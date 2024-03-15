namespace QuanLyTraoDoiHang
{
    partial class FSellermanagement
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
            panel1 = new Panel();
            rBAnalysis = new RJControls.RButton();
            ucProduct = new UCDropDownMenu();
            rButton1 = new RJControls.RButton();
            ucOrder = new UCDropDownMenu();
            panel2 = new Panel();
            pnlSellerTool = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(164, 206, 149);
            panel1.Controls.Add(rBAnalysis);
            panel1.Controls.Add(ucProduct);
            panel1.Controls.Add(rButton1);
            panel1.Controls.Add(ucOrder);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 1339);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // rBAnalysis
            // 
            rBAnalysis.BackColor = Color.FromArgb(244, 237, 204);
            rBAnalysis.BackgroundColor = Color.FromArgb(244, 237, 204);
            rBAnalysis.BorderColor = Color.PaleVioletRed;
            rBAnalysis.BorderRadius = 0;
            rBAnalysis.BorderSize = 0;
            rBAnalysis.FlatAppearance.BorderSize = 0;
            rBAnalysis.FlatStyle = FlatStyle.Flat;
            rBAnalysis.ForeColor = Color.SaddleBrown;
            rBAnalysis.Location = new Point(3, 884);
            rBAnalysis.Name = "rBAnalysis";
            rBAnalysis.Size = new Size(479, 100);
            rBAnalysis.TabIndex = 5;
            rBAnalysis.Text = "Data Analysis";
            rBAnalysis.TextColor = Color.SaddleBrown;
            rBAnalysis.UseVisualStyleBackColor = false;
            // 
            // ucProduct
            // 
            ucProduct.Location = new Point(-10, 629);
            ucProduct.Name = "ucProduct";
            ucProduct.Size = new Size(504, 259);
            ucProduct.TabIndex = 4;
            // 
            // rButton1
            // 
            rButton1.BackColor = Color.FromArgb(244, 237, 204);
            rButton1.BackgroundColor = Color.FromArgb(244, 237, 204);
            rButton1.BorderColor = Color.PaleVioletRed;
            rButton1.BorderRadius = 0;
            rButton1.BorderSize = 0;
            rButton1.FlatAppearance.BorderSize = 0;
            rButton1.FlatStyle = FlatStyle.Flat;
            rButton1.ForeColor = Color.SaddleBrown;
            rButton1.Location = new Point(-2, 157);
            rButton1.Name = "rButton1";
            rButton1.Size = new Size(479, 100);
            rButton1.TabIndex = 3;
            rButton1.Text = "My Shipment";
            rButton1.TextColor = Color.SaddleBrown;
            rButton1.UseVisualStyleBackColor = false;
            rButton1.Click += rButton1_Click;
            // 
            // ucOrder
            // 
            ucOrder.Location = new Point(-10, 372);
            ucOrder.Name = "ucOrder";
            ucOrder.Size = new Size(488, 261);
            ucOrder.TabIndex = 2;
            ucOrder.Load += ucDropDownMenu1_Load;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(482, 1335);
            panel2.TabIndex = 1;
            // 
            // pnlSellerTool
            // 
            pnlSellerTool.Location = new Point(478, 0);
            pnlSellerTool.Name = "pnlSellerTool";
            pnlSellerTool.Size = new Size(1707, 1335);
            pnlSellerTool.TabIndex = 2;
            pnlSellerTool.Paint += pnlSellerTool_Paint;
            // 
            // FSellermanagement
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2188, 1335);
            Controls.Add(pnlSellerTool);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FSellermanagement";
            Text = "FSellermanagement";
            Load += FSellermanagement_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private UCDropDownMenu ucOrder;
        private RJControls.RButton rButton1;
        private RJControls.RButton rBAnalysis;
        private UCDropDownMenu ucProduct;
        private Panel panel2;
        private Panel pnlSellerTool;
    }
}