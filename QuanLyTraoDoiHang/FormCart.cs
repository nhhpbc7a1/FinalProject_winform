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
        public CartItem buyNowItem = null; 
        public FormCart()
        {
            InitializeComponent();

            btnCheckOut.Enabled = false;
            Load += form_Load;
            cbSellectAll.Click += CbSellectAll_CheckedChanged;
            btnCheckOut.Click += BtnCheckOut_Click;
        }

        private void BtnCheckOut_Click(object? sender, EventArgs e)
        {
            List<Product> listTmp = new List<Product>();
            foreach (UCCartEachShop c in pnlProducts.Controls)
            {
                foreach (UCProductInCart x in c.pnlProducts.Controls)
                    if (x.cbChoose.Checked == true)
                    {
                        listTmp.Add(ProductDAO.SelectById(x.cartItem.productId));
                    }
            }
            FCheckOut fCheckOut = new FCheckOut(listTmp);
            Program.mainpage.OpenChildForm(fCheckOut);
        }

        private void CbSellectAll_CheckedChanged(object? sender, EventArgs e)
        {
            foreach (UCCartEachShop c in pnlProducts.Controls)
            {
                c.cbShop.Checked = cbSellectAll.Checked;
                foreach (UCProductInCart control in c.pnlProducts.Controls)
                {
                    control.cbChoose.Checked = cbSellectAll.Checked;
                }
            }
        }
        private void update_CbSellectAll(object? sender, EventArgs e)
        {
            bool kt = true;
            foreach (UCCartEachShop c in pnlProducts.Controls)
                if (c.cbShop.Checked == false)
                {
                    kt = false;
                    break;
                }
            cbSellectAll.Checked = kt;
        }

        private void form_Load(object sender, EventArgs e)
        {
            DataTable table = CartItemDAO.SelectByUserId(Program.currentUserId);
            List<Product> listProduct = new List<Product>();
            foreach (DataRow row in table.Rows)
            {
                listProduct.Add(ProductDAO.SelectById(CartItemDAO.RowToCartItem(row).productId));
            }
            //MessageBox.Show(listProduct.Count.ToString());
            bool[] ch = new bool[100000];
            pnlProducts.Controls.Clear();
            for (int i = 0; i < listProduct.Count; i++)
            {
                Product product = listProduct[i];
                if (ch[product.sellerId] == false)
                {
                    ch[product.sellerId] = true;
                    UCCartEachShop x = new UCCartEachShop();
                    x.seller = UserDAO.SelectByUserId(product.sellerId);

                    pnlProducts.Controls.Add(x);
                    for (int j = i; j < listProduct.Count; j++)
                    {
                        if (listProduct[j].sellerId != product.sellerId) continue;
                        UCProductInCart y = new UCProductInCart();
                        y.cartItem = new CartItem(Program.currentUserId, listProduct[j].productId);
                        y.btnCancel.Click += form_Load;
                        y.cbChoose.CheckedChanged += Load_CheckOut_Calc;
                        y.cbChoose.Click += x.update_cbShop;
                        y.cbChoose.Click += update_CbSellectAll;

                        if (buyNowItem != null && y.cartItem.productId == buyNowItem.productId && y.cartItem.userId == buyNowItem.userId)
                        {
                            y.cbChoose.Checked = true;
                            buyNowItem = null;
                        }
                    
                        x.pnlProducts.Controls.Add(y);
                    }
                    x.cbShop.Click += update_CbSellectAll;

                }
            }
            cbSellectAll.Checked = false;
            Load_CheckOut_Calc(sender, e);
        }


        private void Load_CheckOut_Calc(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            foreach (UCCartEachShop c in pnlProducts.Controls)
            {
                foreach (UCProductInCart control in c.pnlProducts.Controls)
                {
                    if (control.cbChoose.Checked == true)
                    {
                        a++;
                        b += Convert.ToInt32(control.lblPrice.Text);
                    }
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
