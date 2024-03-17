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
            lblPPrice = new Label();
            cBCart = new CheckBox();
            rBDelete = new RJControls.RButton();
            panel1 = new Panel();
            lblProductName = new Label();
            pictureBox1 = new PictureBox();
            dUDStatusShipment = new DomainUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPPrice
            // 
            lblPPrice.AutoSize = true;
            lblPPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPPrice.Location = new Point(639, 94);
            lblPPrice.Margin = new Padding(2, 0, 2, 0);
            lblPPrice.Name = "lblPPrice";
            lblPPrice.Size = new Size(94, 46);
            lblPPrice.TabIndex = 5;
            lblPPrice.Text = "price";
            // 
            // cBCart
            // 
            cBCart.AutoSize = true;
            cBCart.Location = new Point(43, 94);
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
            rBDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rBDelete.ForeColor = Color.Black;
            rBDelete.Location = new Point(1201, 66);
            rBDelete.Name = "rBDelete";
            rBDelete.Size = new Size(197, 100);
            rBDelete.TabIndex = 9;
            rBDelete.Text = "Delete";
            rBDelete.TextColor = Color.Black;
            rBDelete.UseVisualStyleBackColor = false;
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
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 237, 204);
            Controls.Add(dUDStatusShipment);
            Controls.Add(panel1);
            Controls.Add(rBDelete);
            Controls.Add(cBCart);
            Controls.Add(lblPPrice);
            Margin = new Padding(2);
            Name = "UCCartProduct";
            Size = new Size(1431, 227);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
