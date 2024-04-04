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
    public partial class FormReceiveAddress : Form
    {
        public int indexChoose;
        public FormReceiveAddress()
        {
            InitializeComponent();
            Load += FormReceiveAddress_Load;
            btnAddAddress.Click += BtnAddAddress_Click;
        }
        private void BtnAddAddress_Click(object? sender, EventArgs e)
        {
            FormAddReceiveInfo x = new FormAddReceiveInfo();
            x.ShowDialog();
            FormReceiveAddress_Load(sender, e);
        }

        private void FormReceiveAddress_Load(object? sender, EventArgs e)
        {
            DataTable dt = ReceiveInfoDAO.Load();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dataRow = dt.Rows[i];
                ReceiveInfo info = ReceiveInfoDAO.RowToReceiveInfo(dataRow);
                ucReceiveAddressItem x = new ucReceiveAddressItem();
                x.indexChoose = i;

                foreach (Control control in x.Controls)
                    control.Click += CheckChoose_Click;
                x.Click += CheckChoose_Click;

                x.receiveInfo = info;
                pnlAddresses.Controls.Add(x);
            }
        }


        private void CheckChoose_Click(object? sender, EventArgs e)
        {
            
            foreach (ucReceiveAddressItem x in pnlAddresses.Controls)
            {
                if (x.checkChoose.Checked == true && x.indexChoose != this.indexChoose)
                {
                    indexChoose = x.indexChoose;
                    break;
                }
            }
            foreach (ucReceiveAddressItem x in pnlAddresses.Controls)
                if (x.indexChoose != indexChoose)
                    x.checkChoose.Checked = false;
                    
        }
    }
}
