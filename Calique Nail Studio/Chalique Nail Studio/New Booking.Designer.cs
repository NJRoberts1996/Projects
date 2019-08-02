namespace Chalique_Nail_Studio
{
    partial class New_Booking
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
            this.pickDate = new System.Windows.Forms.MonthCalendar();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClientNumber = new System.Windows.Forms.TextBox();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.cmbTreatment = new System.Windows.Forms.ComboBox();
            this.cmbPrefTech = new System.Windows.Forms.ComboBox();
            this.lbxTreatmentList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.notifyDone = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmbTimeEstimate = new System.Windows.Forms.ComboBox();
            this.lblTimeEstimate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pickDate
            // 
            this.pickDate.Location = new System.Drawing.Point(10, 10);
            this.pickDate.Name = "pickDate";
            this.pickDate.TabIndex = 10;
            this.pickDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.pickDate_DateChanged);
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(410, 10);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(180, 20);
            this.txtClientName.TabIndex = 0;
            this.txtClientName.TextChanged += new System.EventHandler(this.txtClientName_TextChanged);
            this.txtClientName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClientName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(249, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(249, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time of booking:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(249, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Treatment:";
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.BackColor = System.Drawing.Color.Thistle;
            this.btnNewBooking.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnNewBooking.FlatAppearance.BorderSize = 2;
            this.btnNewBooking.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBooking.Location = new System.Drawing.Point(10, 230);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(162, 35);
            this.btnNewBooking.TabIndex = 7;
            this.btnNewBooking.Text = "Complete Booking";
            this.btnNewBooking.UseVisualStyleBackColor = false;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Thistle;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(178, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(243, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preferred Technician:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(249, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Client email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(249, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Client tel number:";
            // 
            // txtClientNumber
            // 
            this.txtClientNumber.Location = new System.Drawing.Point(410, 36);
            this.txtClientNumber.Name = "txtClientNumber";
            this.txtClientNumber.Size = new System.Drawing.Size(180, 20);
            this.txtClientNumber.TabIndex = 1;
            this.txtClientNumber.TextChanged += new System.EventHandler(this.txtClientNumber_TextChanged);
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.Location = new System.Drawing.Point(410, 62);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(180, 20);
            this.txtClientEmail.TabIndex = 2;
            this.txtClientEmail.TextChanged += new System.EventHandler(this.txtClientNumber_TextChanged);
            // 
            // cmbTreatment
            // 
            this.cmbTreatment.FormattingEnabled = true;
            this.cmbTreatment.Items.AddRange(new object[] {
            "Standard",
            "Delux"});
            this.cmbTreatment.Location = new System.Drawing.Point(410, 142);
            this.cmbTreatment.Name = "cmbTreatment";
            this.cmbTreatment.Size = new System.Drawing.Size(180, 21);
            this.cmbTreatment.TabIndex = 5;
            this.cmbTreatment.DropDownClosed += new System.EventHandler(this.cmbTreatment_DropDownClosed);
            this.cmbTreatment.Click += new System.EventHandler(this.cmbTreatment_Click);
            this.cmbTreatment.Enter += new System.EventHandler(this.DropDown);
            // 
            // cmbPrefTech
            // 
            this.cmbPrefTech.FormattingEnabled = true;
            this.cmbPrefTech.Location = new System.Drawing.Point(410, 115);
            this.cmbPrefTech.Name = "cmbPrefTech";
            this.cmbPrefTech.Size = new System.Drawing.Size(180, 21);
            this.cmbPrefTech.TabIndex = 4;
            this.cmbPrefTech.SelectedIndexChanged += new System.EventHandler(this.cmbPrefTech_SelectedIndexChanged);
            this.cmbPrefTech.Click += new System.EventHandler(this.DropDown);
            this.cmbPrefTech.Enter += new System.EventHandler(this.DropDown);
            // 
            // lbxTreatmentList
            // 
            this.lbxTreatmentList.FormattingEnabled = true;
            this.lbxTreatmentList.Location = new System.Drawing.Point(410, 170);
            this.lbxTreatmentList.Name = "lbxTreatmentList";
            this.lbxTreatmentList.Size = new System.Drawing.Size(180, 95);
            this.lbxTreatmentList.TabIndex = 16;
            this.lbxTreatmentList.DoubleClick += new System.EventHandler(this.lbxTreatmentList_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(249, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Treatment list:";
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30"});
            this.cmbTime.Location = new System.Drawing.Point(436, 88);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(121, 21);
            this.cmbTime.TabIndex = 3;
            this.cmbTime.Click += new System.EventHandler(this.DropDown);
            this.cmbTime.Enter += new System.EventHandler(this.DropDown);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Thistle;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(328, 230);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 35);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // notifyDone
            // 
            this.notifyDone.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyDone.Text = "notifyIcon1";
            this.notifyDone.Visible = true;
            // 
            // cmbTimeEstimate
            // 
            this.cmbTimeEstimate.FormattingEnabled = true;
            this.cmbTimeEstimate.Items.AddRange(new object[] {
            "30   Minutes",
            "60   Minutes",
            "90   Minutes",
            "120 Minutes",
            "150 Minutes"});
            this.cmbTimeEstimate.Location = new System.Drawing.Point(178, 191);
            this.cmbTimeEstimate.Name = "cmbTimeEstimate";
            this.cmbTimeEstimate.Size = new System.Drawing.Size(121, 21);
            this.cmbTimeEstimate.TabIndex = 6;
            this.cmbTimeEstimate.Click += new System.EventHandler(this.DropDown);
            this.cmbTimeEstimate.Enter += new System.EventHandler(this.DropDown);
            // 
            // lblTimeEstimate
            // 
            this.lblTimeEstimate.AutoSize = true;
            this.lblTimeEstimate.BackColor = System.Drawing.Color.Thistle;
            this.lblTimeEstimate.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeEstimate.ForeColor = System.Drawing.Color.Black;
            this.lblTimeEstimate.Location = new System.Drawing.Point(48, 192);
            this.lblTimeEstimate.Name = "lblTimeEstimate";
            this.lblTimeEstimate.Size = new System.Drawing.Size(110, 18);
            this.lblTimeEstimate.TabIndex = 19;
            this.lblTimeEstimate.Text = "Time estimate:";
            // 
            // New_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chalique_Nail_Studio.Properties.Resources.Light_Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 273);
            this.ControlBox = false;
            this.Controls.Add(this.cmbTimeEstimate);
            this.Controls.Add(this.lblTimeEstimate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbxTreatmentList);
            this.Controls.Add(this.cmbPrefTech);
            this.Controls.Add(this.cmbTreatment);
            this.Controls.Add(this.txtClientEmail);
            this.Controls.Add(this.txtClientNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewBooking);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.pickDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "New_Booking";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar pickDate;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.ComboBox cmbPrefTech;
        private System.Windows.Forms.ListBox lbxTreatmentList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NotifyIcon notifyDone;
        private System.Windows.Forms.ComboBox cmbTimeEstimate;
        private System.Windows.Forms.Label lblTimeEstimate;
        private System.Windows.Forms.TextBox txtClientNumber;
        public System.Windows.Forms.ComboBox cmbTreatment;
    }
}