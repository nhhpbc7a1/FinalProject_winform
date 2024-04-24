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

            btnReturn.BorderSize = 2;
            btnReturn.BorderColor = Color.FromArgb(52, 255, 46);

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

            btnCancel.BorderSize = 2;
            btnCancel.BorderColor = Color.FromArgb(52, 255, 46);

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

            btnCompleted.BorderSize = 2;
            btnCompleted.BorderColor = Color.FromArgb(52, 255, 46);

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

            btnShip.BorderSize = 2;
            btnShip.BorderColor = Color.FromArgb(52, 255, 46);

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
            btnShip.BorderSize = 0;
            btnShip.BorderColor = Color.FromArgb(64, 64, 64, 64);
            btnCancel.BorderSize = 0;
            btnCancel.BorderColor = Color.FromArgb(64, 64, 64, 64);
            btnCompleted.BorderSize = 0;
            btnCompleted.BorderColor = Color.FromArgb(64, 64, 64, 64);
            btnReturn.BorderSize = 0;
            btnReturn.BorderColor = Color.FromArgb(64, 64, 64, 64);
            pnlItems.Controls.Clear();
        }

        private void pnlItems_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
