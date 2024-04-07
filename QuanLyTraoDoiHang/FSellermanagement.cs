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
            lblContent.Text = "My Products";

            MyProduct formMyProduct = new MyProduct();
            OpenChildForm(formMyProduct);
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
            lblContent.Text = "Completed Orders";
            List<string> strings = new List<string>();
            strings.Add("completed");
            FormProductStatus formProductStatus = new FormProductStatus(strings, false);
            OpenChildForm(formProductStatus);
        }

        private void btnReturned_Click(object sender, EventArgs e)
        {
            lblContent.Text = "Returned Orders";
            List<string> strings = new List<string>();
            strings.Add("returned");
            FormProductStatus formProductStatus = new FormProductStatus(strings, false);
            OpenChildForm(formProductStatus);
        }

        private void btnCancelled_Click(object sender, EventArgs e)
        {
            lblContent.Text = "Cancelled Orders";
            List<string> strings = new List<string>();
            strings.Add("cancelled");
            FormProductStatus formProductStatus = new FormProductStatus(strings, false);
            OpenChildForm(formProductStatus);
        }

        private void btnShipment_Click_1(object sender, EventArgs e)
        {
            if (pnlItems.Controls == null)
            {
                picEmpty.Visible = true;
            }
            else
            {
                picEmpty.Visible = false;
            }
            lblContent.Text = "Shipment";
            List<string> strings = new List<string>();
            strings.Add("waiting");
            strings.Add("shipping");
            FormProductStatus formProductStatus = new FormProductStatus(strings, true);
            OpenChildForm(formProductStatus);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


        }

        private void lblContent_Click(object sender, EventArgs e)
        {

        }
    }
}
