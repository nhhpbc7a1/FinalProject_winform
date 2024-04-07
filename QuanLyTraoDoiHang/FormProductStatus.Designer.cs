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
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.BorderRadius = 35;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(295, 379);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(168, 41);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
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
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(106)))), ((int)(((byte)(17)))));
            this.pnlMenu.Location = new System.Drawing.Point(10, 10);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(1);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(725, 32);
            this.pnlMenu.TabIndex = 26;
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