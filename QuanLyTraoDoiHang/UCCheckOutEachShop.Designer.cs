namespace QuanLyTraoDoiHang
{
    partial class UCCheckOutEachShop
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dUDShipping = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShippingType = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCustomerNote = new System.Windows.Forms.Label();
            this.ucCartEachShop1 = new QuanLyTraoDoiHang.UCCartEachShop();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(227)))), ((int)(((byte)(197)))));
            this.panel3.Controls.Add(this.dUDShipping);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblShippingType);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.lblCustomerNote);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(715, 75);
            this.panel3.TabIndex = 3;
            // 
            // dUDShipping
            // 
            this.dUDShipping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dUDShipping.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dUDShipping.Items.Add("Fast");
            this.dUDShipping.Items.Add("Cheap");
            this.dUDShipping.Location = new System.Drawing.Point(426, 15);
            this.dUDShipping.Margin = new System.Windows.Forms.Padding(1);
            this.dUDShipping.Name = "dUDShipping";
            this.dUDShipping.ReadOnly = true;
            this.dUDShipping.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dUDShipping.Size = new System.Drawing.Size(122, 25);
            this.dUDShipping.TabIndex = 51;
            this.dUDShipping.Text = "(Type)";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(574, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Shipping Fee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShippingType
            // 
            this.lblShippingType.AutoSize = true;
            this.lblShippingType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShippingType.Location = new System.Drawing.Point(298, 17);
            this.lblShippingType.Name = "lblShippingType";
            this.lblShippingType.Size = new System.Drawing.Size(124, 21);
            this.lblShippingType.TabIndex = 6;
            this.lblShippingType.Text = "Shipping Option";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(53, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Note for seller";
            // 
            // lblCustomerNote
            // 
            this.lblCustomerNote.AutoSize = true;
            this.lblCustomerNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerNote.Location = new System.Drawing.Point(3, 17);
            this.lblCustomerNote.Name = "lblCustomerNote";
            this.lblCustomerNote.Size = new System.Drawing.Size(44, 21);
            this.lblCustomerNote.TabIndex = 4;
            this.lblCustomerNote.Text = "Note";
            // 
            // ucCartEachShop1
            // 
            this.ucCartEachShop1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCartEachShop1.Location = new System.Drawing.Point(0, 0);
            this.ucCartEachShop1.Name = "ucCartEachShop1";
            this.ucCartEachShop1.Size = new System.Drawing.Size(715, 384);
            this.ucCartEachShop1.TabIndex = 4;
            // 
            // UCCheckOutEachShop
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucCartEachShop1);
            this.Controls.Add(this.panel3);
            this.Name = "UCCheckOutEachShop";
            this.Size = new System.Drawing.Size(715, 459);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel3;
        public DomainUpDown dUDShipping;
        private Label lblShippingType;
        private TextBox textBox1;
        private Label lblCustomerNote;
        private Label label1;
        private UCCartEachShop ucCartEachShop1;
    }
}
