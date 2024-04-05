
namespace QuanLyTraoDoiHang
{
    partial class FormCart
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
            pnlCheckOut = new Panel();
            label2 = new Label();
            btnCheckOut = new RJControls.RButton();
            lblTotalPrice = new Label();
            lblTotalItem = new Label();
            label11 = new Label();
            labelTotalItem = new Label();
            cbSellectAll = new CheckBox();
            pnlProducts = new FlowLayoutPanel();
            pnlMenu = new Panel();
            label4 = new Label();
            label1 = new Label();
            label31 = new Label();
            label100 = new Label();
            panel1 = new Panel();
            pnlCheckOut.SuspendLayout();
            pnlMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCheckOut
            // 
            pnlCheckOut.BackColor = Color.FromArgb(64, 64, 64);
            pnlCheckOut.Controls.Add(label2);
            pnlCheckOut.Controls.Add(btnCheckOut);
            pnlCheckOut.Controls.Add(lblTotalPrice);
            pnlCheckOut.Controls.Add(lblTotalItem);
            pnlCheckOut.Controls.Add(label11);
            pnlCheckOut.Controls.Add(labelTotalItem);
            pnlCheckOut.Controls.Add(cbSellectAll);
            pnlCheckOut.Dock = DockStyle.Bottom;
            pnlCheckOut.Location = new Point(0, 467);
            pnlCheckOut.Margin = new Padding(1);
            pnlCheckOut.Name = "pnlCheckOut";
            pnlCheckOut.Size = new Size(984, 94);
            pnlCheckOut.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(623, 31);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(19, 21);
            label2.TabIndex = 23;
            label2.Text = "đ";
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.FromArgb(231, 41, 41);
            btnCheckOut.BackgroundColor = Color.FromArgb(231, 41, 41);
            btnCheckOut.BorderColor = Color.White;
            btnCheckOut.BorderRadius = 20;
            btnCheckOut.BorderSize = 1;
            btnCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.Location = new Point(782, 24);
            btnCheckOut.Margin = new Padding(1);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(111, 37);
            btnCheckOut.TabIndex = 10;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.TextColor = Color.White;
            btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTotalPrice.ForeColor = SystemColors.ButtonHighlight;
            lblTotalPrice.Location = new Point(644, 31);
            lblTotalPrice.Margin = new Padding(1, 0, 1, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(23, 21);
            lblTotalPrice.TabIndex = 22;
            lblTotalPrice.Text = "0 ";
            // 
            // lblTotalItem
            // 
            lblTotalItem.AutoSize = true;
            lblTotalItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTotalItem.ForeColor = SystemColors.ButtonHighlight;
            lblTotalItem.Location = new Point(389, 31);
            lblTotalItem.Margin = new Padding(1, 0, 1, 0);
            lblTotalItem.Name = "lblTotalItem";
            lblTotalItem.Size = new Size(19, 21);
            lblTotalItem.TabIndex = 21;
            lblTotalItem.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(534, 31);
            label11.Margin = new Padding(1, 0, 1, 0);
            label11.Name = "label11";
            label11.Size = new Size(94, 21);
            label11.TabIndex = 19;
            label11.Text = "Total Price:";
            // 
            // labelTotalItem
            // 
            labelTotalItem.AutoSize = true;
            labelTotalItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalItem.ForeColor = SystemColors.Control;
            labelTotalItem.Location = new Point(277, 31);
            labelTotalItem.Margin = new Padding(1, 0, 1, 0);
            labelTotalItem.Name = "labelTotalItem";
            labelTotalItem.Size = new Size(110, 21);
            labelTotalItem.TabIndex = 18;
            labelTotalItem.Text = "Total Item(s):";
            // 
            // cbSellectAll
            // 
            cbSellectAll.AutoSize = true;
            cbSellectAll.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            cbSellectAll.ForeColor = Color.Bisque;
            cbSellectAll.Location = new Point(59, 31);
            cbSellectAll.Margin = new Padding(1);
            cbSellectAll.Name = "cbSellectAll";
            cbSellectAll.Size = new Size(92, 24);
            cbSellectAll.TabIndex = 0;
            cbSellectAll.Text = "Select All";
            cbSellectAll.UseVisualStyleBackColor = true;
            // 
            // pnlProducts
            // 
            pnlProducts.AutoSize = true;
            pnlProducts.BackColor = Color.White;
            pnlProducts.Location = new Point(123, 64);
            pnlProducts.MaximumSize = new Size(725, 10000);
            pnlProducts.MinimumSize = new Size(725, 0);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(725, 100);
            pnlProducts.TabIndex = 25;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(30, 106, 17);
            pnlMenu.Controls.Add(label4);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Controls.Add(label31);
            pnlMenu.Controls.Add(label100);
            pnlMenu.Location = new Point(123, 29);
            pnlMenu.Margin = new Padding(1);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(725, 31);
            pnlMenu.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(33, 4);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 21);
            label4.TabIndex = 19;
            label4.Text = "Your product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(463, 4);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 17;
            label1.Text = "Condition";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label31.ForeColor = SystemColors.ButtonHighlight;
            label31.Location = new Point(634, 4);
            label31.Margin = new Padding(1, 0, 1, 0);
            label31.Name = "label31";
            label31.Size = new Size(58, 21);
            label31.TabIndex = 16;
            label31.Text = "Action";
            // 
            // label100
            // 
            label100.AutoSize = true;
            label100.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label100.ForeColor = SystemColors.ButtonHighlight;
            label100.Location = new Point(269, 4);
            label100.Margin = new Padding(1, 0, 1, 0);
            label100.Name = "label100";
            label100.Size = new Size(46, 21);
            label100.TabIndex = 15;
            label100.Text = "Price";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pnlMenu);
            panel1.Controls.Add(pnlProducts);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 467);
            panel1.TabIndex = 26;
            // 
            // FormCart
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(164, 206, 149);
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Controls.Add(pnlCheckOut);
            Margin = new Padding(1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCart";
            pnlCheckOut.ResumeLayout(false);
            pnlCheckOut.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlCheckOut;
        private Label label2;
        private Label lblTotalPrice;
        private Label lblTotalItem;
        private Label label11;
        private Label labelTotalItem;
        private CheckBox cbSellectAll;
        public FlowLayoutPanel pnlProducts;
        private Panel pnlMenu;
        private Label label4;
        private Label label1;
        private Label label31;
        private Label label100;
        public RJControls.RButton btnCheckOut;
        private Panel panel1;
    }
}
