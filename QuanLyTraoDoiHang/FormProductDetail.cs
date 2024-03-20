using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTraoDoiHang
{
    public partial class FormProductDetail : Form
    {
        public FormProductDetail()
        {
            InitializeComponent();
            pnl_ThisSellerPage.Visible = false;

        }
        public static Product currentProduct = new Product();

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormProductDetail_Load(object sender, EventArgs e)
        {
            ptbImage.BackgroundImage = currentProduct.image;
            lblName.Text = currentProduct.name;
            lblPrice.Text = currentProduct.price.ToString();
            lblOriginalPrice.Text = currentProduct.originalPrice.ToString();
            lblWarrantyPolicy.Text = currentProduct.warrantyPolicy.ToString();
            lblBrand.Text = currentProduct.brand.ToString();
            lblCondition.Text = currentProduct.condition.ToString();
            lblBought.Text = currentProduct.dateBought.ToString();
            richTextBoxDescription.Text = currentProduct.description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Dock = DockStyle.None;
            panel1.Dock = DockStyle.None;
            pnl_ThisSellerPage.Size = new System.Drawing.Size(777, 653);
            pnl_ThisSellerPage.Visible = true;
            pnl_ThisSellerPage.BringToFront();
            pnl_ThisSellerPage.Dock = DockStyle.Left;
        }

        private void rButton2_Click(object sender, EventArgs e)
        {
            pnl_ThisSellerPage.Visible = false;
        }

        private void rButton4_Click(object sender, EventArgs e)
        {
            panel2.Dock = DockStyle.None;
            panel1.Dock = DockStyle.None;
            pnl_ThisSellerPage.Size = new System.Drawing.Size(648, 653);
            pnl_ThisSellerPage.Visible = true;
            pnl_ThisSellerPage.BringToFront();
            pnl_ThisSellerPage.Dock = DockStyle.Left;
        }

    }
}
