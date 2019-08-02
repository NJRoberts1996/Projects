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
using System.Net.Mail;

namespace CrazyDaisyFlowers
{
    public partial class Inventory : Form
    {
        private string connection = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =";
        string directory = System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString();
        private int amntAva = 0;
        private double leadTime = 0;


        public Inventory()
        {
            InitializeComponent();
            try
            {
                txtNotif.Visible = false;
                txtAmntSold.Enabled = false;
                txtAmntSold.BackColor = Color.LightGray;
                txtTDeliv.Text = "4";
                leadTime = double.Parse(txtTDeliv.Text);

                getFlowerType();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        //retrieves the flower type from the database and shows it up in the combobox
        public void getFlowerType()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(connection + directory + @"\ITRW 325.accdb");
                conn.Open();


                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT DISTINCT(Flower_Type) FROM Inventory ORDER BY Flower_Type ASC";

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["Flower_Type"].ToString());
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        //calculates the reorder point
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //local variables used in the calculations
                double amntPerDay = 0;
                int amnt_sold = 0;
                int days = 0;
                double reorderPoint = 0;


                //open connection
                OleDbConnection conn = new OleDbConnection(connection + directory + @"\ITRW 325.accdb");
                conn.Open();


                //retrieve the amount of flowers of a specific type sold from the database
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = $@"SELECT Amount_Sold FROM Inventory WHERE Flower_Type = '{comboBox1.SelectedItem}'";

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            days++;
                            amnt_sold += int.Parse(reader["Amount_sold"].ToString());

                        }
                        amntPerDay = amnt_sold / days;
                        txtAmntSold.Text = amntPerDay.ToString();

                    }
                }

                //calculate reorder point
                reorderPoint = amntPerDay * leadTime;

                txtNotif.Visible = true;
                txtNotif.Text = "The reorder point is " + reorderPoint + " units";

                checkStockLevel();

                if (amntAva < reorderPoint)
                {
                    MessageBox.Show("You have " + amntAva + " units available\nPlease reorder", "Please Reorder", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if(MessageBox.Show("Would you like to place an order with the supplier?", "Place order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                        client.EnableSsl = true;
                        client.Timeout = 60000;
                        client.Port = 587;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                   
                        //email the business about placing the order
                        string email = "crazydaisies75@gmail.com";
                        string password = "$$Crazy123456";
                        client.Credentials = new System.Net.NetworkCredential(email, password);
                        MailMessage msg = new MailMessage();
                        msg.To.Add(email);
                        msg.From = new MailAddress(email);
                        //change email heading and body. Body reads from textfile when it is created
                        msg.Subject = "Order placed";
                        msg.Body = $"Dear manager\nPlease note, an order for 500 '{comboBox1.SelectedItem}' has been placed.\nTime placed::\t{DateTime.Now.ToString("HH:mm:ss dd MMMM yyyy")} \nKind regards\nCrazy Daisy system";
                        //client.Send(msg);
                        client.SendMailAsync(msg);


                        //email supplier
                        MailMessage notifySupplier = new MailMessage();
                        notifySupplier.To.Add("crazydaisysupplier@gmail.com");
                        notifySupplier.From = new MailAddress(email);
                        notifySupplier.Subject = "Crazy daisy order placement";
                        notifySupplier.Body = $"Dear supplier\nCrazy daisy flowers requires 500 units of {comboBox1.SelectedItem} for delievery in 4 days. \nTime placed:\t{DateTime.Now.ToString("HH:mm:ss dd MMMM yyyy")} \nThank you";
                       // client.Send(notifySupplier);
                        client.SendMailAsync(notifySupplier);
                        MessageBox.Show("Order has been placed", "order placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You have sufficient stock available\nAvailable stock: " + amntAva, "Stock level sufficient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //checks stock level in DB
        public void checkStockLevel()
        {
            try
            {
                amntAva = 0;
                OleDbConnection conn = new OleDbConnection(connection + directory + @"\ITRW 325.accdb");
                conn.Open();


                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = $@"SELECT Amount FROM Flower_Stock WHERE Flower_Type = '{comboBox1.SelectedItem}'";

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            amntAva = int.Parse(reader["Amount"].ToString());
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
