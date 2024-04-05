using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace QuanLyTraoDoiHang
{
    class RatingDAO
    {
        public static SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public static DBConnection dBConnection = new DBConnection();

        private static string tableName = "Rating";

        public static int CreateID()
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName);
            DataTable x = dBConnection.Load(sqlStr);
            int maxValue = 0;
            foreach (DataRow row in x.Rows)
            {
                maxValue = Math.Max(maxValue, Convert.ToInt32(row["RatingID"]));
            }
            return maxValue + 1;
        }


        public RatingDAO() { }
        public static DataTable Load()
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName);
            return dBConnection.Load(sqlStr);
        }


        public static void Update(Rating rating)
        {
            string SQL = string.Format(" UPDATE " + tableName + " SET senderUserId = '{1}', receiverUserId = '{2}', orderId = '{3}', marks = '{4}', detail = '{5}'  WHERE ratingId = '{0}' ;",
            rating.ratingId, rating.senderUserId, rating.receiverUserId, rating.orderId, rating.marks, rating.detail);
            dBConnection.Execute(SQL);
        }
        public static void Add(Rating rating)
        {
            string SQL = string.Format(" INSERT INTO " + tableName + " (ratingId, senderUserId, receiverUserId, orderId, marks, detail) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');",
            rating.ratingId, rating.senderUserId, rating.receiverUserId, rating.orderId, rating.marks, rating.detail);
            dBConnection.Execute(SQL);
        }
        public static void Delete(Rating rating)
        {
            string SQL = string.Format("DELETE FROM " + tableName + " WHERE ratingId = '{0}';", rating.ratingId);
            dBConnection.Execute(SQL);
        }
        public static Rating RowToRating(DataRow row)
        {
            Rating rating = new Rating();
            rating.ratingId = Convert.ToInt32(row["ratingId"]);
            rating.senderUserId = Convert.ToInt32(row["sennderUserId"]);
            rating.receiverUserId = Convert.ToInt32(row["receiverUserId"]);
            rating.orderId = Convert.ToInt32(row["orderId"]);
            rating.marks = Convert.ToInt32(row["marks"]);
            rating.detail = row["detail"].ToString();

            return rating;
        }

    }
}
