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
            panel4 = new Panel();
            charttop5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGrossRevenue).BeginInit();
            pnlGrossRevenue.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)charttop5).BeginInit();
            SuspendLayout();
            // 
            // dtpStartTime
            // 
            dtpStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpStartTime.Format = DateTimePickerFormat.Short;
            dtpStartTime.Location = new Point(57, 16);
            dtpStartTime.Margin = new Padding(1);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.Size = new Size(200, 23);
            dtpStartTime.TabIndex = 0;
            // 
            // dtpEndtime
            // 
            dtpEndtime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpEndtime.Format = DateTimePickerFormat.Short;
            dtpEndtime.Location = new Point(259, 16);
            dtpEndtime.Margin = new Padding(1);
            dtpEndtime.Name = "dtpEndtime";
            dtpEndtime.Size = new Size(190, 23);
            dtpEndtime.TabIndex = 1;
            // 
            // btnWeek
            // 
            btnWeek.Location = new Point(500, 16);
            btnWeek.Margin = new Padding(1);
            btnWeek.Name = "btnWeek";
            btnWeek.Size = new Size(109, 26);
            btnWeek.TabIndex = 4;
            btnWeek.Text = "This Week";
            btnWeek.UseVisualStyleBackColor = true;
            btnWeek.Click += btnWeek_Click;
            // 
            // btn
            // 
            btn.Location = new Point(611, 18);
            btn.Margin = new Padding(1);
            btn.Name = "btn";
            btn.Size = new Size(116, 24);
            btn.TabIndex = 5;
            btn.Text = "This Year";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(451, 17);
            btnOk.Margin = new Padding(1);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(47, 25);
            btnOk.TabIndex = 6;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(177, 148, 112);
            panel1.Controls.Add(lblNoOfOrders);
            panel1.Controls.Add(lblOrdersNumber);
            panel1.Location = new Point(460, 358);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 76);
            panel1.TabIndex = 7;
            // 
            // lblNoOfOrders
            // 
            lblNoOfOrders.AutoSize = true;
            lblNoOfOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNoOfOrders.ForeColor = SystemColors.ButtonHighlight;
            lblNoOfOrders.Location = new Point(12, 0);
            lblNoOfOrders.Margin = new Padding(1, 0, 1, 0);
            lblNoOfOrders.Name = "lblNoOfOrders";
            lblNoOfOrders.Size = new Size(116, 15);
            lblNoOfOrders.TabIndex = 8;
            lblNoOfOrders.Text = "Numbers Of Orders";
            // 
            // lblOrdersNumber
            // 
            lblOrdersNumber.AutoSize = true;
            lblOrdersNumber.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblOrdersNumber.Location = new Point(39, 18);
            lblOrdersNumber.Margin = new Padding(1, 0, 1, 0);
            lblOrdersNumber.Name = "lblOrdersNumber";
            lblOrdersNumber.Size = new Size(60, 28);
            lblOrdersNumber.TabIndex = 9;
            lblOrdersNumber.Text = "1000";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(177, 148, 112);
            panel2.Controls.Add(lblRevenue);
            panel2.Controls.Add(lblRevenueNumber);
            panel2.Location = new Point(460, 453);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 71);
            panel2.TabIndex = 10;
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRevenue.ForeColor = SystemColors.ButtonHighlight;
            lblRevenue.Location = new Point(40, 0);
            lblRevenue.Margin = new Padding(1, 0, 1, 0);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(87, 15);
            lblRevenue.TabIndex = 8;
            lblRevenue.Text = "Total Revenue";
            // 
            // lblRevenueNumber
            // 
            lblRevenueNumber.AutoSize = true;
            lblRevenueNumber.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblRevenueNumber.Location = new Point(54, 19);
            lblRevenueNumber.Margin = new Padding(1, 0, 1, 0);
            lblRevenueNumber.Name = "lblRevenueNumber";
            lblRevenueNumber.Size = new Size(60, 28);
            lblRevenueNumber.TabIndex = 9;
            lblRevenueNumber.Text = "1000";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(177, 148, 112);
            panel3.Controls.Add(lblProfit);
            panel3.Controls.Add(lblProfitNumber);
            panel3.Location = new Point(460, 550);
            panel3.Margin = new Padding(1);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 65);
            panel3.TabIndex = 11;
            // 
            // lblProfit
            // 
            lblProfit.AutoSize = true;
            lblProfit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfit.ForeColor = SystemColors.ButtonHighlight;
            lblProfit.Location = new Point(45, 0);
            lblProfit.Margin = new Padding(1, 0, 1, 0);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new Size(69, 15);
            lblProfit.TabIndex = 8;
            lblProfit.Text = "Total Profit";
            // 
            // lblProfitNumber
            // 
            lblProfitNumber.AutoSize = true;
            lblProfitNumber.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblProfitNumber.Location = new Point(54, 19);
            lblProfitNumber.Margin = new Padding(1, 0, 1, 0);
            lblProfitNumber.Name = "lblProfitNumber";
            lblProfitNumber.Size = new Size(60, 28);
            lblProfitNumber.TabIndex = 9;
            lblProfitNumber.Text = "1000";
            // 
            // chartGrossRevenue
            // 
            chartGrossRevenue.BorderlineColor = Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            chartGrossRevenue.ChartAreas.Add(chartArea1);
            chartGrossRevenue.Dock = DockStyle.Top;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            chartGrossRevenue.Legends.Add(legend1);
            chartGrossRevenue.Location = new Point(0, 0);
            chartGrossRevenue.Margin = new Padding(1);
            chartGrossRevenue.Name = "chartGrossRevenue";
            chartGrossRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.BackSecondaryColor = Color.FromArgb(255, 255, 192);
            series1.BorderColor = Color.FromArgb(64, 64, 0);
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.FromArgb(192, 192, 0);
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = Color.FromArgb(255, 192, 255);
            series1.Name = "revenue";
            chartGrossRevenue.Series.Add(series1);
            chartGrossRevenue.Size = new Size(670, 294);
            chartGrossRevenue.TabIndex = 12;
            chartGrossRevenue.Text = "Revenue";
            title1.Font = new Font("Microsoft Sans Serif", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            title1.Name = "Title1";
            title1.Text = "Revenue";
            chartGrossRevenue.Titles.Add(title1);
            chartGrossRevenue.Click += chartGrossRevenue_Click;
            // 
            // pnlGrossRevenue
            // 
            pnlGrossRevenue.Controls.Add(chartGrossRevenue);
            pnlGrossRevenue.Location = new Point(57, 53);
            pnlGrossRevenue.Margin = new Padding(1);
            pnlGrossRevenue.Name = "pnlGrossRevenue";
            pnlGrossRevenue.Size = new Size(670, 294);
            pnlGrossRevenue.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.Controls.Add(charttop5);
            panel4.Location = new Point(57, 349);
            panel4.Margin = new Padding(1);
            panel4.Name = "panel4";
            panel4.Size = new Size(395, 306);
            panel4.TabIndex = 14;
            // 
            // charttop5
            // 
            chartArea2.Name = "ChartArea1";
            charttop5.ChartAreas.Add(chartArea2);
            charttop5.Dock = DockStyle.Top;
            legend2.Name = "Legend1";
            charttop5.Legends.Add(legend2);
            charttop5.Location = new Point(0, 0);
            charttop5.Margin = new Padding(1);
            charttop5.Name = "charttop5";
            charttop5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.BackSecondaryColor = Color.FromArgb(255, 255, 128);
            series2.BorderColor = Color.FromArgb(192, 192, 0);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Top Products";
            charttop5.Series.Add(series2);
            charttop5.Size = new Size(395, 371);
            charttop5.TabIndex = 12;
            title2.Font = new Font("Microsoft Sans Serif", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            title2.Name = "Title1";
            title2.Text = "Top 5 products";
            charttop5.Titles.Add(title2);
            charttop5.Click += chart1_Click;
            // 
            // FAnalysis
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.FromArgb(164, 206, 149);
            ClientSize = new Size(782, 622);
            Controls.Add(panel4);
            Controls.Add(pnlGrossRevenue);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnOk);
            Controls.Add(btn);
            Controls.Add(btnWeek);
            Controls.Add(dtpEndtime);
            Controls.Add(dtpStartTime);
            Margin = new Padding(1);
            Name = "FAnalysis";
            Text = "FAnalysis";
            Load += FAnalysis_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartGrossRevenue).EndInit();
            pnlGrossRevenue.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)charttop5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpStartTime;
        private DateTimePicker dtpEndtime;
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
        private Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart charttop5;
    }
}