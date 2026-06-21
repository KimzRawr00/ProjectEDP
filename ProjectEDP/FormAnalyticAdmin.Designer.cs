namespace ProjectEDP
{
    partial class FormAnalyticAdmin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelTotalCust = new System.Windows.Forms.Label();
            this.labelTotalBooking = new System.Windows.Forms.Label();
            this.labelTotalRevenue = new System.Windows.Forms.Label();
            this.chartBookingStadium = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPopularMatch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPaymentUsage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelBooking = new System.Windows.Forms.Label();
            this.labelReveneu = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartBookingStadium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPopularMatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPaymentUsage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalCust
            // 
            this.labelTotalCust.AutoSize = true;
            this.labelTotalCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCust.Location = new System.Drawing.Point(241, 122);
            this.labelTotalCust.Name = "labelTotalCust";
            this.labelTotalCust.Size = new System.Drawing.Size(250, 29);
            this.labelTotalCust.TabIndex = 0;
            this.labelTotalCust.Text = "TOTAL CUSTOMER";
            // 
            // labelTotalBooking
            // 
            this.labelTotalBooking.AutoSize = true;
            this.labelTotalBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBooking.Location = new System.Drawing.Point(512, 122);
            this.labelTotalBooking.Name = "labelTotalBooking";
            this.labelTotalBooking.Size = new System.Drawing.Size(223, 29);
            this.labelTotalBooking.TabIndex = 1;
            this.labelTotalBooking.Text = "TOTAL BOOKING";
            // 
            // labelTotalRevenue
            // 
            this.labelTotalRevenue.AutoSize = true;
            this.labelTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRevenue.Location = new System.Drawing.Point(763, 122);
            this.labelTotalRevenue.Name = "labelTotalRevenue";
            this.labelTotalRevenue.Size = new System.Drawing.Size(226, 29);
            this.labelTotalRevenue.TabIndex = 2;
            this.labelTotalRevenue.Text = "TOTAL REVENUE";
            // 
            // chartBookingStadium
            // 
            chartArea13.Name = "ChartArea1";
            this.chartBookingStadium.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chartBookingStadium.Legends.Add(legend13);
            this.chartBookingStadium.Location = new System.Drawing.Point(64, 262);
            this.chartBookingStadium.Name = "chartBookingStadium";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chartBookingStadium.Series.Add(series13);
            this.chartBookingStadium.Size = new System.Drawing.Size(373, 345);
            this.chartBookingStadium.TabIndex = 3;
            this.chartBookingStadium.Text = "Booking By Stadium";
            this.chartBookingStadium.Click += new System.EventHandler(this.chartBookingStadium_Click);
            // 
            // chartPopularMatch
            // 
            chartArea14.Name = "ChartArea1";
            this.chartPopularMatch.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chartPopularMatch.Legends.Add(legend14);
            this.chartPopularMatch.Location = new System.Drawing.Point(808, 262);
            this.chartPopularMatch.Name = "chartPopularMatch";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.chartPopularMatch.Series.Add(series14);
            this.chartPopularMatch.Size = new System.Drawing.Size(373, 345);
            this.chartPopularMatch.TabIndex = 4;
            this.chartPopularMatch.Text = "Popular Match";
            this.chartPopularMatch.Click += new System.EventHandler(this.chartPopularMatch_Click);
            // 
            // chartPaymentUsage
            // 
            chartArea15.Name = "ChartArea1";
            this.chartPaymentUsage.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.chartPaymentUsage.Legends.Add(legend15);
            this.chartPaymentUsage.Location = new System.Drawing.Point(468, 678);
            this.chartPaymentUsage.Name = "chartPaymentUsage";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.chartPaymentUsage.Series.Add(series15);
            this.chartPaymentUsage.Size = new System.Drawing.Size(373, 345);
            this.chartPaymentUsage.TabIndex = 5;
            this.chartPaymentUsage.Text = "Payment Usage";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.Location = new System.Drawing.Point(338, 169);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(64, 25);
            this.labelCustomer.TabIndex = 6;
            this.labelCustomer.Text = "label1";
            // 
            // labelBooking
            // 
            this.labelBooking.AutoSize = true;
            this.labelBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBooking.Location = new System.Drawing.Point(598, 169);
            this.labelBooking.Name = "labelBooking";
            this.labelBooking.Size = new System.Drawing.Size(64, 25);
            this.labelBooking.TabIndex = 7;
            this.labelBooking.Text = "label1";
            // 
            // labelReveneu
            // 
            this.labelReveneu.AutoSize = true;
            this.labelReveneu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReveneu.Location = new System.Drawing.Point(854, 169);
            this.labelReveneu.Name = "labelReveneu";
            this.labelReveneu.Size = new System.Drawing.Size(64, 25);
            this.labelReveneu.TabIndex = 8;
            this.labelReveneu.Text = "label1";
            this.labelReveneu.Click += new System.EventHandler(this.labelReveneu_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(419, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(425, 39);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "Analytic World Cup 2026 ";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 107);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectEDP.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormAnalyticAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 1046);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelReveneu);
            this.Controls.Add(this.labelBooking);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.chartPaymentUsage);
            this.Controls.Add(this.chartPopularMatch);
            this.Controls.Add(this.chartBookingStadium);
            this.Controls.Add(this.labelTotalRevenue);
            this.Controls.Add(this.labelTotalBooking);
            this.Controls.Add(this.labelTotalCust);
            this.Name = "FormAnalyticAdmin";
            this.Text = "Form Analytic Admin";
            this.Load += new System.EventHandler(this.FormAnalyticAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBookingStadium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPopularMatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPaymentUsage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalCust;
        private System.Windows.Forms.Label labelTotalBooking;
        private System.Windows.Forms.Label labelTotalRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBookingStadium;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPopularMatch;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPaymentUsage;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label labelBooking;
        private System.Windows.Forms.Label labelReveneu;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}