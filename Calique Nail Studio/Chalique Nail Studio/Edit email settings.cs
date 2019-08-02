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

namespace Chalique_Nail_Studio
{
    public partial class Edit_email_settings : Form
    {
        private string email;
        private string password;
        private string details;
        private string path;
        private string DBloc;

        public Edit_email_settings()
        {
            InitializeComponent();
            //***************************************************************Auto loads the email address and password from the textfile into the textboxes****************************************
            DBloc = Directory.GetCurrentDirectory();
            if (!File.Exists(DBloc + @"\ChaliqueNailStudio.accdb"))
                DBloc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Chalique Nail Studio";
            path = Path.Combine(DBloc + "\\emailDetails.cns");
            details = "";

            StreamReader myReader = new StreamReader(path);

            while(!myReader.EndOfStream)
            {
                details = myReader.ReadLine();
            }

            string[] allDetails = details.Split(':');
            email = allDetails[0].ToString();
            password = allDetails[1].ToString();

            txtEmail.Text = email;

            txtPassword.Clear();
            txtPassword.Text = password;
            txtPassword.PasswordChar = '*';


            //*****************************************************************************************************************************************************************************************
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            string[] allDetails = details.Split(':');
            StreamWriter myWriter = new StreamWriter(path);
            allDetails[0] = txtEmail.Text;
            allDetails[1] = txtPassword.Text;
            myWriter.WriteLine(allDetails[0] + ":" + allDetails[1]);
            myWriter.Close();
            this.Close();

        }



        private void cBxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cBxShowPassword.Checked == true)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
