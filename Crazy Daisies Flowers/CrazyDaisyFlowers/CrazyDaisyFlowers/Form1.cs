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

namespace CrazyDaisyFlowers
{
    public partial class Form1 : Form
    {
        //global variables
        Image[] pictures = new[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4 };
        //string[] pictures = { "1.jpg", "2.jpg", "3.jpg", "4.jpg" };
        int i = 0;
        string location;
        
        public Form1()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            label2.Text = now.ToString("dd/MM/yyyy");
            label3.Text = now.ToString("hh:mm tt");
            location = Directory.GetCurrentDirectory() + "/" + "SlideShow";
        }

        //timer for slideshow
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pBoxSlideShow.Image = pictures[i]; //pBoxSlideShow.Image = Image.FromFile(location + "/" + pictures[0]);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (pictures.Length == i)
            {
                i = 0;
            }
            pBoxSlideShow.Image = pictures[i]; //FromFile(location + "/" + pictures[i]);
            
        }
        
        //moves back when back label is clicked in slideshow
        private void btnBack_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (i == 0)
            {
                i = pictures.Length;
            }
            i--;
            pBoxSlideShow.Image = pictures[i]; //pBoxSlideShow.Image = Image.FromFile(location + "/" + pictures[i]);
            timer1.Enabled = true;
            
        }

        //moves forward when forward label is clicked in slideshow
        private void btnForward_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            i++;
            if (pictures.Length == i)
            {
                i = 0;
            }
            pBoxSlideShow.Image = pictures[i]; //pBoxSlideShow.Image = Image.FromFile(location + "/" + pictures[i]);
            timer1.Enabled = true;
        }

        //opens inventory form
        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryAmount myinventory = new InventoryAmount();
            myinventory.Show();
        }

        //opens dataEntry form
        private void btnDataEntry_Click(object sender, EventArgs e)
        {
            DataEntry myDataEntry = new DataEntry();
            myDataEntry.Show();
        }

        //opens forecasting form 
        private void btnForecasting_Click(object sender, EventArgs e)
        {
            Forecasting myForecasting = new Forecasting();
            myForecasting.Show();
        }

        //shows about us messagebox
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Developers:\nAhmed Yusuf Patel 27342514\nFranco Verster 25021516\nNicole Roberts 25994689\nNaomi Pretorius 27532704\nArno Pretorius 26056569\nRobin De Klerk 25007335\n\n©Crazy Daisies 2018";
            MessageBox.Show(message, "About us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //opens uses manual
        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //----- Open the help document -----//
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Manual\CDQAUserManual.pdf"))
                System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\Manual\CDQAUserManual.pdf");
        }
    }
}
