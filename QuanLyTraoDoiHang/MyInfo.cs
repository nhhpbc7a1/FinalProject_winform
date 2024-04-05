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
    public partial class MyInfo : Form
    {
        public MyInfo()
        {
            InitializeComponent();
            Load += MyInfo_Load;
            btnSave.Click += btnSave_Click;
            this.AcceptButton = btnSave;
        }

        private void MyInfo_Load(object sender, EventArgs e)
        {
            User currentUser = Program.CurrentUser();
            txtName.Text = currentUser.name;
            txtPersonalID.Text = currentUser.personalId;
            dtBirthday.Text = currentUser.birthday.ToString();
            txtEmail.Text = currentUser.email;
            txtPhone.Text = currentUser.phone;
            txtAddress.Text = currentUser.address;
            switch (currentUser.gender)
            {
                case 0:
                    {
                        radioBtnFemale.Checked = true; break;
                    }
                case 1:
                    {
                        radioBtnMale.Checked = true; break;
                    }
                case 2:
                    {
                        radioBtnOther.Checked = true; break;
                    }
            }
            //lblDateJoined.Text = currentUser.dateJoined.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
            if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Phone!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            if (txtPersonalID.Text.Trim() == "")
            {
                MessageBox.Show("You haven't input your Personal ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPersonalID.Focus();
                return;
            }
            if (UserDAO.IsAdult(dtBirthday.Value) == false)
            {
                MessageBox.Show("You must be an adult !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new User();
            user.name = txtName.Text;
            user.personalId = txtPersonalID.Text;
            user.email = txtEmail.Text;
            user.phone = txtPhone.Text;
            user.address = txtAddress.Text;
            if (radioBtnFemale.Checked == true)
                user.gender = 0;
            if (radioBtnMale.Checked == true)
                user.gender = 1;
            if (radioBtnOther.Checked == true)
                user.gender = 2;

            user.birthday = DateOnly.FromDateTime(dtBirthday.Value);
            user.userId = Program.CurrentUser().userId;
            user.image = Program.CurrentUser().image;
            user.dateJoined = Program.CurrentUser().dateJoined;
            UserDAO.Update(user);
            Program.currentUserId = user.userId;
            MessageBox.Show("Update info successfully","Notification");
            MyInfo_Load(sender, e);
        }

        private void MyInfo_Load_1(object sender, EventArgs e)
        {

        }
    }
}
