﻿namespace QuanLyTraoDoiHang
{
    partial class FormInShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInShop));
            this.pnlThisSellerPage = new System.Windows.Forms.Panel();
            this.lblDateJoined = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblSellerPhone = new System.Windows.Forms.Label();
            this.lblSellerAddress = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.ptbSellerImage = new System.Windows.Forms.PictureBox();
            this.pnlItems = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewRating = new QuanLyTraoDoiHang.RJControls.RButton();
            this.btnViewProducts = new QuanLyTraoDoiHang.RJControls.RButton();
            this.ucStars1 = new QuanLyTraoDoiHang.UCStars();
            this.pnlThisSellerPage.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSellerImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThisSellerPage
            // 
            this.pnlThisSellerPage.BackColor = System.Drawing.Color.White;
            this.pnlThisSellerPage.Controls.Add(this.ucStars1);
            this.pnlThisSellerPage.Controls.Add(this.lblDateJoined);
            this.pnlThisSellerPage.Controls.Add(this.panel6);
            this.pnlThisSellerPage.Controls.Add(this.lblSellerAddress);
            this.pnlThisSellerPage.Controls.Add(this.label11);
            this.pnlThisSellerPage.Controls.Add(this.pictureBox10);
            this.pnlThisSellerPage.Controls.Add(this.lblSellerName);
            this.pnlThisSellerPage.Controls.Add(this.ptbSellerImage);
            this.pnlThisSellerPage.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.pnlThisSellerPage.Location = new System.Drawing.Point(12, 12);
            this.pnlThisSellerPage.Name = "pnlThisSellerPage";
            this.pnlThisSellerPage.Size = new System.Drawing.Size(942, 85);
            this.pnlThisSellerPage.TabIndex = 4;
            // 
            // lblDateJoined
            // 
            this.lblDateJoined.AutoSize = true;
            this.lblDateJoined.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateJoined.Location = new System.Drawing.Point(543, 38);
            this.lblDateJoined.Name = "lblDateJoined";
            this.lblDateJoined.Size = new System.Drawing.Size(42, 21);
            this.lblDateJoined.TabIndex = 19;
            this.lblDateJoined.Text = "Date";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(149)))));
            this.panel6.Controls.Add(this.pictureBox8);
            this.panel6.Controls.Add(this.lblSellerPhone);
            this.panel6.Location = new System.Drawing.Point(294, 23);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(152, 35);
            this.panel6.TabIndex = 13;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(12, 4);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 29);
            this.pictureBox8.TabIndex = 2;
            this.pictureBox8.TabStop = false;
            // 
            // lblSellerPhone
            // 
            this.lblSellerPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSellerPhone.AutoSize = true;
            this.lblSellerPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSellerPhone.ForeColor = System.Drawing.Color.White;
            this.lblSellerPhone.Location = new System.Drawing.Point(49, 9);
            this.lblSellerPhone.Name = "lblSellerPhone";
            this.lblSellerPhone.Size = new System.Drawing.Size(89, 19);
            this.lblSellerPhone.TabIndex = 0;
            this.lblSellerPhone.Text = "0783701185";
            // 
            // lblSellerAddress
            // 
            this.lblSellerAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSellerAddress.ForeColor = System.Drawing.Color.Black;
            this.lblSellerAddress.Location = new System.Drawing.Point(682, 23);
            this.lblSellerAddress.Name = "lblSellerAddress";
            this.lblSellerAddress.Size = new System.Drawing.Size(191, 52);
            this.lblSellerAddress.TabIndex = 18;
            this.lblSellerAddress.Text = "Location: Cao Lanh City, Dong Thap, Viet Nam";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(487, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 21);
            this.label11.TabIndex = 16;
            this.label11.Text = "Joined: ";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(645, 11);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(31, 27);
            this.pictureBox10.TabIndex = 17;
            this.pictureBox10.TabStop = false;
            // 
            // lblSellerName
            // 
            this.lblSellerName.AutoSize = true;
            this.lblSellerName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSellerName.Location = new System.Drawing.Point(86, 20);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(130, 20);
            this.lblSellerName.TabIndex = 6;
            this.lblSellerName.Text = "Hoang Ha Mobile";
            // 
            // ptbSellerImage
            // 
            this.ptbSellerImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbSellerImage.BackgroundImage")));
            this.ptbSellerImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbSellerImage.Location = new System.Drawing.Point(17, 14);
            this.ptbSellerImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbSellerImage.Name = "ptbSellerImage";
            this.ptbSellerImage.Size = new System.Drawing.Size(63, 61);
            this.ptbSellerImage.TabIndex = 4;
            this.ptbSellerImage.TabStop = false;
            // 
            // pnlItems
            // 
            this.pnlItems.AutoSize = true;
            this.pnlItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlItems.Location = new System.Drawing.Point(49, 180);
            this.pnlItems.MaximumSize = new System.Drawing.Size(882, 100000);
            this.pnlItems.MinimumSize = new System.Drawing.Size(882, 330);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(882, 330);
            this.pnlItems.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewRating);
            this.panel1.Controls.Add(this.btnViewProducts);
            this.panel1.Location = new System.Drawing.Point(12, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 71);
            this.panel1.TabIndex = 6;
            // 
            // btnViewRating
            // 
            this.btnViewRating.BackColor = System.Drawing.Color.LightCoral;
            this.btnViewRating.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btnViewRating.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnViewRating.BorderRadius = 20;
            this.btnViewRating.BorderSize = 0;
            this.btnViewRating.FlatAppearance.BorderSize = 0;
            this.btnViewRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRating.ForeColor = System.Drawing.Color.White;
            this.btnViewRating.Location = new System.Drawing.Point(487, 14);
            this.btnViewRating.Name = "btnViewRating";
            this.btnViewRating.Size = new System.Drawing.Size(150, 40);
            this.btnViewRating.TabIndex = 0;
            this.btnViewRating.Text = "View Rating";
            this.btnViewRating.TextColor = System.Drawing.Color.White;
            this.btnViewRating.UseVisualStyleBackColor = false;
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.BackColor = System.Drawing.Color.LightCoral;
            this.btnViewProducts.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btnViewProducts.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnViewProducts.BorderRadius = 20;
            this.btnViewProducts.BorderSize = 0;
            this.btnViewProducts.FlatAppearance.BorderSize = 0;
            this.btnViewProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProducts.ForeColor = System.Drawing.Color.White;
            this.btnViewProducts.Location = new System.Drawing.Point(295, 14);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(150, 40);
            this.btnViewProducts.TabIndex = 0;
            this.btnViewProducts.Text = "View products";
            this.btnViewProducts.TextColor = System.Drawing.Color.White;
            this.btnViewProducts.UseVisualStyleBackColor = false;
            // 
            // ucStars1
            // 
            this.ucStars1.Location = new System.Drawing.Point(86, 38);
            this.ucStars1.Name = "ucStars1";
            this.ucStars1.Size = new System.Drawing.Size(195, 37);
            this.ucStars1.TabIndex = 20;
            // 
            // FormInShop
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(966, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.pnlThisSellerPage);
            this.Name = "FormInShop";
            this.Text = "FormInShop";
            this.pnlThisSellerPage.ResumeLayout(false);
            this.pnlThisSellerPage.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSellerImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Panel pnlThisSellerPage;
        private Label lblDateJoined;
        private Panel panel6;
        private PictureBox pictureBox8;
        private Label lblSellerPhone;
        private Label lblSellerAddress;
        private Label label11;
        private PictureBox pictureBox10;
        private Label lblSellerName;
        private PictureBox ptbSellerImage;
        private FlowLayoutPanel pnlItems;
        private Panel panel1;
        private RJControls.RButton btnViewRating;
        private RJControls.RButton btnViewProducts;
        private UCStars ucStars1;
    }
}