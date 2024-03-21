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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            ProductDAO productDAO = new ProductDAO();
            DataTable table = productDAO.Load();
            foreach (DataRow row in table.Rows)
            {
                UCProductOnMainpage ucProduct = new UCProductOnMainpage();
                ucProduct.product = ProductDAO.RowToProduct(row);

                flowLayoutPanelProductList.Controls.Add(ucProduct);
            }

        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucProductOnMainpage1_Load(object sender, EventArgs e)
        {

        }


        private void ucProductOnMainpage7_Click(object sender, EventArgs e)
        {
            Form form = new FormProductDetail();
            form.ShowDialog();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

    }
}
