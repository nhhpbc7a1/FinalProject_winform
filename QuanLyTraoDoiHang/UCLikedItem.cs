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
    public partial class UCLikedItem : UserControl
    {
        int productId;
        int status = 0;
        public UCLikedItem()
        {
            InitializeComponent();
            iconNo.Visible = true;
            iconYes.Visible = false;
            lblLiked.ForeColor = Color.Black;

            foreach (Control control in panel1.Controls)
            {
                control.Click += Liked_Click;
            }
            panel1.Click += Liked_Click;
        }
        public void AddProductId(int productId)
        {
            this.productId = productId;
            if (LikedItemDAO.SelectByLikedItem(new LikedItem(Program.currentUserId, productId)) == null ) 
            {
                iconNo.Visible = true;
                iconYes.Visible = false;
                lblLiked.ForeColor = Color.Black;
                status = 0;
            }
            else
            {
                iconNo.Visible = false;
                iconYes.Visible = true;
                lblLiked.ForeColor = Color.Red;
                status = 1;
            }
        }


        private void Liked_Click(object? sender, EventArgs e)
        {
            if (Program.currentUserId == -1) 
            {
                MessageBox.Show("Please login first", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Program.currentUserId == ProductDAO.SelectById(productId).sellerId)
            {
                MessageBox.Show("Can not like your product", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (status == 1)
            {
                iconYes.Visible = false;
                iconNo.Visible = true;
                lblLiked.ForeColor = Color.Black;
                LikedItemDAO.Delete(new LikedItem(Program.currentUserId, productId));
                MessageBox.Show("Unlike successfully!");
            }
            else
            {
                iconNo.Visible = false;
                iconYes.Visible = true;
                lblLiked.ForeColor = Color.Red;
                LikedItemDAO.Add(new LikedItem(Program.currentUserId, productId));
                MessageBox.Show("Like successfully!");
            }
            status = (status + 1) % 2;

        }

    }
}
