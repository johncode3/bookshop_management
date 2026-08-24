namespace BookShopWinFrm.BusinessLayer
{
    partial class FrmPOS
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
            label1 = new Label();
            pnlHeader = new Panel();
            txtSearch = new TextBox();
            label2 = new Label();
            pnlToolbar = new Panel();
            cmbCategory = new ComboBox();
            label3 = new Label();
            pnlSale = new Panel();
            panel1 = new Panel();
            dgSaleDetail = new DataGridView();
            SaleDetailId = new DataGridViewTextBoxColumn();
            SaleId = new DataGridViewTextBoxColumn();
            ItemId = new DataGridViewComboBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPriceAtSale = new DataGridViewTextBoxColumn();
            DiscountAmount = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            pnlFooter = new Panel();
            label4 = new Label();
            lblTotalPrice = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            panel3 = new Panel();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            txtNote = new TextBox();
            lblNote = new Label();
            cmbEmployee = new ComboBox();
            lblEmployeeName = new Label();
            dtmSaleDate = new DateTimePicker();
            lblDate = new Label();
            txtRefNumber = new TextBox();
            lblRefNumber = new Label();
            cmbCustomer = new ComboBox();
            lblCustomerName = new Label();
            panel4 = new Panel();
            lblTitle = new Label();
            panel2 = new Panel();
            flopnlItemList = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlSale.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSaleDetail).BeginInit();
            pnlFooter.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kh Pen Wappathor", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(302, 62);
            label1.TabIndex = 0;
            label1.Text = "Book Shop POS";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.LightSkyBlue;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1383, 80);
            pnlHeader.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(308, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(242, 27);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Pen Wappathor", 10F);
            label2.Location = new Point(354, 6);
            label2.Name = "label2";
            label2.Size = new Size(143, 31);
            label2.TabIndex = 4;
            label2.Text = "Search For Item";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = SystemColors.ActiveCaption;
            pnlToolbar.BorderStyle = BorderStyle.Fixed3D;
            pnlToolbar.Controls.Add(cmbCategory);
            pnlToolbar.Controls.Add(label3);
            pnlToolbar.Controls.Add(label2);
            pnlToolbar.Controls.Add(txtSearch);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 80);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(1383, 79);
            pnlToolbar.TabIndex = 9;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(40, 40);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(225, 28);
            cmbCategory.TabIndex = 6;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kh Pen Wappathor", 10F);
            label3.Location = new Point(108, 6);
            label3.Name = "label3";
            label3.Size = new Size(90, 31);
            label3.TabIndex = 5;
            label3.Text = "Category";
            // 
            // pnlSale
            // 
            pnlSale.BackColor = SystemColors.ActiveBorder;
            pnlSale.Controls.Add(panel1);
            pnlSale.Controls.Add(pnlFooter);
            pnlSale.Controls.Add(panel3);
            pnlSale.Controls.Add(panel4);
            pnlSale.Dock = DockStyle.Right;
            pnlSale.Location = new Point(586, 159);
            pnlSale.Name = "pnlSale";
            pnlSale.Size = new Size(797, 537);
            pnlSale.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(dgSaleDetail);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 301);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 171);
            panel1.TabIndex = 18;
            // 
            // dgSaleDetail
            // 
            dgSaleDetail.AllowUserToResizeColumns = false;
            dgSaleDetail.AllowUserToResizeRows = false;
            dgSaleDetail.BackgroundColor = Color.LightGray;
            dgSaleDetail.BorderStyle = BorderStyle.None;
            dgSaleDetail.ColumnHeadersHeight = 40;
            dgSaleDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgSaleDetail.Columns.AddRange(new DataGridViewColumn[] { SaleDetailId, SaleId, ItemId, Description, Quantity, UnitPriceAtSale, DiscountAmount, Price });
            dgSaleDetail.Dock = DockStyle.Fill;
            dgSaleDetail.GridColor = Color.Black;
            dgSaleDetail.Location = new Point(0, 0);
            dgSaleDetail.MultiSelect = false;
            dgSaleDetail.Name = "dgSaleDetail";
            dgSaleDetail.RowHeadersVisible = false;
            dgSaleDetail.RowHeadersWidth = 60;
            dgSaleDetail.RowTemplate.Height = 30;
            dgSaleDetail.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgSaleDetail.Size = new Size(797, 171);
            dgSaleDetail.TabIndex = 0;
            dgSaleDetail.CellValueChanged += dgSaleDetail_CellValueChanged;
            dgSaleDetail.CurrentCellDirtyStateChanged += dgSaleDetail_CurrentCellDirtyStateChanged;
            // 
            // SaleDetailId
            // 
            SaleDetailId.DataPropertyName = "SaleDetailId";
            SaleDetailId.HeaderText = "SaleDetailId";
            SaleDetailId.MinimumWidth = 6;
            SaleDetailId.Name = "SaleDetailId";
            SaleDetailId.Visible = false;
            SaleDetailId.Width = 125;
            // 
            // SaleId
            // 
            SaleId.DataPropertyName = "SaleId";
            SaleId.HeaderText = "SaleId";
            SaleId.MinimumWidth = 6;
            SaleId.Name = "SaleId";
            SaleId.Visible = false;
            SaleId.Width = 125;
            // 
            // ItemId
            // 
            ItemId.DataPropertyName = "ItemId";
            ItemId.HeaderText = "Item Name";
            ItemId.MinimumWidth = 6;
            ItemId.Name = "ItemId";
            ItemId.Width = 150;
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
            // UnitPriceAtSale
            // 
            UnitPriceAtSale.DataPropertyName = "UnitPriceAtSale";
            UnitPriceAtSale.HeaderText = "Unit Price";
            UnitPriceAtSale.MinimumWidth = 6;
            UnitPriceAtSale.Name = "UnitPriceAtSale";
            UnitPriceAtSale.ReadOnly = true;
            UnitPriceAtSale.SortMode = DataGridViewColumnSortMode.NotSortable;
            UnitPriceAtSale.Width = 125;
            // 
            // DiscountAmount
            // 
            DiscountAmount.DataPropertyName = "DiscountAmount";
            DiscountAmount.HeaderText = "Discount";
            DiscountAmount.MinimumWidth = 6;
            DiscountAmount.Name = "DiscountAmount";
            DiscountAmount.ReadOnly = true;
            DiscountAmount.SortMode = DataGridViewColumnSortMode.NotSortable;
            DiscountAmount.Width = 125;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Amount";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.SortMode = DataGridViewColumnSortMode.NotSortable;
            Price.Width = 125;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = SystemColors.ActiveCaption;
            pnlFooter.BorderStyle = BorderStyle.Fixed3D;
            pnlFooter.Controls.Add(label4);
            pnlFooter.Controls.Add(lblTotalPrice);
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 472);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(797, 65);
            pnlFooter.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(440, 12);
            label4.Name = "label4";
            label4.Size = new Size(171, 42);
            label4.TabIndex = 23;
            label4.Text = "Total Price =";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.Location = new Point(606, 10);
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
            // panel3
            // 
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.Controls.Add(cmbStatus);
            panel3.Controls.Add(lblStatus);
            panel3.Controls.Add(txtNote);
            panel3.Controls.Add(lblNote);
            panel3.Controls.Add(cmbEmployee);
            panel3.Controls.Add(lblEmployeeName);
            panel3.Controls.Add(dtmSaleDate);
            panel3.Controls.Add(lblDate);
            panel3.Controls.Add(txtRefNumber);
            panel3.Controls.Add(lblRefNumber);
            panel3.Controls.Add(cmbCustomer);
            panel3.Controls.Add(lblCustomerName);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(797, 221);
            panel3.TabIndex = 17;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Completed", "On Hold", "Cancelled" });
            cmbStatus.Location = new Point(548, 65);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 33;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(548, 20);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(95, 42);
            lblStatus.TabIndex = 32;
            lblStatus.Text = "Status";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(548, 141);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(223, 65);
            txtNote.TabIndex = 31;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNote.Location = new Point(548, 98);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(75, 42);
            lblNote.TabIndex = 27;
            lblNote.Text = "Note";
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(270, 65);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(211, 28);
            cmbEmployee.TabIndex = 26;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeName.Location = new Point(270, 20);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(211, 42);
            lblEmployeeName.TabIndex = 25;
            lblEmployeeName.Text = "Employee Name";
            // 
            // dtmSaleDate
            // 
            dtmSaleDate.Location = new Point(270, 141);
            dtmSaleDate.Name = "dtmSaleDate";
            dtmSaleDate.Size = new Size(240, 27);
            dtmSaleDate.TabIndex = 24;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(270, 96);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(75, 42);
            lblDate.TabIndex = 23;
            lblDate.Text = "Date";
            // 
            // txtRefNumber
            // 
            txtRefNumber.Location = new Point(22, 143);
            txtRefNumber.Name = "txtRefNumber";
            txtRefNumber.Size = new Size(211, 27);
            txtRefNumber.TabIndex = 22;
            // 
            // lblRefNumber
            // 
            lblRefNumber.AutoSize = true;
            lblRefNumber.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRefNumber.Location = new Point(22, 98);
            lblRefNumber.Name = "lblRefNumber";
            lblRefNumber.Size = new Size(162, 42);
            lblRefNumber.TabIndex = 21;
            lblRefNumber.Text = "Ref Number";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(22, 67);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(211, 28);
            cmbCustomer.TabIndex = 20;
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Kh Pen Wappathor", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(22, 22);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(211, 42);
            lblCustomerName.TabIndex = 19;
            lblCustomerName.Text = "Customer Name";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(lblTitle);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(797, 80);
            panel4.TabIndex = 15;
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
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(583, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 537);
            panel2.TabIndex = 11;
            // 
            // flopnlItemList
            // 
            flopnlItemList.AutoScroll = true;
            flopnlItemList.Dock = DockStyle.Fill;
            flopnlItemList.Location = new Point(0, 159);
            flopnlItemList.Name = "flopnlItemList";
            flopnlItemList.Size = new Size(583, 537);
            flopnlItemList.TabIndex = 12;
            // 
            // FrmPOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 696);
            Controls.Add(flopnlItemList);
            Controls.Add(panel2);
            Controls.Add(pnlSale);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Name = "FrmPOS";
            Text = " ";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlSale.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgSaleDetail).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel pnlHeader;
        private TextBox txtSearch;
        private Label label2;
        private Panel pnlToolbar;
        private Panel pnlSale;
        private Panel panel2;
        private Label label3;
        private FlowLayoutPanel flopnlItemList;
        private Panel panel1;
        private DataGridView dgSaleDetail;
        private Panel pnlFooter;
        private Label label4;
        private Label lblTotalPrice;
        private Button btnCancel;
        private Button btnSave;
        private Panel panel3;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private TextBox txtNote;
        private Label lblNote;
        private ComboBox cmbEmployee;
        private Label lblEmployeeName;
        private DateTimePicker dtmSaleDate;
        private Label lblDate;
        private TextBox txtRefNumber;
        private Label lblRefNumber;
        private ComboBox cmbCustomer;
        private Label lblCustomerName;
        private Panel panel4;
        private Label lblTitle;
        private DataGridViewTextBoxColumn SaleDetailId;
        private DataGridViewTextBoxColumn SaleId;
        private DataGridViewComboBoxColumn ItemId;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPriceAtSale;
        private DataGridViewTextBoxColumn DiscountAmount;
        private DataGridViewTextBoxColumn Price;
        private ComboBox cmbCategory;
    }
}