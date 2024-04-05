using QuanLyTraoDoiHang.RJControls;
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

            pnlMainPage.Click += BackToMainpage;
            btnMainPage.Click += BackToMainpage;
            lblMainPage.Click += BackToMainpage;

            lblSellerChannel.Click += lblSellerChannel_Click;
            lblSignUp.Click += lblSignup_Click;
            lblSignIn.Click += lblSignin_Click;
            this.pnlAccount.Location = new Point(850, 9);

            pnlAccount.Click += Account_Click;
            picProfile.Click += Account_Click;
            lblUsername.Click += Account_Click;
            pnlAccount.Visible = false;
            btnAddProduct.Click += btnAddProduct_Click;
            btnCart.Click += btnCart_Click;

            this.Load += UpdateAccountByAction;

            btnExit.Click += btnExit_Click;
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;

            //UploadSearchBoxHistory();
            btnSearch.Click += btnSearch_Click;
        }
        //private void UploadSearchBoxHistory()
        //{
        //    cbSearchBox.Items.Clear();
        //}
        Product currentProductDetail = new Product();
        private void btnSearch_Click(object? sender, EventArgs e)
        {
            FormProduct form = new FormProduct();
            form.LoadBySearchText(cbSearchBox.Text);
            OpenChildForm(form);
        }


        private void UpdateAccountByAction(object? sender, EventArgs e)
        {
            if (Program.CurrentUser() != null)
            {
                pnlAccount.Visible = true;
                lblSignIn.Visible = false;
                lblSignUp.Visible = false;
                lblUsername.Text = AccountDAO.SelectByUserID(Program.currentUserId).username;
                picProfile.BackgroundImage = Program.CurrentUser().image;

            }
            else
            {
                pnlAccount.Visible = false;
                lblSignIn.Visible = true;
                lblSignUp.Visible = true;
            }
        }


        private void lblSellerChannel_Click(object? sender, EventArgs e)
        {
            if (Program.CurrentUser() == null)
            {
                MessageBox.Show("please login first", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                OpenChildForm(new FSellermanagement());
            }
        }

        private void BackToMainpage(object sender, EventArgs e)
        {
            OpenChildForm(new FormProduct());
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

            childForm.Dock = DockStyle.Fill;
            pnl_Body.Controls.Add(childForm);
            pnl_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            UpdateAccountByAction(null, null);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser() == null)
            {
                MessageBox.Show("Please login first", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormCart formCart = new FormCart();
                OpenChildForm(formCart);
            }
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            Form form = new Regisiter();
            form.ShowDialog();
            UpdateAccountByAction(sender, e);
        }

        private void lblSignin_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.ShowDialog();
            UpdateAccountByAction(sender, e);
        }


        private void Account_Click(object sender, EventArgs e)
        {
            PersonalInfor form = new PersonalInfor();
            OpenChildForm(form);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser() == null)
            {
                MessageBox.Show("Please login first", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Form form = new FormAddNewProduct();
                OpenChildForm(form);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
