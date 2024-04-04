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
    public partial class FormAddReceiveInfo : Form
    {
        public ReceiveInfo receiveInfo = null;
        public FormAddReceiveInfo()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            Load += FormAddReceiveInfo_Load;
            btnSave.Focus();
        }

        private void FormAddReceiveInfo_Load(object? sender, EventArgs e)
        {
            if (receiveInfo != null)
            {
                txtName.Text = receiveInfo.name;
                txtPhone.Text = receiveInfo.phone;
                txtAddress.Text = receiveInfo.address;
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (receiveInfo == null)
            {
                receiveInfo = new ReceiveInfo(Program.currentUserId, txtName.Text, txtPhone.Text, txtAddress.Text);

                ReceiveInfoDAO.Add(receiveInfo);
                MessageBox.Show("Add successfully");
                Close();
            }
            else
            {
                receiveInfo.name = txtName.Text;
                receiveInfo.phone = txtPhone.Text;
                receiveInfo.address = txtAddress.Text;
                ReceiveInfoDAO.Update(receiveInfo);
                MessageBox.Show("Update successfully");
                Close(); 
            }
        }
    }
}
