namespace QuanLyTraoDoiHang
{
    partial class ucReceiveAddressItem
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
            this.checkChoose = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkChoose
            // 
            this.checkChoose.AutoSize = true;
            this.checkChoose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkChoose.Location = new System.Drawing.Point(31, 58);
            this.checkChoose.Name = "checkChoose";
            this.checkChoose.Size = new System.Drawing.Size(14, 13);
            this.checkChoose.TabIndex = 6;
            this.checkChoose.TabStop = true;
            this.checkChoose.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(94, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 21);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblUpdate.ForeColor = System.Drawing.Color.Navy;
            this.lblUpdate.Location = new System.Drawing.Point(380, 58);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(60, 21);
            this.lblUpdate.TabIndex = 3;
            this.lblUpdate.Text = "Update";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Location = new System.Drawing.Point(238, 18);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(54, 21);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(94, 58);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(249, 64);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "detailed adress, detailed adress, detailed adress, detailed adress, detailed adre" +
    "ss, detailed adress, detailed adress, detailed adress, detailed adress, ";
            // 
            // ucReceiveAddressItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.checkChoose);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Name = "ucReceiveAddressItem";
            this.Size = new System.Drawing.Size(471, 140);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public RadioButton checkChoose;
        private Label lblName;
        private Label lblPhone;
        private Label lblAddress;
        public Label lblUpdate;
    }
}
