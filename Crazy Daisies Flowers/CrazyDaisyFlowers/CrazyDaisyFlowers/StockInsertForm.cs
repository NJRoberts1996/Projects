using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyDaisyFlowers
{
    public partial class StockInsertForm : Form
    {
        DataEntry dbEntry;
        public StockInsertForm(DataEntry de)
        {
            InitializeComponent();
            dbEntry = de;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            dbEntry.insType = txtType.Text;
            dbEntry.insAmount = Convert.ToInt16(txtStock.Text);
            dbEntry.InsertType();
            this.Close();
        }
    }
}
