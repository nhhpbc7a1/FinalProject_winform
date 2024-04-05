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
            lbl = new Label();
            panel1 = new Panel();
            lblProductName = new Label();
            picItems = new PictureBox();
            lblCondition = new Label();
            label1 = new Label();
            lblPrice = new Label();
            lblOriginPrice = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picItems).BeginInit();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(510, 61);
            lbl.Margin = new Padding(1, 0, 1, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(44, 21);
            lbl.TabIndex = 47;
            lbl.Text = "price";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(picItems);
            panel1.Location = new Point(28, 8);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 74);
            panel1.TabIndex = 51;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductName.Location = new Point(70, 30);
            lblProductName.Margin = new Padding(1, 0, 1, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(59, 21);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "(name)";
            // 
            // picItems
            // 
            picItems.BackColor = SystemColors.Control;
            picItems.BackgroundImageLayout = ImageLayout.Stretch;
            picItems.Location = new Point(4, 5);
            picItems.Margin = new Padding(1);
            picItems.Name = "picItems";
            picItems.Size = new Size(64, 63);
            picItems.TabIndex = 10;
            picItems.TabStop = false;
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCondition.Location = new Point(302, 40);
            lblCondition.Margin = new Padding(1, 0, 1, 0);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(78, 21);
            lblCondition.TabIndex = 56;
            lblCondition.Text = "Condition";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(487, 36);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 57;
            label1.Text = "origin price";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.Location = new Point(578, 61);
            lblPrice.Margin = new Padding(1, 0, 1, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(55, 21);
            lblPrice.TabIndex = 58;
            lblPrice.Text = "10000";
            // 
            // lblOriginPrice
            // 
            lblOriginPrice.AutoSize = true;
            lblOriginPrice.Font = new Font("Segoe UI", 12F, FontStyle.Strikeout, GraphicsUnit.Point);
            lblOriginPrice.Location = new Point(578, 36);
            lblOriginPrice.Margin = new Padding(1, 0, 1, 0);
            lblOriginPrice.Name = "lblOriginPrice";
            lblOriginPrice.Size = new Size(55, 21);
            lblOriginPrice.TabIndex = 59;
            lblOriginPrice.Text = "10000";
            // 
            // UCProductStatusItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 237, 204);
            Controls.Add(lblOriginPrice);
            Controls.Add(lblPrice);
            Controls.Add(label1);
            Controls.Add(lblCondition);
            Controls.Add(lbl);
            Controls.Add(panel1);
            Name = "UCProductStatusItem";
            Size = new Size(693, 128);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lbl;
        public Panel panel1;
        public Label lblProductName;
        public PictureBox picItems;
        public Label lblCondition;
        public Label label1;
        public Label lblPrice;
        public Label lblOriginPrice;
    }
}
