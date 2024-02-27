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
    public partial class QuanLyHang : Form
    {
        public QuanLyHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new FormCart();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form form = new FormProductDetail();
            form.ShowDialog();
        }
    }
}
