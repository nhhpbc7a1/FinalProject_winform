namespace QuanLyTraoDoiHang
{
    partial class UCProductInCheckOut
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.lblOldPrice = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(580, 58);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(111, 22);
            this.lblPrice.TabIndex = 60;
            this.lblPrice.Text = "price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.pbProductImage);
            this.panel1.Location = new System.Drawing.Point(25, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 74);
            this.panel1.TabIndex = 61;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(70, 27);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(51, 19);
            this.lblProductName.TabIndex = 11;
            this.lblProductName.Text = "(name)";
            // 
            // pbProductImage
            // 
            this.pbProductImage.BackColor = System.Drawing.SystemColors.Control;
            this.pbProductImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbProductImage.Location = new System.Drawing.Point(4, 5);
            this.pbProductImage.Margin = new System.Windows.Forms.Padding(1);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(64, 63);
            this.pbProductImage.TabIndex = 10;
            this.pbProductImage.TabStop = false;
            // 
            // lblOldPrice
            // 
            this.lblOldPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.lblOldPrice.Location = new System.Drawing.Point(580, 36);
            this.lblOldPrice.Name = "lblOldPrice";
            this.lblOldPrice.Size = new System.Drawing.Size(111, 22);
            this.lblOldPrice.TabIndex = 63;
            this.lblOldPrice.Text = "Old price";
            this.lblOldPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCondition
            // 
            this.lblCondition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCondition.Location = new System.Drawing.Point(393, 34);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(134, 51);
            this.lblCondition.TabIndex = 62;
            this.lblCondition.Text = "condition of product";
            // 
            // UCProductInCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOldPrice);
            this.Controls.Add(this.lblCondition);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCProductInCheckOut";
            this.Size = new System.Drawing.Size(713, 126);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Label lblPrice;
        public Panel panel1;
        public Label lblProductName;
        public PictureBox pbProductImage;
        private Label lblOldPrice;
        private Label lblCondition;
    }
}
