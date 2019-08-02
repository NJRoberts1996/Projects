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

namespace Chalique_Nail_Studio
{
    public partial class User_control : Form
    {
        private int emplvl;
        private int tabLock = 0;
        private OleDbConnection conn;

        public User_control(OleDbConnection con)
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            radioButton2.Checked = true;
            tabControl1.SelectTab(0); // Change to first tab and disable other tabs
            (tabControl1.TabPages[1] as TabPage).Enabled = false;
            (tabControl1.TabPages[2] as TabPage).Enabled = false;
            
            conn = con;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //----- Set the new employee type and switch tabs -----//
            if (radioButton1.Checked)
            {
                emplvl = 1; // Set new employee level as Owner
            }
            else
            {
                emplvl = 2; // Set new employee level as general staff
                cbxTech.Checked = true;
            }

            // Change to second tab and disable other tabs
            (tabControl1.TabPages[0] as TabPage).Enabled = false;
            (tabControl1.TabPages[1] as TabPage).Enabled = true;
            tabLock = 1;
            tabControl1.SelectTab(1);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
          //----- Switch to the Remove Employee tab -----//
            lbxEmp.Items.Clear();
            lbxEmp.Items.Add("ID \t Name");
            if (radioButton1.Checked)
            {
                emplvl = 1;
            }
            else
            {
                emplvl = 2;
            }
            (tabControl1.TabPages[0] as TabPage).Enabled = false;
            (tabControl1.TabPages[2] as TabPage).Enabled = true;
            tabLock = 2;
            tabControl1.SelectTab(2);
            listEmp();
        }

        // ADD EMPLOYEE /////////////////////////////////////////////////////////////////////////////////////////

        private void btnFin_Click(object sender, EventArgs e)
        {
          //----- Add the employee to the file -----//
            string emps = "";
            switch (emplvl)
            {
                case 1: emps = "an owner";
                    break;
                case 2: emps = "a technician";
                    break;
            }
            try
            {
                // Check the details and prompt to make sure the employee must be added
                if (!txtUser.Text.Equals("") && !txtPassword.Text.Equals(""))
                {
                    string tech;
                    if (cbxTech.Checked && emplvl == 1) { tech = "with technician status"; }
                    else tech = "";
                    
                    if (MessageBox.Show($"Are you sure you want to add employee {txtUser.Text} as {emps} with password {txtPassword.Text} {tech}?",
                                        "New Employee Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand($"SELECT * FROM Employees WHERE Username = '{txtUser.Text}'", conn);
                        OleDbDataReader read = cmd.ExecuteReader();
                        if (read.Read())
                        {
                            throw new Exception("This employee Username is already in use!");
                        }
                        if (txtPassword.Text.Length > 32)
                        {
                            throw new Exception("Your Password is too long.");
                        }
                        cmd = new OleDbCommand($@"INSERT INTO Employees (EmployeeName, [Password], [Username], [Access], IsTech) 
                                                VALUES('{txtName.Text}', '{txtPassword.Text}', '{txtUser.Text}', {emplvl}, {cbxTech.Checked})", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        if (MessageBox.Show("Successfuly added " + txtName.Text + " as an " + emps + ".\r\nDo you wish to continue?", "Success", MessageBoxButtons.YesNo) == DialogResult.No)
                            this.Close();
                    }
                    btnAddCancel_Click(sender, e);
                }
                else MessageBox.Show("Please make sure all fields are filled in", "Empty input");
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Please try again." + ex.Message, "There was a problem");
            }
        }
        
        // EMPLOYEE REMOVAL /////////////////////////////////////////////////////////////////////////////////////

        private void listEmp()
        {
          //----- List the employees in a listBox -----//
            // List employees of the selected level from the senior employee file
            conn.Open();
            OleDbCommand cmd = new OleDbCommand($"SELECT * FROM Employees WHERE Access = {emplvl}", conn);
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                lbxEmp.Items.Add(read["Username"].ToString() + "\t" + read["EmployeeName"]);
            }
            conn.Close();
        }

        private void lbxEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxEmp.SelectedIndex != -1)
                btnRem.Visible = true;
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
          //----- Remove the selected emplyee -----//
            if (lbxEmp.SelectedIndex < 1)
                MessageBox.Show("No user has been selected!");
            else
            {
                string t = Convert.ToString(lbxEmp.SelectedItem).Split('\t')[0];
                conn.Open();
                OleDbCommand cmd = new OleDbCommand($"DELETE * FROM Employees WHERE Username = '{t}'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("The employee has been removed.", "Romoval success");

                lbxEmp.Items.Clear();
                lbxEmp.Items.Add("ID \t Name");
                listEmp();
            }
        }

        // TAB CANCEL ///////////////////////////////////////////////////////////////////////////////////////////

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
          //----- Cancel and go back to the first tab -----//
            txtUser.Clear();
            txtName.Clear();
            txtPassword.Clear();
            (tabControl1.TabPages[0] as TabPage).Enabled = true;
            (tabControl1.TabPages[1] as TabPage).Enabled = false;
            tabLock = 0;
            tabControl1.SelectTab(0);
        }

        private void btnRemCancel_Click(object sender, EventArgs e)
        {
          //----- Cancel and go back to the first tab -----//
            lbxEmp.Items.Clear();
            btnRemove.Visible = false;
            (tabControl1.TabPages[0] as TabPage).Enabled = true;
            (tabControl1.TabPages[2] as TabPage).Enabled = false;
            tabLock = 0;
            tabControl1.SelectTab(0);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl1.SelectedIndex != tabLock)
                e.Cancel = true;
        }

        private void cbxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxPassword.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
                //show text of password
            }
            else
            {
                txtPassword.PasswordChar = '*';
                //show password as asterisks
            }
        }
    }
}