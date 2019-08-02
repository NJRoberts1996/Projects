namespace Chalique_Nail_Studio
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.tconAdmin = new System.Windows.Forms.TabControl();
            this.tabListExpenses = new System.Windows.Forms.TabPage();
            this.dgvIncomeMonthly = new System.Windows.Forms.DataGridView();
            this.lblMnthIncomeList = new System.Windows.Forms.Label();
            this.dgvMonthView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabTypeExpenses = new System.Windows.Forms.TabPage();
            this.btnAddExpenseType = new System.Windows.Forms.Button();
            this.txtExpenseType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxExpenses = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabNewExpense = new System.Windows.Forms.TabPage();
            this.btnDeleteExp = new System.Windows.Forms.Button();
            this.btnEditexp = new System.Windows.Forms.Button();
            this.dgvExpList = new System.Windows.Forms.DataGridView();
            this.dateExpenseSelect = new System.Windows.Forms.MonthCalendar();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExpenseAmt = new System.Windows.Forms.TextBox();
            this.cmbExpenseType = new System.Windows.Forms.ComboBox();
            this.btnUpdateExp = new System.Windows.Forms.Button();
            this.tabEditAndDeleteIncomes = new System.Windows.Forms.TabPage();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblExplain = new System.Windows.Forms.Label();
            this.btnDeleteIncome = new System.Windows.Forms.Button();
            this.txtIncomeAmt = new System.Windows.Forms.TextBox();
            this.lblAmt = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnEditIncome = new System.Windows.Forms.Button();
            this.dgvIncomes = new System.Windows.Forms.DataGridView();
            this.tabTreatments = new System.Windows.Forms.TabPage();
            this.txtTreatmentCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNewTreatment = new System.Windows.Forms.Button();
            this.txtTreatmentDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxTreatments = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tconAdmin.SuspendLayout();
            this.tabListExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomeMonthly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthView)).BeginInit();
            this.tabTypeExpenses.SuspendLayout();
            this.tabNewExpense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpList)).BeginInit();
            this.tabEditAndDeleteIncomes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomes)).BeginInit();
            this.tabTreatments.SuspendLayout();
            this.SuspendLayout();
            // 
            // tconAdmin
            // 
            this.tconAdmin.Controls.Add(this.tabListExpenses);
            this.tconAdmin.Controls.Add(this.tabTypeExpenses);
            this.tconAdmin.Controls.Add(this.tabNewExpense);
            this.tconAdmin.Controls.Add(this.tabEditAndDeleteIncomes);
            this.tconAdmin.Controls.Add(this.tabTreatments);
            this.tconAdmin.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tconAdmin.Location = new System.Drawing.Point(12, 12);
            this.tconAdmin.Name = "tconAdmin";
            this.tconAdmin.Padding = new System.Drawing.Point(0, 0);
            this.tconAdmin.SelectedIndex = 0;
            this.tconAdmin.Size = new System.Drawing.Size(650, 519);
            this.tconAdmin.TabIndex = 4;
            // 
            // tabListExpenses
            // 
            this.tabListExpenses.BackColor = System.Drawing.Color.Transparent;
            this.tabListExpenses.BackgroundImage = global::Chalique_Nail_Studio.Properties.Resources.Light_Blue;
            this.tabListExpenses.Controls.Add(this.dgvIncomeMonthly);
            this.tabListExpenses.Controls.Add(this.lblMnthIncomeList);
            this.tabListExpenses.Controls.Add(this.dgvMonthView);
            this.tabListExpenses.Controls.Add(this.label2);
            this.tabListExpenses.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabListExpenses.Location = new System.Drawing.Point(4, 26);
            this.tabListExpenses.Name = "tabListExpenses";
            this.tabListExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tabListExpenses.Size = new System.Drawing.Size(642, 489);
            this.tabListExpenses.TabIndex = 0;
            this.tabListExpenses.Text = "Expenses & Incomes";
            this.tabListExpenses.ToolTipText = "Expenses and Incomes page";
            this.tabListExpenses.Enter += new System.EventHandler(this.tabListExpenses_Enter);
            // 
            // dgvIncomeMonthly
            // 
            this.dgvIncomeMonthly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncomeMonthly.Location = new System.Drawing.Point(29, 271);
            this.dgvIncomeMonthly.Name = "dgvIncomeMonthly";
            this.dgvIncomeMonthly.Size = new System.Drawing.Size(593, 212);
            this.dgvIncomeMonthly.TabIndex = 10;
            this.toolTip1.SetToolTip(this.dgvIncomeMonthly, "List of all the current months Incomes");
            // 
            // lblMnthIncomeList
            // 
            this.lblMnthIncomeList.AutoSize = true;
            this.lblMnthIncomeList.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMnthIncomeList.Location = new System.Drawing.Point(26, 251);
            this.lblMnthIncomeList.Name = "lblMnthIncomeList";
            this.lblMnthIncomeList.Size = new System.Drawing.Size(259, 17);
            this.lblMnthIncomeList.TabIndex = 9;
            this.lblMnthIncomeList.Text = "List of all Incomes to date for the month:";
            // 
            // dgvMonthView
            // 
            this.dgvMonthView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthView.Location = new System.Drawing.Point(29, 33);
            this.dgvMonthView.Name = "dgvMonthView";
            this.dgvMonthView.Size = new System.Drawing.Size(593, 212);
            this.dgvMonthView.TabIndex = 8;
            this.toolTip1.SetToolTip(this.dgvMonthView, "List of all the current months expenses");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "List of all expenses to date for the month:";
            // 
            // tabTypeExpenses
            // 
            this.tabTypeExpenses.BackColor = System.Drawing.Color.Transparent;
            this.tabTypeExpenses.BackgroundImage = global::Chalique_Nail_Studio.Properties.Resources.Light_Blue;
            this.tabTypeExpenses.Controls.Add(this.btnAddExpenseType);
            this.tabTypeExpenses.Controls.Add(this.txtExpenseType);
            this.tabTypeExpenses.Controls.Add(this.label4);
            this.tabTypeExpenses.Controls.Add(this.lbxExpenses);
            this.tabTypeExpenses.Controls.Add(this.label3);
            this.tabTypeExpenses.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTypeExpenses.Location = new System.Drawing.Point(4, 26);
            this.tabTypeExpenses.Name = "tabTypeExpenses";
            this.tabTypeExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tabTypeExpenses.Size = new System.Drawing.Size(642, 489);
            this.tabTypeExpenses.TabIndex = 1;
            this.tabTypeExpenses.Text = "Expense Types";
            this.tabTypeExpenses.ToolTipText = "Type of expenses page";
            this.tabTypeExpenses.Enter += new System.EventHandler(this.tabTypeExpenses_Enter);
            // 
            // btnAddExpenseType
            // 
            this.btnAddExpenseType.Location = new System.Drawing.Point(369, 421);
            this.btnAddExpenseType.Name = "btnAddExpenseType";
            this.btnAddExpenseType.Size = new System.Drawing.Size(133, 49);
            this.btnAddExpenseType.TabIndex = 4;
            this.btnAddExpenseType.Text = "Add Expense Type";
            this.btnAddExpenseType.UseVisualStyleBackColor = true;
            this.btnAddExpenseType.Click += new System.EventHandler(this.btnAddExpenseType_Click);
            // 
            // txtExpenseType
            // 
            this.txtExpenseType.Location = new System.Drawing.Point(30, 440);
            this.txtExpenseType.Name = "txtExpenseType";
            this.txtExpenseType.Size = new System.Drawing.Size(306, 25);
            this.txtExpenseType.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "New Expense Type to be added:";
            // 
            // lbxExpenses
            // 
            this.lbxExpenses.FormattingEnabled = true;
            this.lbxExpenses.ItemHeight = 17;
            this.lbxExpenses.Location = new System.Drawing.Point(56, 75);
            this.lbxExpenses.Name = "lbxExpenses";
            this.lbxExpenses.Size = new System.Drawing.Size(392, 293);
            this.lbxExpenses.TabIndex = 1;
            this.toolTip1.SetToolTip(this.lbxExpenses, "Double click on an expense to remove it");
            this.lbxExpenses.DoubleClick += new System.EventHandler(this.lbxExpenses_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "List of Expense Types:";
            // 
            // tabNewExpense
            // 
            this.tabNewExpense.BackColor = System.Drawing.Color.Transparent;
            this.tabNewExpense.BackgroundImage = global::Chalique_Nail_Studio.Properties.Resources.Light_Blue;
            this.tabNewExpense.Controls.Add(this.btnDeleteExp);
            this.tabNewExpense.Controls.Add(this.btnEditexp);
            this.tabNewExpense.Controls.Add(this.dgvExpList);
            this.tabNewExpense.Controls.Add(this.dateExpenseSelect);
            this.tabNewExpense.Controls.Add(this.btnAddExpense);
            this.tabNewExpense.Controls.Add(this.label1);
            this.tabNewExpense.Controls.Add(this.txtExpenseAmt);
            this.tabNewExpense.Controls.Add(this.cmbExpenseType);
            this.tabNewExpense.Controls.Add(this.btnUpdateExp);
            this.tabNewExpense.Location = new System.Drawing.Point(4, 26);
            this.tabNewExpense.Name = "tabNewExpense";
            this.tabNewExpense.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewExpense.Size = new System.Drawing.Size(642, 489);
            this.tabNewExpense.TabIndex = 2;
            this.tabNewExpense.Text = "New, Change Expense";
            this.tabNewExpense.ToolTipText = "New or change expenses page";
            this.tabNewExpense.Enter += new System.EventHandler(this.tabNewExpense_Enter);
            // 
            // btnDeleteExp
            // 
            this.btnDeleteExp.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteExp.Location = new System.Drawing.Point(381, 182);
            this.btnDeleteExp.Name = "btnDeleteExp";
            this.btnDeleteExp.Size = new System.Drawing.Size(142, 43);
            this.btnDeleteExp.TabIndex = 17;
            this.btnDeleteExp.Text = "Delete expense";
            this.btnDeleteExp.UseVisualStyleBackColor = true;
            this.btnDeleteExp.Visible = false;
            this.btnDeleteExp.Click += new System.EventHandler(this.btnDeleteExp_Click);
            // 
            // btnEditexp
            // 
            this.btnEditexp.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditexp.Location = new System.Drawing.Point(12, 182);
            this.btnEditexp.Name = "btnEditexp";
            this.btnEditexp.Size = new System.Drawing.Size(142, 43);
            this.btnEditexp.TabIndex = 16;
            this.btnEditexp.Text = "Edit expense";
            this.btnEditexp.UseVisualStyleBackColor = true;
            this.btnEditexp.Click += new System.EventHandler(this.btnEditexp_Click);
            // 
            // dgvExpList
            // 
            this.dgvExpList.AllowUserToAddRows = false;
            this.dgvExpList.AllowUserToDeleteRows = false;
            this.dgvExpList.AllowUserToOrderColumns = true;
            this.dgvExpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvExpList.Location = new System.Drawing.Point(12, 231);
            this.dgvExpList.Name = "dgvExpList";
            this.dgvExpList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpList.Size = new System.Drawing.Size(620, 252);
            this.dgvExpList.TabIndex = 15;
            this.toolTip1.SetToolTip(this.dgvExpList, "Select Something to edit or delete");
            this.dgvExpList.Click += new System.EventHandler(this.dgvExpList_Click);
            // 
            // dateExpenseSelect
            // 
            this.dateExpenseSelect.Location = new System.Drawing.Point(12, 12);
            this.dateExpenseSelect.Name = "dateExpenseSelect";
            this.dateExpenseSelect.TabIndex = 14;
            this.dateExpenseSelect.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dateExpenseSelect_DateChanged);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpense.Location = new System.Drawing.Point(313, 103);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(142, 43);
            this.btnAddExpense.TabIndex = 13;
            this.btnAddExpense.Text = "Add the expense";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cost of expense in R:";
            // 
            // txtExpenseAmt
            // 
            this.txtExpenseAmt.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpenseAmt.Location = new System.Drawing.Point(409, 58);
            this.txtExpenseAmt.Name = "txtExpenseAmt";
            this.txtExpenseAmt.Size = new System.Drawing.Size(100, 25);
            this.txtExpenseAmt.TabIndex = 11;
            // 
            // cmbExpenseType
            // 
            this.cmbExpenseType.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpenseType.FormattingEnabled = true;
            this.cmbExpenseType.Location = new System.Drawing.Point(270, 12);
            this.cmbExpenseType.Name = "cmbExpenseType";
            this.cmbExpenseType.Size = new System.Drawing.Size(266, 25);
            this.cmbExpenseType.TabIndex = 10;
            this.cmbExpenseType.Text = "Select the type of expense to add";
            // 
            // btnUpdateExp
            // 
            this.btnUpdateExp.Location = new System.Drawing.Point(313, 103);
            this.btnUpdateExp.Name = "btnUpdateExp";
            this.btnUpdateExp.Size = new System.Drawing.Size(142, 43);
            this.btnUpdateExp.TabIndex = 18;
            this.btnUpdateExp.Text = "Update Expense";
            this.btnUpdateExp.UseVisualStyleBackColor = true;
            this.btnUpdateExp.Click += new System.EventHandler(this.btnUpdateExp_Click);
            // 
            // tabEditAndDeleteIncomes
            // 
            this.tabEditAndDeleteIncomes.BackgroundImage = global::Chalique_Nail_Studio.Properties.Resources.Light_Blue;
            this.tabEditAndDeleteIncomes.Controls.Add(this.txtDescr);
            this.tabEditAndDeleteIncomes.Controls.Add(this.btnUpdate);
            this.tabEditAndDeleteIncomes.Controls.Add(this.lblExplain);
            this.tabEditAndDeleteIncomes.Controls.Add(this.btnDeleteIncome);
            this.tabEditAndDeleteIncomes.Controls.Add(this.txtIncomeAmt);
            this.tabEditAndDeleteIncomes.Controls.Add(this.lblAmt);
            this.tabEditAndDeleteIncomes.Controls.Add(this.lblDescription);
            this.tabEditAndDeleteIncomes.Controls.Add(this.btnEditIncome);
            this.tabEditAndDeleteIncomes.Controls.Add(this.dgvIncomes);
            this.tabEditAndDeleteIncomes.Location = new System.Drawing.Point(4, 26);
            this.tabEditAndDeleteIncomes.Name = "tabEditAndDeleteIncomes";
            this.tabEditAndDeleteIncomes.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditAndDeleteIncomes.Size = new System.Drawing.Size(642, 489);
            this.tabEditAndDeleteIncomes.TabIndex = 4;
            this.tabEditAndDeleteIncomes.Text = "Change Incomes";
            this.tabEditAndDeleteIncomes.ToolTipText = "Edit and delete Incomes page";
            this.tabEditAndDeleteIncomes.UseVisualStyleBackColor = true;
            this.tabEditAndDeleteIncomes.Enter += new System.EventHandler(this.tabEditAndDeleteIncomes_Enter);
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(106, 334);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(114, 25);
            this.txtDescr.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(239, 427);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 41);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblExplain
            // 
            this.lblExplain.AutoSize = true;
            this.lblExplain.Location = new System.Drawing.Point(9, 11);
            this.lblExplain.MaximumSize = new System.Drawing.Size(550, 40);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(545, 34);
            this.lblExplain.TabIndex = 7;
            this.lblExplain.Text = "Take note that adjusting any incomes without justification is illegal in accordan" +
    "ce with the South African law. Only adjust it if a mistake was made in finalisin" +
    "g a booking.";
            // 
            // btnDeleteIncome
            // 
            this.btnDeleteIncome.Location = new System.Drawing.Point(461, 427);
            this.btnDeleteIncome.Name = "btnDeleteIncome";
            this.btnDeleteIncome.Size = new System.Drawing.Size(110, 41);
            this.btnDeleteIncome.TabIndex = 6;
            this.btnDeleteIncome.Text = "Delete";
            this.btnDeleteIncome.UseVisualStyleBackColor = true;
            this.btnDeleteIncome.Click += new System.EventHandler(this.btnDeleteIncome_Click);
            // 
            // txtIncomeAmt
            // 
            this.txtIncomeAmt.Location = new System.Drawing.Point(106, 383);
            this.txtIncomeAmt.Name = "txtIncomeAmt";
            this.txtIncomeAmt.Size = new System.Drawing.Size(114, 25);
            this.txtIncomeAmt.TabIndex = 5;
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.Location = new System.Drawing.Point(37, 386);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(63, 17);
            this.lblAmt.TabIndex = 3;
            this.lblAmt.Text = "Amount:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(14, 336);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // btnEditIncome
            // 
            this.btnEditIncome.Location = new System.Drawing.Point(7, 427);
            this.btnEditIncome.Name = "btnEditIncome";
            this.btnEditIncome.Size = new System.Drawing.Size(110, 41);
            this.btnEditIncome.TabIndex = 1;
            this.btnEditIncome.Text = "Edit";
            this.btnEditIncome.UseVisualStyleBackColor = true;
            this.btnEditIncome.Click += new System.EventHandler(this.btnEditIncome_Click);
            // 
            // dgvIncomes
            // 
            this.dgvIncomes.AllowUserToAddRows = false;
            this.dgvIncomes.AllowUserToDeleteRows = false;
            this.dgvIncomes.AllowUserToOrderColumns = true;
            this.dgvIncomes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncomes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvIncomes.Location = new System.Drawing.Point(7, 48);
            this.dgvIncomes.MultiSelect = false;
            this.dgvIncomes.Name = "dgvIncomes";
            this.dgvIncomes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncomes.Size = new System.Drawing.Size(564, 265);
            this.dgvIncomes.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dgvIncomes, "Please select a payment to change or remove");
            this.dgvIncomes.Click += new System.EventHandler(this.dgvIncomes_Click);
            // 
            // tabTreatments
            // 
            this.tabTreatments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabTreatments.BackgroundImage = global::Chalique_Nail_Studio.Properties.Resources.Light_Blue;
            this.tabTreatments.Controls.Add(this.txtTreatmentCost);
            this.tabTreatments.Controls.Add(this.label7);
            this.tabTreatments.Controls.Add(this.btnNewTreatment);
            this.tabTreatments.Controls.Add(this.txtTreatmentDescription);
            this.tabTreatments.Controls.Add(this.label5);
            this.tabTreatments.Controls.Add(this.lbxTreatments);
            this.tabTreatments.Controls.Add(this.label6);
            this.tabTreatments.Location = new System.Drawing.Point(4, 26);
            this.tabTreatments.Name = "tabTreatments";
            this.tabTreatments.Size = new System.Drawing.Size(642, 489);
            this.tabTreatments.TabIndex = 3;
            this.tabTreatments.Text = "Treatments";
            this.tabTreatments.ToolTipText = "Treatments page";
            this.tabTreatments.Enter += new System.EventHandler(this.tabTreatments_Enter);
            // 
            // txtTreatmentCost
            // 
            this.txtTreatmentCost.Location = new System.Drawing.Point(139, 436);
            this.txtTreatmentCost.Name = "txtTreatmentCost";
            this.txtTreatmentCost.Size = new System.Drawing.Size(81, 25);
            this.txtTreatmentCost.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(34, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Treatment cost:";
            // 
            // btnNewTreatment
            // 
            this.btnNewTreatment.Location = new System.Drawing.Point(432, 391);
            this.btnNewTreatment.Name = "btnNewTreatment";
            this.btnNewTreatment.Size = new System.Drawing.Size(91, 49);
            this.btnNewTreatment.TabIndex = 9;
            this.btnNewTreatment.Text = "Add Treatment";
            this.btnNewTreatment.UseVisualStyleBackColor = true;
            this.btnNewTreatment.Click += new System.EventHandler(this.btnNewTreatment_Click);
            // 
            // txtTreatmentDescription
            // 
            this.txtTreatmentDescription.Location = new System.Drawing.Point(37, 391);
            this.txtTreatmentDescription.Name = "txtTreatmentDescription";
            this.txtTreatmentDescription.Size = new System.Drawing.Size(337, 25);
            this.txtTreatmentDescription.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(34, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "New Treatment to be added:";
            // 
            // lbxTreatments
            // 
            this.lbxTreatments.FormattingEnabled = true;
            this.lbxTreatments.ItemHeight = 17;
            this.lbxTreatments.Location = new System.Drawing.Point(43, 42);
            this.lbxTreatments.Name = "lbxTreatments";
            this.lbxTreatments.Size = new System.Drawing.Size(392, 293);
            this.lbxTreatments.TabIndex = 6;
            this.toolTip1.SetToolTip(this.lbxTreatments, "Double click to remove a treatment type");
            this.lbxTreatments.DoubleClick += new System.EventHandler(this.lbxTreatments_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(40, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "List of Treatments";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(228, 544);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(174, 37);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "View Report";
            this.toolTip1.SetToolTip(this.btnReport, "Click to generate report");
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(677, 601);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.tconAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tconAdmin.ResumeLayout(false);
            this.tabListExpenses.ResumeLayout(false);
            this.tabListExpenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomeMonthly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthView)).EndInit();
            this.tabTypeExpenses.ResumeLayout(false);
            this.tabTypeExpenses.PerformLayout();
            this.tabNewExpense.ResumeLayout(false);
            this.tabNewExpense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpList)).EndInit();
            this.tabEditAndDeleteIncomes.ResumeLayout(false);
            this.tabEditAndDeleteIncomes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomes)).EndInit();
            this.tabTreatments.ResumeLayout(false);
            this.tabTreatments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tconAdmin;
        private System.Windows.Forms.TabPage tabListExpenses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabTypeExpenses;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnAddExpenseType;
        private System.Windows.Forms.TextBox txtExpenseType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxExpenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabNewExpense;
        private System.Windows.Forms.MonthCalendar dateExpenseSelect;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExpenseAmt;
        private System.Windows.Forms.ComboBox cmbExpenseType;
        private System.Windows.Forms.DataGridView dgvMonthView;
        private System.Windows.Forms.DataGridView dgvExpList;
        private System.Windows.Forms.TabPage tabTreatments;
        private System.Windows.Forms.TextBox txtTreatmentCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNewTreatment;
        private System.Windows.Forms.TextBox txtTreatmentDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxTreatments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeleteExp;
        private System.Windows.Forms.Button btnEditexp;
        private System.Windows.Forms.Button btnUpdateExp;
        private System.Windows.Forms.TabPage tabEditAndDeleteIncomes;
        private System.Windows.Forms.Label lblExplain;
        private System.Windows.Forms.Button btnDeleteIncome;
        private System.Windows.Forms.TextBox txtIncomeAmt;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnEditIncome;
        private System.Windows.Forms.DataGridView dgvIncomes;
        private System.Windows.Forms.DataGridView dgvIncomeMonthly;
        private System.Windows.Forms.Label lblMnthIncomeList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtDescr;
    }
}