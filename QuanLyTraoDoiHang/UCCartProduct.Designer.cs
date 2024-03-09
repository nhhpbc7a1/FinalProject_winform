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
            btnDelete = new Button();
            lblPStatus = new Label();
            lblPPrice = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(898, 51);
            btnDelete.Margin = new Padding(1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 49);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblPStatus
            // 
            lblPStatus.AutoSize = true;
            lblPStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPStatus.Location = new Point(685, 61);
            lblPStatus.Margin = new Padding(1, 0, 1, 0);
            lblPStatus.Name = "lblPStatus";
            lblPStatus.Size = new Size(63, 28);
            lblPStatus.TabIndex = 6;
            lblPStatus.Text = "status";
            lblPStatus.Click += lblPStatus_Click;
            // 
            // lblPPrice
            // 
            lblPPrice.AutoSize = true;
            lblPPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPPrice.Location = new Point(452, 61);
            lblPPrice.Margin = new Padding(1, 0, 1, 0);
            lblPPrice.Name = "lblPPrice";
            lblPPrice.Size = new Size(55, 28);
            lblPPrice.TabIndex = 5;
            lblPPrice.Text = "price";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(70, 22);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 94);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // UCCartProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 237, 204);
            Controls.Add(btnDelete);
            Controls.Add(lblPStatus);
            Controls.Add(lblPPrice);
            Controls.Add(pictureBox1);
            Margin = new Padding(1);
            Name = "UCCartProduct";
            Size = new Size(1148, 144);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Label lblPStatus;
        private Label lblPPrice;
        private PictureBox pictureBox1;
    }
}
