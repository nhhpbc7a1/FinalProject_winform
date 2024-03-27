using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls.RJControls;

namespace QuanLyTraoDoiHang
{
    public partial class FormCart : Form
    {
        public FormCart()
        {
            InitializeComponent();

            Load += form_Load;
        }
        private void form_Load(object sender, EventArgs e)
        {
            DataTable table = CartItemDAO.SelectByUserId(Program.currentUserId);
            ucCartProducts.pnlProducts.Controls.Clear();
            foreach (DataRow row in table.Rows)
            {
                UCProductInCart ucProduct = new UCProductInCart();
                ucProduct.cartItem = CartItemDAO.RowToCartItem(row);
                ucProduct.btnCancel.Click += form_Load;

                ucCartProducts.pnlProducts.Controls.Add(ucProduct);
            }

        }

    }
}
