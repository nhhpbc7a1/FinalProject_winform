using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTraoDoiHang
{
    public class Voucher
    {
        public string name;
        public string voucherId;
        public DateTime activeTime;
        public double proportion;
        public double maxDiscountablePrice;
        public Voucher(string name, string voucherId,DateTime activeTime, double proportion, double maxDiscountablePrice)
        { 
            this.name = name;
            this.voucherId = voucherId;
            this.activeTime = activeTime;
            this.proportion = proportion;
            this.maxDiscountablePrice = maxDiscountablePrice;
        }
    }
}
