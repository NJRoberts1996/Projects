using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITRI615
{
    public partial class StartScreen : MetroFramework.Forms.MetroForm
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            TextEncryptionForm text = new TextEncryptionForm();
            text.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            // files.Close();
            MetroGuiForm files = new MetroGuiForm();
            files.ShowDialog();
        }
    }
}
