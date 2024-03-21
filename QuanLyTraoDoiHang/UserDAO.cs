using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTraoDoiHang
{
    internal class UserDAO
    {
        public static SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public static DBConnection dBConnection = new DBConnection();

        private static string tableName = "UserTable";

        public static int CreateID()
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName);
            DataTable x = dBConnection.Load(sqlStr);
            int maxValue = 0;
            foreach (DataRow row in x.Rows)
            {
                maxValue = Math.Max(maxValue, Convert.ToInt32(row["userId"]));
            }
            return maxValue + 1;
        }
        public static void Update(User user)
        {
            byte[] imageData = MyImage.ImageToByteArray(user.image);


            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connStr))
            {
                connection.Open();
                string sqlStr = string.Format(" UPDATE " + tableName + " SET personalId = '{1}', name = '{2}', birthday = '{3}', email = '{4}', phone = '{5}', gender = '{6}', address = '{7}', image = @ImageData  WHERE userId = '{0}' ;",
                user.userId, user.personalId, user.name, user.birthday, user.email, user.phone, user.gender, user.address, null);
                
                SqlCommand cmd = new SqlCommand(sqlStr, connection);
                cmd.Parameters.Add("@ImageData", System.Data.SqlDbType.VarBinary, -1).Value = imageData;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static void Add(User user)
        {
            byte[] imageData = MyImage.ImageToByteArray(user.image);

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connStr))
            {
                connection.Open();
                string sqlStr = string.Format("INSERT INTO " + tableName + " (userId, personalId, name, birthday, email, phone, gender, address, image) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',@ImageData)",
                user.userId, user.personalId, user.name, user.birthday, user.email, user.phone, user.gender, user.address, null);

                SqlCommand cmd = new SqlCommand(sqlStr, connection);
                cmd.Parameters.Add("@ImageData", System.Data.SqlDbType.VarBinary, -1).Value = imageData;
                cmd.ExecuteNonQuery();
                connection.Close();
            }

        }
        public static void Delete(User user)
        {
            string SQL = string.Format("DELETE FROM " + tableName + " WHERE userid = '{0}';", user.userId);
            dBConnection.Execute(SQL);
        }
        public static User RowToUser(DataRow row)
        {
            User user = new User();
            user.userId = Convert.ToInt32(row["userId"]);
            user.personalId = row["personalId"].ToString();
            user.name = row["name"].ToString();
            user.birthday = DateOnly.FromDateTime(Convert.ToDateTime(row["birthday"]));
            user.email = row["email"].ToString();
            user.phone = row["phone"].ToString();
            user.gender = Convert.ToInt32(row["gender"].ToString());
            user.address = row["address"].ToString();
            user.image = MyImage.ByteArrayToImage((byte[])row["image"]);

            return user;
        }

        public static User SelectByUserId(int userId)
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName + " where userId='{0}'",userId);
            DataTable x = dBConnection.Load(sqlStr);
            if (x.Rows.Count > 0)
                return RowToUser(x.Rows[0]);
            return null;
        }

        public static bool IsAdult(DateTime x)
        {
            if (Convert.ToDateTime(x).AddYears(18) < DateTime.Now)
            {
                return true;
            }
            return false;
        }
        public static bool IsValidEmail(string email)
        {
            var r = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return !String.IsNullOrEmpty(email) && r.IsMatch(email);
        }
        public static bool IsValidPhone(string phone)
        {
            return true;
            if (phone.Length != 12)
                return false;
            for (int i = 0; i < 12; i++)
            {
                if (((i == 3 || i == 8) && phone[i] != '-')
                 || (i != 3 && i != 8 && (phone[i] < '0' || '9' < phone[i])))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
