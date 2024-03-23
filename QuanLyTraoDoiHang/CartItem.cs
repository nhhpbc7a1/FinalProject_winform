using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTraoDoiHang
{
    public class CartItem
    {
        public int userId;
        public int productId;
        public CartItem() { }
        public CartItem(int userId, int productId){
            this.userId = userId;
            this.productId = productId;
        }
    }
}
