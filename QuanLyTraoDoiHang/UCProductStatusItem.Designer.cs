﻿namespace QuanLyTraoDoiHang
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.picItems = new System.Windows.Forms.PictureBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblOriginPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(101, 27);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 15);
            this.lblProductName.MaximumSize = new System.Drawing.Size(220, 10000);
            this.lblProductName.MinimumSize = new System.Drawing.Size(220, 61);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProductName.Size = new System.Drawing.Size(220, 61);
            this.lblProductName.TabIndex = 11;
            this.lblProductName.Text = "(name)";
            // 
            // picItems
            // 
            this.picItems.BackColor = System.Drawing.SystemColors.Control;
            this.picItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picItems.Location = new System.Drawing.Point(35, 25);
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
            this.lblCondition.Margin = new System.Windows.Forms.Padding(1, 0, 1, 15);
            this.lblCondition.MaximumSize = new System.Drawing.Size(264, 10000);
            this.lblCondition.MinimumSize = new System.Drawing.Size(264, 61);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCondition.Size = new System.Drawing.Size(264, 61);
            this.lblCondition.TabIndex = 56;
            this.lblCondition.Text = "Condition";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(617, 55);
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
            this.lblOriginPrice.Location = new System.Drawing.Point(617, 27);
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
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblOriginPrice);
            this.Controls.Add(this.picItems);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCondition);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Name = "UCProductStatusItem";
            this.Size = new System.Drawing.Size(725, 128);
            ((System.ComponentModel.ISupportInitialize)(this.picItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Label lblProductName;
        public PictureBox picItems;
        public Label lblCondition;
        public Label lblPrice;
        public Label lblOriginPrice;
    }
}
