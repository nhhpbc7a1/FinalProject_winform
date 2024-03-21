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
    }
}
