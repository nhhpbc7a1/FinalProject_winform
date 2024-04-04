namespace QuanLyTraoDoiHang
{
    partial class FormReceiveAddress
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
            this.pnlAddresses = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddAddress = new QuanLyTraoDoiHang.RJControls.RButton();
            this.btnConfirm = new QuanLyTraoDoiHang.RJControls.RButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddresses
            // 
            this.pnlAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddresses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlAddresses.Location = new System.Drawing.Point(0, 0);
            this.pnlAddresses.Name = "pnlAddresses";
            this.pnlAddresses.Size = new System.Drawing.Size(800, 486);
            this.pnlAddresses.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddAddress);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddAddress.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddAddress.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddAddress.BorderRadius = 20;
            this.btnAddAddress.BorderSize = 1;
            this.btnAddAddress.FlatAppearance.BorderSize = 0;
            this.btnAddAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddAddress.Location = new System.Drawing.Point(94, 31);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(150, 40);
            this.btnAddAddress.TabIndex = 2;
            this.btnAddAddress.Text = "Add address";
            this.btnAddAddress.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddAddress.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LightCoral;
            this.btnConfirm.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btnConfirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirm.BorderRadius = 20;
            this.btnConfirm.BorderSize = 0;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(564, 31);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 40);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // FormReceiveAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAddresses);
            this.Name = "FormReceiveAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReceiveAddress";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel pnlAddresses;
        private Panel panel1;
        private RJControls.RButton btnAddAddress;
        public RJControls.RButton btnConfirm;
    }
}