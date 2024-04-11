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
    public partial class UCOrder_buyerSight : UserControl
    {
        public OrderTable order = new OrderTable();


        public UCOrder_buyerSight(OrderTable order)
        {
            InitializeComponent();
            this.order = order;
            this.Load += UcOrder_Load;
            cbxStatus.TextChanged += CbxStatus_TextChanged;
            btnViewShop.Click += BtnViewShop_Click1;
        }

        private void BtnViewShop_Click1(object? sender, EventArgs e)
        {
            Form x = new FormInShop(UserDAO.SelectByUserId(order.sellerId));
            x.ShowDialog();
        }

        private void BtnViewShop_Click(object? sender, EventArgs e)
        {
            Program.mainpage.OpenChildForm(new FormInShop(UserDAO.SelectByUserId(order.sellerId)));
        }

        private void CbxStatus_TextChanged(object? sender, EventArgs e)
        {
            order.status = cbxStatus.Text;
        }

        private void UcOrder_Load(object? sender, EventArgs e)
        {
            lblSellerName.Text = UserDAO.SelectByUserId(order.sellerId).name;
            lblTotalPrice.Text = 0.ToString();
            lblTime.Text = order.time.ToString();
            lblMethod.Text = order.shippingMethod;
            cbxStatus.Text = order.status;
            cbxStatus.Enabled = false;
            DataTable productList = OrderItemDAO.SelectByOrderId(order.orderId);
            flwpnlOrder.Controls.Clear();
            int total = 0;

            foreach (DataRow row in productList.Rows)
            {
                Product tmp = ProductDAO.SelectById(OrderItemDAO.RowToOrderItem(row).productId);
                UCViewHistoryItem uc = new UCViewHistoryItem(tmp, order.status, order);
                flwpnlOrder.Controls.Add(uc);
                total += tmp.price;
            }
            lblShippingFee.Text = order.shippingFee.ToString();
            lblTotalPrice.Text = (total + order.shippingFee).ToString();
        }

    }
}
