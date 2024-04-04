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
        public List<Product> listProducts = new List<Product>();

        public FCheckOut(List<Product> listProducts)
        {
            InitializeComponent();

            Load += FCheckOut_Load;
            this.listProducts = listProducts;
            btnChangeReceiveInfo.Click += BtnChangeReceiveInfo_Click;
            this.AcceptButton = rBCheckout;
        }

        private void BtnChangeReceiveInfo_Click(object? sender, EventArgs e)
        {
            FormReceiveAddress x = new FormReceiveAddress();
            x.ShowDialog();
        }

        private void FCheckOut_Load(object? sender, EventArgs e)
        {
            pnlProducts.Controls.Clear();
            bool[] ch = new bool[100000];
            for (int i = 0; i < listProducts.Count; i++)
            {
                Product product = listProducts[i];
                if (ch[product.sellerId] == false)
                {
                    ch[product.sellerId] = true;
                    UCCheckOutEachShop x = new UCCheckOutEachShop();
                    x.ucCartEachShop1.seller = UserDAO.SelectByUserId(product.sellerId);
                    x.ucCartEachShop1.cbShop.Visible = false;

                    for (int j = i; j < listProducts.Count; j++)
                    {
                        if (listProducts[j].sellerId != product.sellerId) continue;
                        UCProductInCheckOut y = new UCProductInCheckOut(listProducts[j]);
                        x.ucCartEachShop1.pnlProducts.Controls.Add(y);
                    }
                    x.comboBoxShippingMethod.SelectedIndexChanged += ComboBoxShippingMethod_SelectedIndexChanged;
                    pnlProducts.Controls.Add(x);

                }
            }

        }

        private void ComboBoxShippingMethod_SelectedIndexChanged(object? sender, EventArgs e)
        {
            int totalShip = 0, totalProductPrice = 0;
            foreach (UCCheckOutEachShop x in pnlProducts.Controls)
            {
                totalShip += Convert.ToInt32(x.lblShippingFee.Text);
                foreach (UCProductInCheckOut y in x.ucCartEachShop1.pnlProducts.Controls)
                {
                    totalProductPrice += Convert.ToInt32(y.lblPrice.Text);
                }
            }
            lblTotalProductPrice.Text = totalProductPrice.ToString();
            lblTotalShippingFee.Text = totalShip.ToString();
            lblTotalPrice.Text = (totalShip + totalProductPrice).ToString();
        }

        private void rBCheckout_Click(object sender, EventArgs e)
        {

        }
    }
}
