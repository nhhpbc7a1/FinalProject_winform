namespace QuanLyTraoDoiHang
{
    partial class FPurchaseDone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPurchaseDone));
            label1 = new Label();
            lblTotalPrice = new Label();
            label3 = new Label();
            btnMyPurchases = new RJControls.RButton();
            btnCart = new RJControls.RButton();
            label2 = new Label();
            label4 = new Label();
            panel6 = new Panel();
            btnHome = new RJControls.RButton();
            btnMinimize = new RJControls.RButton();
            btnExit = new RJControls.RButton();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(298, 216);
            label1.Name = "label1";
            label1.Size = new Size(249, 70);
            label1.TabIndex = 1;
            label1.Text = "You paid";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPrice.ForeColor = Color.White;
            lblTotalPrice.Location = new Point(572, 226);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(106, 50);
            lblTotalPrice.TabIndex = 3;
            lblTotalPrice.Text = "2000";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(544, 230);
            label3.Name = "label3";
            label3.Size = new Size(32, 61);
            label3.TabIndex = 4;
            label3.Text = "đ";
            // 
            // btnMyPurchases
            // 
            btnMyPurchases.BackColor = Color.FromArgb(101, 183, 65);
            btnMyPurchases.BackgroundColor = Color.FromArgb(101, 183, 65);
            btnMyPurchases.BorderColor = Color.White;
            btnMyPurchases.BorderRadius = 10;
            btnMyPurchases.BorderSize = 1;
            btnMyPurchases.FlatAppearance.BorderSize = 0;
            btnMyPurchases.FlatStyle = FlatStyle.Flat;
            btnMyPurchases.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMyPurchases.ForeColor = Color.White;
            btnMyPurchases.Location = new Point(379, 415);
            btnMyPurchases.Name = "btnMyPurchases";
            btnMyPurchases.Size = new Size(177, 40);
            btnMyPurchases.TabIndex = 10;
            btnMyPurchases.Text = "My purchases";
            btnMyPurchases.TextColor = Color.White;
            btnMyPurchases.UseVisualStyleBackColor = false;
            btnMyPurchases.Click += btnMyPurchases_Click;
            // 
            // btnCart
            // 
            btnCart.BackColor = Color.FromArgb(101, 183, 65);
            btnCart.BackgroundColor = Color.FromArgb(101, 183, 65);
            btnCart.BorderColor = Color.White;
            btnCart.BorderRadius = 10;
            btnCart.BorderSize = 1;
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCart.ForeColor = Color.White;
            btnCart.Image = (Image)resources.GetObject("btnCart.Image");
            btnCart.Location = new Point(562, 415);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(43, 40);
            btnCart.TabIndex = 11;
            btnCart.TextColor = Color.White;
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(253, 319);
            label2.Name = "label2";
            label2.Size = new Size(480, 30);
            label2.TabIndex = 12;
            label2.Text = "Your order will be shipped out as soon as possible!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(362, 349);
            label4.Name = "label4";
            label4.Size = new Size(260, 30);
            label4.TabIndex = 13;
            label4.Text = "Thank you for your choice!";
            // 
            // panel6
            // 
            panel6.Controls.Add(btnHome);
            panel6.Controls.Add(btnMinimize);
            panel6.Controls.Add(btnExit);
            panel6.Location = new Point(2, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(101, 33);
            panel6.TabIndex = 20;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(128, 255, 128);
            btnHome.BackgroundColor = Color.FromArgb(128, 255, 128);
            btnHome.BorderColor = Color.PaleVioletRed;
            btnHome.BorderRadius = 21;
            btnHome.BorderSize = 0;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.Wheat;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(69, 6);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(22, 22);
            btnHome.TabIndex = 20;
            btnHome.TextColor = Color.Wheat;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click_1;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.FromArgb(245, 221, 97);
            btnMinimize.BackgroundColor = Color.FromArgb(245, 221, 97);
            btnMinimize.BorderColor = Color.PaleVioletRed;
            btnMinimize.BorderRadius = 20;
            btnMinimize.BorderSize = 0;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(42, 6);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(21, 21);
            btnMinimize.TabIndex = 2;
            btnMinimize.TextColor = Color.White;
            btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightCoral;
            btnExit.BackgroundColor = Color.LightCoral;
            btnExit.BorderColor = Color.PaleVioletRed;
            btnExit.BorderRadius = 20;
            btnExit.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(16, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(21, 21);
            btnExit.TabIndex = 0;
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FPurchaseDone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 183, 65);
            ClientSize = new Size(982, 661);
            Controls.Add(panel6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnCart);
            Controls.Add(btnMyPurchases);
            Controls.Add(label3);
            Controls.Add(lblTotalPrice);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FPurchaseDone";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FPurchaseDone";
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblTotalPrice;
        private Label label3;
        private RJControls.RButton btnMyPurchases;
        private RJControls.RButton btnCart;
        private Label label2;
        private Label label4;
        private Panel panel6;
        private RJControls.RButton btnHome;
        private RJControls.RButton btnMinimize;
        private RJControls.RButton btnExit;
    }
}