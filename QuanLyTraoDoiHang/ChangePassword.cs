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
            ucOldPass.txtPass.PlaceholderText = " Old password";
            ucNewPass.txtPass.PlaceholderText = " New password";
            ucReTypePass.txtPass.PlaceholderText = " Retype new password";
            ucNewPass.txtPass.TextChanged += newPass_TextChanged;
            ucReTypePass.txtPass.TextChanged += RetypedPass_TextChanged;
            ucNewPass.txtPass.TextChanged += UnableChangePassBtn;
            ucReTypePass.txtPass.TextChanged += UnableChangePassBtn;
            this.AcceptButton = btnChangePass;

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            Account x = AccountDAO.SelectByUserID(Program.currentUserId);
            if (AccountDAO.IsChangablePassword(x, ucOldPass.txtPass.Text, ucNewPass.txtPass.Text, ucReTypePass.txtPass.Text))
            {
                x.password = ucNewPass.txtPass.Text;
                AccountDAO.Update(x);
                MessageBox.Show("Change password successfully","Notification");
            }
        }
        private void newPass_TextChanged(object sender, EventArgs e)
        {
            if(ucNewPass.txtPass.Text == "")
            {
                lblValidPass.ForeColor = Color.Black;
            }
            else
            {
                if (!AccountDAO.IsValidPassword(ucNewPass.txtPass.Text))
                {
                    lblValidPass.ForeColor = Color.Red;
                }
                else
                {
                    lblValidPass.ForeColor = Color.Green;
                }
            }
          
        }
        private void RetypedPass_TextChanged(object sender, EventArgs e)
        {
            if(ucReTypePass.txtPass.Text == "")
            {
                lblRetypedPass.ForeColor = Color.Black;
            }
            else
            {
                if (!AccountDAO.IsMatchedPassword(ucReTypePass.txtPass.Text, ucNewPass.txtPass.Text))
                {
                    lblRetypedPass.ForeColor = Color.Red;
                }
                else
                {
                    lblRetypedPass.ForeColor = Color.Green;
                }
            }
          
        }
        private void UnableChangePassBtn(object sender, EventArgs e)
        {
            Account x = AccountDAO.SelectByUserID(Program.currentUserId);
           if(AccountDAO.IsValidPassword(ucNewPass.txtPass.Text)&& (ucNewPass.txtPass.Text == ucReTypePass.txtPass.Text))
           {
                btnChangePass.Enabled = true;
           }
           else
           {
                btnChangePass.Enabled = false;
           }
        }
       
    }
}
