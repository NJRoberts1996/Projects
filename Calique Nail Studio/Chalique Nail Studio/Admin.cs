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
using System.IO;

namespace Chalique_Nail_Studio
{
    public partial class Admin : Form
    {
        OleDbConnection conn;
        private string DBloc;
        private string Target;
        private string person;
        private int expCode;
        private bool edit = false;
        private DataGridViewRow myRows;

        public Admin(OleDbConnection con, string user, string target)
        {
            InitializeComponent();
            conn = con;

            DBloc = Directory.GetCurrentDirectory();
            if (!File.Exists(DBloc + @"\ChaliqueNailStudio.accdb"))
                DBloc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Chalique Nail Studio";

            Target = target;
            person = user;
            button_colour(Color.LightBlue);
        }

        //******************************CHANGE BUTTON COLOUR**************************************
        private void button_colour(Color c)
        {
            // Include here all buttons that will have their colour changed ***
            btnReport.BackColor = c;
            btnNewTreatment.BackColor = c;
            btnAddExpense.BackColor = c;
            btnAddExpenseType.BackColor = c;
            btnEditexp.BackColor = c;
            btnDeleteExp.BackColor = c;
            btnUpdateExp.BackColor = c;
            dgvMonthView.BackgroundColor = c;
            dgvExpList.BackgroundColor = c;
            dgvIncomes.BackgroundColor = c;
            dgvIncomeMonthly.BackgroundColor = c;
        }



        //--------------------------------------------------------------------------------------RELATED TO ALL TAB PAGES------------------------------------------------------------------------------
        private void tabListExpenses_Enter(object sender, EventArgs e)
        {
            //lbxMonthExpensesList.Items.Clear();
            ListAll();
        }
        private void tabTypeExpenses_Enter(object sender, EventArgs e)
        {
            ReadExpenseTypesEdit();
            txtExpenseType.Focus();
            conn.Close();
        }
        private void tabNewExpense_Enter(object sender, EventArgs e)
        {
            //Calls method that display the expense types from the Database
            LoadExpenseTypes();
            ListCurrentMonthExpsenses();
            btnDeleteExp.Visible = false;
            btnEditexp.Visible = false;
            btnUpdateExp.Visible = false;
            conn.Close();
        }
        private void tabEditAndDeleteIncomes_Enter(object sender, EventArgs e)
        {
            //Calls a method to display all payments from the database
            ListCurrentMonthIncome();
            btnDeleteIncome.Visible = false;
            btnEditIncome.Visible = false;
            btnUpdate.Visible = false;
            conn.Close();
           
        }
        private void tabTreatments_Enter(object sender, EventArgs e)
        {
            //Calls method that display the treatments from the Database
            ReadTreatments();
            conn.Close();
        }



        //-------------------------------------------------------------------------------------------------------------END INFORMATION RELATED TO ALL TAB PAGES---------------------------------------------------














        //-----------------------------------------------------------------------------------------------METHOD RELATED TO ADD, EDIT AND DELETE EXPENSES & INCOMES (TAB PAGE 3 & 4)------------------------------------------------------
        //********************************Add to a log file: Edit payment; add, edit, remove expense
        private void WriteLog(string logText, double oldAmt, double newAmt)
        {
            if (!File.Exists(DBloc + @"\logfile.txt"))
            {
                if (Target == null || Target == "")
                    Target = DBloc;
                if (File.Exists(Target + @"\logfile.Backup.txt"))
                {
                    File.Copy(Target + @"\logfile.Backup.txt", DBloc + @"\logfile.txt", true);
                }
            }
            StreamWriter w = File.AppendText(DBloc + @"\logfile.txt");

            string datetime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            w.WriteLine($"{datetime}, {person}, {logText}, New amount: {newAmt: 0.00}, Old amount: {oldAmt: 0.00};");
            w.Close();

        }

        //--------------------------------------------------------------------------------------------------METHOD END RELATED TO TAB PAGE 3 & 4)------------------------------------------------------------------------



















