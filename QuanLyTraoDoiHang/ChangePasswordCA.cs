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
    public partial class ChangePasswordCA : Form
    {
        public ChangePasswordCA()
        {
            InitializeComponent();
        }

        private void btnBackCA_Click(object sender, EventArgs e)
        {
            Form form = new CustomerAccount();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnChangeCA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to change?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                MessageBox.Show("Change successfully!");
            }
            else
            {
                return;
            }

        }
    }
}
