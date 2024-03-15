using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace QuanLyTraoDoiHang
{
    public partial class UCDropDownMenu : UserControl
    {
        public UCDropDownMenu()
        {
            InitializeComponent();
        }

        private void btnDropDown_Click(object sender, EventArgs e)
        {

        }

        private void btnDropDown_Click_1(object sender, EventArgs e)
        {

        }
        bool expand = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                fPanelDropDown.Height += 300;
                if (fPanelDropDown.Height >= fPanelDropDown.MaximumSize.Height)
                {
                    timer1.Stop();
                    expand = true;
                }
            }
            else
            {
                fPanelDropDown.Height -= 250;
                if (fPanelDropDown.Height <= fPanelDropDown.MinimumSize.Height)
                {
                    timer1.Stop();
                    expand = false;
                }
            }
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {

        }

        private void btnDropDown_Click_2(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void rButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void fPanelDropDown_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
