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
            pnl_Infor = new Panel();
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
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbUserImage).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Infor
            // 
            pnl_Infor.Anchor = AnchorStyles.None;
            pnl_Infor.BackColor = SystemColors.ControlLight;
            pnl_Infor.Location = new Point(305, 33);
            pnl_Infor.Name = "pnl_Infor";
            pnl_Infor.Size = new Size(642, 495);
            pnl_Infor.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblChangeImage);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 561);
            panel2.TabIndex = 1;
            // 
            // lblChangeImage
            // 
            lblChangeImage.Anchor = AnchorStyles.None;
            lblChangeImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblChangeImage.ForeColor = Color.Green;
            lblChangeImage.Image = (Image)resources.GetObject("lblChangeImage.Image");
            lblChangeImage.ImageAlign = ContentAlignment.MiddleRight;
            lblChangeImage.Location = new Point(55, 163);
            lblChangeImage.Name = "lblChangeImage";
            lblChangeImage.Size = new Size(158, 30);
            lblChangeImage.TabIndex = 8;
            lblChangeImage.Text = "Change profile";
            lblChangeImage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.BackColor = Color.FromArgb(244, 237, 204);
            panel8.Controls.Add(ptbUserImage);
            panel8.Controls.Add(lblUsername);
            panel8.Location = new Point(72, 33);
            panel8.Name = "panel8";
            panel8.Size = new Size(128, 127);
            panel8.TabIndex = 7;
            // 
            // ptbUserImage
            // 
            ptbUserImage.BackColor = SystemColors.Control;
            ptbUserImage.BackgroundImage = (Image)resources.GetObject("ptbUserImage.BackgroundImage");
            ptbUserImage.BackgroundImageLayout = ImageLayout.Stretch;
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
            lblUsername.BackColor = Color.FromArgb(244, 237, 204);
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
            panel7.Location = new Point(31, 204);
            panel7.Name = "panel7";
            panel7.Size = new Size(197, 314);
            panel7.TabIndex = 6;
            // 
            // btnUpdateInfo
            // 
            btnUpdateInfo.BackColor = Color.FromArgb(101, 183, 65);
            btnUpdateInfo.BackgroundColor = Color.FromArgb(101, 183, 65);
            btnUpdateInfo.BorderColor = Color.PaleVioletRed;
            btnUpdateInfo.BorderRadius = 10;
            btnUpdateInfo.BorderSize = 0;
            btnUpdateInfo.FlatAppearance.BorderSize = 0;
            btnUpdateInfo.FlatStyle = FlatStyle.Flat;
            btnUpdateInfo.ForeColor = Color.White;
            btnUpdateInfo.Image = (Image)resources.GetObject("btnUpdateInfo.Image");
            btnUpdateInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateInfo.Location = new Point(24, 14);
            btnUpdateInfo.Name = "btnUpdateInfo";
            btnUpdateInfo.Size = new Size(158, 51);
            btnUpdateInfo.TabIndex = 2;
            btnUpdateInfo.Text = "Update info";
            btnUpdateInfo.TextColor = Color.White;
            btnUpdateInfo.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(225, 120, 197);
            btnLogout.BackgroundColor = Color.FromArgb(225, 120, 197);
            btnLogout.BorderColor = Color.PaleVioletRed;
            btnLogout.BorderRadius = 10;
            btnLogout.BorderSize = 0;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(24, 233);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(158, 51);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log out";
            btnLogout.TextColor = Color.White;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnChangePass
            // 
            btnChangePass.BackColor = Color.FromArgb(80, 196, 237);
            btnChangePass.BackgroundColor = Color.FromArgb(80, 196, 237);
            btnChangePass.BorderColor = Color.PaleVioletRed;
            btnChangePass.BorderRadius = 10;
            btnChangePass.BorderSize = 0;
            btnChangePass.FlatAppearance.BorderSize = 0;
            btnChangePass.FlatStyle = FlatStyle.Flat;
            btnChangePass.ForeColor = Color.White;
            btnChangePass.Image = (Image)resources.GetObject("btnChangePass.Image");
            btnChangePass.ImageAlign = ContentAlignment.MiddleLeft;
            btnChangePass.Location = new Point(24, 84);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(158, 51);
            btnChangePass.TabIndex = 3;
            btnChangePass.Text = "Change password";
            btnChangePass.TextAlign = ContentAlignment.MiddleRight;
            btnChangePass.TextColor = Color.White;
            btnChangePass.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.FromArgb(95, 93, 156);
            btnHistory.BackgroundColor = Color.FromArgb(95, 93, 156);
            btnHistory.BorderColor = Color.PaleVioletRed;
            btnHistory.BorderRadius = 10;
            btnHistory.BorderSize = 0;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.ForeColor = Color.White;
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(24, 159);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(158, 51);
            btnHistory.TabIndex = 4;
            btnHistory.Text = "Purchase History";
            btnHistory.TextAlign = ContentAlignment.MiddleRight;
            btnHistory.TextColor = Color.White;
            btnHistory.UseVisualStyleBackColor = false;
            // 
            // PersonalInfor
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(984, 561);
            Controls.Add(panel2);
            Controls.Add(pnl_Infor);
            Name = "PersonalInfor";
            Text = "PersonalInfor";
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbUserImage).EndInit();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Infor;
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
    }
}