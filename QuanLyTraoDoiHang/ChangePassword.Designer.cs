namespace QuanLyTraoDoiHang
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            ucReTypePass = new UCPasswordTextBox();
            ucNewPass = new UCPasswordTextBox();
            ucOldPass = new UCPasswordTextBox();
            lblRetypedPass = new Label();
            rButton3 = new RJControls.RButton();
            rButton4 = new RJControls.RButton();
            rButton2 = new RJControls.RButton();
            panel1 = new Panel();
            lblValidPass = new Label();
            label4 = new Label();
            btnChangePass = new RJControls.RButton();
            panel4 = new Panel();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(101, 183, 65);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(642, 72);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(230, 22);
            label2.Name = "label2";
            label2.Size = new Size(181, 30);
            label2.TabIndex = 2;
            label2.Text = "Change Password";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(244, 237, 204);
            panel2.Controls.Add(ucOldPass);
            panel2.Controls.Add(ucNewPass);
            panel2.Controls.Add(ucReTypePass);
            panel2.Controls.Add(lblRetypedPass);
            panel2.Controls.Add(rButton3);
            panel2.Controls.Add(rButton4);
            panel2.Controls.Add(rButton2);
            panel2.Controls.Add(panel1);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(10, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(620, 348);
            panel2.TabIndex = 6;
            // 
            // ucReTypePass
            // 
            ucReTypePass.BackColor = Color.White;
            ucReTypePass.Location = new Point(166, 225);
            ucReTypePass.Margin = new Padding(3, 2, 3, 2);
            ucReTypePass.Name = "ucReTypePass";
            ucReTypePass.Size = new Size(332, 29);
            ucReTypePass.TabIndex = 28;
            // 
            // ucNewPass
            // 
            ucNewPass.BackColor = Color.White;
            ucNewPass.Location = new Point(169, 115);
            ucNewPass.Margin = new Padding(3, 2, 3, 2);
            ucNewPass.Name = "ucNewPass";
            ucNewPass.Size = new Size(329, 29);
            ucNewPass.TabIndex = 29;
            // 
            // ucOldPass
            // 
            ucOldPass.BackColor = Color.White;
            ucOldPass.Location = new Point(169, 57);
            ucOldPass.Margin = new Padding(3, 2, 3, 2);
            ucOldPass.Name = "ucOldPass";
            ucOldPass.Size = new Size(329, 29);
            ucOldPass.TabIndex = 30;
            // 
            // lblRetypedPass
            // 
            lblRetypedPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRetypedPass.ForeColor = Color.Black;
            lblRetypedPass.Location = new Point(169, 269);
            lblRetypedPass.Name = "lblRetypedPass";
            lblRetypedPass.Size = new Size(313, 39);
            lblRetypedPass.TabIndex = 4;
            lblRetypedPass.Text = "Retyped-new password need to be matched with the new password.";
            // 
            // rButton3
            // 
            rButton3.BackColor = Color.FromArgb(36, 10, 52);
            rButton3.BackgroundColor = Color.FromArgb(36, 10, 52);
            rButton3.BorderColor = Color.PaleVioletRed;
            rButton3.BorderRadius = 38;
            rButton3.BorderSize = 0;
            rButton3.FlatAppearance.BorderSize = 0;
            rButton3.FlatStyle = FlatStyle.Flat;
            rButton3.ForeColor = Color.White;
            rButton3.Image = (Image)resources.GetObject("rButton3.Image");
            rButton3.Location = new Point(105, 50);
            rButton3.Name = "rButton3";
            rButton3.Size = new Size(38, 38);
            rButton3.TabIndex = 26;
            rButton3.TextColor = Color.White;
            rButton3.UseVisualStyleBackColor = false;
            // 
            // rButton4
            // 
            rButton4.BackColor = Color.FromArgb(36, 10, 52);
            rButton4.BackgroundColor = Color.FromArgb(36, 10, 52);
            rButton4.BorderColor = Color.PaleVioletRed;
            rButton4.BorderRadius = 38;
            rButton4.BorderSize = 0;
            rButton4.FlatAppearance.BorderSize = 0;
            rButton4.FlatStyle = FlatStyle.Flat;
            rButton4.ForeColor = Color.White;
            rButton4.Image = (Image)resources.GetObject("rButton4.Image");
            rButton4.Location = new Point(105, 220);
            rButton4.Name = "rButton4";
            rButton4.Size = new Size(38, 38);
            rButton4.TabIndex = 25;
            rButton4.TextColor = Color.White;
            rButton4.UseVisualStyleBackColor = false;
            // 
            // rButton2
            // 
            rButton2.BackColor = Color.FromArgb(36, 10, 52);
            rButton2.BackgroundColor = Color.FromArgb(36, 10, 52);
            rButton2.BorderColor = Color.PaleVioletRed;
            rButton2.BorderRadius = 38;
            rButton2.BorderSize = 0;
            rButton2.FlatAppearance.BorderSize = 0;
            rButton2.FlatStyle = FlatStyle.Flat;
            rButton2.ForeColor = Color.White;
            rButton2.Image = (Image)resources.GetObject("rButton2.Image");
            rButton2.Location = new Point(105, 110);
            rButton2.Name = "rButton2";
            rButton2.Size = new Size(38, 38);
            rButton2.TabIndex = 23;
            rButton2.TextColor = Color.White;
            rButton2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblValidPass);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(169, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 71);
            panel1.TabIndex = 8;
            // 
            // lblValidPass
            // 
            lblValidPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblValidPass.ForeColor = Color.Black;
            lblValidPass.Location = new Point(3, 29);
            lblValidPass.Name = "lblValidPass";
            lblValidPass.Size = new Size(323, 39);
            lblValidPass.TabIndex = 4;
            lblValidPass.Text = "Choose a more secure password you don't use anywhere else. It should be longer than 6 characters.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(125, 17);
            label4.TabIndex = 5;
            label4.Text = "Password strength:";
            // 
            // btnChangePass
            // 
            btnChangePass.BackColor = Color.FromArgb(36, 10, 52);
            btnChangePass.BackgroundColor = Color.FromArgb(36, 10, 52);
            btnChangePass.BorderColor = Color.FromArgb(30, 106, 17);
            btnChangePass.BorderRadius = 40;
            btnChangePass.BorderSize = 1;
            btnChangePass.Enabled = false;
            btnChangePass.FlatAppearance.BorderSize = 0;
            btnChangePass.FlatStyle = FlatStyle.Flat;
            btnChangePass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePass.ForeColor = Color.White;
            btnChangePass.Location = new Point(152, 441);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(326, 42);
            btnChangePass.TabIndex = 10;
            btnChangePass.Text = "Change";
            btnChangePass.TextColor = Color.White;
            btnChangePass.UseVisualStyleBackColor = false;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 69);
            panel4.Name = "panel4";
            panel4.Size = new Size(642, 3);
            panel4.TabIndex = 5;
            // 
            // ChangePassword
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(244, 237, 204);
            ClientSize = new Size(642, 495);
            Controls.Add(btnChangePass);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "ChangePassword";
            Text = "ChangePassword";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private RJControls.RButton rButton3;
        private RJControls.RButton rButton4;
        private RJControls.RButton rButton2;
        private RJControls.RButton btnChangePass;
        private UCPasswordTextBox ucOldPass;
        private UCPasswordTextBox ucNewPass;
        private UCPasswordTextBox ucReTypePass;
        private Panel panel1;
        private Label lblValidPass;
        private Label lblRetypedPass;
        private Panel panel4;
    }
}