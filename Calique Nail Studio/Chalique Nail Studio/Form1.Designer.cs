namespace Chalique_Nail_Studio
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pink1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pink2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailFunctionalityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDefaultMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeEmailSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackupLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dateSelect = new System.Windows.Forms.MonthCalendar();
            this.btnEditBooking = new System.Windows.Forms.Button();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.txtBookDetails = new System.Windows.Forms.TextBox();
            this.tlpBookings = new System.Windows.Forms.TableLayoutPanel();
            this.txtDay1 = new System.Windows.Forms.TextBox();
            this.txtDay2 = new System.Windows.Forms.TextBox();
            this.txtDay3 = new System.Windows.Forms.TextBox();
            this.txtDay4 = new System.Windows.Forms.TextBox();
            this.txtDay5 = new System.Windows.Forms.TextBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bookingsRefresh = new System.Windows.Forms.Timer(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tlpBookings.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.menuToolStripMenuItem,
            this.emailFunctionalityToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(42, 21);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.closeToolStripMenuItem1.Text = "&Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.menuToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.menuToolStripMenuItem.Text = "&View";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purpleToolStripMenuItem,
            this.pink1ToolStripMenuItem,
            this.pink2ToolStripMenuItem});
            this.backgroundToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.backgroundToolStripMenuItem.Text = "&Background";
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.purpleToolStripMenuItem.Text = "Purple";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
            // 
            // pink1ToolStripMenuItem
            // 
            this.pink1ToolStripMenuItem.Name = "pink1ToolStripMenuItem";
            this.pink1ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.pink1ToolStripMenuItem.Text = "Pink 1";
            this.pink1ToolStripMenuItem.Click += new System.EventHandler(this.pinkToolStripMenuItem_Click);
            // 
            // pink2ToolStripMenuItem
            // 
            this.pink2ToolStripMenuItem.Name = "pink2ToolStripMenuItem";
            this.pink2ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.pink2ToolStripMenuItem.Text = "Pink 2";
            this.pink2ToolStripMenuItem.Click += new System.EventHandler(this.pink2ToolStripMenuItem_Click);
            // 
            // emailFunctionalityToolStripMenuItem
            // 
            this.emailFunctionalityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeDefaultMessageToolStripMenuItem,
            this.changeEmailSettingsToolStripMenuItem,
            this.changeBackupLocationToolStripMenuItem,
            this.disableBackupToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.emailFunctionalityToolStripMenuItem.Name = "emailFunctionalityToolStripMenuItem";
            this.emailFunctionalityToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.emailFunctionalityToolStripMenuItem.Text = "&Options";
            // 
            // changeDefaultMessageToolStripMenuItem
            // 
            this.changeDefaultMessageToolStripMenuItem.Name = "changeDefaultMessageToolStripMenuItem";
            this.changeDefaultMessageToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.changeDefaultMessageToolStripMenuItem.Text = "Change Email Message";
            this.changeDefaultMessageToolStripMenuItem.Click += new System.EventHandler(this.changeDefaultMessageToolStripMenuItem_Click);
            // 
            // changeEmailSettingsToolStripMenuItem
            // 
            this.changeEmailSettingsToolStripMenuItem.Name = "changeEmailSettingsToolStripMenuItem";
            this.changeEmailSettingsToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.changeEmailSettingsToolStripMenuItem.Text = "Email Account Settings";
            this.changeEmailSettingsToolStripMenuItem.Click += new System.EventHandler(this.changeEmailSettingsToolStripMenuItem_Click);
            // 
            // changeBackupLocationToolStripMenuItem
            // 
            this.changeBackupLocationToolStripMenuItem.Name = "changeBackupLocationToolStripMenuItem";
            this.changeBackupLocationToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.changeBackupLocationToolStripMenuItem.Text = "Change Backup Location";
            this.changeBackupLocationToolStripMenuItem.Click += new System.EventHandler(this.changeBackupLocationToolStripMenuItem_Click);
            // 
            // disableBackupToolStripMenuItem
            // 
            this.disableBackupToolStripMenuItem.Name = "disableBackupToolStripMenuItem";
            this.disableBackupToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.disableBackupToolStripMenuItem.Text = "Toggle Backup";
            this.disableBackupToolStripMenuItem.Click += new System.EventHandler(this.disableBackupToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.usersToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.usersToolStripMenuItem.Text = "&Employee Options";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.helpToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.ReshowDelay = 100;
            // 
            // dateSelect
            // 
            this.dateSelect.BackColor = System.Drawing.Color.Maroon;
            this.dateSelect.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.dateSelect.Location = new System.Drawing.Point(18, 60);
            this.dateSelect.Name = "dateSelect";
            this.dateSelect.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dateSelect, "Select a date to view the bookings for the following 5 days");
            this.dateSelect.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dateSelect_DateSelected);
            this.dateSelect.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.dateSelect_DateSelected);
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.BackColor = System.Drawing.Color.Thistle;
            this.btnEditBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBooking.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBooking.Location = new System.Drawing.Point(41, 499);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(174, 37);
            this.btnEditBooking.TabIndex = 4;
            this.btnEditBooking.Text = "Edit Booking";
            this.toolTip1.SetToolTip(this.btnEditBooking, "Edit the selected booking");
            this.btnEditBooking.UseVisualStyleBackColor = false;
            this.btnEditBooking.Visible = false;
            this.btnEditBooking.Click += new System.EventHandler(this.btnEditBooking_Click);
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.BackColor = System.Drawing.Color.Thistle;
            this.btnNewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBooking.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBooking.Location = new System.Drawing.Point(246, 499);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(174, 37);
            this.btnNewBooking.TabIndex = 5;
            this.btnNewBooking.Text = "New Booking";
            this.toolTip1.SetToolTip(this.btnNewBooking, "Create a new booking");
            this.btnNewBooking.UseVisualStyleBackColor = false;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Thistle;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(451, 499);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(174, 37);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel Booking";
            this.toolTip1.SetToolTip(this.btnCancel, "Cancel the selected booking");
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Thistle;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(653, 499);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(174, 37);
            this.btnFinish.TabIndex = 8;
            this.btnFinish.Text = "Finish Booking";
            this.toolTip1.SetToolTip(this.btnFinish, "Finalise the booking\r\n  Used to manage payment\r\n  after a booking is  complete.");
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtBookDetails
            // 
            this.txtBookDetails.BackColor = System.Drawing.Color.Thistle;
            this.txtBookDetails.Location = new System.Drawing.Point(18, 248);
            this.txtBookDetails.Multiline = true;
            this.txtBookDetails.Name = "txtBookDetails";
            this.txtBookDetails.ReadOnly = true;
            this.txtBookDetails.Size = new System.Drawing.Size(227, 225);
            this.txtBookDetails.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtBookDetails, "Details of the selected apointment.\r\n  Use the [Edit Booking] button to edit deta" +
        "ils.\r\n  Use the [Cancel Booking] button to cancel the booking.");
            this.txtBookDetails.Visible = false;
            // 
            // tlpBookings
            // 
            this.tlpBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBookings.AutoScroll = true;
            this.tlpBookings.BackColor = System.Drawing.Color.Transparent;
            this.tlpBookings.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpBookings.ColumnCount = 5;
            this.tlpBookings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBookings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBookings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBookings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBookings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBookings.Controls.Add(this.txtDay1, 0, 0);
            this.tlpBookings.Controls.Add(this.txtDay2, 1, 0);
            this.tlpBookings.Controls.Add(this.txtDay3, 2, 0);
            this.tlpBookings.Controls.Add(this.txtDay4, 3, 0);
            this.tlpBookings.Controls.Add(this.txtDay5, 4, 0);
            this.tlpBookings.Location = new System.Drawing.Point(280, 60);
            this.tlpBookings.Name = "tlpBookings";
            this.tlpBookings.RowCount = 1;
            this.tlpBookings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBookings.Size = new System.Drawing.Size(547, 413);
            this.tlpBookings.TabIndex = 6;
            this.toolTip1.SetToolTip(this.tlpBookings, "Select a booking to view the details.\r\nTo make a new booking click [New Booking]");
            // 
            // txtDay1
            // 
            this.txtDay1.BackColor = System.Drawing.Color.White;
            this.txtDay1.Location = new System.Drawing.Point(4, 4);
            this.txtDay1.Name = "txtDay1";
            this.txtDay1.ReadOnly = true;
            this.txtDay1.Size = new System.Drawing.Size(99, 20);
            this.txtDay1.TabIndex = 0;
            // 
            // txtDay2
            // 
            this.txtDay2.BackColor = System.Drawing.Color.White;
            this.txtDay2.Location = new System.Drawing.Point(113, 4);
            this.txtDay2.Name = "txtDay2";
            this.txtDay2.ReadOnly = true;
            this.txtDay2.Size = new System.Drawing.Size(99, 20);
            this.txtDay2.TabIndex = 1;
            // 
            // txtDay3
            // 
            this.txtDay3.BackColor = System.Drawing.Color.White;
            this.txtDay3.Location = new System.Drawing.Point(222, 4);
            this.txtDay3.Name = "txtDay3";
            this.txtDay3.ReadOnly = true;
            this.txtDay3.Size = new System.Drawing.Size(99, 20);
            this.txtDay3.TabIndex = 2;
            // 
            // txtDay4
            // 
            this.txtDay4.BackColor = System.Drawing.Color.White;
            this.txtDay4.Location = new System.Drawing.Point(331, 4);
            this.txtDay4.Name = "txtDay4";
            this.txtDay4.ReadOnly = true;
            this.txtDay4.Size = new System.Drawing.Size(99, 20);
            this.txtDay4.TabIndex = 3;
            // 
            // txtDay5
            // 
            this.txtDay5.BackColor = System.Drawing.Color.White;
            this.txtDay5.Location = new System.Drawing.Point(440, 4);
            this.txtDay5.Name = "txtDay5";
            this.txtDay5.ReadOnly = true;
            this.txtDay5.Size = new System.Drawing.Size(100, 20);
            this.txtDay5.TabIndex = 4;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Thistle;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(780, 0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(64, 25);
            this.btnAdmin.TabIndex = 9;
            this.btnAdmin.Text = "Admin";
            this.toolTip1.SetToolTip(this.btnAdmin, "Open the administration window.\r\nUsed to manage general finances.");
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.Thistle;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.Location = new System.Drawing.Point(668, 0);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(112, 25);
            this.btnClients.TabIndex = 10;
            this.btnClients.Text = "Manage Clients";
            this.toolTip1.SetToolTip(this.btnClients, "Manage the clients here.\r\nUsed to add, change and remove Clients");
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // bookingsRefresh
            // 
            this.bookingsRefresh.Interval = 300000;
            this.bookingsRefresh.Tick += new System.EventHandler(this.bookingsRefresh_Tick);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.closeToolStripMenuItem.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.closeToolStripMenuItem.Text = "&Close";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select a date to see bookings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Click on a booking to see the details";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chalique_Nail_Studio.Properties.Resources.Light_Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tlpBookings);
            this.Controls.Add(this.btnNewBooking);
            this.Controls.Add(this.btnEditBooking);
            this.Controls.Add(this.txtBookDetails);
            this.Controls.Add(this.dateSelect);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chalique Nail Studio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmMain_HelpRequested);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tlpBookings.ResumeLayout(false);
            this.tlpBookings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MonthCalendar dateSelect;
        private System.Windows.Forms.TextBox txtBookDetails;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnEditBooking;
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.TableLayoutPanel tlpBookings;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDay1;
        private System.Windows.Forms.TextBox txtDay2;
        private System.Windows.Forms.TextBox txtDay3;
        private System.Windows.Forms.TextBox txtDay4;
        private System.Windows.Forms.TextBox txtDay5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pink1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pink2ToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Timer bookingsRefresh;
        private System.Windows.Forms.ToolStripMenuItem emailFunctionalityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeDefaultMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeEmailSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBackupLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

