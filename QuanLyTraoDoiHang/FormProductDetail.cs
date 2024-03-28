using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTraoDoiHang
{
    public partial class FormProductDetail : Form
    {
        public FormProductDetail()
        {
            InitializeComponent();
            pnlThisSellerPage.Visible = false;
            btnBack.Click += btnBack_Click;
            btnViewPage.Click += btnViewPage_Click;
            pnlProductDetail.Dock = DockStyle.Fill;
        }
        public static Product currentProduct = new Product();

        private void FormProductDetail_Load(object sender, EventArgs e)
        {
            ptbImage.BackgroundImage = currentProduct.image;
            lblName.Text = currentProduct.name;
            lblPrice.Text = currentProduct.price.ToString();
            lblOriginalPrice.Text = currentProduct.originalPrice.ToString();
            lblWarrantyPolicy.Text = currentProduct.warrantyPolicy.ToString();
            lblBrand.Text = currentProduct.brand.ToString();
            lblCondition.Text = currentProduct.condition.ToString();
            lblBought.Text = currentProduct.dateBought.ToString();
            richTextBoxDescription.Text = currentProduct.description;
            //seller info
            User seller = UserDAO.SelectByUserId(currentProduct.sellerId);
            lblSellerName.Text = seller.name;
            ptbSellerImage.BackgroundImage = seller.image;
            lblSellerAddress.Text = seller.address;
            lblDateJoined.Text = seller.dateJoined.ToString();

            DataTable table = ProductDAO.SelectBySellerId(currentProduct.sellerId);
            foreach (DataRow row in table.Rows)
            {
                UCProductOnMainpage ucProduct = new UCProductOnMainpage(ProductDAO.RowToProduct(row))
                { Margin = new System.Windows.Forms.Padding(5, 5, 5, 5) };
                pnlSellerProduct.Controls.Add(ucProduct);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlSellerInfo.Dock = DockStyle.None;
            pnlProductDetail.Dock = DockStyle.None;
            pnlThisSellerPage.Size = new System.Drawing.Size(777, 653);
            pnlThisSellerPage.Visible = true;
            pnlThisSellerPage.BringToFront();
            pnlThisSellerPage.Dock = DockStyle.Left;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlThisSellerPage.Visible = false;
            pnlProductDetail.Visible = true;
            pnlThisSellerPage.Dock = DockStyle.None;
            pnlProductDetail.Dock = DockStyle.Fill;
        }

        private void btnViewPage_Click(object sender, EventArgs e)
        {
            pnlThisSellerPage.Visible = true;
            pnlProductDetail.Visible = false;
            pnlProductDetail.Dock = DockStyle.None;
            pnlThisSellerPage.Dock = DockStyle.Fill;

            //pnlThisSellerPage.Size = new System.Drawing.Size(648, 653);
            pnlThisSellerPage.BringToFront();


        }

        private void ptbImage_Click(object sender, EventArgs e)
        {

        }
    }
}
