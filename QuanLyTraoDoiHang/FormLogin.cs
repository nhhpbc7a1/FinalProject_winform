namespace QuanLyTraoDoiHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ucPassword.txtPass.PlaceholderText = " Password";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

       

        private void lblforgotpass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact Admin for further information!", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        private void rButton2_Click(object sender, EventArgs e)
        {
            Form form = new Regisiter();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            Program.currentUser = UserDAO.SelectByUserId(account.userId);
            Close();
        }
    }
}