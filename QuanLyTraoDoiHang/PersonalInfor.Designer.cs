namespace QuanLyTraoDoiHang
{
    partial class PersonalInfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalInfor));
            panel2 = new Panel();
            lblChangeImage = new Label();
            panel8 = new Panel();
            ptbUserImage = new PictureBox();
            lblUsername = new Label();
            panel7 = new Panel();
            btnUpdateInfo = new RJControls.RButton();
            btnLogout = new RJControls.RButton();
            btnChangePass = new RJControls.RButton();
            btnHistory = new RJControls.RButton();
            panel1 = new Panel();
            panel3 = new Panel();
            pnl_Infor = new Panel();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbUserImage).BeginInit();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(lblChangeImage);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 561);
            panel2.TabIndex = 1;
            // 
            // lblChangeImage
            // 
            lblChangeImage.Anchor = AnchorStyles.None;
            lblChangeImage.BackColor = Color.White;
            lblChangeImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblChangeImage.ForeColor = Color.Green;
            lblChangeImage.Image = (Image)resources.GetObject("lblChangeImage.Image");
            lblChangeImage.ImageAlign = ContentAlignment.MiddleRight;
            lblChangeImage.Location = new Point(25, 162);
            lblChangeImage.Name = "lblChangeImage";
            lblChangeImage.Size = new Size(158, 30);
            lblChangeImage.TabIndex = 8;
            lblChangeImage.Text = "Change profile";
            lblChangeImage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.BackColor = Color.White;
            panel8.Controls.Add(ptbUserImage);
            panel8.Controls.Add(lblUsername);
            panel8.Location = new Point(42, 32);
            panel8.Name = "panel8";
            panel8.Size = new Size(128, 127);
            panel8.TabIndex = 7;
            // 
            // ptbUserImage
            // 
            ptbUserImage.BackColor = SystemColors.Control;
            ptbUserImage.BackgroundImage = (Image)resources.GetObject("ptbUserImage.BackgroundImage");
            ptbUserImage.BackgroundImageLayout = ImageLayout.Stretch;
            ptbUserImage.BorderStyle = BorderStyle.FixedSingle;
            ptbUserImage.Location = new Point(6, 5);
            ptbUserImage.Margin = new Padding(2, 3, 3, 3);
            ptbUserImage.Name = "ptbUserImage";
            ptbUserImage.Size = new Size(116, 95);
            ptbUserImage.TabIndex = 0;
            ptbUserImage.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.White;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(25, 103);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(79, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "username";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.BackColor = Color.White;
            panel7.Controls.Add(btnUpdateInfo);
            panel7.Controls.Add(btnLogout);
            panel7.Controls.Add(btnChangePass);
            panel7.Controls.Add(btnHistory);
            panel7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel7.Location = new Point(12, 204);
            panel7.Name = "panel7";
            panel7.Size = new Size(184, 314);
            panel7.TabIndex = 6;
            // 
            // btnUpdateInfo
            // 
            btnUpdateInfo.BackColor = Color.White;
            btnUpdateInfo.BackgroundColor = Color.White;
            btnUpdateInfo.BorderColor = Color.FromArgb(30, 106, 17);
            btnUpdateInfo.BorderRadius = 10;
            btnUpdateInfo.BorderSize = 1;
            btnUpdateInfo.FlatAppearance.BorderSize = 0;
            btnUpdateInfo.FlatStyle = FlatStyle.Flat;
            btnUpdateInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateInfo.ForeColor = Color.FromArgb(30, 106, 17);
            btnUpdateInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateInfo.Location = new Point(13, 14);
            btnUpdateInfo.Name = "btnUpdateInfo";
            btnUpdateInfo.Size = new Size(152, 44);
            btnUpdateInfo.TabIndex = 2;
            btnUpdateInfo.Text = "Update info";
            btnUpdateInfo.TextColor = Color.FromArgb(30, 106, 17);
            btnUpdateInfo.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.BackgroundColor = Color.White;
            btnLogout.BorderColor = Color.FromArgb(30, 106, 17);
            btnLogout.BorderRadius = 10;
            btnLogout.BorderSize = 1;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.FromArgb(30, 106, 17);
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(13, 185);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(152, 44);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log out";
            btnLogout.TextColor = Color.FromArgb(30, 106, 17);
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnChangePass
            // 
            btnChangePass.BackColor = Color.White;
            btnChangePass.BackgroundColor = Color.White;
            btnChangePass.BorderColor = Color.FromArgb(30, 106, 17);
            btnChangePass.BorderRadius = 10;
            btnChangePass.BorderSize = 1;
            btnChangePass.FlatAppearance.BorderSize = 0;
            btnChangePass.FlatStyle = FlatStyle.Flat;
            btnChangePass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePass.ForeColor = Color.FromArgb(30, 106, 17);
            btnChangePass.Location = new Point(13, 71);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(152, 44);
            btnChangePass.TabIndex = 3;
            btnChangePass.Text = "Change password";
            btnChangePass.TextColor = Color.FromArgb(30, 106, 17);
            btnChangePass.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.White;
            btnHistory.BackgroundColor = Color.White;
            btnHistory.BorderColor = Color.FromArgb(30, 106, 17);
            btnHistory.BorderRadius = 10;
            btnHistory.BorderSize = 1;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistory.ForeColor = Color.FromArgb(30, 106, 17);
            btnHistory.Location = new Point(13, 128);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(152, 44);
            btnHistory.TabIndex = 4;
            btnHistory.Text = "Purchase History";
            btnHistory.TextColor = Color.FromArgb(30, 106, 17);
            btnHistory.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 545);
            panel1.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pnl_Infor);
            panel3.Location = new Point(189, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(783, 545);
            panel3.TabIndex = 2;
            // 
            // pnl_Infor
            // 
            pnl_Infor.Anchor = AnchorStyles.None;
            pnl_Infor.BackColor = SystemColors.ControlLight;
            pnl_Infor.Location = new Point(18, 21);
            pnl_Infor.Name = "pnl_Infor";
            pnl_Infor.Size = new Size(747, 502);
            pnl_Infor.TabIndex = 1;
            // 
            // PersonalInfor
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(984, 561);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "PersonalInfor";
            Text = "PersonalInfor";
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbUserImage).EndInit();
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label lblUsername;
        private PictureBox ptbUserImage;
        private Panel panel7;
        private RJControls.RButton btnUpdateInfo;
        private RJControls.RButton btnChangePass;
        private RJControls.RButton btnHistory;
        private Panel panel8;
        private Label lblChangeImage;
        public RJControls.RButton btnLogout;
        private Panel panel1;
        private Panel panel3;
        private Panel pnl_Infor;
    }
}