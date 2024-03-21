﻿using QuanLyTraoDoiHang.RJControls;
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
            btnCart.Click += btnCart_Click;
            lblSignUp.Click += lblSignup_Click;
            lblSignIn.Click += lblSignin_Click;
            btnAccount.Click += btnAccount_Click;
            btnAddProduct.Click += btnAddProduct_Click;

            btnAccount.Visible = false;
            lblSellerChannel.Visible = false;
            this.Load += UpdateAccountByAction;
        }
        private void UpdateAccountByAction(object? sender, EventArgs e)
        {
            if (Program.currentUser != null)
            {
                btnAccount.Visible = true;
                lblSellerChannel.Visible = true;
                lblSignIn.Visible = false;
                lblSignUp.Visible = false;
            }
            else
            {
                btnAccount.Visible = false;
                lblSellerChannel.Visible = false;
                lblSignIn.Visible = true;
                lblSignUp.Visible = true;

            }
        }


        private void lblSellerChannel_Click(object? sender, EventArgs e)
        {
            OpenChildForm(new FSellermanagement());
        }

        private void BackToMainpage(object sender, EventArgs e)
        {
            OpenChildForm(new FormProduct());
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

            childForm.Dock = DockStyle.Fill;
            pnl_Body.Controls.Add(childForm);
            pnl_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCart());
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            Form form = new Regisiter();
            form.ShowDialog();
            UpdateAccountByAction(sender,e);
        }

        private void lblSignin_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.ShowDialog();
            UpdateAccountByAction(sender, e);
        }


        private void btnAccount_Click(object sender, EventArgs e)
        {
            PersonalInfor form = new PersonalInfor();
            void Logout(object sender, EventArgs e)
            {
                MessageBox.Show("Logout successfully");
                Program.currentUser = null;
                BackToMainpage(sender,e);
                UpdateAccountByAction(sender, e);
            }
            form.btnLogout.Click += Logout;
            OpenChildForm(form);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (Program.currentUser == null)
            {
                MessageBox.Show("Please login before", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            }
            else
            {
                Form form = new FormAddNewProduct();
                form.ShowDialog();
                OpenChildForm(new FormProduct());
            }
        }

    }
}
