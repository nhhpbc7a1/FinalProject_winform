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
            btnChangePass.Click += btnChangePassword_Click;
            btnUpdateInfo.Click += btnUpdateInfo_Click;
            btnHistory.Click += btnHistory_Click;
            Load += PersonalInfor_Load;
            lblChangeImage.Click += lblChangeImage_Click;
            btnLogout.Click += BtnLogout_Click;
        }

        private void BtnLogout_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Logout successfully");
                Program.currentUserId = -1;
                Program.mainpage.OpenChildForm(new FormProduct());
            }
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

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangePassword());
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyInfo());
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewHistory());
        }


        private void PersonalInfor_Load(object sender, EventArgs e)
        {
            ptbUserImage.BackgroundImage = Program.CurrentUser().image;
            lblUsername.Text = AccountDAO.SelectByUserID(Program.currentUserId).username;
        }
        private void lblChangeImage_Click(object sender, EventArgs e)
        {
            Image image = MyImage.ChooseImage();
            ptbUserImage.BackgroundImage = image;
            Program.CurrentUser().image = image;
            UserDAO.Update(Program.CurrentUser());
        }

    }
}
