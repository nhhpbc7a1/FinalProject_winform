namespace QuanLyTraoDoiHang
{
    partial class FormAddRating
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddRating));
            panel1 = new Panel();
            lblProductName = new Label();
            picProductImage = new PictureBox();
            panel2 = new Panel();
            ucStars1 = new UCStars();
            label1 = new Label();
            txtDetail = new RichTextBox();
            panel3 = new Panel();
            label2 = new Label();
            btnSubmit = new RJControls.RButton();
            bindingSource1 = new BindingSource(components);
            panel4 = new Panel();
            panel5 = new Panel();
            btnDeliverAdress = new RJControls.RButton();
            panel6 = new Panel();
            panel7 = new Panel();
            label3 = new Label();
            panel8 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(picProductImage);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(40, 139);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(515, 143);
            panel1.TabIndex = 52;
            // 
            // lblProductName
            // 
            lblProductName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductName.Location = new Point(159, 14);
            lblProductName.Margin = new Padding(1, 0, 1, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(267, 49);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "(name)";
            // 
            // picProductImage
            // 
            picProductImage.BackColor = SystemColors.Control;
            picProductImage.BackgroundImageLayout = ImageLayout.Stretch;
            picProductImage.Location = new Point(0, 1);
            picProductImage.Margin = new Padding(1);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(155, 142);
            picProductImage.TabIndex = 10;
            picProductImage.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(ucStars1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(159, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 74);
            panel2.TabIndex = 57;
            // 
            // ucStars1
            // 
            ucStars1.Location = new Point(4, 33);
            ucStars1.Name = "ucStars1";
            ucStars1.Size = new Size(243, 38);
            ucStars1.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 55;
            label1.Text = "Points";
            // 
            // txtDetail
            // 
            txtDetail.BackColor = SystemColors.ControlLight;
            txtDetail.BorderStyle = BorderStyle.None;
            txtDetail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetail.ForeColor = Color.Black;
            txtDetail.Location = new Point(0, 33);
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(907, 118);
            txtDetail.TabIndex = 54;
            txtDetail.Text = "";
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtDetail);
            panel3.Location = new Point(40, 377);
            panel3.Name = "panel3";
            panel3.Size = new Size(903, 151);
            panel3.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 55;
            label2.Text = "Detail";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(101, 183, 65);
            btnSubmit.BackgroundColor = Color.FromArgb(101, 183, 65);
            btnSubmit.BorderColor = Color.White;
            btnSubmit.BorderRadius = 10;
            btnSubmit.BorderSize = 1;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(370, 20);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(302, 62);
            btnSubmit.TabIndex = 59;
            btnSubmit.Text = "Submit";
            btnSubmit.TextColor = Color.White;
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(btnDeliverAdress);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(982, 61);
            panel4.TabIndex = 60;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Green;
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 59);
            panel5.Name = "panel5";
            panel5.Size = new Size(982, 2);
            panel5.TabIndex = 1;
            // 
            // btnDeliverAdress
            // 
            btnDeliverAdress.BackColor = Color.White;
            btnDeliverAdress.BackgroundColor = Color.White;
            btnDeliverAdress.BorderColor = Color.PaleVioletRed;
            btnDeliverAdress.BorderRadius = 20;
            btnDeliverAdress.BorderSize = 0;
            btnDeliverAdress.DialogResult = DialogResult.TryAgain;
            btnDeliverAdress.FlatAppearance.BorderSize = 0;
            btnDeliverAdress.FlatStyle = FlatStyle.Flat;
            btnDeliverAdress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeliverAdress.ForeColor = Color.Black;
            btnDeliverAdress.Image = (Image)resources.GetObject("btnDeliverAdress.Image");
            btnDeliverAdress.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeliverAdress.Location = new Point(3, 12);
            btnDeliverAdress.Name = "btnDeliverAdress";
            btnDeliverAdress.Size = new Size(82, 40);
            btnDeliverAdress.TabIndex = 0;
            btnDeliverAdress.TextAlign = ContentAlignment.MiddleRight;
            btnDeliverAdress.TextColor = Color.Black;
            btnDeliverAdress.UseVisualStyleBackColor = false;
            btnDeliverAdress.Click += btnDeliverAdress_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(101, 183, 65);
            panel6.Controls.Add(btnSubmit);
            panel6.Dock = DockStyle.Bottom;
            panel6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel6.Location = new Point(0, 567);
            panel6.Name = "panel6";
            panel6.Size = new Size(982, 94);
            panel6.TabIndex = 61;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(238, 234, 234);
            panel7.Controls.Add(label3);
            panel7.Location = new Point(0, 311);
            panel7.Name = "panel7";
            panel7.Size = new Size(982, 38);
            panel7.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(27, 8);
            label3.Name = "label3";
            label3.Size = new Size(86, 17);
            label3.TabIndex = 1;
            label3.Text = "Detail Rating ";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(238, 234, 234);
            panel8.Controls.Add(label4);
            panel8.Location = new Point(0, 62);
            panel8.Name = "panel8";
            panel8.Size = new Size(982, 38);
            panel8.TabIndex = 63;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(27, 8);
            label4.Name = "label4";
            label4.Size = new Size(95, 17);
            label4.TabIndex = 1;
            label4.Text = "Rating by stars";
            // 
            // FormAddRating
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 661);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddRating";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddRating";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        public Label lblProductName;
        public PictureBox picProductImage;
        private RichTextBox txtDetail;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private RJControls.RButton btnSubmit;
        private BindingSource bindingSource1;
        private UCStars ucStars1;
        private Panel panel4;
        private Panel panel5;
        private RJControls.RButton btnDeliverAdress;
        private Panel panel6;
        private Panel panel7;
        private Label label3;
        private Panel panel8;
        private Label label4;
    }
}