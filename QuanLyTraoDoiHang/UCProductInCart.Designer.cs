﻿namespace QuanLyTraoDoiHang
{
    partial class UCProductInCart
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
            lblPrice = new Label();
            cbChoose = new CheckBox();
            panel1 = new Panel();
            lblProductName = new Label();
            pbProductImage = new PictureBox();
            btnCancel = new RJControls.RButton();
            lblCondition = new Label();
            lblOldPrice = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Red;
            lblPrice.Location = new Point(472, 58);
            lblPrice.Margin = new Padding(1, 0, 1, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(47, 21);
            lblPrice.TabIndex = 47;
            lblPrice.Text = "price";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbChoose
            // 
            cbChoose.AutoSize = true;
            cbChoose.Location = new Point(16, 51);
            cbChoose.Margin = new Padding(1);
            cbChoose.Name = "cbChoose";
            cbChoose.Size = new Size(15, 14);
            cbChoose.TabIndex = 49;
            cbChoose.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(pbProductImage);
            panel1.Location = new Point(33, 23);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 74);
            panel1.TabIndex = 50;
            // 
            // lblProductName
            // 
            lblProductName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductName.Location = new Point(70, 12);
            lblProductName.Margin = new Padding(1, 0, 1, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(125, 56);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "(name)";
            // 
            // pbProductImage
            // 
            pbProductImage.BackColor = SystemColors.Control;
            pbProductImage.BackgroundImageLayout = ImageLayout.Stretch;
            pbProductImage.Location = new Point(4, 5);
            pbProductImage.Margin = new Padding(1);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(64, 63);
            pbProductImage.TabIndex = 10;
            pbProductImage.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.BackgroundColor = Color.FromArgb(255, 128, 128);
            btnCancel.BorderColor = Color.PaleVioletRed;
            btnCancel.BorderRadius = 20;
            btnCancel.BorderSize = 0;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(600, 38);
            btnCancel.Margin = new Padding(1);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 40);
            btnCancel.TabIndex = 51;
            btnCancel.Text = "Delete";
            btnCancel.TextColor = Color.White;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblCondition
            // 
            lblCondition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCondition.Location = new Point(246, 35);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(198, 62);
            lblCondition.TabIndex = 52;
            lblCondition.Text = "condition of product";
            lblCondition.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblOldPrice
            // 
            lblOldPrice.AutoSize = true;
            lblOldPrice.Font = new Font("Segoe UI", 12F, FontStyle.Strikeout, GraphicsUnit.Point);
            lblOldPrice.Location = new Point(472, 35);
            lblOldPrice.Name = "lblOldPrice";
            lblOldPrice.Size = new Size(73, 21);
            lblOldPrice.TabIndex = 53;
            lblOldPrice.Text = "Old price";
            lblOldPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(236, 29);
            label1.Name = "label1";
            label1.Size = new Size(197, 62);
            label1.TabIndex = 54;
            label1.Text = "condition of product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(459, 61);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(16, 17);
            label2.TabIndex = 55;
            label2.Text = "đ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(459, 38);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(16, 17);
            label3.TabIndex = 56;
            label3.Text = "đ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UCProductInCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblOldPrice);
            Controls.Add(lblCondition);
            Controls.Add(lblPrice);
            Controls.Add(cbChoose);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Margin = new Padding(0);
            Name = "UCProductInCart";
            Size = new Size(715, 121);
            Load += UCProductInCart_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lblPrice;
        public CheckBox cbChoose;
        public Panel panel1;
        public Label lblProductName;
        public PictureBox pbProductImage;
        public RJControls.RButton btnCancel;
        private Label lblCondition;
        private Label lblOldPrice;
        private Label label1;
        public Label label2;
        public Label label3;
    }
}
