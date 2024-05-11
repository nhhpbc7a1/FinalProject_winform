using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyTraoDoiHang
{

    class ProductDAO
    {
        public static SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public static DBConnection dBConnection = new DBConnection();

        private static string tableName = "product";

        public static int CreateID()
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName);
            DataTable x = dBConnection.Load(sqlStr);
            int maxValue = 0;
            foreach (DataRow row in x.Rows)
            {
                maxValue = Math.Max(maxValue, Convert.ToInt32(row["productId"]));
            }
            return maxValue + 1;
        }


        public ProductDAO() { }
        public void Update(Product product)
        {
            string sqlStr = string.Format("SELECT productId FROM OrderTable,OrderItem where status<>'cancelled' and OrderTable.orderId = orderItem.orderId");
            DataTable y = dBConnection.Load(sqlStr);
            foreach (DataRow rowY in y.Rows)
            {
                if (product.productId.ToString() == rowY["productId"].ToString())
                {
                    MessageBox.Show("This product are being ordered");
                    return;
                }
            }

            byte[] imageData = MyImage.ImageToByteArray(product.image);

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connStr))
            {
                connection.Open();

                string SQL = string.Format(" UPDATE " + tableName + " SET sellerId = '{1}', category = N'{2}', name = N'{3}', price = '{4}', image = @ImageData, originalPrice = '{6}', condition = N'{7}', warrantyPolicy = N'{8}', dateBought = '{9}', Brand = N'{10}', Origin = N'{11}', Description = N'{12}', PostedDate='{13}', SearchCounter='{14}'  WHERE productId = '{0}' ;",
                product.productId, product.sellerId, product.category, product.name, product.price, null, product.originalPrice, product.condition, product.warrantyPolicy, product.dateBought, product.brand, product.origin, product.description, product.PostedDate, product.SearchCounter);

                SqlCommand cmd = new SqlCommand(SQL, connection);
                cmd.Parameters.Add("@ImageData", System.Data.SqlDbType.VarBinary, -1).Value = imageData;
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("save successfully");
            }
        }
        public void Add(Product product)
        {
            byte[] imageData = MyImage.ImageToByteArray(product.image);

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connStr))
            {
                connection.Open();
                string sqlStr = string.Format("INSERT INTO " + tableName + "(productId,sellerId,category,name,price,image,originalPrice,condition,warrantyPolicy,dateBought,Brand,Origin,Description,PostedDate,SearchCounter) VALUES ('{0}','{1}',N'{2}',N'{3}','{4}',@ImageData,'{6}',N'{7}',N'{8}','{9}',N'{10}',N'{11}',N'{12}','{13}','{14}')",
                product.productId, product.sellerId, product.category, product.name, product.price, null, product.originalPrice, product.condition, product.warrantyPolicy, product.dateBought, product.brand, product.origin, product.description, product.PostedDate, product.SearchCounter);

                SqlCommand cmd = new SqlCommand(sqlStr, connection);
                cmd.Parameters.Add("@ImageData", System.Data.SqlDbType.VarBinary, -1).Value = imageData;
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("add successfully");

            }

        }
        public static void Delete(Product product)
        {
            string sqlStr = string.Format("SELECT productId FROM OrderTable,OrderItem where status<>'cancelled' and OrderTable.orderId = orderItem.orderId");
            DataTable y = dBConnection.Load(sqlStr);
            foreach (DataRow rowY in y.Rows)
            {
                if (product.productId.ToString() == rowY["productId"].ToString())
                {
                    MessageBox.Show("This product are being ordered");
                    return;
                }
            }
            if (MessageBox.Show("Do you really want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SubDeleteProduct(product);
                string SQL = string.Format("DELETE FROM " + tableName + " WHERE productId = '{0}';", product.productId);
                dBConnection.Execute(SQL);
                MessageBox.Show("Delete successfully");
            }
        }
        //Delete products have constraint in other table
        public static void SubDeleteProduct(Product product)
        {
            string SQL = string.Format("DELETE FROM " + "OrderItem" + " WHERE productId = '{0}';", product.productId);
            dBConnection.Execute(SQL);
            string Sql = string.Format("DELETE FROM " + "DetailImage" + " WHERE productId = '{0}';", product.productId);
            dBConnection.Execute(Sql);
        }
        public static Product RowToProduct(DataRow row)
        {
            Product product = new Product();
            product.productId = Convert.ToInt32(row["productId"]);
            product.sellerId = Convert.ToInt32(row["sellerId"]);
            product.category = row["category"].ToString();
            product.name = row["name"].ToString();
            product.price = Convert.ToInt32(row["price"]);
            try
            {
                product.image = MyImage.ByteArrayToImage((byte[])row["image"]);
            }
            catch
            {
                product.image = Program.TakeRandom();
            }

            product.originalPrice = Convert.ToInt32(row["originalPrice"]);
            product.condition = row["condition"].ToString();
            product.warrantyPolicy = row["warrantyPolicy"].ToString();
            product.dateBought = DateOnly.FromDateTime(Convert.ToDateTime(row["DateBought"]));
            product.brand = row["brand"].ToString();
            product.origin = row["origin"].ToString();
            product.description = row["description"].ToString();
            product.PostedDate = Convert.ToDateTime(row["PostedDate"]);
            product.SearchCounter = Convert.ToInt32(row["SearchCounter"]);


            return product;

        }
        public static Product SelectById(int id)
        {
            string SQL = string.Format("Select * FROM " + tableName + " WHERE productId = '{0}';", id);
            DataTable x = dBConnection.Load(SQL);
            Product product = new Product();
            if (x.Rows.Count > 0)
            {
                product = RowToProduct(x.Rows[0]);
            }
            else
            {
                MessageBox.Show("not exit");
            }
            return product;
        }
        public static DataTable SelectBySellerId(int sellerId)
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName + " where sellerId='{0}';", sellerId);
            return dBConnection.Load(sqlStr);
        }
        public static List<Product> SearchProducts(List<Product> productList, string searchString)
        {
            List<Product> relatedProducts = new List<Product>();
            foreach (Product product in productList)
            {
                if (product.name.ToLower().Contains(searchString.ToLower()))
                {
                    relatedProducts.Add(product);
                }
            }
            return relatedProducts;
        }
        public static DataTable LoadCanBuy()
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName + " ORDER BY SearchCounter DESC;");
            DataTable x = dBConnection.Load(sqlStr);
            //return x; 
            sqlStr = string.Format("SELECT productId FROM OrderTable,OrderItem where status<>'cancelled' and OrderTable.orderId = orderItem.orderId ");
            DataTable y = dBConnection.Load(sqlStr);
            //return y;
            DataTable z = x;
            for (int i = 0; i < x.Rows.Count; i++)
            {
                DataRow rowX = x.Rows[i];
                bool kt = true;
                foreach (DataRow rowY in y.Rows)
                {
                    if (rowX["productId"].ToString() == rowY["productId"].ToString())
                    {
                        kt = false;
                        break;
                    }
                }
                if (kt == false)
                {
                    z.Rows.RemoveAt(i--);
                }

            }
            return z;
        }
        public static DataTable LoadCanBuy_SameCategory(string category)
        {
            DataTable x = LoadCanBuy();

            for (int i = 0; i < x.Rows.Count; i++)
            {
                Product tmp = RowToProduct(x.Rows[i]);
                if (tmp.category != category)
                    x.Rows.RemoveAt(i--);
            }
            return x;
        }
        public static DataTable LoadCanBuy_SameSeller(int sellerId)
        {
            DataTable x = LoadCanBuy();

            for (int i = 0; i < x.Rows.Count; i++)
            {
                Product tmp = RowToProduct(x.Rows[i]);
                if (tmp.sellerId != sellerId)
                    x.Rows.RemoveAt(i--);
            }
            return x;
        }
        public static void CountingSearch(Product product)
        {
            string SQL = string.Format(" UPDATE " + tableName + " SET SearchCounter='{1}'  WHERE productId = '{0}' ;", product.productId, product.SearchCounter);
            dBConnection.Execute(SQL);
        }
        public static void CancelByBuyer(Product product, OrderTable ordertable)
        {
            string sqlStr = string.Format("SELECT productId FROM OrderTable,OrderItem where status='cancelled' and OrderTable.orderId = orderItem.orderId and OrderTable.orderId='{0}'",ordertable.orderId);
            DataTable y = dBConnection.Load(sqlStr);
            foreach (DataRow rowY in y.Rows)
            {
                if (product.productId.ToString() == rowY["productId"].ToString())
                {
                    MessageBox.Show("This product is canceled by seller");
                    return;
                }
            }

             if (MessageBox.Show("Do you really want to cancel this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CancelReason cancel = new CancelReason();
                cancel.ShowDialog();
                string cancelreason = cancel.cBReason.Text;
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    connection.Open();
                    string SQL = string.Format("INSERT INTO" + " CancelProduct " + "(orderId,productId,reasonCancel) VALUES ('{0}','{1}','{2}')",
                    ordertable.orderId, product.productId, cancelreason);
                    SqlCommand cmd = new SqlCommand(SQL, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                string Sql = string.Format("Update" + " OrderTable " + " SET status = 'cancelled'  WHERE orderId = '{0}' ;",
                ordertable.orderId);
                dBConnection.Load(Sql);
                MessageBox.Show("cancel successfully");
            }
        }
    }    
}
