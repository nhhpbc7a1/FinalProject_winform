namespace QuanLyTraoDoiHang
{
    partial class FormCart
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
            pnlMenu = new Panel();
            label1 = new Label();
            lblAction = new Label();
            lblTotalPrice = new Label();
            chBProducts = new CheckBox();
            pnlCheckOut = new Panel();
            rBCheckout = new RJControls.RButton();
            lblCheckOutPrice = new Label();
            lblItemWriting = new Label();
            lblPriceCheckOut = new Label();
            lblItemsCart = new Label();
            cBPay = new CheckBox();
            panel1 = new Panel();
            ucCartProduct1 = new UCCartProduct();
            pnlMenu.SuspendLayout();
            pnlCheckOut.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(97, 150, 166);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Controls.Add(lblAction);
            pnlMenu.Controls.Add(lblTotalPrice);
            pnlMenu.Controls.Add(chBProducts);
            pnlMenu.Location = new Point(102, 68);
            pnlMenu.Margin = new Padding(2);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1853, 82);
            pnlMenu.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(1177, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 54);
            label1.TabIndex = 17;
            label1.Text = "Status";
            label1.Click += label1_Click_1;
            // 
            // lblAction
            // 
            lblAction.AutoSize = true;
            lblAction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAction.ForeColor = SystemColors.Control;
            lblAction.Location = new Point(1528, 14);
            lblAction.Margin = new Padding(2, 0, 2, 0);
            lblAction.Name = "lblAction";
            lblAction.Size = new Size(154, 54);
            lblAction.TabIndex = 16;
            lblAction.Text = "Actions";
            lblAction.Click += lblAction_Click_1;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPrice.ForeColor = SystemColors.Control;
            lblTotalPrice.Location = new Point(774, 14);
            lblTotalPrice.Margin = new Padding(2, 0, 2, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(203, 54);
            lblTotalPrice.TabIndex = 15;
            lblTotalPrice.Text = "Total Price";
            lblTotalPrice.Click += lblTotalPrice_Click_1;
            // 
            // chBProducts
            // 
            chBProducts.AutoSize = true;
            chBProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chBProducts.ForeColor = SystemColors.Control;
            chBProducts.Location = new Point(49, 10);
            chBProducts.Margin = new Padding(2);
            chBProducts.Name = "chBProducts";
            chBProducts.Size = new Size(305, 58);
            chBProducts.TabIndex = 12;
            chBProducts.Text = "Your Products";
            chBProducts.UseVisualStyleBackColor = true;
            // 
            // pnlCheckOut
            // 
            pnlCheckOut.BackColor = Color.FromArgb(177, 148, 112);
            pnlCheckOut.Controls.Add(rBCheckout);
            pnlCheckOut.Controls.Add(lblCheckOutPrice);
            pnlCheckOut.Controls.Add(lblItemWriting);
            pnlCheckOut.Controls.Add(lblPriceCheckOut);
            pnlCheckOut.Controls.Add(lblItemsCart);
            pnlCheckOut.Controls.Add(cBPay);
            pnlCheckOut.Location = new Point(0, 920);
            pnlCheckOut.Margin = new Padding(2);
            pnlCheckOut.Name = "pnlCheckOut";
            pnlCheckOut.Size = new Size(2072, 222);
            pnlCheckOut.TabIndex = 12;
            // 
            // rBCheckout
            // 
            rBCheckout.BackColor = Color.LightCoral;
            rBCheckout.BackgroundColor = Color.LightCoral;
            rBCheckout.BorderColor = Color.PaleVioletRed;
            rBCheckout.BorderRadius = 20;
            rBCheckout.BorderSize = 0;
            rBCheckout.FlatAppearance.BorderSize = 0;
            rBCheckout.FlatStyle = FlatStyle.Flat;
            rBCheckout.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            rBCheckout.ForeColor = Color.Black;
            rBCheckout.Location = new Point(1641, 62);
            rBCheckout.Name = "rBCheckout";
            rBCheckout.Size = new Size(270, 100);
            rBCheckout.TabIndex = 10;
            rBCheckout.Text = "Check Out";
            rBCheckout.TextColor = Color.Black;
            rBCheckout.UseVisualStyleBackColor = false;
            // 
            // lblCheckOutPrice
            // 
            lblCheckOutPrice.AutoSize = true;
            lblCheckOutPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCheckOutPrice.ForeColor = SystemColors.ButtonHighlight;
            lblCheckOutPrice.Location = new Point(1472, 86);
            lblCheckOutPrice.Name = "lblCheckOutPrice";
            lblCheckOutPrice.Size = new Size(81, 54);
            lblCheckOutPrice.TabIndex = 22;
            lblCheckOutPrice.Text = "0 đ";
            // 
            // lblItemWriting
            // 
            lblItemWriting.AutoSize = true;
            lblItemWriting.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblItemWriting.ForeColor = SystemColors.ButtonHighlight;
            lblItemWriting.Location = new Point(900, 84);
            lblItemWriting.Name = "lblItemWriting";
            lblItemWriting.Size = new Size(46, 54);
            lblItemWriting.TabIndex = 21;
            lblItemWriting.Text = "0";
            // 
            // lblPriceCheckOut
            // 
            lblPriceCheckOut.AutoSize = true;
            lblPriceCheckOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPriceCheckOut.ForeColor = SystemColors.Control;
            lblPriceCheckOut.Location = new Point(1213, 86);
            lblPriceCheckOut.Margin = new Padding(2, 0, 2, 0);
            lblPriceCheckOut.Name = "lblPriceCheckOut";
            lblPriceCheckOut.Size = new Size(230, 54);
            lblPriceCheckOut.TabIndex = 19;
            lblPriceCheckOut.Text = "Total Price:";
            // 
            // lblItemsCart
            // 
            lblItemsCart.AutoSize = true;
            lblItemsCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemsCart.ForeColor = SystemColors.Control;
            lblItemsCart.Location = new Point(622, 86);
            lblItemsCart.Margin = new Padding(2, 0, 2, 0);
            lblItemsCart.Name = "lblItemsCart";
            lblItemsCart.Size = new Size(273, 54);
            lblItemsCart.TabIndex = 18;
            lblItemsCart.Text = "Total Item(s):";
            lblItemsCart.Click += lblItemsCart_Click;
            // 
            // cBPay
            // 
            cBPay.AutoSize = true;
            cBPay.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            cBPay.ForeColor = Color.Bisque;
            cBPay.Location = new Point(151, 86);
            cBPay.Name = "cBPay";
            cBPay.Size = new Size(222, 54);
            cBPay.TabIndex = 0;
            cBPay.Text = "Select All";
            cBPay.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ucCartProduct1);
            panel1.Location = new Point(102, 209);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1841, 877);
            panel1.TabIndex = 14;
            // 
            // ucCartProduct1
            // 
            ucCartProduct1.BackColor = Color.FromArgb(244, 237, 204);
            ucCartProduct1.Location = new Point(48, 44);
            ucCartProduct1.Margin = new Padding(2);
            ucCartProduct1.Name = "ucCartProduct1";
            ucCartProduct1.Size = new Size(1720, 229);
            ucCartProduct1.TabIndex = 0;
            // 
            // FormCart
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 206, 149);
            ClientSize = new Size(2060, 1134);
            Controls.Add(pnlCheckOut);
            Controls.Add(pnlMenu);
            Controls.Add(panel1);
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCart";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlCheckOut.ResumeLayout(false);
            pnlCheckOut.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlMenu;
        private CheckBox chBProducts;
        private Label lblAction;
        private Label lblTotalPrice;
        private Label label1;
        private Panel pnlCheckOut;
        private Panel panel1;
        private UCCartProduct ucCartProduct1;
        private CheckBox cBPay;
        private Label lblPriceCheckOut;
        private Label lblItemsCart;
        private Label lblItemWriting;
        private Label lblCheckOutPrice;
        private RJControls.RButton rBCheckout;
    }
}