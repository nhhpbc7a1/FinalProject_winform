namespace QuanLyTraoDoiHang
{
    partial class FormAddNewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddNewProduct));
            picboxProduct = new PictureBox();
            txtOriginalPrice = new TextBox();
            label1 = new Label();
            btnSave = new RJControls.RButton();
            label2 = new Label();
            txtCondition = new TextBox();
            label3 = new Label();
            txtWarranty = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtOrigin = new TextBox();
            label6 = new Label();
            txtName = new TextBox();
            label7 = new Label();
            txtPrice = new TextBox();
            richTextBoxDescription = new RichTextBox();
            dtpBought = new DateTimePicker();
            panel1 = new Panel();
            txtCategory = new TextBox();
            label10 = new Label();
            txtBrand = new TextBox();
            label9 = new Label();
            rBChangeImage = new RJControls.RButton();
            ((System.ComponentModel.ISupportInitialize)picboxProduct).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // picboxProduct
            // 
            picboxProduct.BackColor = Color.WhiteSmoke;
            picboxProduct.BackgroundImage = (Image)resources.GetObject("picboxProduct.BackgroundImage");
            picboxProduct.BackgroundImageLayout = ImageLayout.Center;
            picboxProduct.Location = new Point(548, 289);
            picboxProduct.Name = "picboxProduct";
            picboxProduct.Size = new Size(356, 205);
            picboxProduct.TabIndex = 0;
            picboxProduct.TabStop = false;
            picboxProduct.Click += picboxProduct_Click;
            // 
            // txtOriginalPrice
            // 
            txtOriginalPrice.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtOriginalPrice.Location = new Point(206, 176);
            txtOriginalPrice.Name = "txtOriginalPrice";
            txtOriginalPrice.Size = new Size(217, 25);
            txtOriginalPrice.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 176);
            label1.Name = "label1";
            label1.Size = new Size(107, 18);
            label1.TabIndex = 2;
            label1.Text = "Original Price *";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(30, 106, 17);
            btnSave.BackgroundColor = Color.FromArgb(30, 106, 17);
            btnSave.BorderColor = Color.PaleVioletRed;
            btnSave.BorderRadius = 20;
            btnSave.BorderSize = 0;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(413, 574);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(188, 50);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(79, 226);
            label2.Name = "label2";
            label2.Size = new Size(83, 18);
            label2.TabIndex = 5;
            label2.Text = "Condition *";
            // 
            // txtCondition
            // 
            txtCondition.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCondition.Location = new Point(206, 226);
            txtCondition.Name = "txtCondition";
            txtCondition.Size = new Size(217, 25);
            txtCondition.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(79, 276);
            label3.Name = "label3";
            label3.Size = new Size(123, 18);
            label3.TabIndex = 7;
            label3.Text = "Warranty Policy *";
            // 
            // txtWarranty
            // 
            txtWarranty.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtWarranty.Location = new Point(206, 276);
            txtWarranty.Name = "txtWarranty";
            txtWarranty.Size = new Size(217, 25);
            txtWarranty.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(79, 326);
            label4.Name = "label4";
            label4.Size = new Size(98, 18);
            label4.TabIndex = 9;
            label4.Text = "Day bought * ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(79, 426);
            label5.Name = "label5";
            label5.Size = new Size(59, 18);
            label5.TabIndex = 11;
            label5.Text = "Origin *";
            // 
            // txtOrigin
            // 
            txtOrigin.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrigin.Location = new Point(206, 426);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(217, 25);
            txtOrigin.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(79, 76);
            label6.Name = "label6";
            label6.Size = new Size(56, 18);
            label6.TabIndex = 13;
            label6.Text = "Name *";
            // 
            // txtName
            // 
            txtName.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(206, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(217, 25);
            txtName.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(79, 126);
            label7.Name = "label7";
            label7.Size = new Size(51, 18);
            label7.TabIndex = 15;
            label7.Text = "Price *";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(206, 126);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(217, 25);
            txtPrice.TabIndex = 14;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Font = new Font("Lato", 11.95F, FontStyle.Italic, GraphicsUnit.Point);
            richTextBoxDescription.ForeColor = SystemColors.InfoText;
            richTextBoxDescription.Location = new Point(548, 63);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(356, 220);
            richTextBoxDescription.TabIndex = 18;
            richTextBoxDescription.Text = "  Description *";
            // 
            // dtpBought
            // 
            dtpBought.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBought.Location = new Point(206, 326);
            dtpBought.Name = "dtpBought";
            dtpBought.Size = new Size(217, 25);
            dtpBought.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtCategory);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtBrand);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtOriginalPrice);
            panel1.Controls.Add(dtpBought);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtCondition);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtWarranty);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtOrigin);
            panel1.Controls.Add(label5);
            panel1.Font = new Font("Lato Semibold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(49, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 467);
            panel1.TabIndex = 21;
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategory.Location = new Point(206, 23);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(217, 25);
            txtCategory.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(79, 26);
            label10.Name = "label10";
            label10.Size = new Size(83, 18);
            label10.TabIndex = 25;
            label10.Text = "Catergory *";
            // 
            // txtBrand
            // 
            txtBrand.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBrand.Location = new Point(206, 376);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(217, 25);
            txtBrand.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lato", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(79, 376);
            label9.Name = "label9";
            label9.Size = new Size(56, 18);
            label9.TabIndex = 23;
            label9.Text = "Brand *";
            // 
            // rBChangeImage
            // 
            rBChangeImage.BackColor = Color.White;
            rBChangeImage.BackgroundColor = Color.White;
            rBChangeImage.BorderColor = Color.FromArgb(30, 106, 17);
            rBChangeImage.BorderRadius = 20;
            rBChangeImage.BorderSize = 1;
            rBChangeImage.FlatAppearance.BorderSize = 0;
            rBChangeImage.FlatStyle = FlatStyle.Flat;
            rBChangeImage.Font = new Font("Lato Heavy", 11.9999981F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            rBChangeImage.ForeColor = Color.FromArgb(30, 106, 17);
            rBChangeImage.Location = new Point(548, 501);
            rBChangeImage.Name = "rBChangeImage";
            rBChangeImage.Size = new Size(356, 29);
            rBChangeImage.TabIndex = 22;
            rBChangeImage.Text = "change image";
            rBChangeImage.TextColor = Color.FromArgb(30, 106, 17);
            rBChangeImage.UseVisualStyleBackColor = false;
            rBChangeImage.Click += rBChangeImage_Click;
            // 
            // FormAddNewProduct
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            ClientSize = new Size(984, 661);
            Controls.Add(rBChangeImage);
            Controls.Add(panel1);
            Controls.Add(richTextBoxDescription);
            Controls.Add(btnSave);
            Controls.Add(picboxProduct);
            Name = "FormAddNewProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddNewProduct";
            Load += FormAddNewProduct_Load;
            ((System.ComponentModel.ISupportInitialize)picboxProduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picboxProduct;
        private TextBox txtOriginalPrice;
        private Label label1;
        private RJControls.RButton btnSave;
        private Label label2;
        private TextBox txtCondition;
        private Label label3;
        private TextBox txtWarranty;
        private Label label4;
        private Label label5;
        private TextBox txtOrigin;
        private Label label6;
        private TextBox txtName;
        private Label label7;
        private TextBox txtPrice;
        private RichTextBox richTextBoxDescription;
        private DateTimePicker dtpBought;
        private Panel panel1;
        private TextBox txtBrand;
        private Label label9;
        private TextBox txtCategory;
        private Label label10;
        private RJControls.RButton rBChangeImage;
    }
}