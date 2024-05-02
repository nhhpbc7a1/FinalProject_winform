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
    public partial class UCSeller_Show : UserControl
    {
 
        User user;
        DataTable products;
        DataTable ratings;
        public UCSeller_Show(User user)
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

            txtNumShippingOrder.Text = OrderTableDAO.CountOrder_BySellerIdAndStatus(user.userId, "shipping").ToString();
            txtNumCompletedOrder.Text = OrderTableDAO.CountOrder_BySellerIdAndStatus(user.userId, "completed").ToString();
            txtNumCancelledOrder.Text = OrderTableDAO.CountOrder_BySellerIdAndStatus(user.userId, "cancelled").ToString();

            ucStars1.userId = user.userId;
            ucStars1.canChanged = false;
            ucStars1.UCStars_Load(null, null);
            btnViewShop.Click += BtnViewShop_Click;
        }

        private void BtnViewShop_Click(object? sender, EventArgs e)
        {
            Program.mainpage.OpenChildForm(new FormInShop(user));   
        }
    }
}
