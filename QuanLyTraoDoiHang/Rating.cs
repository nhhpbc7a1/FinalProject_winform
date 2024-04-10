using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTraoDoiHang
{
    public class Rating
    {
        public int ratingId;
        public int senderUserId;
        public int receiverUserId;
        public int orderId;
        public int productId;
        public int marks;
        public string detail;
        public Rating() { }
        public Rating(int senderUserId, int receiverUserId, int orderId, int productId, int marks, string detail)
        {
            this.ratingId = RatingDAO.CreateID();
            this.senderUserId = senderUserId;
            this.receiverUserId = receiverUserId;
            this.orderId = orderId;
            this.productId = productId;
            this.marks = marks;
            this.detail = detail;
        }
    }
}
