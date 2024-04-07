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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.pnlProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(183)))), ((int)(((byte)(65)))));
            this.pnlMenu.Controls.Add(this.label4);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.label31);
            this.pnlMenu.Controls.Add(this.label100);
            this.pnlMenu.Location = new System.Drawing.Point(10, 23);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(1);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(725, 31);
            this.pnlMenu.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(33, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Your product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(244, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Condition";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label31.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label31.Location = new System.Drawing.Point(567, 4);
            this.label31.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(58, 21);
            this.label31.TabIndex = 16;
            this.label31.Text = "Action";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label100.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label100.Location = new System.Drawing.Point(412, 4);
            this.label100.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(46, 21);
            this.label100.TabIndex = 15;
            this.label100.Text = "Price";
            // 
            // pnlProducts
            // 
            this.pnlProducts.AutoSize = true;
            this.pnlProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlProducts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlProducts.Location = new System.Drawing.Point(12, 58);
            this.pnlProducts.MaximumSize = new System.Drawing.Size(723, 100000);
            this.pnlProducts.MinimumSize = new System.Drawing.Size(723, 330);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(723, 330);
            this.pnlProducts.TabIndex = 26;
            // 
            // MyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 465);
            this.Controls.Add(this.pnlProducts);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MyProduct";
            this.Text = "MyProduct";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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