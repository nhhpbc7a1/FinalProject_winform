using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName);
            return dBConnection.Load(sqlStr);
        }
        public void Update(Product product)
        {
            byte[] imageData = MyImage.ImageToByteArray(product.image);

            string SQL = string.Format(" UPDATE " + tableName + " SET sellerId = '{1}', category = '{2}', name = '{3}', price = '{4}', image = '{5}', originalPrice = '{6}', condition = '{7}', warrantyPolicy = '{8}', dateBought = '{9}', Brand = '{10}', Origin = '{11}', Description = '{12}'  WHERE productId = '{0}' ;",
            product.productId, product.sellerId, product.category, product.name, product.price, null, product.originalPrice, product.condition, product.warrantyPolicy, product.dateBought, product.brand, product.origin, product.description);

            dBConnection.Execute(SQL);
        }
        public void Add(Product product)
        {
            byte[] imageData = MyImage.ImageToByteArray(product.image);

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connStr))
            {
                connection.Open();
                string sqlStr = string.Format("INSERT INTO " + tableName + "(productId,sellerId,category,name,price,image,originalPrice,condition,warrantyPolicy,dateBought,Brand,Origin,Description) VALUES ('{0}','{1}','{2}','{3}','{4}',@ImageData,'{6}','{7}','{8}','{9}','{10}','{11}',N'{12}')",
                product.productId, product.sellerId, product.category, product.name, product.price, null, product.originalPrice, product.condition, product.warrantyPolicy, product.dateBought, product.brand, product.origin, product.description);

                SqlCommand cmd = new SqlCommand(sqlStr, connection);
                cmd.Parameters.Add("@ImageData", System.Data.SqlDbType.VarBinary, -1).Value = imageData;
                cmd.ExecuteNonQuery();
                connection.Close();
            }

        }
        public void Delete(Product product)
        {
            string SQL = string.Format("DELETE FROM " + tableName + " WHERE productId = '{0}';", product.productId);
            dBConnection.Execute(SQL);
        }
        public static Product RowToProduct(DataRow row)
        {
            Product product = new Product();
            product.productId = Convert.ToInt32(row["productId"]);
            product.sellerId = Convert.ToInt32(row["sellerId"]);
            product.category = row["category"].ToString();
            product.name = row["name"].ToString();
            product.price = Convert.ToInt32(row["price"]);
            product.image = MyImage.ByteArrayToImage((byte[])row["image"]);
            product.originalPrice = Convert.ToInt32(row["originalPrice"]);
            product.condition = row["condition"].ToString();
            product.warrantyPolicy = row["warrantyPolicy"].ToString();
            product.dateBought = DateOnly.FromDateTime(Convert.ToDateTime(row["DateBought"]));
            product.brand = row["brand"].ToString();
            product.origin = row["origin"].ToString();
            product.description = row["description"].ToString();

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
    }
}
