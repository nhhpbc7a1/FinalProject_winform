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
    public partial class Regisiter : Form
    {
        public Regisiter()
        {
            InitializeComponent();
            dtBirthday.CustomFormat = " 'Birthday' ";
            dtBirthday.Format = DateTimePickerFormat.Custom;
            

        }

      
        private void btnBackRegister_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.ShowDialog();
           
        }

        private void dtBirthday_ValueChanged(object sender, EventArgs e)
        {
            dtBirthday.CustomFormat = "dd/MM/yyyy ";
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
