namespace BookShopWinFrm.BusinessLayer
{
    partial class FrmEmployeeAddEdit
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
            cmbMaritalStatus = new ComboBox();
            label6 = new Label();
            pnlMain = new Panel();
            txtAddress = new TextBox();
            label12 = new Label();
            cmbStatus = new ComboBox();
            label11 = new Label();
            txtSalary = new TextBox();
            label10 = new Label();
            txtNumberOfChildren = new TextBox();
            label9 = new Label();
            cmbDepartment = new ComboBox();
            label8 = new Label();
            cmbPosition = new ComboBox();
            label7 = new Label();
            dtmHiredDate = new DateTimePicker();
            label5 = new Label();
            cmbHaveSpouse = new ComboBox();
            label1 = new Label();
            dtmDOB = new DateTimePicker();
            cmbSex = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtEmployeeName = new TextBox();
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
            pnlHeader.Size = new Size(572, 80);
            pnlHeader.TabIndex = 7;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Kh Pen Wappathor", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(120, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(284, 62);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "New Employee";
            // 
            // cmbMaritalStatus
            // 
            cmbMaritalStatus.FormattingEnabled = true;
            cmbMaritalStatus.Location = new Point(342, 351);
            cmbMaritalStatus.Name = "cmbMaritalStatus";
            cmbMaritalStatus.Size = new Size(168, 28);
            cmbMaritalStatus.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(342, 306);
            label6.Name = "label6";
            label6.Size = new Size(186, 42);
            label6.TabIndex = 14;
            label6.Text = "Marital Status";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.ControlLight;
            pnlMain.Controls.Add(txtAddress);
            pnlMain.Controls.Add(label12);
            pnlMain.Controls.Add(cmbStatus);
            pnlMain.Controls.Add(label11);
            pnlMain.Controls.Add(txtSalary);
            pnlMain.Controls.Add(label10);
            pnlMain.Controls.Add(txtNumberOfChildren);
            pnlMain.Controls.Add(label9);
            pnlMain.Controls.Add(cmbDepartment);
            pnlMain.Controls.Add(label8);
            pnlMain.Controls.Add(cmbPosition);
            pnlMain.Controls.Add(label7);
            pnlMain.Controls.Add(dtmHiredDate);
            pnlMain.Controls.Add(label5);
            pnlMain.Controls.Add(cmbHaveSpouse);
            pnlMain.Controls.Add(label1);
            pnlMain.Controls.Add(dtmDOB);
            pnlMain.Controls.Add(cmbSex);
            pnlMain.Controls.Add(cmbMaritalStatus);
            pnlMain.Controls.Add(label6);
            pnlMain.Controls.Add(label4);
            pnlMain.Controls.Add(label3);
            pnlMain.Controls.Add(txtEmployeeName);
            pnlMain.Controls.Add(label2);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(572, 734);
            pnlMain.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(33, 653);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(240, 27);
            txtAddress.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(33, 608);
            label12.Name = "label12";
            label12.Size = new Size(118, 42);
            label12.TabIndex = 34;
            label12.Text = "Address";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(342, 653);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(168, 28);
            cmbStatus.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(342, 608);
            label11.Name = "label11";
            label11.Size = new Size(95, 42);
            label11.TabIndex = 32;
            label11.Text = "Status";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(33, 552);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(240, 27);
            txtSalary.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(33, 507);
            label10.Name = "label10";
            label10.Size = new Size(95, 42);
            label10.TabIndex = 30;
            label10.Text = "Salary";
            // 
            // txtNumberOfChildren
            // 
            txtNumberOfChildren.Location = new Point(33, 454);
            txtNumberOfChildren.Name = "txtNumberOfChildren";
            txtNumberOfChildren.Size = new Size(240, 27);
            txtNumberOfChildren.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(33, 409);
            label9.Name = "label9";
            label9.Size = new Size(254, 42);
            label9.TabIndex = 28;
            label9.Text = "Number of Children";
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(342, 552);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(168, 28);
            cmbDepartment.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(342, 507);
            label8.Name = "label8";
            label8.Size = new Size(161, 42);
            label8.TabIndex = 26;
            label8.Text = "Department";
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(342, 454);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(168, 28);
            cmbPosition.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(342, 409);
            label7.Name = "label7";
            label7.Size = new Size(115, 42);
            label7.TabIndex = 24;
            label7.Text = "Position";
            // 
            // dtmHiredDate
            // 
            dtmHiredDate.Location = new Point(33, 351);
            dtmHiredDate.Name = "dtmHiredDate";
            dtmHiredDate.Size = new Size(240, 27);
            dtmHiredDate.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 306);
            label5.Name = "label5";
            label5.Size = new Size(148, 42);
            label5.TabIndex = 22;
            label5.Text = "Hired Date";
            // 
            // cmbHaveSpouse
            // 
            cmbHaveSpouse.FormattingEnabled = true;
            cmbHaveSpouse.Location = new Point(342, 247);
            cmbHaveSpouse.Name = "cmbHaveSpouse";
            cmbHaveSpouse.Size = new Size(168, 28);
            cmbHaveSpouse.TabIndex = 10;
            cmbHaveSpouse.SelectedIndexChanged += cmbHaveSpouse_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(342, 203);
            label1.Name = "label1";
            label1.Size = new Size(175, 42);
            label1.TabIndex = 20;
            label1.Text = "Have Spouse";
            // 
            // dtmDOB
            // 
            dtmDOB.Location = new Point(33, 248);
            dtmDOB.Name = "dtmDOB";
            dtmDOB.Size = new Size(240, 27);
            dtmDOB.TabIndex = 9;
            // 
            // cmbSex
            // 
            cmbSex.FormattingEnabled = true;
            cmbSex.Location = new Point(342, 146);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(168, 28);
            cmbSex.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 203);
            label4.Name = "label4";
            label4.Size = new Size(173, 42);
            label4.TabIndex = 10;
            label4.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(342, 102);
            label3.Name = "label3";
            label3.Size = new Size(108, 42);
            label3.TabIndex = 8;
            label3.Text = "Gender";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(33, 147);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(240, 27);
            txtEmployeeName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 102);
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
            pnlFooter.Location = new Point(0, 734);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(572, 65);
            pnlFooter.TabIndex = 8;
            // 
            // FrmEmployeeAddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 799);
            Controls.Add(pnlHeader);
            Controls.Add(pnlMain);
            Controls.Add(pnlFooter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmployeeAddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEmployeeAddEdit";
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
        private ComboBox cmbMaritalStatus;
        private Label label6;
        private Panel pnlMain;
        private Label label4;
        private Label label3;
        private TextBox txtEmployeeName;
        private Label label2;
        private Button btnCancel;
        private Button btnSave;
        private Panel pnlFooter;
        private ComboBox cmbHaveSpouse;
        private Label label1;
        private DateTimePicker dtmDOB;
        private ComboBox cmbSex;
        private TextBox txtSalary;
        private Label label10;
        private TextBox txtNumberOfChildren;
        private Label label9;
        private ComboBox cmbDepartment;
        private Label label8;
        private ComboBox cmbPosition;
        private Label label7;
        private DateTimePicker dtmHiredDate;
        private Label label5;
        private TextBox txtAddress;
        private Label label12;
        private ComboBox cmbStatus;
        private Label label11;
    }
}