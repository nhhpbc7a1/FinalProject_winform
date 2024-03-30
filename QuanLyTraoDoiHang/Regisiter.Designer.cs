namespace QuanLyTraoDoiHang
{
    partial class Regisiter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regisiter));
            lblBirthday = new Label();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            dtBirthday = new DateTimePicker();
            txtPersonalId = new TextBox();
            txtUsername = new TextBox();
            panel3 = new Panel();
            ucPassword = new UCPasswordTextBox();
            ucRetypePassword = new UCPasswordTextBox();
            lblRetypedPass = new Label();
            lblValidPass = new Label();
            label5 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnRegister = new RJControls.RButton();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label1 = new Label();
            panel6 = new Panel();
            btnHome = new RJControls.RButton();
            btnMinimize = new RJControls.RButton();
            btnExit = new RJControls.RButton();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBirthday.ForeColor = SystemColors.GrayText;
            lblBirthday.Location = new Point(57, 158);
            lblBirthday.Margin = new Padding(4, 0, 4, 0);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(71, 21);
            lblBirthday.TabIndex = 3;
            lblBirthday.Text = "Birthday";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLightLight;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(57, 337);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "  Email";
            txtEmail.Size = new Size(306, 29);
            txtEmail.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.ControlLightLight;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(58, 274);
            txtPhone.Margin = new Padding(4, 3, 4, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "  Phone";
            txtPhone.Size = new Size(306, 29);
            txtPhone.TabIndex = 11;
            // 
            // dtBirthday
            // 
            dtBirthday.CalendarForeColor = Color.FromArgb(244, 237, 204);
            dtBirthday.CalendarMonthBackground = SystemColors.InfoText;
            dtBirthday.CalendarTitleForeColor = SystemColors.ControlDarkDark;
            dtBirthday.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtBirthday.Location = new Point(58, 150);
            dtBirthday.Name = "dtBirthday";
            dtBirthday.RightToLeft = RightToLeft.Yes;
            dtBirthday.Size = new Size(306, 29);
            dtBirthday.TabIndex = 15;
            dtBirthday.ValueChanged += dtBirthday_ValueChanged;
            // 
            // txtPersonalId
            // 
            txtPersonalId.BackColor = SystemColors.ControlLightLight;
            txtPersonalId.BorderStyle = BorderStyle.FixedSingle;
            txtPersonalId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPersonalId.Location = new Point(58, 217);
            txtPersonalId.Margin = new Padding(4, 3, 4, 3);
            txtPersonalId.Name = "txtPersonalId";
            txtPersonalId.PlaceholderText = "  Personal ID";
            txtPersonalId.Size = new Size(306, 29);
            txtPersonalId.TabIndex = 14;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ControlLightLight;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(58, 95);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "  Username";
            txtUsername.Size = new Size(306, 29);
            txtUsername.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(244, 237, 204);
            panel3.Controls.Add(ucRetypePassword);
            panel3.Controls.Add(ucPassword);
            panel3.Controls.Add(lblRetypedPass);
            panel3.Controls.Add(lblValidPass);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(txtPersonalId);
            panel3.Controls.Add(dtBirthday);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(btnRegister);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(lblBirthday);
            panel3.Location = new Point(494, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(421, 615);
            panel3.TabIndex = 15;
            // 
            // ucPassword
            // 
            ucPassword.BackColor = Color.White;
            ucPassword.Location = new Point(58, 397);
            ucPassword.Margin = new Padding(3, 2, 3, 2);
            ucPassword.Name = "ucPassword";
            ucPassword.Size = new Size(306, 29);
            ucPassword.TabIndex = 28;
            // 
            // ucRetypePassword
            // 
            ucRetypePassword.BackColor = Color.White;
            ucRetypePassword.Location = new Point(58, 457);
            ucRetypePassword.Margin = new Padding(3, 2, 3, 2);
            ucRetypePassword.Name = "ucRetypePassword";
            ucRetypePassword.Size = new Size(306, 29);
            ucRetypePassword.TabIndex = 29;
            // 
            // lblRetypedPass
            // 
            lblRetypedPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRetypedPass.ForeColor = Color.Black;
            lblRetypedPass.Location = new Point(58, 493);
            lblRetypedPass.Name = "lblRetypedPass";
            lblRetypedPass.Size = new Size(313, 39);
            lblRetypedPass.TabIndex = 31;
            lblRetypedPass.Text = "Retyped-new password need to be matched with the new password.";
            lblRetypedPass.Visible = false;
            // 
            // lblValidPass
            // 
            lblValidPass.AutoSize = true;
            lblValidPass.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValidPass.ForeColor = Color.Black;
            lblValidPass.Location = new Point(58, 430);
            lblValidPass.Name = "lblValidPass";
            lblValidPass.Size = new Size(197, 13);
            lblValidPass.TabIndex = 30;
            lblValidPass.Text = "It should be longer than 6 characters";
            lblValidPass.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.InfoText;
            label5.Location = new Point(147, 17);
            label5.Name = "label5";
            label5.Size = new Size(142, 45);
            label5.TabIndex = 19;
            label5.Text = "Register";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = SystemColors.ControlLightLight;
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(338, 343);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(18, 18);
            pictureBox7.TabIndex = 26;
            pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ControlLightLight;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(338, 280);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(18, 18);
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ControlLightLight;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(338, 222);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(18, 18);
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlLightLight;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(338, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(18, 18);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(97, 150, 166);
            btnRegister.BackgroundColor = Color.FromArgb(97, 150, 166);
            btnRegister.BorderColor = Color.PaleVioletRed;
            btnRegister.BorderRadius = 20;
            btnRegister.BorderSize = 0;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(57, 536);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(306, 40);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "Register";
            btnRegister.TextColor = Color.White;
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(-18, 248);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(-123, 34);
            label2.Name = "label2";
            label2.Size = new Size(0, 55);
            label2.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 372);
            panel1.TabIndex = 18;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(30, 106, 17);
            label4.Location = new Point(67, 287);
            label4.Name = "label4";
            label4.Size = new Size(301, 24);
            label4.TabIndex = 13;
            label4.Text = "Trade Goods, Seamless, Swift";
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
            // panel6
            // 
            panel6.Controls.Add(btnHome);
            panel6.Controls.Add(btnMinimize);
            panel6.Controls.Add(btnExit);
            panel6.Location = new Point(3, 3);
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
            // Regisiter
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(164, 206, 149);
            ClientSize = new Size(984, 661);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Regisiter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Regisiter";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBirthday;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private DateTimePicker dtBirthday;
        private TextBox txtPersonalId;
        private TextBox txtUsername;
        private Panel panel3;
        private RJControls.RButton btnRegister;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private Label label5;
        private UCPasswordTextBox ucRetypePassword;
        private UCPasswordTextBox ucPassword;
        private Panel panel6;
        private RJControls.RButton btnHome;
        private RJControls.RButton btnMinimize;
        private RJControls.RButton btnExit;
        private Label lblValidPass;
        private Label lblRetypedPass;
    }
}