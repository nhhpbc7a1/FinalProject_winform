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
    public partial class FVoucher : Form
    {
        public Voucher chosenVoucher = null;
        public FVoucher()
        {
            InitializeComponent();
            pnlVoucherList.Controls.Clear();
            foreach (Voucher v in Program.listVoucher)
            {
                ucVoucher x = new ucVoucher(v);
                pnlVoucherList.Controls.Add(x);
                cbxVoucherSelect.Items.Add(v.voucherId);
            }
            cbxVoucherSelect.SelectedIndexChanged += CbxVoucherSelect_SelectedIndexChanged;
        }

        private void CbxVoucherSelect_SelectedIndexChanged(object? sender, EventArgs e)
        {
            chosenVoucher = Program.listVoucher[cbxVoucherSelect.SelectedIndex];
        }

        private void pnlVoucherList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
