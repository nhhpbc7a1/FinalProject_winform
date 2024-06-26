﻿using System;
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
        public static ReceiveInfo currentReceiveInfo = null;
        int totalPrice = 0;

        public FCheckOut(List<Product> listProducts)
        {
            InitializeComponent();

            Load += FCheckOut_Load;
            this.listProducts = listProducts;
            btnChangeReceiveInfo.Click += BtnChangeReceiveInfo_Click;
            DataTable x = ReceiveInfoDAO.SelectByUserId(Program.currentUserId);
            if (x.Rows.Count > 0)
                currentReceiveInfo = ReceiveInfoDAO.RowToReceiveInfo(x.Rows[0]);

            btnCheckOut.Click += BtnCheckOut_Click;
        }

        private void BtnCheckOut_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to checkout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (UCCheckOutEachShop ucShop in pnlProducts.Controls)
                {
                    OrderTable x = new OrderTable(Program.currentUserId, ucShop.shopInfo.userId, currentReceiveInfo.receiveId, DateTime.Now, ucShop.txtNote.Text, ucShop.comboBoxShippingMethod.Text, Convert.ToInt32(ucShop.lblShippingFee.Text), "", "waiting",totalPrice);
                    OrderTableDAO.Add(x);
                    foreach (ucItemsInCheckOut ucProduct in ucShop.ucCartEachShop1.pnlProducts.Controls)
                    {
                        OrderItemDAO.Add(new OrderItem(x.orderId, ucProduct.product.productId));
                    }
                }
                CartItemDAO.DeleteProductBeOrdered();
                FPurchaseDone fPurchaseDone = new FPurchaseDone(totalPrice);
                fPurchaseDone.ShowDialog();
            }

        }

        private void BtnChangeReceiveInfo_Click(object? sender, EventArgs e)
        {
            FormReceiveAddress x = new FormReceiveAddress();
            x.btnConfirm.Click += FCheckOut_Load;
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
                    UCCheckOutEachShop x = new UCCheckOutEachShop(UserDAO.SelectByUserId(product.sellerId));
                    x.ucCartEachShop1.seller = UserDAO.SelectByUserId(product.sellerId);
                    x.ucCartEachShop1.cbShop.Visible = false;
                    int cnt = 0;
                    int totalPriceThisShop = 0;

                    for (int j = i; j < listProducts.Count; j++)
                    {
                        if (listProducts[j].sellerId != product.sellerId) continue;
                        ucItemsInCheckOut y = new ucItemsInCheckOut(listProducts[j]);
                        x.ucCartEachShop1.pnlProducts.Controls.Add(y);
                        totalPriceThisShop += product.price;
                        cnt++;
                    }
                    x.comboBoxShippingMethod.SelectedIndexChanged += ComboBoxShippingMethod_SelectedIndexChanged;
                    totalPriceThisShop += Convert.ToInt32(x.lblShippingFee.Text);
                    x.lblItemNo.Text = cnt.ToString();
                    x.lblTotalPriceThisShop.Text = totalPriceThisShop.ToString();
                    pnlProducts.Controls.Add(x);
                }
            }
            if (currentReceiveInfo != null)
            {
                lblPhoneDelivery.Text = currentReceiveInfo.phone;
                lblNameDelivery.Text = currentReceiveInfo.name;
                lblAddressDelivery.Text = currentReceiveInfo.address;
            }
        }

        private void ComboBoxShippingMethod_SelectedIndexChanged(object? sender, EventArgs e)
        {
            int totalShip = 0, totalProductPrice = 0;
            foreach (UCCheckOutEachShop x in pnlProducts.Controls)
            {
                totalShip += Convert.ToInt32(x.lblShippingFee.Text);
                int totalPriceThisShop = 0;
                foreach (ucItemsInCheckOut y in x.ucCartEachShop1.pnlProducts.Controls)
                {
                    totalProductPrice += Convert.ToInt32(y.lblPrice.Text);
                    totalPriceThisShop += y.product.price;
                }
                totalPriceThisShop += Convert.ToInt32(x.lblShippingFee.Text);
                x.lblTotalPriceThisShop.Text = totalPriceThisShop.ToString();
            }
            lblTotalProductPrice.Text = totalProductPrice.ToString();
            lblTotalShippingFee.Text = totalShip.ToString();
            lblTotalPrice.Text = (totalShip + totalProductPrice).ToString();
            totalPrice = totalShip + totalProductPrice;
        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
