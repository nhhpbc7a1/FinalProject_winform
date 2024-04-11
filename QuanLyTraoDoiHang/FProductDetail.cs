using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTraoDoiHang
{
    public partial class FProductDetail : Form
    {
        public FProductDetail()
        {
            InitializeComponent();
            btnViewPage.Click += btnViewPage_Click;
            Load += FProductDetail_Load;
            btnDeliverAdress.Click += btnDeliverAdress_Click;
            btnAddToCart.Click += BtnAddToCart_Click;
            btnBuyNow.Click += BtnBuyNow_Click;
        }

        private void BtnBuyNow_Click(object? sender, EventArgs e)
        {
            CartItem x = new CartItem(Program.currentUserId, currentProduct.productId);
            CartItemDAO.Add(x);
        }

        private void BtnAddToCart_Click(object? sender, EventArgs e)
        {
            CartItem x = new CartItem(Program.currentUserId, currentProduct.productId);
            CartItemDAO.Add(x);
        }

        public Product currentProduct = new Product();
        private void FProductDetail_Load(object sender, EventArgs e)
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

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void btnViewPage_Click(object sender, EventArgs e)
        {
            Program.mainpage.OpenChildForm(new FormInShop(UserDAO.SelectByUserId(currentProduct.sellerId)));
        }

        private void btnDeliverAdress_Click(object sender, EventArgs e)
        {
            Program.mainpage.OpenChildForm(new FormProduct());
        }

    }
}
