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
        public OrderTable orderTable;
        public UCViewHistoryItem(Product product, string status, OrderTable orderTable)
        {

            InitializeComponent();
            this.product = product;
            picItems.BackgroundImage = product.image;
            lblProductName.Text = product.name;
            lblCondition.Text = product.condition;
            lblPrice.Text = product.price.ToString();
            lblOriginPrice.Text = product.originalPrice.ToString();
            if (status == "completed")
            {
                btnAction.Text = "Rating";
                if (RatingDAO.SelectByProductId(product.productId) != null)
                {
                    btnAction.Enabled = false;
                }
                else Enabled = true;
            }
            if(status == "cancelled")
            {
                btnAction.Text = "Buy again";
                btnAction.Click += BtnRating_Click;
            }
            if(status == "returned")
            {
                btnAction.Text = "Buy again";
                btnAction.Click += BtnRating_Click;
            }
            
            this.orderTable = orderTable;
            if ((status == "waiting") || (status == "shipping"))
            {
                btnAction.Text = "Cancel";
                btnAction.Click += BtnCancel_Click;
            }
        }

        private void BtnRating_Click(object? sender, EventArgs e)
        {
            FormAddRating x = new FormAddRating(product, orderTable);
            x.ShowDialog();
            if (RatingDAO.SelectByProductId(product.productId) != null)
            {
                btnAction.Enabled = false;
            }
            else Enabled = true;
        }
        private void BtnCancel_Click(object? sender, EventArgs e) 
        {
            ProductDAO.CancelByBuyer(product, orderTable);
        }
        private void rButton1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
