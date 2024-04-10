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
            cbShop = new CheckBox();
            pnlProducts = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Green;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(34, 16);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(79, 21);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "username";
            // 
            // lblPhone
            // 
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Image = (Image)resources.GetObject("lblPhone.Image");
            lblPhone.ImageAlign = ContentAlignment.MiddleLeft;
            lblPhone.Location = new Point(221, 13);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(133, 26);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "phone";
            lblPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cbShop);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblPhone);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(715, 58);
            panel1.TabIndex = 2;
            // 
            // cbShop
            // 
            cbShop.AutoSize = true;
            cbShop.Location = new Point(13, 20);
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
            pnlProducts.MaximumSize = new Size(715, 10000);
            pnlProducts.MinimumSize = new Size(715, 50);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Padding = new Padding(0, 0, 5, 0);
            pnlProducts.Size = new Size(715, 92);
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
            Margin = new Padding(3, 3, 10, 3);
            MaximumSize = new Size(715, 10000);
            MinimumSize = new Size(715, 150);
            Name = "UCCartEachShop";
            Size = new Size(715, 150);
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
    }
}
