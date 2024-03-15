using FontAwesome.Sharp;

namespace QuanLyTraoDoiHang
{
    partial class Mainpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainpage));
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            rButton2 = new RJControls.RButton();
            panel5 = new Panel();
            rButton4 = new RJControls.RButton();
            label5 = new Label();
            rButton1 = new RJControls.RButton();
            rButton3 = new RJControls.RButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pnl_Body = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.DropDownWidth = 498;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = SystemColors.InfoText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "totoro model", "susuwatari model", "snow ball" });
            comboBox1.Location = new Point(254, 13);
            comboBox1.Margin = new Padding(6, 3, 6, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(406, 62);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 237, 204);
            panel1.Controls.Add(rButton2);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(rButton1);
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 55);
            panel1.TabIndex = 10;
            // 
            // rButton2
            // 
            rButton2.BackColor = Color.FromArgb(244, 237, 204);
            rButton2.BackgroundColor = Color.FromArgb(244, 237, 204);
            rButton2.BackgroundImageLayout = ImageLayout.Stretch;
            rButton2.BorderColor = Color.FromArgb(244, 237, 204);
            rButton2.BorderRadius = 20;
            rButton2.BorderSize = 0;
            rButton2.FlatAppearance.BorderSize = 0;
            rButton2.FlatStyle = FlatStyle.Flat;
            rButton2.ForeColor = Color.White;
            rButton2.Image = (Image)resources.GetObject("rButton2.Image");
            rButton2.Location = new Point(776, 7);
            rButton2.Name = "rButton2";
            rButton2.Size = new Size(59, 43);
            rButton2.TabIndex = 3;
            rButton2.TextColor = Color.White;
            rButton2.UseVisualStyleBackColor = false;
            rButton2.Click += rButton2_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(rButton4);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(111, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(134, 55);
            panel5.TabIndex = 1;
            // 
            // rButton4
            // 
            rButton4.BackColor = Color.FromArgb(244, 237, 204);
            rButton4.BackgroundColor = Color.FromArgb(244, 237, 204);
            rButton4.BackgroundImage = (Image)resources.GetObject("rButton4.BackgroundImage");
            rButton4.BackgroundImageLayout = ImageLayout.Stretch;
            rButton4.BorderColor = Color.FromArgb(244, 237, 204);
            rButton4.BorderRadius = 20;
            rButton4.BorderSize = 0;
            rButton4.FlatAppearance.BorderSize = 0;
            rButton4.FlatStyle = FlatStyle.Flat;
            rButton4.ForeColor = Color.White;
            rButton4.Location = new Point(6, 2);
            rButton4.Name = "rButton4";
            rButton4.Size = new Size(68, 50);
            rButton4.TabIndex = 0;
            rButton4.TextColor = Color.White;
            rButton4.UseVisualStyleBackColor = false;
            rButton4.Click += rButton4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(30, 106, 17);
            label5.Location = new Point(71, 17);
            label5.Name = "label5";
            label5.Size = new Size(126, 49);
            label5.TabIndex = 1;
            label5.Text = "KoHa";
            // 
            // rButton1
            // 
            rButton1.BackColor = Color.FromArgb(97, 150, 166);
            rButton1.BackgroundColor = Color.FromArgb(97, 150, 166);
            rButton1.BackgroundImageLayout = ImageLayout.Stretch;
            rButton1.BorderColor = Color.PaleVioletRed;
            rButton1.BorderRadius = 4;
            rButton1.BorderSize = 0;
            rButton1.FlatAppearance.BorderSize = 0;
            rButton1.FlatStyle = FlatStyle.Flat;
            rButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rButton1.ForeColor = Color.White;
            rButton1.Image = (Image)resources.GetObject("rButton1.Image");
            rButton1.ImageAlign = ContentAlignment.MiddleLeft;
            rButton1.Location = new Point(669, 10);
            rButton1.Name = "rButton1";
            rButton1.Size = new Size(101, 32);
            rButton1.TabIndex = 19;
            rButton1.Text = "Search";
            rButton1.TextAlign = ContentAlignment.MiddleRight;
            rButton1.TextColor = Color.White;
            rButton1.UseVisualStyleBackColor = false;
            rButton1.Click += rButton1_Click;
            // 
            // rButton3
            // 
            rButton3.BackColor = Color.YellowGreen;
            rButton3.BackgroundColor = Color.YellowGreen;
            rButton3.BorderColor = Color.PaleVioletRed;
            rButton3.BorderRadius = 20;
            rButton3.BorderSize = 0;
            rButton3.FlatAppearance.BorderSize = 0;
            rButton3.FlatStyle = FlatStyle.Flat;
            rButton3.ForeColor = Color.White;
            rButton3.Location = new Point(537, 1);
            rButton3.Name = "rButton3";
            rButton3.Size = new Size(88, 40);
            rButton3.TabIndex = 0;
            rButton3.Text = "account";
            rButton3.TextColor = Color.White;
            rButton3.UseVisualStyleBackColor = false;
            rButton3.Click += rButton3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(136, 12);
            label1.Name = "label1";
            label1.Size = new Size(136, 51);
            label1.TabIndex = 14;
            label1.Text = "Sign in";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(224, 12);
            label2.Name = "label2";
            label2.Size = new Size(149, 51);
            label2.TabIndex = 15;
            label2.Text = "Sign up";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 12);
            label3.Name = "label3";
            label3.Size = new Size(255, 51);
            label3.TabIndex = 16;
            label3.Text = "Seller channel";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(164, 206, 149);
            panel2.Controls.Add(rButton3);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 45);
            panel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(164, 206, 149);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(674, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(307, 44);
            panel3.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(982, 100);
            panel4.TabIndex = 18;
            // 
            // pnl_Body
            // 
            pnl_Body.Dock = DockStyle.Fill;
            pnl_Body.Location = new Point(0, 100);
            pnl_Body.Name = "pnl_Body";
            pnl_Body.Size = new Size(982, 553);
            pnl_Body.TabIndex = 19;
            pnl_Body.Paint += pnl_Body_Paint;
            // 
            // Mainpage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            ClientSize = new Size(982, 653);
            Controls.Add(pnl_Body);
            Controls.Add(panel4);
            Name = "Mainpage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mainpage";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBox1;
        private Panel panel1;
        private IconPictureBox iconPictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private RJControls.RButton rButton1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label5;
        private RJControls.RButton rButton2;
        private RJControls.RButton rButton3;
        private RJControls.RButton rButton4;
        public Panel pnl_Body;
    }
}