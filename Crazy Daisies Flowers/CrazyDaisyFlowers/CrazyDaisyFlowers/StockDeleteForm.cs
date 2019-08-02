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
    public partial class StockDeleteForm : Form
    {
        DataEntry dbEntry;
        public StockDeleteForm(DataEntry de)
        {
            InitializeComponent();
            dbEntry = de;
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            dbEntry.delType = txtDeleteType.Text;
            dbEntry.DeleteType();
            this.Close();
        }
    }
}
