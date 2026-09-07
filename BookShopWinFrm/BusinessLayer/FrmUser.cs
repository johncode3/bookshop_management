using BookShopWinFrm.DataLayer.Model;
using BookShopWinFrm.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopWinFrm.BusinessLayer
{
    public partial class FrmUser : Form
    {
        DataTable dtUser;
        DataTable dtUserPermission;

        public DataTable UserPermissions { get; set; }

        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmAppUser_Load(object sender, EventArgs e)
        {
            InitializePermissionCheckboxes();
            LoadData();
            ApplyPermissions();
        }

        private void ApplyPermissions()
        {
            if (FrmMain.CurrentUser?.IsAdmin == true)
            {
                btnAdd.Visible = true;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                return;
            }

            btnAdd.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;

            if (this.UserPermissions == null || this.UserPermissions.Rows.Count == 0)
                return;

            foreach (DataRow row in this.UserPermissions.Rows)
            {
                string permName = row["PermissionName"].ToString();

                if (permName == "UserCreate")
                    btnAdd.Visible = true;
                else if (permName == "UserModify")
                    btnEdit.Visible = true;
                else if (permName == "UserDelete")
                    btnDelete.Visible = true;
            }
        }
        private bool _isLoading = true;
        private void InitializePermissionCheckboxes()
        {
            flowLayoutPanelPermissions.Controls.Clear();

            Dictionary<string, string> modules = new Dictionary<string, string>()
            {
                { "Customer List", "Customer" },
                { "Sale Transaction", "Sale" },
                { "Purchase Transaction", "Purchase" },
                { "Item Management", "Item" },
                { "Inventory Adjustment", "InventoryAdjustment" },
                { "Employee Management", "Employee" },
                { "Vendor Management", "Vendor" },
                { "User Security", "User" }
            };

            string[] actions = { "View", "Create", "Modify", "Delete" };

            foreach (var modulePair in modules)
            {
                string displayTitle = modulePair.Key;
                string moduleKey = modulePair.Value;

                Panel pnlSection = new Panel();
                pnlSection.Width = flowLayoutPanelPermissions.Width - 40;
                pnlSection.Height = 60;
                pnlSection.Margin = new Padding(10, 5, 10, 10);

                Label lblTitle = new Label();
                lblTitle.Text = displayTitle;
                lblTitle.Font = new Font("Kh Pen", 10F, FontStyle.Bold);
                lblTitle.Location = new Point(5, 2);
                lblTitle.AutoSize = true;
                pnlSection.Controls.Add(lblTitle);

                int xPos = 5;
                int yPos = 28;

                foreach (string action in actions)
                {
                    CheckBox chk = new CheckBox();
                    chk.Name = $"{moduleKey}{action}";
                    chk.Text = action;
                    chk.Location = new Point(xPos, yPos);
                    chk.Width = 85;
                    chk.Font = new Font("Kh Pen", 9F, FontStyle.Regular);
                    pnlSection.Controls.Add(chk);

                    xPos += 90;
                }
                flowLayoutPanelPermissions.Controls.Add(pnlSection);
            }
        }
        // User Data
        private void LoadData()
        {
            _isLoading = true;
            dtUser = AppUserService.GetAll();
            dgUsers.DataSource = dtUser;
            dgUsers.RowTemplate.Height = 70;
            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dgUsers.Columns["Avatar"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            if (dgUsers.Columns.Contains("IsActive")) dgUsers.Columns["IsActive"].Visible = false;
            if (dgUsers.Columns.Contains("IsAdmin")) dgUsers.Columns["IsAdmin"].Visible = false;
            if (dgUsers.Columns.Contains("Password")) dgUsers.Columns["Password"].Visible = false;
            if (dgUsers.Columns.Contains("AppUserId")) dgUsers.Columns["AppUserId"].Visible = false;
            if (dgUsers.Columns.Contains("EmployeeId")) dgUsers.Columns["EmployeeId"].Visible = false;

            if (!dgUsers.Columns.Contains("No"))
            {
                DataGridViewTextBoxColumn colNo = new DataGridViewTextBoxColumn();
                colNo.Name = "No";
                colNo.HeaderText = "No.";
                colNo.Width = 50;
                colNo.DisplayIndex = 0;
                dgUsers.Columns.Insert(0, colNo);
            }
            else
            {
                dgUsers.Columns["No"].DisplayIndex = 0;
            }

            if (dtUser.Rows.Count > 0 && dgUsers.Columns.Contains("AppUserId"))
            {
                dgUsers.Sort(dgUsers.Columns["AppUserId"], ListSortDirection.Descending);
            }

            if (dgUsers.Columns.Contains("Avatar"))
            {
                dgUsers.Columns["Avatar"].HeaderText = "Profile Picture";
                dgUsers.Columns["Avatar"].Width = 200;
                dgUsers.Columns["Avatar"].DisplayIndex = 1;
            }

            if (dgUsers.Columns.Contains("UserName"))
            {
                dgUsers.Columns["UserName"].HeaderText = "User Name";
                dgUsers.Columns["UserName"].DisplayIndex = 2;
                dgUsers.Columns["UserName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            _isLoading = false;
            SetAllCheckboxes(flowLayoutPanelPermissions, false);
        }

        private void dgUsers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                e.Handled = true;
                using (Brush b = new SolidBrush(dgUsers.DefaultCellStyle.BackColor))
                {
                    e.Graphics.FillRectangle(b, e.CellBounds);
                }
                using (Pen p = new Pen(Brushes.Black))
                {
                    p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    p.Color = Color.FromArgb(33, 37, 41);
                    e.Graphics.DrawLine(p, new Point(0, e.CellBounds.Bottom - 1), new Point(e.CellBounds.Right, e.CellBounds.Bottom - 1));
                    e.Graphics.DrawLine(p, new Point(0, 0), new Point(e.CellBounds.Right, 0));
                }
                e.PaintContent(e.ClipBounds);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search(txtSearch.Text.Trim());
        }

        private void Search(string searchText)
        {
            if (dtUser == null) return;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                dtUser.DefaultView.RowFilter = string.Empty;
                dgUsers.DataSource = dtUser;
                return;
            }
            string s = searchText.Trim().Replace("'", "''");
            string filter = $"UserName LIKE '%{s}%'";
            dtUser.DefaultView.RowFilter = filter;
            dgUsers.DataSource = dtUser.DefaultView;
        }

        private void dgUsers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center  
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmUserAddEdit frmAddEdit = new FrmUserAddEdit(null);
            if (frmAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int userId = Convert.ToInt32(dgUsers.SelectedRows[0].Cells["AppUserId"].Value);
            AppUser user = AppUserService.Get(userId);
            FrmUserAddEdit frmUserAddEdit = new FrmUserAddEdit(user);
            if (frmUserAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete the selected user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                int AppUserId = Convert.ToInt32(dgUsers.SelectedRows[0].Cells["AppUserId"].Value);
                AppUserService.Delete(AppUserId);
                LoadData();
                MessageBox.Show("User deleted successfully.", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Permission Data
        private void dgUsers_SelectionChanged(object sender, EventArgs e)
        {
            LoadUserPermissions();
        }

        private void LoadUserPermissions()
        {
            if (_isLoading)
                return;
            if (dgUsers.SelectedRows.Count > 0)
            {
                int AppUserId = Convert.ToInt32(dgUsers.SelectedRows[0].Cells["AppUserId"].Value.ToString());
                dtUserPermission = AppUserService.GetUserPermissions(AppUserId);

                SetAllCheckboxes(flowLayoutPanelPermissions, false);
                if (dtUserPermission != null && dtUserPermission.Rows.Count > 0)
                {
                    foreach (DataRow row in dtUserPermission.Rows)
                    {
                        string permName = row["PermissionName"].ToString();
                        CheckBox permissionCheckbox = FindCheckboxRecursive(flowLayoutPanelPermissions, permName);
                        if (permissionCheckbox != null)
                        {
                            permissionCheckbox.Checked = true;
                        }
                    }
                }
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            SetAllCheckboxes(flowLayoutPanelPermissions, true);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            SetAllCheckboxes(flowLayoutPanelPermissions, false);
        }

        private void btnApplyPermissions_Click(object sender, EventArgs e)
        {
            if (dgUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to apply permissions.", "Apply Permissions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult confirm = MessageBox.Show("Are you sure you want to apply the selected permissions?", "Apply Permissions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if (dgUsers.SelectedRows.Count > 0)
                {
                    int appuserid = Convert.ToInt32(dgUsers.SelectedRows[0].Cells["AppUserId"].Value.ToString());
                    AppUserService.DeleteUserPermission(new AppUserPermission { AppUserId = appuserid });
                    SaveCheckedPermissionsRecursive(flowLayoutPanelPermissions, appuserid);
                    MessageBox.Show("Permissions updated successfully.", "Apply Permissions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserPermissions();
                }
            }
        }

        private void SetAllCheckboxes(Control container, bool isChecked)
        {
            foreach (Control ctrl in container.Controls)
            {
                if (ctrl is CheckBox cb)
                {
                    cb.Checked = isChecked;
                }
                else if (ctrl.HasChildren)
                {
                    SetAllCheckboxes(ctrl, isChecked);
                }
            }
        }

        private CheckBox FindCheckboxRecursive(Control container, string name)
        {
            foreach (Control ctrl in container.Controls)
            {
                if (ctrl is CheckBox cb && cb.Name == name)
                {
                    return cb;
                }
                if (ctrl.HasChildren)
                {
                    CheckBox found = FindCheckboxRecursive(ctrl, name);
                    if (found != null) return found;
                }
            }
            return null;
        }

        private void SaveCheckedPermissionsRecursive(Control container, int appUserId)
        {
            foreach (Control ctrl in container.Controls)
            {
                if (ctrl is CheckBox cb && cb.Checked)
                {
                    AppUserPermission userPermission = new AppUserPermission();
                    userPermission.AppUserId = appUserId;
                    userPermission.PermissionName = cb.Name; // e.g., "CustomerView"
                    AppUserService.AddUserPermission(userPermission);
                }
                else if (ctrl.HasChildren)
                {
                    SaveCheckedPermissionsRecursive(ctrl, appUserId);
                }
            }
        }
    }
}