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
    public partial class UCViewHistoryItem : UserControl
    {
        public Product product = new Product();
        public UCViewHistoryItem(Product product)
        {

            InitializeComponent();
            this.product = product;
            picItems.BackgroundImage = product.image;
            lblProductName.Text = product.name;
            lblCondition.Text = product.condition;
            lblPrice.Text = product.price.ToString();
            lblOriginPrice.Text = product.originalPrice.ToString();

        }
    }
}
