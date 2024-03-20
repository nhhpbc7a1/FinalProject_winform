using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTraoDoiHang
{
    public partial class FormAddNewProduct : Form
    {
        public FormAddNewProduct()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        ProductDAO productDAO = new ProductDAO();
        DBConnection dBConnection = new DBConnection();


        private void btnChangePicture_Click_1(object sender, EventArgs e)
        {
            picboxProduct.BackgroundImage = MyImage.ChooseImage();
            picboxProduct.Refresh(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            if (txtOriginalPrice.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Original Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOriginalPrice.Focus();
                return;
            }

            Product x = new Product(0, txtType.Text, txtName.Text, Convert.ToInt32(txtPrice.Text), picboxProduct.BackgroundImage,
            Convert.ToInt32(txtOriginalPrice.Text), txtCondition.Text, txtWarranty.Text, DateOnly.FromDateTime(dtpBought.Value), txtBrand.Text, txtOrigin.Text, richTextBoxDescription.Text);


            productDAO.Add(x);
        }

        private void btnTakeFirst_Click(object sender, EventArgs e)
        {
            DataTable x = productDAO.Load();

            if (x.Rows.Count > 0)
            {
                DataRow row = x.Rows[0];
                txtType.Text = row["type"].ToString();
                txtName.Text = row["name"].ToString();
                txtPrice.Text = row["price"].ToString();
                picboxProduct.BackgroundImage = MyImage.ByteArrayToImage((byte[])row["image"]);
                txtOriginalPrice.Text = row["originalPrice"].ToString();
                txtCondition.Text = row["condition"].ToString();
                txtWarranty.Text = row["warrantyPolicy"].ToString();
                dtpBought.Value = Convert.ToDateTime(row["dateBought"]);
                txtBrand.Text = row["brand"].ToString();
                txtOrigin.Text = row["Origin"].ToString();
                richTextBoxDescription.Text = row["Description"].ToString();
                return;
            }
            else
            {
                MessageBox.Show("Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            if (txtOriginalPrice.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Original Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOriginalPrice.Focus();
                return;
            }

            Product x = new Product(0, txtType.Text, txtName.Text, Convert.ToInt32(txtPrice.Text), picboxProduct.BackgroundImage,
            Convert.ToInt32(txtOriginalPrice.Text), txtCondition.Text, txtWarranty.Text, DateOnly.FromDateTime(dtpBought.Value), txtBrand.Text, txtOrigin.Text, richTextBoxDescription.Text);

            string sqlStr = string.Format("SELECT *  FROM Product ");
            DataTable table = dBConnection.Load(sqlStr);
            x.productId = Convert.ToInt32(table.Rows[0]["productId"]);

            productDAO.Delete(x);
        }
    }
}
