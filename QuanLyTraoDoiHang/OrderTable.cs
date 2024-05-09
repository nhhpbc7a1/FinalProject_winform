using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTraoDoiHang
{
    public class OrderTable
    {
        public int orderId;
        public int buyerId;
        public int sellerId;
        public int receiveId;
        public DateTime time;
        public string note;
        public string shippingMethod;
        public int shippingFee;
        public string paymentMethod;
        public string status;
        public int totalprice;
        public OrderTable() { }
        public OrderTable(int buyerId, int sellerId, int receiveId, DateTime time, string note, string shippingMethod, int shippingFee, string paymentMethod, string status)
        {
            this.orderId = OrderTableDAO.CreateID();
            this.buyerId = buyerId;
            this.sellerId = sellerId;
            this.receiveId = receiveId;
            this.time = time;
            this.note = note;
            this.shippingMethod = shippingMethod;
            this.shippingFee = shippingFee;
            this.paymentMethod = paymentMethod;
            this.status = status;
        }
        public OrderTable(int buyerId, int sellerId, int receiveId, DateTime time, string note, string shippingMethod, int shippingFee, string paymentMethod, string status, int totalprice)
        {
            this.orderId = OrderTableDAO.CreateID();
            this.buyerId = buyerId;
            this.sellerId = sellerId;
            this.receiveId = receiveId;
            this.time = time;
            this.note = note;
            this.shippingMethod = shippingMethod;
            this.shippingFee = shippingFee;
            this.paymentMethod = paymentMethod;
            this.status = status;
            this.totalprice = totalprice;
        }
    }
}
