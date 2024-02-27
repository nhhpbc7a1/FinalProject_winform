namespace QuanLyTraoDoiHang
{
    partial class SellerAccount
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
            this.userControlPersonalInfo1 = new QuanLyTraoDoiHang.UserControlPersonalInfo();
            this.SuspendLayout();
            // 
            // userControlPersonalInfo1
            // 
            this.userControlPersonalInfo1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userControlPersonalInfo1.Location = new System.Drawing.Point(1, 0);
            this.userControlPersonalInfo1.Name = "userControlPersonalInfo1";
            this.userControlPersonalInfo1.Size = new System.Drawing.Size(686, 546);
            this.userControlPersonalInfo1.TabIndex = 0;
            this.userControlPersonalInfo1.Load += new System.EventHandler(this.userControlPersonalInfo1_Load);
            // 
            // SellerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(688, 532);
            this.Controls.Add(this.userControlPersonalInfo1);
            this.Name = "SellerAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerAccount";
            this.Load += new System.EventHandler(this.SellerAccount_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlPersonalInfo userControlPersonalInfo1;
    }
}