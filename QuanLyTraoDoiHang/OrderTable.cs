﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTraoDoiHang
{
    class OrderTable
    {
        public int orderId;
        public int userId;
        public int receiveId;
        public DateTime time;
        public string note;
        public string shippingMethod;
        public string shippingFee;
        public string paymentMethod;
        public string status;
        public OrderTable() { }
        public OrderTable(int userId, int receiveId, DateTime time, string note, string shippingMethod, string shippingFee, string paymentMethod, string status)
        {
            this.orderId = OrderTableDAO.CreateID();
            this.userId = userId;
            this.receiveId = receiveId;
            this.time = time;
            this.note = note;
            this.shippingMethod = shippingMethod;
            this.shippingFee = shippingFee;
            this.paymentMethod = paymentMethod;
            this.status = status;
        }
    }
}
