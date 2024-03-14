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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucProductOnMainpage1_Load(object sender, EventArgs e)
        {

        }


        private void ucProductOnMainpage7_Click(object sender, EventArgs e)
        {
            Form form = new FormProductDetail();
            form.ShowDialog();

        }
    }
}
