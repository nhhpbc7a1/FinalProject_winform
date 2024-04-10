namespace QuanLyTraoDoiHang
{
    partial class ucOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucOrder));
            panel1 = new Panel();
            lblTime = new Label();
            label1 = new Label();
            lblPhone = new Label();
            lblName = new Label();
            flwpnlOrder = new FlowLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            label6 = new Label();
            lblItemsQuantity = new Label();
            lblMethod = new Label();
            lblStatus = new Label();
            cbxStatus = new ComboBox();
            lblTotalPrice = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(101, 183, 65);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(lblName);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 58);
            panel1.TabIndex = 0;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(522, 20);
            lblTime.Name = "lblTime";
            lblTime.RightToLeft = RightToLeft.No;
            lblTime.Size = new Size(87, 21);
            lblTime.TabIndex = 3;
            lblTime.Text = "10/11/2004";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(427, 20);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(98, 21);
            label1.TabIndex = 2;
            label1.Text = "Placed Time";
            // 
            // lblPhone
            // 
            lblPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.White;
            lblPhone.Image = (Image)resources.GetObject("lblPhone.Image");
            lblPhone.ImageAlign = ContentAlignment.MiddleLeft;
            lblPhone.Location = new Point(217, 20);
            lblPhone.Name = "lblPhone";
            lblPhone.RightToLeft = RightToLeft.No;
            lblPhone.Size = new Size(164, 21);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Phone number";
            lblPhone.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(37, 19);
            lblName.Name = "lblName";
            lblName.RightToLeft = RightToLeft.No;
            lblName.Size = new Size(106, 21);
            lblName.TabIndex = 0;
            lblName.Text = "Buyer's name";
            // 
            // flwpnlOrder
            // 
            flwpnlOrder.AutoSize = true;
            flwpnlOrder.Dock = DockStyle.Left;
            flwpnlOrder.Location = new Point(0, 58);
            flwpnlOrder.Margin = new Padding(0, 0, 5, 0);
            flwpnlOrder.MaximumSize = new Size(720, 100000);
            flwpnlOrder.MinimumSize = new Size(720, 128);
            flwpnlOrder.Name = "flwpnlOrder";
            flwpnlOrder.RightToLeft = RightToLeft.No;
            flwpnlOrder.Size = new Size(720, 128);
            flwpnlOrder.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lblItemsQuantity);
            panel2.Controls.Add(lblMethod);
            panel2.Controls.Add(lblStatus);
            panel2.Controls.Add(cbxStatus);
            panel2.Controls.Add(lblTotalPrice);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 186);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(720, 66);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(153, 17);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(57, 21);
            label2.TabIndex = 11;
            label2.Text = "items )";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(35, 17);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(96, 21);
            label6.TabIndex = 10;
            label6.Text = "Order Total (";
            // 
            // lblItemsQuantity
            // 
            lblItemsQuantity.AutoSize = true;
            lblItemsQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemsQuantity.Location = new Point(128, 17);
            lblItemsQuantity.Name = "lblItemsQuantity";
            lblItemsQuantity.RightToLeft = RightToLeft.No;
            lblItemsQuantity.Size = new Size(28, 21);
            lblItemsQuantity.TabIndex = 6;
            lblItemsQuantity.Text = "no";
            // 
            // lblMethod
            // 
            lblMethod.AutoSize = true;
            lblMethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMethod.Location = new Point(240, 17);
            lblMethod.Name = "lblMethod";
            lblMethod.RightToLeft = RightToLeft.No;
            lblMethod.Size = new Size(115, 21);
            lblMethod.TabIndex = 3;
            lblMethod.Text = "deliver method";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(416, 19);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 21);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status";
            lblStatus.Visible = false;
            // 
            // cbxStatus
            // 
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "waiting", "shipping", "completed", "cancelled", "returned" });
            cbxStatus.Location = new Point(474, 19);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.RightToLeft = RightToLeft.No;
            cbxStatus.Size = new Size(97, 23);
            cbxStatus.TabIndex = 4;
            cbxStatus.Visible = false;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPrice.ForeColor = Color.Red;
            lblTotalPrice.Location = new Point(628, 31);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.RightToLeft = RightToLeft.No;
            lblTotalPrice.Size = new Size(61, 21);
            lblTotalPrice.TabIndex = 3;
            lblTotalPrice.Text = "100000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(607, 31);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(20, 21);
            label4.TabIndex = 2;
            label4.Text = "đ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(617, 10);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 1;
            label3.Text = "Total Price";
            // 
            // ucOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(flwpnlOrder);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(8, 8, 0, 0);
            MaximumSize = new Size(720, 100000);
            MinimumSize = new Size(720, 252);
            Name = "ucOrder";
            RightToLeft = RightToLeft.No;
            Size = new Size(720, 252);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private FlowLayoutPanel flwpnlOrder;
        private Panel panel2;
        private Label lblPhone;
        private Label lblName;
        private Label lblTotalPrice;
        private Label label4;
        private Label label3;
        private Label lblMethod;
        private Label lblTime;
        private Label label1;
        public ComboBox cbxStatus;
        public Label lblStatus;
        private Label lblItemsQuantity;
        private Label label2;
        private Label label6;
    }
}
