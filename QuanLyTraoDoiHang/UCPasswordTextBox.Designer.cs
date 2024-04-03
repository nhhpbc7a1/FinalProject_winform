namespace QuanLyTraoDoiHang
{
    partial class UCPasswordTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPasswordTextBox));
            btnShow = new RJControls.RButton();
            btnHide = new RJControls.RButton();
            txtPass = new TextBox();
            SuspendLayout();
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.White;
            btnShow.BackgroundColor = Color.White;
            btnShow.BackgroundImage = (Image)resources.GetObject("btnShow.BackgroundImage");
            btnShow.BackgroundImageLayout = ImageLayout.Stretch;
            btnShow.BorderColor = Color.PaleVioletRed;
            btnShow.BorderRadius = 0;
            btnShow.BorderSize = 0;
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.ForeColor = Color.White;
            btnShow.Location = new Point(178, 3);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(23, 21);
            btnShow.TabIndex = 20;
            btnShow.TextColor = Color.White;
            btnShow.UseVisualStyleBackColor = false;
            // 
            // btnHide
            // 
            btnHide.BackColor = Color.White;
            btnHide.BackgroundColor = Color.White;
            btnHide.BackgroundImage = (Image)resources.GetObject("btnHide.BackgroundImage");
            btnHide.BackgroundImageLayout = ImageLayout.Stretch;
            btnHide.BorderColor = Color.PaleVioletRed;
            btnHide.BorderRadius = 0;
            btnHide.BorderSize = 0;
            btnHide.FlatAppearance.BorderSize = 0;
            btnHide.FlatStyle = FlatStyle.Flat;
            btnHide.ForeColor = Color.White;
            btnHide.Location = new Point(178, 3);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(23, 21);
            btnHide.TabIndex = 19;
            btnHide.TextColor = Color.White;
            btnHide.UseVisualStyleBackColor = false;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.White;
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Dock = DockStyle.Fill;
            txtPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(0, 0);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "  Old password";
            txtPass.Size = new Size(222, 29);
            txtPass.TabIndex = 18;
            txtPass.UseSystemPasswordChar = true;
            // 
            // UCPasswordTextBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(btnHide);
            Controls.Add(btnShow);
            Controls.Add(txtPass);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCPasswordTextBox";
            Size = new Size(222, 47);
            Load += UCPasswordTextBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RJControls.RButton btnShow;
        private RJControls.RButton btnHide;
        public TextBox txtPass;
    }
}
