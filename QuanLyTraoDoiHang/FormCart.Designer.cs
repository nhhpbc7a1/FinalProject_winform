
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
            this.pnlCheckOut = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rBCheckout = new QuanLyTraoDoiHang.RJControls.RButton();
            this.lblCheckOutPrice = new System.Windows.Forms.Label();
            this.lblItemWriting = new System.Windows.Forms.Label();
            this.lblPriceCheckOut = new System.Windows.Forms.Label();
            this.lblItemsCart = new System.Windows.Forms.Label();
            this.cBPay = new System.Windows.Forms.CheckBox();
            this.ucCartProducts = new QuanLyTraoDoiHang.UCCartProduct();
            this.pnlCheckOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCheckOut
            // 
            this.pnlCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(115)))), ((int)(((byte)(82)))));
            this.pnlCheckOut.Controls.Add(this.label2);
            this.pnlCheckOut.Controls.Add(this.rBCheckout);
            this.pnlCheckOut.Controls.Add(this.lblCheckOutPrice);
            this.pnlCheckOut.Controls.Add(this.lblItemWriting);
            this.pnlCheckOut.Controls.Add(this.lblPriceCheckOut);
            this.pnlCheckOut.Controls.Add(this.lblItemsCart);
            this.pnlCheckOut.Controls.Add(this.cBPay);
            this.pnlCheckOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCheckOut.Location = new System.Drawing.Point(0, 467);
            this.pnlCheckOut.Margin = new System.Windows.Forms.Padding(1);
            this.pnlCheckOut.Name = "pnlCheckOut";
            this.pnlCheckOut.Size = new System.Drawing.Size(984, 94);
            this.pnlCheckOut.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(623, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "đ";
            // 
            // rBCheckout
            // 
            this.rBCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.rBCheckout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.rBCheckout.BorderColor = System.Drawing.Color.White;
            this.rBCheckout.BorderRadius = 20;
            this.rBCheckout.BorderSize = 1;
            this.rBCheckout.FlatAppearance.BorderSize = 0;
            this.rBCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBCheckout.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rBCheckout.ForeColor = System.Drawing.Color.White;
            this.rBCheckout.Location = new System.Drawing.Point(782, 24);
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
            this.lblCheckOutPrice.Location = new System.Drawing.Point(644, 31);
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
            this.lblItemWriting.Location = new System.Drawing.Point(389, 31);
            this.lblItemWriting.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblItemWriting.Name = "lblItemWriting";
            this.lblItemWriting.Size = new System.Drawing.Size(19, 21);
            this.lblItemWriting.TabIndex = 21;
            this.lblItemWriting.Text = "0";
            // 
            // lblPriceCheckOut
            // 
            this.lblPriceCheckOut.AutoSize = true;
            this.lblPriceCheckOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPriceCheckOut.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPriceCheckOut.Location = new System.Drawing.Point(534, 31);
            this.lblPriceCheckOut.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPriceCheckOut.Name = "lblPriceCheckOut";
            this.lblPriceCheckOut.Size = new System.Drawing.Size(94, 21);
            this.lblPriceCheckOut.TabIndex = 19;
            this.lblPriceCheckOut.Text = "Total Price:";
            // 
            // lblItemsCart
            // 
            this.lblItemsCart.AutoSize = true;
            this.lblItemsCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItemsCart.ForeColor = System.Drawing.SystemColors.Control;
            this.lblItemsCart.Location = new System.Drawing.Point(277, 31);
            this.lblItemsCart.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblItemsCart.Name = "lblItemsCart";
            this.lblItemsCart.Size = new System.Drawing.Size(110, 21);
            this.lblItemsCart.TabIndex = 18;
            this.lblItemsCart.Text = "Total Item(s):";
            // 
            // cBPay
            // 
            this.cBPay.AutoSize = true;
            this.cBPay.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cBPay.ForeColor = System.Drawing.Color.Bisque;
            this.cBPay.Location = new System.Drawing.Point(59, 31);
            this.cBPay.Margin = new System.Windows.Forms.Padding(1);
            this.cBPay.Name = "cBPay";
            this.cBPay.Size = new System.Drawing.Size(92, 24);
            this.cBPay.TabIndex = 0;
            this.cBPay.Text = "Select All";
            this.cBPay.UseVisualStyleBackColor = true;
            // 
            // ucCartProducts
            // 
            this.ucCartProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(149)))));
            this.ucCartProducts.Location = new System.Drawing.Point(114, 20);
            this.ucCartProducts.Margin = new System.Windows.Forms.Padding(1);
            this.ucCartProducts.Name = "ucCartProducts";
            this.ucCartProducts.Size = new System.Drawing.Size(755, 469);
            this.ucCartProducts.TabIndex = 21;
            // 
            // FormCart
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlCheckOut);
            this.Controls.Add(this.ucCartProducts);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCart";
            this.pnlCheckOut.ResumeLayout(false);
            this.pnlCheckOut.PerformLayout();
            this.ResumeLayout(false);

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
