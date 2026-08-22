namespace BookShopWinFrm.BusinessLayer
{
    partial class FrmPurchaseAddEdit
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
            dgPurchaseDetail = new DataGridView();
            PurchaseDetailId = new DataGridViewTextBoxColumn();
            PurchaseId = new DataGridViewTextBoxColumn();
            ItemId = new DataGridViewComboBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            txtNote = new TextBox();
            btnEmployeeAdd = new Button();
            lblNote = new Label();
            cmbEmployee = new ComboBox();
            lblEmployeeName = new Label();
            dtmPurchaseDate = new DateTimePicker();
            lblDate = new Label();
            txtRefNumber = new TextBox();
            lblRefNumber = new Label();
            label1 = new Label();
            lblTotalPrice = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            pnlFooter = new Panel();
            lblTitle = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            btnVendorAdd = new Button();
            cmbVendor = new ComboBox();
            lblCustomerName = new Label();
            pnlHeader = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgPurchaseDetail).BeginInit();
            pnlFooter.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgPurchaseDetail
            // 
            dgPurchaseDetail.AllowUserToResizeColumns = false;
            dgPurchaseDetail.AllowUserToResizeRows = false;
            dgPurchaseDetail.BackgroundColor = Color.LightGray;
            dgPurchaseDetail.BorderStyle = BorderStyle.None;
            dgPurchaseDetail.ColumnHeadersHeight = 40;
            dgPurchaseDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgPurchaseDetail.Columns.AddRange(new DataGridViewColumn[] { PurchaseDetailId, PurchaseId, ItemId, Description, Quantity, UnitPrice, TotalAmount });
            dgPurchaseDetail.Dock = DockStyle.Fill;
            dgPurchaseDetail.GridColor = Color.Black;
            dgPurchaseDetail.Location = new Point(0, 0);
            dgPurchaseDetail.MultiSelect = false;
            dgPurchaseDetail.Name = "dgPurchaseDetail";
            dgPurchaseDetail.RowHeadersVisible = false;
            dgPurchaseDetail.RowHeadersWidth = 60;
            dgPurchaseDetail.RowTemplate.Height = 30;
            dgPurchaseDetail.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgPurchaseDetail.Size = new Size(1055, 580);
            dgPurchaseDetail.TabIndex = 0;
            dgPurchaseDetail.CellPainting += dgPurchaseDetail_CellPainting;
            // 
            // PurchaseDetailId
            // 
            PurchaseDetailId.DataPropertyName = "PurchaseDetailId";
            PurchaseDetailId.HeaderText = "PurchaseDetail";
            PurchaseDetailId.MinimumWidth = 6;
            PurchaseDetailId.Name = "PurchaseDetailId";
            PurchaseDetailId.Visible = false;
            PurchaseDetailId.Width = 125;
            // 
            // PurchaseId
            // 
            PurchaseId.DataPropertyName = "PurchaseId";
            PurchaseId.HeaderText = "PurchaseId";
            PurchaseId.MinimumWidth = 6;
            PurchaseId.Name = "PurchaseId";
            PurchaseId.Visible = false;
            PurchaseId.Width = 125;
            // 
            // ItemId
            // 
            ItemId.DataPropertyName = "ItemId";
            ItemId.HeaderText = "Item Name";
            ItemId.MinimumWidth = 6;
            ItemId.Name = "ItemId";
            ItemId.Width = 200;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.SortMode = DataGridViewColumnSortMode.NotSortable;
            Quantity.Width = 125;
            // 
            // UnitPrice
            // 
            UnitPrice.DataPropertyName = "UnitPrice";
            UnitPrice.HeaderText = "Price";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.SortMode = DataGridViewColumnSortMode.NotSortable;
            UnitPrice.Width = 125;
            // 
            // TotalAmount
            // 
            TotalAmount.DataPropertyName = "TotalAmount";
            TotalAmount.HeaderText = "Amount";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Width = 125;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Completed", "On Hold", "Cancelled" });
            cmbStatus.Location = new Point(677, 63);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(173, 28);
            cmbStatus.TabIndex = 33;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(677, 18);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(95, 42);
            lblStatus.TabIndex = 32;
            lblStatus.Text = "Status";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(677, 139);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(339, 65);
            txtNote.TabIndex = 31;
            // 
            // btnEmployeeAdd
            // 
            btnEmployeeAdd.BackColor = Color.FromArgb(40, 167, 69);
            btnEmployeeAdd.FlatAppearance.BorderSize = 0;
            btnEmployeeAdd.FlatStyle = FlatStyle.Flat;
            btnEmployeeAdd.Font = new Font("Kh Pen Wappathor", 12F, FontStyle.Bold);
            btnEmployeeAdd.ForeColor = Color.White;
            btnEmployeeAdd.Location = new Point(597, 60);
            btnEmployeeAdd.Margin = new Padding(0);
            btnEmployeeAdd.Name = "btnEmployeeAdd";
            btnEmployeeAdd.Size = new Size(47, 38);
            btnEmployeeAdd.TabIndex = 30;
            btnEmployeeAdd.Text = "+";
            btnEmployeeAdd.UseVisualStyleBackColor = false;
            btnEmployeeAdd.Click += btnEmployeeAdd_Click;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNote.Location = new Point(677, 96);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(75, 42);
            lblNote.TabIndex = 27;
            lblNote.Text = "Note";
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(355, 63);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(239, 28);
            cmbEmployee.TabIndex = 26;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeName.Location = new Point(355, 18);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(211, 42);
            lblEmployeeName.TabIndex = 25;
            lblEmployeeName.Text = "Employee Name";
            // 
            // dtmPurchaseDate
            // 
            dtmPurchaseDate.Location = new Point(355, 139);
            dtmPurchaseDate.Name = "dtmPurchaseDate";
            dtmPurchaseDate.Size = new Size(262, 27);
            dtmPurchaseDate.TabIndex = 24;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(355, 94);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(75, 42);
            lblDate.TabIndex = 23;
            lblDate.Text = "Date";
            // 
            // txtRefNumber
            // 
            txtRefNumber.Location = new Point(40, 141);
            txtRefNumber.Name = "txtRefNumber";
            txtRefNumber.Size = new Size(190, 27);
            txtRefNumber.TabIndex = 22;
            // 
            // lblRefNumber
            // 
            lblRefNumber.AutoSize = true;
            lblRefNumber.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRefNumber.Location = new Point(40, 96);
            lblRefNumber.Name = "lblRefNumber";
            lblRefNumber.Size = new Size(162, 42);
            lblRefNumber.TabIndex = 21;
            lblRefNumber.Text = "Ref Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(729, 10);
            label1.Name = "label1";
            label1.Size = new Size(171, 42);
            label1.TabIndex = 23;
            label1.Text = "Total Price =";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.Location = new Point(906, 9);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(108, 42);
            lblTotalPrice.TabIndex = 22;
            lblTotalPrice.Text = "$ 00.00";
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
            btnCancel.Location = new Point(202, 13);
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
            btnSave.Location = new Point(45, 13);
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
            pnlFooter.Controls.Add(label1);
            pnlFooter.Controls.Add(lblTotalPrice);
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 816);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1055, 65);
            pnlFooter.TabIndex = 16;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Kh Pen Wappathor", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(32, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(190, 62);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "New Sale";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MistyRose;
            panel2.Controls.Add(dgPurchaseDetail);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 301);
            panel2.Name = "panel2";
            panel2.Size = new Size(1055, 580);
            panel2.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(txtNote);
            panel1.Controls.Add(btnEmployeeAdd);
            panel1.Controls.Add(btnVendorAdd);
            panel1.Controls.Add(lblNote);
            panel1.Controls.Add(cmbEmployee);
            panel1.Controls.Add(lblEmployeeName);
            panel1.Controls.Add(dtmPurchaseDate);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(txtRefNumber);
            panel1.Controls.Add(lblRefNumber);
            panel1.Controls.Add(cmbVendor);
            panel1.Controls.Add(lblCustomerName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 221);
            panel1.TabIndex = 17;
            // 
            // btnVendorAdd
            // 
            btnVendorAdd.BackColor = Color.FromArgb(40, 167, 69);
            btnVendorAdd.FlatAppearance.BorderSize = 0;
            btnVendorAdd.FlatStyle = FlatStyle.Flat;
            btnVendorAdd.Font = new Font("Kh Pen Wappathor", 12F, FontStyle.Bold);
            btnVendorAdd.ForeColor = Color.White;
            btnVendorAdd.Location = new Point(282, 60);
            btnVendorAdd.Margin = new Padding(0);
            btnVendorAdd.Name = "btnVendorAdd";
            btnVendorAdd.Size = new Size(47, 38);
            btnVendorAdd.TabIndex = 29;
            btnVendorAdd.Text = "+";
            btnVendorAdd.UseVisualStyleBackColor = false;
            btnVendorAdd.Click += btnVendorAdd_Click;
            // 
            // cmbVendor
            // 
            cmbVendor.FormattingEnabled = true;
            cmbVendor.Location = new Point(40, 65);
            cmbVendor.Name = "cmbVendor";
            cmbVendor.Size = new Size(239, 28);
            cmbVendor.TabIndex = 20;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(40, 20);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(182, 42);
            lblCustomerName.TabIndex = 19;
            lblCustomerName.Text = "Vendor Name";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.MediumSlateBlue;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1055, 80);
            pnlHeader.TabIndex = 15;
            // 
            // FrmPurchaseAddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 881);
            Controls.Add(pnlFooter);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPurchaseAddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPurchaseAddEdit";
            ((System.ComponentModel.ISupportInitialize)dgPurchaseDetail).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgPurchaseDetail;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private TextBox txtNote;
        private Button btnEmployeeAdd;
        private Label lblNote;
        private ComboBox cmbEmployee;
        private Label lblEmployeeName;
        private DateTimePicker dtmPurchaseDate;
        private Label lblDate;
        private TextBox txtRefNumber;
        private Label lblRefNumber;
        private Label label1;
        private Label lblTotalPrice;
        private Button btnCancel;
        private Button btnSave;
        private Panel pnlFooter;
        private Label lblTitle;
        private Panel panel2;
        private Panel panel1;
        private Panel pnlHeader;
        private Button btnVendorAdd;
        private ComboBox cmbVendor;
        private Label lblCustomerName;
        private DataGridViewTextBoxColumn PurchaseDetailId;
        private DataGridViewTextBoxColumn PurchaseId;
        private DataGridViewComboBoxColumn ItemId;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn TotalAmount;
    }
}