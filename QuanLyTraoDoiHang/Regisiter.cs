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
    public partial class Regisiter : Form
    {
        public Regisiter()
        {
            InitializeComponent();
            dtBirthday.CustomFormat = " 'Birthday' ";
            dtBirthday.Format = DateTimePickerFormat.Custom;

            ucPassword.txtPass.PlaceholderText = "  Password";
            ucRetypePassword.txtPass.PlaceholderText = "  Re-type Password";
            btnRegister.Click += btnRegister_Click;

            ucPassword.txtPass.TextChanged += newPass_TextChanged;
            ucRetypePassword.txtPass.TextChanged += RetypedPass_TextChanged;

        }



        private void dtBirthday_ValueChanged(object sender, EventArgs e)
        {
            dtBirthday.CustomFormat = "dd/MM/yyyy ";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPersonalId.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Personal ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPersonalId.Focus();
                return;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Phone !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Username!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (ucPassword.txtPass.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Password !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            if (ucRetypePassword.txtPass.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Retyped password !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if (UserDAO.IsAdult(dtBirthday.Value) == false)
            {
                MessageBox.Show("You are  under 18 !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (UserDAO.IsValidEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Email isn't valid !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (UserDAO.IsValidPhone(txtPhone.Text) == false)
            {
                MessageBox.Show("Phone isn't valid !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }           
            if (AccountDAO.SelectByUsername(txtUsername.Text) != null)
            {
                MessageBox.Show("Username already exists, Try another !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            if (AccountDAO.IsValidPassword(ucPassword.txtPass.Text) == false)
            {
                MessageBox.Show("Password is unvalid, Try another !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucPassword.txtPass.Focus();
                return;
            }
            if (ucPassword.txtPass.Text != ucRetypePassword.txtPass.Text)
            {
                MessageBox.Show("Your retyped password is not matched!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucRetypePassword.txtPass.Focus();
                return;
            }

            User user = new User(txtPersonalId.Text,"",DateOnly.FromDateTime(dtBirthday.Value),txtEmail.Text,txtPhone.Text,0,"");
            Account account = new Account(user.userId,txtUsername.Text,ucPassword.txtPass.Text);

            UserDAO.Add(user);
            AccountDAO.Add(account);

            Program.currentUserId = user.userId;
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void newPass_TextChanged(object sender, EventArgs e)
        {
            if (ucPassword.txtPass.Text == "")
            {
                lblValidPass.Visible = false;
            }
            else
            {
                if (!AccountDAO.IsValidPassword(ucPassword.txtPass.Text))
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
            if (ucRetypePassword.txtPass.Text == "")
            {
                lblRetypedPass.Visible = false;
            }
            else
            {
                if (!AccountDAO.IsMatchedPassword(ucRetypePassword.txtPass.Text, ucPassword.txtPass.Text))
                {
                    lblRetypedPass.ForeColor = Color.Red;
                }
                else
                {
                    lblRetypedPass.ForeColor = Color.Green;
                }
            }

        }
    }
}
