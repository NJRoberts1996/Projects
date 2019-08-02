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

namespace Chalique_Nail_Studio
{
    public partial class Finish_booking : Form
    {
        public OleDbConnection conn;
        public string DBloc;

        private int currentBooking;
        private double totalCost = 0;
        public bool Complete;

        public double individualCost = 0;
        public double price1;

        // global variables 

        public int bookID;
        public int amountPaid;
        public string paymentMethod;

        public DateTime dt;

        // global variables(payment)

        public Finish_booking(OleDbConnection con, int bookingID)
        {
               
            InitializeComponent();
       
            conn = con;
            DBloc = Directory.GetCurrentDirectory();
            if (!File.Exists(DBloc + @"\ChaliqueNailStudio.accdb"))
                DBloc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Chalique Nail Studio";

            currentBooking = bookingID;
            txtBookingNumber.Text = $"{currentBooking}";
            comboxBoxData();
            readData();
            Style();

            txtFinalPrice.Enabled = true;
            // allow userbility with textbox     

        }
        private void Style()
        {
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
        }
        private void button_colour(Color c)
        {
            // Include here all buttons that will have their colour changed

            btnFinalize.BackColor = c;
            btnCancel.BackColor = c;
            btnAddTreatment.BackColor = c;
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {

            try
            {

                // finalizes the booking 

                Complete = true;

                //notifyDone.ShowBalloonTip(1500, "Booking Finalised", $"The booking for {clientName} has been finalised and payment received.\r\nBooking finalised", ToolTipIcon.None);

                this.Close();

                paymentMethod = cmbPayment.Text;

                amountPaid = Convert.ToInt16(txtFinalPrice.Text);

                dt = DateTime.Now;

                conn.Open();

                OleDbDataAdapter adapt = new OleDbDataAdapter(@"SELECT BookingID, AmountPaid, PaymentMethod, DateOfPayment FROM Payment", conn);

                OleDbCommand cmd = new OleDbCommand(@"INSERT Into Payment(BookingID, AmountPaid, PaymentMethod, DateOfPayment) Values ( " + currentBooking + " , '" +
                amountPaid + "', '" + paymentMethod + "' , '" + dt + "')", conn);

                adapt.InsertCommand = cmd;
                adapt.InsertCommand.ExecuteNonQuery();
                
                // Inserts data into Payment table 
                
                OleDbCommand cmds = new OleDbCommand("DELETE * FROM TreatmentDetailPerBooking WHERE BookingID = " + currentBooking, conn);
                cmds.ExecuteNonQuery();

                foreach (var s in lbxTreatments.Items)
                {
                    // Read data from the treatments table to store in the TreatmentDetailPerBooking table

                    OleDbCommand cm = new OleDbCommand($"SELECT * FROM Treatments WHERE Description LIKE '%{s}%'", conn);

                    OleDbDataReader read = cm.ExecuteReader();

                    read.Read();

                    string tID = read["TreatmentID"].ToString();

                    OleDbCommand c = new OleDbCommand($"INSERT INTO TreatmentDetailPerBooking VALUES ({currentBooking}, {tID}) ", conn);
                    c.ExecuteNonQuery();
                }

                conn.Close();

               // MessageBox.Show("The booking was finalised on: " + dt);

            }

            catch(Exception exc)
            {
                conn.Close();
                MessageBox.Show("An error occured: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Complete = false;
            this.Close();

            MessageBox.Show("Finish booking cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // notification

        }

        public void comboxBoxData()
        {
            try
            {

         
                string holder = "";

                conn.Open();
                   
                string testQuery = "SELECT Description FROM Treatments";

                OleDbCommand cmds = new OleDbCommand(testQuery, conn);

                OleDbDataReader drs = cmds.ExecuteReader();

                while (drs.Read())
                {
                    holder = drs["Description"].ToString();

                    cmbTreatments.Items.Add(holder);

                    // populate additional treatment(s) combo box
                }


                conn.Close();
                

            }

            catch (Exception ex)
            {

                conn.Close();
                MessageBox.Show("Finish err 01\r\n"+ ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        public void readData()
        {
            try
            {
                
                conn.Open();

                cmbPayment.SelectedIndex = 0;

                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Bookings WHERE BookingID = " + currentBooking, conn);
                OleDbDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    int clientID = read.GetInt32(1);

                    // Retrieve client details for booking

                    cmd = new OleDbCommand("SELECT * FROM Clients WHERE ClientID = " + clientID, conn);

                    read = cmd.ExecuteReader();
                    read.Read();

                    txtClientName.Text = read["ClientName"].ToString();
                    txtClientNumber.Text = read["TelNumber"].ToString();
                    txtClientEmail.Text = read["EmailAddress"].ToString();

                    cmd = new OleDbCommand("SELECT * FROM TreatmentDetailPerBooking WHERE BookingID = " + currentBooking, conn);

                    read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        OleDbCommand com = new OleDbCommand($"SELECT * FROM Treatments WHERE TreatmentID = " + read["TreatmentID"].ToString(), conn);
                        OleDbDataReader read1 = com.ExecuteReader();

                        read1.Read();

                        string treatment = read1["Description"].ToString();

                        lbxTreatments.Items.Add(treatment);

                        if(cmbTreatments.FindString(treatment) != -1)
                        {

                            cmbTreatments.Items.RemoveAt(cmbTreatments.FindString(treatment));

                        }

                        price1 = double.Parse(read1[2].ToString());

                        totalCost += price1;

                        //totalCost += double.Parse(read1[2].ToString());

                        txtFinalPrice.Text = Convert.ToString(totalCost);

                    }

                    //txtFinalPrice.Text = $"R {totalCost:0.00}"; // Requires testing ***
                }

          
                conn.Close();

                // import data for client name, telephone number and email address based on the client ID


            }

            catch (Exception ex)
            {

                conn.Close();
                MessageBox.Show("Finish err 02\r\n"+ ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnAddTreatment_Click(object sender, EventArgs e)
        {
         
            try
            {

                 if (cmbTreatments.SelectedIndex != -1)
                 {
                     lbxTreatments.Items.Add(cmbTreatments.SelectedItem);

                 }
              

                // List box adds (additions) selected from combox box items to listbox(additions) 

                string value = cmbTreatments.Text;
               
                // retrieving data from the combo box  

                conn.Open();

                OleDbCommand cmd = new OleDbCommand($@"SELECT TreatmentCost FROM Treatments WHERE Description = '{value}'", conn);
                OleDbDataReader rdr = cmd.ExecuteReader();

                rdr.Read();

                price1 = double.Parse(rdr["TreatmentCost"].ToString());

                totalCost += price1;

                txtFinalPrice.Text = Convert.ToString(totalCost);

                conn.Close();

                cmbTreatments.Items.Remove(cmbTreatments.SelectedItem);

            }

            catch (Exception exc)
            {
                conn.Close();
                MessageBox.Show("An error occured!" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

           
            // basic calculation function

        }

        private void lbxTreatments_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            
            if (lbxTreatments.SelectedItem != null)
            {
              
                string value = lbxTreatments.SelectedItem.ToString();

                conn.Open();

                OleDbCommand cmd = new OleDbCommand($@"SELECT TreatmentCost FROM Treatments WHERE Description = '{value}'", conn);
                OleDbDataReader rdr = cmd.ExecuteReader();

                rdr.Read();

                price1 = double.Parse(rdr["TreatmentCost"].ToString());
                totalCost -= price1;

                txtFinalPrice.Text = Convert.ToString(totalCost);

                conn.Close();

                // closes the database 

                cmbTreatments.Items.Add(lbxTreatments.SelectedItem);

                // remove the selected item 

                cmbTreatments.Items.Remove(cmbTreatments.SelectedItem);

                lbxTreatments.Items.Remove(lbxTreatments.SelectedItem);


            }

            else
            {

                MessageBox.Show("Please select a valid treatent to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           

            // Function to double click remove and basic calculation function 
        }

        private void cmbTreatments_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            ///// N/A 

        }
    }
}
