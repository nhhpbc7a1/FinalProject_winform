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
            btnUpdate.Location = new Point(307, 497);
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
            pnlItems.Location = new Point(9, 22);
            pnlItems.Margin = new Padding(0);
            pnlItems.Name = "pnlItems";
            pnlItems.Padding = new Padding(0, 5, 0, 0);
            pnlItems.RightToLeft = RightToLeft.No;
            pnlItems.Size = new Size(740, 459);
            pnlItems.TabIndex = 27;
            // 
            // picEmpty
            // 
            picEmpty.BackgroundImage = (Image)resources.GetObject("picEmpty.BackgroundImage");
            picEmpty.Location = new Point(330, 185);
            picEmpty.Margin = new Padding(330, 180, 3, 3);
            picEmpty.Name = "picEmpty";
            picEmpty.Size = new Size(100, 93);
            picEmpty.TabIndex = 29;
            picEmpty.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Location = new Point(9, 480);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 5);
            panel1.TabIndex = 30;
            // 
            // FormProductStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(758, 545);
            Controls.Add(pnlItems);
            Controls.Add(panel1);
            Controls.Add(btnUpdate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProductStatus";
            Text = "FormProductStatus";
            pnlItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picEmpty).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RJControls.RButton btnUpdate;
        private FlowLayoutPanel pnlItems;
        private PictureBox picEmpty;
        private Panel panel1;
    }
}