namespace QuanLyTraoDoiHang
{
    partial class UCOrder_buyerSight
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            lblTime = new Label();
            label1 = new Label();
            btnViewShop = new RJControls.RButton();
            lblSellerName = new Label();
            flwpnlOrder = new FlowLayoutPanel();
            panel2 = new Panel();
            lblShippingFee = new Label();
            lblMethod = new Label();
            lblStatus = new Label();
            cbxStatus = new ComboBox();
            lblTotalPrice = new Label();
            label4 = new Label();
            label3 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(flwpnlOrder);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.MaximumSize = new Size(725, 100000);
            flowLayoutPanel1.MinimumSize = new Size(725, 252);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(725, 252);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnViewShop);
            panel1.Controls.Add(lblSellerName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 58);
            panel1.TabIndex = 0;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(492, 14);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(85, 20);
            lblTime.TabIndex = 5;
            lblTime.Text = "10/11/2004";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(399, 13);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 4;
            label1.Text = "Placed Time";
            // 
            // btnViewShop
            // 
            btnViewShop.BackColor = Color.LightCoral;
            btnViewShop.BackgroundColor = Color.LightCoral;
            btnViewShop.BorderColor = Color.PaleVioletRed;
            btnViewShop.BorderRadius = 20;
            btnViewShop.BorderSize = 0;
            btnViewShop.FlatAppearance.BorderSize = 0;
            btnViewShop.FlatStyle = FlatStyle.Flat;
            btnViewShop.ForeColor = Color.White;
            btnViewShop.Location = new Point(162, 11);
            btnViewShop.Name = "btnViewShop";
            btnViewShop.Size = new Size(108, 29);
            btnViewShop.TabIndex = 1;
            btnViewShop.Text = "View Shop";
            btnViewShop.TextColor = Color.White;
            btnViewShop.UseVisualStyleBackColor = false;
            // 
            // lblSellerName
            // 
            lblSellerName.AutoSize = true;
            lblSellerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSellerName.Location = new Point(27, 19);
            lblSellerName.Name = "lblSellerName";
            lblSellerName.Size = new Size(103, 21);
            lblSellerName.TabIndex = 0;
            lblSellerName.Text = "Seller's name";
            // 
            // flwpnlOrder
            // 
            flwpnlOrder.AutoSize = true;
            flwpnlOrder.Dock = DockStyle.Top;
            flwpnlOrder.Location = new Point(0, 58);
            flwpnlOrder.Margin = new Padding(0);
            flwpnlOrder.MaximumSize = new Size(625, 100000);
            flwpnlOrder.MinimumSize = new Size(625, 128);
            flwpnlOrder.Name = "flwpnlOrder";
            flwpnlOrder.Size = new Size(625, 128);
            flwpnlOrder.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 192);
            panel2.Controls.Add(lblShippingFee);
            panel2.Controls.Add(lblMethod);
            panel2.Controls.Add(lblStatus);
            panel2.Controls.Add(cbxStatus);
            panel2.Controls.Add(lblTotalPrice);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 186);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(625, 66);
            panel2.TabIndex = 2;
            // 
            // lblShippingFee
            // 
            lblShippingFee.AutoSize = true;
            lblShippingFee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblShippingFee.Location = new Point(370, 21);
            lblShippingFee.Name = "lblShippingFee";
            lblShippingFee.Size = new Size(63, 21);
            lblShippingFee.TabIndex = 3;
            lblShippingFee.Text = "shipFee";
            // 
            // lblMethod
            // 
            lblMethod.AutoSize = true;
            lblMethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMethod.Location = new Point(229, 21);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(115, 21);
            lblMethod.TabIndex = 3;
            lblMethod.Text = "deliver method";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(16, 17);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 21);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status";
            // 
            // cbxStatus
            // 
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "waiting", "shipping", "completed", "cancelled", "returned" });
            cbxStatus.Location = new Point(74, 19);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(121, 23);
            cbxStatus.TabIndex = 4;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPrice.Location = new Point(510, 38);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(64, 21);
            lblTotalPrice.TabIndex = 3;
            lblTotalPrice.Text = "100000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(488, 41);
            label4.Name = "label4";
            label4.Size = new Size(16, 17);
            label4.TabIndex = 2;
            label4.Text = "đ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(494, 17);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 1;
            label3.Text = "Total Price";
            // 
            // UCOrder_buyerSight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(flowLayoutPanel1);
            MaximumSize = new Size(625, 100000);
            MinimumSize = new Size(625, 252);
            Name = "UCOrder_buyerSight";
            Size = new Size(625, 252);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private FlowLayoutPanel flwpnlOrder;
        private Panel panel2;
        private Label lblSellerName;
        private Label lblTotalPrice;
        private Label label4;
        private Label label3;
        private Label lblMethod;
        public ComboBox cbxStatus;
        public Label lblStatus;
        private RJControls.RButton btnViewShop;
        private Label lblShippingFee;
        private Label lblTime;
        private Label label1;
    }
}
