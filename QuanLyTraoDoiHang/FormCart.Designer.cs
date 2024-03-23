
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.pnlCheckOut.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlProducts);
            this.panel1.Controls.Add(this.pnlMenu);
            this.panel1.Location = new System.Drawing.Point(115, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 439);
            this.panel1.TabIndex = 21;
            // 
            // pnlProducts
            // 
            this.pnlProducts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlProducts.Location = new System.Drawing.Point(15, 39);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(725, 400);
            this.pnlProducts.TabIndex = 25;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.pnlMenu.Controls.Add(this.label4);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.lblAction);
            this.pnlMenu.Controls.Add(this.lblTotalPrice);
            this.pnlMenu.Location = new System.Drawing.Point(15, 4);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(1);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(725, 31);
            this.pnlMenu.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(33, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Your product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(463, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Status";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAction.Location = new System.Drawing.Point(634, 4);
            this.lblAction.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(58, 21);
            this.lblAction.TabIndex = 16;
            this.lblAction.Text = "Action";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalPrice.Location = new System.Drawing.Point(269, 4);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(85, 21);
            this.lblTotalPrice.TabIndex = 15;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // FormCart
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCheckOut);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCart";
            this.pnlCheckOut.ResumeLayout(false);
            this.pnlCheckOut.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
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
        private Panel panel1;
        private FlowLayoutPanel pnlProducts;
        private Panel pnlMenu;
        private Label label4;
        private Label label1;
        private Label lblAction;
        private Label lblTotalPrice;
    }
}
