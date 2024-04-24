using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace QuanLyTraoDoiHang
{
    public partial class ViewHistory : Form
    {
        DataTable x;
        public ViewHistory()
        {
            InitializeComponent();
            btnShip.Click += btnShip_Click;
            btnCompleted.Click += BtnCompleted_Click;
            btnCancel.Click += BtnCancel_Click;
            btnReturn.Click += BtnReturn_Click;
            x = OrderTableDAO.SellectByBuyerId(Program.currentUserId);
            btnShip_Click(null, null);
        }

        private void BtnReturn_Click(object? sender, EventArgs e)
        {
            ResetBtnStatusBorder();

            pnlReturned.BackColor = Color.FromArgb(30, 106, 17);


            foreach (DataRow row in x.Rows)
            {
                OrderTable tmp = OrderTableDAO.RowToOrderTable(row);
                if (tmp.status == "returned")
                {
                    UCOrder_buyerSight item = new UCOrder_buyerSight(tmp);
                    pnlItems.Controls.Add(item);
                }
            }
            if (pnlItems.Controls.Count == 0) pnlItems.Controls.Add(pictureBox1);
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            ResetBtnStatusBorder();

            pnlCancelled.BackColor = Color.FromArgb(30, 106, 17);


            foreach (DataRow row in x.Rows)
            {
                OrderTable tmp = OrderTableDAO.RowToOrderTable(row);
                if (tmp.status == "cancelled")
                {
                    UCOrder_buyerSight item = new UCOrder_buyerSight(tmp);
                    pnlItems.Controls.Add(item);
                }
            }
            if (pnlItems.Controls.Count == 0) pnlItems.Controls.Add(pictureBox1);

        }

        private void BtnCompleted_Click(object? sender, EventArgs e)
        {
            ResetBtnStatusBorder();
            pnlCompleted.BackColor = Color.FromArgb(30, 106, 17);


            foreach (DataRow row in x.Rows)
            {
                OrderTable tmp = OrderTableDAO.RowToOrderTable(row);
                if (tmp.status == "completed")
                {
                    UCOrder_buyerSight item = new UCOrder_buyerSight(tmp);
                    pnlItems.Controls.Add(item);
                }
            }
            if (pnlItems.Controls.Count == 0) pnlItems.Controls.Add(pictureBox1);

        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            ResetBtnStatusBorder();

            pnlShip.BackColor = Color.FromArgb(30, 106, 17);

            pnlItems.Controls.Clear();
            DataTable x = OrderTableDAO.SellectByBuyerId(Program.currentUserId);
            foreach (DataRow row in x.Rows)
            {
                OrderTable tmp = OrderTableDAO.RowToOrderTable(row);
                if (tmp.status == "shipping" || tmp.status == "waiting")
                {
                    UCOrder_buyerSight item = new UCOrder_buyerSight(tmp);
                    pnlItems.Controls.Add(item);
                }
            }
            if (pnlItems.Controls.Count == 0) pnlItems.Controls.Add(pictureBox1);

        }
        void ResetBtnStatusBorder()
        {

            pnlShip.BackColor = Color.Transparent;
            pnlCompleted.BackColor = Color.Transparent;
            pnlCancelled.BackColor = Color.Transparent;
            pnlReturned.BackColor = Color.Transparent;
            pnlItems.Controls.Clear();
        }

        private void pnlItems_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
