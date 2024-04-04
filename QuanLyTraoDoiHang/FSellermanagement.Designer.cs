﻿using QuanLyTraoDoiHang.RJControls;

namespace QuanLyTraoDoiHang
{
    partial class FSellermanagement
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSellermanagement));
            pnlSellerTool = new Panel();
            rButton2 = new RButton();
            pnlProducts = new FlowLayoutPanel();
            pnlMenu = new Panel();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            lblAction = new Label();
            lblTotalPrice = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            pnlDropDownnn = new Panel();
            btnReturned = new RButton();
            btnCancelled = new RButton();
            btnMyOrder = new RButton();
            btnOrder = new RButton();
            pnlDropDownProdu = new Panel();
            btnAddProduct = new RButton();
            btnMyProducts = new RButton();
            btnProducts = new RButton();
            panel1 = new Panel();
            btnDataAnalysis = new RButton();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnShipment = new RButton();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            pnlSellerTool.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlDropDownnn.SuspendLayout();
            pnlDropDownProdu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSellerTool
            // 
            pnlSellerTool.BackColor = Color.White;
            pnlSellerTool.Controls.Add(rButton2);
            pnlSellerTool.Controls.Add(pnlProducts);
            pnlSellerTool.Controls.Add(pnlMenu);
            pnlSellerTool.Location = new Point(216, 90);
            pnlSellerTool.Margin = new Padding(1);
            pnlSellerTool.Name = "pnlSellerTool";
            pnlSellerTool.RightToLeft = RightToLeft.Yes;
            pnlSellerTool.Size = new Size(758, 465);
            pnlSellerTool.TabIndex = 2;
            // 
            // rButton2
            // 
            rButton2.BackColor = Color.FromArgb(30, 106, 17);
            rButton2.BackgroundColor = Color.FromArgb(30, 106, 17);
            rButton2.BorderColor = Color.PaleVioletRed;
            rButton2.BorderRadius = 35;
            rButton2.BorderSize = 0;
            rButton2.FlatAppearance.BorderSize = 0;
            rButton2.FlatStyle = FlatStyle.Flat;
            rButton2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rButton2.ForeColor = Color.White;
            rButton2.Location = new Point(301, 410);
            rButton2.Name = "rButton2";
            rButton2.Size = new Size(168, 40);
            rButton2.TabIndex = 22;
            rButton2.Text = "Update";
            rButton2.TextColor = Color.White;
            rButton2.UseVisualStyleBackColor = false;
            // 
            // pnlProducts
            // 
            pnlProducts.BackColor = SystemColors.ControlLight;
            pnlProducts.Location = new Point(16, 59);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(725, 336);
            pnlProducts.TabIndex = 21;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(101, 183, 65);
            pnlMenu.Controls.Add(label4);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Controls.Add(label3);
            pnlMenu.Controls.Add(lblAction);
            pnlMenu.Controls.Add(lblTotalPrice);
            pnlMenu.Location = new Point(16, 24);
            pnlMenu.Margin = new Padding(1);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(725, 31);
            pnlMenu.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(14, 5);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 21);
            label4.TabIndex = 20;
            label4.Text = "Your product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(528, 5);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 18;
            label1.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(359, 5);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 17;
            label3.Text = "Status";
            // 
            // lblAction
            // 
            lblAction.AutoSize = true;
            lblAction.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAction.ForeColor = Color.White;
            lblAction.Location = new Point(639, 5);
            lblAction.Margin = new Padding(1, 0, 1, 0);
            lblAction.Name = "lblAction";
            lblAction.Size = new Size(58, 21);
            lblAction.TabIndex = 16;
            lblAction.Text = "Action";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPrice.ForeColor = Color.White;
            lblTotalPrice.Location = new Point(194, 5);
            lblTotalPrice.Margin = new Padding(1, 0, 1, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(85, 21);
            lblTotalPrice.TabIndex = 15;
            lblTotalPrice.Text = "Total Price";
            // 
            // timer1
            // 
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 15;
            timer2.Tick += timer2_Tick;
            // 
            // pnlDropDownnn
            // 
            pnlDropDownnn.Controls.Add(btnReturned);
            pnlDropDownnn.Controls.Add(btnCancelled);
            pnlDropDownnn.Controls.Add(btnMyOrder);
            pnlDropDownnn.Controls.Add(btnOrder);
            pnlDropDownnn.Dock = DockStyle.Top;
            pnlDropDownnn.Location = new Point(0, 0);
            pnlDropDownnn.MaximumSize = new Size(156, 162);
            pnlDropDownnn.MinimumSize = new Size(156, 40);
            pnlDropDownnn.Name = "pnlDropDownnn";
            pnlDropDownnn.Size = new Size(156, 40);
            pnlDropDownnn.TabIndex = 2;
            // 
            // btnReturned
            // 
            btnReturned.BackColor = Color.FromArgb(155, 207, 83);
            btnReturned.BackgroundColor = Color.FromArgb(155, 207, 83);
            btnReturned.BorderColor = Color.PaleVioletRed;
            btnReturned.BorderRadius = 10;
            btnReturned.BorderSize = 0;
            btnReturned.Dock = DockStyle.Top;
            btnReturned.FlatAppearance.BorderSize = 0;
            btnReturned.FlatStyle = FlatStyle.Flat;
            btnReturned.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturned.ForeColor = Color.White;
            btnReturned.Location = new Point(0, 120);
            btnReturned.MaximumSize = new Size(156, 40);
            btnReturned.Name = "btnReturned";
            btnReturned.Size = new Size(156, 40);
            btnReturned.TabIndex = 6;
            btnReturned.Text = "Returned orders";
            btnReturned.TextColor = Color.White;
            btnReturned.UseVisualStyleBackColor = false;
            btnReturned.Click += btnReturned_Click;
            // 
            // btnCancelled
            // 
            btnCancelled.BackColor = Color.FromArgb(155, 207, 83);
            btnCancelled.BackgroundColor = Color.FromArgb(155, 207, 83);
            btnCancelled.BorderColor = Color.PaleVioletRed;
            btnCancelled.BorderRadius = 10;
            btnCancelled.BorderSize = 0;
            btnCancelled.Dock = DockStyle.Top;
            btnCancelled.FlatAppearance.BorderSize = 0;
            btnCancelled.FlatStyle = FlatStyle.Flat;
            btnCancelled.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelled.ForeColor = Color.White;
            btnCancelled.Location = new Point(0, 80);
            btnCancelled.Name = "btnCancelled";
            btnCancelled.Size = new Size(156, 40);
            btnCancelled.TabIndex = 5;
            btnCancelled.Text = "Cancelled orders";
            btnCancelled.TextColor = Color.White;
            btnCancelled.UseVisualStyleBackColor = false;
            btnCancelled.Click += btnCancelled_Click;
            // 
            // btnMyOrder
            // 
            btnMyOrder.BackColor = Color.FromArgb(155, 207, 83);
            btnMyOrder.BackgroundColor = Color.FromArgb(155, 207, 83);
            btnMyOrder.BorderColor = Color.PaleVioletRed;
            btnMyOrder.BorderRadius = 10;
            btnMyOrder.BorderSize = 0;
            btnMyOrder.Dock = DockStyle.Top;
            btnMyOrder.FlatAppearance.BorderSize = 0;
            btnMyOrder.FlatStyle = FlatStyle.Flat;
            btnMyOrder.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMyOrder.ForeColor = Color.White;
            btnMyOrder.Location = new Point(0, 40);
            btnMyOrder.Name = "btnMyOrder";
            btnMyOrder.Size = new Size(156, 40);
            btnMyOrder.TabIndex = 4;
            btnMyOrder.Text = "My orders";
            btnMyOrder.TextColor = Color.White;
            btnMyOrder.UseVisualStyleBackColor = false;
            btnMyOrder.Click += btnMyOrder_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(30, 106, 17);
            btnOrder.BackgroundColor = Color.FromArgb(30, 106, 17);
            btnOrder.BorderColor = Color.PaleVioletRed;
            btnOrder.BorderRadius = 10;
            btnOrder.BorderSize = 0;
            btnOrder.Dock = DockStyle.Top;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrder.ForeColor = Color.White;
            btnOrder.Image = Properties.Resources.icons8_down_161;
            btnOrder.Location = new Point(0, 0);
            btnOrder.Name = "btnOrder";
            btnOrder.RightToLeft = RightToLeft.No;
            btnOrder.Size = new Size(156, 40);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "   Order  ";
            btnOrder.TextAlign = ContentAlignment.MiddleRight;
            btnOrder.TextColor = Color.White;
            btnOrder.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // pnlDropDownProdu
            // 
            pnlDropDownProdu.Controls.Add(btnAddProduct);
            pnlDropDownProdu.Controls.Add(btnMyProducts);
            pnlDropDownProdu.Controls.Add(btnProducts);
            pnlDropDownProdu.Dock = DockStyle.Top;
            pnlDropDownProdu.Location = new Point(0, 40);
            pnlDropDownProdu.MaximumSize = new Size(156, 120);
            pnlDropDownProdu.MinimumSize = new Size(156, 40);
            pnlDropDownProdu.Name = "pnlDropDownProdu";
            pnlDropDownProdu.Size = new Size(156, 40);
            pnlDropDownProdu.TabIndex = 7;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(155, 207, 83);
            btnAddProduct.BackgroundColor = Color.FromArgb(155, 207, 83);
            btnAddProduct.BorderColor = Color.PaleVioletRed;
            btnAddProduct.BorderRadius = 10;
            btnAddProduct.BorderSize = 0;
            btnAddProduct.Dock = DockStyle.Top;
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(0, 80);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(156, 40);
            btnAddProduct.TabIndex = 5;
            btnAddProduct.Text = "Add new product";
            btnAddProduct.TextColor = Color.White;
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnMyProducts
            // 
            btnMyProducts.BackColor = Color.FromArgb(155, 207, 83);
            btnMyProducts.BackgroundColor = Color.FromArgb(155, 207, 83);
            btnMyProducts.BorderColor = Color.PaleVioletRed;
            btnMyProducts.BorderRadius = 10;
            btnMyProducts.BorderSize = 0;
            btnMyProducts.Dock = DockStyle.Top;
            btnMyProducts.FlatAppearance.BorderSize = 0;
            btnMyProducts.FlatStyle = FlatStyle.Flat;
            btnMyProducts.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMyProducts.ForeColor = Color.White;
            btnMyProducts.Location = new Point(0, 40);
            btnMyProducts.Name = "btnMyProducts";
            btnMyProducts.Size = new Size(156, 40);
            btnMyProducts.TabIndex = 4;
            btnMyProducts.Text = "My products";
            btnMyProducts.TextColor = Color.White;
            btnMyProducts.UseVisualStyleBackColor = false;
            btnMyProducts.Click += btnMyProducts_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(30, 106, 17);
            btnProducts.BackgroundColor = Color.FromArgb(30, 106, 17);
            btnProducts.BorderColor = Color.PaleVioletRed;
            btnProducts.BorderRadius = 10;
            btnProducts.BorderSize = 0;
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProducts.ForeColor = Color.White;
            btnProducts.Image = Properties.Resources.icons8_down_16;
            btnProducts.Location = new Point(0, 0);
            btnProducts.Name = "btnProducts";
            btnProducts.RightToLeft = RightToLeft.No;
            btnProducts.Size = new Size(156, 40);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = ContentAlignment.MiddleRight;
            btnProducts.TextColor = Color.White;
            btnProducts.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnDataAnalysis);
            panel1.Controls.Add(pnlDropDownProdu);
            panel1.Controls.Add(pnlDropDownnn);
            panel1.Location = new Point(29, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 338);
            panel1.TabIndex = 3;
            // 
            // btnDataAnalysis
            // 
            btnDataAnalysis.BackColor = Color.FromArgb(30, 106, 17);
            btnDataAnalysis.BackgroundColor = Color.FromArgb(30, 106, 17);
            btnDataAnalysis.BorderColor = Color.PaleVioletRed;
            btnDataAnalysis.BorderRadius = 10;
            btnDataAnalysis.BorderSize = 0;
            btnDataAnalysis.Dock = DockStyle.Top;
            btnDataAnalysis.FlatAppearance.BorderSize = 0;
            btnDataAnalysis.FlatStyle = FlatStyle.Flat;
            btnDataAnalysis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDataAnalysis.ForeColor = Color.White;
            btnDataAnalysis.Location = new Point(0, 80);
            btnDataAnalysis.Name = "btnDataAnalysis";
            btnDataAnalysis.Size = new Size(156, 40);
            btnDataAnalysis.TabIndex = 8;
            btnDataAnalysis.Text = "Data Analysis";
            btnDataAnalysis.TextColor = Color.White;
            btnDataAnalysis.UseVisualStyleBackColor = false;
            btnDataAnalysis.Click += btnDataAnalysis_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 94);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(244, 237, 204);
            panel2.Controls.Add(btnShipment);
            panel2.Location = new Point(29, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(156, 39);
            panel2.TabIndex = 7;
            // 
            // btnShipment
            // 
            btnShipment.BackColor = Color.FromArgb(30, 106, 17);
            btnShipment.BackgroundColor = Color.FromArgb(30, 106, 17);
            btnShipment.BorderColor = Color.PaleVioletRed;
            btnShipment.BorderRadius = 10;
            btnShipment.BorderSize = 0;
            btnShipment.Dock = DockStyle.Top;
            btnShipment.FlatAppearance.BorderSize = 0;
            btnShipment.FlatStyle = FlatStyle.Flat;
            btnShipment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnShipment.ForeColor = Color.White;
            btnShipment.Location = new Point(0, 0);
            btnShipment.Name = "btnShipment";
            btnShipment.Size = new Size(156, 40);
            btnShipment.TabIndex = 9;
            btnShipment.Text = "My Shipment";
            btnShipment.TextColor = Color.White;
            btnShipment.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(216, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(758, 85);
            panel3.TabIndex = 8;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 30);
            label2.Name = "label2";
            label2.Size = new Size(240, 30);
            label2.TabIndex = 59;
            label2.Text = "Content";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(6, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 549);
            panel4.TabIndex = 9;
            // 
            // FSellermanagement
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(984, 561);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pnlSellerTool);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1);
            Name = "FSellermanagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FSellermanagement";
            pnlSellerTool.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlDropDownnn.ResumeLayout(false);
            pnlDropDownProdu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlSellerTool;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Panel pnlDropDownnn;
        private RJControls.RButton btnReturned;
        private RJControls.RButton btnCancelled;
        private RJControls.RButton btnMyOrder;
        private RJControls.RButton btnOrder;
        private Panel pnlDropDownProdu;
        private RJControls.RButton btnAddProduct;
        private RJControls.RButton btnMyProducts;
        private RJControls.RButton btnProducts;
        private Panel panel1;
        private RJControls.RButton btnDataAnalysis;
        private PictureBox pictureBox1;
        private Panel panel2;
        private RJControls.RButton btnShipment;
        private Panel pnlMenu;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label lblAction;
        private Label lblTotalPrice;
        private FlowLayoutPanel pnlProducts;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private RButton rButton2;
    }
}