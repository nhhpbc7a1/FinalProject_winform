namespace QuanLyTraoDoiHang
{
    partial class UCCartProduct
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
            lblPStatus = new Label();
            lblPPrice = new Label();
            pictureBox1 = new PictureBox();
            cBCart = new CheckBox();
            rBDelete = new RJControls.RButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPStatus
            // 
            lblPStatus.AutoSize = true;
            lblPStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPStatus.Location = new Point(1456, 125);
            lblPStatus.Margin = new Padding(2, 0, 2, 0);
            lblPStatus.Name = "lblPStatus";
            lblPStatus.Size = new Size(128, 54);
            lblPStatus.TabIndex = 6;
            lblPStatus.Text = "status";
            lblPStatus.Click += lblPStatus_Click;
            // 
            // lblPPrice
            // 
            lblPPrice.AutoSize = true;
            lblPPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPPrice.Location = new Point(960, 125);
            lblPPrice.Margin = new Padding(2, 0, 2, 0);
            lblPPrice.Name = "lblPPrice";
            lblPPrice.Size = new Size(110, 54);
            lblPPrice.TabIndex = 5;
            lblPPrice.Text = "price";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(149, 45);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 193);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // cBCart
            // 
            cBCart.AutoSize = true;
            cBCart.Location = new Point(33, 125);
            cBCart.Name = "cBCart";
            cBCart.Size = new Size(34, 33);
            cBCart.TabIndex = 8;
            cBCart.UseVisualStyleBackColor = true;
            // 
            // rBDelete
            // 
            rBDelete.BackColor = Color.LightCoral;
            rBDelete.BackgroundColor = Color.LightCoral;
            rBDelete.BorderColor = Color.PaleVioletRed;
            rBDelete.BorderRadius = 20;
            rBDelete.BorderSize = 0;
            rBDelete.FlatAppearance.BorderSize = 0;
            rBDelete.FlatStyle = FlatStyle.Flat;
            rBDelete.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            rBDelete.ForeColor = Color.Black;
            rBDelete.Location = new Point(1811, 103);
            rBDelete.Name = "rBDelete";
            rBDelete.Size = new Size(197, 100);
            rBDelete.TabIndex = 9;
            rBDelete.Text = "Delete";
            rBDelete.TextColor = Color.Black;
            rBDelete.UseVisualStyleBackColor = false;
            // 
            // UCCartProduct
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 237, 204);
            Controls.Add(rBDelete);
            Controls.Add(cBCart);
            Controls.Add(lblPStatus);
            Controls.Add(lblPPrice);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "UCCartProduct";
            Size = new Size(2182, 295);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPStatus;
        private Label lblPPrice;
        private PictureBox pictureBox1;
        private CheckBox cBCart;
        private RJControls.RButton rBDelete;
    }
}
