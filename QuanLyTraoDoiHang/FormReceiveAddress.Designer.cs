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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceiveAddress));
            pnlAddresses = new FlowLayoutPanel();
            panel1 = new Panel();
            btnAddAddress = new RJControls.RButton();
            btnConfirm = new RJControls.RButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnDeliverAdress = new RJControls.RButton();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAddresses
            // 
            pnlAddresses.AutoScroll = true;
            pnlAddresses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlAddresses.Location = new Point(3, 58);
            pnlAddresses.Name = "pnlAddresses";
            pnlAddresses.Size = new Size(963, 503);
            pnlAddresses.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(101, 183, 65);
            panel1.Controls.Add(btnAddAddress);
            panel1.Controls.Add(btnConfirm);
            panel1.Dock = DockStyle.Bottom;
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 567);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 94);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // btnAddAddress
            // 
            btnAddAddress.BackColor = Color.FromArgb(101, 183, 65);
            btnAddAddress.BackgroundColor = Color.FromArgb(101, 183, 65);
            btnAddAddress.BorderColor = SystemColors.ActiveCaptionText;
            btnAddAddress.BorderRadius = 20;
            btnAddAddress.BorderSize = 1;
            btnAddAddress.FlatAppearance.BorderSize = 0;
            btnAddAddress.FlatStyle = FlatStyle.Flat;
            btnAddAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddAddress.ForeColor = SystemColors.ActiveCaptionText;
            btnAddAddress.ImageAlign = ContentAlignment.TopCenter;
            btnAddAddress.Location = new Point(234, 20);
            btnAddAddress.Name = "btnAddAddress";
            btnAddAddress.Size = new Size(261, 53);
            btnAddAddress.TabIndex = 2;
            btnAddAddress.Text = "Add address";
            btnAddAddress.TextColor = SystemColors.ActiveCaptionText;
            btnAddAddress.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(101, 183, 65);
            btnConfirm.BackgroundColor = Color.FromArgb(101, 183, 65);
            btnConfirm.BorderColor = Color.White;
            btnConfirm.BorderRadius = 20;
            btnConfirm.BorderSize = 1;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(522, 20);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(261, 53);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Confirm";
            btnConfirm.TextColor = Color.White;
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(pnlAddresses);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(982, 661);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnDeliverAdress);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(963, 49);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Green;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(963, 2);
            panel3.TabIndex = 1;
            // 
            // btnDeliverAdress
            // 
            btnDeliverAdress.BackColor = SystemColors.ControlLightLight;
            btnDeliverAdress.BackgroundColor = SystemColors.ControlLightLight;
            btnDeliverAdress.BorderColor = Color.PaleVioletRed;
            btnDeliverAdress.BorderRadius = 20;
            btnDeliverAdress.BorderSize = 0;
            btnDeliverAdress.FlatAppearance.BorderSize = 0;
            btnDeliverAdress.FlatStyle = FlatStyle.Flat;
            btnDeliverAdress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeliverAdress.ForeColor = Color.Black;
            btnDeliverAdress.Image = (Image)resources.GetObject("btnDeliverAdress.Image");
            btnDeliverAdress.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeliverAdress.Location = new Point(3, 3);
            btnDeliverAdress.Name = "btnDeliverAdress";
            btnDeliverAdress.Size = new Size(171, 40);
            btnDeliverAdress.TabIndex = 0;
            btnDeliverAdress.Text = "Delivery Address";
            btnDeliverAdress.TextAlign = ContentAlignment.MiddleRight;
            btnDeliverAdress.TextColor = Color.Black;
            btnDeliverAdress.UseVisualStyleBackColor = false;
            btnDeliverAdress.Click += btnDeliverAdress_Click;
            // 
            // FormReceiveAddress
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(982, 661);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReceiveAddress";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReceiveAddress";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnlAddresses;
        private Panel panel1;
        private RJControls.RButton btnAddAddress;
        public RJControls.RButton btnConfirm;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private RJControls.RButton btnDeliverAdress;
    }
}