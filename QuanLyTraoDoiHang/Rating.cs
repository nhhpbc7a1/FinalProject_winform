using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTraoDoiHang
{
    class Rating
    {
        public int ratingId;
        public int senderUserId;
        public int receiverUserId;
        public int orderId;
        public int marks;
        public string detail;
        public Rating() { }
        public Rating(int senderUserId, int receiverUserId, int orderId, int marks, string detail)
        {
            this.ratingId = RatingDAO.CreateID();
            this.senderUserId = senderUserId;
            this.receiverUserId = receiverUserId;
            this.orderId = orderId;
            this.marks = marks;
            this.detail = detail;
        }
    }
}
