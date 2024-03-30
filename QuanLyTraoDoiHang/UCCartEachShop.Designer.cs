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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbShop = new System.Windows.Forms.CheckBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.pnlProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbShop);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.phone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 73);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 1);
            this.panel2.TabIndex = 2;
            // 
            // cbShop
            // 
            this.cbShop.AutoSize = true;
            this.cbShop.Location = new System.Drawing.Point(21, 30);
            this.cbShop.Name = "cbShop";
            this.cbShop.Size = new System.Drawing.Size(15, 14);
            this.cbShop.TabIndex = 1;
            this.cbShop.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(42, 24);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 21);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "username";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phone.Image = ((System.Drawing.Image)(resources.GetObject("phone.Image")));
            this.phone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phone.Location = new System.Drawing.Point(127, 21);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(76, 26);
            this.phone.TabIndex = 0;
            this.phone.Text = "phone";
            this.phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlProducts
            // 
            this.pnlProducts.AutoSize = true;
            this.pnlProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProducts.Location = new System.Drawing.Point(0, 73);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(715, 542);
            this.pnlProducts.TabIndex = 4;
            // 
            // UCCartEachShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlProducts);
            this.Controls.Add(this.panel1);
            this.Name = "UCCartEachShop";
            this.Size = new System.Drawing.Size(715, 615);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lblUsername;
        private Label phone;
        private CheckBox cbShop;
        private FlowLayoutPanel pnlProducts;
        private Panel panel2;
    }
}
