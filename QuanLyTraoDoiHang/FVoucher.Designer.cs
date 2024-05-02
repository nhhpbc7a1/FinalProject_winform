namespace QuanLyTraoDoiHang
{
    partial class FVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVoucher));
            panel2 = new Panel();
            panel3 = new Panel();
            btnBack = new RJControls.RButton();
            pnlVoucherList = new FlowLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            btnSelect = new RJControls.RButton();
            panel4 = new Panel();
            cbxVoucherSelect = new ComboBox();
            label2 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnBack);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 49);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Green;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(982, 2);
            panel3.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlLightLight;
            btnBack.BackgroundColor = SystemColors.ControlLightLight;
            btnBack.BorderColor = Color.PaleVioletRed;
            btnBack.BorderRadius = 20;
            btnBack.BorderSize = 0;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Black;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(210, 40);
            btnBack.TabIndex = 0;
            btnBack.Text = "Select KoHa Voucher";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.TextColor = Color.Black;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pnlVoucherList
            // 
            pnlVoucherList.AutoScroll = true;
            pnlVoucherList.BorderStyle = BorderStyle.FixedSingle;
            pnlVoucherList.Location = new Point(18, 65);
            pnlVoucherList.Name = "pnlVoucherList";
            pnlVoucherList.Size = new Size(940, 417);
            pnlVoucherList.TabIndex = 6;
            pnlVoucherList.Paint += pnlVoucherList_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(101, 183, 65);
            panel1.Controls.Add(btnSelect);
            panel1.Dock = DockStyle.Bottom;
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 584);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 77);
            panel1.TabIndex = 8;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.FromArgb(101, 183, 65);
            btnSelect.BackgroundColor = Color.FromArgb(101, 183, 65);
            btnSelect.BorderColor = Color.White;
            btnSelect.BorderRadius = 20;
            btnSelect.BorderSize = 1;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(367, 14);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(261, 53);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select";
            btnSelect.TextColor = Color.White;
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(cbxVoucherSelect);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(20, 488);
            panel4.Name = "panel4";
            panel4.Size = new Size(938, 77);
            panel4.TabIndex = 9;
            // 
            // cbxVoucherSelect
            // 
            cbxVoucherSelect.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxVoucherSelect.FormattingEnabled = true;
            cbxVoucherSelect.Location = new Point(330, 22);
            cbxVoucherSelect.Name = "cbxVoucherSelect";
            cbxVoucherSelect.Size = new Size(311, 29);
            cbxVoucherSelect.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 25);
            label2.Name = "label2";
            label2.Size = new Size(286, 21);
            label2.TabIndex = 0;
            label2.Text = "Enter voucher code you want to apply";
            // 
            // FVoucher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 661);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pnlVoucherList);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FVoucher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FVoucher";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private RJControls.RButton btnBack;
        private FlowLayoutPanel pnlVoucherList;
        private Label label1;
        private Panel panel1;
        public RJControls.RButton btnSelect;
        private Panel panel4;
        private Label label2;
        private ComboBox cbxVoucherSelect;
    }
}