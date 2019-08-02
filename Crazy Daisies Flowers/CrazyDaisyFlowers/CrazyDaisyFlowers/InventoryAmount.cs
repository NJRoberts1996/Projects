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

namespace CrazyDaisyFlowers
{
    

    public partial class InventoryAmount : Form
    {
        private string connection = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =";
        string directory = System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString();



        //shows all the flowers in the DB on form load
        public InventoryAmount()
        {
            InitializeComponent();
            OleDbConnection conn = new OleDbConnection(connection + directory + @"\ITRW 325.accdb");
            conn.Open();

            OleDbDataAdapter adapt = new OleDbDataAdapter($@"SELECT * FROM Flower_Stock ORDER BY Flower_Type ASC", conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "Flower_Stock");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Flower_Stock";
            conn.Close();

        }

        private void ROPbtn_Click(object sender, EventArgs e)
        {
            Inventory myinventory = new Inventory();
            myinventory.Show();
        }
    }
}
