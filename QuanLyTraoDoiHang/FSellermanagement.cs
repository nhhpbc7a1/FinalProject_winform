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
            OpenChildForm(new FormMyShipment());
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
            //this.ucOrder.rBSelect.Text = "Order";
            //this.ucOrder.rButton1.Text = "My Order";
            ////cancel by buyer, cancel by owner
            //this.ucOrder.rButton2.Text = "Cancellation";
            ////return reason
            //this.ucOrder.rButton3.Text = "Return";

        }
        private void ucProduct_Load(object sender, EventArgs e)
        {
            //actions: update
            //this.ucProduct.rBSelect.Text = "Product";
            //this.ucProduct.rButton1.Text = "My Product";
            //this.ucProduct.rButton2.Text = "Add New Products";
            //this.ucProduct.rButton3.Visible = false;

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

        private void ucOrder_Load(object sender, EventArgs e)
        {
            //this.ucOrder.rBSelect.Text = "Order";
            //this.ucOrder.rButton1.Text = "My Order";
            ////cancel by buyer, cancel by owner
            //this.ucOrder.rButton2.Text = "Cancellation";
            ////return reason
            //this.ucOrder.rButton3.Text = "Return";
        }

        private void ucProduct_Load_1(object sender, EventArgs e)
        {
            ////actions: update
            //this.ucProduct.rBSelect.Text = "Product";
            //this.ucProduct.rButton1.Text = "My Product";
            //this.ucProduct.rButton2.Text = "Add New Products";
            //this.ucProduct.rButton3.Visible = false;
        }

        private void ucProduct_Load_2(object sender, EventArgs e)
        {
            //actions: update
            //this.ucProduct.rBSelect.Text = "Product";
            //this.ucProduct.rButton1.Text = "My Product";
            //this.ucProduct.rButton2.Text = "Add New Products";
            //this.ucProduct.rButton3.Visible = false;
        }

        private void ucOrder_Load_1(object sender, EventArgs e)
        {
            //this.ucOrder.rBSelect.Text = "Order";
            //this.ucOrder.rButton1.Text = "My Order";
            ////cancel by buyer, cancel by owner
            //this.ucOrder.rButton2.Text = "Cancellation";
            ////return reason
            //this.ucOrder.rButton3.Text = "Return";
        }

        private void rBAnalysis_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new FAnalysis());
        }

       
        private bool isCollapsed;
        private bool isCollapsed1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
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

        private void btnCancelled_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FCancellation());

        }

        private void btnReturned_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FReturn());

        }

        private void btnMyProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyProduct());

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnShipment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMyShipment());

        }

        private void rButton1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FAnalysis());

        }

        private void rButton5_Click(object sender, EventArgs e)
        {

        }

        private void rButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMyShipment());

        }

        private void rButton1_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new FAnalysis());

        }

        private void btnShipment_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormMyShipment());

        }
    }
}
