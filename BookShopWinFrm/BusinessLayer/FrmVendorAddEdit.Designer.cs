namespace BookShopWinFrm.BusinessLayer
{
    partial class FrmVendorAddEdit
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
            txtAddress = new TextBox();
            label7 = new Label();
            pnlMain = new Panel();
            txtEmail = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtCompanyName = new TextBox();
            label3 = new Label();
            txtVendorName = new TextBox();
            label2 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            pnlFooter = new Panel();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.LightSkyBlue;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(542, 80);
            pnlHeader.TabIndex = 7;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Kh Pen Wappathor", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(127, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(241, 62);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "New Vendor";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(33, 350);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(206, 27);
            txtAddress.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(33, 305);
            label7.Name = "label7";
            label7.Size = new Size(118, 42);
            label7.TabIndex = 16;
            label7.Text = "Address";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.ControlLight;
            pnlMain.Controls.Add(txtAddress);
            pnlMain.Controls.Add(label7);
            pnlMain.Controls.Add(txtEmail);
            pnlMain.Controls.Add(label5);
            pnlMain.Controls.Add(txtPhone);
            pnlMain.Controls.Add(label4);
            pnlMain.Controls.Add(txtCompanyName);
            pnlMain.Controls.Add(label3);
            pnlMain.Controls.Add(txtVendorName);
            pnlMain.Controls.Add(label2);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(542, 422);
            pnlMain.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(297, 258);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 27);
            txtEmail.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(297, 213);
            label5.Name = "label5";
            label5.Size = new Size(84, 42);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(33, 258);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(204, 27);
            txtPhone.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 213);
            label4.Name = "label4";
            label4.Size = new Size(196, 42);
            label4.TabIndex = 10;
            label4.Text = "Phone Number";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(297, 157);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(206, 27);
            txtCompanyName.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(297, 112);
            label3.Name = "label3";
            label3.Size = new Size(206, 42);
            label3.TabIndex = 8;
            label3.Text = "Company Name";
            // 
            // txtVendorName
            // 
            txtVendorName.Location = new Point(33, 157);
            txtVendorName.Name = "txtVendorName";
            txtVendorName.Size = new Size(211, 27);
            txtVendorName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 112);
            label2.Name = "label2";
            label2.Size = new Size(182, 42);
            label2.TabIndex = 6;
            label2.Text = "Vendor Name";
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
            btnCancel.Location = new Point(291, 13);
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
            btnSave.Location = new Point(104, 13);
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
            pnlFooter.Location = new Point(0, 422);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(542, 65);
            pnlFooter.TabIndex = 8;
            // 
            // FrmVendorAddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 487);
            Controls.Add(pnlHeader);
            Controls.Add(pnlMain);
            Controls.Add(pnlFooter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVendorAddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVendorAddEdit";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private TextBox txtAddress;
        private Label label7;
        private Panel pnlMain;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtCompanyName;
        private Label label3;
        private TextBox txtVendorName;
        private Label label2;
        private Button btnCancel;
        private Button btnSave;
        private Panel pnlFooter;
    }
}