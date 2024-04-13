using QuanLyTraoDoiHang.RJControls;
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
    public partial class UCProductOnMainpage : UserControl
    {
        public Product product = new Product();
        public UCProductOnMainpage(Product product)
        {
            InitializeComponent();
            this.product = product;

            foreach (Control c in this.Controls)
            {
                if (c.Name != "btnBuyNow" || !(c is RButton))
                    c.Click += OpenFormDetail;
                else
                {
                    c.Click += BuyNow;
                }
            }
            this.Click += OpenFormDetail;
            ptbImage.BackgroundImage = product.image;
            lblName.Text = product.name;
            lblPrice.Text = product.price.ToString();
            lblOriginalPrice.Text = product.originalPrice.ToString();
            lblDateStart.Text = product.dateBought.ToString();

            DataTable ratings = RatingDAO.SellectBySellerId(product.sellerId);
            if (ratings.Rows.Count == 0)
            {
                ucStars1.Visible = false;
            }
            else
            {
                double avgRating = 0;
                foreach (DataRow row in ratings.Rows)
                {
                    Rating x = RatingDAO.RowToRating(row);
                    avgRating += x.marks;
                }
                double tmp = ratings.Rows.Count;
                ucStars1.lblNumStar.Text = (avgRating / tmp).ToString();
                ucStars1.lblNumStar.Visible = true;
                ucStars1.comboBoxNum.Text = (avgRating / tmp).ToString();
                ucStars1.comboBoxNum.Visible = false;
                ucStars1.comboBoxNum.Enabled = false;
            }

        }

        void BuyNow(object sender, EventArgs e)
        {
            CartItem x = new CartItem(Program.currentUserId, product.productId);
            CartItemDAO.Add(x);
        }

        private void UCProductOnMainpage_Load(object sender, EventArgs e)
        {
        }
        private void OpenFormDetail(object sender, EventArgs e)
        {
            FProductDetail formDetail = new FProductDetail(product);

            Program.mainpage.OpenChildForm(formDetail);
        }
    }
}