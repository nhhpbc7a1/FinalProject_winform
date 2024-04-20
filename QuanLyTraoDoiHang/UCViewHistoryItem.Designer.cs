namespace QuanLyTraoDoiHang
{
    partial class UCViewHistoryItem
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
            panel1 = new Panel();
            lblProductName = new Label();
            picItems = new PictureBox();
            lblCondition = new Label();
            lblPrice = new Label();
            lblOriginPrice = new Label();
            btnRating = new RJControls.RButton();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picItems).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(picItems);
            panel1.Location = new Point(14, 29);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 74);
            panel1.TabIndex = 51;
            // 
            // lblProductName
            // 
            lblProductName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductName.Location = new Point(70, 8);
            lblProductName.Margin = new Padding(1, 0, 1, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(160, 60);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "(name)";
            // 
            // picItems
            // 
            picItems.BackColor = SystemColors.Control;
            picItems.BackgroundImageLayout = ImageLayout.Stretch;
            picItems.Location = new Point(4, 5);
            picItems.Margin = new Padding(1);
            picItems.Name = "picItems";
            picItems.Size = new Size(64, 63);
            picItems.TabIndex = 10;
            picItems.TabStop = false;
            // 
            // lblCondition
            // 
            lblCondition.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCondition.Location = new Point(274, 29);
            lblCondition.Margin = new Padding(1, 0, 1, 0);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(186, 78);
            lblCondition.TabIndex = 56;
            lblCondition.Text = "Condition";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Red;
            lblPrice.Location = new Point(485, 63);
            lblPrice.Margin = new Padding(1, 0, 1, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(52, 21);
            lblPrice.TabIndex = 58;
            lblPrice.Text = "10000";
            // 
            // lblOriginPrice
            // 
            lblOriginPrice.AutoSize = true;
            lblOriginPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Strikeout, GraphicsUnit.Point);
            lblOriginPrice.Location = new Point(485, 36);
            lblOriginPrice.Margin = new Padding(1, 0, 1, 0);
            lblOriginPrice.Name = "lblOriginPrice";
            lblOriginPrice.Size = new Size(52, 21);
            lblOriginPrice.TabIndex = 59;
            lblOriginPrice.Text = "10000";
            // 
            // btnRating
            // 
            btnRating.BackColor = Color.Transparent;
            btnRating.BackgroundColor = Color.Transparent;
            btnRating.BorderColor = Color.LightCoral;
            btnRating.BorderRadius = 10;
            btnRating.BorderSize = 1;
            btnRating.FlatAppearance.BorderSize = 0;
            btnRating.FlatStyle = FlatStyle.Flat;
            btnRating.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRating.ForeColor = Color.LightCoral;
            btnRating.Location = new Point(578, 37);
            btnRating.Name = "btnRating";
            btnRating.Size = new Size(119, 40);
            btnRating.TabIndex = 60;
            btnRating.Text = "Rating";
            btnRating.TextColor = Color.LightCoral;
            btnRating.UseVisualStyleBackColor = false;
            btnRating.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(471, 64);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 67;
            label1.Text = "đ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(471, 37);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 68;
            label2.Text = "đ";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Location = new Point(4, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(717, 1);
            panel2.TabIndex = 69;
            // 
            // UCViewHistoryItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRating);
            Controls.Add(lblOriginPrice);
            Controls.Add(lblPrice);
            Controls.Add(lblCondition);
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "UCViewHistoryItem";
            Size = new Size(725, 128);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Panel panel1;
        public Label lblProductName;
        public PictureBox picItems;
        public Label lblCondition;
        public Label lblPrice;
        public Label lblOriginPrice;
        private RJControls.RButton btnRating;
        public Label label1;
        public Label label2;
        private Panel panel2;
    }
}
