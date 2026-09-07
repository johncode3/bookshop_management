namespace BookShopWinFrm.BusinessLayer
{
    partial class FrmVendor
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
            dgVendors = new DataGridView();
            label1 = new Label();
            pnlToolbar = new Panel();
            label2 = new Label();
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            pnlHeader = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgVendors).BeginInit();
            pnlToolbar.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgVendors
            // 
            dgVendors.AllowUserToAddRows = false;
            dgVendors.AllowUserToDeleteRows = false;
            dgVendors.AllowUserToResizeColumns = false;
            dgVendors.AllowUserToResizeRows = false;
            dgVendors.BackgroundColor = Color.White;
            dgVendors.BorderStyle = BorderStyle.None;
            dgVendors.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgVendors.ColumnHeadersHeight = 40;
            dgVendors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgVendors.Dock = DockStyle.Fill;
            dgVendors.Location = new Point(0, 159);
            dgVendors.MultiSelect = false;
            dgVendors.Name = "dgVendors";
            dgVendors.ReadOnly = true;
            dgVendors.RowHeadersVisible = false;
            dgVendors.RowHeadersWidth = 51;
            dgVendors.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgVendors.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
            dgVendors.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgVendors.RowTemplate.Height = 30;
            dgVendors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgVendors.Size = new Size(1095, 557);
            dgVendors.TabIndex = 7;
            dgVendors.CellPainting += dgVendors_CellPainting;
            dgVendors.RowPostPaint += dgVendors_RowPostPaint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kh Pen Wappathor", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 62);
            label1.TabIndex = 0;
            label1.Text = "Vendor List";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = SystemColors.ActiveCaption;
            pnlToolbar.BorderStyle = BorderStyle.Fixed3D;
            pnlToolbar.Controls.Add(label2);
            pnlToolbar.Controls.Add(txtSearch);
            pnlToolbar.Controls.Add(btnDelete);
            pnlToolbar.Controls.Add(btnEdit);
            pnlToolbar.Controls.Add(btnAdd);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 80);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(1095, 79);
            pnlToolbar.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Pen Wappathor", 10F);
            label2.Location = new Point(580, 10);
            label2.Name = "label2";
            label2.Size = new Size(136, 31);
            label2.TabIndex = 4;
            label2.Text = "Search Vendor";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(533, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(242, 27);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.FlatAppearance.BorderColor = Color.White;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Kh Pen Wappathor", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(323, 19);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 123, 255);
            btnEdit.FlatAppearance.BorderColor = Color.White;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Kh Pen Wappathor", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(165, 19);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(138, 38);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Visible = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(40, 167, 69);
            btnAdd.FlatAppearance.BorderColor = Color.White;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Kh Pen Wappathor", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(10, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.LightSkyBlue;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1095, 80);
            pnlHeader.TabIndex = 5;
            // 
            // FrmVendor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 716);
            Controls.Add(dgVendors);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Name = "FrmVendor";
            Text = "FrmVendor";
            WindowState = FormWindowState.Maximized;
            Load += FrmVendor_Load;
            ((System.ComponentModel.ISupportInitialize)dgVendors).EndInit();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgVendors;
        private Label label1;
        private Panel pnlToolbar;
        private Label label2;
        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Panel pnlHeader;
    }
}