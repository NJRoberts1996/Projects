namespace Chalique_Nail_Studio
{
    partial class Finish_booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finish_booking));
            this.btnFinalize = new System.Windows.Forms.Button();
            this.lbxTreatments = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTreatments = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientNumber = new System.Windows.Forms.TextBox();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBookingNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddTreatment = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSuggestedPrice = new System.Windows.Forms.Label();
            this.txtFinalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.notifyDone = new System.Windows.Forms.NotifyIcon(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.lbxTreatments2 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFinalize
            // 
            this.btnFinalize.BackColor = System.Drawing.Color.Thistle;
            this.btnFinalize.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnFinalize.FlatAppearance.BorderSize = 2;
            this.btnFinalize.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalize.Location = new System.Drawing.Point(12, 262);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(226, 35);
            this.btnFinalize.TabIndex = 20;
            this.btnFinalize.Text = "Done";
            this.toolTip1.SetToolTip(this.btnFinalize, "Confirm ");
            this.btnFinalize.UseVisualStyleBackColor = false;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // lbxTreatments
            // 
            this.lbxTreatments.FormattingEnabled = true;
            this.lbxTreatments.Location = new System.Drawing.Point(515, 35);
            this.lbxTreatments.Name = "lbxTreatments";
            this.lbxTreatments.Size = new System.Drawing.Size(301, 225);
            this.lbxTreatments.TabIndex = 22;
            this.toolTip1.SetToolTip(this.lbxTreatments, "Double click - deletes selected treatment");
            this.lbxTreatments.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxTreatments_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Client Information:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Treatments:";
            // 
            // cmbTreatments
            // 
            this.cmbTreatments.FormattingEnabled = true;
            this.cmbTreatments.Location = new System.Drawing.Point(258, 38);
            this.cmbTreatments.Name = "cmbTreatments";
            this.cmbTreatments.Size = new System.Drawing.Size(237, 21);
            this.cmbTreatments.TabIndex = 25;
            this.cmbTreatments.SelectedIndexChanged += new System.EventHandler(this.cmbTreatments_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "E - mail:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Thistle;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(258, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(237, 35);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btnCancel, "Cancel");
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Client name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Client number:";
            // 
            // txtClientName
            // 
            this.txtClientName.BackColor = System.Drawing.Color.White;
            this.txtClientName.Location = new System.Drawing.Point(88, 17);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.ReadOnly = true;
            this.txtClientName.Size = new System.Drawing.Size(125, 20);
            this.txtClientName.TabIndex = 33;
            // 
            // txtClientNumber
            // 
            this.txtClientNumber.BackColor = System.Drawing.Color.White;
            this.txtClientNumber.Location = new System.Drawing.Point(88, 47);
            this.txtClientNumber.Name = "txtClientNumber";
            this.txtClientNumber.ReadOnly = true;
            this.txtClientNumber.Size = new System.Drawing.Size(125, 20);
            this.txtClientNumber.TabIndex = 34;
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.BackColor = System.Drawing.Color.White;
            this.txtClientEmail.Location = new System.Drawing.Point(88, 78);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.ReadOnly = true;
            this.txtClientEmail.Size = new System.Drawing.Size(125, 20);
            this.txtClientEmail.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtClientEmail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtClientNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtClientName);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 110);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Details";
            // 
            // txtBookingNumber
            // 
            this.txtBookingNumber.BackColor = System.Drawing.Color.White;
            this.txtBookingNumber.Location = new System.Drawing.Point(113, 39);
            this.txtBookingNumber.Name = "txtBookingNumber";
            this.txtBookingNumber.ReadOnly = true;
            this.txtBookingNumber.Size = new System.Drawing.Size(125, 20);
            this.txtBookingNumber.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(18, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Booking Number:";
            // 
            // btnAddTreatment
            // 
            this.btnAddTreatment.BackColor = System.Drawing.Color.Thistle;
            this.btnAddTreatment.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.btnAddTreatment.FlatAppearance.BorderSize = 2;
            this.btnAddTreatment.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTreatment.Location = new System.Drawing.Point(258, 82);
            this.btnAddTreatment.Name = "btnAddTreatment";
            this.btnAddTreatment.Size = new System.Drawing.Size(162, 50);
            this.btnAddTreatment.TabIndex = 40;
            this.btnAddTreatment.Text = "Add Treatment:";
            this.btnAddTreatment.UseVisualStyleBackColor = false;
            this.btnAddTreatment.Click += new System.EventHandler(this.btnAddTreatment_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "select treatments to add:";
            // 
            // lblSuggestedPrice
            // 
            this.lblSuggestedPrice.AutoSize = true;
            this.lblSuggestedPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSuggestedPrice.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuggestedPrice.Location = new System.Drawing.Point(47, 194);
            this.lblSuggestedPrice.Name = "lblSuggestedPrice";
            this.lblSuggestedPrice.Size = new System.Drawing.Size(116, 13);
            this.lblSuggestedPrice.TabIndex = 43;
            this.lblSuggestedPrice.Text = "Suggested price:";
            // 
            // txtFinalPrice
            // 
            this.txtFinalPrice.Location = new System.Drawing.Point(50, 210);
            this.txtFinalPrice.Name = "txtFinalPrice";
            this.txtFinalPrice.Size = new System.Drawing.Size(111, 20);
            this.txtFinalPrice.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Payment method:";
            // 
            // cmbPayment
            // 
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "EFT"});
            this.cmbPayment.Location = new System.Drawing.Point(207, 209);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(121, 21);
            this.cmbPayment.TabIndex = 46;
            // 
            // notifyDone
            // 
            this.notifyDone.Text = "notifyIcon1";
            this.notifyDone.Visible = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(29, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "R";
            // 
            // lbxTreatments2
            // 
            this.lbxTreatments2.FormattingEnabled = true;
            this.lbxTreatments2.Location = new System.Drawing.Point(355, 146);
            this.lbxTreatments2.Name = "lbxTreatments2";
            this.lbxTreatments2.Size = new System.Drawing.Size(88, 30);
            this.lbxTreatments2.TabIndex = 48;
            this.lbxTreatments2.Visible = false;
            this.lbxTreatments2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxTreatments_MouseDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(255, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Additional:";
            this.label10.Visible = false;
            // 
            // Finish_booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 309);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbxTreatments2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFinalPrice);
            this.Controls.Add(this.lblSuggestedPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddTreatment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBookingNumber);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbTreatments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxTreatments);
            this.Controls.Add(this.btnFinalize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Finish_booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finish booking";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.ListBox lbxTreatments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTreatments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientNumber;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBookingNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddTreatment;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSuggestedPrice;
        private System.Windows.Forms.TextBox txtFinalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.NotifyIcon notifyDone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbxTreatments2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}