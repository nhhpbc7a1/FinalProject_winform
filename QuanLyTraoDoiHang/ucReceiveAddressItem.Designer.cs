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
            checkChoose = new RadioButton();
            lblName = new Label();
            lblUpdate = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            SuspendLayout();
            // 
            // checkChoose
            // 
            checkChoose.AutoSize = true;
            checkChoose.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkChoose.Location = new Point(26, 26);
            checkChoose.Name = "checkChoose";
            checkChoose.Size = new Size(14, 13);
            checkChoose.TabIndex = 6;
            checkChoose.TabStop = true;
            checkChoose.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(94, 18);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 21);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            lblUpdate.ForeColor = Color.FromArgb(30, 106, 17);
            lblUpdate.Location = new Point(670, 46);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(36, 21);
            lblUpdate.TabIndex = 3;
            lblUpdate.Text = "Edit";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Location = new Point(317, 18);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(54, 21);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.Location = new Point(94, 46);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(570, 64);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "detailed adress, detailed adress, detailed adress, detailed adress, detailed adress, detailed adress, detailed adress, detailed adress, detailed adress, ";
            // 
            // ucReceiveAddressItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(checkChoose);
            Controls.Add(lblName);
            Controls.Add(lblUpdate);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Name = "ucReceiveAddressItem";
            Size = new Size(721, 119);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public RadioButton checkChoose;
        private Label lblName;
        private Label lblPhone;
        private Label lblAddress;
        public Label lblUpdate;
    }
}
