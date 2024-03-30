namespace QuanLyTraoDoiHang
{
    partial class UcProductStatus
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
            lblTotalPrice = new Label();
            lblAction = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            pnlMenu = new Panel();
            pnlProducts = new FlowLayoutPanel();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPrice.ForeColor = Color.White;
            lblTotalPrice.Location = new Point(194, 5);
            lblTotalPrice.Margin = new Padding(1, 0, 1, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(85, 19);
            lblTotalPrice.TabIndex = 15;
            lblTotalPrice.Text = "Total Price";
            // 
            // lblAction
            // 
            lblAction.AutoSize = true;
            lblAction.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lblAction.ForeColor = Color.White;
            lblAction.Location = new Point(639, 5);
            lblAction.Margin = new Padding(1, 0, 1, 0);
            lblAction.Name = "lblAction";
            lblAction.Size = new Size(56, 19);
            lblAction.TabIndex = 16;
            lblAction.Text = "Action";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(359, 5);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 17;
            label1.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(528, 5);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 18;
            label2.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(14, 5);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 19);
            label4.TabIndex = 20;
            label4.Text = "Your product";
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(101, 183, 65);
            pnlMenu.Controls.Add(label4);
            pnlMenu.Controls.Add(label2);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Controls.Add(lblAction);
            pnlMenu.Controls.Add(lblTotalPrice);
            pnlMenu.Location = new Point(14, 10);
            pnlMenu.Margin = new Padding(1);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(725, 31);
            pnlMenu.TabIndex = 19;
            // 
            // pnlProducts
            // 
            pnlProducts.BackColor = SystemColors.ButtonHighlight;
            pnlProducts.Location = new Point(14, 45);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(725, 336);
            pnlProducts.TabIndex = 20;
            // 
            // UcProductStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(pnlProducts);
            Controls.Add(pnlMenu);
            Name = "UcProductStatus";
            Size = new Size(755, 393);
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTotalPrice;
        private Label lblAction;
        private Label label1;
        private Label label2;
        private Label label4;
        private Panel pnlMenu;
        private FlowLayoutPanel pnlProducts;
    }
}
