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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.chBProducts = new System.Windows.Forms.CheckBox();
            this.pnlCheckOut = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rBCheckout = new QuanLyTraoDoiHang.RJControls.RButton();
            this.lblCheckOutPrice = new System.Windows.Forms.Label();
            this.lblItemWriting = new System.Windows.Forms.Label();
            this.lblPriceCheckOut = new System.Windows.Forms.Label();
            this.lblItemsCart = new System.Windows.Forms.Label();
            this.cBPay = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucCartProduct1 = new QuanLyTraoDoiHang.UCCartProduct();
            this.pnlMenu.SuspendLayout();
            this.pnlCheckOut.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.lblAction);
            this.pnlMenu.Controls.Add(this.lblTotalPrice);
            this.pnlMenu.Controls.Add(this.chBProducts);
            this.pnlMenu.Location = new System.Drawing.Point(42, 25);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(1);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(875, 30);
            this.pnlMenu.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(504, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Status";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAction.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAction.Location = new System.Drawing.Point(739, 4);
            this.lblAction.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(61, 21);
            this.lblAction.TabIndex = 16;
            this.lblAction.Text = "Actions";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalPrice.Location = new System.Drawing.Point(297, 4);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(80, 21);
            this.lblTotalPrice.TabIndex = 15;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // chBProducts
            // 
            this.chBProducts.AutoSize = true;
            this.chBProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chBProducts.ForeColor = System.Drawing.SystemColors.Control;
            this.chBProducts.Location = new System.Drawing.Point(24, 3);
            this.chBProducts.Margin = new System.Windows.Forms.Padding(1);
            this.chBProducts.Name = "chBProducts";
            this.chBProducts.Size = new System.Drawing.Size(126, 25);
            this.chBProducts.TabIndex = 12;
            this.chBProducts.Text = "Your Products";
            this.chBProducts.UseVisualStyleBackColor = true;
            // 
            // pnlCheckOut
            // 
            this.pnlCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(148)))), ((int)(((byte)(112)))));
            this.pnlCheckOut.Controls.Add(this.label2);
            this.pnlCheckOut.Controls.Add(this.rBCheckout);
            this.pnlCheckOut.Controls.Add(this.lblCheckOutPrice);
            this.pnlCheckOut.Controls.Add(this.lblItemWriting);
            this.pnlCheckOut.Controls.Add(this.lblPriceCheckOut);
            this.pnlCheckOut.Controls.Add(this.lblItemsCart);
            this.pnlCheckOut.Controls.Add(this.cBPay);
            this.pnlCheckOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCheckOut.Location = new System.Drawing.Point(0, 480);
            this.pnlCheckOut.Margin = new System.Windows.Forms.Padding(1);
            this.pnlCheckOut.Name = "pnlCheckOut";
            this.pnlCheckOut.Size = new System.Drawing.Size(984, 81);
            this.pnlCheckOut.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(664, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "đ";
            // 
            // rBCheckout
            // 
            this.rBCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBCheckout.BackColor = System.Drawing.Color.LightCoral;
            this.rBCheckout.BackgroundColor = System.Drawing.Color.LightCoral;
            this.rBCheckout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rBCheckout.BorderRadius = 20;
            this.rBCheckout.BorderSize = 0;
            this.rBCheckout.FlatAppearance.BorderSize = 0;
            this.rBCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBCheckout.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rBCheckout.ForeColor = System.Drawing.Color.White;
            this.rBCheckout.Location = new System.Drawing.Point(781, 23);
            this.rBCheckout.Margin = new System.Windows.Forms.Padding(1);
            this.rBCheckout.Name = "rBCheckout";
            this.rBCheckout.Size = new System.Drawing.Size(111, 37);
            this.rBCheckout.TabIndex = 10;
            this.rBCheckout.Text = "Check Out";
            this.rBCheckout.TextColor = System.Drawing.Color.White;
            this.rBCheckout.UseVisualStyleBackColor = false;
            // 
            // lblCheckOutPrice
            // 
            this.lblCheckOutPrice.AutoSize = true;
            this.lblCheckOutPrice.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCheckOutPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCheckOutPrice.Location = new System.Drawing.Point(685, 31);
            this.lblCheckOutPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCheckOutPrice.Name = "lblCheckOutPrice";
            this.lblCheckOutPrice.Size = new System.Drawing.Size(23, 21);
            this.lblCheckOutPrice.TabIndex = 22;
            this.lblCheckOutPrice.Text = "0 ";
            // 
            // lblItemWriting
            // 
            this.lblItemWriting.AutoSize = true;
            this.lblItemWriting.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblItemWriting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblItemWriting.Location = new System.Drawing.Point(441, 31);
            this.lblItemWriting.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblItemWriting.Name = "lblItemWriting";
            this.lblItemWriting.Size = new System.Drawing.Size(19, 21);
            this.lblItemWriting.TabIndex = 21;
            this.lblItemWriting.Text = "0";
            // 
            // lblPriceCheckOut
            // 
            this.lblPriceCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPriceCheckOut.AutoSize = true;
            this.lblPriceCheckOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPriceCheckOut.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPriceCheckOut.Location = new System.Drawing.Point(578, 31);
            this.lblPriceCheckOut.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPriceCheckOut.Name = "lblPriceCheckOut";
            this.lblPriceCheckOut.Size = new System.Drawing.Size(94, 21);
            this.lblPriceCheckOut.TabIndex = 19;
            this.lblPriceCheckOut.Text = "Total Price:";
            // 
            // lblItemsCart
            // 
            this.lblItemsCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemsCart.AutoSize = true;
            this.lblItemsCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItemsCart.ForeColor = System.Drawing.SystemColors.Control;
            this.lblItemsCart.Location = new System.Drawing.Point(338, 30);
            this.lblItemsCart.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblItemsCart.Name = "lblItemsCart";
            this.lblItemsCart.Size = new System.Drawing.Size(110, 21);
            this.lblItemsCart.TabIndex = 18;
            this.lblItemsCart.Text = "Total Item(s):";
            // 
            // cBPay
            // 
            this.cBPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBPay.AutoSize = true;
            this.cBPay.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cBPay.ForeColor = System.Drawing.Color.Bisque;
            this.cBPay.Location = new System.Drawing.Point(66, 30);
            this.cBPay.Margin = new System.Windows.Forms.Padding(1);
            this.cBPay.Name = "cBPay";
            this.cBPay.Size = new System.Drawing.Size(92, 24);
            this.cBPay.TabIndex = 0;
            this.cBPay.Text = "Select All";
            this.cBPay.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ucCartProduct1);
            this.panel1.Location = new System.Drawing.Point(42, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 322);
            this.panel1.TabIndex = 14;
            // 
            // ucCartProduct1
            // 
            this.ucCartProduct1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.ucCartProduct1.Location = new System.Drawing.Point(12, 12);
            this.ucCartProduct1.Margin = new System.Windows.Forms.Padding(1);
            this.ucCartProduct1.Name = "ucCartProduct1";
            this.ucCartProduct1.Size = new System.Drawing.Size(847, 104);
            this.ucCartProduct1.TabIndex = 0;
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlCheckOut);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCart";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlCheckOut.ResumeLayout(false);
            this.pnlCheckOut.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Label label2;
    }
}