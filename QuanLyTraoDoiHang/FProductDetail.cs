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
        Product product = new Product();
        public FProductDetail(Product product)
        {
            InitializeComponent();
            btnViewPage.Click += btnViewPage_Click;
            Load += FProductDetail_Load;
            btnDeliverAdress.Click += btnDeliverAdress_Click;
            btnAddToCart.Click += BtnAddToCart_Click;
            btnBuyNow.Click += BtnBuyNow_Click;
            this.product = product;


            ptbImage.BackgroundImage = product.image;
            lblName.Text = product.name;
            lblPrice.Text = product.price.ToString();
            lblOriginalPrice.Text = product.originalPrice.ToString();
            lblWarrantyPolicy.Text = product.warrantyPolicy.ToString();
            lblBrand.Text = product.brand.ToString();
            lblCondition.Text = product.condition.ToString();
            lblBought.Text = product.dateBought.ToString();
            richTextBoxDescription.Text = product.description;
            //seller info
            User seller = UserDAO.SelectByUserId(product.sellerId);
            lblSellerName.Text = seller.name;
            ptbSellerImage.BackgroundImage = seller.image;
            lblSellerAddress.Text = seller.address;
            lblDateJoined.Text = seller.dateJoined.ToString();

            pnlDetailImages.Controls.Clear();
            List<Image> list = DetailImageDAO.TakeListByProductId(product.productId);
            list.Add(product.image);
            int i = 0;
            foreach (Image img in list)
            {
                UCDetailImage x = new UCDetailImage(img);

                x.MouseHover += ChangeBeingShowedImage;
                x.Margin = new Padding(8, 8, 0, 0);

                void ChangeBeingShowedImage(object? sender, EventArgs e)
                {
                    ptbImage.BackgroundImage = img;
                }

                pnlDetailImages.Controls.Add(x);
            }
        }


        private void BtnBuyNow_Click(object? sender, EventArgs e)
        {
            CartItem x = new CartItem(Program.currentUserId, product.productId);
            CartItemDAO.Add(x);
        }

        private void BtnAddToCart_Click(object? sender, EventArgs e)
        {
            CartItem x = new CartItem(Program.currentUserId, product.productId);
            CartItemDAO.Add(x);
        }

        private void FProductDetail_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void btnViewPage_Click(object sender, EventArgs e)
        {
            Program.mainpage.OpenChildForm(new FormInShop(UserDAO.SelectByUserId(product.sellerId)));
        }

        private void btnDeliverAdress_Click(object sender, EventArgs e)
        {
            Program.mainpage.OpenChildForm(new FormProduct());
        }

    }
}
