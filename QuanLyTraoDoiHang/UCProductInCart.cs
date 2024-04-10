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
    public partial class UCProductInCart : UserControl
    {
        public UCProductInCart()
        {
            InitializeComponent();

            Load += form_Load;
            btnCancel.Click += btnCancel_Click;
        }
        public CartItem cartItem = new CartItem();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CartItemDAO.Delete(cartItem);
            MessageBox.Show("cancel successfully");
        }
        private void form_Load(object sender, EventArgs e)
        {
            Product product = ProductDAO.SelectById(cartItem.productId);
            pbProductImage.BackgroundImage = product.image;
            lblProductName.Text = product.name;
            lblPrice.Text = product.price.ToString();
            lblCondition.Text = product.condition.ToString();
            lblOldPrice.Text = product.originalPrice.ToString();
        }

        private void UCProductInCart_Load(object sender, EventArgs e)
        {

        }
    }
}
