namespace QuanLyTraoDoiHang
{
    partial class FormMyOrder
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
            pnlShipment = new Panel();
            ucShipment1 = new UCShipment();
            label2 = new Label();
            pnlMenu.SuspendLayout();
            pnlShipment.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(97, 150, 166);
            pnlMenu.Controls.Add(label2);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Controls.Add(lblAction);
            pnlMenu.Controls.Add(lblTotalPrice);
            pnlMenu.Controls.Add(chBProducts);
            pnlMenu.Location = new Point(58, 67);
            pnlMenu.Margin = new Padding(2);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1575, 85);
            pnlMenu.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(688, 14);
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
            lblAction.Location = new Point(1327, 14);
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
            lblTotalPrice.Location = new Point(421, 18);
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
            // pnlShipment
            // 
            pnlShipment.AutoScroll = true;
            pnlShipment.BackColor = Color.FromArgb(224, 224, 224);
            pnlShipment.BorderStyle = BorderStyle.FixedSingle;
            pnlShipment.Controls.Add(ucShipment1);
            pnlShipment.Location = new Point(58, 208);
            pnlShipment.Margin = new Padding(6);
            pnlShipment.Name = "pnlShipment";
            pnlShipment.Size = new Size(1575, 915);
            pnlShipment.TabIndex = 18;
            // 
            // ucShipment1
            // 
            ucShipment1.BackColor = Color.FromArgb(244, 237, 204);
            ucShipment1.Location = new Point(32, 40);
            ucShipment1.Name = "ucShipment1";
            ucShipment1.Size = new Size(1524, 262);
            ucShipment1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(1066, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 54);
            label2.TabIndex = 19;
            label2.Text = "Type";
            // 
            // FormMyOrder
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 206, 149);
            ClientSize = new Size(1684, 1126);
            Controls.Add(pnlMenu);
            Controls.Add(pnlShipment);
            Name = "FormMyOrder";
            Text = "FormMyOrder";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlShipment.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Label label1;
        private Label lblAction;
        private Label lblTotalPrice;
        private CheckBox chBProducts;
        private Panel pnlShipment;
        private UCShipment ucShipment1;
        private Label label2;
    }
}