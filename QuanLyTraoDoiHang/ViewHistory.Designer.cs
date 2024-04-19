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
            pictureBox1 = new PictureBox();
            pnlItems = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlItems.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(btnShip);
            flowLayoutPanel1.Controls.Add(btnCompleted);
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Controls.Add(btnReturn);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(747, 50);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnShip
            // 
            btnShip.BackColor = Color.White;
            btnShip.BackgroundColor = Color.White;
            btnShip.BorderColor = Color.White;
            btnShip.BorderRadius = 5;
            btnShip.BorderSize = 1;
            btnShip.FlatAppearance.BorderSize = 0;
            btnShip.FlatStyle = FlatStyle.Flat;
            btnShip.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnShip.ForeColor = Color.Black;
            btnShip.ImageAlign = ContentAlignment.MiddleRight;
            btnShip.Location = new Point(0, 3);
            btnShip.Margin = new Padding(0, 3, 0, 0);
            btnShip.Name = "btnShip";
            btnShip.Size = new Size(187, 45);
            btnShip.TabIndex = 0;
            btnShip.Text = "To Ship";
            btnShip.TextColor = Color.Black;
            btnShip.UseVisualStyleBackColor = false;
            // 
            // btnCompleted
            // 
            btnCompleted.BackColor = Color.White;
            btnCompleted.BackgroundColor = Color.White;
            btnCompleted.BorderColor = Color.White;
            btnCompleted.BorderRadius = 5;
            btnCompleted.BorderSize = 1;
            btnCompleted.FlatAppearance.BorderSize = 0;
            btnCompleted.FlatStyle = FlatStyle.Flat;
            btnCompleted.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompleted.ForeColor = Color.Black;
            btnCompleted.ImageAlign = ContentAlignment.MiddleRight;
            btnCompleted.Location = new Point(187, 3);
            btnCompleted.Margin = new Padding(0, 3, 0, 0);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(187, 45);
            btnCompleted.TabIndex = 1;
            btnCompleted.Text = "Completed";
            btnCompleted.TextColor = Color.Black;
            btnCompleted.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.BackgroundColor = Color.White;
            btnCancel.BorderColor = Color.White;
            btnCancel.BorderRadius = 5;
            btnCancel.BorderSize = 1;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Black;
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.Location = new Point(374, 3);
            btnCancel.Margin = new Padding(0, 3, 0, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(187, 45);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancelled";
            btnCancel.TextColor = Color.Black;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.White;
            btnReturn.BackgroundColor = Color.White;
            btnReturn.BorderColor = Color.White;
            btnReturn.BorderRadius = 5;
            btnReturn.BorderSize = 1;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.ForeColor = Color.Black;
            btnReturn.ImageAlign = ContentAlignment.MiddleRight;
            btnReturn.Location = new Point(561, 3);
            btnReturn.Margin = new Padding(0, 3, 0, 0);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(183, 45);
            btnReturn.TabIndex = 3;
            btnReturn.Text = "Returned";
            btnReturn.TextColor = Color.Black;
            btnReturn.UseVisualStyleBackColor = false;
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
            // pnlItems
            // 
            pnlItems.AutoScroll = true;
            pnlItems.BackColor = SystemColors.ControlLight;
            pnlItems.Controls.Add(pictureBox1);
            pnlItems.Location = new Point(0, 56);
            pnlItems.Name = "pnlItems";
            pnlItems.Size = new Size(747, 446);
            pnlItems.TabIndex = 3;
            // 
            // ViewHistory
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(747, 502);
            Controls.Add(pnlItems);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewHistory";
            Text = "ViewHistory";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlItems.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private RJControls.RButton btnShip;
        private RJControls.RButton btnCompleted;
        private RJControls.RButton btnCancel;
        private RJControls.RButton btnReturn;
        private PictureBox pictureBox1;
        private FlowLayoutPanel pnlItems;
    }
}