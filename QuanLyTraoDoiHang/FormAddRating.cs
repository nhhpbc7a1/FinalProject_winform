using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormAddRating : Form
    {
        Product product;
        OrderTable orderTable;
        public FormAddRating(Product product, OrderTable orderTable)
        {
            InitializeComponent();
            this.product = product;
            picProductImage.BackgroundImage = product.image;
            lblProductName.Text = product.name;
            btnSubmit.Click += BtnSubmit_Click;
            this.orderTable = orderTable;

            ucStars1.canChanged = true;
            ucStars1.UCStars_Load(null, null);

        }

        private void BtnSubmit_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to add rating?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RatingDAO.Add(new Rating(Program.currentUserId, product.sellerId, orderTable.orderId, product.productId, Convert.ToInt32(ucStars1.comboBoxNum.Text.ToString()), txtDetail.Text));
                MessageBox.Show("Add rating successfully");
                Close();
            }
        }

        private void btnDeliverAdress_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
