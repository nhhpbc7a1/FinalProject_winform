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
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnCheckOut = new RButton();
            lblTotalProductPrice = new Label();
            lblTotalShippingFee = new Label();
            lblProducPrice = new Label();
            lblTotalPrice = new Label();
            lblShipping = new Label();
            lblTotal = new Label();
            panel4 = new Panel();
            panel1 = new Panel();
            pnlProducts = new FlowLayoutPanel();
            label2 = new Label();
            panel2 = new Panel();
            btnChangeReceiveInfo = new RButton();
            lblAddressDelivery = new Label();
            lblPhoneDelivery = new Label();
            lblNameDelivery = new Label();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnCheckOut);
            panel3.Controls.Add(lblTotalProductPrice);
            panel3.Controls.Add(lblTotalShippingFee);
            panel3.Controls.Add(lblProducPrice);
            panel3.Controls.Add(lblTotalPrice);
            panel3.Controls.Add(lblShipping);
            panel3.Controls.Add(lblTotal);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 465);
            panel3.Name = "panel3";
            panel3.Size = new Size(982, 96);
            panel3.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(483, 38);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(19, 21);
            label4.TabIndex = 66;
            label4.Text = "đ";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(181, 40);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(19, 21);
            label3.TabIndex = 65;
            label3.Text = "đ";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(666, 50);
            label1.Name = "label1";
            label1.Size = new Size(17, 27);
            label1.TabIndex = 64;
            label1.Text = "đ";
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.FromArgb(231, 41, 41);
            btnCheckOut.BackgroundColor = Color.FromArgb(231, 41, 41);
            btnCheckOut.BorderColor = Color.White;
            btnCheckOut.BorderRadius = 10;
            btnCheckOut.BorderSize = 1;
            btnCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.Location = new Point(810, 19);
            btnCheckOut.Margin = new Padding(1);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(150, 55);
            btnCheckOut.TabIndex = 53;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.TextColor = Color.White;
            btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // lblTotalProductPrice
            // 
            lblTotalProductPrice.AutoSize = true;
            lblTotalProductPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalProductPrice.ForeColor = Color.White;
            lblTotalProductPrice.Location = new Point(200, 40);
            lblTotalProductPrice.Name = "lblTotalProductPrice";
            lblTotalProductPrice.RightToLeft = RightToLeft.Yes;
            lblTotalProductPrice.Size = new Size(70, 21);
            lblTotalProductPrice.TabIndex = 55;
            lblTotalProductPrice.Text = "1000000";
            lblTotalProductPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalShippingFee
            // 
            lblTotalShippingFee.AutoSize = true;
            lblTotalShippingFee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalShippingFee.ForeColor = Color.White;
            lblTotalShippingFee.Location = new Point(497, 38);
            lblTotalShippingFee.Name = "lblTotalShippingFee";
            lblTotalShippingFee.RightToLeft = RightToLeft.No;
            lblTotalShippingFee.Size = new Size(79, 21);
            lblTotalShippingFee.TabIndex = 57;
            lblTotalShippingFee.Text = "10000000";
            lblTotalShippingFee.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblProducPrice
            // 
            lblProducPrice.AutoSize = true;
            lblProducPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProducPrice.ForeColor = Color.White;
            lblProducPrice.Location = new Point(12, 40);
            lblProducPrice.Name = "lblProducPrice";
            lblProducPrice.Size = new Size(174, 21);
            lblProducPrice.TabIndex = 54;
            lblProducPrice.Text = "Merchandise Subtotal:";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPrice.ForeColor = Color.Yellow;
            lblTotalPrice.Location = new Point(679, 50);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(89, 25);
            lblTotalPrice.TabIndex = 59;
            lblTotalPrice.Text = "1000000";
            lblTotalPrice.Click += lblTotalPrice_Click;
            // 
            // lblShipping
            // 
            lblShipping.AutoSize = true;
            lblShipping.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblShipping.ForeColor = Color.White;
            lblShipping.Location = new Point(339, 34);
            lblShipping.Name = "lblShipping";
            lblShipping.Size = new Size(149, 27);
            lblShipping.TabIndex = 56;
            lblShipping.Text = "Total Shipping Fee:";
            lblShipping.TextAlign = ContentAlignment.BottomRight;
            lblShipping.UseCompatibleTextRendering = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(645, 19);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(146, 31);
            lblTotal.TabIndex = 58;
            lblTotal.Text = "Total Payment:";
            lblTotal.TextAlign = ContentAlignment.BottomRight;
            lblTotal.UseCompatibleTextRendering = true;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel1);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(960, 455);
            panel4.TabIndex = 61;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(pnlProducts);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(100, 18);
            panel1.Margin = new Padding(3, 15, 3, 3);
            panel1.MaximumSize = new Size(751, 10000);
            panel1.MinimumSize = new Size(751, 440);
            panel1.Name = "panel1";
            panel1.Size = new Size(751, 440);
            panel1.TabIndex = 1;
            // 
            // pnlProducts
            // 
            pnlProducts.AutoSize = true;
            pnlProducts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlProducts.BackColor = SystemColors.ControlLight;
            pnlProducts.Location = new Point(15, 109);
            pnlProducts.MaximumSize = new Size(719, 10000);
            pnlProducts.MinimumSize = new Size(719, 200);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(719, 200);
            pnlProducts.TabIndex = 25;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(15, 6);
            label2.Name = "label2";
            label2.Size = new Size(159, 23);
            label2.TabIndex = 3;
            label2.Text = "Delivery Address";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(btnChangeReceiveInfo);
            panel2.Controls.Add(lblAddressDelivery);
            panel2.Controls.Add(lblPhoneDelivery);
            panel2.Controls.Add(lblNameDelivery);
            panel2.Location = new Point(13, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(725, 71);
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
            btnChangeReceiveInfo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnChangeReceiveInfo.ForeColor = Color.Black;
            btnChangeReceiveInfo.Location = new Point(616, 13);
            btnChangeReceiveInfo.Name = "btnChangeReceiveInfo";
            btnChangeReceiveInfo.Size = new Size(82, 45);
            btnChangeReceiveInfo.TabIndex = 3;
            btnChangeReceiveInfo.Text = "Edit";
            btnChangeReceiveInfo.TextColor = Color.Black;
            btnChangeReceiveInfo.UseVisualStyleBackColor = false;
            // 
            // lblAddressDelivery
            // 
            lblAddressDelivery.AutoSize = true;
            lblAddressDelivery.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddressDelivery.ForeColor = SystemColors.ControlText;
            lblAddressDelivery.Location = new Point(14, 37);
            lblAddressDelivery.Name = "lblAddressDelivery";
            lblAddressDelivery.Size = new Size(66, 21);
            lblAddressDelivery.TabIndex = 2;
            lblAddressDelivery.Text = "Address";
            // 
            // lblPhoneDelivery
            // 
            lblPhoneDelivery.AutoSize = true;
            lblPhoneDelivery.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhoneDelivery.Location = new Point(264, 13);
            lblPhoneDelivery.Name = "lblPhoneDelivery";
            lblPhoneDelivery.Size = new Size(126, 21);
            lblPhoneDelivery.TabIndex = 1;
            lblPhoneDelivery.Text = "Phone Number";
            // 
            // lblNameDelivery
            // 
            lblNameDelivery.AutoSize = true;
            lblNameDelivery.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameDelivery.Location = new Point(14, 13);
            lblNameDelivery.Name = "lblNameDelivery";
            lblNameDelivery.Size = new Size(56, 21);
            lblNameDelivery.TabIndex = 0;
            lblNameDelivery.Text = "Name";
            // 
            // FCheckOut
            // 
            AccessibleRole = AccessibleRole.Row;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(982, 561);
            Controls.Add(panel3);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FCheckOut";
            Text = "FCheckOut";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTotalProductPrice;
        private Label lblProducPrice;
        private Label lblTotalShippingFee;
        private Label lblShipping;
        private Label lblTotalPrice;
        private Label lblTotal;
        private RJControls.RButton btnCheckOut;
        private Panel panel3;
        private Label label1;
        private Label label4;
        private Label label3;
        private Panel panel4;
        private Panel panel1;
        private Label label2;
        public FlowLayoutPanel pnlProducts;
        private Panel panel2;
        private RButton btnChangeReceiveInfo;
        private Label lblAddressDelivery;
        private Label lblPhoneDelivery;
        private Label lblNameDelivery;
    }
}