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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

       
        //
        private void btnHideOldPass_Click(object sender, EventArgs e)
        {
            if (txtOldPass.UseSystemPasswordChar == false)
            {
                txtOldPass.UseSystemPasswordChar = true;
                rButton5.BringToFront();
            }
        }

     
        private void rButton5_Click(object sender, EventArgs e)
        {
            if (txtOldPass.UseSystemPasswordChar == true)
            {
                txtOldPass.UseSystemPasswordChar = false;
                btnHideOldPass.BringToFront();
            }
        }
        //
        private void btnViewNewPass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.UseSystemPasswordChar == true)
            {
                txtNewPass.UseSystemPasswordChar = false;
                btnHideNewPass.BringToFront();
            }
        }

        private void btnHideNewPass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.UseSystemPasswordChar == false)
            {
                txtNewPass.UseSystemPasswordChar = true;
                btnHideNewPass.BringToFront();
            }
        }
        //
        private void btnViewPass_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
            {
                txtPass.UseSystemPasswordChar = false;
                btnHidePass.BringToFront();
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == false)
            {
                txtPass.UseSystemPasswordChar = true;
                btnHidePass.BringToFront();
            }
        }
        //
    }
}
