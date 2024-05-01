namespace QuanLyTraoDoiHang
{
    partial class ucVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucVoucher));
            panel1 = new Panel();
            lblVoucherId = new Label();
            label1 = new Label();
            lblName = new Label();
            label3 = new Label();
            label2 = new Label();
            lblPercentage = new Label();
            label4 = new Label();
            label5 = new Label();
            lblMaxDiscountableValue = new Label();
            lblTime = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 106, 17);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblVoucherId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 136);
            panel1.TabIndex = 0;
            // 
            // lblVoucherId
            // 
            lblVoucherId.AutoSize = true;
            lblVoucherId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVoucherId.ForeColor = Color.White;
            lblVoucherId.Location = new Point(94, 109);
            lblVoucherId.Name = "lblVoucherId";
            lblVoucherId.Size = new Size(43, 17);
            lblVoucherId.TabIndex = 4;
            lblVoucherId.Text = "label6";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 109);
            label1.Name = "label1";
            label1.Size = new Size(90, 17);
            label1.TabIndex = 3;
            label1.Text = "Voucher's id : ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(94, 52);
            lblName.Name = "lblName";
            lblName.Size = new Size(47, 21);
            lblName.TabIndex = 2;
            lblName.Text = "KoHa";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(3, 30);
            label3.Name = "label3";
            label3.Size = new Size(85, 65);
            label3.TabIndex = 1;
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(192, 19);
            label2.Name = "label2";
            label2.Size = new Size(186, 21);
            label2.TabIndex = 1;
            label2.Text = "Discount_Percentage(%)";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPercentage.Location = new Point(439, 19);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(25, 21);
            lblPercentage.TabIndex = 2;
            lblPercentage.Text = "10";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(192, 88);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 3;
            label4.Text = "Expiring Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(192, 52);
            label5.Name = "label5";
            label5.Size = new Size(224, 21);
            label5.TabIndex = 4;
            label5.Text = "Max_Discountable_Value(VND)";
            // 
            // lblMaxDiscountableValue
            // 
            lblMaxDiscountableValue.AutoSize = true;
            lblMaxDiscountableValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMaxDiscountableValue.Location = new Point(439, 52);
            lblMaxDiscountableValue.Name = "lblMaxDiscountableValue";
            lblMaxDiscountableValue.Size = new Size(64, 21);
            lblMaxDiscountableValue.TabIndex = 5;
            lblMaxDiscountableValue.Text = "500000";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(439, 88);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(94, 21);
            lblTime.TabIndex = 6;
            lblTime.Text = "10/11/2004";
            lblTime.Click += label3_Click;
            // 
            // ucVoucher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblTime);
            Controls.Add(lblMaxDiscountableValue);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblPercentage);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(6, 3, 3, 3);
            Name = "ucVoucher";
            Size = new Size(918, 136);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label lblPercentage;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label lblMaxDiscountableValue;
        private Label lblTime;
        private Label lblName;
        private Label lblVoucherId;
        private Label label1;
    }
}
