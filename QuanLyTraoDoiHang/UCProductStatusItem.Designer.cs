namespace QuanLyTraoDoiHang
{
    partial class UCProductStatusItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProductStatusItem));
            this.dUDStatusShipment = new System.Windows.Forms.DomainUpDown();
            this.lblPPrice = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rBCancel = new QuanLyTraoDoiHang.RJControls.RButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOrderCode = new System.Windows.Forms.Label();
            this.lblEstimateddate = new System.Windows.Forms.Label();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.dUDType = new System.Windows.Forms.DomainUpDown();
            this.lblWriteDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dUDStatusShipment
            // 
            this.dUDStatusShipment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dUDStatusShipment.Location = new System.Drawing.Point(323, 34);
            this.dUDStatusShipment.Margin = new System.Windows.Forms.Padding(1);
            this.dUDStatusShipment.Name = "dUDStatusShipment";
            this.dUDStatusShipment.ReadOnly = true;
            this.dUDStatusShipment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dUDStatusShipment.Size = new System.Drawing.Size(114, 25);
            this.dUDStatusShipment.TabIndex = 48;
            this.dUDStatusShipment.Text = "(Status)";
            // 
            // lblPPrice
            // 
            this.lblPPrice.AutoSize = true;
            this.lblPPrice.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPPrice.Location = new System.Drawing.Point(194, 37);
            this.lblPPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPPrice.Name = "lblPPrice";
            this.lblPPrice.Size = new System.Drawing.Size(38, 19);
            this.lblPPrice.TabIndex = 47;
            this.lblPPrice.Text = "price";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 40);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 49;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rBCancel
            // 
            this.rBCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.rBCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.rBCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rBCancel.BorderRadius = 20;
            this.rBCancel.BorderSize = 1;
            this.rBCancel.FlatAppearance.BorderSize = 0;
            this.rBCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rBCancel.ForeColor = System.Drawing.Color.White;
            this.rBCancel.Image = ((System.Drawing.Image)(resources.GetObject("rBCancel.Image")));
            this.rBCancel.Location = new System.Drawing.Point(618, 28);
            this.rBCancel.Margin = new System.Windows.Forms.Padding(1);
            this.rBCancel.Name = "rBCancel";
            this.rBCancel.Size = new System.Drawing.Size(66, 37);
            this.rBCancel.TabIndex = 56;
            this.rBCancel.TextColor = System.Drawing.Color.White;
            this.rBCancel.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(28, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 74);
            this.panel1.TabIndex = 51;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(70, 27);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(51, 19);
            this.lblProductName.TabIndex = 11;
            this.lblProductName.Text = "(name)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 63);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblOrderCode
            // 
            this.lblOrderCode.AutoSize = true;
            this.lblOrderCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderCode.Location = new System.Drawing.Point(94, 99);
            this.lblOrderCode.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOrderCode.Name = "lblOrderCode";
            this.lblOrderCode.Size = new System.Drawing.Size(82, 17);
            this.lblOrderCode.TabIndex = 55;
            this.lblOrderCode.Text = "(order code)";
            // 
            // lblEstimateddate
            // 
            this.lblEstimateddate.AutoSize = true;
            this.lblEstimateddate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstimateddate.Location = new System.Drawing.Point(323, 99);
            this.lblEstimateddate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEstimateddate.Name = "lblEstimateddate";
            this.lblEstimateddate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEstimateddate.Size = new System.Drawing.Size(102, 17);
            this.lblEstimateddate.TabIndex = 52;
            this.lblEstimateddate.Text = "Estimated date: ";
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.AutoSize = true;
            this.lblOrderBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderBy.Location = new System.Drawing.Point(28, 99);
            this.lblOrderBy.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOrderBy.Size = new System.Drawing.Size(64, 17);
            this.lblOrderBy.TabIndex = 54;
            this.lblOrderBy.Text = "Order by:";
            // 
            // dUDType
            // 
            this.dUDType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dUDType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dUDType.Location = new System.Drawing.Point(475, 35);
            this.dUDType.Margin = new System.Windows.Forms.Padding(1);
            this.dUDType.Name = "dUDType";
            this.dUDType.ReadOnly = true;
            this.dUDType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dUDType.Size = new System.Drawing.Size(122, 25);
            this.dUDType.TabIndex = 50;
            this.dUDType.Text = "(Type)";
            // 
            // lblWriteDate
            // 
            this.lblWriteDate.AutoSize = true;
            this.lblWriteDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblWriteDate.Location = new System.Drawing.Point(427, 99);
            this.lblWriteDate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblWriteDate.Name = "lblWriteDate";
            this.lblWriteDate.Size = new System.Drawing.Size(40, 17);
            this.lblWriteDate.TabIndex = 53;
            this.lblWriteDate.Text = "(date)";
            // 
            // UCProductStatusItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.dUDStatusShipment);
            this.Controls.Add(this.lblPPrice);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.rBCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOrderCode);
            this.Controls.Add(this.lblEstimateddate);
            this.Controls.Add(this.lblOrderBy);
            this.Controls.Add(this.dUDType);
            this.Controls.Add(this.lblWriteDate);
            this.Name = "UCProductStatusItem";
            this.Size = new System.Drawing.Size(693, 128);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DomainUpDown dUDStatusShipment;
        public Label lblPPrice;
        public CheckBox checkBox1;
        private RJControls.RButton rBCancel;
        public Panel panel1;
        public Label lblProductName;
        public PictureBox pictureBox1;
        private Label lblOrderCode;
        public Label lblEstimateddate;
        private Label lblOrderBy;
        public DomainUpDown dUDType;
        public Label lblWriteDate;
    }
}
