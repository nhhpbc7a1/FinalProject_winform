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
            OpenChildForm(new FormProduct());
        }

       
        private void Mainpage_Load(object sender, EventArgs e)
        {
           
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCart());

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form form = new Regisiter();
            form.ShowDialog();
        }

        private void pnl_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProduct());
        }

        private void rButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCart());

        }

        private void rButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PersonalInfor());
        }

        private void rButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProduct());

        }
    }
}
