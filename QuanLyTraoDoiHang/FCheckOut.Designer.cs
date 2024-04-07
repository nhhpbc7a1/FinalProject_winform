using QuanLyTraoDoiHang.RJControls;

namespace QuanLyTraoDoiHang
{
    partial class FCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCheckOut));
            panel1 = new Panel();
            label = new Label();
            panel2 = new Panel();
            btnChangeReceiveInfo = new RButton();
            lblAddressDelivery = new Label();
            lblPhoneDelivery = new Label();
            lblNameDelivery = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            btnCheckOut = new RButton();
            lblTotalProductPrice = new Label();
            lblTotalShippingFee = new Label();
            lblProducPrice = new Label();
            lblTotalPrice = new Label();
            lblShipping = new Label();
            lblTotal = new Label();
            panel5 = new Panel();
            pnlProducts = new FlowLayoutPanel();
            pnlMenu = new Panel();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            pnlMenu.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 90, 12);
            panel1.Controls.Add(label);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(128, 15);
            panel1.Margin = new Padding(3, 15, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 127);
            panel1.TabIndex = 0;
            // 
            // label
            // 
            label.AutoSize = true;
            label.FlatStyle = FlatStyle.System;
            label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label.ForeColor = Color.FromArgb(255, 255, 192);
            label.Location = new Point(15, 12);
            label.Name = "label";
            label.Size = new Size(113, 17);
            label.TabIndex = 2;
            label.Text = "Delivery Address";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(btnChangeReceiveInfo);
            panel2.Controls.Add(lblAddressDelivery);
            panel2.Controls.Add(lblPhoneDelivery);
            panel2.Controls.Add(lblNameDelivery);
            panel2.Location = new Point(15, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(701, 71);
            panel2.TabIndex = 1;
            // 
            // btnChangeReceiveInfo
            // 
            btnChangeReceiveInfo.BackColor = SystemColors.ButtonHighlight;
            btnChangeReceiveInfo.BackgroundColor = SystemColors.ButtonHighlight;
            btnChangeReceiveInfo.BorderColor = Color.PeachPuff;
            btnChangeReceiveInfo.BorderRadius = 20;
            btnChangeReceiveInfo.BorderSize = 0;
            btnChangeReceiveInfo.FlatAppearance.BorderSize = 0;
            btnChangeReceiveInfo.FlatStyle = FlatStyle.Flat;
            btnChangeReceiveInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnChangeReceiveInfo.ForeColor = Color.SteelBlue;
            btnChangeReceiveInfo.Location = new Point(616, 4);
            btnChangeReceiveInfo.Name = "btnChangeReceiveInfo";
            btnChangeReceiveInfo.Size = new Size(69, 64);
            btnChangeReceiveInfo.TabIndex = 3;
            btnChangeReceiveInfo.Text = "change";
            btnChangeReceiveInfo.TextColor = Color.SteelBlue;
            btnChangeReceiveInfo.UseVisualStyleBackColor = false;
            // 
            // lblAddressDelivery
            // 
            lblAddressDelivery.AutoSize = true;
            lblAddressDelivery.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddressDelivery.Location = new Point(14, 37);
            lblAddressDelivery.Name = "lblAddressDelivery";
            lblAddressDelivery.Size = new Size(66, 21);
            lblAddressDelivery.TabIndex = 2;
            lblAddressDelivery.Text = "Address";
            // 
            // lblPhoneDelivery
            // 
            lblPhoneDelivery.AutoSize = true;
            lblPhoneDelivery.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPhoneDelivery.Location = new Point(245, 13);
            lblPhoneDelivery.Name = "lblPhoneDelivery";
            lblPhoneDelivery.Size = new Size(113, 20);
            lblPhoneDelivery.TabIndex = 1;
            lblPhoneDelivery.Text = "Phone Number";
            // 
            // lblNameDelivery
            // 
            lblNameDelivery.AutoSize = true;
            lblNameDelivery.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameDelivery.Location = new Point(14, 13);
            lblNameDelivery.Name = "lblNameDelivery";
            lblNameDelivery.Size = new Size(50, 20);
            lblNameDelivery.TabIndex = 0;
            lblNameDelivery.Text = "Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(246, 250, 200);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btnCheckOut);
            panel3.Controls.Add(lblTotalProductPrice);
            panel3.Controls.Add(lblTotalShippingFee);
            panel3.Controls.Add(lblProducPrice);
            panel3.Controls.Add(lblTotalPrice);
            panel3.Controls.Add(lblShipping);
            panel3.Controls.Add(lblTotal);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 529);
            panel3.Name = "panel3";
            panel3.Size = new Size(984, 172);
            panel3.TabIndex = 60;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(87, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 142);
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.FromArgb(231, 41, 41);
            btnCheckOut.BackgroundColor = Color.FromArgb(231, 41, 41);
            btnCheckOut.BorderColor = Color.White;
            btnCheckOut.BorderRadius = 20;
            btnCheckOut.BorderSize = 1;
            btnCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.Location = new Point(819, 117);
            btnCheckOut.Margin = new Padding(1);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(111, 37);
            btnCheckOut.TabIndex = 53;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.TextColor = Color.White;
            btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // lblTotalProductPrice
            // 
            lblTotalProductPrice.AutoSize = true;
            lblTotalProductPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalProductPrice.Location = new Point(798, 15);
            lblTotalProductPrice.Name = "lblTotalProductPrice";
            lblTotalProductPrice.Size = new Size(137, 21);
            lblTotalProductPrice.TabIndex = 55;
            lblTotalProductPrice.Text = "Merchandise Price";
            // 
            // lblTotalShippingFee
            // 
            lblTotalShippingFee.AutoSize = true;
            lblTotalShippingFee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalShippingFee.Location = new Point(820, 48);
            lblTotalShippingFee.Name = "lblTotalShippingFee";
            lblTotalShippingFee.Size = new Size(110, 21);
            lblTotalShippingFee.TabIndex = 57;
            lblTotalShippingFee.Text = "Shipping Price";
            // 
            // lblProducPrice
            // 
            lblProducPrice.AutoSize = true;
            lblProducPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProducPrice.Location = new Point(611, 15);
            lblProducPrice.Name = "lblProducPrice";
            lblProducPrice.Size = new Size(164, 21);
            lblProducPrice.TabIndex = 54;
            lblProducPrice.Text = "Merchandise Subtotal:";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPrice.Location = new Point(850, 84);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(80, 21);
            lblTotalPrice.TabIndex = 59;
            lblTotalPrice.Text = "Total Price";
            // 
            // lblShipping
            // 
            lblShipping.AutoSize = true;
            lblShipping.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblShipping.Location = new Point(611, 48);
            lblShipping.Name = "lblShipping";
            lblShipping.Size = new Size(105, 27);
            lblShipping.TabIndex = 56;
            lblShipping.Text = "Shiping Total:";
            lblShipping.TextAlign = ContentAlignment.BottomRight;
            lblShipping.UseCompatibleTextRendering = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.IndianRed;
            lblTotal.Location = new Point(611, 84);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 27);
            lblTotal.TabIndex = 58;
            lblTotal.Text = "Total:";
            lblTotal.TextAlign = ContentAlignment.BottomRight;
            lblTotal.UseCompatibleTextRendering = true;
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.Controls.Add(pnlProducts);
            panel5.Controls.Add(pnlMenu);
            panel5.Location = new Point(128, 148);
            panel5.MaximumSize = new Size(725, 10000);
            panel5.MinimumSize = new Size(725, 200);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(30, 0, 0, 0);
            panel5.Size = new Size(725, 244);
            panel5.TabIndex = 53;
            // 
            // pnlProducts
            // 
            pnlProducts.AutoSize = true;
            pnlProducts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlProducts.BackColor = Color.White;
            pnlProducts.Location = new Point(4, 41);
            pnlProducts.MaximumSize = new Size(719, 10000);
            pnlProducts.MinimumSize = new Size(719, 200);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(719, 200);
            pnlProducts.TabIndex = 25;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(30, 90, 12);
            pnlMenu.Controls.Add(label4);
            pnlMenu.Controls.Add(label3);
            pnlMenu.Controls.Add(label5);
            pnlMenu.Location = new Point(4, 6);
            pnlMenu.Margin = new Padding(1);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(719, 31);
            pnlMenu.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(33, 4);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 21);
            label4.TabIndex = 19;
            label4.Text = "Your product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(352, 4);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 17;
            label3.Text = "Condition";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(630, 4);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 15;
            label5.Text = "Price";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(125, 0, 0, 0);
            flowLayoutPanel1.Size = new Size(984, 529);
            flowLayoutPanel1.TabIndex = 54;
            // 
            // FCheckOut
            // 
            AccessibleRole = AccessibleRole.Row;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(984, 701);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Name = "FCheckOut";
            Text = "FCheckOut";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblPhoneDelivery;
        private Panel panel2;
        private Label lblNameDelivery;
        private Label label;
        private RJControls.RButton btnChangeReceiveInfo;
        private Label lblTotalProductPrice;
        private Label lblProducPrice;
        private Label lblTotalShippingFee;
        private Label lblShipping;
        private Label lblTotalPrice;
        private Label lblTotal;
        private RJControls.RButton btnCheckOut;
        private Panel panel5;
        public FlowLayoutPanel pnlProducts;
        private Panel pnlMenu;
        private Label label4;
        private Label label3;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label lblAddressDelivery;
    }
}