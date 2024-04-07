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
    public partial class FProductDetail : Form
    {
        public FProductDetail()
        {
            InitializeComponent();
            btnBack.Click += btnBack_Click;
            btnViewPage.Click += btnViewPage_Click;
            Load += FProductDetail_Load;
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }
        public Product currentProduct = new Product();
        private void FProductDetail_Load(object sender, EventArgs e)
        {
            ptbImage.BackgroundImage = currentProduct.image;
            lblName.Text = currentProduct.name;
            lblPrice.Text = currentProduct.price.ToString();
            lblOriginalPrice.Text = currentProduct.originalPrice.ToString();
            lblWarrantyPolicy.Text = currentProduct.warrantyPolicy.ToString();
            lblBrand.Text = currentProduct.brand.ToString();
            lblCondition.Text = currentProduct.condition.ToString();
            lblBought.Text = currentProduct.dateBought.ToString();
            richTextBoxDescription.Text = currentProduct.description;
            //seller info
            User seller = UserDAO.SelectByUserId(currentProduct.sellerId);
            lblSellerName.Text = seller.name;
            ptbSellerImage.BackgroundImage = seller.image;
            lblSellerAddress.Text = seller.address;
            lblDateJoined.Text = seller.dateJoined.ToString();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void btnViewPage_Click(object sender, EventArgs e)
        {
            Program.mainpage.OpenChildForm(new FormInShop(UserDAO.SelectByUserId(currentProduct.sellerId)));
        }
    }
}
