using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace QuanLyTraoDoiHang
{
    internal class AccountDAO
    {
        public static SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public static DBConnection dBConnection = new DBConnection();

        private static string tableName = "Account";
        public static void Update(Account account)
        {
            string SQL = string.Format(" UPDATE " + tableName + " SET username = '{1}', password = '{2}'  WHERE userId = '{0}' ;",
            account.userId, account.username, account.password);
            dBConnection.Execute(SQL);
        }
        public static void Add(Account account)
        {
            string SQL = string.Format(" INSERT INTO " + tableName + " (userId,username,password) VALUES ('{0}','{1}','{2}')",
            account.userId, account.username, account.password);
            dBConnection.Execute(SQL);
        }
        public static void Delete(Account account)
        {
            string SQL = string.Format("DELETE FROM " + tableName + " WHERE userId = '{0}';", account.userId);
            dBConnection.Execute(SQL);
        }
        public static bool CheckUsernameExist(string username)
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName + "where username='{0}' or ", username);
            DataTable x = dBConnection.Load(sqlStr);
            if (x.Rows.Count > 0)
                return true;
            return false;
        }
        public static Account RowToAccount(DataRow row)
        {
            Account account = new Account();
            account.userId = Convert.ToInt32(row["userId"]);
            account.username = row["username"].ToString();
            account.password = row["password"].ToString();
            return account;
        }

        public static Account SelectByUsername(string username)
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName + " where username='{0}'", username);
            DataTable x = dBConnection.Load(sqlStr);
            if (x.Rows.Count > 0)
                return RowToAccount(x.Rows[0]);
            return null;
        }
        public static Account SelectByUserID(int userID)
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName + " where userID ='{0}'", userID);
            DataTable x = dBConnection.Load(sqlStr);
            if (x.Rows.Count > 0)
                return RowToAccount(x.Rows[0]);
            return null;
        }
        public static bool IsValidPassword(string password)
        {
            if (password.Length < 6)
                return false;
            return true;
        }
        public static bool IsMatchedPassword(string newpass, string retypedpass)
        {
            if (retypedpass != newpass)
                return false;
            return true;
        }
        public static bool IsChangablePassword(Account account,string oldPass, string newPass, string retypePass)
        {
            if(oldPass != account.password)
            {
                MessageBox.Show("Your old password doesn't exist");
                return false;
            }
            if(!(IsValidPassword(newPass)))
            {
                MessageBox.Show("Your new password is not correct");

                return false;
            }
            if( retypePass != newPass )
            {
                MessageBox.Show("Your retyped password is not correct");
                return false;
            }
            return true;
        }

    }
}
