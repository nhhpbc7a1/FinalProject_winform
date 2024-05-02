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
    public partial class FormShowSellerList : Form
    {
        public FormShowSellerList()
        {
            InitializeComponent();
            
            flowLayoutPanel.Controls.Clear();
            DataTable x = UserDAO.LoadAll();
            foreach(DataRow dr in x.Rows) 
            { 
                User user = UserDAO.RowToUser(dr);
                UCSeller_Show tmp = new UCSeller_Show(user);
                flowLayoutPanel.Controls.Add(tmp);
            }
            //flowLayoutPanel.
        }
    }
}
