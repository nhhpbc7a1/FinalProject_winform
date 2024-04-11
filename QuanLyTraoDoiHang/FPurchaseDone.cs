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
    public partial class FPurchaseDone : Form
    {
        public FPurchaseDone(int totalPrice)
        {
            InitializeComponent();
            lblTotalPrice.Text = totalPrice.ToString();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            Program.mainpage.OpenChildForm(new FormCart());
            this.Close();
        }

        private void btnMyPurchases_Click(object sender, EventArgs e)
        {
            PersonalInfor p = new PersonalInfor();
            p.OpenChildForm(new ViewHistory());
            Program.mainpage.OpenChildForm(p);
            this.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Program.mainpage.OpenChildForm(new FormProduct());
            this.Close();

        }
    }
}
