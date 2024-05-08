namespace QuanLyTraoDoiHang
{
    partial class CancelReason
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelReason));
            cBReason = new ComboBox();
            label1 = new Label();
            rButton1 = new RJControls.RButton();
            panel6 = new Panel();
            rButton2 = new RJControls.RButton();
            btnMinimize = new RJControls.RButton();
            btnExit = new RJControls.RButton();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // cBReason
            // 
            cBReason.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBReason.FormattingEnabled = true;
            cBReason.Items.AddRange(new object[] { "I do not like product anymore", "I have another choice", "I want to change my address" });
            cBReason.Location = new Point(184, 280);
            cBReason.Name = "cBReason";
            cBReason.Size = new Size(625, 29);
            cBReason.TabIndex = 0;
            cBReason.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(240, 223);
            label1.Name = "label1";
            label1.Size = new Size(528, 45);
            label1.TabIndex = 1;
            label1.Text = "WHY DO YOU WANT TO CANCEL?";
            // 
            // rButton1
            // 
            rButton1.BackColor = Color.FromArgb(255, 255, 192);
            rButton1.BackgroundColor = Color.FromArgb(255, 255, 192);
            rButton1.BorderColor = Color.PaleVioletRed;
            rButton1.BorderRadius = 20;
            rButton1.BorderSize = 0;
            rButton1.FlatAppearance.BorderSize = 0;
            rButton1.FlatStyle = FlatStyle.Flat;
            rButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rButton1.ForeColor = Color.Black;
            rButton1.Location = new Point(374, 341);
            rButton1.Name = "rButton1";
            rButton1.Size = new Size(247, 40);
            rButton1.TabIndex = 2;
            rButton1.Text = "Done";
            rButton1.TextColor = Color.Black;
            rButton1.UseVisualStyleBackColor = false;
            rButton1.Click += rButton1_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(rButton2);
            panel6.Controls.Add(btnMinimize);
            panel6.Controls.Add(btnExit);
            panel6.Location = new Point(2, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(103, 33);
            panel6.TabIndex = 20;
            // 
            // rButton2
            // 
            rButton2.BackColor = Color.FromArgb(128, 255, 128);
            rButton2.BackgroundColor = Color.FromArgb(128, 255, 128);
            rButton2.BorderColor = Color.PaleVioletRed;
            rButton2.BorderRadius = 21;
            rButton2.BorderSize = 0;
            rButton2.FlatAppearance.BorderSize = 0;
            rButton2.FlatStyle = FlatStyle.Flat;
            rButton2.ForeColor = Color.Wheat;
            rButton2.Image = (Image)resources.GetObject("rButton2.Image");
            rButton2.Location = new Point(69, 6);
            rButton2.Name = "rButton2";
            rButton2.Size = new Size(22, 22);
            rButton2.TabIndex = 20;
            rButton2.TextColor = Color.Wheat;
            rButton2.UseVisualStyleBackColor = false;
            rButton2.Click += rButton2_Click;
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
            btnMinimize.Location = new Point(42, 6);
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
            btnExit.Location = new Point(16, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(21, 21);
            btnExit.TabIndex = 0;
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // CancelReason
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 183, 65);
            ClientSize = new Size(982, 661);
            Controls.Add(panel6);
            Controls.Add(rButton1);
            Controls.Add(label1);
            Controls.Add(cBReason);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CancelReason";
            Opacity = 0.99D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CancelReason";
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox cBReason;
        private Label label1;
        private RJControls.RButton rButton1;
        private Panel panel6;
        private RJControls.RButton rButton2;
        private RJControls.RButton btnMinimize;
        private RJControls.RButton btnExit;
    }
}