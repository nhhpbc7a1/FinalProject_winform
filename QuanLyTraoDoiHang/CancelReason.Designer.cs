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
            cBReason = new ComboBox();
            label1 = new Label();
            rButton1 = new RJControls.RButton();
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
            // CancelReason
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(101, 183, 65);
            ClientSize = new Size(966, 622);
            Controls.Add(rButton1);
            Controls.Add(label1);
            Controls.Add(cBReason);
            Name = "CancelReason";
            Opacity = 0.7D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CancelReason";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox cBReason;
        private Label label1;
        private RJControls.RButton rButton1;
    }
}