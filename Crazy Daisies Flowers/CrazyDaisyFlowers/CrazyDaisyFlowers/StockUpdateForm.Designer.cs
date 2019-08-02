namespace CrazyDaisyFlowers
{
    partial class StockUpdateForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpdateType = new System.Windows.Forms.TextBox();
            this.txtUpdateAmount = new System.Windows.Forms.TextBox();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flower type to update:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New amount:";
            // 
            // txtUpdateType
            // 
            this.txtUpdateType.Location = new System.Drawing.Point(130, 6);
            this.txtUpdateType.Name = "txtUpdateType";
            this.txtUpdateType.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateType.TabIndex = 2;
            // 
            // txtUpdateAmount
            // 
            this.txtUpdateAmount.Location = new System.Drawing.Point(130, 38);
            this.txtUpdateAmount.Name = "txtUpdateAmount";
            this.txtUpdateAmount.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateAmount.TabIndex = 3;
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Location = new System.Drawing.Point(12, 71);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStock.TabIndex = 4;
            this.btnUpdateStock.Text = "Update";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // StockUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 106);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.txtUpdateAmount);
            this.Controls.Add(this.txtUpdateType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StockUpdateForm";
            this.Text = "Update Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpdateType;
        private System.Windows.Forms.TextBox txtUpdateAmount;
        private System.Windows.Forms.Button btnUpdateStock;
    }
}