namespace ITRI615
{
    partial class MetroGuiForm
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
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.inputFileTxt = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.inputFileBtn = new MetroFramework.Controls.MetroButton();
			this.keyFileTxt = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.keyFileBtn = new MetroFramework.Controls.MetroButton();
			this.outputFileTxt = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.outputFileBtn = new MetroFramework.Controls.MetroButton();
			this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.EncryptRdio = new MetroFramework.Controls.MetroRadioButton();
			this.DecryptRdio = new MetroFramework.Controls.MetroRadioButton();
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.metroPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.CheckFileExists = true;
			this.saveFileDialog1.CreatePrompt = true;
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			// 
			// inputFileTxt
			// 
			this.inputFileTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.inputFileTxt.CustomButton.Image = null;
			this.inputFileTxt.CustomButton.Location = new System.Drawing.Point(497, 1);
			this.inputFileTxt.CustomButton.Name = "";
			this.inputFileTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.inputFileTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.inputFileTxt.CustomButton.TabIndex = 1;
			this.inputFileTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.inputFileTxt.CustomButton.UseSelectable = true;
			this.inputFileTxt.CustomButton.Visible = false;
			this.inputFileTxt.Enabled = false;
			this.inputFileTxt.Lines = new string[0];
			this.inputFileTxt.Location = new System.Drawing.Point(23, 97);
			this.inputFileTxt.MaxLength = 32767;
			this.inputFileTxt.Name = "inputFileTxt";
			this.inputFileTxt.PasswordChar = '\0';
			this.inputFileTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.inputFileTxt.SelectedText = "";
			this.inputFileTxt.SelectionLength = 0;
			this.inputFileTxt.SelectionStart = 0;
			this.inputFileTxt.ShortcutsEnabled = true;
			this.inputFileTxt.Size = new System.Drawing.Size(519, 23);
			this.inputFileTxt.TabIndex = 1;
			this.inputFileTxt.UseSelectable = true;
			this.inputFileTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.inputFileTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 75);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(115, 19);
			this.metroLabel1.TabIndex = 3;
			this.metroLabel1.Text = "Input File Location";
			// 
			// inputFileBtn
			// 
			this.inputFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.inputFileBtn.Location = new System.Drawing.Point(568, 97);
			this.inputFileBtn.Name = "inputFileBtn";
			this.inputFileBtn.Size = new System.Drawing.Size(98, 23);
			this.inputFileBtn.TabIndex = 4;
			this.inputFileBtn.Text = "Open File";
			this.inputFileBtn.UseSelectable = true;
			this.inputFileBtn.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// keyFileTxt
			// 
			this.keyFileTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.keyFileTxt.CustomButton.Image = null;
			this.keyFileTxt.CustomButton.Location = new System.Drawing.Point(497, 1);
			this.keyFileTxt.CustomButton.Name = "";
			this.keyFileTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.keyFileTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.keyFileTxt.CustomButton.TabIndex = 1;
			this.keyFileTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.keyFileTxt.CustomButton.UseSelectable = true;
			this.keyFileTxt.CustomButton.Visible = false;
			this.keyFileTxt.Enabled = false;
			this.keyFileTxt.Lines = new string[0];
			this.keyFileTxt.Location = new System.Drawing.Point(23, 173);
			this.keyFileTxt.MaxLength = 32767;
			this.keyFileTxt.Name = "keyFileTxt";
			this.keyFileTxt.PasswordChar = '\0';
			this.keyFileTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.keyFileTxt.SelectedText = "";
			this.keyFileTxt.SelectionLength = 0;
			this.keyFileTxt.SelectionStart = 0;
			this.keyFileTxt.ShortcutsEnabled = true;
			this.keyFileTxt.Size = new System.Drawing.Size(519, 23);
			this.keyFileTxt.TabIndex = 5;
			this.keyFileTxt.UseSelectable = true;
			this.keyFileTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.keyFileTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(23, 151);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(106, 19);
			this.metroLabel2.TabIndex = 6;
			this.metroLabel2.Text = "Key File Location";
			// 
			// keyFileBtn
			// 
			this.keyFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.keyFileBtn.Location = new System.Drawing.Point(568, 173);
			this.keyFileBtn.Name = "keyFileBtn";
			this.keyFileBtn.Size = new System.Drawing.Size(98, 23);
			this.keyFileBtn.TabIndex = 7;
			this.keyFileBtn.Text = "Open Key File";
			this.keyFileBtn.UseSelectable = true;
			this.keyFileBtn.Click += new System.EventHandler(this.keyFileBtn_Click);
			// 
			// outputFileTxt
			// 
			this.outputFileTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.outputFileTxt.CustomButton.Image = null;
			this.outputFileTxt.CustomButton.Location = new System.Drawing.Point(497, 1);
			this.outputFileTxt.CustomButton.Name = "";
			this.outputFileTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.outputFileTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.outputFileTxt.CustomButton.TabIndex = 1;
			this.outputFileTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.outputFileTxt.CustomButton.UseSelectable = true;
			this.outputFileTxt.CustomButton.Visible = false;
			this.outputFileTxt.Enabled = false;
			this.outputFileTxt.Lines = new string[0];
			this.outputFileTxt.Location = new System.Drawing.Point(23, 240);
			this.outputFileTxt.MaxLength = 32767;
			this.outputFileTxt.Name = "outputFileTxt";
			this.outputFileTxt.PasswordChar = '\0';
			this.outputFileTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.outputFileTxt.SelectedText = "";
			this.outputFileTxt.SelectionLength = 0;
			this.outputFileTxt.SelectionStart = 0;
			this.outputFileTxt.ShortcutsEnabled = true;
			this.outputFileTxt.Size = new System.Drawing.Size(519, 23);
			this.outputFileTxt.TabIndex = 8;
			this.outputFileTxt.UseSelectable = true;
			this.outputFileTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.outputFileTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(23, 218);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(127, 19);
			this.metroLabel3.TabIndex = 9;
			this.metroLabel3.Text = "Output File Location";
			// 
			// outputFileBtn
			// 
			this.outputFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.outputFileBtn.Location = new System.Drawing.Point(568, 240);
			this.outputFileBtn.Name = "outputFileBtn";
			this.outputFileBtn.Size = new System.Drawing.Size(98, 23);
			this.outputFileBtn.TabIndex = 10;
			this.outputFileBtn.Text = "Save File";
			this.outputFileBtn.UseSelectable = true;
			this.outputFileBtn.Click += new System.EventHandler(this.outputFileBtn_Click);
			// 
			// metroComboBox1
			// 
			this.metroComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroComboBox1.FormattingEnabled = true;
			this.metroComboBox1.ItemHeight = 23;
			this.metroComboBox1.Items.AddRange(new object[] {
            "Vernam",
            "Vigenere",
            "Transposition",
            "Own"});
			this.metroComboBox1.Location = new System.Drawing.Point(23, 318);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.Size = new System.Drawing.Size(295, 29);
			this.metroComboBox1.TabIndex = 11;
			this.metroComboBox1.UseSelectable = true;
			this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(23, 296);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(121, 19);
			this.metroLabel4.TabIndex = 12;
			this.metroLabel4.Text = "Encryption Method";
			// 
			// metroTile1
			// 
			this.metroTile1.ActiveControl = null;
			this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.metroTile1.Location = new System.Drawing.Point(445, 316);
			this.metroTile1.Name = "metroTile1";
			this.metroTile1.Size = new System.Drawing.Size(207, 58);
			this.metroTile1.Style = MetroFramework.MetroColorStyle.Teal;
			this.metroTile1.TabIndex = 13;
			this.metroTile1.Text = "Do the hard work for me!";
			this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.metroTile1.UseSelectable = true;
			this.metroTile1.UseTileImage = true;
			this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
			// 
			// EncryptRdio
			// 
			this.EncryptRdio.AutoSize = true;
			this.EncryptRdio.Location = new System.Drawing.Point(4, 13);
			this.EncryptRdio.Name = "EncryptRdio";
			this.EncryptRdio.Size = new System.Drawing.Size(63, 15);
			this.EncryptRdio.TabIndex = 2;
			this.EncryptRdio.Text = "Encrypt";
			this.EncryptRdio.UseSelectable = true;
			// 
			// DecryptRdio
			// 
			this.DecryptRdio.AutoSize = true;
			this.DecryptRdio.Location = new System.Drawing.Point(3, 46);
			this.DecryptRdio.Name = "DecryptRdio";
			this.DecryptRdio.Size = new System.Drawing.Size(64, 15);
			this.DecryptRdio.TabIndex = 3;
			this.DecryptRdio.Text = "Decrypt";
			this.DecryptRdio.UseSelectable = true;
			// 
			// metroPanel1
			// 
			this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.metroPanel1.Controls.Add(this.DecryptRdio);
			this.metroPanel1.Controls.Add(this.EncryptRdio);
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(325, 286);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(105, 88);
			this.metroPanel1.TabIndex = 14;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			// 
			// MetroGuiForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 399);
			this.Controls.Add(this.metroPanel1);
			this.Controls.Add(this.metroTile1);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroComboBox1);
			this.Controls.Add(this.outputFileBtn);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.outputFileTxt);
			this.Controls.Add(this.keyFileBtn);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.keyFileTxt);
			this.Controls.Add(this.inputFileBtn);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.inputFileTxt);
			this.Name = "MetroGuiForm";
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Spy Kit";
			this.Load += new System.EventHandler(this.MetroGuiForm_Load);
			this.metroPanel1.ResumeLayout(false);
			this.metroPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroTextBox inputFileTxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton inputFileBtn;
        private MetroFramework.Controls.MetroTextBox keyFileTxt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton keyFileBtn;
        private MetroFramework.Controls.MetroTextBox outputFileTxt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton outputFileBtn;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroRadioButton EncryptRdio;
        private MetroFramework.Controls.MetroRadioButton DecryptRdio;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}