using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string SQL = string.Format(" UPDATE " + tableName + " SET userId = '{1}', receiveId = '{2}', time = '{3}', note = '{4}', shippingMethod = '{5}', shippingFee = '{6}', paymentMethod = '{7}', status = '{8}'  WHERE orderId = '{0}' ;",
            orderTable.orderId, orderTable.userId, orderTable.receiveId, orderTable.time, orderTable.note, orderTable.shippingMethod, orderTable.shippingFee, orderTable.paymentMethod, orderTable.status);
            dBConnection.Execute(SQL);
        }
        public static void Add(OrderTable orderTable)
        {
            string SQL = string.Format(" INSERT INTO " + tableName + " (orderId, userId, receiveId, time, note, shippingMethod, shippingFee, paymentMethod, status) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');",
            orderTable.orderId, orderTable.userId, orderTable.receiveId, orderTable.time, orderTable.note, orderTable.shippingMethod, orderTable.shippingFee, orderTable.paymentMethod, orderTable.status);
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
            orderTable.userId = Convert.ToInt32(row["userId"]);
            orderTable.receiveId = Convert.ToInt32(row["orderId"]);
            orderTable.time = Convert.ToDateTime(row["time"].ToString());
            orderTable.note = row["note"].ToString();
            orderTable.shippingFee = Convert.ToInt32(row["shippingFee"].ToString());
            orderTable.shippingMethod = row["shippingMethod"].ToString();
            orderTable.paymentMethod = row["paymentMethod"].ToString();
            orderTable.status = row["status"].ToString();



            return orderTable;
        }
    }
}
