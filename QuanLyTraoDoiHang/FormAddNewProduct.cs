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
            picboxProduct.Click += picboxProduct_Click;
            lblAddPhoto.Click += lblAddPhoto_Click;
            btnSave.Click += btnSave_Click;

            //picboxProduct.BackgroundImage = Properties.Resources.empty_product;
        }
        Product product = null;
        public FormAddNewProduct(Product product)
        {
            InitializeComponent();
            picboxProduct.Click += picboxProduct_Click;
            lblAddPhoto.Click += lblAddPhoto_Click;
            btnSave.Click += btnSave_Click;
            this.product = product;
            txtCategory.Text = product.category;
            txtName.Text = product.name;
            txtPrice.Text = product.price.ToString();
            txtOriginalPrice.Text = product.originalPrice.ToString();
            txtCondition.Text = product.condition;
            txtWarranty.Text = product.warrantyPolicy;
            dtpBought.Text = product.dateBought.ToString();
            txtBrand.Text = product.brand;
            txtOrigin.Text = product.origin;
            richTextBoxDescription.Text = product.description;
            picboxProduct.BackgroundImage = product.image;
            if (product.image != null)
            {
                lblAddPhoto.Visible = false;
            }
            //picboxProduct.BackgroundImage = Properties.Resources.empty_product;
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
            if (txtCategory.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input Category!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategory.Focus();
                return;
            }
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            if (txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            if (txtOriginalPrice.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input Original Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }

            if (txtCondition.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input Condition!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCondition.Focus();
                return;
            }
            if (txtWarranty.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input Warranty Policy!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWarranty.Focus();
                return;
            }
            if (txtBrand.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input Brand!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrand.Focus();
                return;
            }
            if (txtOrigin.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input Origin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOrigin.Focus();
                return;
            }
            if (richTextBoxDescription.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input Desciption!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBoxDescription.Focus();
                return;
            }

            if (product == null)
            {
                Product x = new Product(Program.CurrentUser().userId, txtCategory.Text, txtName.Text, Convert.ToInt32(txtPrice.Text), picboxProduct.BackgroundImage,
                Convert.ToInt32(txtOriginalPrice.Text), txtCondition.Text, txtWarranty.Text, DateOnly.FromDateTime(dtpBought.Value), txtBrand.Text, txtOrigin.Text, richTextBoxDescription.Text);

                productDAO.Add(x);

            }
            else
            {
                Product x = new Product(Program.CurrentUser().userId, txtCategory.Text, txtName.Text, Convert.ToInt32(txtPrice.Text), picboxProduct.BackgroundImage,
                Convert.ToInt32(txtOriginalPrice.Text), txtCondition.Text, txtWarranty.Text, DateOnly.FromDateTime(dtpBought.Value), txtBrand.Text, txtOrigin.Text, richTextBoxDescription.Text);
                x.productId = product.productId;
                productDAO.Update(x);
            }
        }

        private void FormAddNewProduct_Load(object sender, EventArgs e)
        {

        }

        private void picboxProduct_Click(object sender, EventArgs e)
        {
            picboxProduct.BackgroundImage = MyImage.ChooseImage();
            picboxProduct.Refresh();
        }

        private void rBChangeImage_Click(object sender, EventArgs e)
        {
            picboxProduct.BackgroundImage = MyImage.ChooseImage();
            picboxProduct.Refresh();
        }

        private void lblAddPhoto_Click(object sender, EventArgs e)
        {
            picboxProduct.BackgroundImage = MyImage.ChooseImage();
            picboxProduct.Refresh();
        }

        private void btnDeliverAdress_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
