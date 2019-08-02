using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using Chalique_Nail_Studio.Properties;

namespace Chalique_Nail_Studio
{
    public partial class frmMain : Form
    {
        private const string OWNER1 = "Chantenique: 084 557 3751";
        private const string OWNER2 = "Angelique:   074 992 7807";

        private string DB = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = ";
        private string DBloc, target;
        private bool   backup;
        private bool   Loading;
        private string bg = "";
        private OleDbConnection conn;
        private bool   loginFail;

        private int currentBooking;
        private string cName, bDate;
        TextBox[,] booking = new TextBox[5, 20];

        // instance variables 

        public frmMain()
        {//------------------------------------------------------------------------------------------------------------
            DBloc = Directory.GetCurrentDirectory();
            DB += DBloc + @"\ChaliqueNailStudio.accdb";
            conn = new OleDbConnection(DB);

            // Initialise login form
            loginFail = false;
            Login login = new Login(conn);
            login.ShowDialog();
            
            if (login.Canceled)
                loginFail = true;

            InitializeComponent();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            if (loginFail)
            {
                this.Close();
            }
            else
            {
                Loading = true;
                //this.Visible = false;

                DateRangeEventArgs g = new DateRangeEventArgs(dateSelect.TodayDate, dateSelect.TodayDate);
                dateSelect_DateSelected(dateSelect, g);

                if (!File.Exists(DBloc + @"\settings.txt"))
                {
                    StreamWriter w = File.CreateText(DBloc + @"\settings.txt");
                    w.Write("DB request backup ;true\r\nDB backup location ;\r\nSelected background; 2");
                    w.Close();
                }

                StreamReader r = File.OpenText(DBloc + @"\settings.txt");
                string[] temp = r.ReadLine().Split(';');
                backup = Convert.ToBoolean(temp[1]);
                if ((temp = r.ReadLine().Split(';'))[1] != "")
                    target = temp[1];
                if ((temp = r.ReadLine().Split(';'))[1] != "")
                    switch (int.Parse(temp[1]))
                    {
                        case 1: purpleToolStripMenuItem_Click(sender, e);
                            break;
                        case 2: pinkToolStripMenuItem_Click(sender, e);
                            break;
                        case 3: pink2ToolStripMenuItem_Click(sender, e);
                            break;
                        default: break;
                    }

                if (backup)
                    if (target == null || target == "")
                        if (MessageBox.Show("No backup location is chosen. Do you wish to choose a backup location?", "Backup", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            if (folderBrowserDialog1.ShowDialog() == DialogResult.Yes)
                            {
                                target = folderBrowserDialog1.SelectedPath;
                            }
                r.Close();
                Loading = false;
                //this.Visible = true;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backup)
                backupDB(); //Do this also on a daily basis
            writeSettings();
        }

        private void writeSettings()
        {
            if (!Loading)
            {
                StreamWriter w = File.CreateText(DBloc + @"\settings.txt");
                if (backup)
                {
                    w.Write("DB request backup ;true" + "\r\n");
                    if (Directory.Exists(target))
                        w.Write("DB backup location ;" + target + "\r\n");
                    else
                        w.Write("DB backup location ;\r\n");
                }
                else
                {
                    w.Write("DB backup location ;false" + "\r\n");
                    w.Write("DB backup location ;\r\n");
                }

                w.Write("Selected background ;" + bg);
                w.Close();
            }
        }

        private void backupDB()
        {
            if (target == "" || target == null)
                target = DBloc;

            File.Copy(DBloc + @"\ChaliqueNailStudio.accdb", target + @"\ChaliqueNailStudio.Backup.accdb", true);
        }

        private void bookingsRefresh_Tick(object sender, EventArgs e)
        {
            //Refresh the bookings table

        }

        //***************************************************************************//
        // =========================== MENU STRIP EVENTS =========================== //
        //*****=================================================================*****//
        // ======================== BACKGROUND CHANGE EVENTS ======================= //

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.Light_Purple;
            button_colour(Color.Thistle);
            bg = "1";
            writeSettings();
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.Bright_Pink;
            button_colour(Color.Pink);
            bg = "2";
            writeSettings();
        }

        private void pink2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.Light_Pink;
            button_colour(Color.Pink);
            bg = "3";
            writeSettings();
        }

        private void button_colour(Color c)
        {
            txtBookDetails.BackColor = c;
            btnCancel.BackColor      = c;
            btnEditBooking.BackColor = c;
            btnNewBooking.BackColor  = c;
            btnFinish.BackColor      = c;
            btnClients.BackColor     = c;
            btnAdmin.BackColor       = c;
        }

        //*****=================================================================*****//
        // ========================= USER MANAGEMENT EVENTS ======================== //

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Initialise login form
            loginFail = false;
            Login login = new Login(conn);
            login.ShowDialog();

            if (login.Canceled)
            {
                loginFail = true;
            }

            if (!loginFail)
            {
                if (login.acclvl == 1 || login.acclvl == 0)
                {
                    //show the users dialog
                    User_control user = new User_control(conn);
                    user.ShowDialog();
                }
                else MessageBox.Show("You do not have access to the User Management system!", "ACCESS DENIED");
            }
        }

