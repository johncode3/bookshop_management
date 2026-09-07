namespace BookShopWinFrm.BusinessLayer
{
    partial class FrmSale
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
            dgSales = new DataGridView();
            label1 = new Label();
            pnlToolbar = new Panel();
            label2 = new Label();
            txtSearch = new TextBox();
            btnCancel = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            pnlHeader = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgSales).BeginInit();
            pnlToolbar.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgSales
            // 
            dgSales.AllowUserToAddRows = false;
            dgSales.AllowUserToDeleteRows = false;
            dgSales.AllowUserToResizeColumns = false;
            dgSales.AllowUserToResizeRows = false;
            dgSales.BackgroundColor = Color.White;
            dgSales.BorderStyle = BorderStyle.None;
            dgSales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgSales.ColumnHeadersHeight = 40;
            dgSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgSales.Dock = DockStyle.Fill;
            dgSales.Location = new Point(0, 159);
            dgSales.MultiSelect = false;
            dgSales.Name = "dgSales";
            dgSales.ReadOnly = true;
            dgSales.RowHeadersVisible = false;
            dgSales.RowHeadersWidth = 50;
            dgSales.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgSales.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
            dgSales.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgSales.RowTemplate.Height = 30;
            dgSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSales.Size = new Size(1132, 456);
            dgSales.TabIndex = 7;
            dgSales.CellPainting += dgSales_CellPainting;
            dgSales.RowPostPaint += dgCustomers_RowPostPaint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kh Pen Wappathor", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 62);
            label1.TabIndex = 0;
            label1.Text = "Sale List";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = SystemColors.ActiveCaption;
            pnlToolbar.BorderStyle = BorderStyle.Fixed3D;
            pnlToolbar.Controls.Add(label2);
            pnlToolbar.Controls.Add(txtSearch);
            pnlToolbar.Controls.Add(btnCancel);
            pnlToolbar.Controls.Add(btnEdit);
            pnlToolbar.Controls.Add(btnAdd);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 80);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(1132, 79);
            pnlToolbar.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Pen Wappathor", 10F);
            label2.Location = new Point(580, 10);
            label2.Name = "label2";
            label2.Size = new Size(143, 31);
            label2.TabIndex = 4;
            label2.Text = "Search For Sale";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(533, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(242, 27);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(220, 53, 69);
            btnCancel.FlatAppearance.BorderColor = Color.White;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Kh Pen Wappathor", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(323, 19);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(172, 38);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel Sale";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
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
            pnlHeader.Size = new Size(1132, 80);
            pnlHeader.TabIndex = 5;
            // 
            // FrmSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 615);
            Controls.Add(dgSales);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Name = "FrmSale";
            Text = "FrmSale";
            WindowState = FormWindowState.Maximized;
            Load += FrmSale_Load;
            ((System.ComponentModel.ISupportInitialize)dgSales).EndInit();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgSales;
        private Label label1;
        private Panel pnlToolbar;
        private Label label2;
        private TextBox txtSearch;
        private Button btnCancel;
        private Button btnEdit;
        private Button btnAdd;
        private Panel pnlHeader;
    }
}