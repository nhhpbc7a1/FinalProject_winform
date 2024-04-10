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
            lblPrice = new Label();
            panel1 = new Panel();
            lblProductName = new Label();
            pbProductImage = new PictureBox();
            lblOldPrice = new Label();
            lblCondition = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Red;
            lblPrice.Location = new Point(565, 51);
            lblPrice.Margin = new Padding(1, 0, 1, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(111, 22);
            lblPrice.TabIndex = 60;
            lblPrice.Text = "price";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(pbProductImage);
            panel1.Location = new Point(25, 16);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 74);
            panel1.TabIndex = 61;
            // 
            // lblProductName
            // 
            lblProductName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductName.Location = new Point(70, 13);
            lblProductName.Margin = new Padding(1, 0, 1, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(207, 55);
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
            pbProductImage.Size = new Size(64, 63);
            pbProductImage.TabIndex = 10;
            pbProductImage.TabStop = false;
            // 
            // lblOldPrice
            // 
            lblOldPrice.Font = new Font("Segoe UI", 12F, FontStyle.Strikeout, GraphicsUnit.Point);
            lblOldPrice.Location = new Point(565, 29);
            lblOldPrice.Name = "lblOldPrice";
            lblOldPrice.Size = new Size(111, 22);
            lblOldPrice.TabIndex = 63;
            lblOldPrice.Text = "Old price";
            lblOldPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCondition
            // 
            lblCondition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCondition.Location = new Point(307, 26);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(152, 61);
            lblCondition.TabIndex = 62;
            lblCondition.Text = "condition of product";
            // 
            // UCProductInCheckOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblPrice);
            Controls.Add(panel1);
            Controls.Add(lblOldPrice);
            Controls.Add(lblCondition);
            Margin = new Padding(0);
            Name = "UCProductInCheckOut";
            Size = new Size(713, 126);
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
    }
}
