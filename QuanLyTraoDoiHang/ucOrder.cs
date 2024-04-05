﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTraoDoiHang
{
    public partial class ucOrder : UserControl
    {
        public OrderTable order = new OrderTable();


        public ucOrder(OrderTable order)
        {
            InitializeComponent();
            this.order = order;
            this.Load += UcOrder_Load;
            cbxStatus.TextChanged += CbxStatus_TextChanged;

        }

        private void CbxStatus_TextChanged(object? sender, EventArgs e)
        {
            order.status = cbxStatus.Text;
        }

        private void UcOrder_Load(object? sender, EventArgs e)
        {
            ReceiveInfo receiveInfo = ReceiveInfoDAO.SelectByReceiveId(order.receiveId);
            lblName.Text = receiveInfo.name;
            lblPhone.Text = receiveInfo.phone;
            lblTotalPrice.Text = 0.ToString();
            lblItemsQuantity.Text = 0.ToString();
            lblMethod.Text = order.shippingMethod;
            cbxStatus.Text = order.status;
            lblTime.Text = order.time.ToString();
            DataTable productList = OrderItemDAO.SelectByOrderId(order.orderId);
            flwpnlOrder.Controls.Clear();

            foreach (DataRow row in productList.Rows)
            {
               UCProductStatusItem uc = new UCProductStatusItem(ProductDAO.SelectById(OrderItemDAO.RowToOrderItem(row).productId));
                flwpnlOrder.Controls.Add(uc);
            }
        }
    }
}

















