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
    public partial class UCCheckOutEachShop : UserControl
    {
        public User shopInfo = new User();
        public UCCheckOutEachShop(User shopInfo)
        {
            InitializeComponent();
            Load += UCCheckOutEachShop_Load;
            comboBoxShippingMethod.SelectedIndexChanged += ComboBoxShippingMethod_SelectedIndexChanged;
            this.shopInfo = shopInfo;
        }

        private void ComboBoxShippingMethod_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lblShippingFee.Text = ((comboBoxShippingMethod.SelectedIndex + 1) * 20000).ToString();
        }

        private void UCCheckOutEachShop_Load(object? sender, EventArgs e)
        {
            comboBoxShippingMethod.SelectedIndex = 0;
        }

        private void ucCartEachShop1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
