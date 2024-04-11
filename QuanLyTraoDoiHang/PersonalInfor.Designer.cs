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
            pnl_Infor.Location = new Point(226, 32);
            pnl_Infor.Name = "pnl_Infor";
            pnl_Infor.Size = new Size(736, 502);
            pnl_Infor.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(lblChangeImage);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 561);
            panel2.TabIndex = 1;
            // 
            // lblChangeImage
            // 
            lblChangeImage.Anchor = AnchorStyles.None;
            lblChangeImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblChangeImage.ForeColor = Color.Green;
            lblChangeImage.Image = (Image)resources.GetObject("lblChangeImage.Image");
            lblChangeImage.ImageAlign = ContentAlignment.MiddleRight;
            lblChangeImage.Location = new Point(27, 163);
            lblChangeImage.Name = "lblChangeImage";
            lblChangeImage.Size = new Size(158, 30);
            lblChangeImage.TabIndex = 8;
            lblChangeImage.Text = "Change profile";
            lblChangeImage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.BackColor = Color.WhiteSmoke;
            panel8.Controls.Add(ptbUserImage);
            panel8.Controls.Add(lblUsername);
            panel8.Location = new Point(44, 33);
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
            lblUsername.BackColor = Color.WhiteSmoke;
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
            panel7.BackColor = Color.WhiteSmoke;
            panel7.Controls.Add(btnUpdateInfo);
            panel7.Controls.Add(btnLogout);
            panel7.Controls.Add(btnChangePass);
            panel7.Controls.Add(btnHistory);
            panel7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel7.Location = new Point(8, 204);
            panel7.Name = "panel7";
            panel7.Size = new Size(197, 314);
            panel7.TabIndex = 6;
            // 
            // btnUpdateInfo
            // 
            btnUpdateInfo.BackColor = Color.FromArgb(36, 10, 52);
            btnUpdateInfo.BackgroundColor = Color.FromArgb(36, 10, 52);
            btnUpdateInfo.BorderColor = Color.PaleVioletRed;
            btnUpdateInfo.BorderRadius = 10;
            btnUpdateInfo.BorderSize = 0;
            btnUpdateInfo.FlatAppearance.BorderSize = 0;
            btnUpdateInfo.FlatStyle = FlatStyle.Flat;
            btnUpdateInfo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateInfo.ForeColor = Color.White;
            btnUpdateInfo.Image = (Image)resources.GetObject("btnUpdateInfo.Image");
            btnUpdateInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateInfo.Location = new Point(13, 14);
            btnUpdateInfo.Name = "btnUpdateInfo";
            btnUpdateInfo.Size = new Size(169, 51);
            btnUpdateInfo.TabIndex = 2;
            btnUpdateInfo.Text = "Update info";
            btnUpdateInfo.TextColor = Color.White;
            btnUpdateInfo.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(248, 196, 180);
            btnLogout.BackgroundColor = Color.FromArgb(248, 196, 180);
            btnLogout.BorderColor = Color.PaleVioletRed;
            btnLogout.BorderRadius = 10;
            btnLogout.BorderSize = 0;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Black;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(13, 233);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(169, 51);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log out";
            btnLogout.TextColor = Color.Black;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnChangePass
            // 
            btnChangePass.BackColor = Color.FromArgb(249, 232, 151);
            btnChangePass.BackgroundColor = Color.FromArgb(249, 232, 151);
            btnChangePass.BorderColor = Color.PaleVioletRed;
            btnChangePass.BorderRadius = 10;
            btnChangePass.BorderSize = 0;
            btnChangePass.FlatAppearance.BorderSize = 0;
            btnChangePass.FlatStyle = FlatStyle.Flat;
            btnChangePass.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePass.ForeColor = Color.Black;
            btnChangePass.Image = (Image)resources.GetObject("btnChangePass.Image");
            btnChangePass.ImageAlign = ContentAlignment.MiddleLeft;
            btnChangePass.Location = new Point(13, 84);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(169, 51);
            btnChangePass.TabIndex = 3;
            btnChangePass.Text = "Change password";
            btnChangePass.TextAlign = ContentAlignment.MiddleRight;
            btnChangePass.TextColor = Color.Black;
            btnChangePass.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.FromArgb(36, 10, 52);
            btnHistory.BackgroundColor = Color.FromArgb(36, 10, 52);
            btnHistory.BorderColor = Color.PaleVioletRed;
            btnHistory.BorderRadius = 10;
            btnHistory.BorderSize = 0;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistory.ForeColor = Color.White;
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(13, 159);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(169, 51);
            btnHistory.TabIndex = 4;
            btnHistory.Text = "Purchase History";
            btnHistory.TextAlign = ContentAlignment.MiddleRight;
            btnHistory.TextColor = Color.White;
            btnHistory.UseVisualStyleBackColor = false;
            // 
            // PersonalInfor
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
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