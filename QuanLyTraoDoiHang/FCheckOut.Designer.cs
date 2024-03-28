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
            panel1 = new Panel();
            lblAddressDelivery = new Label();
            panel2 = new Panel();
            rButton1 = new RJControls.RButton();
            lblAddressDeliver = new Label();
            label1 = new Label();
            lblNameDelivery = new Label();
            panel3 = new Panel();
            dUDShipping = new DomainUpDown();
            lblShippingType = new Label();
            textBox1 = new TextBox();
            lblCustomerNote = new Label();
            ucCartProduct1 = new UCCartProduct();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 96, 176);
            panel1.Controls.Add(lblAddressDelivery);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(134, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 97);
            panel1.TabIndex = 0;
            // 
            // lblAddressDelivery
            // 
            lblAddressDelivery.AutoSize = true;
            lblAddressDelivery.FlatStyle = FlatStyle.System;
            lblAddressDelivery.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddressDelivery.ForeColor = Color.FromArgb(255, 255, 192);
            lblAddressDelivery.Location = new Point(15, 12);
            lblAddressDelivery.Name = "lblAddressDelivery";
            lblAddressDelivery.Size = new Size(113, 17);
            lblAddressDelivery.TabIndex = 2;
            lblAddressDelivery.Text = "Delivery Address";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(rButton1);
            panel2.Controls.Add(lblAddressDeliver);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblNameDelivery);
            panel2.Location = new Point(15, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(701, 62);
            panel2.TabIndex = 1;
            // 
            // rButton1
            // 
            rButton1.BackColor = SystemColors.ButtonHighlight;
            rButton1.BackgroundColor = SystemColors.ButtonHighlight;
            rButton1.BorderColor = Color.PeachPuff;
            rButton1.BorderRadius = 20;
            rButton1.BorderSize = 0;
            rButton1.FlatAppearance.BorderSize = 0;
            rButton1.FlatStyle = FlatStyle.Flat;
            rButton1.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            rButton1.ForeColor = Color.SteelBlue;
            rButton1.Location = new Point(619, 13);
            rButton1.Name = "rButton1";
            rButton1.Size = new Size(69, 40);
            rButton1.TabIndex = 3;
            rButton1.Text = "change";
            rButton1.TextColor = Color.SteelBlue;
            rButton1.UseVisualStyleBackColor = false;
            // 
            // lblAddressDeliver
            // 
            lblAddressDeliver.AutoSize = true;
            lblAddressDeliver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddressDeliver.Location = new Point(223, 22);
            lblAddressDeliver.Name = "lblAddressDeliver";
            lblAddressDeliver.Size = new Size(66, 21);
            lblAddressDeliver.TabIndex = 2;
            lblAddressDeliver.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(73, 22);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 1;
            label1.Text = "Phone Number";
            // 
            // lblNameDelivery
            // 
            lblNameDelivery.AutoSize = true;
            lblNameDelivery.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameDelivery.Location = new Point(17, 22);
            lblNameDelivery.Name = "lblNameDelivery";
            lblNameDelivery.Size = new Size(50, 20);
            lblNameDelivery.TabIndex = 0;
            lblNameDelivery.Text = "Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(246, 227, 197);
            panel3.Controls.Add(dUDShipping);
            panel3.Controls.Add(lblShippingType);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(lblCustomerNote);
            panel3.Location = new Point(134, 549);
            panel3.Name = "panel3";
            panel3.Size = new Size(726, 82);
            panel3.TabIndex = 2;
            // 
            // dUDShipping
            // 
            dUDShipping.BorderStyle = BorderStyle.FixedSingle;
            dUDShipping.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dUDShipping.Location = new Point(509, 34);
            dUDShipping.Margin = new Padding(1);
            dUDShipping.Name = "dUDShipping";
            dUDShipping.ReadOnly = true;
            dUDShipping.RightToLeft = RightToLeft.No;
            dUDShipping.Size = new Size(122, 25);
            dUDShipping.TabIndex = 51;
            dUDShipping.Text = "(Type)";
            // 
            // lblShippingType
            // 
            lblShippingType.AutoSize = true;
            lblShippingType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblShippingType.Location = new Point(372, 34);
            lblShippingType.Name = "lblShippingType";
            lblShippingType.Size = new Size(124, 21);
            lblShippingType.TabIndex = 6;
            lblShippingType.Text = "Shipping Option";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(66, 31);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "Note for seller";
            // 
            // lblCustomerNote
            // 
            lblCustomerNote.AutoSize = true;
            lblCustomerNote.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerNote.Location = new Point(16, 33);
            lblCustomerNote.Name = "lblCustomerNote";
            lblCustomerNote.Size = new Size(44, 21);
            lblCustomerNote.TabIndex = 4;
            lblCustomerNote.Text = "Note";
            lblCustomerNote.Click += lblCustomerNote_Click;
            // 
            // ucCartProduct1
            // 
            ucCartProduct1.AutoSize = true;
            ucCartProduct1.BackColor = Color.FromArgb(164, 206, 149);
            ucCartProduct1.Location = new Point(122, 127);
            ucCartProduct1.Margin = new Padding(1);
            ucCartProduct1.Name = "ucCartProduct1";
            ucCartProduct1.Size = new Size(742, 451);
            ucCartProduct1.TabIndex = 3;
            ucCartProduct1.Load += ucCartProduct1_Load;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(246, 250, 200);
            panel4.Controls.Add(rBCheckout);
            panel4.Controls.Add(lblTotalPrice);
            panel4.Controls.Add(lblTotal);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(lblShipping);
            panel4.Controls.Add(lblPriceProduct);
            panel4.Controls.Add(lblProducPrice);
            panel4.Location = new Point(134, 602);
            panel4.Name = "panel4";
            panel4.Size = new Size(730, 69);
            panel4.TabIndex = 52;
            // 
            // dUDPaymentType
            // 
            dUDPaymentType.BorderStyle = BorderStyle.FixedSingle;
            dUDPaymentType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dUDPaymentType.Location = new Point(508, 38);
            dUDPaymentType.Margin = new Padding(1);
            dUDPaymentType.Name = "dUDPaymentType";
            dUDPaymentType.ReadOnly = true;
            dUDPaymentType.RightToLeft = RightToLeft.No;
            dUDPaymentType.Size = new Size(122, 25);
            dUDPaymentType.TabIndex = 53;
            dUDPaymentType.Text = "(Type)";
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPayment.Location = new Point(354, 42);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(122, 21);
            lblPayment.TabIndex = 52;
            lblPayment.Text = "Payment Option";
            // 
            // lblProducPrice
            // 
            lblProducPrice.AutoSize = true;
            lblProducPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProducPrice.Location = new Point(3, 10);
            lblProducPrice.Name = "lblProducPrice";
            lblProducPrice.Size = new Size(164, 21);
            lblProducPrice.TabIndex = 54;
            lblProducPrice.Text = "Merchandise Subtotal:";
            // 
            // lblPriceProduct
            // 
            lblPriceProduct.AutoSize = true;
            lblPriceProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPriceProduct.Location = new Point(115, 31);
            lblPriceProduct.Name = "lblPriceProduct";
            lblPriceProduct.Size = new Size(137, 21);
            lblPriceProduct.TabIndex = 55;
            lblPriceProduct.Text = "Merchandise Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(335, 31);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 57;
            label2.Text = "Shipping Price";
            label2.Click += label2_Click;
            // 
            // lblShipping
            // 
            lblShipping.AutoSize = true;
            lblShipping.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblShipping.Location = new Point(238, 4);
            lblShipping.Name = "lblShipping";
            lblShipping.Size = new Size(105, 27);
            lblShipping.TabIndex = 56;
            lblShipping.Text = "Shiping Total:";
            lblShipping.TextAlign = ContentAlignment.BottomRight;
            lblShipping.UseCompatibleTextRendering = true;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPrice.Location = new Point(511, 31);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(80, 21);
            lblTotalPrice.TabIndex = 59;
            lblTotalPrice.Text = "Total Price";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.IndianRed;
            lblTotal.Location = new Point(463, 10);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 27);
            lblTotal.TabIndex = 58;
            lblTotal.Text = "Total:";
            lblTotal.TextAlign = ContentAlignment.BottomRight;
            lblTotal.UseCompatibleTextRendering = true;
            // 
            // rBCheckout
            // 
            rBCheckout.BackColor = Color.FromArgb(231, 41, 41);
            rBCheckout.BackgroundColor = Color.FromArgb(231, 41, 41);
            rBCheckout.BorderColor = Color.White;
            rBCheckout.BorderRadius = 20;
            rBCheckout.BorderSize = 1;
            rBCheckout.FlatAppearance.BorderSize = 0;
            rBCheckout.FlatStyle = FlatStyle.Flat;
            rBCheckout.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            rBCheckout.ForeColor = Color.White;
            rBCheckout.Location = new Point(605, 15);
            rBCheckout.Margin = new Padding(1);
            rBCheckout.Name = "rBCheckout";
            rBCheckout.Size = new Size(111, 37);
            rBCheckout.TabIndex = 53;
            rBCheckout.Text = "Check Out";
            rBCheckout.TextColor = Color.White;
            rBCheckout.UseVisualStyleBackColor = false;
            // 
            // FCheckOut
            // 
            AccessibleRole = AccessibleRole.Row;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(164, 206, 149);
            ClientSize = new Size(984, 701);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(ucCartProduct1);
            Name = "FCheckOut";
            Text = "FCheckOut";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblAddressDelivery;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label lblNameDelivery;
        private UCCartProduct ucCartProduct1;
        private Label lblAddressDeliver;
        private RJControls.RButton rButton1;
        private Label lblCustomerNote;
        private TextBox textBox1;
        private Label lblShippingType;
        public DomainUpDown dUDShipping;
    }
}