namespace QuanLyTraoDoiHang
{
    partial class UCDropDownMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDropDownMenu));
            fPanelDropDown = new FlowLayoutPanel();
            rBSelect = new RJControls.RButton();
            pnlOptions = new Panel();
            rButton1 = new RJControls.RButton();
            rButton2 = new RJControls.RButton();
            rButton3 = new RJControls.RButton();
            timer1 = new System.Windows.Forms.Timer(components);
            fPanelDropDown.SuspendLayout();
            pnlOptions.SuspendLayout();
            SuspendLayout();
            // 
            // fPanelDropDown
            // 
            fPanelDropDown.BackColor = Color.FromArgb(164, 206, 149);
            fPanelDropDown.Controls.Add(rBSelect);
            fPanelDropDown.Controls.Add(pnlOptions);
            fPanelDropDown.Location = new Point(3, 0);
            fPanelDropDown.MaximumSize = new Size(485, 230);
            fPanelDropDown.MinimumSize = new Size(485, 230);
            fPanelDropDown.Name = "fPanelDropDown";
            fPanelDropDown.Size = new Size(485, 230);
            fPanelDropDown.TabIndex = 0;
            // 
            // rBSelect
            // 
            rBSelect.BackColor = Color.FromArgb(244, 237, 204);
            rBSelect.BackgroundColor = Color.FromArgb(244, 237, 204);
            rBSelect.BorderColor = Color.PaleVioletRed;
            rBSelect.BorderRadius = 0;
            rBSelect.BorderSize = 0;
            rBSelect.FlatAppearance.BorderSize = 0;
            rBSelect.FlatStyle = FlatStyle.Flat;
            rBSelect.ForeColor = Color.SaddleBrown;
            rBSelect.Image = (Image)resources.GetObject("rBSelect.Image");
            rBSelect.ImageAlign = ContentAlignment.MiddleRight;
            rBSelect.Location = new Point(3, 3);
            rBSelect.Name = "rBSelect";
            rBSelect.Size = new Size(480, 102);
            rBSelect.TabIndex = 1;
            rBSelect.Text = "Select";
            rBSelect.TextColor = Color.SaddleBrown;
            rBSelect.UseVisualStyleBackColor = false;
            rBSelect.Click += rButton1_Click;
            // 
            // pnlOptions
            // 
            pnlOptions.AutoScroll = true;
            pnlOptions.AutoScrollMargin = new Size(0, 180);
            pnlOptions.BackColor = Color.FromArgb(164, 206, 149);
            pnlOptions.Controls.Add(rButton1);
            pnlOptions.Controls.Add(rButton2);
            pnlOptions.Controls.Add(rButton3);
            pnlOptions.Location = new Point(3, 111);
            pnlOptions.Name = "pnlOptions";
            pnlOptions.Size = new Size(480, 337);
            pnlOptions.TabIndex = 1;
            // 
            // rButton1
            // 
            rButton1.BackColor = Color.FromArgb(244, 237, 230);
            rButton1.BackgroundColor = Color.FromArgb(244, 237, 230);
            rButton1.BorderColor = Color.PaleVioletRed;
            rButton1.BorderRadius = 0;
            rButton1.BorderSize = 0;
            rButton1.FlatAppearance.BorderSize = 0;
            rButton1.FlatStyle = FlatStyle.Flat;
            rButton1.ForeColor = Color.SaddleBrown;
            rButton1.ImageAlign = ContentAlignment.MiddleRight;
            rButton1.Location = new Point(2, 13);
            rButton1.Name = "rButton1";
            rButton1.Size = new Size(480, 102);
            rButton1.TabIndex = 2;
            rButton1.Text = "Select";
            rButton1.TextColor = Color.SaddleBrown;
            rButton1.UseVisualStyleBackColor = false;
            // 
            // rButton2
            // 
            rButton2.BackColor = Color.FromArgb(244, 237, 230);
            rButton2.BackgroundColor = Color.FromArgb(244, 237, 230);
            rButton2.BorderColor = Color.PaleVioletRed;
            rButton2.BorderRadius = 0;
            rButton2.BorderSize = 0;
            rButton2.FlatAppearance.BorderSize = 0;
            rButton2.FlatStyle = FlatStyle.Flat;
            rButton2.ForeColor = Color.SaddleBrown;
            rButton2.ImageAlign = ContentAlignment.MiddleRight;
            rButton2.Location = new Point(2, 228);
            rButton2.Name = "rButton2";
            rButton2.Size = new Size(480, 102);
            rButton2.TabIndex = 3;
            rButton2.Text = "Select";
            rButton2.TextColor = Color.SaddleBrown;
            rButton2.UseVisualStyleBackColor = false;
            // 
            // rButton3
            // 
            rButton3.BackColor = Color.FromArgb(244, 237, 230);
            rButton3.BackgroundColor = Color.FromArgb(244, 237, 230);
            rButton3.BorderColor = Color.PaleVioletRed;
            rButton3.BorderRadius = 0;
            rButton3.BorderSize = 0;
            rButton3.FlatAppearance.BorderSize = 0;
            rButton3.FlatStyle = FlatStyle.Flat;
            rButton3.ForeColor = Color.SaddleBrown;
            rButton3.ImageAlign = ContentAlignment.MiddleRight;
            rButton3.Location = new Point(2, 121);
            rButton3.Name = "rButton3";
            rButton3.Size = new Size(480, 102);
            rButton3.TabIndex = 4;
            rButton3.Text = "Select";
            rButton3.TextColor = Color.SaddleBrown;
            rButton3.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // UCDropDownMenu
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(fPanelDropDown);
            Name = "UCDropDownMenu";
            Size = new Size(1235, 869);
            fPanelDropDown.ResumeLayout(false);
            pnlOptions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel fPanelDropDown;
        private System.Windows.Forms.Timer timer1;
        private RJControls.RButton rBSelect;
        private RJControls.RButton rButton2;
        private RJControls.RButton rButton3;
        private Panel pnlOptions;
        private RJControls.RButton rButton1;
    }
}
