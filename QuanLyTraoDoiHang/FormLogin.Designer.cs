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
            txtUsername = new TextBox();
            panel2 = new Panel();
            ucPassword = new UCPasswordTextBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            btnRegister = new RJControls.RButton();
            btnSignin = new RJControls.RButton();
            lblforgotpass = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            btnHome = new RJControls.RButton();
            btnMinimize = new RJControls.RButton();
            btnExit = new RJControls.RButton();
            panel3 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ControlLightLight;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(54, 89);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "  Username";
            txtUsername.Size = new Size(264, 27);
            txtUsername.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ucPassword);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(btnSignin);
            panel2.Controls.Add(lblforgotpass);
            panel2.Controls.Add(txtUsername);
            panel2.Location = new Point(555, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 413);
            panel2.TabIndex = 7;
            // 
            // ucPassword
            // 
            ucPassword.BackColor = Color.White;
            ucPassword.Font = new Font("Lato", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ucPassword.Location = new Point(54, 147);
            ucPassword.Margin = new Padding(3, 2, 3, 2);
            ucPassword.Name = "ucPassword";
            ucPassword.Size = new Size(264, 29);
            ucPassword.TabIndex = 27;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlLightLight;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(296, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(18, 18);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lato", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.InfoText;
            label5.Location = new Point(116, 16);
            label5.Name = "label5";
            label5.Size = new Size(151, 39);
            label5.TabIndex = 15;
            label5.Text = "Welcome";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.White;
            btnRegister.BackgroundColor = Color.White;
            btnRegister.BorderColor = Color.FromArgb(11, 96, 176);
            btnRegister.BorderRadius = 20;
            btnRegister.BorderSize = 3;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.FromArgb(11, 96, 176);
            btnRegister.Location = new Point(54, 326);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(251, 44);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "Register";
            btnRegister.TextColor = Color.FromArgb(11, 96, 176);
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnSignin
            // 
            btnSignin.BackColor = Color.FromArgb(11, 96, 176);
            btnSignin.BackgroundColor = Color.FromArgb(11, 96, 176);
            btnSignin.BorderColor = Color.PaleVioletRed;
            btnSignin.BorderRadius = 20;
            btnSignin.BorderSize = 0;
            btnSignin.FlatAppearance.BorderSize = 0;
            btnSignin.FlatStyle = FlatStyle.Flat;
            btnSignin.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignin.ForeColor = Color.White;
            btnSignin.Location = new Point(54, 256);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(251, 40);
            btnSignin.TabIndex = 15;
            btnSignin.Text = "Sign in";
            btnSignin.TextColor = Color.White;
            btnSignin.UseVisualStyleBackColor = false;
            // 
            // lblforgotpass
            // 
            lblforgotpass.AutoSize = true;
            lblforgotpass.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblforgotpass.ForeColor = SystemColors.GrayText;
            lblforgotpass.Location = new Point(97, 194);
            lblforgotpass.Name = "lblforgotpass";
            lblforgotpass.Size = new Size(170, 19);
            lblforgotpass.TabIndex = 7;
            lblforgotpass.Text = "Forgot your password?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 45F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(30, 106, 17);
            label1.Location = new Point(122, 217);
            label1.Name = "label1";
            label1.Size = new Size(186, 70);
            label1.TabIndex = 9;
            label1.Text = "KoHa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(-2, 94);
            label2.Name = "label2";
            label2.Size = new Size(0, 55);
            label2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(103, 308);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lato", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(30, 106, 17);
            label4.Location = new Point(75, 287);
            label4.Name = "label4";
            label4.Size = new Size(278, 25);
            label4.TabIndex = 13;
            label4.Text = "Trade Goods, Seamless, Swift";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 372);
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
            // panel6
            // 
            panel6.Controls.Add(btnHome);
            panel6.Controls.Add(btnMinimize);
            panel6.Controls.Add(btnExit);
            panel6.Location = new Point(0, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(103, 33);
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
            btnHome.Location = new Point(69, 7);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(22, 22);
            btnHome.TabIndex = 20;
            btnHome.TextColor = Color.Wheat;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
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
            btnMinimize.Location = new Point(42, 7);
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
            btnExit.Location = new Point(16, 7);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(21, 21);
            btnExit.TabIndex = 0;
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(25, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(934, 454);
            panel3.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(30, 106, 17);
            ClientSize = new Size(984, 661);
            ControlBox = false;
            Controls.Add(panel6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel3);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsername;
        private Panel panel2;
        private Label lblforgotpass;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RJControls.RButton btnRegister;
        private RJControls.RButton btnSignin;
        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private UCPasswordTextBox ucPassword;
        private Panel panel6;
        private RJControls.RButton btnHome;
        private RJControls.RButton btnMinimize;
        private RJControls.RButton btnExit;
        private Panel panel3;
    }
}