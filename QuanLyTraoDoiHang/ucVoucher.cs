using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTraoDoiHang
{
    public partial class ucVoucher : UserControl
    {
        Voucher CurrentVoucher;
        public ucVoucher(Voucher currentVoucher)
        {
            InitializeComponent();
            CurrentVoucher = currentVoucher;
            lblName.Text = currentVoucher.name.ToString();
            lblVoucherId.Text = currentVoucher.voucherId.ToString();
            lblPercentage.Text = currentVoucher.proportion.ToString();
            lblMaxDiscountableValue.Text = currentVoucher.maxDiscountablePrice.ToString();
            lblTime.Text = currentVoucher.activeTime.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
