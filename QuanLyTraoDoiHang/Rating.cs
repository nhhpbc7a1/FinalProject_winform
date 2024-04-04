using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTraoDoiHang
{
    class Rating
    {
        int senderUserId;
        int receiveUserId;
        int orderId;
        int marks;
        string detail;
        public Rating(int senderUserId, int receiveUserId, int orderId, int marks, string detail)
        {
            this.senderUserId = senderUserId;
            this.receiveUserId = receiveUserId;
            this.orderId = orderId;
            this.marks = marks;
            this.detail = detail;
        }
    }
}
