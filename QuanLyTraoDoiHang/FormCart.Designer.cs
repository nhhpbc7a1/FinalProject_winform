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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucCartProduct1 = new QuanLyTraoDoiHang.UCCartProduct();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(150)))), ((int)(((byte)(166)))));
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.lblAction);
            this.pnlMenu.Controls.Add(this.lblTotalPrice);
            this.pnlMenu.Controls.Add(this.chBProducts);
            this.pnlMenu.Location = new System.Drawing.Point(48, 33);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1162, 40);
            this.pnlMenu.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(703, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Status";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAction.Location = new System.Drawing.Point(919, 6);
            this.lblAction.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(77, 28);
            this.lblAction.TabIndex = 16;
            this.lblAction.Text = "Actions";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.Location = new System.Drawing.Point(446, 6);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(101, 28);
            this.lblTotalPrice.TabIndex = 15;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // chBProducts
            // 
            this.chBProducts.AutoSize = true;
            this.chBProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chBProducts.Location = new System.Drawing.Point(23, 5);
            this.chBProducts.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.chBProducts.Name = "chBProducts";
            this.chBProducts.Size = new System.Drawing.Size(155, 32);
            this.chBProducts.TabIndex = 12;
            this.chBProducts.Text = "Your Products";
            this.chBProducts.UseVisualStyleBackColor = true;
            // 
            // pnlCheckOut
            // 
            this.pnlCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.pnlCheckOut.Location = new System.Drawing.Point(0, 449);
            this.pnlCheckOut.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pnlCheckOut.Name = "pnlCheckOut";
            this.pnlCheckOut.Size = new System.Drawing.Size(1284, 108);
            this.pnlCheckOut.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ucCartProduct1);
            this.panel1.Location = new System.Drawing.Point(48, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 429);
            this.panel1.TabIndex = 14;
            // 
            // ucCartProduct1
            // 
            this.ucCartProduct1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.ucCartProduct1.Location = new System.Drawing.Point(11, 14);
            this.ucCartProduct1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ucCartProduct1.Name = "ucCartProduct1";
            this.ucCartProduct1.Size = new System.Drawing.Size(1138, 139);
            this.ucCartProduct1.TabIndex = 0;
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1273, 553);
            this.Controls.Add(this.pnlCheckOut);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCart";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
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
    }
}