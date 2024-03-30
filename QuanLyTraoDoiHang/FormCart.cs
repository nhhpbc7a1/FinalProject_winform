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

            btnCheckOut.Enabled = false;
            Load += form_Load;
            cbSellectAll.CheckedChanged += CbSellectAll_CheckedChanged;
            btnCheckOut.Click += BtnCheckOut_Click;
        }

        private void BtnCheckOut_Click(object? sender, EventArgs e)
        {

        }

        private void CbSellectAll_CheckedChanged(object? sender, EventArgs e)
        {
            foreach (UCProductInCart c in pnlProducts.Controls)
                c.cbChoose.Checked = cbSellectAll.Checked;
        }

        private void form_Load(object sender, EventArgs e)
        {
            DataTable table = CartItemDAO.SelectByUserId(Program.currentUserId);
            pnlProducts.Controls.Clear();
            foreach (DataRow row in table.Rows)
            {
                UCProductInCart ucProduct = new UCProductInCart();
                ucProduct.cartItem = CartItemDAO.RowToCartItem(row);
                ucProduct.btnCancel.Click += form_Load;
                ucProduct.cbChoose.CheckedChanged += Load_CheckOut_Calc;

                pnlProducts.Controls.Add(ucProduct);
            }
        }
        private void Load_CheckOut_Calc(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            foreach (UCProductInCart c in pnlProducts.Controls)
            {
                if (c.cbChoose.Checked == true)
                {
                    a++;
                    b += Convert.ToInt32(c.lblPrice.Text);
                }
            }
            lblTotalItem.Text = a.ToString();
            lblTotalPrice.Text = b.ToString();

            if (a > 0)
                btnCheckOut.Enabled = true;
            else btnCheckOut.Enabled = false;

        }

    }
}
