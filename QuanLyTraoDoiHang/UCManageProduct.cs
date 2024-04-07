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
    public partial class UCManageProduct : UserControl
    {
        Product product { get; set; }
        public UCManageProduct(Product product)
        {
            InitializeComponent();
            this.product = product;
            picItems.BackgroundImage = product.image;
            lblProductName.Text = product.name;
            lblCondition.Text = product.condition;
            lblPrice.Text = product.price.ToString();
            lblOriginPrice.Text = product.originalPrice.ToString();
            btnViewChange.Click += BtnViewChange_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            ProductDAO.Delete(product);
        }

        private void BtnViewChange_Click(object? sender, EventArgs e)
        {
            FormAddNewProduct x = new FormAddNewProduct(product);
            x.ShowDialog();
        }
    }
}
