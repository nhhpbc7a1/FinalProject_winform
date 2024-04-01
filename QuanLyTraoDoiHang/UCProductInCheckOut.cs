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
    public partial class UCProductInCheckOut : UserControl
    {
        public Product product; 
        public UCProductInCheckOut(Product product)
        {
            InitializeComponent();
            this.product = product;
            pbProductImage.BackgroundImage = product.image;
            lblProductName.Text = product.name;
            lblCondition.Text = product.condition;
            lblOldPrice.Text = product.originalPrice.ToString();
            lblPrice.Text = product.price.ToString();
        }

    }
}
