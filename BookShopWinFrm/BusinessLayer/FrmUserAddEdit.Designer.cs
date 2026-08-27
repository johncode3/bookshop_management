namespace BookShopWinFrm.BusinessLayer
{
    partial class FrmUserAddEdit
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
            pnlMain = new Panel();
            imgProfile = new PictureBox();
            btnUpload = new Button();
            chkIsAdmin = new CheckBox();
            label7 = new Label();
            cmbEmployee = new ComboBox();
            txtConfirmPassword = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtUserName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            pnlFooter = new Panel();
            openFileUpload = new OpenFileDialog();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgProfile).BeginInit();
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
            pnlHeader.Size = new Size(515, 80);
            pnlHeader.TabIndex = 10;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Kh Pen Wappathor", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(162, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(197, 62);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "New User";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.ControlLight;
            pnlMain.Controls.Add(imgProfile);
            pnlMain.Controls.Add(btnUpload);
            pnlMain.Controls.Add(chkIsAdmin);
            pnlMain.Controls.Add(label7);
            pnlMain.Controls.Add(cmbEmployee);
            pnlMain.Controls.Add(txtConfirmPassword);
            pnlMain.Controls.Add(label5);
            pnlMain.Controls.Add(txtPassword);
            pnlMain.Controls.Add(label4);
            pnlMain.Controls.Add(txtUserName);
            pnlMain.Controls.Add(label3);
            pnlMain.Controls.Add(label2);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(515, 518);
            pnlMain.TabIndex = 9;
            // 
            // imgProfile
            // 
            imgProfile.Location = new Point(278, 316);
            imgProfile.Name = "imgProfile";
            imgProfile.Size = new Size(145, 158);
            imgProfile.SizeMode = PictureBoxSizeMode.Zoom;
            imgProfile.TabIndex = 38;
            imgProfile.TabStop = false;
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
            btnUpload.Location = new Point(25, 361);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(80, 35);
            btnUpload.TabIndex = 36;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // chkIsAdmin
            // 
            chkIsAdmin.AutoSize = true;
            chkIsAdmin.Font = new Font("Kh Pen Wappathor", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkIsAdmin.Location = new Point(25, 428);
            chkIsAdmin.Name = "chkIsAdmin";
            chkIsAdmin.Size = new Size(122, 35);
            chkIsAdmin.TabIndex = 14;
            chkIsAdmin.Text = "Is Admin ?";
            chkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 316);
            label7.Name = "label7";
            label7.Size = new Size(162, 42);
            label7.TabIndex = 37;
            label7.Text = "User Profile";
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(22, 165);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(211, 28);
            cmbEmployee.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(256, 260);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(206, 27);
            txtConfirmPassword.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(256, 215);
            label5.Name = "label5";
            label5.Size = new Size(239, 42);
            label5.TabIndex = 12;
            label5.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(24, 260);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(204, 27);
            txtPassword.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 215);
            label4.Name = "label4";
            label4.Size = new Size(136, 42);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(256, 165);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Username";
            txtUserName.Size = new Size(206, 27);
            txtUserName.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(256, 120);
            label3.Name = "label3";
            label3.Size = new Size(151, 42);
            label3.TabIndex = 8;
            label3.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 120);
            label2.Name = "label2";
            label2.Size = new Size(211, 42);
            label2.TabIndex = 6;
            label2.Text = "Employee Name";
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
            btnCancel.Location = new Point(260, 13);
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
            btnSave.Location = new Point(73, 13);
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
            pnlFooter.Location = new Point(0, 518);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(515, 65);
            pnlFooter.TabIndex = 11;
            // 
            // openFileUpload
            // 
            openFileUpload.FileName = "openFileDialog1";
            // 
            // FrmUserAddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 583);
            Controls.Add(pnlHeader);
            Controls.Add(pnlMain);
            Controls.Add(pnlFooter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUserAddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUserAddEdit";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgProfile).EndInit();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlMain;
        private TextBox txtConfirmPassword;
        private Label label5;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtUserName;
        private Label label3;
        private Label label2;
        private Button btnCancel;
        private Button btnSave;
        private Panel pnlFooter;
        private ComboBox cmbEmployee;
        private CheckBox chkIsAdmin;
        private PictureBox imgProfile;
        private Button btnUpload;
        private Label label7;
        private OpenFileDialog openFileUpload;
    }
}