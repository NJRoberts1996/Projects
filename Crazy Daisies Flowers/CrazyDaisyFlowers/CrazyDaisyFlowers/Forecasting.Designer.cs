namespace CrazyDaisyFlowers
{
    partial class Forecasting
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
            this.comboBox1Forecast = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1Forecast = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.btnCalcForecast = new System.Windows.Forms.Button();
            this.btnCalcForecast2 = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.groupBox1Forecast.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select your preferred forecast period:";
            // 
            // comboBox1Forecast
            // 
            this.comboBox1Forecast.FormattingEnabled = true;
            this.comboBox1Forecast.Items.AddRange(new object[] {
            "January 2019",
            "February 2019",
            "March 2019",
            "April 2019",
            "May 2019",
            "June 2019",
            "July 2019",
            "August 2019",
            "September 2019",
            "October 2019",
            "November 2019",
            "December 2019",
            "January 2020"});
            this.comboBox1Forecast.Location = new System.Drawing.Point(17, 68);
            this.comboBox1Forecast.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1Forecast.Name = "comboBox1Forecast";
            this.comboBox1Forecast.Size = new System.Drawing.Size(300, 28);
            this.comboBox1Forecast.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(772, 427);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear/Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1Forecast
            // 
            this.groupBox1Forecast.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1Forecast.Controls.Add(this.label4);
            this.groupBox1Forecast.Controls.Add(this.label3);
            this.groupBox1Forecast.Controls.Add(this.label2);
            this.groupBox1Forecast.Controls.Add(this.lblTest);
            this.groupBox1Forecast.Controls.Add(this.lblAverage);
            this.groupBox1Forecast.Font = new System.Drawing.Font("High Tower Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1Forecast.Location = new System.Drawing.Point(356, 68);
            this.groupBox1Forecast.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1Forecast.Name = "groupBox1Forecast";
            this.groupBox1Forecast.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1Forecast.Size = new System.Drawing.Size(611, 347);
            this.groupBox1Forecast.TabIndex = 6;
            this.groupBox1Forecast.TabStop = false;
            this.groupBox1Forecast.Text = "Forecast - ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "\"\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "\"\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "\"\"";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(34, 98);
            this.lblTest.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(17, 15);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "\"\"";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(34, 53);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(17, 15);
            this.lblAverage.TabIndex = 0;
            this.lblAverage.Text = "\"\"";
            // 
            // btnCalcForecast
            // 
            this.btnCalcForecast.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCalcForecast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalcForecast.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcForecast.Location = new System.Drawing.Point(15, 172);
            this.btnCalcForecast.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalcForecast.Name = "btnCalcForecast";
            this.btnCalcForecast.Size = new System.Drawing.Size(302, 111);
            this.btnCalcForecast.TabIndex = 2;
            this.btnCalcForecast.Text = "Calculate Forecast\r\n(De - seasonalized)";
            this.btnCalcForecast.UseVisualStyleBackColor = false;
            this.btnCalcForecast.Click += new System.EventHandler(this.btnCalcForecast_Click);
            // 
            // btnCalcForecast2
            // 
            this.btnCalcForecast2.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCalcForecast2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalcForecast2.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcForecast2.Location = new System.Drawing.Point(15, 319);
            this.btnCalcForecast2.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalcForecast2.Name = "btnCalcForecast2";
            this.btnCalcForecast2.Size = new System.Drawing.Size(302, 96);
            this.btnCalcForecast2.TabIndex = 3;
            this.btnCalcForecast2.Text = "Calculate Forecast\r\n(Seasonalized)";
            this.btnCalcForecast2.UseVisualStyleBackColor = false;
            this.btnCalcForecast2.Click += new System.EventHandler(this.btnCalcForecast2_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.BackColor = System.Drawing.Color.RosyBrown;
            this.btnGraph.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraph.Location = new System.Drawing.Point(565, 427);
            this.btnGraph.Margin = new System.Windows.Forms.Padding(6);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(195, 63);
            this.btnGraph.TabIndex = 4;
            this.btnGraph.Text = "Graph";
            this.btnGraph.UseVisualStyleBackColor = false;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // Forecasting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::CrazyDaisyFlowers.Properties.Resources.daisy_b_ack;
            this.ClientSize = new System.Drawing.Size(1015, 515);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.btnCalcForecast2);
            this.Controls.Add(this.btnCalcForecast);
            this.Controls.Add(this.groupBox1Forecast);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1Forecast);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Forecasting";
            this.Text = "Forecasting";
            this.groupBox1Forecast.ResumeLayout(false);
            this.groupBox1Forecast.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1Forecast;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1Forecast;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btnCalcForecast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcForecast2;
        private System.Windows.Forms.Button btnGraph;
    }
}