using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using Chalique_Nail_Studio.Properties;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Net.Sockets;

namespace Chalique_Nail_Studio
{
    public partial class New_Booking : Form
    {
        private OleDbConnection conn;
        private string DBloc;


        public bool Complete { get; set; }      // Booking is  fully completed
        private bool selected = false;        // Client is selected
        private bool edit = false;        // Existing booking is being edited
        private bool editLoading = false;       // True while the booking to be edited is still loading
        private bool clientEdit = false;        // Client details have been altered
        public DateTime Date { get; set; }      // Date of booking
        public static int ID { get; set; }      // Booking ID
        public int clientID;                    // Client ID
        private string clientName;              // Name of client
        private string descript;                // Description of booking
        private int techID;                     // Employee ID of preffered technician; 0 if no preference

        public New_Booking(OleDbConnection con)
        {
            commonConstructor(con);
            clientName = "";
            descript   = "";
            Complete   = false;
        }
        //if date has been selected
        public New_Booking(OleDbConnection con, DateTime bookingDate)
        {
            commonConstructor(con);
            Date = bookingDate;
            clientName = "";
            descript   = "";
            //set date to date received
            pickDate.SelectionStart = bookingDate;
            Complete = false;
        }
        //if editing a booking
        public New_Booking(OleDbConnection con, int bookingID)
        {
            commonConstructor(con);

            ID = bookingID;

            try
            {
                editLoading = true;
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Bookings WHERE BookingID = " + ID, conn);
                OleDbDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    clientID = read.GetInt32(1);
                    Date     = read.GetDateTime(2);
                    techID   = read.GetInt32(3);
                    pickDate.SetDate(read.GetDateTime(2));
                    string bTime = (read.GetDateTime(2)).ToString("HH:mm");
                    cmbTime.SelectedIndex = cmbTime.FindString(bTime);
                    int timeEstimate = int.Parse(read["TimeEstimate"].ToString());
                    if (timeEstimate != 0)
                    {
                        cmbTimeEstimate.SelectedIndex = cmbTimeEstimate.FindString($"{timeEstimate}");
                    }

                    // Retrieve client details for booking
                    selected = true;
                    cmd  = new OleDbCommand("SELECT * FROM Clients WHERE ClientID = " + clientID, conn);
                    read = cmd.ExecuteReader();
                    read.Read();
                    txtClientName.Text = clientName = read["ClientName"].ToString();
                    txtClientNumber.Text = read["TelNumber"].ToString();
                    txtClientEmail.Text  = read["EmailAddress"].ToString();


                    if (techID != 0)
                    {
                        cmd = new OleDbCommand($@"SELECT EmployeeName FROM Employees WHERE EmployeeID = {techID}", conn);
                        read = cmd.ExecuteReader();
                        read.Read();
                        cmbPrefTech.SelectedIndex = cmbPrefTech.FindString(read["EmployeeName"].ToString());
                    }
                    else cmbPrefTech.SelectedIndex = 0;

                    cmd = new OleDbCommand("SELECT * FROM TreatmentDetailPerBooking WHERE BookingID = " + ID, conn);
                    read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        OleDbCommand com = new OleDbCommand($"SELECT * FROM Treatments WHERE TreatmentID = " + read["TreatmentID"].ToString(), conn);
                        OleDbDataReader read1 = com.ExecuteReader();
                        read1.Read();
                        lbxTreatmentList.Items.Add(read1["Description"].ToString());
                    }
                }
                else throw new Exception("No booking found for Booking ID " + ID);
                