        //*****=================================================================*****//
        // ============================== HELP EVENTS ============================== //

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string help = "First select a date on the calendar.\n" +
                          "Then select a booking from the list.\n" +
                          "If there are no bookings in the list you need to create one,\nclick the New Booking button.";
            MessageBox.Show(help, "HELP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = "Version: 0.1\nThis is a test program only\nDo not use this program as a final version"; //-----
            MessageBox.Show(about, "About Chalique Nails Studio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void disableBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backup)
            {
                backup = false;
                MessageBox.Show("Backups have been disabled", "Toggle Backups");
            }
            else
            {
                backup = true;
                MessageBox.Show("Backups have been enabled", "Toggle Backups");
            }
        }

        private void changeBackupLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                target = folderBrowserDialog1.SelectedPath;
            }
        }

        //***************************************************************************//
        // ========================== LOAD BOOKING EVENTS ========================== //

        private void dateSelect_DateSelected(object sender, DateRangeEventArgs e)
        {
            LoadBookings();
        }

        private void LoadBookings()
        {
            // Get bookings info for 5 days as selected
            // Display in grid view for selection (Table Layout Panel, tlpBookings)
            DateTime date = dateSelect.SelectionRange.Start;
            DateTime date2;

            //remove bookings textboxes from the tablelayoutpanel
            if (!Loading)
                /*foreach (TextBox t in booking)
                {
                    this.Controls.Remove(t);
                }*/
                for (int j = 0; j < 5; j++)
                    for(int i = 1; i < 20; i++)
                    {
                        Control a;
                        if ((a = tlpBookings.GetControlFromPosition(j, i)) != null)
                            tlpBookings.Controls.Remove(a);
                    }

            txtDay1.Text = date.ToShortDateString();
            RetrieveBookings(date, 0);

            date2 = date.AddDays(1);
            txtDay2.Text = date2.ToShortDateString();
            RetrieveBookings(date2, 1);

            date2 = date2.AddDays(1);
            txtDay3.Text = date2.ToShortDateString();
            RetrieveBookings(date2, 2);

            date2 = date2.AddDays(1);
            txtDay4.Text = date2.ToShortDateString();
            RetrieveBookings(date2, 3);

            date2 = date2.AddDays(1);
            txtDay5.Text = date2.ToShortDateString();
            RetrieveBookings(date2, 4);
        }

        private void RetrieveBookings(DateTime date, int col)
        {//------------------------------------------------------------------------------------------------------------
             //display bookings
             //create and array of textboxes, for as many bookings neccessary,
             //  for each day and load the bookings data into them
             //use an array of arrays, load them into tlpBookings

            conn.Open();
            int c = 1;
            OleDbCommand cmd = new OleDbCommand($@"SELECT * FROM Bookings WHERE DateValue(BookingDateTime) = #{date.ToShortDateString()}# ORDER BY BookingDateTime ", conn);
            OleDbDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                OleDbCommand com = new OleDbCommand($@"SELECT * FROM Clients WHERE ClientID = {read["ClientID"].ToString()}", conn);
                OleDbDataReader r = com.ExecuteReader();
                r.Read();

                string bID, cName, bTime, tech;
                int techID;
                bID     = read["BookingID"].ToString();
                cName   = r["ClientName"].ToString();
                bTime   = (Convert.ToDateTime(read["BookingDateTime"].ToString())).TimeOfDay.ToString();
                if ((techID = int.Parse(read["EmployeeID"].ToString())) != 0)
                {
                    com = new OleDbCommand($@"SELECT EmployeeName FROM Employees WHERE EmployeeID = {techID}", conn);
                    r = com.ExecuteReader();
                    r.Read();
                    tech = r[0].ToString();
                }
                else tech = "No preference";


                TextBox t1 = new TextBox()
                {
                    Multiline = true,
                    Text = $"{cName}\t      .{bID}\r\n{bTime}\r\n{tech}",
                    Name = "b" + bID
                };
                t1.Multiline = true; t1.Height = 46;
                t1.Click += new EventHandler(SelectBooking_Click);
                tlpBookings.Controls.Add(t1, col, c++);
            }

