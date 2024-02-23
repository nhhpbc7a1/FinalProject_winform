namespace QuanLyTraoDoiHang
{
    partial class ChangePasswordCA
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeCA = new System.Windows.Forms.Button();
            this.btnBackCA = new System.Windows.Forms.Button();
            this.btnExitCA = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 163);
            this.panel1.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(167, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 25);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(167, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 25);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Re-type new password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "New password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 25);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old pasword";
            // 
            // btnChangeCA
            // 
            this.btnChangeCA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChangeCA.Location = new System.Drawing.Point(165, 222);
            this.btnChangeCA.Name = "btnChangeCA";
            this.btnChangeCA.Size = new System.Drawing.Size(87, 34);
            this.btnChangeCA.TabIndex = 5;
            this.btnChangeCA.Text = "Change";
            this.btnChangeCA.UseVisualStyleBackColor = true;
            this.btnChangeCA.Click += new System.EventHandler(this.btnChangeCA_Click);
            // 
            // btnBackCA
            // 
            this.btnBackCA.Location = new System.Drawing.Point(34, 245);
            this.btnBackCA.Name = "btnBackCA";
            this.btnBackCA.Size = new System.Drawing.Size(75, 29);
            this.btnBackCA.TabIndex = 6;
            this.btnBackCA.Text = "Back";
            this.btnBackCA.UseVisualStyleBackColor = true;
            this.btnBackCA.Click += new System.EventHandler(this.btnBackCA_Click);
            // 
            // btnExitCA
            // 
            this.btnExitCA.Location = new System.Drawing.Point(325, 245);
            this.btnExitCA.Name = "btnExitCA";
            this.btnExitCA.Size = new System.Drawing.Size(75, 29);
            this.btnExitCA.TabIndex = 7;
            this.btnExitCA.Text = "Exit";
            this.btnExitCA.UseVisualStyleBackColor = true;
            // 
            // ChangePasswordCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 286);
            this.Controls.Add(this.btnExitCA);
            this.Controls.Add(this.btnBackCA);
            this.Controls.Add(this.btnChangeCA);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ChangePasswordCA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordCA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button btnChangeCA;
        private Button btnBackCA;
        private Button btnExitCA;
    }
}