namespace QuanLyTraoDoiHang
{
    partial class FormProductStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductStatus));
            this.btnUpdate = new QuanLyTraoDoiHang.RJControls.RButton();
            this.pnlItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.picEmpty = new System.Windows.Forms.PictureBox();
            this.pnlItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(30, 106, 17);
            btnUpdate.BackgroundColor = Color.FromArgb(30, 106, 17);
            btnUpdate.BorderColor = Color.PaleVioletRed;
            btnUpdate.BorderRadius = 35;
            btnUpdate.BorderSize = 0;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(307, 438);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(168, 41);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Update";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // pnlItems
            // 
            this.pnlItems.AutoScroll = true;
            this.pnlItems.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlItems.Controls.Add(this.picEmpty);
            this.pnlItems.Location = new System.Drawing.Point(10, 45);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(725, 328);
            this.pnlItems.TabIndex = 27;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(30, 106, 17);
            pnlMenu.Location = new Point(16, 10);
            pnlMenu.Margin = new Padding(1);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(725, 32);
            pnlMenu.TabIndex = 26;
            // 
            // picEmpty
            // 
            this.picEmpty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picEmpty.BackgroundImage")));
            this.picEmpty.Location = new System.Drawing.Point(310, 120);
            this.picEmpty.Margin = new System.Windows.Forms.Padding(310, 120, 3, 3);
            this.picEmpty.Name = "picEmpty";
            this.picEmpty.Size = new System.Drawing.Size(100, 93);
            this.picEmpty.TabIndex = 29;
            this.picEmpty.TabStop = false;
            // 
            // FormProductStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 426);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FormProductStatus";
            this.Text = "FormProductStatus";
            this.pnlItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEmpty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RJControls.RButton btnUpdate;
        private FlowLayoutPanel pnlItems;
        private Panel pnlMenu;
        private PictureBox picEmpty;
    }
}