using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

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
            string SQL = string.Format(" UPDATE " + tableName + " SET buyerId = '{1}', sellerId='{2}', receiveId = '{3}', time = '{4}', note = '{5}', shippingMethod = '{6}', shippingFee = '{7}', paymentMethod = '{8}', status = '{9}'  WHERE orderId = '{0}' ;",
            orderTable.orderId, orderTable.buyerId, orderTable.sellerId, orderTable.receiveId, orderTable.time, orderTable.note, orderTable.shippingMethod, orderTable.shippingFee, orderTable.paymentMethod, orderTable.status);
            dBConnection.Execute(SQL);
        }
        public static void Add(OrderTable orderTable)
        {
            string SQL = string.Format(" INSERT INTO " + tableName + " (orderId, buyerId, sellerId, receiveId, time, note, shippingMethod, shippingFee, paymentMethod, status) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}');",
            orderTable.orderId, orderTable.buyerId, orderTable.sellerId, orderTable.receiveId, orderTable.time, orderTable.note, orderTable.shippingMethod, orderTable.shippingFee, orderTable.paymentMethod, orderTable.status);
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
    }
}
