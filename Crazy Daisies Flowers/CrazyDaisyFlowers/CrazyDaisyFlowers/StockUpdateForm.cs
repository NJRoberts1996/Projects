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
    public partial class StockUpdateForm : Form
    {
        DataEntry dbEntry;

        public StockUpdateForm(DataEntry de)
        {
            InitializeComponent();
            dbEntry = de;
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            dbEntry.updateType = txtUpdateType.Text;
            dbEntry.updateAmount = Convert.ToInt16(txtUpdateAmount.Text);
            dbEntry.UpdateType();
            this.Close();
        }
    }
}
