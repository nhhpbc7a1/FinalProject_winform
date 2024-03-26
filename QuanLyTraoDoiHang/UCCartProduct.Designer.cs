namespace QuanLyTraoDoiHang
{
    partial class UCCartProduct
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.pnlProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.pnlMenu.Controls.Add(this.label4);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.lblAction);
            this.pnlMenu.Controls.Add(this.lblTotalPrice);
            this.pnlMenu.Location = new System.Drawing.Point(14, 10);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(1);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(725, 31);
            this.pnlMenu.TabIndex = 22;
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
            this.label1.Location = new System.Drawing.Point(463, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Status";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAction.Location = new System.Drawing.Point(634, 4);
            this.lblAction.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(58, 21);
            this.lblAction.TabIndex = 16;
            this.lblAction.Text = "Action";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalPrice.Location = new System.Drawing.Point(269, 4);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(85, 21);
            this.lblTotalPrice.TabIndex = 15;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // pnlProducts
            // 
            this.pnlProducts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlProducts.Location = new System.Drawing.Point(14, 45);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(725, 403);
            this.pnlProducts.TabIndex = 23;
            // 
            // UCCartProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(149)))));
            this.Controls.Add(this.pnlProducts);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UCCartProduct";
            this.Size = new System.Drawing.Size(755, 469);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlMenu;
        private Label label4;
        private Label label1;
        private Label lblAction;
        private Label lblTotalPrice;
        public FlowLayoutPanel pnlProducts;
    }
}
