﻿using System;
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
    public partial class ViewHistory : Form
    {
        public ViewHistory()
        {
            InitializeComponent();
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            btnShip.BorderSize = 2;
            btnShip.BorderColor = Color.FromArgb(52, 255, 46);
        }

        private void ucMyPurchase2_Load(object sender, EventArgs e)
        {

        }
    }
}
