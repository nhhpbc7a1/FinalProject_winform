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

            ucStars1.comboBoxNum.SelectedIndex = rating.marks;
            ucStars1.comboBoxNum.Text = rating.marks.ToString();
            ucStars1.comboBoxNum.Enabled = false;
        }

    }
}
