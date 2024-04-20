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
            //seller info
            User seller = UserDAO.SelectByUserId(product.sellerId);
            lblSellerName.Text = seller.name;
            ptbSellerImage.BackgroundImage = seller.image;
            lblSellerAddress.Text = seller.address;
            lblDateJoined.Text = seller.dateJoined.ToString();
            lblSellerPhone.Text = seller.phone;
            ucStarsSeller.userId = seller.userId;
            ucStarsSeller.canChanged = false;
            ucStarsSeller.UCStars_Load(null, null);

            pnlDetailImages.Controls.Clear();
            List<Image> list = DetailImageDAO.TakeListByProductId(product.productId);
            list.Add(product.image);
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

            DataTable dataTable = ProductDAO.LoadCanBuy_SameSeller(product.sellerId);
            fpnlShowProductOfThisSeller.Controls.Clear();
            for (int i = 0; i < Math.Min(dataTable.Rows.Count, 4); i++)
            {
                Product tmp = ProductDAO.RowToProduct(dataTable.Rows[i]);
                fpnlShowProductOfThisSeller.Controls.Add(new UCProductOnMainpage(tmp));
            }

            dataTable = ProductDAO.LoadCanBuy_SameCategory(product.category);
            fpnlShowSimilarProduct.Controls.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Product tmp = ProductDAO.RowToProduct(dataTable.Rows[i]);
                fpnlShowSimilarProduct.Controls.Add(new UCProductOnMainpage(tmp));
            }

        }


        private void BtnBuyNow_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to buy now this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CartItem x = new CartItem(Program.currentUserId, product.productId);
                if (CartItemDAO.Add_NoMessage(x))
                {
                    FormCart formTmp = new FormCart();
                    formTmp.buyNowItem = x;
                    Program.mainpage.OpenChildForm(formTmp);
                }

            }
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
