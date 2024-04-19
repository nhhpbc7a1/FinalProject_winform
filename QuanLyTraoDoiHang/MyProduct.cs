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
    public partial class MyProduct : Form
    {
        public MyProduct()
        {
            InitializeComponent();
            Load += MyProduct_Load;
        }

        private void MyProduct_Load(object? sender, EventArgs e)
        {
            pnlProducts.Controls.Clear();
            DataTable x = ProductDAO.SelectBySellerId(Program.currentUserId);
            foreach (DataRow row in x.Rows)
            {
                UCManageProduct tmp = new UCManageProduct(ProductDAO.RowToProduct(row));
                pnlProducts.Controls.Add(tmp);
            }
        }

        private void pnlProducts_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
