
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
            pnlCheckOut = new Panel();
            label2 = new Label();
            rBCheckout = new RJControls.RButton();
            lblCheckOutPrice = new Label();
            lblItemWriting = new Label();
            lblPriceCheckOut = new Label();
            lblItemsCart = new Label();
            cBPay = new CheckBox();
            ucCartProducts = new UCCartProduct();
            pnlCheckOut.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCheckOut
            // 
            pnlCheckOut.BackColor = Color.FromArgb(182, 115, 82);
            pnlCheckOut.Controls.Add(label2);
            pnlCheckOut.Controls.Add(rBCheckout);
            pnlCheckOut.Controls.Add(lblCheckOutPrice);
            pnlCheckOut.Controls.Add(lblItemWriting);
            pnlCheckOut.Controls.Add(lblPriceCheckOut);
            pnlCheckOut.Controls.Add(lblItemsCart);
            pnlCheckOut.Controls.Add(cBPay);
            pnlCheckOut.Dock = DockStyle.Bottom;
            pnlCheckOut.Location = new Point(0, 467);
            pnlCheckOut.Margin = new Padding(1);
            pnlCheckOut.Name = "pnlCheckOut";
            pnlCheckOut.Size = new Size(984, 94);
            pnlCheckOut.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(623, 31);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(19, 21);
            label2.TabIndex = 23;
            label2.Text = "đ";
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
            rBCheckout.Location = new Point(782, 24);
            rBCheckout.Margin = new Padding(1);
            rBCheckout.Name = "rBCheckout";
            rBCheckout.Size = new Size(111, 37);
            rBCheckout.TabIndex = 10;
            rBCheckout.Text = "Check Out";
            rBCheckout.TextColor = Color.White;
            rBCheckout.UseVisualStyleBackColor = false;
            rBCheckout.Click += rBCheckout_Click;
            // 
            // lblCheckOutPrice
            // 
            lblCheckOutPrice.AutoSize = true;
            lblCheckOutPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCheckOutPrice.ForeColor = SystemColors.ButtonHighlight;
            lblCheckOutPrice.Location = new Point(644, 31);
            lblCheckOutPrice.Margin = new Padding(1, 0, 1, 0);
            lblCheckOutPrice.Name = "lblCheckOutPrice";
            lblCheckOutPrice.Size = new Size(23, 21);
            lblCheckOutPrice.TabIndex = 22;
            lblCheckOutPrice.Text = "0 ";
            // 
            // lblItemWriting
            // 
            lblItemWriting.AutoSize = true;
            lblItemWriting.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblItemWriting.ForeColor = SystemColors.ButtonHighlight;
            lblItemWriting.Location = new Point(389, 31);
            lblItemWriting.Margin = new Padding(1, 0, 1, 0);
            lblItemWriting.Name = "lblItemWriting";
            lblItemWriting.Size = new Size(19, 21);
            lblItemWriting.TabIndex = 21;
            lblItemWriting.Text = "0";
            // 
            // lblPriceCheckOut
            // 
            lblPriceCheckOut.AutoSize = true;
            lblPriceCheckOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPriceCheckOut.ForeColor = SystemColors.Control;
            lblPriceCheckOut.Location = new Point(534, 31);
            lblPriceCheckOut.Margin = new Padding(1, 0, 1, 0);
            lblPriceCheckOut.Name = "lblPriceCheckOut";
            lblPriceCheckOut.Size = new Size(94, 21);
            lblPriceCheckOut.TabIndex = 19;
            lblPriceCheckOut.Text = "Total Price:";
            // 
            // lblItemsCart
            // 
            lblItemsCart.AutoSize = true;
            lblItemsCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemsCart.ForeColor = SystemColors.Control;
            lblItemsCart.Location = new Point(277, 31);
            lblItemsCart.Margin = new Padding(1, 0, 1, 0);
            lblItemsCart.Name = "lblItemsCart";
            lblItemsCart.Size = new Size(110, 21);
            lblItemsCart.TabIndex = 18;
            lblItemsCart.Text = "Total Item(s):";
            // 
            // cBPay
            // 
            cBPay.AutoSize = true;
            cBPay.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            cBPay.ForeColor = Color.Bisque;
            cBPay.Location = new Point(59, 31);
            cBPay.Margin = new Padding(1);
            cBPay.Name = "cBPay";
            cBPay.Size = new Size(92, 24);
            cBPay.TabIndex = 0;
            cBPay.Text = "Select All";
            cBPay.UseVisualStyleBackColor = true;
            // 
            // ucCartProducts
            // 
            ucCartProducts.BackColor = Color.FromArgb(164, 206, 149);
            ucCartProducts.Location = new Point(114, 20);
            ucCartProducts.Margin = new Padding(1);
            ucCartProducts.Name = "ucCartProducts";
            ucCartProducts.Size = new Size(755, 469);
            ucCartProducts.TabIndex = 21;
            ucCartProducts.Load += ucCartProducts_Load;
            // 
            // FormCart
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(164, 206, 149);
            ClientSize = new Size(984, 561);
            Controls.Add(pnlCheckOut);
            Controls.Add(ucCartProducts);
            Margin = new Padding(1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCart";
            pnlCheckOut.ResumeLayout(false);
            pnlCheckOut.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlCheckOut;
        private Label label2;
        private RJControls.RButton rBCheckout;
        private Label lblCheckOutPrice;
        private Label lblItemWriting;
        private Label lblPriceCheckOut;
        private Label lblItemsCart;
        private CheckBox cBPay;
        private UCCartProduct ucCartProducts;
    }
}
