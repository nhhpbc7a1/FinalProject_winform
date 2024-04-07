using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace QuanLyTraoDoiHang
{
    class CartItemDAO
    {
        public static SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public static DBConnection dBConnection = new DBConnection();

        private static string tableName = "CartItem";
        public static void Add(CartItem cartItem)
        {
            if (Program.currentUserId == -1)
            {
                MessageBox.Show("please login first");
                return;
            }
            if (Program.currentUserId == ProductDAO.SelectById(cartItem.productId).sellerId)
            {
                MessageBox.Show("You can not buy your product");
                return;
            }
            if (SelectByCartItem(cartItem) != null)
            {
                MessageBox.Show("Be added to cart");
                return;
            }

            string SQL = string.Format(" INSERT INTO " + tableName + " (userId, productId) VALUES ('{0}','{1}')", cartItem.userId, cartItem.productId);
            dBConnection.Execute(SQL);

            MessageBox.Show("add successfully ");
        }
        public static void Delete(CartItem cartItem)
        {
            string SQL = string.Format("DELETE FROM " + tableName + " WHERE userId = '{0}' and productId = '{1}';", cartItem.userId, cartItem.productId);
            dBConnection.Execute(SQL);
        }
        public static CartItem RowToCartItem(DataRow row)
        {
            CartItem cartItem = new CartItem();
            cartItem.userId = Convert.ToInt32(row["userId"]);
            cartItem.productId = Convert.ToInt32(row["productId"]);
            return cartItem;
        }

        public static DataTable SelectByUserId(int userId)
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName + " where userId='{0}'", userId);
            return dBConnection.Load(sqlStr);
        }
        public static CartItem SelectByCartItem(CartItem cartItem)
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName + " where userId='{0}' and productId='{1}'", cartItem.userId, cartItem.productId);
            DataTable x = dBConnection.Load(sqlStr);
            if (x.Rows.Count > 0)
                return RowToCartItem(x.Rows[0]);
            return null;
        }
        public static void DeleteProductBeOrdered()
        {
            string sqlStr = string.Format("SELECT productId FROM OrderTable,OrderItem where status != 'cancel' ");
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
