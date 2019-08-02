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

namespace CrazyDaisyFlowers
{
    public partial class DataEntry : Form
    {
        public string DBFile;
        public OleDbConnection myDB;
        public string conn = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ";
        string directory = System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString();
        private string[] myHeading = new string[] {"Flower_Stock", "Forecasting", "Inventory"};
        private string[] myDB_Tables = new string[] { "Flower_Stock", "Forecasting", "Inventory" };
        private int i = 0;

        //Flower type table
        public string insType, updateType, delType;
        public int insAmount, updateAmount;

        public DataEntry()
        {
            InitializeComponent();
        }

        private void btn_Left_Click(object sender, EventArgs e)
        {
            try
            {
                if (i != 0)
                {
                    i--;
                    lbl_Heading.Text = myHeading[i];

                    OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM " + myDB_Tables[i], myDB);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "List");

                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "List";

                   if (i != 0)
                    {
                        btnAdd.Hide();
                        btnDelete.Hide();
                        btnUpdate.Hide();
                    }

                   else if (i == 0)
                    {
                        btnAdd.Show();
                        btnDelete.Show();
                        btnUpdate.Show();
                    }
                }


                else if (i == 0)
                {
                    i = myHeading.Length - 1;
                    lbl_Heading.Text = myHeading[i];

                    OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM " + myDB_Tables[i], myDB);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "List");

                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "List";

                    if (i != 0)
                    {
                        btnAdd.Hide();
                        btnDelete.Hide();
                        btnUpdate.Hide();
                    }

                    else if (i == 0)
                    {
                        btnAdd.Show();
                        btnDelete.Show();
                        btnUpdate.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Right_Click(object sender, EventArgs e)
        {
            try
            {
                if (i < myHeading.Length - 1)
                {
                    i++;
                    lbl_Heading.Text = myHeading[i];

                    OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM " + myDB_Tables[i], myDB);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "List");

                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "List";

                    if (i != 0)
                    {
                        btnAdd.Hide();
                        btnDelete.Hide();
                        btnUpdate.Hide();
                    }

                    else if (i == 0)
                    {
                        btnAdd.Show();
                        btnDelete.Show();
                        btnUpdate.Show();
                    }
                }
                else if (i == myHeading.Length - 1)
                {
                    i = 0;
                    lbl_Heading.Text = myHeading[i];

                    OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM " + myDB_Tables[i], myDB);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "List");

                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "List";

                    if (i != 0)
                    {
                        btnAdd.Hide();
                        btnDelete.Hide();
                        btnUpdate.Hide();
                    }

                    else if (i == 0)
                    {
                        btnAdd.Show();
                        btnDelete.Show();
                        btnUpdate.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataEntry_Load(object sender, EventArgs e)
        {
            /*if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DBFile = openFileDialog1.FileName;
            }*/
            try
            {
                myDB = new OleDbConnection(conn + directory + @"\ITRW 325.accdb");

                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Flower_Stock", myDB);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "List";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (i == 0)
                {
                    StockDeleteForm stock_del = new StockDeleteForm(this);
                    stock_del.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (i == 0)
                {
                    StockUpdateForm stock_update = new StockUpdateForm(this);
                    stock_update.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (i == 0)
                {
                    StockInsertForm stock_ins = new StockInsertForm(this);
                    stock_ins.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertType()
        {
            try
            {
                myDB.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Flower_Stock", myDB);
                //In_stock was the problem...Replaced with Amount to fix insert error HERE  ______
                OleDbCommand cmd = new OleDbCommand(@"Insert INTO Flower_Stock(Flower_Type, Amount) VALUES ( '" + insType + "', " + insAmount + ")", myDB); //NB check "" vir int '""' vir string
                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();

                // na insert verskyn nuwe datastel
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "List";
                myDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteType()
        {
            try
            {
                myDB.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Flower_Stock", myDB);
                OleDbCommand cmd = new OleDbCommand(@"Delete from Flower_Stock WHERE Flower_Type = '" + delType + "'", myDB);
                adapter.DeleteCommand = cmd;
                adapter.DeleteCommand.ExecuteNonQuery();

                // na delete verskyn datastel weer
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "List";
                myDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateType()
        {
            try
            {
                myDB.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM Flower_Stock", myDB);
                OleDbCommand cmd = new OleDbCommand(@"Update Flower_Stock SET In_Stock = " + updateAmount + " WHERE Flower_Type = '" + updateType + "'", myDB); //NB check "" vir int '""' vir string
                adapter.UpdateCommand = cmd;
                adapter.UpdateCommand.ExecuteNonQuery();

                // na insert verskyn nuwe datastel
                DataSet ds = new DataSet();
                adapter.Fill(ds, "List");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "List";
                myDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
