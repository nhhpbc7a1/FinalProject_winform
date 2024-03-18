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
            btnCart = new RJControls.RButton();
            panel5 = new Panel();
            btnMainPage = new RJControls.RButton();
            label5 = new Label();
            btnSearch = new RJControls.RButton();
            rButton3 = new RJControls.RButton();
            lblSignin = new Label();
            lblSignup = new Label();
            lblSellerChannel = new Label();
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
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.DropDownWidth = 498;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = SystemColors.InfoText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "totoro model", "susuwatari model", "snow ball" });
            comboBox1.Location = new Point(254, 13);
            comboBox1.Margin = new Padding(6, 3, 6, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(406, 36);
            comboBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(193, 242, 176);
            panel1.Controls.Add(btnCart);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 55);
            panel1.TabIndex = 10;
            // 
            // btnCart
            // 
            btnCart.Anchor = AnchorStyles.None;
            btnCart.BackColor = Color.FromArgb(193, 242, 176);
            btnCart.BackgroundColor = Color.FromArgb(193, 242, 176);
            btnCart.BackgroundImageLayout = ImageLayout.Stretch;
            btnCart.BorderColor = Color.FromArgb(244, 237, 204);
            btnCart.BorderRadius = 20;
            btnCart.BorderSize = 0;
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.ForeColor = Color.White;
            btnCart.Image = (Image)resources.GetObject("btnCart.Image");
            btnCart.Location = new Point(776, 7);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(59, 43);
            btnCart.TabIndex = 3;
            btnCart.TextColor = Color.White;
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.Controls.Add(btnMainPage);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(111, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(134, 55);
            panel5.TabIndex = 1;
            // 
            // btnMainPage
            // 
            btnMainPage.BackColor = Color.FromArgb(193, 242, 176);
            btnMainPage.BackgroundColor = Color.FromArgb(193, 242, 176);
            btnMainPage.BackgroundImage = (Image)resources.GetObject("btnMainPage.BackgroundImage");
            btnMainPage.BackgroundImageLayout = ImageLayout.Stretch;
            btnMainPage.BorderColor = Color.FromArgb(244, 237, 204);
            btnMainPage.BorderRadius = 20;
            btnMainPage.BorderSize = 0;
            btnMainPage.FlatAppearance.BorderSize = 0;
            btnMainPage.FlatStyle = FlatStyle.Flat;
            btnMainPage.ForeColor = Color.White;
            btnMainPage.Location = new Point(6, 2);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Size = new Size(68, 50);
            btnMainPage.TabIndex = 0;
            btnMainPage.TextColor = Color.White;
            btnMainPage.UseVisualStyleBackColor = false;
            btnMainPage.Click += btnMainPage_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(30, 106, 17);
            label5.Location = new Point(71, 17);
            label5.Name = "label5";
            label5.Size = new Size(63, 23);
            label5.TabIndex = 1;
            label5.Text = "KoHa";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.BackColor = Color.FromArgb(104, 149, 210);
            btnSearch.BackgroundColor = Color.FromArgb(104, 149, 210);
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.BorderColor = Color.PaleVioletRed;
            btnSearch.BorderRadius = 5;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(669, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 32);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
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
            // lblSignin
            // 
            lblSignin.AutoSize = true;
            lblSignin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSignin.ForeColor = SystemColors.ButtonHighlight;
            lblSignin.Location = new Point(136, 12);
            lblSignin.Name = "lblSignin";
            lblSignin.Size = new Size(70, 25);
            lblSignin.TabIndex = 14;
            lblSignin.Text = "Sign in";
            lblSignin.Click += lblSignin_Click;
            // 
            // lblSignup
            // 
            lblSignup.AutoSize = true;
            lblSignup.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSignup.ForeColor = SystemColors.ButtonHighlight;
            lblSignup.Location = new Point(224, 12);
            lblSignup.Name = "lblSignup";
            lblSignup.Size = new Size(76, 25);
            lblSignup.TabIndex = 15;
            lblSignup.Text = "Sign up";
            lblSignup.Click += lblSignup_Click;
            // 
            // lblSellerChannel
            // 
            lblSellerChannel.AutoSize = true;
            lblSellerChannel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSellerChannel.ForeColor = SystemColors.ButtonHighlight;
            lblSellerChannel.Location = new Point(3, 12);
            lblSellerChannel.Name = "lblSellerChannel";
            lblSellerChannel.Size = new Size(131, 25);
            lblSellerChannel.TabIndex = 16;
            lblSellerChannel.Text = "Seller channel";
            lblSellerChannel.Click += lblSellerChannel_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(101, 183, 65);
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
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(101, 183, 65);
            panel3.Controls.Add(lblSignup);
            panel3.Controls.Add(lblSignin);
            panel3.Controls.Add(lblSellerChannel);
            panel3.Location = new Point(674, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(307, 44);
            panel3.TabIndex = 17;
            panel3.Paint += panel3_Paint;
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
        private Label lblSignin;
        private Label lblSignup;
        private Label lblSellerChannel;
        private RJControls.RButton btnSearch;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label5;
        private RJControls.RButton btnCart;
        private RJControls.RButton rButton3;
        private RJControls.RButton btnMainPage;
        public Panel pnl_Body;
    }
}