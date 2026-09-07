namespace BookShopWinFrm.BusinessLayer
{
    partial class FrmLogin
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
            pnlLogin = new Panel();
            btnCancel = new Button();
            btnLogin = new Button();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblTitle = new Label();
            picLogo = new PictureBox();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(btnCancel);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(lblUserName);
            pnlLogin.Controls.Add(txtUserName);
            pnlLogin.Controls.Add(lblTitle);
            pnlLogin.Controls.Add(picLogo);
            pnlLogin.Location = new Point(483, 89);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(418, 544);
            pnlLogin.TabIndex = 0;
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
            btnCancel.Location = new Point(219, 454);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(138, 38);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancle";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(40, 167, 69);
            btnLogin.FlatAppearance.BorderColor = Color.Black;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Kh Pen Wappathor", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(62, 454);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(138, 38);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Kh Pen Wappathor", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(50, 332);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(150, 45);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(50, 390);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(307, 27);
            txtPassword.TabIndex = 6;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Kh Pen Wappathor", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(50, 230);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(165, 45);
            lblUserName.TabIndex = 5;
            lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(50, 288);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(307, 27);
            txtUserName.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Kh Pen Wappathor", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(50, 138);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(307, 62);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Login to System";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(155, 31);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(105, 104);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 3;
            picLogo.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1437, 738);
            Controls.Add(pnlLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Text = "FrmLogin";
            WindowState = FormWindowState.Maximized;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Label lblTitle;
        private PictureBox picLogo;
        private TextBox txtUserName;
        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnCancel;
        private Button btnLogin;
    }
}