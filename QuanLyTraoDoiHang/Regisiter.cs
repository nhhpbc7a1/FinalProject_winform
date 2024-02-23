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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register successfully");
        }

        private void txtBirthday_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBackRegister_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.ShowDialog();
           
        }
    }
}
