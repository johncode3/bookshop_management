namespace BookShopWinFrm.BusinessLayer
{
    partial class FrmInventoryAdjustment
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
            dgInventoryAdjDetail = new DataGridView();
            label1 = new Label();
            pnlToolbar = new Panel();
            label2 = new Label();
            txtSearch = new TextBox();
            btnEdit = new Button();
            btnAdd = new Button();
            pnlHeader = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgInventoryAdjDetail).BeginInit();
            pnlToolbar.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgInventoryAdjDetail
            // 
            dgInventoryAdjDetail.AllowUserToAddRows = false;
            dgInventoryAdjDetail.AllowUserToDeleteRows = false;
            dgInventoryAdjDetail.AllowUserToResizeColumns = false;
            dgInventoryAdjDetail.AllowUserToResizeRows = false;
            dgInventoryAdjDetail.BackgroundColor = Color.White;
            dgInventoryAdjDetail.BorderStyle = BorderStyle.None;
            dgInventoryAdjDetail.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgInventoryAdjDetail.ColumnHeadersHeight = 40;
            dgInventoryAdjDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgInventoryAdjDetail.Dock = DockStyle.Fill;
            dgInventoryAdjDetail.Location = new Point(0, 159);
            dgInventoryAdjDetail.MultiSelect = false;
            dgInventoryAdjDetail.Name = "dgInventoryAdjDetail";
            dgInventoryAdjDetail.ReadOnly = true;
            dgInventoryAdjDetail.RowHeadersVisible = false;
            dgInventoryAdjDetail.RowHeadersWidth = 50;
            dgInventoryAdjDetail.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgInventoryAdjDetail.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
            dgInventoryAdjDetail.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgInventoryAdjDetail.RowTemplate.Height = 30;
            dgInventoryAdjDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgInventoryAdjDetail.Size = new Size(923, 698);
            dgInventoryAdjDetail.TabIndex = 13;
            dgInventoryAdjDetail.CellPainting += dgPurchases_CellPainting;
            dgInventoryAdjDetail.RowPostPaint += dgPurchases_RowPostPaint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kh Pen Wappathor", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(475, 62);
            label1.TabIndex = 0;
            label1.Text = "Inventory Adjustment List";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = SystemColors.ActiveCaption;
            pnlToolbar.BorderStyle = BorderStyle.Fixed3D;
            pnlToolbar.Controls.Add(label2);
            pnlToolbar.Controls.Add(txtSearch);
            pnlToolbar.Controls.Add(btnEdit);
            pnlToolbar.Controls.Add(btnAdd);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 80);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(923, 79);
            pnlToolbar.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Pen Wappathor", 10F);
            label2.Location = new Point(569, 11);
            label2.Name = "label2";
            label2.Size = new Size(184, 31);
            label2.TabIndex = 4;
            label2.Text = "Search For Purchase";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(544, 45);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(242, 27);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            pnlHeader.Size = new Size(923, 80);
            pnlHeader.TabIndex = 11;
            // 
            // FrmInventoryAdjustment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 857);
            Controls.Add(dgInventoryAdjDetail);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Name = "FrmInventoryAdjustment";
            Text = "FrmInventoryAdjustment";
            WindowState = FormWindowState.Maximized;
            Load += FrmInventoryAdjustment_Load;
            ((System.ComponentModel.ISupportInitialize)dgInventoryAdjDetail).EndInit();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgInventoryAdjDetail;
        private Label label1;
        private Panel pnlToolbar;
        private Label label2;
        private TextBox txtSearch;
        private Button btnEdit;
        private Button btnAdd;
        private Panel pnlHeader;
    }
}