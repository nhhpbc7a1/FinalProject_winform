using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Effects;

namespace QuanLyTraoDoiHang
{
    public partial class UCCartEachShop : UserControl
    {
        public UCCartEachShop()
        {
            InitializeComponent();
            Load += UCCartEachShop_Load;
            cbShop.Click += CbShop_CheckedChanged;
        }

        private void CbShop_CheckedChanged(object? sender, EventArgs e)
        {
            foreach (UCProductInCart c in pnlProducts.Controls)
                c.cbChoose.Checked = cbShop.Checked;
        }

        public void update_cbShop(object sender, EventArgs e)
        {
            bool kt = true;
            foreach (UCProductInCart c in pnlProducts.Controls)
                if (c.cbChoose.Checked == false)
                {
                    kt = false;
                    break;
                }
            cbShop.Checked = kt;
        }
        public User seller = new User();

        private void UCCartEachShop_Load(object? sender, EventArgs e)
        {
            lblUsername.Text = seller.name;
            lblPhone.Text = seller.phone;
        }

    }
}
