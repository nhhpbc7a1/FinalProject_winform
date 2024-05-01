namespace QuanLyTraoDoiHang
{
    partial class MyProduct
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
            pnlMenu = new Panel();
            label4 = new Label();
            label1 = new Label();
            label31 = new Label();
            label100 = new Label();
            pnlProducts = new FlowLayoutPanel();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(101, 183, 65);
            pnlMenu.Controls.Add(label4);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Controls.Add(label31);
            pnlMenu.Controls.Add(label100);
            pnlMenu.Location = new Point(8, 22);
            pnlMenu.Margin = new Padding(1);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(740, 31);
            pnlMenu.TabIndex = 25;
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
            label1.Location = new Point(272, 4);
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
            label31.Location = new Point(626, 4);
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
            label100.Location = new Point(480, 4);
            label100.Margin = new Padding(1, 0, 1, 0);
            label100.Name = "label100";
            label100.Size = new Size(46, 21);
            label100.TabIndex = 15;
            label100.Text = "Price";
            // 
            // pnlProducts
            // 
            pnlProducts.AutoScroll = true;
            pnlProducts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlProducts.BackColor = SystemColors.ControlLight;
            pnlProducts.Location = new Point(8, 53);
            pnlProducts.Margin = new Padding(0);
            pnlProducts.MaximumSize = new Size(740, 100000);
            pnlProducts.MinimumSize = new Size(740, 470);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Padding = new Padding(5, 0, 0, 0);
            pnlProducts.Size = new Size(740, 470);
            pnlProducts.TabIndex = 26;
            pnlProducts.Paint += pnlProducts_Paint;
            // 
            // MyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(758, 545);
            Controls.Add(pnlProducts);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1);
            MaximumSize = new Size(758, 100000);
            MinimumSize = new Size(758, 545);
            Name = "MyProduct";
            RightToLeft = RightToLeft.No;
            Text = "MyProduct";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Label label4;
        private Label label1;
        private Label label31;
        private Label label100;
        private FlowLayoutPanel pnlProducts;
    }
}