namespace BookShopWinFrm.BusinessLayer
{
    partial class FrmEmployee
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
            dgEmployees = new DataGridView();
            label1 = new Label();
            pnlToolbar = new Panel();
            label2 = new Label();
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            pnlHeader = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgEmployees).BeginInit();
            pnlToolbar.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgEmployees
            // 
            dgEmployees.AllowUserToAddRows = false;
            dgEmployees.AllowUserToDeleteRows = false;
            dgEmployees.AllowUserToResizeColumns = false;
            dgEmployees.AllowUserToResizeRows = false;
            dgEmployees.BackgroundColor = Color.White;
            dgEmployees.BorderStyle = BorderStyle.None;
            dgEmployees.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgEmployees.ColumnHeadersHeight = 40;
            dgEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgEmployees.Dock = DockStyle.Fill;
            dgEmployees.Location = new Point(0, 159);
            dgEmployees.MultiSelect = false;
            dgEmployees.Name = "dgEmployees";
            dgEmployees.ReadOnly = true;
            dgEmployees.RowHeadersVisible = false;
            dgEmployees.RowHeadersWidth = 51;
            dgEmployees.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgEmployees.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
            dgEmployees.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgEmployees.RowTemplate.Height = 30;
            dgEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgEmployees.Size = new Size(1086, 616);
            dgEmployees.TabIndex = 7;
            dgEmployees.CellFormatting += dgEmployees_CellFormatting;
            dgEmployees.CellPainting += dgEmployees_CellPainting;
            dgEmployees.RowPostPaint += dgEmployees_RowPostPaint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kh Pen Wappathor", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 62);
            label1.TabIndex = 0;
            label1.Text = "Employee List";
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
            pnlToolbar.Size = new Size(1086, 79);
            pnlToolbar.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Pen Wappathor", 10F);
            label2.Location = new Point(575, 10);
            label2.Name = "label2";
            label2.Size = new Size(157, 31);
            label2.TabIndex = 4;
            label2.Text = "Search Employee";
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
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.LightSkyBlue;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1086, 80);
            pnlHeader.TabIndex = 5;
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 775);
            Controls.Add(dgEmployees);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Name = "FrmEmployee";
            Text = "FrmEmployee";
            WindowState = FormWindowState.Maximized;
            Load += FrmEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dgEmployees).EndInit();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgEmployees;
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