        //--------------------------------------------------------------------------------------------------All EXPENSES AND INCOMES TAB INFORMATION (TAB PAGE 1)-----------------------------------------------------------------------------
        //****************************************************************************lists all the current months expenses in the first tab page***************************************************
        public void ListAll()
        {
            DateTime test = dateExpenseSelect.SelectionStart;//which datetimepicker do i choose this from?
            DateTime start = new DateTime(test.Year, test.Month, 1, 0, 0, 0, 0);
            DateTime end = start.AddMonths(1).AddMinutes(-1);

            try
            {
                conn.Open();
                //---------------------------------------------------------------------------Expenses-----------------------------------------------------------------------------------------
                OleDbDataAdapter adapter = new OleDbDataAdapter($@"SELECT B.DateOfExpense AS [Date], A.ExpenseDescript AS [Description], B.Cost
                                                                    FROM ExpenseType A INNER JOIN OperationalExpense B 
                                                                    ON A.ExpenseCode = B.ExpenseCode
                                                                    WHERE B.DateOfExpense BETWEEN #{start.ToShortDateString()}# AND #{end.ToShortDateString()}#
                                                                    ORDER BY B.DateOfExpense", conn);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "Expenses");

                dgvMonthView.DataSource = ds;
                dgvMonthView.DataMember = "Expenses";
                dgvMonthView.Columns[1].Width = 250;
                foreach (DataGridViewColumn col in dgvMonthView.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("There was an error\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try {
                //---------------------------------------------------------------------------Incomes-----------------------------------------------------------------------------------------
                conn.Open();
                OleDbDataAdapter adt = new OleDbDataAdapter($@"SELECT B.DateOfPayment AS [Date], C.ClientName AS [Description], B.AmountPaid AS [Amount Paid], B.SaleID AS [Sale ID] 
                                                                FROM (Bookings A INNER JOIN Payment B ON B.BookingID = A.BookingID)
                                                                INNER JOIN Clients C ON A.ClientID = C.ClientID 
                                                                WHERE B.DateOfPayment BETWEEN #{start.ToShortDateString()}# AND #{end.ToShortDateString()}#
                                                                ORDER BY B.DateOfPayment",conn);

                DataSet d = new DataSet();
                adt.Fill(d,"Incomes");

                dgvIncomeMonthly.DataSource = d;
                dgvIncomeMonthly.DataMember = "Incomes";
                dgvIncomeMonthly.Columns[1].Width = 250;
                dgvIncomeMonthly.Columns[0].Width = 140;

                foreach (DataGridViewColumn col in dgvIncomeMonthly.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                conn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("There was an error\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        
        //------------------------------------------------------------------------------------------------END TAB PAGE 1-----------------------------------------------------------------------------------------------


















        //----------------------------------------------------------------------------------------------------EXPENSE TYPES TAB INFORMATION (TAB PAGE 2)-------------------------------------------------------------------------------------------



        //********************************Method that displays information from the database in the listBox on tab page 2**************************************//
        public void ReadExpenseTypesEdit()
        {
            try
            {
                //Clears the contens of the listBox on tabPage2
                lbxExpenses.Items.Clear();

                //Opens the DB connection
                conn.Open();

                //Command and datareader to read expense types from the DB into the listBox
                using (OleDbCommand command = new OleDbCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT ExpenseDescript FROM ExpenseType ORDER BY ExpenseDescript ASC";

                    //reads information from the database
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lbxExpenses.Items.Add(reader["ExpenseDescript"].ToString());
                        }
                    }
                }
                //Close DB connection
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //********************************Button click adds an expense into the database, Calls method that displays the expense in the listbox on tab page 2 as well*************//
        private void btnAddExpenseType_Click(object sender, EventArgs e)
        {
            try
            {
                string expType = txtExpenseType.Text;

                //check if the textBox is empty or not before adding information in the database
                if (string.IsNullOrEmpty(expType))
                {
                    MessageBox.Show("Please enter an expense type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you would like to add " + expType + " as an expense?", "Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            //Opens the DB connection
                            conn.Open();


                            //Command to insert expense type into Database
                            OleDbCommand cmd = new OleDbCommand($@"INSERT INTO ExpenseType(ExpenseDescript) VALUES ('{expType}')", conn);
                            cmd.ExecuteNonQuery();


                            //Expense type that is added is shown in messageBox
                            MessageBox.Show("You have successfully added " + expType + " as an expense", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Close DB connection
                            conn.Close();

                            //Calls method that reads the database and displays the expense type in the listBox
                            ReadExpenseTypesEdit();

                            //Clears the contents of the textBox
                            txtExpenseType.Clear();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(expType + " was not added", "Declined", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                txtExpenseType.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //********************************Method to remove an expense when you double click the listbox expense type*************************************************
        private void lbxExpenses_DoubleClick(object sender, EventArgs e)
        {
            if(lbxExpenses.SelectedItem != null)
            { 
                string expName = "";
                foreach (string val in lbxExpenses.SelectedItems)
                {
                    expName = val;
                }

                if (MessageBox.Show("Do you wish to remove " + expName + " as an expense?", "Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();

                        //Add here the check for expenses of this type and deny deletion if any exist (Can also give option to replace expense type)************//



                        //OleDbDataAdapter adapter = new OleDbDataAdapter($@"SELECT ExpenseDescript FROM ExpenseType ORDER BY ExpenseDescript ASC", conn);
                        OleDbCommand cmd = new OleDbCommand($@"DELETE FROM ExpenseType WHERE ExpenseDescript = '{expName}'", conn);
                        cmd.ExecuteNonQuery();
                        //MessageBox.Show(expName + " was successfully removed as an expense", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        ReadExpenseTypesEdit();
                    }
                    catch(Exception ef)
                    {
                        conn.Close();
                        MessageBox.Show("There was an error\n" + ef.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                
                }
                else
                {
                    MessageBox.Show(expName + " was not removed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You have not selected a valid expense type to remove", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //-------------------------------------------------------------------------------------------------------------------END TAB PAGE 2--------------------------------------------------------------------------


















        //----------------------------------------------------------------------------------------------------NEW EXPENSE TAB INFORMATION (TAB PAGE 3)-------------------------------------------------------------------------------------------

        public void clearAll()
        {
            cmbExpenseType.Text = "Select the type of expense to add";
            txtExpenseAmt.Text = null;
            dateExpenseSelect.TodayDate = DateTime.Now;
        }



        //**************************************Displays expense type from the database in the comboBox on tabNewExpense**********************************
        public void LoadExpenseTypes()
        {
            try
            {
                //Clear content of ComboxBox
                cmbExpenseType.Items.Clear();

                //Opens the DB connection
                conn.Open();

                //Command and datareader to read expense types from the DB into the comboBox
                using (OleDbCommand command = new OleDbCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT ExpenseDescript FROM ExpenseType ORDER BY ExpenseDescript ASC";

                    //whenever you want to get some data from the database
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbExpenseType.Items.Add(reader["ExpenseDescript"].ToString());
                        }
                    }
                }
                //Close DB connection
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        


        //********************************shows all the current months expenses in the datagridview*****************************
        public void ListCurrentMonthExpsenses()
        {
            try
            {
                conn.Open();
                DateTime test = dateExpenseSelect.SelectionStart;
                DateTime start = new DateTime(test.Year, test.Month, 1, 0, 0, 0, 0);
                DateTime end = start.AddMonths(1).AddMinutes(-1);
                OleDbDataAdapter adapter = new OleDbDataAdapter($@"SELECT  B.DateOfExpense AS [Date], A.ExpenseDescript AS [Description],B.Cost, B.ExpenseID
                                                                FROM ExpenseType A INNER JOIN OperationalExpense B 
                                                                ON A.ExpenseCode = B.ExpenseCode 
                                                                WHERE B.DateOfExpense BETWEEN #{start.ToShortDateString()}# AND #{end.ToShortDateString()}#
                                                                ORDER BY B.DateOfExpense", conn);


                DataSet ds = new DataSet();
                adapter.Fill(ds, "Expenses");

                dgvExpList.DataSource = ds;
                dgvExpList.DataMember = "Expenses";
                dgvExpList.Columns[1].Width = 250;
                foreach (DataGridViewColumn col in dgvExpList.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
        

        //********************************reads the expense code type from the database so that we work across multiple tables*******************************************
        public void ExpenseCodeType()
        {
            try
            {
                expCode = -1;
                conn.Open();

                OleDbCommand cmd = new OleDbCommand($@"SELECT ExpenseCode FROM ExpenseType WHERE ExpenseDescript = '{cmbExpenseType.Text}'", conn);

                OleDbDataReader read = cmd.ExecuteReader();
                read.Read();
                expCode = int.Parse(read["ExpenseCode"].ToString());
                //MessageBox.Show(expCode.ToString());
                conn.Close();
            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        //********************************method that loads all the current expenses from the database*****************************************************
        public void LoadCurrentExpense(string expID)
        {
            try
            {
                cmbExpenseType.Enabled = false;
                conn.Open();
                dgvExpList.ClearSelection();
                edit = true;
                OleDbCommand cmd = new OleDbCommand($@"SELECT B.DateOfExpense, A.ExpenseDescript, B.Cost 
                                                                FROM ExpenseType A INNER JOIN OperationalExpense B 
                                                                ON A.ExpenseCode = B.ExpenseCode
                                                                WHERE B.ExpenseID = {expID}", conn);

                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();

                //int.Parse(read["ExpenseCode"].ToString());

                dateExpenseSelect.SelectionStart = Convert.ToDateTime(reader["DateOfExpense"].ToString());
                dateExpenseSelect.SelectionEnd = Convert.ToDateTime(reader["DateOfExpense"].ToString());
                cmbExpenseType.Text = reader["ExpenseDescript"].ToString();
                txtExpenseAmt.Text = reader["Cost"].ToString();

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //make button submit_changes.visible = true, and button new_expense.visible = false;**************************************************************************************************************************************
        }



        //********************************Add expense to database*************************************************************
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            try
            {
                ExpenseCodeType();
                DateTime dtExp = dateExpenseSelect.SelectionRange.Start;
                double oldVal = 0;

                if (txtExpenseAmt.Text != "")
                    try
                    {
                        Int64 test1 = Int64.Parse(txtExpenseAmt.Text);
                    }
                    catch(Exception)
                    {
                        throw new Exception("Please enter a valid number");
                    }
                double newVal = Convert.ToDouble(txtExpenseAmt.Text);
                string logtext = $"Add expense {cmbExpenseType.SelectedItem.ToString()} on the {dateExpenseSelect.SelectionStart.ToShortDateString()} for date: {dtExp.ToShortDateString()}";

                if (MessageBox.Show("Are you sure that you would like to add " + cmbExpenseType.SelectedItem.ToString() + " totalling R" + txtExpenseAmt.Text + " as an expense", "Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        OleDbCommand command = new OleDbCommand($@"INSERT INTO OperationalExpense (DateOfExpense, Cost, ExpenseCode) VALUES ('{dtExp}', {double.Parse(txtExpenseAmt.Text)}, {expCode})", conn);
                        command.ExecuteNonQuery();
                        conn.Close();

                        WriteLog(logtext, oldVal, newVal);

                        dgvExpList.Refresh();
                        ListCurrentMonthExpsenses();
                        cmbExpenseType.Items.Clear();
                        LoadExpenseTypes();
                        clearAll();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
       
                    MessageBox.Show(cmbExpenseType.SelectedItem.ToString() + " was not added", "Request", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        //********************************btnEdit click that allows you to update the expenses in tab page 3*********************************************
        private void btnEditexp_Click(object sender, EventArgs e)
        {
            try
            {
                myRows = dgvExpList.SelectedRows[0];

                LoadCurrentExpense(myRows.Cells[3].Value.ToString());
                btnUpdateExp.Visible = true;
                btnDeleteExp.Visible = false;
                btnAddExpense.Visible = false;
                btnEditexp.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        


        //********************************btnUpdate that allows you to update an expense**************************************
        private void btnUpdateExp_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dtExp;
                dtExp = dateExpenseSelect.SelectionRange.Start;
                //DataGridViewRow myRows = dgvExpList.SelectedRows[0];
                //ExpenseID();
                string expenseID = myRows.Cells[3].Value.ToString();

                double oldVal = Convert.ToDouble(myRows.Cells[2].Value.ToString());
                double newVal = Convert.ToDouble(txtExpenseAmt.Text);
                string logtext = $"Edit expense {myRows.Cells[1].Value.ToString()}, ID: {expenseID} for date: {myRows.Cells[0].Value.ToString()}";

                string message = "Are you sure you want to update " + myRows.Cells[1].Value.ToString() + " on the " + myRows.Cells[0].Value.ToString() + " to R" + txtExpenseAmt.Text + "?";
                if (MessageBox.Show(message, "Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand($@"UPDATE OperationalExpense SET DateOfExpense = '{dtExp}', Cost = {double.Parse(txtExpenseAmt.Text)} WHERE ExpenseID = {expenseID}", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        WriteLog(logtext, oldVal, newVal);

                        ListCurrentMonthExpsenses();
                        clearAll();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(myRows.Cells[1].Value.ToString() + " was not updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvExpList.Refresh();
                txtExpenseAmt.Text = "";
                cmbExpenseType.Text = "Select the type of expense to add";
                LoadExpenseTypes();
                btnUpdateExp.Visible = false;
                btnDeleteExp.Visible = false;
                btnAddExpense.Visible = true;
                btnEditexp.Visible = false;
                cmbExpenseType.Enabled = true;
                edit = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        //********************************Remove the selected expense from the database when expense is selected on the datagridview
        private void btnDeleteExp_Click(object sender, EventArgs e)
        {
            try
            {
                //Selected expense row
                DataGridViewRow myRow = dgvExpList.SelectedRows[0];

                //Details for the log file
                double oldVal = Convert.ToDouble(myRow.Cells[2].Value.ToString());
                double newVal = 0;
                string logtext = $"Remove expense {myRow.Cells[1].Value.ToString()}, ID: {myRow.Cells[3].Value.ToString()} for date: {myRow.Cells[0].Value.ToString()}";

                //
                string expIDDel = (myRow.Cells[3].Value.ToString());
                string delItem = myRow.Cells[1].Value.ToString();
                string message = "Are you sure that you would like to remove " + delItem + " of R" + myRow.Cells[2].Value.ToString() + " on the " + myRow.Cells[0].Value.ToString();
                if (MessageBox.Show(message, "Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand($@"DELETE FROM OperationalExpense WHERE ExpenseID = {expIDDel}", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        ListCurrentMonthExpsenses();
                        WriteLog(logtext, oldVal, newVal);
                        clearAll();
                        //MessageBox.Show(delItem + " was removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(myRow.Cells[1].Value.ToString() + " was not removed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvExpList.Refresh();
                btnUpdateExp.Visible = false;
                btnDeleteExp.Visible = false;
                btnAddExpense.Visible = true;
                btnEditexp.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        //********************************Allows you to edit or delete an expense when an expense is selected from the datagridview*******************************
        private void dgvExpList_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow myRow = dgvExpList.SelectedRows[0];
                if (myRow == null)
                    throw new Exception("No entry has been chosen!");
                btnDeleteExp.Visible = true;
                btnEditexp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        //--------------------------------------------------------------------------------------END TAB PAGE 3-----------------------------------------------------------------------------------------------------















        //-------------------------------------------------------------------------------------BEGIN TAB PAGE 4-----------------------------------------------------------------------------------------------------
        public void ListCurrentMonthIncome()
        {
            try
            { 
                //set the date time picker from selected date to one month after selected date
                DateTime test = dateExpenseSelect.SelectionStart;
                DateTime start = new DateTime(test.Year, test.Month, 1, 0, 0, 0, 0);
                DateTime end = start.AddMonths(1).AddMinutes(-1);

                //add columns to datagridview
                conn.Open();
                string message = $@"SELECT B.DateOfPayment AS [Date], C.ClientName AS [Description], B.AmountPaid AS [Amount Paid], B.SaleID AS [Sale ID] 
                                                                FROM (Bookings A INNER JOIN Payment B ON B.BookingID = A.BookingID)
                                                                INNER JOIN Clients C ON A.ClientID = C.ClientID 
                                                                WHERE B.DateOfPayment BETWEEN #{start.ToShortDateString()}# AND #{end.ToShortDateString()}#
                                                                ORDER BY B.DateOfPayment
                                                               ";
                OleDbDataAdapter adapter = new OleDbDataAdapter(message, conn);

               
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Incomes");

                dgvIncomes.DataSource = ds;
                dgvIncomes.DataMember = "Incomes";
                dgvIncomes.Columns[1].Width = 250;
                foreach (DataGridViewColumn col in dgvIncomes.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
//________________________________________________________________________________________Method Loading Current Income_________________________________________________________________________
        public void LoadCurrentIncome(string SID)
        {
            try
            {
                //set the date time picker from selected date to one month after selected date
                DateTime test = dateExpenseSelect.SelectionStart;
                DateTime start = new DateTime(test.Year, test.Month, 1, 0, 0, 0, 0);
                DateTime end = start.AddMonths(1).AddMinutes(-1);

                txtDescr.Enabled = false;
                conn.Open();
                edit = true;
                OleDbCommand cmd = new OleDbCommand($@"SELECT B.DateOfPayment AS [Date], C.ClientName AS [Description], B.AmountPaid AS [Amount Paid], B.SaleID AS [Sale ID] 
                                                                FROM (Bookings A INNER JOIN Payment B ON B.BookingID = A.BookingID)
                                                                INNER JOIN Clients C ON A.ClientID = C.ClientID 
                                                                WHERE SaleID = {SID}", conn);

                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();

                dateExpenseSelect.SelectionStart = Convert.ToDateTime(reader["DateOfPayment"].ToString());
                dateExpenseSelect.SelectionEnd = Convert.ToDateTime(reader["DateOfPayment"].ToString());
                txtDescr.Text = reader["ClientName"].ToString();
                txtIncomeAmt.Text = reader["AmountPaid"].ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

//_______________________________________________________________________Method when datagridview is selected_______________________________________________________________________________________________________________________________________
        private void dgvIncomes_Click(object sender, EventArgs e)
        {
            //set buttons visible when datagridview row is selected
            try
            {
                DataGridViewRow myRow = dgvIncomes.SelectedRows[0];
                if (myRow == null)
                    throw new Exception("No entry has been chosen!");
                btnEditIncome.Visible = true;
                btnDeleteIncome.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }


        //-----------------------------------------------------------------------CHANGE PAYMENTS TAB (edit and delete incomes) (TAB PAGE 4)--------------------------------------------------------------------------------------------------------

        private void btnEditIncome_Click(object sender, EventArgs e)
        {
            try
            {
                //add desctription to textbox and set editible false
                DataGridViewRow myRow = dgvIncomes.SelectedRows[0];
                txtDescr.Text = myRow.Cells[1].Value.ToString();
                txtDescr.Enabled = false;

                //add amount to textbox and keep editible true
                txtIncomeAmt.Text = myRow.Cells[2].Value.ToString();
                btnUpdate.Visible = true;
                btnEditIncome.Visible = false;
                btnDeleteIncome.Visible = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //*******************************************************************************************************************


        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow myRow = dgvIncomes.SelectedRows[0];
                double oldVal = Convert.ToDouble(myRow.Cells[2].Value);
                double newVal = Convert.ToDouble(txtIncomeAmt.Text);
                string logtext = $"Edit Income {myRow.Cells[2].Value.ToString()} for salesID: {myRow.Cells[3].Value.ToString()} on date: {myRow.Cells[0].Value.ToString()}";

                string message = "Are you sure you want to change the income from R" + myRow.Cells[2].Value.ToString() +  " to R" + txtIncomeAmt.Text + "?";
                if (MessageBox.Show(message, "Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        //updates information selected
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand($@"UPDATE Payment SET AmountPaid = {double.Parse(txtIncomeAmt.Text)} WHERE SaleID = {myRow.Cells[3].Value}", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        WriteLog(logtext, oldVal, newVal);
                        ListCurrentMonthIncome();
                    }

                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(myRow.Cells[2].Value.ToString() + " was not updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //refresh page, and set all to original state
                dgvIncomes.Refresh();
                txtIncomeAmt.Text = "";
                txtDescr.Text = "";
                btnEditIncome.Visible = false;
                btnDeleteIncome.Visible = false;
                btnUpdate.Visible = false;
                txtDescr.Enabled = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}


//**************************************************Delete selected item****************************************************************************************
private void btnDeleteIncome_Click(object sender, EventArgs e)
        {
           try
            {
                DataGridViewRow myRow = dgvIncomes.SelectedRows[0];

                double oldVal = Convert.ToDouble(myRow.Cells[2].Value);
                double newVal = 0;
                string logtext = $"Remove payment of {myRow.Cells[1].Value.ToString()} of R{myRow.Cells[2].ToString()} paid on: {myRow.Cells[0].Value.ToString()}?";

                string message = "Are you sure that you would like to remove the payment made by " + myRow.Cells[1].Value.ToString() + " of R" + myRow.Cells[2].Value.ToString() + " paid on " + myRow.Cells[0].Value.ToString() + "?";
                if (MessageBox.Show(message, "Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand($@"DELETE FROM Payment WHERE SaleID = {myRow.Cells[3].Value}", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        WriteLog(logtext, oldVal, newVal);
                        ListCurrentMonthIncome();

                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(myRow.Cells[1].Value.ToString() + " was not removed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //refresh page, and set all to original state
                dgvIncomes.Refresh();
                txtIncomeAmt.Text = "";
                txtDescr.Text = "";
                btnEditIncome.Visible = false;
                btnDeleteIncome.Visible = false;
                btnUpdate.Visible = false;
                txtDescr.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-----------------------------------------------------------------------------------------------------END TAB PAGE 4-----------------------------------------------------------------------------------------------

        
            
            
            
            
            
            










            
            
        //----------------------------------------------------------------------------------------------------TREATMENTS TAB INFORMATION (TAB PAGE 5)-------------------------------------------------------------------------------------------

        //********************************Method that displays information from the database in the listBox on tab page 2**************************************//
        private void ReadTreatments()
        {
            //Clears the contens of the Treatments listBox
            lbxTreatments.Items.Clear();

            try
            {
                //Opens the DB connection
                conn.Open();

                //Command and datareader to read treatments from the DB into the listBox
                using (OleDbCommand command = new OleDbCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT Description FROM Treatments";

                    //reads information from the database
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lbxTreatments.Items.Add(reader["Description"].ToString());
                        }
                    }
                }
                //Close DB connection
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        //********************************
        private void dateExpenseSelect_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (!edit)
                ListCurrentMonthExpsenses();
        }



        //********************************Method to remove a treatment when you double click the treatments listbox
        private void lbxTreatments_DoubleClick(object sender, EventArgs e)
        {
            if (lbxTreatments.SelectedItem != null)
            {
                string treatName = "";
                foreach (string val in lbxTreatments.SelectedItems)
                {
                    treatName = val;
                }

                if (MessageBox.Show("Do you wish to remove " + treatName + " as a treatment?", "Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        conn.Open();

                        //OleDbDataAdapter adapter = new OleDbDataAdapter($@"SELECT ExpenseDescript FROM ExpenseType ORDER BY ExpenseDescript ASC", conn);
                        OleDbCommand cmd = new OleDbCommand($@"DELETE FROM Treatments WHERE Description = '{treatName}'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(treatName + " was successfully removed as a treatment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        ReadExpenseTypesEdit();
                        lbxTreatments.Items.Clear();
                        ReadTreatments();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show(treatName + " was not removed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You have not selected a valid expense type to remove", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        //********************************Button click adds a treatment into the database*************//
        private void btnNewTreatment_Click(object sender, EventArgs e)
        {
            try
            {

                if (((txtTreatmentDescription.Text) == null) && ((txtTreatmentCost.Text == null)))
                {
                    MessageBox.Show("Please enter a treatment description or treatment cost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (MessageBox.Show("Are you sure you want to add " + txtTreatmentDescription.Text + " as an expense", "Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand($@"INSERT INTO Treatments (Description, TreatmentCost) VALUES ('{txtTreatmentDescription.Text}', {double.Parse(txtTreatmentCost.Text)})", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    txtTreatmentDescription.Text = null;
                    txtTreatmentCost.Text = null;
                    lbxTreatments.Items.Clear();
                    ReadTreatments();

                }
                else
                {
                    MessageBox.Show(txtTreatmentDescription.Text + " was not added", "Treatment not added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            IEReport myReport = new IEReport();
            myReport.Show();
        }



        //-----------------------------------------------------------------------------------------------------------END TAB PAGE 5--------------------------------------------------------------------------------------
    }
}
