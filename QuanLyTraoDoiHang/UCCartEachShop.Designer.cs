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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbShop = new System.Windows.Forms.CheckBox();
            this.pnlProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(34, 16);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 21);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "username";
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Image = ((System.Drawing.Image)(resources.GetObject("lblPhone.Image")));
            this.lblPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPhone.Location = new System.Drawing.Point(129, 13);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(120, 26);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "phone";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbShop);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 58);
            this.panel1.TabIndex = 2;
            // 
            // cbShop
            // 
            this.cbShop.AutoSize = true;
            this.cbShop.Location = new System.Drawing.Point(13, 20);
            this.cbShop.Name = "cbShop";
            this.cbShop.Size = new System.Drawing.Size(15, 14);
            this.cbShop.TabIndex = 1;
            this.cbShop.UseVisualStyleBackColor = true;
            // 
            // pnlProducts
            // 
            this.pnlProducts.AutoSize = true;
            this.pnlProducts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProducts.Location = new System.Drawing.Point(0, 58);
            this.pnlProducts.MaximumSize = new System.Drawing.Size(715, 10000);
            this.pnlProducts.MinimumSize = new System.Drawing.Size(715, 50);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnlProducts.Size = new System.Drawing.Size(715, 92);
            this.pnlProducts.TabIndex = 3;
            // 
            // UCCartEachShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlProducts);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.MaximumSize = new System.Drawing.Size(715, 10000);
            this.MinimumSize = new System.Drawing.Size(715, 150);
            this.Name = "UCCartEachShop";
            this.Size = new System.Drawing.Size(715, 150);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblUsername;
        private Label lblPhone;
        private Panel panel1;
        public FlowLayoutPanel pnlProducts;
        public CheckBox cbShop;
    }
}
