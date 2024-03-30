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
    public partial class FCheckOut : Form
    {
        public FCheckOut()
        {
            InitializeComponent();

            Load += FCheckOut_Load;
        }

        private void FCheckOut_Load(object? sender, EventArgs e)
        {
            pnlProducts.Controls.Clear();
            foreach (CartItem x in cartItems)
            {
                UCProductInCart ucProduct = new UCProductInCart();
                ucProduct.cartItem = x;
                ucProduct.btnCancel.Enabled = false;
                ucProduct.cbChoose.Checked = true;
                ucProduct.cbChoose.Enabled = false;

                pnlProducts.Controls.Add(ucProduct);
            }
        }

        public List<CartItem> cartItems = new List<CartItem>();
    }
}
