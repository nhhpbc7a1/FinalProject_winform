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
            lblOriginPrice = new Label();
            lblPrice = new Label();
            lblCondition = new Label();
            panel3 = new Panel();
            lblProductName = new Label();
            picItems = new PictureBox();
            btnViewChange = new RJControls.RButton();
            btnDelete = new RJControls.RButton();
            label1 = new Label();
            label2 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picItems).BeginInit();
            SuspendLayout();
            // 
            // lblOriginPrice
            // 
            lblOriginPrice.AutoSize = true;
            lblOriginPrice.Font = new Font("Segoe UI", 12F, FontStyle.Strikeout, GraphicsUnit.Point);
            lblOriginPrice.Location = new Point(469, 49);
            lblOriginPrice.Margin = new Padding(1, 0, 1, 0);
            lblOriginPrice.Name = "lblOriginPrice";
            lblOriginPrice.Size = new Size(55, 21);
            lblOriginPrice.TabIndex = 65;
            lblOriginPrice.Text = "10000";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Red;
            lblPrice.Location = new Point(472, 78);
            lblPrice.Margin = new Padding(1, 0, 1, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(52, 21);
            lblPrice.TabIndex = 64;
            lblPrice.Text = "10000";
            // 
            // lblCondition
            // 
            lblCondition.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCondition.Location = new Point(247, 49);
            lblCondition.Margin = new Padding(1, 0, 1, 0);
            lblCondition.Name = "lblCondition";
            lblCondition.RightToLeft = RightToLeft.No;
            lblCondition.Size = new Size(181, 79);
            lblCondition.TabIndex = 62;
            lblCondition.Text = "Condition";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblProductName);
            panel3.Controls.Add(picItems);
            panel3.Location = new Point(10, 30);
            panel3.Margin = new Padding(1);
            panel3.Name = "panel3";
            panel3.Size = new Size(235, 98);
            panel3.TabIndex = 61;
            // 
            // lblProductName
            // 
            lblProductName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductName.Location = new Point(74, 19);
            lblProductName.Margin = new Padding(1, 0, 1, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.RightToLeft = RightToLeft.No;
            lblProductName.Size = new Size(160, 69);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "(name)";
            // 
            // picItems
            // 
            picItems.BackColor = SystemColors.Control;
            picItems.BackgroundImageLayout = ImageLayout.Stretch;
            picItems.Location = new Point(4, 13);
            picItems.Margin = new Padding(1);
            picItems.Name = "picItems";
            picItems.Size = new Size(68, 74);
            picItems.TabIndex = 10;
            picItems.TabStop = false;
            // 
            // btnViewChange
            // 
            btnViewChange.BackColor = Color.White;
            btnViewChange.BackgroundColor = Color.White;
            btnViewChange.BorderColor = Color.LightCoral;
            btnViewChange.BorderRadius = 10;
            btnViewChange.BorderSize = 1;
            btnViewChange.CausesValidation = false;
            btnViewChange.FlatAppearance.BorderSize = 0;
            btnViewChange.FlatStyle = FlatStyle.Flat;
            btnViewChange.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewChange.ForeColor = Color.LightCoral;
            btnViewChange.Location = new Point(581, 30);
            btnViewChange.Name = "btnViewChange";
            btnViewChange.Size = new Size(119, 40);
            btnViewChange.TabIndex = 0;
            btnViewChange.Text = "View/Change";
            btnViewChange.TextColor = Color.LightCoral;
            btnViewChange.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.BackgroundColor = Color.LightCoral;
            btnDelete.BorderColor = Color.PaleVioletRed;
            btnDelete.BorderRadius = 10;
            btnDelete.BorderSize = 0;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(581, 78);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 40);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.TextColor = Color.White;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(455, 79);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 66;
            label1.Text = "đ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(455, 50);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 67;
            label2.Text = "đ";
            // 
            // UCManageProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnViewChange);
            Controls.Add(lblOriginPrice);
            Controls.Add(panel3);
            Controls.Add(lblPrice);
            Controls.Add(lblCondition);
            Margin = new Padding(0, 5, 0, 0);
            Name = "UCManageProduct";
            Size = new Size(723, 150);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        public Label label1;
        public Label label2;
    }
}
