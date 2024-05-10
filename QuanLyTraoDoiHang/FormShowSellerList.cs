using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace QuanLyTraoDoiHang
{
    public partial class FormShowSellerList : Form
    {
        public FormShowSellerList()
        {
            InitializeComponent();

            flowLayoutPanel.Controls.Clear();
            DataTable x = UserDAO.LoadAll();
            List<UCSeller_Show> list = new List<UCSeller_Show>();

            foreach (DataRow c in x.Rows)
            {
                User user1 = UserDAO.RowToUser(c);
                UCSeller_Show tmp1 = new UCSeller_Show(user1);
                list.Add(tmp1);
            }
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i; j < list.Count; j++)
                {
                    if (list[i].ucStars1.numStar > list[j].ucStars1.numStar)
                    {
                        UCSeller_Show tam = list[i];
                        list[i] = list[j];
                        list[j] = tam;
                    }
                }
            }
            foreach (UCSeller_Show c in list)
            {
                flowLayoutPanel.Controls.Add(c);
            }
        }
        private void rButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
