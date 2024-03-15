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
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void FSellermanagement_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucDropDownMenu1_Load(object sender, EventArgs e)
        {

        }

        private void rButton1_Click(object sender, EventArgs e)
        {

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
    }
}
