namespace QuanLyTraoDoiHang
{
    partial class UCProductInCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProductInCart));
            lblPrice = new Label();
            cbChoose = new CheckBox();
            panel1 = new Panel();
            lblProductName = new Label();
            pbProductImage = new PictureBox();
            btnCancel = new RJControls.RButton();
            lblCondition = new Label();
            lblOldPrice = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Red;
            lblPrice.Location = new Point(250, 57);
            lblPrice.Margin = new Padding(1, 0, 1, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(123, 21);
            lblPrice.TabIndex = 47;
            lblPrice.Text = "price";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbChoose
            // 
            cbChoose.AutoSize = true;
            cbChoose.Location = new Point(16, 51);
            cbChoose.Margin = new Padding(1);
            cbChoose.Name = "cbChoose";
            cbChoose.Size = new Size(15, 14);
            cbChoose.TabIndex = 49;
            cbChoose.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(pbProductImage);
            panel1.Location = new Point(33, 23);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 74);
            panel1.TabIndex = 50;
            // 
            // lblProductName
            // 
            lblProductName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductName.Location = new Point(70, 12);
            lblProductName.Margin = new Padding(1, 0, 1, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(139, 56);
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
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 41, 41);
            btnCancel.BackgroundColor = Color.FromArgb(231, 41, 41);
            btnCancel.BorderColor = Color.PaleVioletRed;
            btnCancel.BorderRadius = 20;
            btnCancel.BorderSize = 0;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(631, 45);
            btnCancel.Margin = new Padding(1);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(66, 37);
            btnCancel.TabIndex = 51;
            btnCancel.TextColor = Color.White;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblCondition
            // 
            lblCondition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCondition.Location = new Point(396, 39);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(207, 58);
            lblCondition.TabIndex = 52;
            lblCondition.Text = "condition of product";
            lblCondition.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblOldPrice
            // 
            lblOldPrice.Font = new Font("Segoe UI", 12F, FontStyle.Strikeout, GraphicsUnit.Point);
            lblOldPrice.Location = new Point(250, 35);
            lblOldPrice.Name = "lblOldPrice";
            lblOldPrice.Size = new Size(123, 22);
            lblOldPrice.TabIndex = 53;
            lblOldPrice.Text = "Old price";
            lblOldPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UCProductInCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(lblOldPrice);
            Controls.Add(lblCondition);
            Controls.Add(lblPrice);
            Controls.Add(cbChoose);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Margin = new Padding(0, 5, 0, 0);
            Name = "UCProductInCart";
            Size = new Size(715, 121);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lblPrice;
        public CheckBox cbChoose;
        public Panel panel1;
        public Label lblProductName;
        public PictureBox pbProductImage;
        public RJControls.RButton btnCancel;
        private Label lblCondition;
        private Label lblOldPrice;
    }
}
