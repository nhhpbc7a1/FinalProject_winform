namespace QuanLyTraoDoiHang
{
    partial class ViewHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewHistory));
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnShip = new RJControls.RButton();
            btnCompleted = new RJControls.RButton();
            btnCancel = new RJControls.RButton();
            btnReturn = new RJControls.RButton();
            pnlItems = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            pnlItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(101, 183, 65);
            flowLayoutPanel1.Controls.Add(btnShip);
            flowLayoutPanel1.Controls.Add(btnCompleted);
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnReturn);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(736, 50);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnShip
            // 
            btnShip.BackColor = Color.WhiteSmoke;
            btnShip.BackgroundColor = Color.WhiteSmoke;
            btnShip.BorderColor = Color.FromArgb(64, 64, 64);
            btnShip.BorderRadius = 10;
            btnShip.BorderSize = 1;
            btnShip.FlatAppearance.BorderSize = 0;
            btnShip.FlatStyle = FlatStyle.Flat;
            btnShip.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnShip.ForeColor = Color.Black;
            btnShip.Image = (Image)resources.GetObject("btnShip.Image");
            btnShip.ImageAlign = ContentAlignment.MiddleRight;
            btnShip.Location = new Point(4, 3);
            btnShip.Margin = new Padding(4, 3, 34, 3);
            btnShip.Name = "btnShip";
            btnShip.Size = new Size(154, 40);
            btnShip.TabIndex = 0;
            btnShip.Text = "To Ship";
            btnShip.TextColor = Color.Black;
            btnShip.UseVisualStyleBackColor = false;
            // 
            // btnCompleted
            // 
            btnCompleted.BackColor = Color.WhiteSmoke;
            btnCompleted.BackgroundColor = Color.WhiteSmoke;
            btnCompleted.BorderColor = Color.FromArgb(64, 64, 64);
            btnCompleted.BorderRadius = 10;
            btnCompleted.BorderSize = 1;
            btnCompleted.FlatAppearance.BorderSize = 0;
            btnCompleted.FlatStyle = FlatStyle.Flat;
            btnCompleted.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompleted.ForeColor = Color.Black;
            btnCompleted.Image = (Image)resources.GetObject("btnCompleted.Image");
            btnCompleted.ImageAlign = ContentAlignment.MiddleRight;
            btnCompleted.Location = new Point(196, 3);
            btnCompleted.Margin = new Padding(4, 3, 34, 3);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(154, 40);
            btnCompleted.TabIndex = 1;
            btnCompleted.Text = "Completed";
            btnCompleted.TextColor = Color.Black;
            btnCompleted.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.BackgroundColor = Color.WhiteSmoke;
            btnCancel.BorderColor = Color.FromArgb(64, 64, 64);
            btnCancel.BorderRadius = 10;
            btnCancel.BorderSize = 1;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(388, 3);
            btnCancel.Margin = new Padding(4, 3, 34, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(154, 40);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancelled";
            btnCancel.TextColor = Color.Black;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.WhiteSmoke;
            btnReturn.BackgroundColor = Color.WhiteSmoke;
            btnReturn.BorderColor = Color.FromArgb(64, 64, 64);
            btnReturn.BorderRadius = 10;
            btnReturn.BorderSize = 1;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.ForeColor = Color.Black;
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.ImageAlign = ContentAlignment.MiddleRight;
            btnReturn.Location = new Point(576, 3);
            btnReturn.Margin = new Padding(0, 3, 3, 3);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(154, 40);
            btnReturn.TabIndex = 3;
            btnReturn.Text = "Returned";
            btnReturn.TextColor = Color.Black;
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // pnlItems
            // 
            pnlItems.AutoScroll = true;
            pnlItems.BackColor = Color.LightGray;
            pnlItems.Controls.Add(pictureBox1);
            pnlItems.Location = new Point(5, 49);
            pnlItems.Name = "pnlItems";
            pnlItems.Size = new Size(725, 447);
            pnlItems.TabIndex = 3;
            pnlItems.Paint += pnlItems_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(320, 160);
            pictureBox1.Margin = new Padding(320, 160, 3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 93);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ViewHistory
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.LightGray;
            ClientSize = new Size(736, 502);
            Controls.Add(pnlItems);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewHistory";
            Text = "ViewHistory";
            flowLayoutPanel1.ResumeLayout(false);
            pnlItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private RJControls.RButton btnShip;
        private RJControls.RButton btnCompleted;
        private RJControls.RButton btnCancel;
        private RJControls.RButton btnReturn;
        private FlowLayoutPanel pnlItems;
        private PictureBox pictureBox1;
    }
}