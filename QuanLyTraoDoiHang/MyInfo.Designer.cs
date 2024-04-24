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
            panel3 = new Panel();
            panel2 = new Panel();
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
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(101, 183, 65);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(747, 72);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(747, 3);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(276, 22);
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
            btnSave.BackColor = Color.FromArgb(30, 106, 17);
            btnSave.BackgroundColor = Color.FromArgb(30, 106, 17);
            btnSave.BorderColor = Color.FromArgb(128, 255, 128);
            btnSave.BorderRadius = 40;
            btnSave.BorderSize = 0;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(235, 431);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(277, 42);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.FromArgb(224, 224, 224);
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
            flowLayoutPanel3.Size = new Size(313, 341);
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
            txtPersonalID.Size = new Size(277, 29);
            txtPersonalID.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(flowLayoutPanel3);
            panel1.Location = new Point(107, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(536, 347);
            panel1.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(59, 64);
            label8.Name = "label8";
            label8.Size = new Size(128, 21);
            label8.TabIndex = 20;
            label8.Text = "Identity number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(60, 112);
            label7.Name = "label7";
            label7.Size = new Size(71, 21);
            label7.TabIndex = 19;
            label7.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(60, 158);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 18;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(60, 205);
            label5.Name = "label5";
            label5.Size = new Size(117, 21);
            label5.TabIndex = 17;
            label5.Text = "Phone number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(60, 252);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 16;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(60, 302);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 15;
            label3.Text = "Gender";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 17);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 14;
            label1.Text = "Full name";
            // 
            // MyInfo
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(747, 502);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MyInfo";
            Text = "MyInfo";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}