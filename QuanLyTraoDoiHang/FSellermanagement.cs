using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;  
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomControls.RJControls;
using System.Windows.Forms;
using QuanLyTraoDoiHang.Properties;

namespace QuanLyTraoDoiHang
{
    public partial class FSellermanagement : Form
    {

        public FSellermanagement()
        {
            InitializeComponent();
            btnShipment_Click_1(null, null);
            //OpenChildForm(new FormMyShipment());
        }



        private void rButton1_Product_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new MyProduct());
        }



        private void rButton1_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormMyShipment());
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            childForm.Dock = DockStyle.Fill;
            pnlSellerTool.Controls.Add(childForm);
            pnlSellerTool.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void rBAnalysis_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FAnalysis());
        }


        private bool isCollapsed;
        private bool isCollapsed1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btnOrder.Image = Resources.icons8_up_16;
                pnlDropDownnn.Height += 10;
                if (pnlDropDownnn.Size == pnlDropDownnn.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                btnOrder.Image = Resources.icons8_down_16;
                pnlDropDownnn.Height -= 10;
                if (pnlDropDownnn.Size == pnlDropDownnn.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnOrder.BackColor = Color.FromArgb(30, 106, 17);
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed1)
            {
                btnProducts.Image = Resources.icons8_up_16;
                pnlDropDownProdu.Height += 10;
                if (pnlDropDownProdu.Size == pnlDropDownProdu.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed1 = false;
                }
            }
            else
            {
                btnProducts.Image = Resources.icons8_down_16;
                pnlDropDownProdu.Height -= 10;
                if (pnlDropDownProdu.Size == pnlDropDownProdu.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed1 = true;
                }
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            timer2.Start();
            //btnProducts.BackColor = Color.FromArgb(30, 106, 17);

        }
        private void btnShipment_Click(object sender, EventArgs e)
        {
            //DataTable x = OrderTableDAO.SellectByUserId(Program.currentUserId);
            //foreach (DataRow row in x.Rows)
            //{
            //    OrderTable order = OrderTableDAO.RowToOrderTable(row);
            //    ucOrder item = new ucOrder(order);
            //    pnlItems.Controls.Add(item);

            //}
        }
        // btn Product
        private void btnMyProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyProduct());

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }
        private void btnDataAnalysis_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FAnalysis());

        }
        // btn Order
        private void btnMyOrder_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            lblContent.Text = "Completed Orders";

            DataTable x = OrderTableDAO.SellectByUserId(Program.currentUserId);
            pnlItems.Controls.Clear();
            foreach (DataRow row in x.Rows)
            {

                OrderTable order = OrderTableDAO.RowToOrderTable(row);
                if (order.status == "completed")
                {
                    ucOrder item = new ucOrder(order);
                    pnlItems.Controls.Add(item);
                }


            }
        }

        private void btnReturned_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            lblContent.Text = "Returned Orders";

            DataTable x = OrderTableDAO.SellectByUserId(Program.currentUserId);
            pnlItems.Controls.Clear();
            foreach (DataRow row in x.Rows)
            {

                OrderTable order = OrderTableDAO.RowToOrderTable(row);
                if (order.status == "returned")
                {
                    ucOrder item = new ucOrder(order);
                    pnlItems.Controls.Add(item);
                }


            }
        }

        private void btnCancelled_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            lblContent.Text = "Cancelled Orders";

            DataTable x = OrderTableDAO.SellectByUserId(Program.currentUserId);
            pnlItems.Controls.Clear();
            foreach (DataRow row in x.Rows)
            {

                OrderTable order = OrderTableDAO.RowToOrderTable(row);
                if (order.status == "cancelled")
                {
                    ucOrder item = new ucOrder(order);
                    pnlItems.Controls.Add(item);
                }


            }
        }

        private void btnShipment_Click_1(object sender, EventArgs e)
        {
            lblContent.Text = "Shipment";

            DataTable x = OrderTableDAO.SellectByUserId(Program.currentUserId);
            pnlItems.Controls.Clear();
            foreach (DataRow row in x.Rows)
            {

                OrderTable order = OrderTableDAO.RowToOrderTable(row);


                if ((order.status == "waiting") || (order.status) == "shipping")
                {
                    ucOrder item = new ucOrder(order);
                    item.cbxStatus.Visible = true;
                    item.lblStatus.Visible = true;
                    pnlItems.Controls.Add(item);
                }


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            foreach (ucOrder ucorder in pnlItems.Controls)
            {
                OrderTableDAO.Update(ucorder.order);
            }
            btnShipment_Click_1(sender, e);

        }

        private void lblContent_Click(object sender, EventArgs e)
        {

        }
    }
}
