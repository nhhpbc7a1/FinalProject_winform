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
    public partial class UCStars : UserControl
    {
        double numStar = 5;
        public UCStars()
        {
            InitializeComponent();
            
            pnlRating.Controls.Clear();
            if (numStar >= 1)
                pnlRating.Controls.Add(picStar1);
            if (numStar >= 2)
                pnlRating.Controls.Add(picStar2);
            if (numStar >= 3)
                pnlRating.Controls.Add(picStar3);
            if (numStar >= 4)
                pnlRating.Controls.Add(picStar4);
            if (numStar >= 5)
                pnlRating.Controls.Add(picStar5);

            comboBoxNum.SelectedIndex = 4;

            comboBoxNum.SelectedIndexChanged += ComboBoxNum_SelectedIndexChanged;
        }

        private void ComboBoxNum_SelectedIndexChanged(object? sender, EventArgs e)
        {
            numStar = Convert.ToDouble(comboBoxNum.Text);
            pnlRating.Controls.Clear();
            if (numStar >= 1)
                pnlRating.Controls.Add(picStar1);
            if (numStar >= 2)
                pnlRating.Controls.Add(picStar2);
            if (numStar >= 3)
                pnlRating.Controls.Add(picStar3);
            if (numStar >= 4)
                pnlRating.Controls.Add(picStar4);
            if (numStar >= 5)
                pnlRating.Controls.Add(picStar5);


        }
    }
}
