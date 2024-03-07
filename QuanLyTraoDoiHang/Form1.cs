namespace QuanLyTraoDoiHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new QuanLyHang();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form form = new Regisiter();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

       

        private void lblforgotpass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact Admin for further information!", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }
    }
}