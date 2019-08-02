namespace ITRI615
{
    partial class TextEncryptionForm
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
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.DecryptRdio = new MetroFramework.Controls.MetroRadioButton();
			this.EncryptRdio = new MetroFramework.Controls.MetroRadioButton();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.EncryptionMethodcmbx = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.outputFileTxt = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.keyFileTxt = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.inputFileTxt = new MetroFramework.Controls.MetroTextBox();
			this.metroPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroPanel1
			// 
			this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.metroPanel1.Controls.Add(this.DecryptRdio);
			this.metroPanel1.Controls.Add(this.EncryptRdio);
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(570, 164);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(115, 74);
			this.metroPanel1.TabIndex = 27;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
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
			// EncryptRdio
			// 
			this.EncryptRdio.AutoSize = true;
			this.EncryptRdio.Location = new System.Drawing.Point(4, 14);
			this.EncryptRdio.Name = "EncryptRdio";
			this.EncryptRdio.Size = new System.Drawing.Size(63, 15);
			this.EncryptRdio.TabIndex = 2;
			this.EncryptRdio.Text = "Encrypt";
			this.EncryptRdio.UseSelectable = true;
			// 
			// metroTile1
			// 
			this.metroTile1.ActiveControl = null;
			this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.metroTile1.Location = new System.Drawing.Point(61, 406);
			this.metroTile1.Name = "metroTile1";
			this.metroTile1.Size = new System.Drawing.Size(576, 58);
			this.metroTile1.Style = MetroFramework.MetroColorStyle.Teal;
			this.metroTile1.TabIndex = 26;
			this.metroTile1.Text = "Do the hard work for me!";
			this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.metroTile1.UseSelectable = true;
			this.metroTile1.UseTileImage = true;
			this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(23, 164);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(121, 19);
			this.metroLabel4.TabIndex = 25;
			this.metroLabel4.Text = "Encryption Method";
			this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
			// 
			// EncryptionMethodcmbx
			// 
			this.EncryptionMethodcmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EncryptionMethodcmbx.FormattingEnabled = true;
			this.EncryptionMethodcmbx.ItemHeight = 23;
			this.EncryptionMethodcmbx.Items.AddRange(new object[] {
            "Vernam",
            "Vigenere",
            "Transposition",
            "Own"});
			this.EncryptionMethodcmbx.Location = new System.Drawing.Point(23, 186);
			this.EncryptionMethodcmbx.Name = "EncryptionMethodcmbx";
			this.EncryptionMethodcmbx.Size = new System.Drawing.Size(438, 29);
			this.EncryptionMethodcmbx.TabIndex = 24;
			this.EncryptionMethodcmbx.UseSelectable = true;
			this.EncryptionMethodcmbx.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(23, 313);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(157, 19);
			this.metroLabel3.TabIndex = 22;
			this.metroLabel3.Text = "Here\'s The Processed Text";
			this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
			// 
			// outputFileTxt
			// 
			this.outputFileTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.outputFileTxt.CustomButton.Image = null;
			this.outputFileTxt.CustomButton.Location = new System.Drawing.Point(600, 1);
			this.outputFileTxt.CustomButton.Name = "";
			this.outputFileTxt.CustomButton.Size = new System.Drawing.Size(61, 61);
			this.outputFileTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.outputFileTxt.CustomButton.TabIndex = 1;
			this.outputFileTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.outputFileTxt.CustomButton.UseSelectable = true;
			this.outputFileTxt.CustomButton.Visible = false;
			this.outputFileTxt.Lines = new string[0];
			this.outputFileTxt.Location = new System.Drawing.Point(23, 335);
			this.outputFileTxt.MaxLength = 32767;
			this.outputFileTxt.Multiline = true;
			this.outputFileTxt.Name = "outputFileTxt";
			this.outputFileTxt.PasswordChar = '\0';
			this.outputFileTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.outputFileTxt.SelectedText = "";
			this.outputFileTxt.SelectionLength = 0;
			this.outputFileTxt.SelectionStart = 0;
			this.outputFileTxt.ShortcutsEnabled = true;
			this.outputFileTxt.Size = new System.Drawing.Size(662, 63);
			this.outputFileTxt.TabIndex = 21;
			this.outputFileTxt.UseSelectable = true;
			this.outputFileTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.outputFileTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.outputFileTxt.Click += new System.EventHandler(this.outputFileTxt_Click);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(23, 247);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(93, 19);
			this.metroLabel2.TabIndex = 19;
			this.metroLabel2.Text = "Input Your Key";
			this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
			// 
			// keyFileTxt
			// 
			this.keyFileTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.keyFileTxt.CustomButton.Image = null;
			this.keyFileTxt.CustomButton.Location = new System.Drawing.Point(640, 1);
			this.keyFileTxt.CustomButton.Name = "";
			this.keyFileTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.keyFileTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.keyFileTxt.CustomButton.TabIndex = 1;
			this.keyFileTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.keyFileTxt.CustomButton.UseSelectable = true;
			this.keyFileTxt.CustomButton.Visible = false;
			this.keyFileTxt.Lines = new string[0];
			this.keyFileTxt.Location = new System.Drawing.Point(23, 269);
			this.keyFileTxt.MaxLength = 32767;
			this.keyFileTxt.Name = "keyFileTxt";
			this.keyFileTxt.PasswordChar = '\0';
			this.keyFileTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.keyFileTxt.SelectedText = "";
			this.keyFileTxt.SelectionLength = 0;
			this.keyFileTxt.SelectionStart = 0;
			this.keyFileTxt.ShortcutsEnabled = true;
			this.keyFileTxt.Size = new System.Drawing.Size(662, 23);
			this.keyFileTxt.TabIndex = 18;
			this.keyFileTxt.UseSelectable = true;
			this.keyFileTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.keyFileTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.keyFileTxt.Click += new System.EventHandler(this.keyFileTxt_Click);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 60);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(128, 19);
			this.metroLabel1.TabIndex = 16;
			this.metroLabel1.Text = "Input Your Input Text";
			this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
			// 
			// inputFileTxt
			// 
			this.inputFileTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.inputFileTxt.CustomButton.Image = null;
			this.inputFileTxt.CustomButton.Location = new System.Drawing.Point(588, 2);
			this.inputFileTxt.CustomButton.Name = "";
			this.inputFileTxt.CustomButton.Size = new System.Drawing.Size(71, 71);
			this.inputFileTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.inputFileTxt.CustomButton.TabIndex = 1;
			this.inputFileTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.inputFileTxt.CustomButton.UseSelectable = true;
			this.inputFileTxt.CustomButton.Visible = false;
			this.inputFileTxt.Lines = new string[0];
			this.inputFileTxt.Location = new System.Drawing.Point(23, 82);
			this.inputFileTxt.MaxLength = 32767;
			this.inputFileTxt.Multiline = true;
			this.inputFileTxt.Name = "inputFileTxt";
			this.inputFileTxt.PasswordChar = '\0';
			this.inputFileTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.inputFileTxt.SelectedText = "";
			this.inputFileTxt.SelectionLength = 0;
			this.inputFileTxt.SelectionStart = 0;
			this.inputFileTxt.ShortcutsEnabled = true;
			this.inputFileTxt.Size = new System.Drawing.Size(662, 76);
			this.inputFileTxt.TabIndex = 15;
			this.inputFileTxt.UseSelectable = true;
			this.inputFileTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.inputFileTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.inputFileTxt.Click += new System.EventHandler(this.inputFileTxt_Click);
			// 
			// TextEncryptionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(720, 487);
			this.Controls.Add(this.metroPanel1);
			this.Controls.Add(this.metroTile1);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.EncryptionMethodcmbx);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.outputFileTxt);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.keyFileTxt);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.inputFileTxt);
			this.Name = "TextEncryptionForm";
			this.Text = "Spy Kit Text Encryptor";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.metroPanel1.ResumeLayout(false);
			this.metroPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroRadioButton DecryptRdio;
        private MetroFramework.Controls.MetroRadioButton EncryptRdio;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox EncryptionMethodcmbx;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox outputFileTxt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox keyFileTxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox inputFileTxt;
    }
}