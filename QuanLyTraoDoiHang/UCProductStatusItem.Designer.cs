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
            lblProductName = new Label();
            picItems = new PictureBox();
            lblCondition = new Label();
            lblPrice = new Label();
            lblOriginPrice = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picItems).BeginInit();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductName.Location = new Point(96, 25);
            lblProductName.Margin = new Padding(1, 0, 1, 15);
            lblProductName.MaximumSize = new Size(220, 10000);
            lblProductName.Name = "lblProductName";
            lblProductName.RightToLeft = RightToLeft.No;
            lblProductName.Size = new Size(159, 72);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "(name)";
            // 
            // picItems
            // 
            picItems.BackColor = SystemColors.Control;
            picItems.BackgroundImageLayout = ImageLayout.Stretch;
            picItems.Location = new Point(17, 23);
            picItems.Margin = new Padding(1);
            picItems.Name = "picItems";
            picItems.Size = new Size(68, 74);
            picItems.TabIndex = 10;
            picItems.TabStop = false;
            // 
            // lblCondition
            // 
            lblCondition.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCondition.Location = new Point(313, 25);
            lblCondition.Margin = new Padding(1, 0, 1, 15);
            lblCondition.MaximumSize = new Size(264, 10000);
            lblCondition.Name = "lblCondition";
            lblCondition.RightToLeft = RightToLeft.No;
            lblCondition.Size = new Size(197, 72);
            lblCondition.TabIndex = 56;
            lblCondition.Text = "Condition";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Red;
            lblPrice.Location = new Point(614, 59);
            lblPrice.Margin = new Padding(1, 0, 1, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(52, 21);
            lblPrice.TabIndex = 58;
            lblPrice.Text = "10000";
            // 
            // lblOriginPrice
            // 
            lblOriginPrice.AutoSize = true;
            lblOriginPrice.Font = new Font("Segoe UI", 12F, FontStyle.Strikeout, GraphicsUnit.Point);
            lblOriginPrice.Location = new Point(614, 38);
            lblOriginPrice.Margin = new Padding(1, 0, 1, 0);
            lblOriginPrice.Name = "lblOriginPrice";
            lblOriginPrice.Size = new Size(55, 21);
            lblOriginPrice.TabIndex = 59;
            lblOriginPrice.Text = "10000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(600, 61);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 60;
            label1.Text = "đ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(600, 39);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 61;
            label2.Text = "đ";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Location = new Point(4, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(707, 1);
            panel2.TabIndex = 62;
            // 
            // UCProductStatusItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblProductName);
            Controls.Add(lblOriginPrice);
            Controls.Add(picItems);
            Controls.Add(lblPrice);
            Controls.Add(lblCondition);
            Margin = new Padding(0);
            Name = "UCProductStatusItem";
            RightToLeft = RightToLeft.No;
            Size = new Size(727, 130);
            ((System.ComponentModel.ISupportInitialize)picItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lblProductName;
        public PictureBox picItems;
        public Label lblCondition;
        public Label lblPrice;
        public Label lblOriginPrice;
        public Label label1;
        public Label label2;
        private Panel panel2;
    }
}
