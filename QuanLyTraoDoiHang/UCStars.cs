using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTraoDoiHang
{
    public partial class UCStars : UserControl
    {
        double numStar = 5;
        public int userId = -1;
        public bool canChanged = false;
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

            pnlRating.Controls.Add(comboBoxNum);
            pnlRating.Controls.Add(lblNumStar);

            comboBoxNum.SelectedIndex = 4;

            comboBoxNum.SelectedIndexChanged += ComboBoxNum_SelectedIndexChanged;

            this.Load += UCStars_Load;
            UCStars_Load(null, null);
        }

        public void UCStars_Load(object? sender, EventArgs e)
        {
            if (userId == -1)
            {
                lblNumStar.Text = comboBoxNum.Text.ToString();
                lblNumStar.Visible = true;
                comboBoxNum.Visible = false;
                comboBoxNum.Enabled = false;
                return;
            }
            DataTable ratings = RatingDAO.SellectBySellerId(userId);
            double avgRating = 0;
            foreach (DataRow row in ratings.Rows)
            {
                Rating x = RatingDAO.RowToRating(row);
                avgRating += x.marks;
            }
            double tmp = ratings.Rows.Count;

            lblNumStar.Text = (avgRating / tmp).ToString();
            lblNumStar.Visible = true;

            if (canChanged == false)
            {
                comboBoxNum.Text = (avgRating / tmp).ToString();
                comboBoxNum.Visible = false;
                comboBoxNum.Enabled = false;
            }
            else
            {
            }
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

            pnlRating.Controls.Add(comboBoxNum);
            pnlRating.Controls.Add(lblNumStar);

        }
    }
}