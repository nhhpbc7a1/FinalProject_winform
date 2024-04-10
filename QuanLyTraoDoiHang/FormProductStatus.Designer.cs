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
            btnUpdate = new RJControls.RButton();
            pnlItems = new FlowLayoutPanel();
            picEmpty = new PictureBox();
            panel1 = new Panel();
            pnlItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEmpty).BeginInit();
            panel1.SuspendLayout();
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
            btnUpdate.Location = new Point(294, 13);
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
            pnlItems.BackColor = SystemColors.ControlLight;
            pnlItems.Controls.Add(picEmpty);
            pnlItems.Location = new Point(9, 0);
            pnlItems.Margin = new Padding(0);
            pnlItems.Name = "pnlItems";
            pnlItems.Size = new Size(740, 418);
            pnlItems.TabIndex = 27;
            // 
            // picEmpty
            // 
            picEmpty.BackgroundImage = (Image)resources.GetObject("picEmpty.BackgroundImage");
            picEmpty.Location = new Point(310, 120);
            picEmpty.Margin = new Padding(310, 120, 3, 3);
            picEmpty.Name = "picEmpty";
            picEmpty.Size = new Size(100, 93);
            picEmpty.TabIndex = 29;
            picEmpty.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnUpdate);
            panel1.Location = new Point(9, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 68);
            panel1.TabIndex = 29;
            // 
            // FormProductStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(758, 496);
            Controls.Add(panel1);
            Controls.Add(pnlItems);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProductStatus";
            Text = "FormProductStatus";
            pnlItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picEmpty).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RJControls.RButton btnUpdate;
        private FlowLayoutPanel pnlItems;
        private PictureBox picEmpty;
        private Panel panel1;
    }
}