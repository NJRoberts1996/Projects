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
    public partial class Client_Management : Form
    {
        private OleDbConnection conn;
        private string DBloc;
        private bool   selected;
        private string clientName;
        private int    clientID;

        public Client_Management(OleDbConnection con)
        {
            // Component initialization
            InitializeComponent();
            conn = con;
            DBloc = Directory.GetCurrentDirectory();

            try
            {

                if (!File.Exists(DBloc + @"\ChaliqueNailStudio.accdb"))
                    DBloc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Chalique Nail Studio";

                // Name textbox autocomplete settings
                txtName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtDelName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtDelName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtName.Focus();
                selected = false;

                NamesAutoload();
            }

            catch (Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void NamesAutoload()
        {

            // Load names into textboxes
            string[] arr = SuggestNames();

            if (arr != null)
            {
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                collection.AddRange(arr);

                txtName.AutoCompleteCustomSource = collection;
                txtDelName.AutoCompleteCustomSource = collection;
            }
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            { 
                if(selected/*txtDelName.Text != ""*/)
                {
                    conn.Open();
                    OleDbCommand cmnd;
                    OleDbDataReader reader;
                    cmnd = new OleDbCommand("SELECT BookingID from Bookings WHERE ClientID = " + clientID, conn);
                    reader = cmnd.ExecuteReader();
                    //reader.Read();
                    int bID;
                    while (reader.Read())
                    {
                        bID = int.Parse(reader["BookingID"].ToString());

                        cmnd = new OleDbCommand("SELECT DateOfPayment FROM Payment WHERE BookingID = " + bID, conn);
                        reader = cmnd.ExecuteReader();
                        if (reader.Read())
                            throw new Exception("This client has had a booking finished on " + reader[0].ToString() + " and can not be removed.");

                        cmnd = new OleDbCommand("DELETE * FROM TreatmentDetailPerBooking WHERE BookingID = " + bID, conn);
                        cmnd.ExecuteNonQuery();
                        cmnd = new OleDbCommand("DELETE * FROM Bookings WHERE BookingID = " + bID, conn);
                        cmnd.ExecuteNonQuery();
                    }

                    cmnd = new OleDbCommand("DELETE * FROM Clients WHERE ClientID = " + clientID, conn);
                    cmnd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();

                    txtDelName.Text = "";
                    NamesAutoload();
                }

                else
                {
                    MessageBox.Show("Please enter the client name you wish to delete", "Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {

                if (selected/*txtName.Text != "" && txtNum.Text != "" && txtEmail.Text != ""*/)
                {
                    conn.Open();
                    OleDbCommand cmnd = new OleDbCommand(@"UPDATE Clients set ClientName = '" + txtName.Text + "', TelNumber = '" + txtNum.Text + "', EmailAddress = '" + txtEmail.Text + "' WHERE ClientID = " + clientID, conn);
                    cmnd.ExecuteNonQuery();

                    MessageBox.Show("Client Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    txtName.Clear();
                    txtNum.Clear();
                    txtEmail.Clear();
                    NamesAutoload();
                }
                else
                {
                    MessageBox.Show("Please fill all the textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
   
        private string[] SuggestNames()
        {

            conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT ClientName FROM Clients ORDER BY ClientName", conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> names = new List<string>();
            while (reader.Read())
            {
                names.Add(reader[0].ToString());
            }
            conn.Close();
            if (names.Count > 0)
                return names.ToArray();
            else return null;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Enter)
                    selectClient(sender);
            }


            catch (Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void selectClient(object sender)
        {
            // We use a substitute textbox so this method can be used both for change and delete
            try
            {

                TextBox t = (sender as TextBox);
                if (t.Text != "")
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand($"SELECT * FROM Clients WHERE ClientName LIKE '%{t.Text}%'", conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (t.Name == "txtName")
                        {
                            txtEmail.Text = reader["EmailAddress"].ToString();
                            txtNum.Text = reader["TelNumber"].ToString();
                        }
                        clientName = t.Text;
                        clientID = int.Parse(reader["ClientID"].ToString());


                        selected = true;
                    }

                    conn.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                if (tabControl1.SelectedIndex == 0)
                    txtName.Focus();
                else
                    txtDelName.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}