namespace QuanLyTraoDoiHang
{
    partial class FAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndtime = new System.Windows.Forms.DateTimePicker();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnWeek = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNoOfOrders = new System.Windows.Forms.Label();
            this.lblOrdersNumber = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblRevenueNumber = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblProfitNumber = new System.Windows.Forms.Label();
            this.chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlGrossRevenue = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chTop5Products = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblOrder = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).BeginInit();
            this.pnlGrossRevenue.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chTop5Products)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "MMM dd, yyyy";
            this.dtpStartTime.Location = new System.Drawing.Point(13, 11);
            this.dtpStartTime.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(129, 23);
            this.dtpStartTime.TabIndex = 0;
            // 
            // dtpEndtime
            // 
            this.dtpEndtime.CustomFormat = "MMM dd, yyyy";
            this.dtpEndtime.Location = new System.Drawing.Point(168, 9);
            this.dtpEndtime.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dtpEndtime.Name = "dtpEndtime";
            this.dtpEndtime.Size = new System.Drawing.Size(129, 23);
            this.dtpEndtime.TabIndex = 1;
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(346, 7);
            this.btnCustom.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(77, 21);
            this.btnCustom.TabIndex = 2;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(426, 7);
            this.btnToday.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(77, 21);
            this.btnToday.TabIndex = 3;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            // 
            // btnWeek
            // 
            this.btnWeek.Location = new System.Drawing.Point(506, 7);
            this.btnWeek.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(77, 21);
            this.btnWeek.TabIndex = 4;
            this.btnWeek.Text = "This Week";
            this.btnWeek.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(586, 7);
            this.btn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(77, 21);
            this.btn.TabIndex = 5;
            this.btn.Text = "This Month";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(304, 7);
            this.btnOk.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(40, 21);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(148)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.lblNoOfOrders);
            this.panel1.Controls.Add(this.lblOrdersNumber);
            this.panel1.Location = new System.Drawing.Point(13, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 47);
            this.panel1.TabIndex = 7;
            // 
            // lblNoOfOrders
            // 
            this.lblNoOfOrders.AutoSize = true;
            this.lblNoOfOrders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNoOfOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNoOfOrders.Location = new System.Drawing.Point(15, 0);
            this.lblNoOfOrders.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNoOfOrders.Name = "lblNoOfOrders";
            this.lblNoOfOrders.Size = new System.Drawing.Size(116, 15);
            this.lblNoOfOrders.TabIndex = 8;
            this.lblNoOfOrders.Text = "Numbers Of Orders";
            // 
            // lblOrdersNumber
            // 
            this.lblOrdersNumber.AutoSize = true;
            this.lblOrdersNumber.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblOrdersNumber.Location = new System.Drawing.Point(39, 18);
            this.lblOrdersNumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOrdersNumber.Name = "lblOrdersNumber";
            this.lblOrdersNumber.Size = new System.Drawing.Size(60, 28);
            this.lblOrdersNumber.TabIndex = 9;
            this.lblOrdersNumber.Text = "1000";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(148)))), ((int)(((byte)(112)))));
            this.panel2.Controls.Add(this.lblRevenue);
            this.panel2.Controls.Add(this.lblRevenueNumber);
            this.panel2.Location = new System.Drawing.Point(171, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 47);
            this.panel2.TabIndex = 10;
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRevenue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRevenue.Location = new System.Drawing.Point(22, 0);
            this.lblRevenue.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(87, 15);
            this.lblRevenue.TabIndex = 8;
            this.lblRevenue.Text = "Total Revenue";
            // 
            // lblRevenueNumber
            // 
            this.lblRevenueNumber.AutoSize = true;
            this.lblRevenueNumber.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblRevenueNumber.Location = new System.Drawing.Point(54, 19);
            this.lblRevenueNumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblRevenueNumber.Name = "lblRevenueNumber";
            this.lblRevenueNumber.Size = new System.Drawing.Size(60, 28);
            this.lblRevenueNumber.TabIndex = 9;
            this.lblRevenueNumber.Text = "1000";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(148)))), ((int)(((byte)(112)))));
            this.panel3.Controls.Add(this.lblProfit);
            this.panel3.Controls.Add(this.lblProfitNumber);
            this.panel3.Location = new System.Drawing.Point(416, 42);
            this.panel3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 47);
            this.panel3.TabIndex = 11;
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProfit.Location = new System.Drawing.Point(22, 0);
            this.lblProfit.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(69, 15);
            this.lblProfit.TabIndex = 8;
            this.lblProfit.Text = "Total Profit";
            // 
            // lblProfitNumber
            // 
            this.lblProfitNumber.AutoSize = true;
            this.lblProfitNumber.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblProfitNumber.Location = new System.Drawing.Point(54, 19);
            this.lblProfitNumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProfitNumber.Name = "lblProfitNumber";
            this.lblProfitNumber.Size = new System.Drawing.Size(60, 28);
            this.lblProfitNumber.TabIndex = 9;
            this.lblProfitNumber.Text = "1000";
            // 
            // chartGrossRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGrossRevenue.ChartAreas.Add(chartArea1);
            this.chartGrossRevenue.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chartGrossRevenue.Legends.Add(legend1);
            this.chartGrossRevenue.Location = new System.Drawing.Point(0, 0);
            this.chartGrossRevenue.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.chartGrossRevenue.Name = "chartGrossRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGrossRevenue.Series.Add(series1);
            this.chartGrossRevenue.Size = new System.Drawing.Size(367, 247);
            this.chartGrossRevenue.TabIndex = 12;
            this.chartGrossRevenue.Text = "Gross Revenue";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            title1.Name = "Title1";
            title1.Text = "Gross Revenue";
            this.chartGrossRevenue.Titles.Add(title1);
            // 
            // pnlGrossRevenue
            // 
            this.pnlGrossRevenue.Controls.Add(this.chartGrossRevenue);
            this.pnlGrossRevenue.Location = new System.Drawing.Point(13, 97);
            this.pnlGrossRevenue.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pnlGrossRevenue.Name = "pnlGrossRevenue";
            this.pnlGrossRevenue.Size = new System.Drawing.Size(367, 251);
            this.pnlGrossRevenue.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chTop5Products);
            this.panel5.Location = new System.Drawing.Point(383, 97);
            this.panel5.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(302, 420);
            this.panel5.TabIndex = 14;
            // 
            // chTop5Products
            // 
            chartArea2.Name = "ChartArea1";
            this.chTop5Products.ChartAreas.Add(chartArea2);
            this.chTop5Products.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chTop5Products.Legends.Add(legend2);
            this.chTop5Products.Location = new System.Drawing.Point(0, 0);
            this.chTop5Products.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.chTop5Products.Name = "chTop5Products";
            this.chTop5Products.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chTop5Products.Series.Add(series2);
            this.chTop5Products.Size = new System.Drawing.Size(302, 419);
            this.chTop5Products.TabIndex = 12;
            this.chTop5Products.Text = "Top 5 Products";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            title2.Name = "Title1";
            title2.Text = "Top 5 Products";
            this.chTop5Products.Titles.Add(title2);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(148)))), ((int)(((byte)(112)))));
            this.panel4.Controls.Add(this.lblOrder);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lblCustomer);
            this.panel4.Controls.Add(this.lblCustomerCount);
            this.panel4.Location = new System.Drawing.Point(13, 353);
            this.panel4.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 164);
            this.panel4.TabIndex = 15;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOrder.Location = new System.Drawing.Point(9, 80);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(116, 15);
            this.lblOrder.TabIndex = 10;
            this.lblOrder.Text = "Numbers Of Orders";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(191, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "1000";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustomer.Location = new System.Drawing.Point(9, 27);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(137, 15);
            this.lblCustomer.TabIndex = 8;
            this.lblCustomer.Text = "Numbers Of Customers";
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCustomerCount.Location = new System.Drawing.Point(191, 45);
            this.lblCustomerCount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(60, 28);
            this.lblCustomerCount.TabIndex = 9;
            this.lblCustomerCount.Text = "1000";
            // 
            // FAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(811, 527);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlGrossRevenue);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnWeek);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.dtpEndtime);
            this.Controls.Add(this.dtpStartTime);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FAnalysis";
            this.Text = "FAnalysis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).EndInit();
            this.pnlGrossRevenue.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chTop5Products)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker dtpStartTime;
        private DateTimePicker dtpEndtime;
        private Button btnCustom;
        private Button btnToday;
        private Button btnWeek;
        private Button btn;
        private Button btnOk;
        private Panel panel1;
        private Label lblNoOfOrders;
        private Label lblOrdersNumber;
        private Panel panel2;
        private Label lblRevenue;
        private Label lblRevenueNumber;
        private Panel panel3;
        private Label lblProfit;
        private Label lblProfitNumber;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenue;
        private Panel pnlGrossRevenue;
        private Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chTop5Products;
        private Panel panel4;
        private Label lblOrder;
        private Label label4;
        private Label lblCustomer;
        private Label lblCustomerCount;
    }
}