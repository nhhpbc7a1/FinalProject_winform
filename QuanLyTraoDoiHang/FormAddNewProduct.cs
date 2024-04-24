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
using System.Xaml;

namespace QuanLyTraoDoiHang
{
    public partial class FormAddNewProduct : Form
    {

        void AddEvents()
        {

            picboxProduct.Click += ChangeProductImage_Click;
            lblAddPhoto.Click += ChangeProductImage_Click;
            btnSave.Click += btnSave_Click;
            btnDeliverAdress.Click += btnDeliverAdress_Click;

            picDetailImage1.Click += PicDetailImage1_Click;
            picDetailImage2.Click += PicDetailImage2_Click;
            picDetailImage3.Click += PicDetailImage3_Click;
        }

        private void PicDetailImage3_Click(object? sender, EventArgs e)
        {
            picDetailImage3.BackgroundImage = MyImage.ChooseImage();
            listImage[2] = picDetailImage3.BackgroundImage;
            picDetailImage3.Refresh();
        }

        private void PicDetailImage2_Click(object? sender, EventArgs e)
        {
            picDetailImage2.BackgroundImage = MyImage.ChooseImage();
            listImage[1] = picDetailImage2.BackgroundImage;
            picDetailImage2.Refresh();
        }

        private void PicDetailImage1_Click(object? sender, EventArgs e)
        {
            picDetailImage1.BackgroundImage = MyImage.ChooseImage();
            listImage[0] = picDetailImage1.BackgroundImage;
            picDetailImage1.Refresh();
        }

        public FormAddNewProduct()
        {

            InitializeComponent();
            txtCondition.Focus();

            AddEvents();
            //picboxProduct.BackgroundImage = Properties.Resources.empty_product;
        }

        Product product = null;
        List<Image> listImage = new List<Image>();
        public FormAddNewProduct(Product product)
        {
            InitializeComponent();
            AddEvents();
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

            listImage = DetailImageDAO.TakeListByProductId(product.productId);
            picDetailImage1.BackgroundImage = listImage[0];
            picDetailImage2.BackgroundImage = listImage[1];
            picDetailImage3.BackgroundImage = listImage[2];


            //picboxProduct.BackgroundImage = Properties.Resources.empty_product;
        }


        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        ProductDAO productDAO = new ProductDAO();
        DBConnection dBConnection = new DBConnection();



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
            if (picboxProduct.BackgroundImage == null)
            {
                MessageBox.Show("You haven't input Main Image!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (product == null)
            {
                Product x = new Product(Program.CurrentUser().userId, txtCategory.Text, txtName.Text, Convert.ToInt32(txtPrice.Text), picboxProduct.BackgroundImage,
                Convert.ToInt32(txtOriginalPrice.Text), txtCondition.Text, txtWarranty.Text, DateOnly.FromDateTime(dtpBought.Value), txtBrand.Text, txtOrigin.Text, richTextBoxDescription.Text);

                productDAO.Add(x);
                foreach (Image img in listImage)
                    DetailImageDAO.Add(x.productId, img);
            }
            else
            {
                Product x = new Product(Program.CurrentUser().userId, txtCategory.Text, txtName.Text, Convert.ToInt32(txtPrice.Text), picboxProduct.BackgroundImage,
                Convert.ToInt32(txtOriginalPrice.Text), txtCondition.Text, txtWarranty.Text, DateOnly.FromDateTime(dtpBought.Value), txtBrand.Text, txtOrigin.Text, richTextBoxDescription.Text);
                x.productId = product.productId;
                productDAO.Update(x);

                DetailImageDAO.DeleteByProductId(x.productId);
                foreach (Image img in listImage)
                    DetailImageDAO.Add(x.productId, img);

            }
        }
        private void ChangeProductImage_Click(object sender, EventArgs e)
        {
            picboxProduct.BackgroundImage = MyImage.ChooseImage();
            picboxProduct.Refresh();
            if (picboxProduct.BackgroundImage != null)
            {
                lblAddPhoto.Visible = false;
            }
        }

        private void btnDeliverAdress_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
