using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace QuanLyTraoDoiHang
{
    public partial class FormInShop : Form
    {
        User user;
        DataTable products;
        DataTable ratings;
        public FormInShop(User user)
        {
            InitializeComponent();
            this.user = user;
            lblSellerName.Text = user.name;
            lblSellerPhone.Text = user.phone;
            lblSellerAddress.Text = user.address;
            lblDateJoined.Text = user.dateJoined.ToString();
            ptbSellerImage.BackgroundImage = user.image;
            products = ProductDAO.LoadCanBuy_SameSeller(user.userId);
            ratings = RatingDAO.SellectBySellerId(user.userId);
            btnViewProducts.Click += BtnViewProducts_Click;
            btnViewRating.Click += BtnViewRating_Click;
            BtnViewProducts_Click(null, null);

            ucStars1.userId = user.userId;
            ucStars1.canChanged = false;
            ucStars1.UCStars_Load(null, null);

        }

        private void BtnViewRating_Click(object? sender, EventArgs e)
        {
            pnlItems.Controls.Clear();
            foreach (DataRow row in ratings.Rows)
            {
                Rating x = RatingDAO.RowToRating(row);
                pnlItems.Controls.Add(new UCRatingInShop(x));
            }

        }

        private void BtnViewProducts_Click(object? sender, EventArgs e)
        {
            pnlItems.Controls.Clear();
            foreach (DataRow row in products.Rows)
            {
                Product x = ProductDAO.RowToProduct(row);
                pnlItems.Controls.Add(new UCProductOnMainpage(x));
            }
        }

     

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void btnHome_Click(object sender, EventArgs e)
        {
            Program.mainpage.OpenChildForm(new FormProduct());
            this.Close();

        }

      
        private void btnViewShop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}