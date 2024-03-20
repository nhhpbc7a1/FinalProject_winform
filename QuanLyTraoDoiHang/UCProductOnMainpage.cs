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
    public partial class UCProductOnMainpage : UserControl
    {
        public UCProductOnMainpage()
        {
            InitializeComponent();

            foreach (Control c in this.Controls)
            {
                c.Click += OpenFormDetail;
            }
            this.Click += OpenFormDetail;
        }
        public Product product = new Product();
        private void UCProductOnMainpage_Load(object sender, EventArgs e)
        {
            ptbImage.BackgroundImage = product.image;
            lblName.Text = product.name;
            lblPrice.Text = product.price.ToString();
        }
        private void OpenFormDetail(object sender, EventArgs e)
        {
            FormProductDetail formDetail = new FormProductDetail();
            FormProductDetail.currentProduct = product;

            formDetail.ShowDialog();

        }
    }
}
