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
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnBuyNow = new QuanLyTraoDoiHang.RJControls.RButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbImage
            // 
            this.ptbImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbImage.BackgroundImage")));
            this.ptbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbImage.Location = new System.Drawing.Point(0, 0);
            this.ptbImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(200, 134);
            this.ptbImage.TabIndex = 0;
            this.ptbImage.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(37, 134);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(147, 28);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Product\'s name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(37, 178);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 28);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "10.500";
            // 
            // btnBuyNow
            // 
            this.btnBuyNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnBuyNow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnBuyNow.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuyNow.BorderRadius = 15;
            this.btnBuyNow.BorderSize = 0;
            this.btnBuyNow.FlatAppearance.BorderSize = 0;
            this.btnBuyNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyNow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuyNow.ForeColor = System.Drawing.Color.White;
            this.btnBuyNow.Location = new System.Drawing.Point(114, 174);
            this.btnBuyNow.Name = "btnBuyNow";
            this.btnBuyNow.Size = new System.Drawing.Size(73, 30);
            this.btnBuyNow.TabIndex = 5;
            this.btnBuyNow.Text = "Buy now";
            this.btnBuyNow.TextColor = System.Drawing.Color.White;
            this.btnBuyNow.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 32);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // UCProductOnMainpage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBuyNow);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.ptbImage);
            this.Margin = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.Name = "UCProductOnMainpage";
            this.Size = new System.Drawing.Size(200, 213);
            this.Load += new System.EventHandler(this.UCProductOnMainpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public PictureBox ptbImage;
        public Label lblName;
        public Label lblPrice;
        private RJControls.RButton btnBuyNow;
        private PictureBox pictureBox1;
    }
}
