namespace QuanLyTraoDoiHang
{
    partial class UCProductStatusItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.picItems = new System.Windows.Forms.PictureBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblOriginPrice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.picItems);
            this.panel1.Location = new System.Drawing.Point(28, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 74);
            this.panel1.TabIndex = 51;
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(70, 19);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(202, 49);
            this.lblProductName.TabIndex = 11;
            this.lblProductName.Text = "(name)";
            // 
            // picItems
            // 
            this.picItems.BackColor = System.Drawing.SystemColors.Control;
            this.picItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picItems.Location = new System.Drawing.Point(4, 5);
            this.picItems.Margin = new System.Windows.Forms.Padding(1);
            this.picItems.Name = "picItems";
            this.picItems.Size = new System.Drawing.Size(64, 63);
            this.picItems.TabIndex = 10;
            this.picItems.TabStop = false;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCondition.Location = new System.Drawing.Point(335, 27);
            this.lblCondition.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(78, 21);
            this.lblCondition.TabIndex = 56;
            this.lblCondition.Text = "Condition";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(578, 55);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 21);
            this.lblPrice.TabIndex = 58;
            this.lblPrice.Text = "10000";
            // 
            // lblOriginPrice
            // 
            this.lblOriginPrice.AutoSize = true;
            this.lblOriginPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.lblOriginPrice.Location = new System.Drawing.Point(578, 27);
            this.lblOriginPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOriginPrice.Name = "lblOriginPrice";
            this.lblOriginPrice.Size = new System.Drawing.Size(55, 21);
            this.lblOriginPrice.TabIndex = 59;
            this.lblOriginPrice.Text = "10000";
            // 
            // UCProductStatusItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.lblOriginPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.panel1);
            this.Name = "UCProductStatusItem";
            this.Size = new System.Drawing.Size(693, 128);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Panel panel1;
        public Label lblProductName;
        public PictureBox picItems;
        public Label lblCondition;
        public Label lblPrice;
        public Label lblOriginPrice;
    }
}
