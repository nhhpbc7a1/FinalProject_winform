namespace QuanLyTraoDoiHang
{
    partial class FormProduct
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            pnlChildForm = new Panel();
            panel4 = new Panel();
            flowLayoutPanelProductList = new FlowLayoutPanel();
            panel1 = new Panel();
            panel8 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel7 = new Panel();
            label5 = new Label();
            label6 = new Label();
            btnApply = new RJControls.RButton();
            cbMaxPrice = new ComboBox();
            cbMinPrice = new ComboBox();
            panel6 = new Panel();
            cbAddress = new ComboBox();
            checkListBoxAddress = new CheckedListBox();
            label21 = new Label();
            panel5 = new Panel();
            checkListBoxCategory = new CheckedListBox();
            cbCategory = new ComboBox();
            label20 = new Label();
            label22 = new Label();
            pnlChildForm.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChildForm
            // 
            pnlChildForm.BackColor = SystemColors.ControlLight;
            pnlChildForm.Controls.Add(panel4);
            pnlChildForm.Controls.Add(panel2);
            pnlChildForm.Dock = DockStyle.Fill;
            pnlChildForm.Location = new Point(0, 0);
            pnlChildForm.Name = "pnlChildForm";
            pnlChildForm.Size = new Size(984, 561);
            pnlChildForm.TabIndex = 58;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.AutoSize = true;
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(flowLayoutPanelProductList);
            panel4.Controls.Add(panel1);
            panel4.Location = new Point(265, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(719, 561);
            panel4.TabIndex = 56;
            // 
            // flowLayoutPanelProductList
            // 
            flowLayoutPanelProductList.AutoScroll = true;
            flowLayoutPanelProductList.BackColor = Color.White;
            flowLayoutPanelProductList.Location = new Point(6, 63);
            flowLayoutPanelProductList.Name = "flowLayoutPanelProductList";
            flowLayoutPanelProductList.Padding = new Padding(0, 5, 0, 0);
            flowLayoutPanelProductList.Size = new Size(698, 495);
            flowLayoutPanelProductList.TabIndex = 62;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(101, 183, 65);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.FromArgb(30, 106, 17);
            panel1.Location = new Point(6, 10);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 54);
            panel1.TabIndex = 61;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(30, 90, 12);
            panel8.Dock = DockStyle.Bottom;
            panel8.ForeColor = Color.FromArgb(30, 106, 17);
            panel8.Location = new Point(0, 49);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(701, 5);
            panel8.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(260, 13);
            label1.Name = "label1";
            label1.Size = new Size(191, 25);
            label1.TabIndex = 0;
            label1.Text = "Suggestion for today";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label22);
            panel2.Location = new Point(12, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 551);
            panel2.TabIndex = 56;
            // 
            // panel7
            // 
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(btnApply);
            panel7.Controls.Add(cbMaxPrice);
            panel7.Controls.Add(cbMinPrice);
            panel7.Location = new Point(18, 376);
            panel7.Name = "panel7";
            panel7.Size = new Size(214, 141);
            panel7.TabIndex = 59;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(16, 13);
            label5.Name = "label5";
            label5.Size = new Size(93, 21);
            label5.TabIndex = 50;
            label5.Text = "Min price";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(16, 48);
            label6.Name = "label6";
            label6.Size = new Size(93, 21);
            label6.TabIndex = 51;
            label6.Text = "Max price";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.FromArgb(101, 183, 65);
            btnApply.BackgroundColor = Color.FromArgb(101, 183, 65);
            btnApply.BorderColor = Color.FromArgb(101, 183, 65);
            btnApply.BorderRadius = 25;
            btnApply.BorderSize = 2;
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnApply.ForeColor = Color.White;
            btnApply.Location = new Point(17, 88);
            btnApply.Margin = new Padding(3, 2, 3, 2);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(187, 51);
            btnApply.TabIndex = 54;
            btnApply.Text = "Apply";
            btnApply.TextColor = Color.White;
            btnApply.UseVisualStyleBackColor = false;
            // 
            // cbMaxPrice
            // 
            cbMaxPrice.BackColor = Color.White;
            cbMaxPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMaxPrice.FormattingEnabled = true;
            cbMaxPrice.Items.AddRange(new object[] { "100000", "200000", "500000", "1000000", "2000000", "5000000" });
            cbMaxPrice.Location = new Point(115, 45);
            cbMaxPrice.Name = "cbMaxPrice";
            cbMaxPrice.Size = new Size(89, 29);
            cbMaxPrice.TabIndex = 56;
            // 
            // cbMinPrice
            // 
            cbMinPrice.BackColor = Color.White;
            cbMinPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMinPrice.FormattingEnabled = true;
            cbMinPrice.Items.AddRange(new object[] { "0", "100000", "200000", "500000" });
            cbMinPrice.Location = new Point(115, 10);
            cbMinPrice.Name = "cbMinPrice";
            cbMinPrice.Size = new Size(89, 29);
            cbMinPrice.TabIndex = 55;
            // 
            // panel6
            // 
            panel6.Controls.Add(cbAddress);
            panel6.Controls.Add(checkListBoxAddress);
            panel6.Controls.Add(label21);
            panel6.Location = new Point(18, 210);
            panel6.Name = "panel6";
            panel6.Size = new Size(214, 165);
            panel6.TabIndex = 58;
            // 
            // cbAddress
            // 
            cbAddress.AccessibleRole = AccessibleRole.None;
            cbAddress.AutoCompleteMode = AutoCompleteMode.Append;
            cbAddress.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbAddress.BackColor = Color.White;
            cbAddress.DropDownHeight = 110;
            cbAddress.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbAddress.FormattingEnabled = true;
            cbAddress.IntegralHeight = false;
            cbAddress.Items.AddRange(new object[] { "An Giang", "Bà Rịa - Vũng Tàu", "Bạc Liêu", "Bắc Giang", "Bắc Kạn", "Bắc Ninh", "Bến Tre", "Bình Định", "Binh Duong", "Bình Phước", "Bình Thuận", "Cà Mau", "Cần Thơ", "Cao Bằng", "Đà Nẵng", "Đắk Lắk", "Đắk Nông", "Điện Biên", "Dong Nai", "Đồng Tháp", "Gia Lai", "Hà Giang", "Hà Nam", "Hà Nội", "Hà Tĩnh", "Hải Dương", "Hải Phòng", "Hậu Giang", "Hòa Bình", "Hồ Chí Minh (TP.HCM)", "Hưng Yên", "Khánh Hòa", "Kiên Giang", "Kon Tum", "Lai Châu", "Lâm Đồng", "Lạng Sơn", "Lào Cai", "Long An", "Nam Định", "Nghệ An", "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Phú Yên", "Quảng Bình", "Quảng Nam", "Quảng Ngãi", "Quảng Ninh", "Quảng Trị", "Sóc Trăng", "Sơn La", "Tây Ninh", "Thái Bình", "Thái Nguyên", "Thanh Hóa", "Thừa Thiên Huế", "Tiền Giang", "Trà Vinh", "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái" });
            cbAddress.Location = new Point(17, 132);
            cbAddress.Name = "cbAddress";
            cbAddress.Size = new Size(172, 28);
            cbAddress.TabIndex = 53;
            // 
            // checkListBoxAddress
            // 
            checkListBoxAddress.BorderStyle = BorderStyle.None;
            checkListBoxAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkListBoxAddress.FormattingEnabled = true;
            checkListBoxAddress.Items.AddRange(new object[] { "Ha Noi", "Ho Chi Minh", "Da Nang", "Hai Phong" });
            checkListBoxAddress.Location = new Point(10, 30);
            checkListBoxAddress.Name = "checkListBoxAddress";
            checkListBoxAddress.Size = new Size(190, 96);
            checkListBoxAddress.TabIndex = 54;
            // 
            // label21
            // 
            label21.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ImageAlign = ContentAlignment.MiddleLeft;
            label21.Location = new Point(35, 6);
            label21.Name = "label21";
            label21.Size = new Size(137, 21);
            label21.TabIndex = 42;
            label21.Text = "Store address";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(checkListBoxCategory);
            panel5.Controls.Add(cbCategory);
            panel5.Controls.Add(label20);
            panel5.Location = new Point(18, 41);
            panel5.Name = "panel5";
            panel5.Size = new Size(214, 175);
            panel5.TabIndex = 57;
            // 
            // checkListBoxCategory
            // 
            checkListBoxCategory.BorderStyle = BorderStyle.None;
            checkListBoxCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkListBoxCategory.FormattingEnabled = true;
            checkListBoxCategory.Items.AddRange(new object[] { "Smart Phone", "Laptop", "Motorbike", "Car" });
            checkListBoxCategory.Location = new Point(10, 33);
            checkListBoxCategory.Name = "checkListBoxCategory";
            checkListBoxCategory.Size = new Size(190, 96);
            checkListBoxCategory.TabIndex = 52;
            // 
            // cbCategory
            // 
            cbCategory.AutoCompleteMode = AutoCompleteMode.Append;
            cbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbCategory.BackColor = Color.White;
            cbCategory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Smart phone", "Laptop", "Motorbike", "Car", "tai nghe", "Moc Khoa", "Album", "Clothes", "Furnitures", "Electronic Devices", "Mini Models", "Stationeries", "Decorations", "Books", "Robot Toys", "Accessories", "Cosmetics" });
            cbCategory.Location = new Point(17, 135);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(172, 28);
            cbCategory.TabIndex = 51;
            // 
            // label20
            // 
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(57, 9);
            label20.Name = "label20";
            label20.Size = new Size(103, 21);
            label20.TabIndex = 49;
            label20.Text = "Category";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.FromArgb(30, 106, 17);
            label22.Image = (Image)resources.GetObject("label22.Image");
            label22.ImageAlign = ContentAlignment.MiddleLeft;
            label22.Location = new Point(35, 13);
            label22.Name = "label22";
            label22.Size = new Size(159, 25);
            label22.TabIndex = 41;
            label22.Text = "Product Filter";
            label22.TextAlign = ContentAlignment.TopRight;
            // 
            // FormProduct
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(984, 561);
            Controls.Add(pnlChildForm);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProduct";
            Text = "Product";
            pnlChildForm.ResumeLayout(false);
            pnlChildForm.PerformLayout();
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlChildForm;
        private Panel panel4;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ComboBox cbMaxPrice;
        private ComboBox cbMinPrice;
        private RJControls.RButton btnApply;
        private Label label6;
        private Label label5;
        private Label label20;
        private Label label22;
        private Label label21;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private CheckedListBox checkListBoxAddress;
        private ComboBox cbAddress;
        private CheckedListBox checkListBoxCategory;
        private ComboBox cbCategory;
        public FlowLayoutPanel flowLayoutPanelProductList;
        private Panel panel8;
    }
}