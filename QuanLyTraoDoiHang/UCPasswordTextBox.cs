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
    public partial class UCPasswordTextBox : UserControl
    {
        public UCPasswordTextBox()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
            btnHide.Click += btnHide_Click;
            btnShow.Click += btnShow_Click;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
            {
                txtPass.UseSystemPasswordChar = false;
                btnShow.BringToFront();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == false)
            {
                txtPass.UseSystemPasswordChar = true;
                btnHide.BringToFront();
            }
        }

        public void UCPasswordTextBox_Load(object sender, EventArgs e)
        {
            txtPass.Width = this.Width;
            this.Height = txtPass.Height;
            btnHide.Location = new Point(this.Width - btnHide.Width - 7, (this.Height - btnHide.Height) / 2);
            btnShow.Location = new Point(this.Width - btnHide.Width - 7, (this.Height - btnHide.Height) / 2);

            btnHide.BringToFront();
            this.BringToFront();
        }

    }
}
