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
        // Instance variables
        private const string OWNER1 = "Chantenique: 084 557 3751";
        private const string OWNER2 = "Angelique:   074 992 7807";

        private OleDbConnection conn;       // Database connection
        private string DB = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = ";
        private string DBloc, target;       // Location variables
        private bool   backup;              // Flag to backup database and settings
        private bool   Loading;             // Flag to prevent method triggers while loading
        private string bg = "";             // Background setting
        private bool   loginFail;           // Flag for login failure, prevents operation continuance

        private int currentBooking;         // Booking currently selected, used to display, edit, delete and finalise bookings
        private string cName, bDate;        // Client name and booking date


        //***************************************************************************//
        // ======================= FORM LOAD AND CLOSE EVENTS ====================== //

        public frmMain()
        {//------------------------------------------------------------------------------------------------------------
            DBloc = Directory.GetCurrentDirectory();
            if (!File.Exists(DBloc + @"\ChaliqueNailStudio.accdb"))
                DBloc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Chalique Nail Studio";
            if (!File.Exists(DBloc + @"\ChaliqueNailStudio.accdb"))
            {
                try
                {
                    if (MessageBox.Show("The database file cannot be found. Do you want to select a backed up file?", "Database Not Found", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        OpenFileDialog databasePicker = new OpenFileDialog();
                        databasePicker.Title = "Select the Database file";
                        databasePicker.Filter = "Access Database files (*.accdb)|*.accdb";
                        databasePicker.InitialDirectory = @"C:\";
                        if (databasePicker.ShowDialog() == DialogResult.OK)
                        {
                            File.Copy(databasePicker.FileName, DBloc + @"\ChaliqueNailStudio.accdb", true);
                        }
                        else throw new Exception();
                    }
                    else throw new Exception();
                }
                catch (Exception)
                {
                    MessageBox.Show("The program cannot run without the database. Please contact an administrator to restore the database", "Fatal error");
                    Environment.Exit(0);
                }
            }

            DB += DBloc + @"\ChaliqueNailStudio.accdb";
            conn = new OleDbConnection(DB);

            // Initialise login form
            loginFail = false;
            Login login = new Login(conn);
            login.ShowDialog();

            if (login.Canceled)
            {
                // Exit immediately if login process is canceled on startup
                loginFail = true;
                Environment.Exit(0);
            }

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
                // Prevents events being triggered during the loading process
                Loading = true;
                
                DateRangeEventArgs g = new DateRangeEventArgs(dateSelect.TodayDate, dateSelect.TodayDate);
                dateSelect_DateSelected(dateSelect, g);

                // if settings file does not exist, create a new one
                if (!File.Exists(DBloc + @"\settings.cns"))
                {
                    StreamWriter w = File.CreateText(DBloc + @"\settings.cns");
                    w.Write("DB request backup ;true\r\nDB backup location ;\r\nSelected background; 2");
                    w.Close();
                }

                // Load the settings
                StreamReader r = File.OpenText(DBloc + @"\settings.cns");
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


                // Checks backup setting and backup location.
                if (backup)
                    if (target == null || target == "" || !Directory.Exists(target))
                        if (MessageBox.Show("No backup location is chosen. Do you wish to choose a backup location?", "Backup", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            folderBrowserDialog1.SelectedPath = DBloc;
                            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                            {
                                target = folderBrowserDialog1.SelectedPath;
                                r.Close();
                                Loading = false;
                                writeSettings();
                            }
                        }
                r.Close();
                Loading = false;    // Loading completed, processes continue as normal
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backup)
                backupDB(); //Do this also on a daily basis
            writeSettings();
        }



        //************************* Write the settings to the settings file
        private void writeSettings()
        {
            if (!Loading)
            {
                StreamWriter w = File.CreateText(DBloc + @"\settings.cns");
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



        //************************* Create a backup of the database
        private void backupDB()
        {
            if (target == "" || target == null)
                target = DBloc;

            File.Copy(DBloc + @"\ChaliqueNailStudio.accdb", target + @"\ChaliqueNailStudio.Backup.accdb", true);
            if (File.Exists(DBloc + @"\logfile.txt"))
                File.Copy(DBloc + @"\logfile.txt", target + @"\logfile.Backup.txt", true);
        }



        //************************* Refresh the bookings table
        private void bookingsRefresh_Tick(object sender, EventArgs e)
        {
            LoadBookings();
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

        //************************* Change the button colours to match the theme
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

        //************************* Open the user management dialog
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

        //************************* Show the help manual ***Message box until help manual is compiled
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //helpMethod();
            openHelpMenu();
        }

        private void helpMethod()
        {
            string help = "First select a date on the calendar.\n" +
                          "Then select a booking from the list.\n" +
                          "If there are no bookings in the list you need to create one,\nclick the New Booking button.";
            MessageBox.Show(help, "HELP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void openHelpMenu()
        {
            if (File.Exists(DBloc + @"\Manual\Help Manual.pdf"))
                System.Diagnostics.Process.Start(DBloc + @"\Manual\Help Manual.pdf");
            else if (File.Exists(DBloc + @"\Manual\Help Manual.docx"))
                System.Diagnostics.Process.Start(DBloc + @"\Manual\Help Manual.docx");
            else MessageBox.Show("No help file has been found!");
        }

        //************************* Message box containing details about the probgram
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = "Chalique Nail Studio\nVersion: 1.0\n© 2017 Analysis Paralysis - Group 21\r\n\r\n"
                            + "Project developers:\r\n"
                            + "Robin de Klerk   \t 079 030 3144 \r\n"
                            + "Ahmed Yusuf Patel\t 063 448 3161 \r\n"
                            + "Nicole Roberts   \t 084 571 7752 \r\n"
                            + "Franco Verster   \t 083 254 1119 \r\n"
                            + "Arno Pretorius   \t 074 748 4914 \r\n"
                            + "Naomi Pretorius  \t 060 780 9777";
            MessageBox.Show(about, "About Chalique Nails Studio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //************************* Close the program
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //************************* Toggle the backup setting
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
            writeSettings();
        }

        //************************* Change the Database backup location, can be changed to a removable device
        private void changeBackupLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                target = folderBrowserDialog1.SelectedPath;
                writeSettings();
            }
        }

        //***************************************************************************//
        // ========================== LOAD BOOKING EVENTS ========================== //

        //************************* Reload the bookings table when selected date changes
        private void dateSelect_DateSelected(object sender, DateRangeEventArgs e)
        {
            LoadBookings();
        }



        //************************* Load all the bookings into the bookings table for the 5 days after the date selected
        private void LoadBookings()
        {
            // Display in grid view for selection (Table Layout Panel, tlpBookings)
            DateTime date = dateSelect.SelectionRange.Start;

            // Remove bookings textboxes from the tablelayoutpanel
            if (!Loading)
                for (int j = 0; j < 5; j++)
                    for(int i = 1; i < 20; i++)
                    {
                        Control a;
                        if ((a = tlpBookings.GetControlFromPosition(j, i)) != null)
                            tlpBookings.Controls.Remove(a);
                    }

            txtDay1.Text = date.ToShortDateString();
            RetrieveBookings(date, 0);

            date = date.AddDays(1);
            txtDay2.Text = date.ToShortDateString();
            RetrieveBookings(date, 1);

            date = date.AddDays(1);
            txtDay3.Text = date.ToShortDateString();
            RetrieveBookings(date, 2);

            date = date.AddDays(1);
            txtDay4.Text = date.ToShortDateString();
            RetrieveBookings(date, 3);

            date = date.AddDays(1);
            txtDay5.Text = date.ToShortDateString();
            RetrieveBookings(date, 4);
        }



        //************************* Load the bookings for the specified date into the bookings table
        private void RetrieveBookings(DateTime date, int col)
        {
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
                Color tColor = Color.White;
                if ((techID = int.Parse(read["EmployeeID"].ToString())) != 0)
                {
                    com = new OleDbCommand($@"SELECT EmployeeName FROM Employees WHERE EmployeeID = {techID}", conn);
                    r = com.ExecuteReader();
                    r.Read();
                    tech = r[0].ToString();
                }
                else tech = "No preference";

                com = new OleDbCommand($"SELECT * FROM Payment WHERE BookingID = {bID}", conn);
                OleDbDataReader read1 = com.ExecuteReader();

                if (read1.Read())
                {
                    tColor = Color.PaleGreen;
                }

                TextBox t1 = new TextBox()
                {
                    Multiline = true,
                    Text = $"{cName}\r\n{bTime}      #{bID}\r\n{tech}",
                    Name = "b" + bID,
                    ReadOnly = true,
                    BackColor = tColor
                };
                t1.Height = 46;
                t1.Click += new EventHandler(SelectBooking_Click);
                tlpBookings.Controls.Add(t1, col, c++);
            }

            conn.Close();
        }



        //***************************************************************************//
        // ========================== BUTTON CLICK EVENTS ========================== //

        //************************* Open the Admin dialog
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
                    Admin admin = new Admin(conn, login.user, target);

                    admin.ShowDialog();
                }
                else MessageBox.Show("You do not have access to the Admin system!", "ACCESS DENIED");
            }
        }



        //************************* Open the Clients dialog
        private void btnClients_Click(object sender, EventArgs e)
        {
            Client_Management cManagement = new Client_Management(conn);
            cManagement.Show();
            LoadBookings();
        }



        //************************* Open the New booking dialog
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



        //************************* Open the New booking dialog, sending the booking to be edited
        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            // Open the New Booking form, sending the Booking ID
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
                MessageBox.Show("An error has occured while attempting to edit the booking.\r\n" + ex, "Edit error");
            }
        }



        //************************* Delete the selected booking
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you want to cancel the booking for {cName} on {bDate} ?", "Confirm cancelation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand($"SELECT * FROM Payment WHERE BookingID = {currentBooking}", conn);
                OleDbDataReader read = cmd.ExecuteReader();

                if (!read.Read())
                {
                    try
                    {
                        cmd = new OleDbCommand($"DELETE * FROM TreatmentDetailPerBooking WHERE BookingID = {currentBooking}", conn);
                        cmd.ExecuteNonQuery();
                        cmd = new OleDbCommand($"DELETE * FROM Bookings WHERE BookingID = {currentBooking}", conn);
                        cmd.ExecuteNonQuery();

                        conn.Close();
                        LoadBookings();
                        MessageBox.Show("The booking has been cancelled!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There was an error while deleting the booking!\r\n" + ex, "Error deleting booking");
                    }
                }
                else MessageBox.Show("This booking has already been finalised. Cant Cancel.", "Cancellation error");
            }
            conn.Close();

            txtBookDetails.Visible = false;
            btnEditBooking.Visible = false;
            btnCancel.Visible = false;
            btnFinish.Visible = false;
        }



        //************************* Open the Email settings dialog
        private void changeEmailSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginFail = false;
            Login login = new Login(conn);
            login.ShowDialog();

            if (login.Canceled)
                loginFail = true;

            if (!loginFail)
            {
                if (login.acclvl == 1 || login.acclvl == 0)
                {
                    Edit_email_settings myEmailsettings = new Edit_email_settings();
                    myEmailsettings.Show();
                }
                else MessageBox.Show("You do not have access to the Admin system!", "ACCESS DENIED");
            }
        }



        //************************* Open the Email messages dialog
        private void changeDefaultMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginFail = false;
            Login login = new Login(conn);
            login.ShowDialog();

            if (login.Canceled)
                loginFail = true;

            if (!loginFail)
            {
                if (login.acclvl == 1 || login.acclvl == 0)
                {
                    Change_Email_Message myDefaultEmail = new Change_Email_Message();
                    myDefaultEmail.Show();
                }
                else MessageBox.Show("You do not have access to the Admin system!", "ACCESS DENIED");
            }
        }



        //************************* Open the Finish bookings dialog, sending the booking ID
        private void btnFinish_Click(object sender, EventArgs e)
        {
            // Open the Finish booking dialog. send current booking number

            conn.Open();
            OleDbCommand cmd = new OleDbCommand($"SELECT * FROM Payment WHERE BookingID = {currentBooking}", conn);
            OleDbDataReader read = cmd.ExecuteReader();

            if (!read.Read())
            {
                conn.Close();
                Finish_booking input = new Finish_booking(conn, currentBooking);
                input.ShowDialog();

                txtBookDetails.Visible = false;
                btnEditBooking.Visible = false;
                btnCancel.Visible = false;
                btnFinish.Visible = false;
            }
            else MessageBox.Show("This booking has already been finalised. Cannot Finalise again.", "Finalisation error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            conn.Close();
        }

        private void frmMain_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            helpMethod();
        }

        //***************************************************************************//
        // ============================= BOOKING EVENTS ============================ //

        //************************* Set the current booking
        private void SelectBooking_Click(object sender, EventArgs e)
        {
            // Select booking detail for the selected booking, -> buttons visible
            txtBookDetails.Text = ""; // Detail text of booking, including treatments
            txtBookDetails.Visible = true;
            btnEditBooking.Visible = true;
            btnCancel.Visible = true;
            btnFinish.Visible = true;

            currentBooking = int.Parse((sender as TextBox).Text.Split('\r')[1].Split('#')[1]);
            try
            {
                LoadBookingData();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error showing booking details:\r\n" + ex, "Error");
            }
        }



        //************************* Show the detail for the current booking
        private void LoadBookingData()
        {
            // Load booking detail into txtBookDetails, including treatments
            if (currentBooking == 0)
                throw new Exception("No booking selected");
            conn.Open();

            OleDbCommand cmd = new OleDbCommand($@"SELECT * FROM Bookings WHERE BookingID = {currentBooking}", conn);
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
                    bTech = r["EmployeeName"].ToString();
                }
                else bTech = "No preference";
                txtBookDetails.Text = $"Client:\t{cName}\r\nTel:\t{cNum}\r\nEmail:\t{cEmail}\r\nDate:\t{bDate}   Time:  {bTime}\r\nTechnician:\t{bTech}\r\nTimes estimate:\t{bTimeEst} minutes\r\n\r\nTreatments:";

                com = new OleDbCommand($@"SELECT TreatmentID FROM TreatmentDetailPerBooking WHERE BookingID = {currentBooking}", conn);
                r = com.ExecuteReader();
                while (r.Read())
                {
                    cmd = new OleDbCommand($@"SELECT * FROM Treatments WHERE TreatmentID = {r["TreatmentID"].ToString()}", conn);
                    read = cmd.ExecuteReader();
                    read.Read();
                    txtBookDetails.AppendText($"\r\n-{read["Description"].ToString()}\tR{read["TreatmentCost"].ToString()}");
                }
            }
            else
                throw new Exception("Error reading from the Bookings table.");
            conn.Close();
        }



        //***************************************************************************//
        // ==========================              EVENTS ========================== //



    }
}
