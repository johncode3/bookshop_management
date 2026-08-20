namespace BookShopWinFrm.BusinessLayer
{
    partial class FrmItemAddEdit
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            txtRating = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtAuthorName = new TextBox();
            txtItemName = new TextBox();
            label2 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            pnlFooter = new Panel();
            label3 = new Label();
            pnlMain = new Panel();
            cmbCategory = new ComboBox();
            imgItem = new PictureBox();
            btnUpload = new Button();
            label7 = new Label();
            txtItemDescription = new TextBox();
            label8 = new Label();
            txtSalePrice = new TextBox();
            label6 = new Label();
            txtQuantity = new TextBox();
            label1 = new Label();
            openFileUpload = new OpenFileDialog();
            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgItem).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.LightSkyBlue;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(522, 80);
            pnlHeader.TabIndex = 7;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Kh Pen Wappathor", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(169, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(191, 62);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "New Item";
            // 
            // txtRating
            // 
            txtRating.Location = new Point(287, 253);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(125, 27);
            txtRating.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(287, 208);
            label5.Name = "label5";
            label5.Size = new Size(97, 42);
            label5.TabIndex = 12;
            label5.Text = "Rating";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 208);
            label4.Name = "label4";
            label4.Size = new Size(129, 42);
            label4.TabIndex = 10;
            label4.Text = "Category";
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(287, 158);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(190, 27);
            txtAuthorName.TabIndex = 9;
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(42, 158);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(191, 27);
            txtItemName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 113);
            label2.Name = "label2";
            label2.Size = new Size(147, 42);
            label2.TabIndex = 6;
            label2.Text = "Item Name";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(220, 53, 69);
            btnCancel.FlatAppearance.BorderColor = Color.Black;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Kh Pen Wappathor", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(285, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(138, 38);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancle";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(40, 167, 69);
            btnSave.FlatAppearance.BorderColor = Color.Black;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Kh Pen Wappathor", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(98, 13);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 38);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = SystemColors.ActiveCaption;
            pnlFooter.BorderStyle = BorderStyle.Fixed3D;
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 686);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(522, 65);
            pnlFooter.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(287, 113);
            label3.Name = "label3";
            label3.Size = new Size(177, 42);
            label3.TabIndex = 8;
            label3.Text = "Author Name";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.ControlLight;
            pnlMain.Controls.Add(cmbCategory);
            pnlMain.Controls.Add(imgItem);
            pnlMain.Controls.Add(btnUpload);
            pnlMain.Controls.Add(label7);
            pnlMain.Controls.Add(txtItemDescription);
            pnlMain.Controls.Add(label8);
            pnlMain.Controls.Add(txtSalePrice);
            pnlMain.Controls.Add(label6);
            pnlMain.Controls.Add(txtQuantity);
            pnlMain.Controls.Add(label1);
            pnlMain.Controls.Add(txtRating);
            pnlMain.Controls.Add(label5);
            pnlMain.Controls.Add(label4);
            pnlMain.Controls.Add(txtAuthorName);
            pnlMain.Controls.Add(label3);
            pnlMain.Controls.Add(txtItemName);
            pnlMain.Controls.Add(label2);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(522, 751);
            pnlMain.TabIndex = 6;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(41, 253);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(192, 28);
            cmbCategory.TabIndex = 11;
            // 
            // imgItem
            // 
            imgItem.Location = new Point(287, 397);
            imgItem.Name = "imgItem";
            imgItem.Size = new Size(132, 149);
            imgItem.SizeMode = PictureBoxSizeMode.Zoom;
            imgItem.TabIndex = 35;
            imgItem.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.MediumBlue;
            btnUpload.FlatAppearance.BorderColor = Color.Black;
            btnUpload.FlatAppearance.BorderSize = 0;
            btnUpload.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Kh Pen Wappathor", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(44, 454);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(80, 35);
            btnUpload.TabIndex = 3;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(43, 409);
            label7.Name = "label7";
            label7.Size = new Size(152, 42);
            label7.TabIndex = 34;
            label7.Text = "Item Image";
            // 
            // txtItemDescription
            // 
            txtItemDescription.Location = new Point(44, 566);
            txtItemDescription.Multiline = true;
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(433, 89);
            txtItemDescription.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(44, 523);
            label8.Name = "label8";
            label8.Size = new Size(158, 42);
            label8.TabIndex = 32;
            label8.Text = "Description";
            // 
            // txtSalePrice
            // 
            txtSalePrice.Location = new Point(287, 352);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(125, 27);
            txtSalePrice.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(287, 307);
            label6.Name = "label6";
            label6.Size = new Size(142, 42);
            label6.TabIndex = 20;
            label6.Text = "Sale Price";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(44, 352);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 307);
            label1.Name = "label1";
            label1.Size = new Size(120, 42);
            label1.TabIndex = 18;
            label1.Text = "Quantity";
            // 
            // openFileUpload
            // 
            openFileUpload.FileName = "openFileDialog1";
            // 
            // FrmItemAddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 751);
            Controls.Add(pnlHeader);
            Controls.Add(pnlFooter);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmItemAddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmItemAddEdit";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private TextBox txtRating;
        private Label label5;
        private Label label4;
        private TextBox txtAuthorName;
        private TextBox txtItemName;
        private Label label2;
        private Button btnCancel;
        private Button btnSave;
        private Panel pnlFooter;
        private Label label3;
        private Panel pnlMain;
        private TextBox txtSalePrice;
        private Label label6;
        private TextBox txtQuantity;
        private Label label1;
        private Label label7;
        private TextBox txtItemDescription;
        private Label label8;
        private Button btnUpload;
        private OpenFileDialog openFileUpload;
        private PictureBox imgItem;
        private ComboBox cmbCategory;
    }
}