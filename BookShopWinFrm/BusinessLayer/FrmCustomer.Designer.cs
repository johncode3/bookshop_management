namespace BookShopWinFrm.BusinessLayer
{
    partial class FrmCustomer
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
            pnlToolbar = new Panel();
            label2 = new Label();
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgCustomers = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCustomers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kh Pen Wappathor", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 62);
            label1.TabIndex = 0;
            label1.Text = "Customer List";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.LightSkyBlue;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1130, 80);
            pnlHeader.TabIndex = 2;
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
            pnlToolbar.Size = new Size(1130, 79);
            pnlToolbar.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Pen Wappathor", 10F);
            label2.Location = new Point(482, 11);
            label2.Name = "label2";
            label2.Size = new Size(363, 31);
            label2.TabIndex = 4;
            label2.Text = "Search Customer Name or Company Name";
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
            btnAdd.Click += btnAdd_Click;
            // 
            // dgCustomers
            // 
            dgCustomers.AllowUserToAddRows = false;
            dgCustomers.AllowUserToDeleteRows = false;
            dgCustomers.AllowUserToResizeColumns = false;
            dgCustomers.AllowUserToResizeRows = false;
            dgCustomers.BackgroundColor = Color.White;
            dgCustomers.BorderStyle = BorderStyle.None;
            dgCustomers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgCustomers.ColumnHeadersHeight = 40;
            dgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgCustomers.Dock = DockStyle.Fill;
            dgCustomers.Location = new Point(0, 159);
            dgCustomers.MultiSelect = false;
            dgCustomers.Name = "dgCustomers";
            dgCustomers.ReadOnly = true;
            dgCustomers.RowHeadersVisible = false;
            dgCustomers.RowHeadersWidth = 51;
            dgCustomers.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgCustomers.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
            dgCustomers.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgCustomers.RowTemplate.Height = 30;
            dgCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCustomers.Size = new Size(1130, 566);
            dgCustomers.TabIndex = 4;
            dgCustomers.CellPainting += dgCustomers_CellPainting;
            dgCustomers.RowPostPaint += dgCustomers_RowPostPaint;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 725);
            Controls.Add(dgCustomers);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Name = "FrmCustomer";
            Text = "FrmCustomer";
            WindowState = FormWindowState.Maximized;
            Load += FrmCustomer_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnl;
        private Label label1;
        private Panel pnlHeader;
        private Panel pnlToolbar;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgCustomers;
        private TextBox txtSearch;
        private Label label2;
    }
}