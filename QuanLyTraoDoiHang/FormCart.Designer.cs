namespace QuanLyTraoDoiHang
{
    partial class FormCart
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
            pBMenu = new PictureBox();
            pBSearch = new PictureBox();
            btnHelp = new Button();
            cBAccount = new ComboBox();
            txtSearch = new TextBox();
            button4 = new Button();
            icbtnHome = new FontAwesome.Sharp.IconButton();
            pnlMenu = new Panel();
            label1 = new Label();
            lblAction = new Label();
            lblTotalPrice = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            chBProducts = new CheckBox();
            pnlCheckOut = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pBMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBSearch).BeginInit();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pBMenu
            // 
            pBMenu.BackColor = Color.Gold;
            pBMenu.Location = new Point(-3, -5);
            pBMenu.Name = "pBMenu";
            pBMenu.Size = new Size(2343, 104);
            pBMenu.TabIndex = 0;
            pBMenu.TabStop = false;
            // 
            // pBSearch
            // 
            pBSearch.BackColor = Color.White;
            pBSearch.Location = new Point(-3, 95);
            pBSearch.Name = "pBSearch";
            pBSearch.Size = new Size(2343, 182);
            pBSearch.TabIndex = 1;
            pBSearch.TabStop = false;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.Cornsilk;
            btnHelp.Location = new Point(1562, 12);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(188, 58);
            btnHelp.TabIndex = 3;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = false;
            // 
            // cBAccount
            // 
            cBAccount.FormattingEnabled = true;
            cBAccount.Location = new Point(1772, 18);
            cBAccount.Name = "cBAccount";
            cBAccount.Size = new Size(302, 49);
            cBAccount.TabIndex = 5;
            cBAccount.Text = "Account";
            cBAccount.SelectedIndexChanged += cBAccount_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(1086, 146);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(907, 80);
            txtSearch.TabIndex = 7;
            txtSearch.Text = "Your products";
            // 
            // button4
            // 
            button4.BackColor = Color.MidnightBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Window;
            button4.Location = new Point(1982, 143);
            button4.Name = "button4";
            button4.Size = new Size(217, 86);
            button4.TabIndex = 8;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // icbtnHome
            // 
            icbtnHome.BackColor = Color.White;
            icbtnHome.FlatAppearance.BorderSize = 0;
            icbtnHome.FlatStyle = FlatStyle.Flat;
            icbtnHome.Font = new Font("Segoe UI Black", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point);
            icbtnHome.ForeColor = Color.MidnightBlue;
            icbtnHome.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            icbtnHome.IconColor = Color.MidnightBlue;
            icbtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbtnHome.IconSize = 100;
            icbtnHome.ImageAlign = ContentAlignment.MiddleRight;
            icbtnHome.Location = new Point(101, 127);
            icbtnHome.Name = "icbtnHome";
            icbtnHome.Size = new Size(317, 99);
            icbtnHome.TabIndex = 10;
            icbtnHome.Text = "Home |";
            icbtnHome.TextAlign = ContentAlignment.MiddleLeft;
            icbtnHome.UseVisualStyleBackColor = false;
            icbtnHome.Click += iconButton1_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Cornsilk;
            pnlMenu.Controls.Add(label1);
            pnlMenu.Controls.Add(lblAction);
            pnlMenu.Controls.Add(lblTotalPrice);
            pnlMenu.Controls.Add(lblQuantity);
            pnlMenu.Controls.Add(lblPrice);
            pnlMenu.Controls.Add(chBProducts);
            pnlMenu.Location = new Point(101, 335);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(2098, 83);
            pnlMenu.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1567, 20);
            label1.Name = "label1";
            label1.Size = new Size(98, 41);
            label1.TabIndex = 17;
            label1.Text = "Status";
            // 
            // lblAction
            // 
            lblAction.AutoSize = true;
            lblAction.Location = new Point(1857, 20);
            lblAction.Name = "lblAction";
            lblAction.Size = new Size(116, 41);
            lblAction.TabIndex = 16;
            lblAction.Text = "Actions";
            lblAction.Click += lblAction_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(1214, 20);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(153, 41);
            lblTotalPrice.TabIndex = 15;
            lblTotalPrice.Text = "Total Price";
            lblTotalPrice.Click += lblTotalPrice_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(905, 20);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(132, 41);
            lblQuantity.TabIndex = 14;
            lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(570, 20);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(145, 41);
            lblPrice.TabIndex = 13;
            lblPrice.Text = "Unit Price";
            // 
            // chBProducts
            // 
            chBProducts.AutoSize = true;
            chBProducts.Location = new Point(30, 20);
            chBProducts.Name = "chBProducts";
            chBProducts.Size = new Size(240, 45);
            chBProducts.TabIndex = 12;
            chBProducts.Text = "Your Products";
            chBProducts.UseVisualStyleBackColor = true;
            // 
            // pnlCheckOut
            // 
            pnlCheckOut.BackColor = Color.Gainsboro;
            pnlCheckOut.Location = new Point(101, 914);
            pnlCheckOut.Name = "pnlCheckOut";
            pnlCheckOut.Size = new Size(2098, 184);
            pnlCheckOut.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Location = new Point(101, 470);
            panel1.Name = "panel1";
            panel1.Size = new Size(2098, 438);
            panel1.TabIndex = 13;
            // 
            // FormCart
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(2335, 1096);
            Controls.Add(panel1);
            Controls.Add(pnlCheckOut);
            Controls.Add(pnlMenu);
            Controls.Add(icbtnHome);
            Controls.Add(button4);
            Controls.Add(txtSearch);
            Controls.Add(cBAccount);
            Controls.Add(btnHelp);
            Controls.Add(pBSearch);
            Controls.Add(pBMenu);
            Name = "FormCart";
            Text = "FormCart";
            Load += FormCart_Load;
            ((System.ComponentModel.ISupportInitialize)pBMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBSearch).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pBMenu;
        private PictureBox pBSearch;
        private Button btnHelp;
        private ComboBox cBAccount;
        private TextBox txtSearch;
        private Button button4;
        private FontAwesome.Sharp.IconButton icbtnHome;
        private Panel pnlMenu;
        private CheckBox chBProducts;
        private Label lblAction;
        private Label lblTotalPrice;
        private Label lblQuantity;
        private Label lblPrice;
        private Label label1;
        private Panel pnlCheckOut;
        private Panel panel1;
    }
}