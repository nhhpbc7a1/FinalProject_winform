using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTraoDoiHang
{
    class OrderTable
    {
        int orderId;
        int userId;
        int receiveId;
        DateTime time;
        string note;
        string shippingMethod;
        string shippingFee;
        string paymentMethod;
        string status;
        public OrderTable(int orderId, int userId, int receiveId, DateTime time, string note, string shippingMethod, string shippingFee, string paymentMethod, string status)
        {
            this.orderId = orderId;
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
