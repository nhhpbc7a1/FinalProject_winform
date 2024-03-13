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
    public partial class PersonalInfor : Form
    {
        public PersonalInfor()
        {
            InitializeComponent();
            OpenChildForm(new MyInfo());
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            childForm.Dock = DockStyle.None;
            pnl_Infor.Controls.Add(childForm);
            pnl_Infor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
      
        private void rButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangePassword());
        }

        private void rButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyInfo());
        }
    }
}
