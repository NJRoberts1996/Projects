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
    public partial class Change_Email_Message : Form
    {
        private string DBloc;
        private string initialmessage;
        private string reminder;

        public Change_Email_Message()
        {
            InitializeComponent();

            DBloc = Directory.GetCurrentDirectory();
            if (!File.Exists(DBloc + @"\ChaliqueNailStudio.accdb"))
                DBloc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Chalique Nail Studio";

            if (File.Exists(DBloc + @"\EmailMessage.cns"))
            {
                StreamReader r = File.OpenText(DBloc + @"\EmailMessage.cns");
                initialmessage = r.ReadToEnd();
                r.Close();
            }
            else
            {
                initialmessage =
@"Dear Client

Your booking at Chalique Nail Studio has been confirmed. The details of the booking will follow below. 
We now take CASH AND CARD😬😬

Thank you
Have a lovely day🌸
Chalique Nail Studio";
            }
            txtEmail.Text = initialmessage;


            if (File.Exists(DBloc + @"\EmailReminder.cns"))
            {
                StreamReader r = File.OpenText(DBloc + @"\EmailReminder.cns");
                reminder = r.ReadToEnd();
                r.Close();
            }
            else
            {
                reminder =
@"Dear Client

Please remember your appointment at Chalique Nail Studio for tomorrow💅🏼
We now take CASH AND CARD😬😬

Thank you
Have a lovely day🌸";
            }
            txtReminder.Text = reminder;
            txtEmail.Focus();
            txtEmail.SelectionStart = txtEmail.Text.Length - 1;
            txtEmail.SelectionLength = 0;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //Write the new text to the EmailMessage file
            StreamWriter w = File.CreateText(DBloc + @"\\EmailMessage.cns");
            w.Write(txtEmail.Text);
            w.Close();

            //Write the new text to the EmailReminder file
            w = File.CreateText(DBloc + @"\\EmailReminder.cns");
            w.Write(txtReminder.Text);
            w.Close();

            MessageBox.Show("Email messages updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
