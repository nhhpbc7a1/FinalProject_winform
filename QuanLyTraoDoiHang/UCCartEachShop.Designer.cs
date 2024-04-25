namespace QuanLyTraoDoiHang
{
    partial class UCCartEachShop
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCartEachShop));
            lblUsername = new Label();
            lblPhone = new Label();
            panel1 = new Panel();
            label1 = new Label();
            cbShop = new CheckBox();
            pnlProducts = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.FromArgb(229, 228, 131);
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(35, 26);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(85, 21);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "username";
            // 
            // lblPhone
            // 
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhone.Image = (Image)resources.GetObject("lblPhone.Image");
            lblPhone.ImageAlign = ContentAlignment.MiddleLeft;
            lblPhone.Location = new Point(255, 16);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(150, 26);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "phone";
            lblPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 228, 131);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbShop);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblPhone);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(715, 58);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 10);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
            label1.TabIndex = 2;
            label1.Text = "Seller's name";
            // 
            // cbShop
            // 
            cbShop.AutoSize = true;
            cbShop.Location = new Point(14, 32);
            cbShop.Name = "cbShop";
            cbShop.Size = new Size(15, 14);
            cbShop.TabIndex = 1;
            cbShop.UseVisualStyleBackColor = true;
            // 
            // pnlProducts
            // 
            pnlProducts.AutoSize = true;
            pnlProducts.BackColor = Color.WhiteSmoke;
            pnlProducts.Dock = DockStyle.Fill;
            pnlProducts.Location = new Point(0, 58);
            pnlProducts.Margin = new Padding(0, 0, 0, 5);
            pnlProducts.MaximumSize = new Size(715, 10000);
            pnlProducts.MinimumSize = new Size(715, 121);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(715, 121);
            pnlProducts.TabIndex = 3;
            // 
            // UCCartEachShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            Controls.Add(pnlProducts);
            Controls.Add(panel1);
            Margin = new Padding(6, 5, 0, 0);
            MaximumSize = new Size(715, 10000);
            MinimumSize = new Size(715, 121);
            Name = "UCCartEachShop";
            Size = new Size(715, 179);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsername;
        private Label lblPhone;
        private Panel panel1;
        public FlowLayoutPanel pnlProducts;
        public CheckBox cbShop;
        private Label label1;
    }
}
