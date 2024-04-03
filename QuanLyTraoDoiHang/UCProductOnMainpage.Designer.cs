namespace QuanLyTraoDoiHang
{
    partial class UCProductOnMainpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProductOnMainpage));
            ptbImage = new PictureBox();
            lblName = new Label();
            lblPrice = new Label();
            btnBuyNow = new RJControls.RButton();
            label1 = new Label();
            lblOriginalPrice = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbImage).BeginInit();
            SuspendLayout();
            // 
            // ptbImage
            // 
            ptbImage.BackgroundImage = (Image)resources.GetObject("ptbImage.BackgroundImage");
            ptbImage.BackgroundImageLayout = ImageLayout.Stretch;
            ptbImage.Dock = DockStyle.Top;
            ptbImage.Location = new Point(0, 0);
            ptbImage.Margin = new Padding(3, 2, 3, 2);
            ptbImage.Name = "ptbImage";
            ptbImage.Size = new Size(200, 148);
            ptbImage.TabIndex = 0;
            ptbImage.TabStop = false;
            // 
            // lblName
            // 
            lblName.Font = new Font("Lato Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(0, 150);
            lblName.Name = "lblName";
            lblName.Size = new Size(200, 33);
            lblName.TabIndex = 1;
            lblName.Text = "Product's name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Red;
            lblPrice.Location = new Point(22, 222);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(58, 19);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "10.500";
            // 
            // btnBuyNow
            // 
            btnBuyNow.BackColor = Color.FromArgb(231, 41, 41);
            btnBuyNow.BackgroundColor = Color.FromArgb(231, 41, 41);
            btnBuyNow.BorderColor = Color.PaleVioletRed;
            btnBuyNow.BorderRadius = 15;
            btnBuyNow.BorderSize = 0;
            btnBuyNow.FlatAppearance.BorderSize = 0;
            btnBuyNow.FlatStyle = FlatStyle.Flat;
            btnBuyNow.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuyNow.ForeColor = Color.White;
            btnBuyNow.Location = new Point(115, 213);
            btnBuyNow.Name = "btnBuyNow";
            btnBuyNow.Size = new Size(73, 30);
            btnBuyNow.TabIndex = 5;
            btnBuyNow.Text = "Buy now";
            btnBuyNow.TextColor = Color.White;
            btnBuyNow.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 225);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 6;
            label1.Text = "đ";
            // 
            // lblOriginalPrice
            // 
            lblOriginalPrice.AutoSize = true;
            lblOriginalPrice.Font = new Font("Lato", 11.9999981F, FontStyle.Strikeout, GraphicsUnit.Point);
            lblOriginalPrice.ForeColor = SystemColors.ActiveCaptionText;
            lblOriginalPrice.Location = new Point(22, 201);
            lblOriginalPrice.Name = "lblOriginalPrice";
            lblOriginalPrice.Size = new Size(63, 19);
            lblOriginalPrice.TabIndex = 6;
            lblOriginalPrice.Text = "100000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 206);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 6;
            label2.Text = "đ";
            // 
            // UCProductOnMainpage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(lblOriginalPrice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBuyNow);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(ptbImage);
            Margin = new Padding(10, 4, 10, 4);
            Name = "UCProductOnMainpage";
            Size = new Size(200, 255);
            Load += UCProductOnMainpage_Load;
            ((System.ComponentModel.ISupportInitialize)ptbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public PictureBox ptbImage;
        public Label lblName;
        public Label lblPrice;
        private RJControls.RButton btnBuyNow;
        private Label label1;
        private Label lblOriginalPrice;
        private Label label2;
    }
}
