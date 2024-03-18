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
            this.lblPPrice = new System.Windows.Forms.Label();
            this.cBCart = new System.Windows.Forms.CheckBox();
            this.rBDelete = new QuanLyTraoDoiHang.RJControls.RButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dUDStatusShipment = new System.Windows.Forms.DomainUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPPrice
            // 
            this.lblPPrice.AutoSize = true;
            this.lblPPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPPrice.Location = new System.Drawing.Point(318, 34);
            this.lblPPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPPrice.Name = "lblPPrice";
            this.lblPPrice.Size = new System.Drawing.Size(38, 19);
            this.lblPPrice.TabIndex = 5;
            this.lblPPrice.Text = "price";
            // 
            // cBCart
            // 
            this.cBCart.AutoSize = true;
            this.cBCart.Location = new System.Drawing.Point(18, 34);
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
            this.rBDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rBDelete.ForeColor = System.Drawing.Color.Black;
            this.rBDelete.Location = new System.Drawing.Point(727, 24);
            this.rBDelete.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rBDelete.Name = "rBDelete";
            this.rBDelete.Size = new System.Drawing.Size(81, 37);
            this.rBDelete.TabIndex = 9;
            this.rBDelete.Text = "Delete";
            this.rBDelete.TextColor = System.Drawing.Color.Black;
            this.rBDelete.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(46, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 73);
            this.panel1.TabIndex = 19;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(109, 30);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(51, 19);
            this.lblProductName.TabIndex = 11;
            this.lblProductName.Text = "(name)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(11, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 60);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // dUDStatusShipment
            // 
            this.dUDStatusShipment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dUDStatusShipment.Location = new System.Drawing.Point(521, 32);
            this.dUDStatusShipment.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dUDStatusShipment.Name = "dUDStatusShipment";
            this.dUDStatusShipment.ReadOnly = true;
            this.dUDStatusShipment.Size = new System.Drawing.Size(124, 25);
            this.dUDStatusShipment.TabIndex = 16;
            this.dUDStatusShipment.Text = "(Status)";
            // 
            // UCCartProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.dUDStatusShipment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rBDelete);
            this.Controls.Add(this.cBCart);
            this.Controls.Add(this.lblPPrice);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "UCCartProduct";
            this.Size = new System.Drawing.Size(870, 83);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