                conn.Close();
                editLoading = false;
                edit     = true;
                Complete = true;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("An error has occured while editing the booking: " + ex);
                this.Close();
            }
        }

        // This is shared by all constructors
        private void commonConstructor(OleDbConnection con)
        {
            // Component initialization
            InitializeComponent();
            conn = con;
            DBloc = Directory.GetCurrentDirectory();
            if (!File.Exists(DBloc + @"\ChaliqueNailStudio.accdb"))
                DBloc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Chalique Nail Studio";
            commonConstructor();
        }
        // This is shared by all constructors
        private void commonConstructor()
        {
            Clear();

            // Preferred technician comboBox
            conn.Open();
            cmbPrefTech.Items.Clear();
            cmbPrefTech.Items.Add("No preference");
            // Select all employees that are techicians
            OleDbCommand cmd = new OleDbCommand("SELECT EmployeeName, IsTech FROM Employees WHERE IsTech = TRUE", conn);
            OleDbDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                cmbPrefTech.Items.Add(read[0].ToString());  // Add them to the technician list
            }
            cmbTime.SelectedIndex = 6;
            cmbTimeEstimate.SelectedIndex = 1;

            // Treatment list combobox
            cmbTreatment.Items.Clear();
            cmd = new OleDbCommand("SELECT Description FROM Treatments", conn);
            read = cmd.ExecuteReader();
            while(read.Read())
                cmbTreatment.Items.Add(read["Description"].ToString());

            // Name textbox autocomplete settings
            txtClientName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtClientName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbTreatment.DropDownWidth = 250;

            conn.Close();

            // Style preset
            StreamReader r = File.OpenText(DBloc + @"\settings.cns");
            r.ReadLine();
            r.ReadLine();
            string[] temp;
            if ((temp = r.ReadLine().Split(';'))[1] != "")
                switch (int.Parse(temp[1]))
                {
                    case 1:
                        this.BackgroundImage = Resources.Light_Purple;
                        button_colour(Color.Thistle);
                        break;
                    case 2:
                        this.BackgroundImage = Resources.Bright_Pink;
                        button_colour(Color.Pink);
                        break;
                    case 3:
                        this.BackgroundImage = Resources.Light_Pink;
                        button_colour(Color.Pink);
                        break;
                    default: break;
                }
            r.Close();
            
            //SuggestStrings will have the logic to return array of strings either from cache/db
            try
            {
                string[] arr = SuggestNames(txtClientName.Text);

                if (arr != null)
                {
                    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                    collection.AddRange(arr);

                    txtClientName.AutoCompleteCustomSource = collection; //************************** UNTESTED
                }
            }
            catch (Exception)
            { }
        }
        private void button_colour(Color c)
        {
            // Include here all buttons that will have their colour changed ***
            btnNewBooking.BackColor   = c;
            btnCancel.BackColor       = c;
            btnClear.BackColor        = c;
            lblTimeEstimate.BackColor = c;
        }

        //***************************************************************************//
        // ======================= SEARCH CLIENTS EVENTS =========================== //

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {
            if (!editLoading)
                if (selected)
                {
                    clientEdit = true;
                }
        }

        private string[] SuggestNames(string t)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT ClientName FROM Clients ORDER BY ClientName", conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> names = new List<string>();
            while(reader.Read())
            {
                names.Add(reader[0].ToString());
            }
            conn.Close();
            if (names.Count > 0)
                return names.ToArray();
            else return null;
        }

        private void txtClientName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                selectClient();
        }

        //***************************************************************************//
        // ========================== SELECT CLIENT EVENT ========================== //

        private void selectClient()
        {
            if (txtClientName.Text != "")
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand($"SELECT * FROM Clients WHERE ClientName LIKE '%{txtClientName.Text}%'", conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtClientEmail.Text  = reader["EmailAddress"].ToString();
                    txtClientNumber.Text = reader["TelNumber"].ToString();
                    clientName = txtClientName.Text;
                    clientID   = int.Parse(reader["ClientID"].ToString());
                    selected   = true;
                    cmbTime.Focus();
                }

                conn.Close();
            }
        }

        //***************************************************************************//
        // ========================== GATHER DETAIL EVENTS ========================= //

        private void txtClientNumber_TextChanged(object sender, EventArgs e)
        {
            if (!editLoading)
                if (selected)
                {
                    clientEdit = true;
                }
        }

        private void cmbTreatment_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void addClient()
        {
            clientName = txtClientName.Text;
            if (MessageBox.Show($"Do you want to add this client?\r\nName: {clientName}\tCell number: {txtClientNumber.Text}\r\nEmail: {txtClientEmail.Text}", "New Client", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conn.Open();
                // Write new client details to table
                OleDbCommand cmd = new OleDbCommand($"INSERT INTO Clients (ClientName, TelNumber, EmailAddress) VALUES('{clientName}', '{txtClientNumber.Text}', '{txtClientEmail.Text}')", conn);
                cmd.ExecuteNonQuery();

                // Read Client ID and set client as selected
                cmd = new OleDbCommand($"SELECT ClientID From Clients WHERE ClientName = '{clientName}'", conn);
                OleDbDataReader read = cmd.ExecuteReader();
                read.Read();
                clientID = int.Parse(read[0].ToString());

                selected = true;
                clientEdit = false;
                conn.Close();
            }
            else throw new Exception("You must first select a client or add a new client.");
        }

        //***************************************************************************//
        // ========================= FINISH BOOKING EVENTS ========================= //

        public void CompletionDetails()
        {
            // Notification method
            try
            {
                if (Complete)
                {
                    // Send notification of completion to client
                    
                    //------------------------------------------------Email functionality added here------------------------------------------------
                    //Reads email and password from a textfile
                    string details = "";
                    string emailText = "";
                    string email = "";
                    string password = "";
                    

                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.EnableSsl = true;
                    client.Timeout = 60000;
                    client.Port = 587;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                        
                    StreamReader myReader = new StreamReader(DBloc + "\\emailDetails.cns");

                    while (!myReader.EndOfStream)
                    {
                        details = myReader.ReadLine();
                    }

                    string[] allDetails = details.Split(':');
                    email = allDetails[0].ToString();
                    password = allDetails[1].ToString();
                    myReader.Close();

                    client.Credentials = new System.Net.NetworkCredential(email, password);
                    MailMessage msg = new MailMessage();

                    msg.To.Add(txtClientEmail.Text);
                    msg.From = new MailAddress("chaliquenailstudio@gmail.com");
                    //change email heading and body. Body reads from textfile when it is created
                    msg.Subject = "Appointment at Chalique Nail Studio";

                    myReader = new StreamReader(DBloc + "\\EmailMessage.cns");
                    emailText = myReader.ReadToEnd();
                    myReader.Close();

                    client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                    msg.Body = emailText + $"Booking number:\t{ID}\r\nDate of Booking:\t{Date.ToString("dddd, dd MMMM, yyyy")}\r\nTime of Booking:\t{cmbTime.Text}\r\nPreferred technician:\t{cmbPrefTech.Text}";
                    client.SendMailAsync(msg);
                    
                }
                else
                {
                    MessageBox.Show("The booking is not complete.");
                }
            }
            catch (Exception ex)
            {
                notifyDone.ShowBalloonTip(1500, "Booking not Completed!", $"{ex}", ToolTipIcon.Error);
            }
        }
        
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the unique identifier for this asynchronous operation.
            //String token = (string)e.UserState;

            if (e.Cancelled)
            {  }
            if (e.Error != null)
            {  }
            else
            {
                MessageBox.Show($"Booking {ID} notification sent");
            }
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            try
            {
                // Client name
                if (txtClientName.Text != "" && !selected)
                    selectClient();
                else if (txtClientName.Text == "")
                    throw new Exception("Please indicate a client for the treatment");
                
                // Check all controlls for values
                if (lbxTreatmentList.Items.Count <= 0)
                {
                    throw new Exception("Please fill all the fields");
                }

                if (txtClientEmail.Text != "")
                {
                    var test = new MailAddress(txtClientEmail.Text);
                }

                if (txtClientNumber.Text != "")
                    try
                    {
                        string t = txtClientNumber.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("+", "");
                        Int64 test1 = Int64.Parse(t);
                    }
                    catch (OverflowException)
                    {
                        throw new Exception("The telephone number is too long.");
                    }
                    catch (FormatException)
                    {
                        throw new Exception("The telephone number may not contain letters or special characters.");
                    }

                if (!selected)
                    addClient();

                OleDbCommand com;
                if (clientEdit)
                {
                    if (selected)
                    {
                        // Update Clients table with new info
                        conn.Open();
                        string message = $"UPDATE Clients SET ClientName = '{txtClientName.Text}', TelNumber = '{txtClientNumber.Text}', EmailAddress = '{txtClientEmail.Text}' WHERE ClientID = {clientID}";
                        //MessageBox.Show(message);
                        com = new OleDbCommand(message, conn);
                        com.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                int hour, min;
                hour = int.Parse(cmbTime.Text.Split(':')[0]);
                min = int.Parse(cmbTime.Text.Split(':')[1]);
                Date = Convert.ToDateTime(pickDate.SelectionStart.ToShortDateString()).AddHours(hour).AddMinutes(min);
                //Ask if all input is correct
                DialogResult d = MessageBox.Show("Is the booking correct?\n" + $"{clientName}\t{Date}\n{descript}", "Booking entry", MessageBoxButtons.YesNo);
                if (!(d == DialogResult.Yes))
                    throw new Exception("");


                int timeEst;
                switch (cmbTimeEstimate.SelectedIndex)
                {
                    case 0:     timeEst = 30;
                        break;
                    case 1:     timeEst = 60;
                        break;
                    case 2:     timeEst = 90;
                        break;
                    case 3:     timeEst = 120;
                        break;
                    case 4:     timeEst = 150;
                        break;
                    default:    timeEst = 0;
                        break;
                }

                // Store data
                if (edit)
                {
                    // Update booking and client tables
                    conn.Open();
                    com = new OleDbCommand($"UPDATE Bookings SET (BookingDateTime = #{Date}#, EmployeeID = {techID}, TimeEstimate = {timeEst}) WHERE BookingID = {ID}", conn);
                    //com.ExecuteNonQuery();
                    // Delete old entries from TreatmentDetailPerBooking
                    com = new OleDbCommand("DELETE * FROM TreatmentDetailPerBooking WHERE BookingID = " + ID, conn);
                    com.ExecuteNonQuery();
                }
                else
                {
                    // Insert into booking table
                    conn.Open();
                    com = new OleDbCommand($"INSERT INTO Bookings (ClientID, BookingDateTime, EmployeeID, TimeEstimate) VALUES({clientID}, #{Date}#, {techID}, {timeEst})", conn);
                    com.ExecuteNonQuery();
                    com = new OleDbCommand($"SELECT BookingID FROM Bookings WHERE ClientID = {clientID} AND BookingDateTime = #{Date}#", conn);
                    OleDbDataReader read = com.ExecuteReader();
                    read.Read();
                    ID = int.Parse(read[0].ToString());
                }
                
                foreach (var s in lbxTreatmentList.Items)
                {
                    // Read data from the treatments table to store in the TreatmentDetailPerBooking table
                    com = new OleDbCommand($"SELECT * FROM Treatments WHERE Description LIKE '%{s}%'", conn);
                    OleDbDataReader read = com.ExecuteReader();
                    read.Read();
                    string tID = read["TreatmentID"].ToString();
                    com = new OleDbCommand($"INSERT INTO TreatmentDetailPerBooking VALUES ({ID}, {tID}) ", conn);
                    com.ExecuteNonQuery();
                }


                //If all data could be stored
                conn.Close();
                Complete = true;
                if (txtClientEmail.Text != "")
                {
                    CompletionDetails();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                if (ex.Message != "")
                    MessageBox.Show("Please make sure all the data has been input\r\n//"+ ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        //***************************************************************************//
        // =============================== CANCEL EVENT ============================ //

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Complete = false;
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            commonConstructor();
            txtClientName.Focus();
        }
        private void Clear()
        {
            // Reset all input fields and variables
            txtClientName.Clear();
            txtClientNumber.Clear();
            txtClientEmail.Clear();

            selected = false;
            Complete = false;
            edit = false;
            clientEdit = false;
            clientName = "";
            clientID = 0;
            ID = 0;
            descript = "";
            techID = 0;

            cmbTime.SelectedIndex = -1;
            cmbTreatment.SelectedIndex = -1;
            cmbTimeEstimate.SelectedIndex = -1;
            cmbPrefTech.SelectedIndex = -1;

            pickDate.SelectionStart = DateTime.Now;

            lbxTreatmentList.Items.Clear();
        }

        private string CheckDoubleBookings(DateTime slot)
        {

            DateTime time;

            time = slot;

            return "";

        }

        private void lbxTreatmentList_DoubleClick(object sender, EventArgs e)
        {
            if (lbxTreatmentList.SelectedItem != null)
            {
                cmbTreatment.Items.Add(lbxTreatmentList.SelectedItem);
                lbxTreatmentList.Items.Remove(lbxTreatmentList.SelectedItem);
            }
        }

        private void DropDown(object sender, EventArgs e)
        {
            (sender as ComboBox).DroppedDown = true;
        }

        private void cmbPrefTech_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPrefTech.SelectedIndex == 0)
            {
                // Select employee ID 0 // no preference
                techID = 0;
            }
            else
            {

                if (!editLoading)
                {
                    // Read employee ID by selected name
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand($"SELECT EmployeeID From Employees WHERE EmployeeName LIKE '%{cmbPrefTech.Text}%'", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    read.Read();
                    techID = int.Parse(read[0].ToString());
                    conn.Close();
                }
            }
        }

        private void cmbTreatment_Click(object sender, EventArgs e)
        {
            if (cmbTreatment.SelectedIndex != -1)
            {
                // Add to description
                if (cmbTreatment.SelectedText != "")
                {
                    lbxTreatmentList.Items.Add(cmbTreatment.Text);
                    cmbTreatment.Items.Remove(cmbTreatment.SelectedItem);
                    DropDown(sender, e);
                }
            }
            else DropDown(sender, e);
        }

        private void cmbTreatment_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbTreatment.SelectedIndex != -1)
            {
                // Add to description
                if (cmbTreatment.SelectedText != "")
                {
                    lbxTreatmentList.Items.Add(cmbTreatment.Text);
                    cmbTreatment.Items.Remove(cmbTreatment.SelectedItem);
                    DropDown(sender, e);
                }
            }
        }

        private void pickDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (pickDate.SelectionStart.DayOfWeek == DayOfWeek.Saturday)
            {
                cmbTime.Items.Clear();
                string[] temp = { "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30" };
                cmbTime.Items.AddRange(temp);
                cmbTime.SelectedIndex = 6;
                cmbTimeEstimate.SelectedIndex = 0;
            }
            else if (cmbTime.Items.Count < 13)
            {
                cmbTime.Items.Clear();
                string[] temp = { "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30" };
                cmbTime.Items.AddRange(temp);
                cmbTime.SelectedIndex = 6;
                cmbTimeEstimate.SelectedIndex = 0;
            }
        }
    }
}