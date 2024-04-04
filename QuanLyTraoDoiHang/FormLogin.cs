namespace QuanLyTraoDoiHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ucPassword.txtPass.PlaceholderText = " Password";
            btnSignin.Click += btnSignin_Click;
            btnRegister.Click += btnRegister_Click;
            lblforgotpass.Click += lblforgotpass_Click;
            btnExit.Click += btnExit_Click;
            lblforgotpass.MouseEnter += lblforgotpass_MouseEnter;
            lblforgotpass.MouseLeave += lblforgotpass_MouseLeave;
         }

        private void lblforgotpass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact Admin for further information!", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }


        private void btnSignin_Click(object sender, EventArgs e)
        {
            Account account = AccountDAO.SelectByUsername(txtUsername.Text);
            if (account == null)
            {
                MessageBox.Show("Your username does not exist","Notification",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            if (ucPassword.txtPass.Text != account.password)
            {
                MessageBox.Show("Your password is not correct","Notification",MessageBoxButtons.OK,MessageBoxIcon.Error);
                ucPassword.txtPass.Focus();
                return;
            }
            MessageBox.Show("Login successfully", "Notification", MessageBoxButtons.OK);
            Program.currentUserId = account.userId;
            Close();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form form = new Regisiter();
            form.ShowDialog();
            if (Program.CurrentUser() != null)
                Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lblforgotpass_MouseEnter(object sender, EventArgs e)
        {
            lblforgotpass.Font =  new Font(lblforgotpass.Font, FontStyle.Underline);
        }

        private void lblforgotpass_MouseLeave(object sender, EventArgs e)
        {
            lblforgotpass.Font = new Font(lblforgotpass.Font, FontStyle.Regular);

        }
    }
}