namespace CrazyDaisyFlowers
{
    partial class InventoryAmount
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ROPbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // ROPbtn
            // 
            this.ROPbtn.BackColor = System.Drawing.Color.RosyBrown;
            this.ROPbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROPbtn.Location = new System.Drawing.Point(249, 353);
            this.ROPbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ROPbtn.Name = "ROPbtn";
            this.ROPbtn.Size = new System.Drawing.Size(272, 48);
            this.ROPbtn.TabIndex = 1;
            this.ROPbtn.Text = "Calculate Reorder Point";
            this.ROPbtn.UseVisualStyleBackColor = false;
            this.ROPbtn.Click += new System.EventHandler(this.ROPbtn_Click);
            // 
            // InventoryAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CrazyDaisyFlowers.Properties.Resources.Daisy_Back;
            this.ClientSize = new System.Drawing.Size(745, 416);
            this.Controls.Add(this.ROPbtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InventoryAmount";
            this.Text = "InventoryAmount";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ROPbtn;
    }
}