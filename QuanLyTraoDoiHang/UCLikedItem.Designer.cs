namespace QuanLyTraoDoiHang
{
    partial class UCLikedItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLikedItem));
            iconYes = new PictureBox();
            iconNo = new PictureBox();
            lblLiked = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)iconYes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconNo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // iconYes
            // 
            iconYes.BackgroundImage = (Image)resources.GetObject("iconYes.BackgroundImage");
            iconYes.BackgroundImageLayout = ImageLayout.Stretch;
            iconYes.Location = new Point(3, 3);
            iconYes.Name = "iconYes";
            iconYes.Size = new Size(20, 20);
            iconYes.TabIndex = 0;
            iconYes.TabStop = false;
            // 
            // iconNo
            // 
            iconNo.BackgroundImage = (Image)resources.GetObject("iconNo.BackgroundImage");
            iconNo.BackgroundImageLayout = ImageLayout.Stretch;
            iconNo.Location = new Point(3, 3);
            iconNo.Name = "iconNo";
            iconNo.Size = new Size(20, 20);
            iconNo.TabIndex = 1;
            iconNo.TabStop = false;
            // 
            // lblLiked
            // 
            lblLiked.AutoSize = true;
            lblLiked.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLiked.Location = new Point(29, 2);
            lblLiked.Name = "lblLiked";
            lblLiked.Size = new Size(65, 21);
            lblLiked.TabIndex = 2;
            lblLiked.Text = "Favorite";
            // 
            // panel1
            // 
            panel1.Controls.Add(iconNo);
            panel1.Controls.Add(lblLiked);
            panel1.Controls.Add(iconYes);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(97, 28);
            panel1.TabIndex = 3;
            // 
            // UCLikedItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "UCLikedItem";
            Size = new Size(97, 28);
            ((System.ComponentModel.ISupportInitialize)iconYes).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconNo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox iconYes;
        private PictureBox iconNo;
        private Label lblLiked;
        private Panel panel1;
    }
}
