using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyTraoDoiHang
{
    public partial class FAnalysis : Form
    {
        OrderTable orderTable = new OrderTable();
        DataTable x;
        DateTime checkStart, checkEnd;
        int numberdays;
        public FAnalysis()
        {
            InitializeComponent();
            checkStart = dtpStartTime.Value;
            checkEnd = dtpEndtime.Value;
            lblOrdersNumber.Text = Convert.ToString(OrderTableDAO.CountOrder(Program.currentUserId));
            lblRevenueNumber.Text = Convert.ToString(OrderTableDAO.Revenue(Program.currentUserId));
            double revenue = Convert.ToDouble(OrderTableDAO.Revenue(Program.currentUserId));
            double profit = 0.2 * revenue;
            lblProfitNumber.Text = Convert.ToString(profit);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            checkStart = dtpStartTime.Value;
            checkEnd = dtpEndtime.Value;
            numberdays = (checkEnd - checkStart).Days;
            if (numberdays <= 30)
            {
                fillChartbyDays();
            }
            else if (numberdays <= (360 * 2))
            {
                fillChartbyMonths(checkStart, checkEnd);
            }

            //Update bottom 
            DBConnection dBConnection;
            x = OrderTableDAO.TakeOrderBySellerIdAndTime(Program.currentUserId, dtpStartTime.Value, dtpEndtime.Value);
            lblOrdersNumber.Text = x.Rows.Count.ToString();
            int sum = 0;
            foreach (DataRow row in x.Rows) 
            {
                sum += Convert.ToInt32(row["totalprice"]);
            }
            lblRevenueNumber.Text = sum.ToString();
            double revenue = Convert.ToDouble(sum);
            double profit = 0.2 * revenue;
            lblProfitNumber.Text = Convert.ToString(profit);

        }

        private void fillChartbyMonths(DateTime checkStart, DateTime checkEnd)
        {
            DataTable revenueData = OrderTableDAO.Revenue_Month(Program.currentUserId, checkStart, checkEnd);
            chartGrossRevenue.DataSource = revenueData;
            chartGrossRevenue.Series[0].XValueType = ChartValueType.DateTime;
            chartGrossRevenue.ChartAreas[0].AxisX.LabelStyle.Format = "MMM yyyy";
            chartGrossRevenue.Series[0].XValueMember = "monthh";
            chartGrossRevenue.Series[0].YValueMembers = "revenue";
            chartGrossRevenue.DataBind();
        }
        private void fillChartbyDays()
        {
            DataTable revenueData = OrderTableDAO.Revenue_Days(Program.currentUserId, checkStart, checkEnd);
            chartGrossRevenue.DataSource = revenueData;
            chartGrossRevenue.Series[0].XValueType = ChartValueType.DateTime;
            chartGrossRevenue.ChartAreas[0].AxisX.LabelStyle.Format = "dd MMM";
            chartGrossRevenue.Series[0].XValueMember = "day_month";
            chartGrossRevenue.Series[0].YValueMembers = "revenue";
            chartGrossRevenue.DataBind();
        }
        private void fillChartbyWeeks()
        {
            DataTable revenueData = OrderTableDAO.Revenue_Days(Program.currentUserId, DateTime.Today.AddDays(-7), DateTime.Today.AddDays(-1));
            chartGrossRevenue.DataSource = revenueData;
            chartGrossRevenue.Series[0].XValueType = ChartValueType.DateTime;
            chartGrossRevenue.ChartAreas[0].AxisX.LabelStyle.Format = "dd MMM";
            chartGrossRevenue.Series[0].Name = "revenue";
            chartGrossRevenue.Series[0].XValueMember = "day_month";
            chartGrossRevenue.Series[0].YValueMembers = "revenue";
            chartGrossRevenue.DataBind();
        }
        private void fillTop5Product()
        {
            DataTable top5products = OrderTableDAO.Top5Products(Program.currentUserId);
            charttop5.DataSource = top5products;
            charttop5.Series[0].XValueMember = "Category";
            charttop5.Series[0].YValueMembers = "CategoryCount";
            charttop5.DataBind();
        }
        private void chartGrossRevenue_Click(object sender, EventArgs e)
        {

        }

        private void FAnalysis_Load(object sender, EventArgs e)
        {
            fillChartbyMonths(DateTime.Today.AddMonths(-3), DateTime.Today);
            fillTop5Product();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            fillChartbyMonths(DateTime.Today.AddMonths(-3), DateTime.Today);
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            fillChartbyWeeks();
        }
    }
}
