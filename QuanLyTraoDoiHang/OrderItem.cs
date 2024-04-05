using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTraoDoiHang
{
    class OrderItem
    {
        public int orderId;
        public int productId;
        public OrderItem() { }
        public OrderItem(int orderId, int productId)
        {
            this.orderId = orderId;
            this.productId = productId;
        }
    }
}
