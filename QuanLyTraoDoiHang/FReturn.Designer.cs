namespace QuanLyTraoDoiHang
{
    partial class FReturn
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
            this.ucProductStatus1 = new QuanLyTraoDoiHang.UcProductStatus();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucProductStatus1
            // 
            this.ucProductStatus1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(149)))));
            this.ucProductStatus1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucProductStatus1.Location = new System.Drawing.Point(0, 90);
            this.ucProductStatus1.Name = "ucProductStatus1";
            this.ucProductStatus1.Size = new System.Drawing.Size(756, 444);
            this.ucProductStatus1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(183)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 76);
            this.panel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(340, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 30);
            this.label2.TabIndex = 59;
            this.label2.Text = "Returned orders";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(756, 3);
            this.panel4.TabIndex = 58;
            // 
            // FReturn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(756, 534);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ucProductStatus1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FReturn";
            this.Text = "FReturn";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private UcProductStatus ucProductStatus1;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
    }
}