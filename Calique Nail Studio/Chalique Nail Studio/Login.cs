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
using System.Net.Mail;

namespace Chalique_Nail_Studio
{
    public partial class Login : Form
    {
        private int inval;
        private OleDbConnection conn;

        public bool Canceled { get; set; }
        public int acclvl { get; set; }
        public string user { get; set; }


        public Login(OleDbConnection con)
        {
            //----- Default constructor for general login -----//
            InitializeComponent();
            Canceled = false;
            conn = con;
        }

        private void edtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool valid = false;
            valid = login(); // Call login method
            if (valid == true)
            {
                // If login is valid close the login dialog
                this.Close();
            }
            else
            {
                // If login fails then give an error and increment fail counter
                MessageBox.Show("The login details are invalid!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inval++;
            }


            if (inval >= 3)
            {
                // If login fails 3 times Notify senior manager

                try
                {
                    //------------------------------------------------Email functionality added here------------------------------------------------
                    //Reads email and password from a textfile
                    string details = "";
                    string email = "";
                    string password = "";

                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.EnableSsl = true;
                    client.Timeout = 60000;
                    client.Port = 587;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;

                    string DBloc = Directory.GetCurrentDirectory();
                    if (!File.Exists(DBloc + @"\ChaliqueNailStudio.accdb"))
                        DBloc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Chalique Nail Studio";


                    if (File.Exists(DBloc + "\\emailDetails.cns"))
                    {
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

                        msg.To.Add("chaliquenailstudio@gmail.com");
                        msg.From = new MailAddress("chaliquenailstudio@gmail.com");
                        //change email heading and body. Body reads from textfile when it is created
                        msg.Subject = "System login failure";


                        msg.Body = $"Login failed 3 times:\r\nDate of attempt:\t{DateTime.Now.ToString("HH:mm:ss dd MMMM yyyy")}\r\nPerson making attempt:\t{edtUser.Text}";
                        client.SendMailAsync(msg);
                    }
                }
                catch (Exception ef)
                {
                    MessageBox.Show(ef.Message);
                }
                Canceled = true;
                this.Close();
            }
        }

        private bool login()
        {
            //----- This method compares the details given to the employee entries from the file -----//
            conn.Open();
            OleDbCommand cmd = new OleDbCommand($"SELECT * FROM Employees WHERE Username = '{edtUser.Text}'", conn);
            OleDbDataReader read = cmd.ExecuteReader();
            if (read.Read())
                if (!read["EmployeeName"].Equals(null))
                {
                    if (read["Password"].ToString().Equals(edtPass.Text))
                    {
                        user = read["EmployeeName"].ToString();
                        acclvl = int.Parse(read["Access"].ToString());
                        conn.Close();
                        return true;
                    }
                }
            conn.Close();
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Set a check to see whether login succeeded and close the dialog
            Canceled = true;
            this.Close();
        }
    }
}
