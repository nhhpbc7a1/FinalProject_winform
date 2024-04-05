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
            this.comboBoxShippingMethod = new System.Windows.Forms.ComboBox();
            this.lblShippingFee = new System.Windows.Forms.Label();
            this.lblShippingType = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblCustomerNote = new System.Windows.Forms.Label();
            this.ucCartEachShop1 = new QuanLyTraoDoiHang.UCCartEachShop();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(227)))), ((int)(((byte)(197)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBoxShippingMethod);
            this.panel3.Controls.Add(this.lblShippingFee);
            this.panel3.Controls.Add(this.lblShippingType);
            this.panel3.Controls.Add(this.txtNote);
            this.panel3.Controls.Add(this.lblCustomerNote);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(715, 75);
            this.panel3.TabIndex = 3;
            // 
            // comboBoxShippingMethod
            // 
            this.comboBoxShippingMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShippingMethod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxShippingMethod.FormattingEnabled = true;
            this.comboBoxShippingMethod.Items.AddRange(new object[] {
            "Standard",
            "Fast"});
            this.comboBoxShippingMethod.Location = new System.Drawing.Point(401, 15);
            this.comboBoxShippingMethod.Name = "comboBoxShippingMethod";
            this.comboBoxShippingMethod.Size = new System.Drawing.Size(167, 29);
            this.comboBoxShippingMethod.TabIndex = 7;
            // 
            // lblShippingFee
            // 
            this.lblShippingFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShippingFee.ForeColor = System.Drawing.Color.Red;
            this.lblShippingFee.Location = new System.Drawing.Point(574, 14);
            this.lblShippingFee.Name = "lblShippingFee";
            this.lblShippingFee.Size = new System.Drawing.Size(111, 22);
            this.lblShippingFee.TabIndex = 6;
            this.lblShippingFee.Text = "Shipping Fee";
            this.lblShippingFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShippingType
            // 
            this.lblShippingType.AutoSize = true;
            this.lblShippingType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShippingType.Location = new System.Drawing.Point(271, 15);
            this.lblShippingType.Name = "lblShippingType";
            this.lblShippingType.Size = new System.Drawing.Size(124, 21);
            this.lblShippingType.TabIndex = 6;
            this.lblShippingType.Text = "Shipping Option";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNote.Location = new System.Drawing.Point(53, 15);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.PlaceholderText = "Note for seller";
            this.txtNote.Size = new System.Drawing.Size(198, 29);
            this.txtNote.TabIndex = 5;
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
            this.ucCartEachShop1.AutoSize = true;
            this.ucCartEachShop1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucCartEachShop1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCartEachShop1.Location = new System.Drawing.Point(0, 0);
            this.ucCartEachShop1.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.ucCartEachShop1.MaximumSize = new System.Drawing.Size(715, 10000);
            this.ucCartEachShop1.MinimumSize = new System.Drawing.Size(715, 150);
            this.ucCartEachShop1.Name = "ucCartEachShop1";
            this.ucCartEachShop1.Size = new System.Drawing.Size(715, 200);
            this.ucCartEachShop1.TabIndex = 4;
            // 
            // UCCheckOutEachShop
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucCartEachShop1);
            this.Controls.Add(this.panel3);
            this.MaximumSize = new System.Drawing.Size(715, 10000);
            this.MinimumSize = new System.Drawing.Size(715, 250);
            this.Name = "UCCheckOutEachShop";
            this.Size = new System.Drawing.Size(715, 275);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel3;
        private Label lblShippingType;
        private Label lblCustomerNote;
        public UCCartEachShop ucCartEachShop1;
        public ComboBox comboBoxShippingMethod;
        public Label lblShippingFee;
        public TextBox txtNote;
    }
}
