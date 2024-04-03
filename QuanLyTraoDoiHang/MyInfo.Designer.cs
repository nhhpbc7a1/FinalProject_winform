namespace QuanLyTraoDoiHang
{
    partial class MyInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyInfo));
            panel3 = new Panel();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            radioBtnFemale = new RadioButton();
            radioBtnMale = new RadioButton();
            radioBtnOther = new RadioButton();
            txtAddress = new TextBox();
            dtBirthday = new DateTimePicker();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            btnSave = new RJControls.RButton();
            flowLayoutPanel3 = new FlowLayoutPanel();
            txtPersonalID = new TextBox();
            rButton3 = new RJControls.RButton();
            flowLayoutPanel4 = new FlowLayoutPanel();
            rButton2 = new RJControls.RButton();
            rButton1 = new RJControls.RButton();
            rButton4 = new RJControls.RButton();
            rButton5 = new RJControls.RButton();
            rButton6 = new RJControls.RButton();
            rButton7 = new RJControls.RButton();
            panel1 = new Panel();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(642, 72);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(210, 21);
            label2.Name = "label2";
            label2.Size = new Size(213, 30);
            label2.TabIndex = 3;
            label2.Text = "Personal Information";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(radioBtnFemale);
            flowLayoutPanel1.Controls.Add(radioBtnMale);
            flowLayoutPanel1.Controls.Add(radioBtnOther);
            flowLayoutPanel1.Location = new Point(10, 291);
            flowLayoutPanel1.Margin = new Padding(10, 9, 10, 9);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(277, 42);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // radioBtnFemale
            // 
            radioBtnFemale.AutoSize = true;
            radioBtnFemale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnFemale.Location = new Point(3, 3);
            radioBtnFemale.Name = "radioBtnFemale";
            radioBtnFemale.Size = new Size(78, 25);
            radioBtnFemale.TabIndex = 12;
            radioBtnFemale.TabStop = true;
            radioBtnFemale.Text = "Female";
            radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // radioBtnMale
            // 
            radioBtnMale.AutoSize = true;
            radioBtnMale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnMale.Location = new Point(87, 3);
            radioBtnMale.Name = "radioBtnMale";
            radioBtnMale.Size = new Size(62, 25);
            radioBtnMale.TabIndex = 13;
            radioBtnMale.TabStop = true;
            radioBtnMale.Text = "Male";
            radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // radioBtnOther
            // 
            radioBtnOther.AutoSize = true;
            radioBtnOther.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnOther.Location = new Point(155, 3);
            radioBtnOther.Name = "radioBtnOther";
            radioBtnOther.Size = new Size(68, 25);
            radioBtnOther.TabIndex = 14;
            radioBtnOther.TabStop = true;
            radioBtnOther.Text = "Other";
            radioBtnOther.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.ControlLightLight;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(10, 244);
            txtAddress.Margin = new Padding(10, 9, 10, 9);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(277, 29);
            txtAddress.TabIndex = 5;
            // 
            // dtBirthday
            // 
            dtBirthday.CalendarMonthBackground = SystemColors.Control;
            dtBirthday.CalendarTitleBackColor = Color.Black;
            dtBirthday.CalendarTitleForeColor = SystemColors.ControlDarkDark;
            dtBirthday.CalendarTrailingForeColor = SystemColors.ButtonShadow;
            dtBirthday.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtBirthday.Format = DateTimePickerFormat.Short;
            dtBirthday.Location = new Point(10, 103);
            dtBirthday.Margin = new Padding(10, 9, 10, 9);
            dtBirthday.Name = "dtBirthday";
            dtBirthday.Size = new Size(277, 29);
            dtBirthday.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.ControlLightLight;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(10, 197);
            txtPhone.Margin = new Padding(10, 9, 10, 9);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone number";
            txtPhone.Size = new Size(277, 29);
            txtPhone.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLightLight;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(10, 150);
            txtEmail.Margin = new Padding(10, 9, 10, 9);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(277, 29);
            txtEmail.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ControlLightLight;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(10, 9);
            txtName.Margin = new Padding(10, 9, 10, 9);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Full name";
            txtName.Size = new Size(277, 29);
            txtName.TabIndex = 0;
            txtName.Text = "   ";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(101, 183, 65);
            btnSave.BackgroundColor = Color.FromArgb(101, 183, 65);
            btnSave.BorderColor = Color.FromArgb(30, 106, 17);
            btnSave.BorderRadius = 40;
            btnSave.BorderSize = 1;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(191, 441);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(277, 42);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(txtName);
            flowLayoutPanel3.Controls.Add(txtPersonalID);
            flowLayoutPanel3.Controls.Add(dtBirthday);
            flowLayoutPanel3.Controls.Add(txtEmail);
            flowLayoutPanel3.Controls.Add(txtPhone);
            flowLayoutPanel3.Controls.Add(txtAddress);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel3.Location = new Point(190, 6);
            flowLayoutPanel3.Margin = new Padding(0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(428, 344);
            flowLayoutPanel3.TabIndex = 10;
            // 
            // txtPersonalID
            // 
            txtPersonalID.BackColor = SystemColors.ControlLightLight;
            txtPersonalID.BorderStyle = BorderStyle.FixedSingle;
            txtPersonalID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPersonalID.Location = new Point(10, 56);
            txtPersonalID.Margin = new Padding(10, 9, 10, 9);
            txtPersonalID.Name = "txtPersonalID";
            txtPersonalID.PlaceholderText = "Identity number";
            txtPersonalID.Size = new Size(277, 29);
            txtPersonalID.TabIndex = 1;
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
            rButton3.Location = new Point(3, 5);
            rButton3.Margin = new Padding(3, 5, 3, 5);
            rButton3.Name = "rButton3";
            rButton3.Size = new Size(38, 38);
            rButton3.TabIndex = 27;
            rButton3.TextColor = Color.White;
            rButton3.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(rButton3);
            flowLayoutPanel4.Controls.Add(rButton2);
            flowLayoutPanel4.Controls.Add(rButton1);
            flowLayoutPanel4.Controls.Add(rButton4);
            flowLayoutPanel4.Controls.Add(rButton5);
            flowLayoutPanel4.Controls.Add(rButton6);
            flowLayoutPanel4.Controls.Add(rButton7);
            flowLayoutPanel4.Location = new Point(124, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(47, 340);
            flowLayoutPanel4.TabIndex = 13;
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
            rButton2.Location = new Point(3, 53);
            rButton2.Margin = new Padding(3, 5, 3, 5);
            rButton2.Name = "rButton2";
            rButton2.Size = new Size(38, 38);
            rButton2.TabIndex = 29;
            rButton2.TextColor = Color.White;
            rButton2.UseVisualStyleBackColor = false;
            // 
            // rButton1
            // 
            rButton1.BackColor = Color.FromArgb(36, 10, 52);
            rButton1.BackgroundColor = Color.FromArgb(36, 10, 52);
            rButton1.BorderColor = Color.PaleVioletRed;
            rButton1.BorderRadius = 38;
            rButton1.BorderSize = 0;
            rButton1.FlatAppearance.BorderSize = 0;
            rButton1.FlatStyle = FlatStyle.Flat;
            rButton1.ForeColor = Color.White;
            rButton1.Image = (Image)resources.GetObject("rButton1.Image");
            rButton1.Location = new Point(3, 101);
            rButton1.Margin = new Padding(3, 5, 3, 5);
            rButton1.Name = "rButton1";
            rButton1.Size = new Size(38, 38);
            rButton1.TabIndex = 28;
            rButton1.TextColor = Color.White;
            rButton1.UseVisualStyleBackColor = false;
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
            rButton4.Location = new Point(3, 149);
            rButton4.Margin = new Padding(3, 5, 3, 5);
            rButton4.Name = "rButton4";
            rButton4.Size = new Size(38, 38);
            rButton4.TabIndex = 30;
            rButton4.TextColor = Color.White;
            rButton4.UseVisualStyleBackColor = false;
            // 
            // rButton5
            // 
            rButton5.BackColor = Color.FromArgb(36, 10, 52);
            rButton5.BackgroundColor = Color.FromArgb(36, 10, 52);
            rButton5.BorderColor = Color.PaleVioletRed;
            rButton5.BorderRadius = 38;
            rButton5.BorderSize = 0;
            rButton5.FlatAppearance.BorderSize = 0;
            rButton5.FlatStyle = FlatStyle.Flat;
            rButton5.ForeColor = Color.White;
            rButton5.Image = (Image)resources.GetObject("rButton5.Image");
            rButton5.Location = new Point(3, 197);
            rButton5.Margin = new Padding(3, 5, 3, 5);
            rButton5.Name = "rButton5";
            rButton5.Size = new Size(38, 38);
            rButton5.TabIndex = 31;
            rButton5.TextColor = Color.White;
            rButton5.UseVisualStyleBackColor = false;
            // 
            // rButton6
            // 
            rButton6.BackColor = Color.FromArgb(36, 10, 52);
            rButton6.BackgroundColor = Color.FromArgb(36, 10, 52);
            rButton6.BorderColor = Color.PaleVioletRed;
            rButton6.BorderRadius = 38;
            rButton6.BorderSize = 0;
            rButton6.FlatAppearance.BorderSize = 0;
            rButton6.FlatStyle = FlatStyle.Flat;
            rButton6.ForeColor = Color.White;
            rButton6.Image = (Image)resources.GetObject("rButton6.Image");
            rButton6.Location = new Point(3, 245);
            rButton6.Margin = new Padding(3, 5, 3, 5);
            rButton6.Name = "rButton6";
            rButton6.Size = new Size(38, 38);
            rButton6.TabIndex = 32;
            rButton6.TextColor = Color.White;
            rButton6.UseVisualStyleBackColor = false;
            // 
            // rButton7
            // 
            rButton7.BackColor = Color.FromArgb(36, 10, 52);
            rButton7.BackgroundColor = Color.FromArgb(36, 10, 52);
            rButton7.BorderColor = Color.PaleVioletRed;
            rButton7.BorderRadius = 38;
            rButton7.BorderSize = 0;
            rButton7.FlatAppearance.BorderSize = 0;
            rButton7.FlatStyle = FlatStyle.Flat;
            rButton7.ForeColor = Color.White;
            rButton7.Image = (Image)resources.GetObject("rButton7.Image");
            rButton7.Location = new Point(3, 293);
            rButton7.Margin = new Padding(3, 5, 3, 5);
            rButton7.Name = "rButton7";
            rButton7.Size = new Size(38, 38);
            rButton7.TabIndex = 33;
            rButton7.TextColor = Color.White;
            rButton7.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 237, 219);
            panel1.Controls.Add(flowLayoutPanel4);
            panel1.Controls.Add(flowLayoutPanel3);
            panel1.Location = new Point(12, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 360);
            panel1.TabIndex = 14;
            // 
            // MyInfo
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(642, 495);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Controls.Add(panel3);
            Name = "MyInfo";
            Text = "MyInfo";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private DateTimePicker dtBirthday;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtName;
        private RJControls.RButton btnSave;
        private Label label2;
        private TextBox txtAddress;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton radioBtnFemale;
        private RadioButton radioBtnMale;
        private RadioButton radioBtnOther;
        private FlowLayoutPanel flowLayoutPanel3;
        private TextBox txtPersonalID;
        private RJControls.RButton rButton3;
        private FlowLayoutPanel flowLayoutPanel4;
        private RJControls.RButton rButton2;
        private RJControls.RButton rButton1;
        private RJControls.RButton rButton4;
        private RJControls.RButton rButton5;
        private RJControls.RButton rButton6;
        private RJControls.RButton rButton7;
        private Panel panel1;
    }
}