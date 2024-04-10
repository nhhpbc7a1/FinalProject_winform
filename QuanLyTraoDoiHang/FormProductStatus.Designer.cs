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
            btnUpdate = new RJControls.RButton();
            pnlItems = new FlowLayoutPanel();
            pnlMenu = new Panel();
            SuspendLayout();
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
            pnlItems.AutoScroll = true;
            pnlItems.BackColor = Color.White;
            pnlItems.Location = new Point(16, 45);
            pnlItems.Name = "pnlItems";
            pnlItems.Size = new Size(725, 387);
            pnlItems.TabIndex = 27;
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
            // FormProductStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(758, 498);
            Controls.Add(btnUpdate);
            Controls.Add(pnlItems);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProductStatus";
            Text = "FormProductStatus";
            ResumeLayout(false);
        }

        #endregion

        private RJControls.RButton btnUpdate;
        private FlowLayoutPanel pnlItems;
        private Panel pnlMenu;
    }
}