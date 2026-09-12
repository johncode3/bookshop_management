namespace BookShopWinFrm.BusinessLayer
{
    partial class FrmPurchase
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
            dgPurchases = new DataGridView();
            label1 = new Label();
            pnlToolbar = new Panel();
            label2 = new Label();
            txtSearch = new TextBox();
            btnCancel = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            pnlHeader = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgPurchases).BeginInit();
            pnlToolbar.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgPurchases
            // 
            dgPurchases.AllowUserToAddRows = false;
            dgPurchases.AllowUserToDeleteRows = false;
            dgPurchases.AllowUserToResizeColumns = false;
            dgPurchases.AllowUserToResizeRows = false;
            dgPurchases.BackgroundColor = Color.White;
            dgPurchases.BorderStyle = BorderStyle.None;
            dgPurchases.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgPurchases.ColumnHeadersHeight = 40;
            dgPurchases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgPurchases.Dock = DockStyle.Fill;
            dgPurchases.Location = new Point(0, 159);
            dgPurchases.MultiSelect = false;
            dgPurchases.Name = "dgPurchases";
            dgPurchases.ReadOnly = true;
            dgPurchases.RowHeadersVisible = false;
            dgPurchases.RowHeadersWidth = 50;
            dgPurchases.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgPurchases.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
            dgPurchases.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgPurchases.RowTemplate.Height = 30;
            dgPurchases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPurchases.Size = new Size(1259, 508);
            dgPurchases.TabIndex = 10;
            dgPurchases.CellPainting += dgPurchases_CellPainting;
            dgPurchases.RowPostPaint += dgPurchases_RowPostPaint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kh Pen Wappathor", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 62);
            label1.TabIndex = 0;
            label1.Text = "Purchase List";
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
            pnlToolbar.Size = new Size(1259, 79);
            pnlToolbar.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Pen Wappathor", 10F);
            label2.Location = new Point(630, 10);
            label2.Name = "label2";
            label2.Size = new Size(184, 31);
            label2.TabIndex = 4;
            label2.Text = "Search For Purchase";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(605, 44);
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
            btnCancel.Size = new Size(218, 38);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel Purchase";
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
            pnlHeader.Size = new Size(1259, 80);
            pnlHeader.TabIndex = 8;
            // 
            // FrmPurchase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 667);
            Controls.Add(dgPurchases);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Name = "FrmPurchase";
            Text = "FrmPurchase";
            WindowState = FormWindowState.Maximized;
            Load += FrmPurchase_Load;
            ((System.ComponentModel.ISupportInitialize)dgPurchases).EndInit();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgPurchases;
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