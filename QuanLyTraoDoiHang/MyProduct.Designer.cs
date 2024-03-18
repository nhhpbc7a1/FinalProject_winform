namespace QuanLyTraoDoiHang
{
    partial class MyProduct
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
            ucCartProduct1 = new UCCartProduct();
            pnlMenu = new Panel();
            label1 = new Label();
            lblAction = new Label();
            lblTotalPrice = new Label();
            chBProducts = new CheckBox();
            panel1.SuspendLayout();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ucCartProduct1);
            panel1.Location = new Point(52, 191);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1581, 868);
            panel1.TabIndex = 16;
            // 
            // ucCartProduct1
            // 
            ucCartProduct1.BackColor = Color.FromArgb(244, 237, 204);
            ucCartProduct1.Location = new Point(43, 50);
            ucCartProduct1.Margin = new Padding(2);
            ucCartProduct1.Name = "ucCartProduct1";
            ucCartProduct1.Size = new Size(1490, 220);
            ucCartProduct1.TabIndex = 0;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(97, 150, 166);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Controls.Add(lblAction);
            pnlMenu.Controls.Add(lblTotalPrice);
            pnlMenu.Controls.Add(chBProducts);
            pnlMenu.Location = new Point(52, 57);
            pnlMenu.Margin = new Padding(2);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1575, 85);
            pnlMenu.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(936, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 54);
            label1.TabIndex = 17;
            label1.Text = "Status";
            // 
            // lblAction
            // 
            lblAction.AutoSize = true;
            lblAction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAction.ForeColor = SystemColors.Control;
            lblAction.Location = new Point(1294, 14);
            lblAction.Margin = new Padding(2, 0, 2, 0);
            lblAction.Name = "lblAction";
            lblAction.Size = new Size(154, 54);
            lblAction.TabIndex = 16;
            lblAction.Text = "Actions";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPrice.ForeColor = SystemColors.Control;
            lblTotalPrice.Location = new Point(622, 14);
            lblTotalPrice.Margin = new Padding(2, 0, 2, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(203, 54);
            lblTotalPrice.TabIndex = 15;
            lblTotalPrice.Text = "Total Price";
            // 
            // chBProducts
            // 
            chBProducts.AutoSize = true;
            chBProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chBProducts.ForeColor = SystemColors.Control;
            chBProducts.Location = new Point(33, 14);
            chBProducts.Margin = new Padding(2);
            chBProducts.Name = "chBProducts";
            chBProducts.Size = new Size(305, 58);
            chBProducts.TabIndex = 12;
            chBProducts.Text = "Your Products";
            chBProducts.UseVisualStyleBackColor = true;
            // 
            // MyProduct
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 206, 149);
            ClientSize = new Size(1684, 1126);
            Controls.Add(pnlMenu);
            Controls.Add(panel1);
            Name = "MyProduct";
            Text = "MyProduct";
            panel1.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private UCCartProduct ucCartProduct1;
        private Panel pnlMenu;
        private Label label1;
        private Label lblAction;
        private Label lblTotalPrice;
        private CheckBox chBProducts;
    }
}