namespace QuanLyTraoDoiHang
{
    partial class FormShowSellerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowSellerList));
            label1 = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            rButton1 = new RJControls.RButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(347, 20);
            label1.Name = "label1";
            label1.Size = new Size(311, 37);
            label1.TabIndex = 0;
            label1.Text = "Prestigious Seller's List";
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.BackColor = SystemColors.Control;
            flowLayoutPanel.Location = new Point(10, 88);
            flowLayoutPanel.Margin = new Padding(30, 0, 0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(30, 0, 0, 0);
            flowLayoutPanel.Size = new Size(960, 561);
            flowLayoutPanel.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(101, 183, 65);
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(835, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 29);
            comboBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(101, 183, 65);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(rButton1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 76);
            panel1.TabIndex = 3;
            // 
            // rButton1
            // 
            rButton1.BackColor = Color.FromArgb(101, 183, 65);
            rButton1.BackgroundColor = Color.FromArgb(101, 183, 65);
            rButton1.BorderColor = Color.PaleVioletRed;
            rButton1.BorderRadius = 40;
            rButton1.BorderSize = 0;
            rButton1.FlatAppearance.BorderSize = 0;
            rButton1.FlatStyle = FlatStyle.Flat;
            rButton1.ForeColor = Color.White;
            rButton1.Image = (Image)resources.GetObject("rButton1.Image");
            rButton1.Location = new Point(10, 17);
            rButton1.Name = "rButton1";
            rButton1.Size = new Size(50, 40);
            rButton1.TabIndex = 1;
            rButton1.TextColor = Color.White;
            rButton1.UseVisualStyleBackColor = false;
            rButton1.Click += rButton1_Click;
            // 
            // FormShowSellerList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 661);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormShowSellerList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormShowSellerList";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel;
        private ComboBox comboBox1;
        private Panel panel1;
        private RJControls.RButton rButton1;
    }
}