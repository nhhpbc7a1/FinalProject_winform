namespace QuanLyTraoDoiHang
{
    partial class ucMyPurchase
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
            lblWriteDate = new Label();
            dUDType = new DomainUpDown();
            lblOrderBy = new Label();
            lblEstimateddate = new Label();
            lblOrderCode = new Label();
            pictureBox1 = new PictureBox();
            lblProductName = new Label();
            panel1 = new Panel();
            dUDStatusShipment = new DomainUpDown();
            checkBox1 = new CheckBox();
            lblPPrice = new Label();
            rBCancel = new RJControls.RButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWriteDate
            // 
            lblWriteDate.AutoSize = true;
            lblWriteDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblWriteDate.Location = new Point(426, 101);
            lblWriteDate.Margin = new Padding(1, 0, 1, 0);
            lblWriteDate.Name = "lblWriteDate";
            lblWriteDate.Size = new Size(40, 17);
            lblWriteDate.TabIndex = 63;
            lblWriteDate.Text = "(date)";
            // 
            // dUDType
            // 
            dUDType.BorderStyle = BorderStyle.FixedSingle;
            dUDType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dUDType.Location = new Point(474, 37);
            dUDType.Margin = new Padding(1);
            dUDType.Name = "dUDType";
            dUDType.ReadOnly = true;
            dUDType.RightToLeft = RightToLeft.No;
            dUDType.Size = new Size(122, 25);
            dUDType.TabIndex = 60;
            dUDType.Text = "(Type)";
            // 
            // lblOrderBy
            // 
            lblOrderBy.AutoSize = true;
            lblOrderBy.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderBy.Location = new Point(27, 101);
            lblOrderBy.Margin = new Padding(1, 0, 1, 0);
            lblOrderBy.Name = "lblOrderBy";
            lblOrderBy.RightToLeft = RightToLeft.No;
            lblOrderBy.Size = new Size(64, 17);
            lblOrderBy.TabIndex = 64;
            lblOrderBy.Text = "Order by:";
            // 
            // lblEstimateddate
            // 
            lblEstimateddate.AutoSize = true;
            lblEstimateddate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstimateddate.Location = new Point(322, 101);
            lblEstimateddate.Margin = new Padding(1, 0, 1, 0);
            lblEstimateddate.Name = "lblEstimateddate";
            lblEstimateddate.RightToLeft = RightToLeft.No;
            lblEstimateddate.Size = new Size(102, 17);
            lblEstimateddate.TabIndex = 62;
            lblEstimateddate.Text = "Estimated date: ";
            // 
            // lblOrderCode
            // 
            lblOrderCode.AutoSize = true;
            lblOrderCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderCode.Location = new Point(93, 101);
            lblOrderCode.Margin = new Padding(1, 0, 1, 0);
            lblOrderCode.Name = "lblOrderCode";
            lblOrderCode.Size = new Size(82, 17);
            lblOrderCode.TabIndex = 65;
            lblOrderCode.Text = "(order code)";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(4, 5);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 63);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductName.Location = new Point(70, 27);
            lblProductName.Margin = new Padding(1, 0, 1, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(51, 19);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "(name)";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(27, 10);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(124, 74);
            panel1.TabIndex = 61;
            // 
            // dUDStatusShipment
            // 
            dUDStatusShipment.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dUDStatusShipment.Location = new Point(322, 36);
            dUDStatusShipment.Margin = new Padding(1);
            dUDStatusShipment.Name = "dUDStatusShipment";
            dUDStatusShipment.ReadOnly = true;
            dUDStatusShipment.RightToLeft = RightToLeft.No;
            dUDStatusShipment.Size = new Size(114, 25);
            dUDStatusShipment.TabIndex = 58;
            dUDStatusShipment.Text = "(Status)";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(10, 42);
            checkBox1.Margin = new Padding(1);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 59;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblPPrice
            // 
            lblPPrice.AutoSize = true;
            lblPPrice.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            lblPPrice.Location = new Point(193, 39);
            lblPPrice.Margin = new Padding(1, 0, 1, 0);
            lblPPrice.Name = "lblPPrice";
            lblPPrice.Size = new Size(38, 19);
            lblPPrice.TabIndex = 57;
            lblPPrice.Text = "price";
            // 
            // rBCancel
            // 
            rBCancel.BackColor = Color.FromArgb(231, 41, 41);
            rBCancel.BackgroundColor = Color.FromArgb(231, 41, 41);
            rBCancel.BorderColor = Color.PaleVioletRed;
            rBCancel.BorderRadius = 10;
            rBCancel.BorderSize = 1;
            rBCancel.FlatAppearance.BorderSize = 0;
            rBCancel.FlatStyle = FlatStyle.Flat;
            rBCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rBCancel.ForeColor = Color.White;
            rBCancel.Location = new Point(485, 81);
            rBCancel.Margin = new Padding(1);
            rBCancel.Name = "rBCancel";
            rBCancel.Size = new Size(111, 37);
            rBCancel.TabIndex = 66;
            rBCancel.TextColor = Color.White;
            rBCancel.UseVisualStyleBackColor = false;
            // 
            // ucMyPurchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 237, 204);
            Controls.Add(dUDStatusShipment);
            Controls.Add(lblPPrice);
            Controls.Add(checkBox1);
            Controls.Add(rBCancel);
            Controls.Add(panel1);
            Controls.Add(lblOrderCode);
            Controls.Add(lblEstimateddate);
            Controls.Add(lblOrderBy);
            Controls.Add(dUDType);
            Controls.Add(lblWriteDate);
            Margin = new Padding(9, 5, 5, 5);
            Name = "ucMyPurchase";
            Size = new Size(613, 128);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblWriteDate;
        public DomainUpDown dUDType;
        private Label lblOrderBy;
        public Label lblEstimateddate;
        private Label lblOrderCode;
        public PictureBox pictureBox1;
        public Label lblProductName;
        public Panel panel1;
        public DomainUpDown dUDStatusShipment;
        public CheckBox checkBox1;
        public Label lblPPrice;
        private RJControls.RButton rBCancel;
    }
}
