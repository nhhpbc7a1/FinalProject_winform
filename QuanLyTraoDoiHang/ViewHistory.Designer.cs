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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShip = new QuanLyTraoDoiHang.RJControls.RButton();
            this.btnCompleted = new QuanLyTraoDoiHang.RJControls.RButton();
            this.btnCancel = new QuanLyTraoDoiHang.RJControls.RButton();
            this.btnReturn = new QuanLyTraoDoiHang.RJControls.RButton();
            this.pnlItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(183)))), ((int)(((byte)(65)))));
            this.flowLayoutPanel1.Controls.Add(this.btnShip);
            this.flowLayoutPanel1.Controls.Add(this.btnCompleted);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnReturn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(736, 50);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnShip
            // 
            this.btnShip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShip.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnShip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShip.BorderRadius = 5;
            this.btnShip.BorderSize = 0;
            this.btnShip.FlatAppearance.BorderSize = 0;
            this.btnShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShip.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShip.ForeColor = System.Drawing.Color.Black;
            this.btnShip.Image = ((System.Drawing.Image)(resources.GetObject("btnShip.Image")));
            this.btnShip.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShip.Location = new System.Drawing.Point(0, 10);
            this.btnShip.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(184, 40);
            this.btnShip.TabIndex = 0;
            this.btnShip.Text = "To Ship";
            this.btnShip.TextColor = System.Drawing.Color.Black;
            this.btnShip.UseVisualStyleBackColor = false;
            // 
            // btnCompleted
            // 
            this.btnCompleted.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCompleted.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnCompleted.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCompleted.BorderRadius = 5;
            this.btnCompleted.BorderSize = 0;
            this.btnCompleted.FlatAppearance.BorderSize = 0;
            this.btnCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleted.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompleted.ForeColor = System.Drawing.Color.Black;
            this.btnCompleted.Image = ((System.Drawing.Image)(resources.GetObject("btnCompleted.Image")));
            this.btnCompleted.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompleted.Location = new System.Drawing.Point(184, 10);
            this.btnCompleted.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(184, 40);
            this.btnCompleted.TabIndex = 1;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.TextColor = System.Drawing.Color.Black;
            this.btnCompleted.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(368, 10);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelled";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturn.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturn.BorderRadius = 5;
            this.btnReturn.BorderSize = 0;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.Location = new System.Drawing.Point(552, 10);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(184, 40);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Returned";
            this.btnReturn.TextColor = System.Drawing.Color.Black;
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // pnlItems
            // 
            this.pnlItems.AutoScroll = true;
            this.pnlItems.BackColor = System.Drawing.Color.LightGray;
            this.pnlItems.Controls.Add(this.pictureBox1);
            this.pnlItems.Location = new System.Drawing.Point(5, 49);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(725, 447);
            this.pnlItems.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 160);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(320, 160, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 93);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ViewHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(736, 502);
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewHistory";
            this.Text = "ViewHistory";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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