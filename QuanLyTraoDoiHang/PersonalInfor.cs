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
            btnFavorite.Click += BtnFavorite_Click;
        }

        private void BtnFavorite_Click(object? sender, EventArgs e)
        {
            ResetbtnColor();
            btnFavorite.TextColor = Color.White;
            btnFavorite.BackColor = Color.FromArgb(101, 183, 65);

            FlowLayoutPanel x = new FlowLayoutPanel();
            x.Dock = DockStyle.Fill;
            x.Padding = new Padding(50, 5, 0, 5);
            x.AutoScroll = true;
            DataTable listFavor = LikedItemDAO.SelectByUserId(Program.currentUserId);
            foreach (DataRow row in listFavor.Rows) 
            {
                LikedItem likedItem = LikedItemDAO.RowToLikedItem(row);
                UCProductOnMainpage tmp = new UCProductOnMainpage(ProductDAO.SelectById(likedItem.productId));
                x.Controls.Add(tmp);
            }
            pnl_Infor.Controls.Clear();
            pnl_Infor.Controls.Add(x);
        }

        private void BtnLogout_Click(object? sender, EventArgs e)
        {
            ResetbtnColor();
            btnLogout.TextColor = Color.White;
            btnLogout.BackColor = Color.FromArgb(101, 183, 65);

            if (MessageBox.Show("Do you really want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Logout successfully");
                Program.currentUserId = -1;
                Program.mainpage.OpenChildForm(new FormProduct());
            }
        }

        private Form currentFormChild;
        public void OpenChildForm(Form childForm)
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
            ResetbtnColor();
            btnChangePass.TextColor = Color.White;
            btnChangePass.BackColor = Color.FromArgb(101, 183, 65);
            OpenChildForm(new ChangePassword());
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            ResetbtnColor();
            btnUpdateInfo.TextColor = Color.White;
            btnUpdateInfo.BackColor = Color.FromArgb(101, 183, 65);
            OpenChildForm(new MyInfo());
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            ResetbtnColor();
            btnHistory.TextColor = Color.White;
            btnHistory.BackColor = Color.FromArgb(101, 183, 65);
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
            User x = Program.CurrentUser();
            x.image = image;
            UserDAO.Update(x);
        }
        void ResetbtnColor()
        {
            btnUpdateInfo.BackColor = Color.White;
            btnUpdateInfo.TextColor = Color.FromArgb(30, 106, 17);
            btnChangePass.BackColor = Color.White;
            btnChangePass.TextColor = Color.FromArgb(30, 106, 17);
            btnHistory.BackColor = Color.White;
            btnHistory.TextColor = Color.FromArgb(30, 106, 17);
            btnLogout.BackColor = Color.White;
            btnLogout.TextColor = Color.FromArgb(30, 106, 17);
            btnFavorite.BackColor = Color.White;
            btnFavorite.TextColor = Color.FromArgb(30, 106, 17);
        }
    }
}
