namespace QuanLyTraoDoiHang
{
    partial class ucItemsInCheckOut
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
            lblPrice = new Label();
            panel1 = new Panel();
            lblProductName = new Label();
            pbProductImage = new PictureBox();
            lblOldPrice = new Label();
            lblCondition = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Red;
            lblPrice.Location = new Point(603, 59);
            lblPrice.Margin = new Padding(1, 0, 1, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(102, 22);
            lblPrice.TabIndex = 60;
            lblPrice.Text = "price";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(pbProductImage);
            panel1.Location = new Point(11, 25);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 83);
            panel1.TabIndex = 61;
            // 
            // lblProductName
            // 
            lblProductName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductName.Location = new Point(74, 5);
            lblProductName.Margin = new Padding(1, 0, 1, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(169, 74);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "(name)";
            // 
            // pbProductImage
            // 
            pbProductImage.BackColor = SystemColors.Control;
            pbProductImage.BackgroundImageLayout = ImageLayout.Stretch;
            pbProductImage.Location = new Point(4, 5);
            pbProductImage.Margin = new Padding(1);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(68, 74);
            pbProductImage.TabIndex = 10;
            pbProductImage.TabStop = false;
            // 
            // lblOldPrice
            // 
            lblOldPrice.Font = new Font("Segoe UI", 12F, FontStyle.Strikeout, GraphicsUnit.Point);
            lblOldPrice.Location = new Point(603, 37);
            lblOldPrice.Name = "lblOldPrice";
            lblOldPrice.Size = new Size(107, 22);
            lblOldPrice.TabIndex = 63;
            lblOldPrice.Text = "Old price";
            lblOldPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCondition
            // 
            lblCondition.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCondition.Location = new Point(303, 25);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(203, 83);
            lblCondition.TabIndex = 62;
            lblCondition.Text = "condition of product";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(584, 59);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 22);
            label1.TabIndex = 64;
            label1.Text = "đ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(584, 38);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(24, 22);
            label2.TabIndex = 65;
            label2.Text = "đ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Location = new Point(4, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(707, 1);
            panel2.TabIndex = 66;
            // 
            // ucItemsInCheckOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPrice);
            Controls.Add(panel1);
            Controls.Add(lblOldPrice);
            Controls.Add(lblCondition);
            Margin = new Padding(0);
            Name = "ucItemsInCheckOut";
            Size = new Size(715, 130);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Label lblPrice;
        public Panel panel1;
        public Label lblProductName;
        public PictureBox pbProductImage;
        private Label lblOldPrice;
        private Label lblCondition;
        public Label label1;
        public Label label2;
        private Panel panel2;
    }
}
