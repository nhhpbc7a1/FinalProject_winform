namespace QuanLyTraoDoiHang
{
    partial class FormAddReceiveInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddReceiveInfo));
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            btnSave = new RJControls.RButton();
            panel2 = new Panel();
            panel3 = new Panel();
            btnDeliverAdress = new RJControls.RButton();
            panel1 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            label2 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(27, 150);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Full name";
            txtName.Size = new Size(726, 22);
            txtName.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(27, 202);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone number";
            txtPhone.Size = new Size(389, 22);
            txtPhone.TabIndex = 0;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(27, 343);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Detailed Address";
            txtAddress.Size = new Size(916, 22);
            txtAddress.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(101, 183, 65);
            btnSave.BackgroundColor = Color.FromArgb(101, 183, 65);
            btnSave.BorderColor = Color.White;
            btnSave.BorderRadius = 10;
            btnSave.BorderSize = 1;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(367, 24);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(222, 48);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnDeliverAdress);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 65);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Green;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(982, 2);
            panel3.TabIndex = 1;
            // 
            // btnDeliverAdress
            // 
            btnDeliverAdress.BackColor = SystemColors.ControlLightLight;
            btnDeliverAdress.BackgroundColor = SystemColors.ControlLightLight;
            btnDeliverAdress.BorderColor = Color.PaleVioletRed;
            btnDeliverAdress.BorderRadius = 20;
            btnDeliverAdress.BorderSize = 0;
            btnDeliverAdress.FlatAppearance.BorderSize = 0;
            btnDeliverAdress.FlatStyle = FlatStyle.Flat;
            btnDeliverAdress.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeliverAdress.ForeColor = Color.Black;
            btnDeliverAdress.Image = (Image)resources.GetObject("btnDeliverAdress.Image");
            btnDeliverAdress.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeliverAdress.Location = new Point(3, 12);
            btnDeliverAdress.Name = "btnDeliverAdress";
            btnDeliverAdress.Size = new Size(161, 40);
            btnDeliverAdress.TabIndex = 0;
            btnDeliverAdress.Text = "Edit Address";
            btnDeliverAdress.TextAlign = ContentAlignment.MiddleRight;
            btnDeliverAdress.TextColor = Color.Black;
            btnDeliverAdress.UseVisualStyleBackColor = false;
            btnDeliverAdress.Click += btnDeliverAdress_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(101, 183, 65);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 567);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 94);
            panel1.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(238, 234, 234);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 65);
            panel4.Name = "panel4";
            panel4.Size = new Size(982, 38);
            panel4.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(27, 8);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 0;
            label1.Text = "Contact";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(238, 234, 234);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(0, 274);
            panel5.Name = "panel5";
            panel5.Size = new Size(982, 38);
            panel5.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(27, 8);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 1;
            label2.Text = "Address";
            // 
            // FormAddReceiveInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 661);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddReceiveInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddReceiveInfo";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private RJControls.RButton btnSave;
        private Panel panel2;
        private Panel panel3;
        private RJControls.RButton btnDeliverAdress;
        private Panel panel1;
        private Panel panel4;
        private Label label1;
        private Panel panel5;
        private Label label2;
    }
}