            conn.Close();
        }

        //***************************************************************************//
        // ========================== BUTTON CLICK EVENTS ========================== //

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Initialise login form
            loginFail = false;
            Login login = new Login(conn);
            login.ShowDialog();

            if (login.Canceled)
                loginFail = true;
    
            if (!loginFail)
            {
                if (login.acclvl == 1 || login.acclvl == 0)
                {
                    Admin admin = new Admin(conn);

                    admin.ShowDialog();
                }
                else MessageBox.Show("You do not have access to the Admin system!", "ACCESS DENIED");
            }
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            Client_Management cManagement = new Client_Management(conn);
            cManagement.Show();
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {//------------------------------------------------------------------------------------------------------------
            New_Booking booking = new New_Booking(conn);
            booking.ShowDialog();

            if (booking.Complete)
            {             
                //MessageBox.Show("Booking Successful");

                txtBookDetails.Visible = false;
                btnEditBooking.Visible = false;
                btnCancel.Visible = false;
                btnFinish.Visible = false;
                // reload bookings grid
                LoadBookings();
            }
        }

        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            // Open the New Booking form, sending the Booking ID
            if (MessageBox.Show($"Do you want to change the booking for {cName} on {bDate} ?", "Confirm edit booking", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    New_Booking booking = new New_Booking(conn, currentBooking);
                    booking.ShowDialog();
                    if (booking.Complete)
                    {
                        MessageBox.Show("The booking has been successfully changed.");
                    }

                    txtBookDetails.Visible = false;
                    btnEditBooking.Visible = false;
                    btnCancel.Visible = false;
                    btnFinish.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occured while attempting to edit a booking.\r\n" + ex, "Edit error");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you want to cancel the booking for {cName} on {bDate} ?", "Confirm cancelation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand($"DELETE * FROM Bookings WHERE BookingID = {currentBooking}", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new OleDbCommand($"DELETE * FROM TreatmentDetailPerBooking WHERE BookingID = {currentBooking}", conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    LoadBookings();
                    MessageBox.Show("The booking has been cancelled!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while deleting the booking!\r\n"+ex, "Error deleting booking");
                }
            }

            txtBookDetails.Visible = false;
            btnEditBooking.Visible = false;
            btnCancel.Visible = false;
            btnFinish.Visible = false;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            // Open the Finish booking dialog. send current booking number
            Finish_booking input = new Finish_booking(conn, currentBooking);
            input.ShowDialog();

            txtBookDetails.Visible = false;
            btnEditBooking.Visible = false;
            btnCancel.Visible = false;
            btnFinish.Visible = false;
        }

        //***************************************************************************//
        // ============================= BOOKING EVENTS ============================ //

        private void SelectBooking_Click(object sender, EventArgs e)
        {
            // Select booking detail for the selected booking, -> buttons visible
            txtBookDetails.Text = ""; // Detail text of booking, including treatments
            txtBookDetails.Visible = true;
            btnEditBooking.Visible = true;
            btnCancel.Visible = true;
            btnFinish.Visible = true;

            currentBooking = int.Parse((sender as TextBox).Text.Split('\r')[0].Split('.')[1]);
            try
            {
                // Load booking detail into txtBookDetails, including treatments
                if (currentBooking == 0)
                    throw new Exception("No booking selected");
                conn.Open();

                OleDbCommand cmd = new OleDbCommand($@"SELECT ClientID, EmployeeID, BookingDateTime, TimeEstimate FROM Bookings WHERE BookingID = {currentBooking}", conn);
                OleDbDataReader read = cmd.ExecuteReader();
                string cID, cNum, cEmail, bTime, bTech, bTimeEst;
                int techID;

                if (read.Read())
                {
                    OleDbCommand com = new OleDbCommand($@"SELECT * FROM Clients WHERE ClientID = {cID = read["ClientID"].ToString()}", conn);
                    OleDbDataReader r = com.ExecuteReader();
                    r.Read();                    
                    cName = r["ClientName"].ToString();
                    cNum = r["TelNumber"].ToString();
                    cEmail = r["EmailAddress"].ToString();
                    bDate = (read.GetDateTime(2)).ToShortDateString();
                    bTime = (read.GetDateTime(2)).ToShortTimeString();
                    bTimeEst = read["TimeEstimate"].ToString();
                    
                    if ((techID = int.Parse(read["EmployeeID"].ToString())) != 0)
                    {
                        com = new OleDbCommand($@"SELECT EmployeeName FROM Employees WHERE EmployeeID = {techID}", conn);
                        r = com.ExecuteReader();
                        r.Read();
                        bTech = r[0].ToString();
                    }
                    else bTech = "No preference";
                    txtBookDetails.Text = $"Client:\t{cName}\r\nTel:\t{cNum}\r\nEmail:\t{cEmail}\r\nDate:\t{bDate}   Time:  {bTime}\r\nTechnician:\t{bTech}\r\nTimes estimate:\t{bTimeEst} minutes\r\n\r\nTreatments:";

                    com = new OleDbCommand($@"SELECT TreatmentID FROM TreatmentDetailPerBooking WHERE BookingID = {currentBooking}", conn);
                    r = com.ExecuteReader();
                    while(r.Read())
                    {
                        cmd = new OleDbCommand($@"SELECT Description FROM Treatments WHERE TreatmentID = {r["TreatmentID"]}", conn);
                        read = cmd.ExecuteReader();
                        txtBookDetails.AppendText($"\r\n-{read["Description"].ToString()}");
                    }
                }
                else
                    throw new Exception("Error reading from the Bookings table.");
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error showing booking details:\r\n" + ex, "Error");
            }

        }

        //***************************************************************************//
        // ==========================              EVENTS ========================== //


        
    }
}
