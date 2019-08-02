namespace CrazyDaisyFlowers
{
    partial class StockDeleteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeleteType = new System.Windows.Forms.TextBox();
            this.btnDeleteType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flower type to delete:";
            // 
            // txtDeleteType
            // 
            this.txtDeleteType.Location = new System.Drawing.Point(126, 6);
            this.txtDeleteType.Name = "txtDeleteType";
            this.txtDeleteType.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteType.TabIndex = 1;
            // 
            // btnDeleteType
            // 
            this.btnDeleteType.Location = new System.Drawing.Point(15, 39);
            this.btnDeleteType.Name = "btnDeleteType";
            this.btnDeleteType.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteType.TabIndex = 2;
            this.btnDeleteType.Text = "Delete";
            this.btnDeleteType.UseVisualStyleBackColor = true;
            this.btnDeleteType.Click += new System.EventHandler(this.btnDeleteType_Click);
            // 
            // StockDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 74);
            this.Controls.Add(this.btnDeleteType);
            this.Controls.Add(this.txtDeleteType);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StockDeleteForm";
            this.Text = "Delete Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeleteType;
        private System.Windows.Forms.Button btnDeleteType;
    }
}