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
    public partial class CancelReason : Form
    {
        public CancelReason()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rButton1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rButton2_Click(object sender, EventArgs e)
        {
            Program.mainpage.OpenChildForm(new FormProduct());
            this.Close();
        }
    }
}
