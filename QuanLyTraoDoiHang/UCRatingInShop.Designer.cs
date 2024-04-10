namespace QuanLyTraoDoiHang
{
    partial class UCRatingInShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRatingInShop));
            this.lblBuyerName = new System.Windows.Forms.Label();
            this.picboxBuyerImage = new System.Windows.Forms.PictureBox();
            this.lblDateBought = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.ucStars1 = new QuanLyTraoDoiHang.UCStars();
            this.lblRatingText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxBuyerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuyerName
            // 
            this.lblBuyerName.AutoSize = true;
            this.lblBuyerName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuyerName.Location = new System.Drawing.Point(100, 10);
            this.lblBuyerName.Name = "lblBuyerName";
            this.lblBuyerName.Size = new System.Drawing.Size(106, 20);
            this.lblBuyerName.TabIndex = 9;
            this.lblBuyerName.Text = "hoanghamobi";
            // 
            // picboxBuyerImage
            // 
            this.picboxBuyerImage.BackgroundImage = global::QuanLyTraoDoiHang.Properties.Resources.empty_avatar;
            this.picboxBuyerImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxBuyerImage.Location = new System.Drawing.Point(31, 4);
            this.picboxBuyerImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picboxBuyerImage.Name = "picboxBuyerImage";
            this.picboxBuyerImage.Size = new System.Drawing.Size(63, 61);
            this.picboxBuyerImage.TabIndex = 7;
            this.picboxBuyerImage.TabStop = false;
            // 
            // lblDateBought
            // 
            this.lblDateBought.AutoSize = true;
            this.lblDateBought.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateBought.Location = new System.Drawing.Point(285, 8);
            this.lblDateBought.Name = "lblDateBought";
            this.lblDateBought.Size = new System.Drawing.Size(137, 21);
            this.lblDateBought.TabIndex = 21;
            this.lblDateBought.Text = "2023-12-30 00:56";
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(484, 10);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(369, 50);
            this.lblProductName.TabIndex = 21;
            this.lblProductName.Text = "Tai nghe SENNHEISER Momentum True Wireless 3";
            // 
            // ucStars1
            // 
            this.ucStars1.Location = new System.Drawing.Point(100, 27);
            this.ucStars1.Name = "ucStars1";
            this.ucStars1.Size = new System.Drawing.Size(208, 39);
            this.ucStars1.TabIndex = 23;
            // 
            // lblRatingText
            // 
            this.lblRatingText.AutoSize = true;
            this.lblRatingText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRatingText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRatingText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRatingText.Location = new System.Drawing.Point(49, 69);
            this.lblRatingText.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.lblRatingText.MaximumSize = new System.Drawing.Size(783, 10000);
            this.lblRatingText.MinimumSize = new System.Drawing.Size(783, 65);
            this.lblRatingText.Name = "lblRatingText";
            this.lblRatingText.Size = new System.Drawing.Size(783, 65);
            this.lblRatingText.TabIndex = 22;
            this.lblRatingText.Text = resources.GetString("lblRatingText.Text");
            // 
            // UCRatingInShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ucStars1);
            this.Controls.Add(this.lblRatingText);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblDateBought);
            this.Controls.Add(this.lblBuyerName);
            this.Controls.Add(this.picboxBuyerImage);
            this.MaximumSize = new System.Drawing.Size(875, 10000);
            this.MinimumSize = new System.Drawing.Size(875, 150);
            this.Name = "UCRatingInShop";
            this.Size = new System.Drawing.Size(873, 149);
            ((System.ComponentModel.ISupportInitialize)(this.picboxBuyerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBuyerName;
        private PictureBox picboxBuyerImage;
        private Label lblDateBought;
        private Label lblProductName;
        private UCStars ucStars1;
        private Label lblRatingText;
    }
}
