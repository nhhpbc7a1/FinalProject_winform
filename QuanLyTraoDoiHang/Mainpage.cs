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
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
        }

       
        private void Mainpage_Load(object sender, EventArgs e)
        {
           
        }
        private Form currentFormChild;
        private void OpenChhildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            childForm.Dock = DockStyle.Fill;
            pnl_Body.Controls.Add(childForm);
            pnl_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChhildForm(new FormCart());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChhildForm(new FormProductDetail());
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
