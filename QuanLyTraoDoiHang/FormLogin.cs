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
                MessageBox.Show("wrong username");
                txtUsername.Focus();
                return;
            }
            if (ucPassword.txtPass.Text != account.password)
            {
                MessageBox.Show("wrong password");
                ucPassword.txtPass.Focus();
                return;
            }
            MessageBox.Show("Login successfully","Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
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
    }
}