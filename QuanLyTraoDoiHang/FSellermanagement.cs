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

namespace QuanLyTraoDoiHang
{
    public partial class FSellermanagement : Form
    {
        public FSellermanagement()
        {
            InitializeComponent();
            OpenChildForm(new FormMyShipment());
            this.ucOrder.rButton1.Click += rButton1_Order_Click;
            this.ucOrder.rButton2.Click += rButton2_Order_Click;
            this.ucOrder.rButton3.Click += rButton3_Order_Click;
            this.ucProduct.rButton1.Click += rButton1_Product_Click;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        private void rButton1_Order_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMyOrder());
        }
        private void rButton2_Order_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FCancellation());
        }
        private void rButton3_Order_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FReturn());
        }
        private void rButton1_Product_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyProduct());
        }
        private void FSellermanagement_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucDropDownMenu1_Load(object sender, EventArgs e)
        {
            this.ucOrder.rBSelect.Text = "Order";
            this.ucOrder.rButton1.Text = "My Order";
            //cancel by buyer, cancel by owner
            this.ucOrder.rButton2.Text = "Cancellation";
            //return reason
            this.ucOrder.rButton3.Text = "Return";

        }
        private void ucProduct_Load(object sender, EventArgs e)
        {
            //actions: update
            this.ucProduct.rBSelect.Text = "Product";
            this.ucProduct.rButton1.Text = "My Product";
            this.ucProduct.rButton2.Text = "Add New Products";
            this.ucProduct.rButton3.Visible = false;

        }

        private void rButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMyShipment());
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

        private void pnlSellerTool_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rBAnalysis_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FAnalysis());
        }

        private void rBAnalysis_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FAnalysis());

        }
    }
}
