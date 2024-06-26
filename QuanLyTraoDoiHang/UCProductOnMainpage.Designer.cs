﻿namespace QuanLyTraoDoiHang
{
    partial class UCProductOnMainpage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProductOnMainpage));
            ptbImage = new PictureBox();
            lblName = new Label();
            lblPrice = new Label();
            btnBuyNow = new RJControls.RButton();
            label1 = new Label();
            lblOriginalPrice = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ucStars1 = new UCStars();
            lblDateStart = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ptbImage).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ptbImage
            // 
            ptbImage.BackgroundImage = (Image)resources.GetObject("ptbImage.BackgroundImage");
            ptbImage.BackgroundImageLayout = ImageLayout.Stretch;
            ptbImage.BorderStyle = BorderStyle.FixedSingle;
            ptbImage.Dock = DockStyle.Top;
            ptbImage.Location = new Point(0, 0);
            ptbImage.Margin = new Padding(3, 2, 3, 2);
            ptbImage.Name = "ptbImage";
            ptbImage.Size = new Size(200, 148);
            ptbImage.TabIndex = 0;
            ptbImage.TabStop = false;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(4, 150);
            lblName.Name = "lblName";
            lblName.Size = new Size(194, 65);
            lblName.TabIndex = 1;
            lblName.Text = "Product's name";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Red;
            lblPrice.Location = new Point(14, 0);
            lblPrice.Margin = new Padding(0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(71, 24);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "10.500";
            // 
            // btnBuyNow
            // 
            btnBuyNow.BackColor = Color.FromArgb(231, 41, 41);
            btnBuyNow.BackgroundColor = Color.FromArgb(231, 41, 41);
            btnBuyNow.BorderColor = Color.PaleVioletRed;
            btnBuyNow.BorderRadius = 15;
            btnBuyNow.BorderSize = 0;
            btnBuyNow.FlatAppearance.BorderSize = 0;
            btnBuyNow.FlatStyle = FlatStyle.Flat;
            btnBuyNow.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuyNow.ForeColor = Color.White;
            btnBuyNow.Location = new Point(115, 272);
            btnBuyNow.Name = "btnBuyNow";
            btnBuyNow.Size = new Size(73, 30);
            btnBuyNow.TabIndex = 5;
            btnBuyNow.Text = "Buy now";
            btnBuyNow.TextColor = Color.White;
            btnBuyNow.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 10);
            label1.Margin = new Padding(0, 10, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 6;
            label1.Text = "đ";
            // 
            // lblOriginalPrice
            // 
            lblOriginalPrice.AutoSize = true;
            lblOriginalPrice.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Strikeout, GraphicsUnit.Point);
            lblOriginalPrice.ForeColor = SystemColors.ControlDarkDark;
            lblOriginalPrice.Location = new Point(99, 4);
            lblOriginalPrice.Margin = new Padding(0, 4, 0, 0);
            lblOriginalPrice.Name = "lblOriginalPrice";
            lblOriginalPrice.Size = new Size(49, 16);
            lblOriginalPrice.TabIndex = 6;
            lblOriginalPrice.Text = "100000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(85, 10);
            label2.Margin = new Padding(0, 10, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 6;
            label2.Text = "đ";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(lblPrice);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(lblOriginalPrice);
            flowLayoutPanel1.Location = new Point(4, 218);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(196, 33);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // ucStars1
            // 
            ucStars1.Location = new Point(4, 242);
            ucStars1.Name = "ucStars1";
            ucStars1.Size = new Size(195, 29);
            ucStars1.TabIndex = 8;
            // 
            // lblDateStart
            // 
            lblDateStart.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateStart.ForeColor = SystemColors.ControlDarkDark;
            lblDateStart.Location = new Point(9, 281);
            lblDateStart.Name = "lblDateStart";
            lblDateStart.Size = new Size(40, 18);
            lblDateStart.TabIndex = 6;
            lblDateStart.Text = "1000";
            lblDateStart.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(48, 284);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 6;
            label3.Text = "days ago";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(199, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 164);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 164);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(1, 311);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 1);
            panel3.TabIndex = 12;
            // 
            // UCProductOnMainpage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(ucStars1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(btnBuyNow);
            Controls.Add(lblDateStart);
            Controls.Add(lblName);
            Controls.Add(ptbImage);
            Margin = new Padding(4, 4, 15, 4);
            Name = "UCProductOnMainpage";
            Size = new Size(200, 312);
            ((System.ComponentModel.ISupportInitialize)ptbImage).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public PictureBox ptbImage;
        public Label lblName;
        public Label lblPrice;
        private RJControls.RButton btnBuyNow;
        private Label label1;
        private Label lblOriginalPrice;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private UCStars ucStars1;
        private Label lblDateStart;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}