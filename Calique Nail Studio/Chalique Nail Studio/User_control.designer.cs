namespace Chalique_Nail_Studio
{
    partial class User_control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_control));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabType = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.cbxTech = new System.Windows.Forms.CheckBox();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabRemove = new System.Windows.Forms.TabPage();
            this.btnRemCancel = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.Button();
            this.lbxEmp = new System.Windows.Forms.ListBox();
            this.lblEmp = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbxPassword = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabType.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabRemove.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabControl1.Controls.Add(this.tabType);
            this.tabControl1.Controls.Add(this.tabAdd);
            this.tabControl1.Controls.Add(this.tabRemove);
            this.tabControl1.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(418, 281);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabType
            // 
            this.tabType.BackColor = System.Drawing.Color.Transparent;
            this.tabType.BackgroundImage = global::Chalique_Nail_Studio.Properties.Resources.Light_Blue;
            this.tabType.Controls.Add(this.btnRemove);
            this.tabType.Controls.Add(this.btnAdd);
            this.tabType.Controls.Add(this.label1);
            this.tabType.Controls.Add(this.radioButton2);
            this.tabType.Controls.Add(this.radioButton1);
            this.tabType.Location = new System.Drawing.Point(4, 26);
            this.tabType.Name = "tabType";
            this.tabType.Padding = new System.Windows.Forms.Padding(3);
            this.tabType.Size = new System.Drawing.Size(397, 251);
            this.tabType.TabIndex = 0;
            this.tabType.Text = "Type of User";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(230, 190);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 45);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove user";
            this.toolTip1.SetToolTip(this.btnRemove, "Click to remove user");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(50, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 45);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add new user";
            this.toolTip1.SetToolTip(this.btnAdd, "Click to add new user");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Which type of employee do you want to work with?";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(35, 84);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Technician";
            this.toolTip1.SetToolTip(this.radioButton2, "Select type of user to add");
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(35, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Owner";
            this.toolTip1.SetToolTip(this.radioButton1, "Select type of user to add");
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // tabAdd
            // 
            this.tabAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabAdd.BackgroundImage = global::Chalique_Nail_Studio.Properties.Resources.Light_Blue;
            this.tabAdd.Controls.Add(this.cbxPassword);
            this.tabAdd.Controls.Add(this.cbxTech);
            this.tabAdd.Controls.Add(this.btnAddCancel);
            this.tabAdd.Controls.Add(this.txtName);
            this.tabAdd.Controls.Add(this.label4);
            this.tabAdd.Controls.Add(this.btnFin);
            this.tabAdd.Controls.Add(this.txtPassword);
            this.tabAdd.Controls.Add(this.txtUser);
            this.tabAdd.Controls.Add(this.label3);
            this.tabAdd.Controls.Add(this.label2);
            this.tabAdd.Location = new System.Drawing.Point(4, 26);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(410, 251);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add User";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // cbxTech
            // 
            this.cbxTech.AutoSize = true;
            this.cbxTech.Location = new System.Drawing.Point(64, 137);
            this.cbxTech.Name = "cbxTech";
            this.cbxTech.Size = new System.Drawing.Size(237, 21);
            this.cbxTech.TabIndex = 5;
            this.cbxTech.Text = "Is technician? (Can do treatments)";
            this.cbxTech.UseVisualStyleBackColor = true;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancel.Location = new System.Drawing.Point(230, 190);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(120, 45);
            this.btnAddCancel.TabIndex = 7;
            this.btnAddCancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btnAddCancel, "Click to cancel");
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 25);
            this.txtName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtName, "Enter employee names");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Full name:";
            // 
            // btnFin
            // 
            this.btnFin.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFin.Location = new System.Drawing.Point(50, 190);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(140, 45);
            this.btnFin.TabIndex = 6;
            this.btnFin.Text = "Finish";
            this.toolTip1.SetToolTip(this.btnFin, "Click to finish adding the user");
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(127, 86);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(146, 25);
            this.txtPassword.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtPassword, "Enter password");
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(127, 16);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(146, 25);
            this.txtUser.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtUser, "Enter employee I.D.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // tabRemove
            // 
            this.tabRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabRemove.BackgroundImage = global::Chalique_Nail_Studio.Properties.Resources.Light_Blue;
            this.tabRemove.Controls.Add(this.btnRemCancel);
            this.tabRemove.Controls.Add(this.btnRem);
            this.tabRemove.Controls.Add(this.lbxEmp);
            this.tabRemove.Controls.Add(this.lblEmp);
            this.tabRemove.Location = new System.Drawing.Point(4, 26);
            this.tabRemove.Name = "tabRemove";
            this.tabRemove.Size = new System.Drawing.Size(397, 251);
            this.tabRemove.TabIndex = 2;
            this.tabRemove.Text = "Remove User";
            this.tabRemove.UseVisualStyleBackColor = true;
            // 
            // btnRemCancel
            // 
            this.btnRemCancel.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemCancel.Location = new System.Drawing.Point(230, 190);
            this.btnRemCancel.Name = "btnRemCancel";
            this.btnRemCancel.Size = new System.Drawing.Size(120, 45);
            this.btnRemCancel.TabIndex = 8;
            this.btnRemCancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btnRemCancel, "Click to cancel");
            this.btnRemCancel.UseVisualStyleBackColor = true;
            this.btnRemCancel.Click += new System.EventHandler(this.btnRemCancel_Click);
            // 
            // btnRem
            // 
            this.btnRem.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRem.Location = new System.Drawing.Point(50, 190);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(140, 45);
            this.btnRem.TabIndex = 2;
            this.btnRem.Text = "Remove employee";
            this.toolTip1.SetToolTip(this.btnRem, "Click to remove employee");
            this.btnRem.UseVisualStyleBackColor = true;
            this.btnRem.Visible = false;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // lbxEmp
            // 
            this.lbxEmp.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxEmp.FormattingEnabled = true;
            this.lbxEmp.ItemHeight = 17;
            this.lbxEmp.Location = new System.Drawing.Point(33, 56);
            this.lbxEmp.Name = "lbxEmp";
            this.lbxEmp.Size = new System.Drawing.Size(247, 106);
            this.lbxEmp.TabIndex = 1;
            this.toolTip1.SetToolTip(this.lbxEmp, "Select employee to remove");
            this.lbxEmp.SelectedIndexChanged += new System.EventHandler(this.lbxEmp_SelectedIndexChanged);
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.Location = new System.Drawing.Point(30, 20);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(128, 17);
            this.lblEmp.TabIndex = 0;
            this.lblEmp.Text = "Type of employee: ";
            // 
            // cbxPassword
            // 
            this.cbxPassword.AutoSize = true;
            this.cbxPassword.Location = new System.Drawing.Point(285, 90);
            this.cbxPassword.Name = "cbxPassword";
            this.cbxPassword.Size = new System.Drawing.Size(122, 21);
            this.cbxPassword.TabIndex = 8;
            this.cbxPassword.Text = "show password";
            this.cbxPassword.UseVisualStyleBackColor = true;
            this.cbxPassword.CheckedChanged += new System.EventHandler(this.cbxPassword_CheckedChanged);
            // 
            // User_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(422, 281);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User_control";
            this.Text = "Employee Management";
            this.tabControl1.ResumeLayout(false);
            this.tabType.ResumeLayout(false);
            this.tabType.PerformLayout();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabRemove.ResumeLayout(false);
            this.tabRemove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.ListBox lbxEmp;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnRemCancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cbxTech;
        private System.Windows.Forms.CheckBox cbxPassword;
    }
}