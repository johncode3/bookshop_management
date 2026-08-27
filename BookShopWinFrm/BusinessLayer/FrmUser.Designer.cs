namespace BookShopWinFrm.BusinessLayer
{
    partial class FrmUser
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
            pnlToolbar = new Panel();
            label2 = new Label();
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            pnlHeader = new Panel();
            dgUsers = new DataGridView();
            panel2 = new Panel();
            pnlPermissionToolbar = new Panel();
            btnClearAll = new Button();
            btnApplyPermission = new Button();
            btnSelectAll = new Button();
            pnlPermissions = new Panel();
            flowLayoutPanelPermissions = new FlowLayoutPanel();
            pnlToolbar.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsers).BeginInit();
            pnlPermissionToolbar.SuspendLayout();
            pnlPermissions.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kh Pen Wappathor", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(463, 62);
            label1.TabIndex = 0;
            label1.Text = "User and Permission List";
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
            pnlToolbar.Size = new Size(1475, 79);
            pnlToolbar.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kh Pen Wappathor", 10F);
            label2.Location = new Point(598, 10);
            label2.Name = "label2";
            label2.Size = new Size(115, 31);
            label2.TabIndex = 4;
            label2.Text = "Search User";
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
            pnlHeader.Size = new Size(1475, 80);
            pnlHeader.TabIndex = 8;
            // 
            // dgUsers
            // 
            dgUsers.AllowUserToAddRows = false;
            dgUsers.AllowUserToDeleteRows = false;
            dgUsers.AllowUserToResizeColumns = false;
            dgUsers.AllowUserToResizeRows = false;
            dgUsers.BackgroundColor = Color.White;
            dgUsers.BorderStyle = BorderStyle.None;
            dgUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgUsers.ColumnHeadersHeight = 40;
            dgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgUsers.Dock = DockStyle.Left;
            dgUsers.Location = new Point(0, 159);
            dgUsers.MultiSelect = false;
            dgUsers.Name = "dgUsers";
            dgUsers.ReadOnly = true;
            dgUsers.RowHeadersVisible = false;
            dgUsers.RowHeadersWidth = 51;
            dgUsers.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgUsers.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
            dgUsers.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgUsers.RowTemplate.Height = 30;
            dgUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsers.Size = new Size(639, 600);
            dgUsers.TabIndex = 10;
            dgUsers.RowPostPaint += dgUsers_RowPostPaint;
            dgUsers.SelectionChanged += dgUsers_SelectionChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(639, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 600);
            panel2.TabIndex = 12;
            // 
            // pnlPermissionToolbar
            // 
            pnlPermissionToolbar.BackColor = SystemColors.ActiveCaption;
            pnlPermissionToolbar.Controls.Add(btnClearAll);
            pnlPermissionToolbar.Controls.Add(btnApplyPermission);
            pnlPermissionToolbar.Controls.Add(btnSelectAll);
            pnlPermissionToolbar.Dock = DockStyle.Bottom;
            pnlPermissionToolbar.Location = new Point(642, 700);
            pnlPermissionToolbar.Name = "pnlPermissionToolbar";
            pnlPermissionToolbar.Size = new Size(833, 59);
            pnlPermissionToolbar.TabIndex = 13;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = Color.FromArgb(220, 53, 69);
            btnClearAll.FlatAppearance.BorderColor = Color.White;
            btnClearAll.FlatAppearance.BorderSize = 0;
            btnClearAll.FlatStyle = FlatStyle.Flat;
            btnClearAll.Font = new Font("Kh Pen Wappathor", 10F, FontStyle.Bold);
            btnClearAll.ForeColor = Color.White;
            btnClearAll.Location = new Point(166, 9);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(138, 38);
            btnClearAll.TabIndex = 7;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnApplyPermission
            // 
            btnApplyPermission.BackColor = Color.FromArgb(40, 167, 69);
            btnApplyPermission.FlatAppearance.BorderColor = Color.White;
            btnApplyPermission.FlatAppearance.BorderSize = 0;
            btnApplyPermission.FlatStyle = FlatStyle.Flat;
            btnApplyPermission.Font = new Font("Kh Pen Wappathor", 10F, FontStyle.Bold);
            btnApplyPermission.ForeColor = Color.White;
            btnApplyPermission.Location = new Point(310, 9);
            btnApplyPermission.Name = "btnApplyPermission";
            btnApplyPermission.Size = new Size(208, 38);
            btnApplyPermission.TabIndex = 5;
            btnApplyPermission.Text = "Apply Permission";
            btnApplyPermission.UseVisualStyleBackColor = false;
            btnApplyPermission.Click += btnApplyPermissions_Click;
            // 
            // btnSelectAll
            // 
            btnSelectAll.BackColor = Color.FromArgb(0, 123, 255);
            btnSelectAll.FlatAppearance.BorderColor = Color.White;
            btnSelectAll.FlatAppearance.BorderSize = 0;
            btnSelectAll.FlatStyle = FlatStyle.Flat;
            btnSelectAll.Font = new Font("Kh Pen Wappathor", 10F, FontStyle.Bold);
            btnSelectAll.ForeColor = Color.White;
            btnSelectAll.Location = new Point(22, 9);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new Size(138, 38);
            btnSelectAll.TabIndex = 6;
            btnSelectAll.Text = "Select All";
            btnSelectAll.UseVisualStyleBackColor = false;
            btnSelectAll.Click += btnSelectAll_Click;
            // 
            // pnlPermissions
            // 
            pnlPermissions.BackColor = Color.White;
            pnlPermissions.Controls.Add(flowLayoutPanelPermissions);
            pnlPermissions.Dock = DockStyle.Fill;
            pnlPermissions.Location = new Point(642, 159);
            pnlPermissions.Name = "pnlPermissions";
            pnlPermissions.Size = new Size(833, 541);
            pnlPermissions.TabIndex = 14;
            // 
            // flowLayoutPanelPermissions
            // 
            flowLayoutPanelPermissions.BackColor = Color.White;
            flowLayoutPanelPermissions.Dock = DockStyle.Fill;
            flowLayoutPanelPermissions.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelPermissions.Location = new Point(0, 0);
            flowLayoutPanelPermissions.Name = "flowLayoutPanelPermissions";
            flowLayoutPanelPermissions.Size = new Size(833, 541);
            flowLayoutPanelPermissions.TabIndex = 0;
            // 
            // FrmUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 759);
            Controls.Add(pnlPermissions);
            Controls.Add(pnlPermissionToolbar);
            Controls.Add(panel2);
            Controls.Add(dgUsers);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Name = "FrmUser";
            Text = "FrmUser";
            WindowState = FormWindowState.Maximized;
            Load += FrmAppUser_Load;
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsers).EndInit();
            pnlPermissionToolbar.ResumeLayout(false);
            pnlPermissions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel pnlToolbar;
        private Label label2;
        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Panel pnlHeader;
        private DataGridView dgUsers;
        private Panel panel2;
        private Panel pnlPermissionToolbar;
        private Button btnClearAll;
        private Button btnApplyPermission;
        private Button btnSelectAll;
        private Panel pnlPermissions;
        private FlowLayoutPanel flowLayoutPanelPermissions;
    }
}