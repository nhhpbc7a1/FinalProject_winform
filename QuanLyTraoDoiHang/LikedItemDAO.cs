using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTraoDoiHang
{
    class LikedItemDAO
    {
        public static SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public static DBConnection dBConnection = new DBConnection();

        private static string tableName = "LikedItem";

        public static void Add(LikedItem LikedItem)
        {
            string SQL = string.Format(" INSERT INTO " + tableName + " (userId, productId) VALUES ('{0}','{1}')", LikedItem.userId, LikedItem.productId);
            dBConnection.Execute(SQL);
        }
        public static void Delete(LikedItem LikedItem)
        {
            string SQL = string.Format("DELETE FROM " + tableName + " WHERE userId = '{0}' and productId = '{1}';", LikedItem.userId, LikedItem.productId);
            dBConnection.Execute(SQL);
        }
        public static LikedItem RowToLikedItem(DataRow row)
        {
            LikedItem likedItem = new LikedItem();
            likedItem.userId = Convert.ToInt32(row["userId"]);
            likedItem.productId = Convert.ToInt32(row["productId"]);
            return likedItem;
        }

        public static DataTable SelectByUserId(int userId)
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName + " where userId='{0}'", userId);
            return dBConnection.Load(sqlStr);
        }
        public static LikedItem SelectByLikedItem(LikedItem LikedItem)
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName + " where userId='{0}' and productId='{1}'", LikedItem.userId, LikedItem.productId);
            DataTable x = dBConnection.Load(sqlStr);
            if (x.Rows.Count > 0)
                return RowToLikedItem(x.Rows[0]);
            return null;
        }
        public static void DeleteProductBeOrdered()
        {
            string sqlStr = string.Format("SELECT productId FROM OrderTable,LikedItem where status != 'cancel' ");
            DataTable x = dBConnection.Load(sqlStr);
            foreach (DataRow row in x.Rows)
            {
                DeletedByProductId(Convert.ToInt32(row["productId"]));
            }
        }
        public static void DeletedByProductId(int productId)
        {
            string SQL = string.Format("DELETE FROM " + tableName + " WHERE productId = '{0}';", productId);
            dBConnection.Execute(SQL);

        }

    }
}