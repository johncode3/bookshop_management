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
    public partial class FrmEmployee : Form
    {
        DataTable dtEmployee;

        public DataTable UserPermissions { get; set; }

        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
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

                if (permName == "EmployeeCreate")
                    btnAdd.Visible = true;
                else if (permName == "EmployeeModify")
                    btnEdit.Visible = true;
                else if (permName == "EmployeeDelete")
                    btnDelete.Visible = true;
            }
        }
        private void LoadData()
        {
            dtEmployee = EmployeeService.GetAll();
            dgEmployees.DataSource = dtEmployee;

            if (dgEmployees.Columns.Contains("IsActive"))
            {
                dgEmployees.Columns["IsActive"].Visible = false;
            }
            if (dgEmployees.Columns.Contains("EmployeeId"))
            {
                dgEmployees.Columns["EmployeeId"].Visible = false;
            }

            if (!dgEmployees.Columns.Contains("No"))
            {
                DataGridViewTextBoxColumn colNo = new DataGridViewTextBoxColumn();
                colNo.Name = "No";
                colNo.HeaderText = "No.";
                colNo.Width = 50;
                colNo.DisplayIndex = 0;
                dgEmployees.Columns.Insert(0, colNo);
            }
            else
            {
                dgEmployees.Columns["No"].DisplayIndex = 0;
            }

            dgEmployees.Sort(dgEmployees.Columns["EmployeeId"], ListSortDirection.Descending);

            dgEmployees.Columns["EmployeeName"].HeaderText = "Name";
            dgEmployees.Columns["EmployeeName"].Width = 200;
            dgEmployees.Columns["EmployeeName"].DisplayIndex = 1;

            dgEmployees.Columns["Sex"].HeaderText = "Gender";
            dgEmployees.Columns["Sex"].Width = 80;
            dgEmployees.Columns["Sex"].DisplayIndex = 2;

            dgEmployees.Columns["DOB"].HeaderText = "Date of Birth";
            dgEmployees.Columns["DOB"].Width = 150;
            dgEmployees.Columns["DOB"].DisplayIndex = 3;

            dgEmployees.Columns["MaritalStatus"].HeaderText = "Marital Status";
            dgEmployees.Columns["MaritalStatus"].Width = 150;
            dgEmployees.Columns["MaritalStatus"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgEmployees.Columns["MaritalStatus"].DisplayIndex = 4;

            dgEmployees.Columns["HaveSpouse"].HeaderText = "Have Spouse";
            dgEmployees.Columns["HaveSpouse"].Width = 150;
            dgEmployees.Columns["HaveSpouse"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgEmployees.Columns["HaveSpouse"].DisplayIndex = 5;

            dgEmployees.Columns["NumberOfChildren"].HeaderText = "Children Number";
            dgEmployees.Columns["NumberOfChildren"].Width = 150;
            dgEmployees.Columns["NumberOfChildren"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgEmployees.Columns["NumberOfChildren"].DisplayIndex = 6;

            dgEmployees.Columns["HiredDate"].HeaderText = "Hire Date";
            dgEmployees.Columns["HiredDate"].Width = 150;
            dgEmployees.Columns["HiredDate"].DisplayIndex = 7;

            dgEmployees.Columns["Position"].HeaderText = "Position";
            dgEmployees.Columns["Position"].Width = 150;
            dgEmployees.Columns["Position"].DisplayIndex = 8;

            dgEmployees.Columns["Department"].HeaderText = "Department";
            dgEmployees.Columns["Department"].Width = 150;
            dgEmployees.Columns["Department"].DisplayIndex = 9;

            dgEmployees.Columns["Salary"].HeaderText = "Salary";
            dgEmployees.Columns["Salary"].Width = 120;
            dgEmployees.Columns["Salary"].DisplayIndex = 10;

            dgEmployees.Columns["Address"].HeaderText = "Address";
            dgEmployees.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgEmployees.Columns["Address"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgEmployees.Columns["Address"].DisplayIndex = 11;
        }
        private void dgEmployees_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 & e.ColumnIndex > -1)
            {
                {
                    e.Handled = true;
                    using (Brush b = new SolidBrush(dgEmployees.DefaultCellStyle.BackColor))
                    {
                        e.Graphics.FillRectangle(b, e.CellBounds);
                    }
                    using (Pen p = new Pen(Brushes.Black))
                    {
                        {
                            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                            p.Color = Color.FromArgb(33, 37, 41);
                            e.Graphics.DrawLine(p, new Point(0, e.CellBounds.Bottom - 1), new Point(e.CellBounds.Right, e.CellBounds.Bottom - 1));
                            e.Graphics.DrawLine(p, new Point(0, 0), new Point(e.CellBounds.Right, 0));
                        }
                        e.PaintContent(e.ClipBounds);
                    }
                }
            }
        }
        private void dgEmployees_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search(txtSearch.Text.Trim());
        }
        private void Search(string searchText)
        {
            if (dtEmployee == null)
                return;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                dtEmployee.DefaultView.RowFilter = string.Empty;
                dgEmployees.DataSource = dtEmployee;
                return;
            }
            string s = searchText.Trim().Replace("'", "''");
            string filter = $"EmployeeName LIKE '%{s}%' OR Department LIKE '%{s}%'";
            dtEmployee.DefaultView.RowFilter = filter;
            dgEmployees.DataSource = dtEmployee.DefaultView;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == new FrmEmployeeAddEdit(null).ShowDialog())
            {
                LoadData();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to edit.", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int employeeId = Convert.ToInt32(dgEmployees.SelectedRows[0].Cells["EmployeeId"].Value);
            Employee employee = EmployeeService.Get(employeeId);
            FrmEmployeeAddEdit frmEmployeeAddEdit = new FrmEmployeeAddEdit(employee);
            if (frmEmployeeAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete the selected employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                int employeeId = Convert.ToInt32(dgEmployees.SelectedRows[0].Cells["EmployeeId"].Value);
                EmployeeService.Delete(employeeId);
                LoadData();
                MessageBox.Show("Employee deleted successfully.", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgEmployees_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgEmployees.Columns[e.ColumnIndex].Name == "HaveSpouse" && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int val))
                {
                    e.Value = (val == 1) ? "Yes" : "No";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
