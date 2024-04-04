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
    public partial class ucReceiveAddressItem : UserControl
    {
        public ReceiveInfo receiveInfo = null;
        public int indexChoose;
        public ucReceiveAddressItem()
        {
            InitializeComponent();
            lblUpdate.Click += LblUpdate_Click;
            Load += UcReceiveAddressItem_Load;
            foreach (Control c in this.Controls)
                c.Click += C_Click;
            Click += C_Click;
        }

        private void C_Click(object? sender, EventArgs e)
        {
            checkChoose.Checked = true;
        }

        private void UcReceiveAddressItem_Load(object? sender, EventArgs e)
        {
            if (receiveInfo != null)
            {
                lblName.Text = receiveInfo.name;
                lblPhone.Text = receiveInfo.phone;
                lblAddress.Text = receiveInfo.address;
            }
        }

        public void LblUpdate_Click(object? sender, EventArgs e)
        {
            FormAddReceiveInfo x = new FormAddReceiveInfo();
            x.receiveInfo = receiveInfo;
            x.ShowDialog();
            UcReceiveAddressItem_Load(sender, e);

        }
    }
}
