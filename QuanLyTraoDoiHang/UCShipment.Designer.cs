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
            dUDType = new DomainUpDown();
            panel1 = new Panel();
            lblProductName = new Label();
            lblEstimateddate = new Label();
            lblWriteDate = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            rBDelete.Location = new Point(1248, 83);
            rBDelete.Name = "rBDelete";
            rBDelete.Size = new Size(146, 99);
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
            lblPPrice.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            lblPPrice.Location = new Point(456, 106);
            lblPPrice.Margin = new Padding(2, 0, 2, 0);
            lblPPrice.Name = "lblPPrice";
            lblPPrice.Size = new Size(94, 46);
            lblPPrice.TabIndex = 11;
            lblPPrice.Text = "price";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(9, 15);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 171);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dUDStatusShipment
            // 
            dUDStatusShipment.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dUDStatusShipment.Location = new Point(574, 109);
            dUDStatusShipment.Name = "dUDStatusShipment";
            dUDStatusShipment.ReadOnly = true;
            dUDStatusShipment.Size = new Size(300, 52);
            dUDStatusShipment.TabIndex = 15;
            dUDStatusShipment.Text = "(Status)";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(41, 119);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(34, 33);
            checkBox1.TabIndex = 16;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dUDType
            // 
            dUDType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dUDType.Location = new Point(893, 109);
            dUDType.Name = "dUDType";
            dUDType.ReadOnly = true;
            dUDType.Size = new Size(339, 52);
            dUDType.TabIndex = 17;
            dUDType.Text = "(TypeOfShipment)";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(81, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 202);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductName.Location = new Point(170, 74);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(123, 46);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "(name)";
            // 
            // lblEstimateddate
            // 
            lblEstimateddate.AutoSize = true;
            lblEstimateddate.Location = new Point(538, 179);
            lblEstimateddate.Name = "lblEstimateddate";
            lblEstimateddate.Size = new Size(230, 41);
            lblEstimateddate.TabIndex = 19;
            lblEstimateddate.Text = "Estimated date: ";
            // 
            // lblWriteDate
            // 
            lblWriteDate.AutoSize = true;
            lblWriteDate.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblWriteDate.Location = new Point(756, 179);
            lblWriteDate.Name = "lblWriteDate";
            lblWriteDate.Size = new Size(93, 41);
            lblWriteDate.TabIndex = 20;
            lblWriteDate.Text = "(date)";
            // 
            // UCShipment
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 237, 204);
            Controls.Add(lblWriteDate);
            Controls.Add(lblEstimateddate);
            Controls.Add(panel1);
            Controls.Add(dUDType);
            Controls.Add(checkBox1);
            Controls.Add(dUDStatusShipment);
            Controls.Add(rBDelete);
            Controls.Add(cBCart);
            Controls.Add(lblPPrice);
            Name = "UCShipment";
            Size = new Size(1431, 274);
            Load += UCShipment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public RJControls.RButton rBDelete;
        public CheckBox cBCart;
        public Label lblPPrice;
        public PictureBox pictureBox1;
        public DomainUpDown dUDStatusShipment;
        public CheckBox checkBox1;
        public DomainUpDown dUDType;
        public Panel panel1;
        public Label lblProductName;
        public Label lblEstimateddate;
        public Label lblWriteDate;
    }
}
