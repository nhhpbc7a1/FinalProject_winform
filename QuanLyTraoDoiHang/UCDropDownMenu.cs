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

      
       
        bool expand = false;


      
        private void rButton1_Click(object sender, EventArgs e)
        {
            if (pnlOptions.Visible == false)
            {
                pnlOptions.Visible = true;
            }
            else pnlOptions.Visible = false;
        }
        private void HideOptions()
        {
            if (pnlOptions.Visible == true)
            {
                pnlOptions.Visible = false;
            }
        }
        private void fPanelDropDown_Paint(object sender, PaintEventArgs e)
        {

        }

      
      

      
        private void UCDropDownMenu_Load(object sender, EventArgs e)
        {
            pnlOptions.Visible = false;
        }

        private void rButton1_Click_2(object sender, EventArgs e)
        {

            HideOptions();

        }

        private void rButton2_Click_1(object sender, EventArgs e)
        {
            HideOptions();

        }

        private void rButton3_Click(object sender, EventArgs e)
        {
            HideOptions();

        }
    }
}
