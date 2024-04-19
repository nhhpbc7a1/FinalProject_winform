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
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            lblTotalPriceThisShop = new Label();
            lblItemNo = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBoxShippingMethod = new ComboBox();
            lblShippingFee = new Label();
            lblShippingType = new Label();
            txtNote = new TextBox();
            lblCustomerNote = new Label();
            ucCartEachShop1 = new UCCartEachShop();
            panel2 = new Panel();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(comboBoxShippingMethod);
            panel3.Controls.Add(lblShippingFee);
            panel3.Controls.Add(lblShippingType);
            panel3.Controls.Add(txtNote);
            panel3.Controls.Add(lblCustomerNote);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 223);
            panel3.Name = "panel3";
            panel3.Size = new Size(715, 128);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(578, 37);
            label2.Name = "label2";
            label2.Size = new Size(20, 21);
            label2.TabIndex = 10;
            label2.Text = "đ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(567, 12);
            label1.Name = "label1";
            label1.Size = new Size(111, 22);
            label1.TabIndex = 9;
            label1.Text = "Shipping Fee";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblTotalPriceThisShop);
            panel1.Controls.Add(lblItemNo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(715, 60);
            panel1.TabIndex = 8;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(569, 20);
            label7.Name = "label7";
            label7.Size = new Size(13, 25);
            label7.TabIndex = 11;
            label7.Text = "đ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPriceThisShop
            // 
            lblTotalPriceThisShop.AutoSize = true;
            lblTotalPriceThisShop.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPriceThisShop.ForeColor = Color.Red;
            lblTotalPriceThisShop.Location = new Point(578, 18);
            lblTotalPriceThisShop.Name = "lblTotalPriceThisShop";
            lblTotalPriceThisShop.Size = new Size(100, 25);
            lblTotalPriceThisShop.TabIndex = 10;
            lblTotalPriceThisShop.Text = "54220000";
            lblTotalPriceThisShop.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblItemNo
            // 
            lblItemNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemNo.ForeColor = Color.Black;
            lblItemNo.Location = new Point(103, 18);
            lblItemNo.Name = "lblItemNo";
            lblItemNo.Size = new Size(28, 21);
            lblItemNo.TabIndex = 9;
            lblItemNo.Text = "10";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(127, 18);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 8;
            label4.Text = "items )";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(13, 18);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 7;
            label3.Text = "Order Total (";
            // 
            // comboBoxShippingMethod
            // 
            comboBoxShippingMethod.BackColor = Color.WhiteSmoke;
            comboBoxShippingMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxShippingMethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxShippingMethod.FormattingEnabled = true;
            comboBoxShippingMethod.Items.AddRange(new object[] { "Standard", "Fast" });
            comboBoxShippingMethod.Location = new Point(351, 15);
            comboBoxShippingMethod.Name = "comboBoxShippingMethod";
            comboBoxShippingMethod.Size = new Size(101, 29);
            comboBoxShippingMethod.TabIndex = 7;
            // 
            // lblShippingFee
            // 
            lblShippingFee.AutoSize = true;
            lblShippingFee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblShippingFee.ForeColor = Color.Black;
            lblShippingFee.Location = new Point(594, 36);
            lblShippingFee.Name = "lblShippingFee";
            lblShippingFee.Size = new Size(55, 21);
            lblShippingFee.TabIndex = 6;
            lblShippingFee.Text = "20000";
            lblShippingFee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblShippingType
            // 
            lblShippingType.AutoSize = true;
            lblShippingType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblShippingType.ForeColor = Color.Black;
            lblShippingType.Location = new Point(221, 15);
            lblShippingType.Name = "lblShippingType";
            lblShippingType.Size = new Size(124, 21);
            lblShippingType.TabIndex = 6;
            lblShippingType.Text = "Shipping Option";
            // 
            // txtNote
            // 
            txtNote.BackColor = Color.White;
            txtNote.BorderStyle = BorderStyle.None;
            txtNote.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNote.ForeColor = SystemColors.WindowFrame;
            txtNote.Location = new Point(63, 15);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.PlaceholderText = "Note for seller";
            txtNote.Size = new Size(152, 41);
            txtNote.TabIndex = 5;
            txtNote.TabStop = false;
            // 
            // lblCustomerNote
            // 
            lblCustomerNote.AutoSize = true;
            lblCustomerNote.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerNote.ForeColor = Color.Black;
            lblCustomerNote.Location = new Point(10, 15);
            lblCustomerNote.Name = "lblCustomerNote";
            lblCustomerNote.Size = new Size(47, 21);
            lblCustomerNote.TabIndex = 4;
            lblCustomerNote.Text = "Note:";
            // 
            // ucCartEachShop1
            // 
            ucCartEachShop1.AutoSize = true;
            ucCartEachShop1.BackColor = Color.WhiteSmoke;
            ucCartEachShop1.Dock = DockStyle.Fill;
            ucCartEachShop1.Location = new Point(0, 0);
            ucCartEachShop1.Margin = new Padding(0);
            ucCartEachShop1.MaximumSize = new Size(715, 10000);
            ucCartEachShop1.MinimumSize = new Size(715, 150);
            ucCartEachShop1.Name = "ucCartEachShop1";
            ucCartEachShop1.Size = new Size(715, 223);
            ucCartEachShop1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(715, 1);
            panel2.TabIndex = 11;
            // 
            // UCCheckOutEachShop
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(ucCartEachShop1);
            Controls.Add(panel3);
            Margin = new Padding(2, 3, 3, 6);
            MaximumSize = new Size(715, 10000);
            MinimumSize = new Size(715, 250);
            Name = "UCCheckOutEachShop";
            Size = new Size(715, 351);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private Label lblShippingType;
        private Label lblCustomerNote;
        public UCCartEachShop ucCartEachShop1;
        public ComboBox comboBoxShippingMethod;
        public Label lblShippingFee;
        public TextBox txtNote;
        private Panel panel1;
        public Label label2;
        public Label label1;
        private Label label3;
        private Label label4;
        public Label label7;
        public Label lblTotalPriceThisShop;
        public Label lblItemNo;
        private Panel panel2;
    }
}
