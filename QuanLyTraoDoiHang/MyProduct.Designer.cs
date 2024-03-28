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
            ucCartProduct1 = new UCCartProduct();
            SuspendLayout();
            // 
            // ucCartProduct1
            // 
            ucCartProduct1.BackColor = Color.FromArgb(164, 206, 149);
            ucCartProduct1.Location = new Point(1, 1);
            ucCartProduct1.Margin = new Padding(1);
            ucCartProduct1.Name = "ucCartProduct1";
            ucCartProduct1.Size = new Size(755, 393);
            ucCartProduct1.TabIndex = 6;
            // 
            // MyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 206, 149);
            ClientSize = new Size(756, 467);
            Controls.Add(ucCartProduct1);
            Margin = new Padding(1);
            Name = "MyProduct";
            Text = "MyProduct";
            ResumeLayout(false);
        }

        #endregion
        private UCCartProduct ucCartProduct1;
    }
}