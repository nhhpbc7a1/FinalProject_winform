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
            dtpStartTime = new DateTimePicker();
            dtpEndtime = new DateTimePicker();
            btnCustom = new Button();
            btnToday = new Button();
            btnWeek = new Button();
            btn = new Button();
            btnOk = new Button();
            panel1 = new Panel();
            lblNoOfOrders = new Label();
            lblOrdersNumber = new Label();
            panel2 = new Panel();
            lblRevenue = new Label();
            lblRevenueNumber = new Label();
            panel3 = new Panel();
            lblProfit = new Label();
            lblProfitNumber = new Label();
            chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pnlGrossRevenue = new Panel();
            panel5 = new Panel();
            chTop5Products = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel4 = new Panel();
            lblOrder = new Label();
            label4 = new Label();
            lblCustomer = new Label();
            lblCustomerCount = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGrossRevenue).BeginInit();
            pnlGrossRevenue.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chTop5Products).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dtpStartTime
            // 
            dtpStartTime.CustomFormat = "MMM dd, yyyy";
            dtpStartTime.Location = new Point(32, 31);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.Size = new Size(308, 47);
            dtpStartTime.TabIndex = 0;
            // 
            // dtpEndtime
            // 
            dtpEndtime.CustomFormat = "MMM dd, yyyy";
            dtpEndtime.Location = new Point(408, 24);
            dtpEndtime.Name = "dtpEndtime";
            dtpEndtime.Size = new Size(308, 47);
            dtpEndtime.TabIndex = 1;
            // 
            // btnCustom
            // 
            btnCustom.Location = new Point(841, 20);
            btnCustom.Name = "btnCustom";
            btnCustom.Size = new Size(188, 58);
            btnCustom.TabIndex = 2;
            btnCustom.Text = "Custom";
            btnCustom.UseVisualStyleBackColor = true;
            // 
            // btnToday
            // 
            btnToday.Location = new Point(1035, 20);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(188, 58);
            btnToday.TabIndex = 3;
            btnToday.Text = "Today";
            btnToday.UseVisualStyleBackColor = true;
            // 
            // btnWeek
            // 
            btnWeek.Location = new Point(1229, 20);
            btnWeek.Name = "btnWeek";
            btnWeek.Size = new Size(188, 58);
            btnWeek.TabIndex = 4;
            btnWeek.Text = "This Week";
            btnWeek.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            btn.Location = new Point(1423, 20);
            btn.Name = "btn";
            btn.Size = new Size(188, 58);
            btn.TabIndex = 5;
            btn.Text = "This Month";
            btn.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(739, 20);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(96, 58);
            btnOk.TabIndex = 6;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(177, 148, 112);
            panel1.Controls.Add(lblNoOfOrders);
            panel1.Controls.Add(lblOrdersNumber);
            panel1.Location = new Point(32, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 128);
            panel1.TabIndex = 7;
            // 
            // lblNoOfOrders
            // 
            lblNoOfOrders.AutoSize = true;
            lblNoOfOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNoOfOrders.ForeColor = SystemColors.ButtonHighlight;
            lblNoOfOrders.Location = new Point(37, 0);
            lblNoOfOrders.Name = "lblNoOfOrders";
            lblNoOfOrders.Size = new Size(293, 41);
            lblNoOfOrders.TabIndex = 8;
            lblNoOfOrders.Text = "Numbers Of Orders";
            // 
            // lblOrdersNumber
            // 
            lblOrdersNumber.AutoSize = true;
            lblOrdersNumber.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblOrdersNumber.Location = new Point(95, 50);
            lblOrdersNumber.Name = "lblOrdersNumber";
            lblOrdersNumber.Size = new Size(145, 67);
            lblOrdersNumber.TabIndex = 9;
            lblOrdersNumber.Text = "1000";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(177, 148, 112);
            panel2.Controls.Add(lblRevenue);
            panel2.Controls.Add(lblRevenueNumber);
            panel2.Location = new Point(415, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(576, 128);
            panel2.TabIndex = 10;
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRevenue.ForeColor = SystemColors.ButtonHighlight;
            lblRevenue.Location = new Point(53, 0);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(215, 41);
            lblRevenue.TabIndex = 8;
            lblRevenue.Text = "Total Revenue";
            // 
            // lblRevenueNumber
            // 
            lblRevenueNumber.AutoSize = true;
            lblRevenueNumber.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblRevenueNumber.Location = new Point(130, 51);
            lblRevenueNumber.Name = "lblRevenueNumber";
            lblRevenueNumber.Size = new Size(145, 67);
            lblRevenueNumber.TabIndex = 9;
            lblRevenueNumber.Text = "1000";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(177, 148, 112);
            panel3.Controls.Add(lblProfit);
            panel3.Controls.Add(lblProfitNumber);
            panel3.Location = new Point(1011, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(649, 128);
            panel3.TabIndex = 11;
            // 
            // lblProfit
            // 
            lblProfit.AutoSize = true;
            lblProfit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfit.ForeColor = SystemColors.ButtonHighlight;
            lblProfit.Location = new Point(53, 0);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new Size(177, 41);
            lblProfit.TabIndex = 8;
            lblProfit.Text = "Total Profit";
            // 
            // lblProfitNumber
            // 
            lblProfitNumber.AutoSize = true;
            lblProfitNumber.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblProfitNumber.Location = new Point(130, 51);
            lblProfitNumber.Name = "lblProfitNumber";
            lblProfitNumber.Size = new Size(145, 67);
            lblProfitNumber.TabIndex = 9;
            lblProfitNumber.Text = "1000";
            // 
            // chartGrossRevenue
            // 
            chartArea1.Name = "ChartArea1";
            chartGrossRevenue.ChartAreas.Add(chartArea1);
            chartGrossRevenue.Dock = DockStyle.Top;
            legend1.Name = "Legend1";
            chartGrossRevenue.Legends.Add(legend1);
            chartGrossRevenue.Location = new Point(0, 0);
            chartGrossRevenue.Name = "chartGrossRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartGrossRevenue.Series.Add(series1);
            chartGrossRevenue.Size = new Size(891, 676);
            chartGrossRevenue.TabIndex = 12;
            chartGrossRevenue.Text = "Gross Revenue";
            title1.Font = new Font("Microsoft Sans Serif", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            title1.Name = "Title1";
            title1.Text = "Gross Revenue";
            chartGrossRevenue.Titles.Add(title1);
            // 
            // pnlGrossRevenue
            // 
            pnlGrossRevenue.Controls.Add(chartGrossRevenue);
            pnlGrossRevenue.Location = new Point(32, 264);
            pnlGrossRevenue.Name = "pnlGrossRevenue";
            pnlGrossRevenue.Size = new Size(891, 685);
            pnlGrossRevenue.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.Controls.Add(chTop5Products);
            panel5.Location = new Point(929, 264);
            panel5.Name = "panel5";
            panel5.Size = new Size(734, 1147);
            panel5.TabIndex = 14;
            // 
            // chTop5Products
            // 
            chartArea2.Name = "ChartArea1";
            chTop5Products.ChartAreas.Add(chartArea2);
            chTop5Products.Dock = DockStyle.Top;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            chTop5Products.Legends.Add(legend2);
            chTop5Products.Location = new Point(0, 0);
            chTop5Products.Name = "chTop5Products";
            chTop5Products.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.LabelForeColor = Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chTop5Products.Series.Add(series2);
            chTop5Products.Size = new Size(734, 1144);
            chTop5Products.TabIndex = 12;
            chTop5Products.Text = "Top 5 Products";
            title2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            title2.Name = "Title1";
            title2.Text = "Top 5 Products";
            chTop5Products.Titles.Add(title2);
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(177, 148, 112);
            panel4.Controls.Add(lblOrder);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(lblCustomer);
            panel4.Controls.Add(lblCustomerCount);
            panel4.Location = new Point(32, 964);
            panel4.Name = "panel4";
            panel4.Size = new Size(891, 447);
            panel4.TabIndex = 15;
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrder.ForeColor = SystemColors.ButtonHighlight;
            lblOrder.Location = new Point(22, 220);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(293, 41);
            lblOrder.TabIndex = 10;
            lblOrder.Text = "Numbers Of Orders";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(465, 272);
            label4.Name = "label4";
            label4.Size = new Size(145, 67);
            label4.TabIndex = 11;
            label4.Text = "1000";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomer.ForeColor = SystemColors.ButtonHighlight;
            lblCustomer.Location = new Point(22, 75);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(346, 41);
            lblCustomer.TabIndex = 8;
            lblCustomer.Text = "Numbers Of Customers";
            // 
            // lblCustomerCount
            // 
            lblCustomerCount.AutoSize = true;
            lblCustomerCount.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCustomerCount.Location = new Point(465, 124);
            lblCustomerCount.Name = "lblCustomerCount";
            lblCustomerCount.Size = new Size(145, 67);
            lblCustomerCount.TabIndex = 9;
            lblCustomerCount.Text = "1000";
            // 
            // FAnalysis
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(164, 206, 149);
            ClientSize = new Size(1684, 1443);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(pnlGrossRevenue);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnOk);
            Controls.Add(btn);
            Controls.Add(btnWeek);
            Controls.Add(btnToday);
            Controls.Add(btnCustom);
            Controls.Add(dtpEndtime);
            Controls.Add(dtpStartTime);
            Name = "FAnalysis";
            Text = "FAnalysis";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartGrossRevenue).EndInit();
            pnlGrossRevenue.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chTop5Products).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
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