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
            cbSearchBox = new ComboBox();
            panel1 = new Panel();
            pnlMainPage = new Panel();
            btnMainPage = new RJControls.RButton();
            lblMainPage = new Label();
            btnCart = new RJControls.RButton();
            btnAddProduct = new RJControls.RButton();
            btnSearch = new RJControls.RButton();
            lblSignIn = new Label();
            lblSignUp = new Label();
            lblSellerChannel = new Label();
            panel2 = new Panel();
            pnlAccount = new Panel();
            picProfile = new PictureBox();
            lblUsername = new Label();
            panel6 = new Panel();
            rButton2 = new RJControls.RButton();
            btnMinimize = new RJControls.RButton();
            btnExit = new RJControls.RButton();
            panel3 = new Panel();
            panel4 = new Panel();
            pnl_Body = new Panel();
            panel1.SuspendLayout();
            pnlMainPage.SuspendLayout();
            panel2.SuspendLayout();
            pnlAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // cbSearchBox
            // 
            cbSearchBox.Anchor = AnchorStyles.None;
            cbSearchBox.BackColor = SystemColors.Window;
            cbSearchBox.DropDownWidth = 498;
            cbSearchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSearchBox.ForeColor = SystemColors.InfoText;
            cbSearchBox.FormattingEnabled = true;
            cbSearchBox.Items.AddRange(new object[] { "totoro model", "susuwatari model", "snow ball" });
            cbSearchBox.Location = new Point(254, 13);
            cbSearchBox.Margin = new Padding(6, 3, 6, 3);
            cbSearchBox.Name = "cbSearchBox";
            cbSearchBox.Size = new Size(406, 29);
            cbSearchBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pnlMainPage);
            panel1.Controls.Add(btnCart);
            panel1.Controls.Add(btnAddProduct);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(cbSearchBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 55);
            panel1.TabIndex = 10;
            // 
            // pnlMainPage
            // 
            pnlMainPage.Anchor = AnchorStyles.None;
            pnlMainPage.Controls.Add(btnMainPage);
            pnlMainPage.Controls.Add(lblMainPage);
            pnlMainPage.Location = new Point(111, 0);
            pnlMainPage.Name = "pnlMainPage";
            pnlMainPage.Size = new Size(134, 55);
            pnlMainPage.TabIndex = 1;
            // 
            // btnMainPage
            // 
            btnMainPage.BackColor = Color.White;
            btnMainPage.BackgroundColor = Color.White;
            btnMainPage.BackgroundImage = (Image)resources.GetObject("btnMainPage.BackgroundImage");
            btnMainPage.BackgroundImageLayout = ImageLayout.Stretch;
            btnMainPage.BorderColor = Color.FromArgb(244, 237, 204);
            btnMainPage.BorderRadius = 20;
            btnMainPage.BorderSize = 0;
            btnMainPage.FlatAppearance.BorderSize = 0;
            btnMainPage.FlatStyle = FlatStyle.Flat;
            btnMainPage.ForeColor = Color.White;
            btnMainPage.Location = new Point(20, 2);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Size = new Size(54, 50);
            btnMainPage.TabIndex = 0;
            btnMainPage.TextColor = Color.White;
            btnMainPage.UseVisualStyleBackColor = false;
            // 
            // lblMainPage
            // 
            lblMainPage.AutoSize = true;
            lblMainPage.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMainPage.ForeColor = Color.FromArgb(30, 106, 17);
            lblMainPage.Location = new Point(71, 17);
            lblMainPage.Name = "lblMainPage";
            lblMainPage.Size = new Size(51, 19);
            lblMainPage.TabIndex = 1;
            lblMainPage.Text = "KoHa";
            // 
            // btnCart
            // 
            btnCart.BackColor = Color.White;
            btnCart.BackgroundColor = Color.White;
            btnCart.BorderColor = Color.PaleVioletRed;
            btnCart.BorderRadius = 20;
            btnCart.BorderSize = 0;
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.ForeColor = Color.White;
            btnCart.Image = (Image)resources.GetObject("btnCart.Image");
            btnCart.Location = new Point(776, 11);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(42, 34);
            btnCart.TabIndex = 20;
            btnCart.TextColor = Color.White;
            btnCart.UseVisualStyleBackColor = false;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.White;
            btnAddProduct.BackgroundColor = Color.White;
            btnAddProduct.BorderColor = Color.FromArgb(193, 242, 176);
            btnAddProduct.BorderRadius = 20;
            btnAddProduct.BorderSize = 0;
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI Semibold", 6F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddProduct.ForeColor = Color.FromArgb(11, 96, 176);
            btnAddProduct.Image = (Image)resources.GetObject("btnAddProduct.Image");
            btnAddProduct.ImageAlign = ContentAlignment.TopCenter;
            btnAddProduct.Location = new Point(822, 7);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(62, 42);
            btnAddProduct.TabIndex = 18;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.TextAlign = ContentAlignment.BottomCenter;
            btnAddProduct.TextColor = Color.FromArgb(11, 96, 176);
            btnAddProduct.UseVisualStyleBackColor = false;
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
            btnSearch.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
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
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignIn.ForeColor = SystemColors.ButtonHighlight;
            lblSignIn.Location = new Point(136, 13);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(59, 18);
            lblSignIn.TabIndex = 14;
            lblSignIn.Text = "Sign in";
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignUp.ForeColor = SystemColors.ButtonHighlight;
            lblSignUp.Location = new Point(225, 13);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(64, 18);
            lblSignUp.TabIndex = 15;
            lblSignUp.Text = "Sign up";
            // 
            // lblSellerChannel
            // 
            lblSellerChannel.AutoSize = true;
            lblSellerChannel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSellerChannel.ForeColor = SystemColors.ButtonHighlight;
            lblSellerChannel.Location = new Point(3, 13);
            lblSellerChannel.Name = "lblSellerChannel";
            lblSellerChannel.Size = new Size(114, 18);
            lblSellerChannel.TabIndex = 16;
            lblSellerChannel.Text = "Seller channel";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 106, 17);
            panel2.Controls.Add(pnlAccount);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 45);
            panel2.TabIndex = 14;
            // 
            // pnlAccount
            // 
            pnlAccount.Controls.Add(picProfile);
            pnlAccount.Controls.Add(lblUsername);
            pnlAccount.Location = new Point(198, 10);
            pnlAccount.Name = "pnlAccount";
            pnlAccount.Size = new Size(159, 27);
            pnlAccount.TabIndex = 21;
            // 
            // picProfile
            // 
            picProfile.BackgroundImageLayout = ImageLayout.Stretch;
            picProfile.Location = new Point(3, 5);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(20, 17);
            picProfile.TabIndex = 1;
            picProfile.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(26, 6);
            lblUsername.Margin = new Padding(10, 0, 3, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(73, 17);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "HuongLe";
            // 
            // panel6
            // 
            panel6.Controls.Add(rButton2);
            panel6.Controls.Add(btnMinimize);
            panel6.Controls.Add(btnExit);
            panel6.Location = new Point(12, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(103, 33);
            panel6.TabIndex = 19;
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
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(30, 106, 17);
            panel3.Controls.Add(lblSignUp);
            panel3.Controls.Add(lblSignIn);
            panel3.Controls.Add(lblSellerChannel);
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
            pnl_Body.BackColor = Color.White;
            pnl_Body.Dock = DockStyle.Fill;
            pnl_Body.Location = new Point(0, 100);
            pnl_Body.Name = "pnl_Body";
            pnl_Body.Size = new Size(982, 561);
            pnl_Body.TabIndex = 19;
            // 
            // Mainpage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            ClientSize = new Size(982, 661);
            Controls.Add(pnl_Body);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mainpage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            pnlMainPage.ResumeLayout(false);
            pnlMainPage.PerformLayout();
            panel2.ResumeLayout(false);
            pnlAccount.ResumeLayout(false);
            pnlAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cbSearchBox;
        private Panel panel1;
        private IconPictureBox iconPictureBox1;
        private Label lblSignIn;
        private Label lblSignUp;
        private Label lblSellerChannel;
        private RJControls.RButton btnSearch;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel pnlMainPage;
        private Label lblMainPage;
        private Label label5;
        private RJControls.RButton rButton3;
        private RJControls.RButton btnMainPage;
        public Panel pnl_Body;
        private RJControls.RButton btnAddProduct;
        private Panel panel6;
        private RJControls.RButton btnMinimize;
        private RJControls.RButton btnExit;
        private RJControls.RButton btnCart;
        private RJControls.RButton rButton2;
        private Panel pnlAccount;
        private PictureBox picProfile;
        private Label lblUsername;
    }
}