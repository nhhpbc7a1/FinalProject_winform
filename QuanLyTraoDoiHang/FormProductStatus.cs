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
    public partial class FormProductStatus : Form
    {
        public FormProductStatus(List<string> statusList, bool beUpdated)
        {
            InitializeComponent();
            btnUpdate.Visible = beUpdated;

            DataTable x = OrderTableDAO.SellectBySellerId(Program.currentUserId);
            pnlItems.Controls.Clear();
            foreach (DataRow row in x.Rows)
            {

                OrderTable order = OrderTableDAO.RowToOrderTable(row);
                foreach (string status in statusList)
                    if (order.status == status)
                    {
                        ucOrder item = new ucOrder(order);
                        if (beUpdated == true)
                        {
                            item.cbxStatus.Visible = true;
                            item.lblStatus.Visible = true;
                        }

                        pnlItems.Controls.Add(item);
                    }
            }
            if (pnlItems.Controls.Count == 0)
            {
               pnlItems.Controls.Add(picEmpty);

            }
            btnUpdate.Click += BtnUpdate_Click;
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            foreach (ucOrder ucorder in pnlItems.Controls)
            {
                OrderTableDAO.Update(ucorder.order);
            }
            Program.mainpage.OpenChildForm(new FSellermanagement());
        }
    }
}
