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
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(164, 206, 149);
            panel1.Controls.Add(rBAnalysis);
            panel1.Controls.Add(ucProduct);
            panel1.Controls.Add(rButton1);
            panel1.Controls.Add(ucOrder);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 661);
            panel1.TabIndex = 0;
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
            rBAnalysis.Location = new Point(0, 341);
            rBAnalysis.Margin = new Padding(1);
            rBAnalysis.Name = "rBAnalysis";
            rBAnalysis.Size = new Size(198, 37);
            rBAnalysis.TabIndex = 5;
            rBAnalysis.Text = "Data Analysis";
            rBAnalysis.TextColor = Color.SaddleBrown;
            rBAnalysis.UseVisualStyleBackColor = false;
            rBAnalysis.Click += rBAnalysis_Click_1;
            // 
            // ucProduct
            // 
            ucProduct.Location = new Point(-2, 247);
            ucProduct.Margin = new Padding(0);
            ucProduct.Name = "ucProduct";
            ucProduct.Size = new Size(201, 95);
            ucProduct.TabIndex = 4;
            ucProduct.Load += ucProduct_Load_1;
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
            rButton1.Location = new Point(-1, 57);
            rButton1.Margin = new Padding(1);
            rButton1.Name = "rButton1";
            rButton1.Size = new Size(199, 37);
            rButton1.TabIndex = 3;
            rButton1.Text = "My Shipment";
            rButton1.TextColor = Color.SaddleBrown;
            rButton1.UseVisualStyleBackColor = false;
            // 
            // ucOrder
            // 
            ucOrder.Location = new Point(-2, 149);
            ucOrder.Margin = new Padding(0);
            ucOrder.Name = "ucOrder";
            ucOrder.Size = new Size(201, 138);
            ucOrder.TabIndex = 2;
            ucOrder.Load += ucOrder_Load;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 661);
            panel2.TabIndex = 1;
            // 
            // pnlSellerTool
            // 
            pnlSellerTool.Dock = DockStyle.Fill;
            pnlSellerTool.Location = new Point(198, 0);
            pnlSellerTool.Margin = new Padding(1);
            pnlSellerTool.Name = "pnlSellerTool";
            pnlSellerTool.RightToLeft = RightToLeft.Yes;
            pnlSellerTool.Size = new Size(786, 661);
            pnlSellerTool.TabIndex = 2;
            // 
            // FSellermanagement
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(984, 661);
            Controls.Add(pnlSellerTool);
            Controls.Add(panel2);
            Margin = new Padding(1);
            Name = "FSellermanagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FSellermanagement";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
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