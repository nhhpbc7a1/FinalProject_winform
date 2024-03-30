namespace QuanLyTraoDoiHang
{
    partial class FormMyShipment
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
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            ucProductStatus1 = new UcProductStatus();
            rButton2 = new RJControls.RButton();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 106, 17);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = SystemColors.Window;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(756, 81);
            panel3.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato Black", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(309, 23);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 59;
            label2.Text = "My Shipment";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 78);
            panel4.Name = "panel4";
            panel4.Size = new Size(756, 3);
            panel4.TabIndex = 58;
            // 
            // ucProductStatus1
            // 
            ucProductStatus1.BackColor = Color.Gainsboro;
            ucProductStatus1.Dock = DockStyle.Bottom;
            ucProductStatus1.Location = new Point(0, 76);
            ucProductStatus1.Name = "ucProductStatus1";
            ucProductStatus1.Size = new Size(756, 458);
            ucProductStatus1.TabIndex = 22;
            // 
            // rButton2
            // 
            rButton2.BackColor = Color.FromArgb(30, 106, 17);
            rButton2.BackgroundColor = Color.FromArgb(30, 106, 17);
            rButton2.BorderColor = Color.PaleVioletRed;
            rButton2.BorderRadius = 20;
            rButton2.BorderSize = 0;
            rButton2.FlatAppearance.BorderSize = 0;
            rButton2.FlatStyle = FlatStyle.Flat;
            rButton2.Font = new Font("Segoe UI Black", 9.900001F, FontStyle.Bold, GraphicsUnit.Point);
            rButton2.ForeColor = Color.White;
            rButton2.Location = new Point(312, 476);
            rButton2.Margin = new Padding(1);
            rButton2.Name = "rButton2";
            rButton2.Size = new Size(154, 37);
            rButton2.TabIndex = 23;
            rButton2.Text = "Update";
            rButton2.TextColor = Color.White;
            rButton2.UseVisualStyleBackColor = false;
            // 
            // FormMyShipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(756, 534);
            Controls.Add(rButton2);
            Controls.Add(ucProductStatus1);
            Controls.Add(panel3);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(1);
            Name = "FormMyShipment";
            Text = "FormMyShipment";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private UcProductStatus ucProductStatus1;
        private RJControls.RButton rButton2;
    }
}