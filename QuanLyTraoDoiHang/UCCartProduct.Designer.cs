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
            this.lblPStatus = new System.Windows.Forms.Label();
            this.lblPPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cBCart = new System.Windows.Forms.CheckBox();
            this.rBDelete = new QuanLyTraoDoiHang.RJControls.RButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPStatus
            // 
            this.lblPStatus.AutoSize = true;
            this.lblPStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPStatus.Location = new System.Drawing.Point(485, 46);
            this.lblPStatus.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPStatus.Name = "lblPStatus";
            this.lblPStatus.Size = new System.Drawing.Size(51, 21);
            this.lblPStatus.TabIndex = 6;
            this.lblPStatus.Text = "status";
            // 
            // lblPPrice
            // 
            this.lblPPrice.AutoSize = true;
            this.lblPPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPPrice.Location = new System.Drawing.Point(297, 45);
            this.lblPPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPPrice.Name = "lblPPrice";
            this.lblPPrice.Size = new System.Drawing.Size(44, 21);
            this.lblPPrice.TabIndex = 5;
            this.lblPPrice.Text = "price";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(61, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 71);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cBCart
            // 
            this.cBCart.AutoSize = true;
            this.cBCart.Location = new System.Drawing.Point(14, 46);
            this.cBCart.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cBCart.Name = "cBCart";
            this.cBCart.Size = new System.Drawing.Size(15, 14);
            this.cBCart.TabIndex = 8;
            this.cBCart.UseVisualStyleBackColor = true;
            // 
            // rBDelete
            // 
            this.rBDelete.BackColor = System.Drawing.Color.LightCoral;
            this.rBDelete.BackgroundColor = System.Drawing.Color.LightCoral;
            this.rBDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rBDelete.BorderRadius = 20;
            this.rBDelete.BorderSize = 0;
            this.rBDelete.FlatAppearance.BorderSize = 0;
            this.rBDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBDelete.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rBDelete.ForeColor = System.Drawing.Color.White;
            this.rBDelete.Location = new System.Drawing.Point(716, 38);
            this.rBDelete.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rBDelete.Name = "rBDelete";
            this.rBDelete.Size = new System.Drawing.Size(81, 37);
            this.rBDelete.TabIndex = 9;
            this.rBDelete.Text = "Delete";
            this.rBDelete.TextColor = System.Drawing.Color.White;
            this.rBDelete.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(111, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 200);
            panel1.TabIndex = 19;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductName.Location = new Point(265, 82);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(123, 46);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "(name)";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(27, 16);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 164);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // dUDStatusShipment
            // 
            dUDStatusShipment.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dUDStatusShipment.Location = new Point(801, 92);
            dUDStatusShipment.Name = "dUDStatusShipment";
            dUDStatusShipment.ReadOnly = true;
            dUDStatusShipment.Size = new Size(300, 52);
            dUDStatusShipment.TabIndex = 16;
            dUDStatusShipment.Text = "(Status)";
            // 
            // UCCartProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.rBDelete);
            this.Controls.Add(this.cBCart);
            this.Controls.Add(this.lblPStatus);
            this.Controls.Add(this.lblPPrice);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "UCCartProduct";
            this.Size = new System.Drawing.Size(898, 108);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblPPrice;
        private CheckBox cBCart;
        private RJControls.RButton rBDelete;
        private Panel panel1;
        private Label lblProductName;
        private PictureBox pictureBox1;
        public DomainUpDown dUDStatusShipment;
    }
}
