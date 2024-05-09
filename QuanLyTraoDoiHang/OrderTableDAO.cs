using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyTraoDoiHang
{
    class OrderTableDAO
    {
        public static SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public static DBConnection dBConnection = new DBConnection();

        private static string tableName = "OrderTable";

        public static int CreateID()
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName);
            DataTable x = dBConnection.Load(sqlStr);
            int maxValue = 0;
            foreach (DataRow row in x.Rows)
            {
                maxValue = Math.Max(maxValue, Convert.ToInt32(row["OrderId"]));
            }
            return maxValue + 1;
        }


        public OrderTableDAO() { }
        public static DataTable Load()
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName);
            return dBConnection.Load(sqlStr);
        }


        public static void Update(OrderTable orderTable)
        {
            string SQL = string.Format(" UPDATE " + tableName + " SET buyerId = '{1}', sellerId='{2}', receiveId = '{3}', time = '{4}', note = '{5}', shippingMethod = '{6}', shippingFee = '{7}', paymentMethod = '{8}', status = '{9}', totalprice ='{10}'  WHERE orderId = '{0}' ;",
            orderTable.orderId, orderTable.buyerId, orderTable.sellerId, orderTable.receiveId, orderTable.time, orderTable.note, orderTable.shippingMethod, orderTable.shippingFee, orderTable.paymentMethod, orderTable.status, orderTable.totalprice);
            dBConnection.Execute(SQL);
        }
        public static void Add(OrderTable orderTable)
        {
            string SQL = string.Format(" INSERT INTO " + tableName + " (orderId, buyerId, sellerId, receiveId, time, note, shippingMethod, shippingFee, paymentMethod, status, totalprice) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}', '{10}');",
            orderTable.orderId, orderTable.buyerId, orderTable.sellerId, orderTable.receiveId, orderTable.time, orderTable.note, orderTable.shippingMethod, orderTable.shippingFee, orderTable.paymentMethod, orderTable.status, orderTable.totalprice);
            dBConnection.Execute(SQL);
        }
        public static void Delete(OrderTable orderTable)
        {
            string SQL = string.Format("DELETE FROM " + tableName + " WHERE orderId = '{0}';", orderTable.orderId);
            dBConnection.Execute(SQL);
        }
        public static OrderTable RowToOrderTable(DataRow row)
        {
            OrderTable orderTable = new OrderTable();
            orderTable.orderId = Convert.ToInt32(row["orderId"]);
            orderTable.buyerId = Convert.ToInt32(row["buyerId"]);
            orderTable.sellerId = Convert.ToInt32(row["sellerId"]);
            orderTable.receiveId = Convert.ToInt32(row["receiveId"]);
            orderTable.time = Convert.ToDateTime(row["time"].ToString());
            orderTable.note = row["note"].ToString();
            orderTable.shippingFee = Convert.ToInt32(row["shippingFee"].ToString());
            orderTable.shippingMethod = row["shippingMethod"].ToString();
            orderTable.paymentMethod = row["paymentMethod"].ToString();
            orderTable.status = row["status"].ToString();
            orderTable.totalprice = Convert.ToInt32(row["totalprice"].ToString());


            return orderTable;
        }
        public static DataTable SellectBySellerId(int sellerId)
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName + " WHERE sellerId = '{0}' ",sellerId );
            return dBConnection.Load(sqlStr);
        }
        public static DataTable SellectByBuyerId(int buyerId)
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName + " WHERE buyerId = '{0}' ", buyerId);
            return dBConnection.Load(sqlStr);
        }
        public static OrderTable SelectById(int id)
        {
            string SQL = string.Format("Select * FROM " + tableName + " WHERE orderId = '{0}';", id);
            DataTable x = dBConnection.Load(SQL);
            OrderTable order = new OrderTable();
            if (x.Rows.Count > 0)
            {
                order = RowToOrderTable(x.Rows[0]);
            }
            else
            {
                MessageBox.Show("not exit");
            }
            return order;
        }
        public static int CountOrder_BySellerIdAndStatus(int sellerId,string status)
        {
            string SQL = string.Format("Select * FROM " + tableName + " WHERE status='{1}' and sellerId = '{0}';", sellerId, status);
            DataTable x = dBConnection.Load(SQL);
            return x.Rows.Count;
        }
        public static int CountOrder(int sellerId)
        {
            string SQL = string.Format("Select * FROM " + tableName + " WHERE status<>'cancelled' and sellerId = '{0}';", sellerId);
            DataTable x = dBConnection.Load(SQL);
            return x.Rows.Count;
        }
        public static decimal Revenue(int sellerId)
        {
            string SQL = string.Format("SELECT SUM(totalprice) AS TotalRevenue FROM " + tableName + " WHERE status <> 'cancelled' AND sellerId = '{0}';",sellerId);
            
            DataTable dataTable = dBConnection.Load(SQL);

            if (dataTable.Rows.Count > 0)
            {
                object totalRevenue = dataTable.Rows[0]["TotalRevenue"];
                if (totalRevenue != DBNull.Value)
                {
                    return Convert.ToDecimal(totalRevenue);
                }
            }

            return 0; // Trả về 0 nếu không có dữ liệu hoặc tổng doanh thu không tồn tại
        }

        public static DataTable Revenue_Days(int sellerID, DateTime start, DateTime end)
        {
            DataTable revenue = new DataTable();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
            {
                string tempTableSQL = "DECLARE @DateTable TABLE (day_month DATE); " +
                      "DECLARE @CurrentDate DATE = CONVERT(DATE, @start, 103); " +
                      "WHILE @CurrentDate <= @end " +
                      "BEGIN " +
                      "    INSERT INTO @DateTable (day_month) VALUES (@CurrentDate); " +
                      "    SET @CurrentDate = DATEADD(DAY, 1, @CurrentDate); " +
                      "END ";
                string mainQuerySQL = "SELECT DAY(dt.day_month) AS day,  DATENAME(MONTH, dt.day_month) as month, " +
                                      "COALESCE(SUM(ot.totalprice), 0) AS revenue, dt.day_month as day_month " +
                                      "FROM @DateTable dt " +
                                      "JOIN " + tableName + " ot ON DAY(dt.day_month) = DAY(ot.time) " +
                                      "                                   AND DATENAME(MONTH, dt.day_month) = DATENAME(MONTH, ot.time)" +
                                      "                                   AND ot.sellerId = @sellerId " +
                                      "                                   AND ot.status <> 'cancelled' " +
                                      "GROUP BY DAY(dt.day_month),DATENAME(MONTH, dt.day_month), dt.day_month";

                string SQL = tempTableSQL + mainQuerySQL;
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@sellerId", sellerID);
                cmd.Parameters.Add("@start", System.Data.SqlDbType.DateTime).Value = start;
                cmd.Parameters.Add("@end", System.Data.SqlDbType.DateTime).Value = end;
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Fill(revenue);
                }
                cmd.ExecuteNonQuery();
            }
            return revenue;
        }
        public static DataTable Revenue_Month(int sellerID, DateTime start, DateTime end)
        {
            DataTable revenue = new DataTable();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
            {
                string tempTableSQL = "DECLARE @DateTable TABLE (month DATE); " +
                      "DECLARE @CurrentDate DATE = DATEFROMPARTS(YEAR(@start), MONTH(@start), 1); " +
                     "DECLARE @EndDate DATE = DATEADD(MONTH,3, @end) " +
                      "WHILE @CurrentDate <=  @EndDate " +
                      "BEGIN " +
                      "    INSERT INTO @DateTable (month) VALUES (@CurrentDate); " +
                      "    SET @CurrentDate = DATEADD(MONTH, 1, @CurrentDate); " +
                      "END ";
                string mainQuerySQL = "SELECT DATENAME(MONTH, dt.month) as month, YEAR(dt.month) as year, " +
                                      " COALESCE(SUM(ot.totalprice), 0) AS revenue, dt.month as monthh " +
                                      "FROM @DateTable dt " +
                                      "LEFT JOIN " + tableName + " ot ON DATENAME(MONTH, dt.month) =  DATENAME(MONTH, ot.time) " +
                                      "                                   AND YEAR(dt.month) = YEAR(ot.time)" +
                                      "                                   AND ot.sellerId = @sellerId " +
                                      "                                   AND ot.status <> 'cancelled' " +
                                      "GROUP BY DATENAME(MONTH, dt.month),YEAR(dt.month), dt.month";

                string SQL = tempTableSQL + mainQuerySQL;
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@sellerId", sellerID);
                cmd.Parameters.Add("@start", System.Data.SqlDbType.DateTime).Value = start;
                cmd.Parameters.Add("@end", System.Data.SqlDbType.DateTime).Value = end;
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Fill(revenue);
                }

                cmd.ExecuteNonQuery();
            }
            return revenue;
        }
        public static DataTable Top5Products(int sellerID)
        {
            DataTable Top5Product = new DataTable();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
            {
                string SQL = "SELECT COUNT(Product.category) AS CategoryCount, " +
                    "Product.category as category FROM OrderTable " +
                    " INNER JOIN OrderItem ON OrderTable.orderId = OrderItem.orderId " +
                    " INNER JOIN Product ON OrderItem.productId = Product.productId " +
                     " WHERE OrderTable.sellerId = @sellerId AND Product.sellerId = @sellerId AND " +
                     " OrderTable.status <>  'cancelled' " +
                    " GROUP BY Product.Category " +
                    " Order by CategoryCount desc ";
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@sellerId", sellerID);
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Fill(Top5Product);
                }
                cmd.ExecuteNonQuery();
            }
            return Top5Product;
        }

    }
}

