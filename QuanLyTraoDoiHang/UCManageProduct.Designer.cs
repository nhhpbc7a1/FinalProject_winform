namespace QuanLyTraoDoiHang
{
    partial class UCManageProduct
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
            this.lblOriginPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.picItems = new System.Windows.Forms.PictureBox();
            this.btnViewChange = new QuanLyTraoDoiHang.RJControls.RButton();
            this.btnDelete = new QuanLyTraoDoiHang.RJControls.RButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOriginPrice
            // 
            this.lblOriginPrice.AutoSize = true;
            this.lblOriginPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.lblOriginPrice.Location = new System.Drawing.Point(382, 55);
            this.lblOriginPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOriginPrice.Name = "lblOriginPrice";
            this.lblOriginPrice.Size = new System.Drawing.Size(55, 21);
            this.lblOriginPrice.TabIndex = 65;
            this.lblOriginPrice.Text = "10000";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(382, 80);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 21);
            this.lblPrice.TabIndex = 64;
            this.lblPrice.Text = "10000";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCondition.Location = new System.Drawing.Point(269, 65);
            this.lblCondition.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(78, 21);
            this.lblCondition.TabIndex = 62;
            this.lblCondition.Text = "Condition";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblProductName);
            this.panel3.Controls.Add(this.picItems);
            this.panel3.Location = new System.Drawing.Point(26, 35);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 74);
            this.panel3.TabIndex = 61;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(70, 30);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(59, 21);
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
            // btnViewChange
            // 
            this.btnViewChange.BackColor = System.Drawing.Color.White;
            this.btnViewChange.BackgroundColor = System.Drawing.Color.White;
            this.btnViewChange.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnViewChange.BorderRadius = 20;
            this.btnViewChange.BorderSize = 2;
            this.btnViewChange.CausesValidation = false;
            this.btnViewChange.FlatAppearance.BorderSize = 0;
            this.btnViewChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnViewChange.Location = new System.Drawing.Point(465, 13);
            this.btnViewChange.Name = "btnViewChange";
            this.btnViewChange.Size = new System.Drawing.Size(225, 40);
            this.btnViewChange.TabIndex = 0;
            this.btnViewChange.Text = "View/Change product detail";
            this.btnViewChange.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnViewChange.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(493, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(173, 40);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // UCManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnViewChange);
            this.Controls.Add(this.lblOriginPrice);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCondition);
            this.Name = "UCManageProduct";
            this.Size = new System.Drawing.Size(693, 150);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Label lblOriginPrice;
        public Label lblPrice;
        public Label lblCondition;
        public Panel panel3;
        public Label lblProductName;
        public PictureBox picItems;
        private RJControls.RButton btnViewChange;
        private RJControls.RButton btnDelete;
    }
}
