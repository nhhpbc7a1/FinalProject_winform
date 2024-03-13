namespace QuanLyTraoDoiHang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblUsername = new Label();
            lblPassword = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel2 = new Panel();
            label5 = new Label();
            rButton2 = new RJControls.RButton();
            rButton1 = new RJControls.RButton();
            lblforgotpass = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = SystemColors.GrayText;
            lblUsername.Location = new Point(34, 89);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(104, 28);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            lblUsername.Click += label1_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = SystemColors.GrayText;
            lblPassword.Location = new Point(34, 139);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 28);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 89);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 29);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 135);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 29);
            textBox2.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(244, 237, 204);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(rButton2);
            panel2.Controls.Add(rButton1);
            panel2.Controls.Add(lblforgotpass);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(760, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 413);
            panel2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.InfoText;
            label5.Location = new Point(97, 11);
            label5.Name = "label5";
            label5.Size = new Size(151, 54);
            label5.TabIndex = 15;
            label5.Text = "Sign in";
            // 
            // rButton2
            // 
            rButton2.BackColor = Color.FromArgb(97, 150, 166);
            rButton2.BackgroundColor = Color.FromArgb(97, 150, 166);
            rButton2.BorderColor = Color.PaleVioletRed;
            rButton2.BorderRadius = 20;
            rButton2.BorderSize = 0;
            rButton2.FlatAppearance.BorderSize = 0;
            rButton2.FlatStyle = FlatStyle.Flat;
            rButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rButton2.ForeColor = Color.White;
            rButton2.Location = new Point(54, 326);
            rButton2.Name = "rButton2";
            rButton2.Size = new Size(251, 40);
            rButton2.TabIndex = 16;
            rButton2.Text = "Register";
            rButton2.TextColor = Color.White;
            rButton2.UseVisualStyleBackColor = false;
            // 
            // rButton1
            // 
            rButton1.BackColor = Color.FromArgb(95, 93, 156);
            rButton1.BackgroundColor = Color.FromArgb(95, 93, 156);
            rButton1.BorderColor = Color.PaleVioletRed;
            rButton1.BorderRadius = 20;
            rButton1.BorderSize = 0;
            rButton1.FlatAppearance.BorderSize = 0;
            rButton1.FlatStyle = FlatStyle.Flat;
            rButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rButton1.ForeColor = Color.White;
            rButton1.Location = new Point(54, 256);
            rButton1.Name = "rButton1";
            rButton1.Size = new Size(251, 40);
            rButton1.TabIndex = 15;
            rButton1.Text = "Sign in";
            rButton1.TextColor = Color.White;
            rButton1.UseVisualStyleBackColor = false;
            // 
            // lblforgotpass
            // 
            lblforgotpass.AutoSize = true;
            lblforgotpass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblforgotpass.ForeColor = SystemColors.GrayText;
            lblforgotpass.Location = new Point(97, 194);
            lblforgotpass.Name = "lblforgotpass";
            lblforgotpass.Size = new Size(214, 28);
            lblforgotpass.TabIndex = 7;
            lblforgotpass.Text = "Forgot your password?";
            lblforgotpass.Click += lblforgotpass_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 45F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(30, 106, 17);
            label1.Location = new Point(122, 217);
            label1.Name = "label1";
            label1.Size = new Size(234, 89);
            label1.TabIndex = 9;
            label1.Text = "KoHa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(-2, 94);
            label2.Name = "label2";
            label2.Size = new Size(0, 69);
            label2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(103, 308);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(30, 106, 17);
            label4.Location = new Point(80, 287);
            label4.Name = "label4";
            label4.Size = new Size(393, 33);
            label4.TabIndex = 13;
            label4.Text = "Trade Goods, Seamless, Swift";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(126, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 372);
            panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(95, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 211);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 206, 149);
            ClientSize = new Size(1284, 661);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel2;
        private Label lblforgotpass;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RJControls.RButton rButton2;
        private RJControls.RButton rButton1;
        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox1;
    }
}