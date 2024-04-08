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
    public partial class UCRatingInShop : UserControl
    {
        Rating Rating;
        public UCRatingInShop(Rating rating)
        {
            InitializeComponent();
            this.Rating = rating;
            User x = UserDAO.SelectByUserId(Rating.senderUserId);
            lblBuyerName.Text = x.name;
            picboxBuyerImage.BackgroundImage = x.image;
            lblDateBought.Text = OrderTableDAO.SelectById(rating.orderId).time.ToString();
            lblProductName.Text = ProductDAO.SelectById(rating.productId).name;
            lblRatingText.Text = rating.detail;

            pnlRating.Controls.Clear();
            for (int i = 1; i <= rating.marks; i++)
                pnlRating.Controls.Add(star1);

        }

    }
}
