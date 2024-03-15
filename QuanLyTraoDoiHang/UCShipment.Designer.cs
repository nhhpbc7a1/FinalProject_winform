namespace QuanLyTraoDoiHang
{
    partial class UCShipment
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
            rBDelete = new RJControls.RButton();
            cBCart = new CheckBox();
            lblPPrice = new Label();
            pictureBox1 = new PictureBox();
            dUDStatusShipment = new DomainUpDown();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            rBDelete.Location = new Point(1512, 81);
            rBDelete.Name = "rBDelete";
            rBDelete.Size = new Size(197, 100);
            rBDelete.TabIndex = 14;
            rBDelete.Text = "Cancel";
            rBDelete.TextColor = Color.Black;
            rBDelete.UseVisualStyleBackColor = false;
            // 
            // cBCart
            // 
            cBCart.AutoSize = true;
            cBCart.Location = new Point(-78, 118);
            cBCart.Name = "cBCart";
            cBCart.Size = new Size(34, 33);
            cBCart.TabIndex = 13;
            cBCart.UseVisualStyleBackColor = true;
            // 
            // lblPPrice
            // 
            lblPPrice.AutoSize = true;
            lblPPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPPrice.Location = new Point(578, 103);
            lblPPrice.Margin = new Padding(2, 0, 2, 0);
            lblPPrice.Name = "lblPPrice";
            lblPPrice.Size = new Size(110, 54);
            lblPPrice.TabIndex = 11;
            lblPPrice.Text = "price";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(64, 32);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 193);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // dUDStatusShipment
            // 
            dUDStatusShipment.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            dUDStatusShipment.Location = new Point(900, 100);
            dUDStatusShipment.Name = "dUDStatusShipment";
            dUDStatusShipment.Size = new Size(300, 51);
            dUDStatusShipment.TabIndex = 15;
            dUDStatusShipment.Text = "(Status)";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(16, 118);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(34, 33);
            checkBox1.TabIndex = 16;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // UCShipment
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 237, 204);
            Controls.Add(checkBox1);
            Controls.Add(dUDStatusShipment);
            Controls.Add(rBDelete);
            Controls.Add(cBCart);
            Controls.Add(lblPPrice);
            Controls.Add(pictureBox1);
            Name = "UCShipment";
            Size = new Size(1806, 274);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RJControls.RButton rBDelete;
        private CheckBox cBCart;
        private Label lblPPrice;
        private PictureBox pictureBox1;
        private DomainUpDown dUDStatusShipment;
        private CheckBox checkBox1;
    }
}
