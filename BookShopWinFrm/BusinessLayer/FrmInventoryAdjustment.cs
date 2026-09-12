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
    public partial class FrmInventoryAdjustment : Form
    {
        DataTable dtInventoryAdjustment;

        public DataTable UserPermissions { get; set; }

        public FrmInventoryAdjustment()
        {
            InitializeComponent();
            this.VisibleChanged += FrmInventoryAdjustment_VisibleChanged;
        }

        private void FrmInventoryAdjustment_Load(object sender, EventArgs e)
        {
            LoadData();
            ApplyPermissions();
        }

        private void FrmInventoryAdjustment_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadData();
                ApplyPermissions();
            }
        }

        private void ApplyPermissions()
        {
            if (FrmMain.CurrentUser?.IsAdmin == true)
            {
                btnAdd.Visible = true;
                btnEdit.Visible = true;
                return;
            }

            btnAdd.Visible = false;
            btnEdit.Visible = false;

            if (this.UserPermissions == null || this.UserPermissions.Rows.Count == 0)
                return;

            foreach (DataRow row in this.UserPermissions.Rows)
            {
                string permName = row["PermissionName"].ToString();

                if (permName == "InventoryAdjustmentCreate")
                    btnAdd.Visible = true;
                else if (permName == "InventoryAdjustmentModify")
                    btnEdit.Visible = true;
            }
        }
        private void LoadData()
        {
            dtInventoryAdjustment = InventoryAdjustmentService.GetAll();
            dgInventoryAdjDetail.DataSource = dtInventoryAdjustment;

            if (dgInventoryAdjDetail.Columns.Contains("InventoryAdjustmentId"))
            {
                dgInventoryAdjDetail.Columns["InventoryAdjustmentId"].Visible = false;
            }
            if (dgInventoryAdjDetail.Columns.Contains("EmployeeId"))
            {
                dgInventoryAdjDetail.Columns["EmployeeId"].Visible = false;
            }
            if (!dgInventoryAdjDetail.Columns.Contains("No"))
            {
                DataGridViewTextBoxColumn colNo = new DataGridViewTextBoxColumn();
                colNo.Name = "No";
                colNo.HeaderText = "No.";
                colNo.Width = 50;
                colNo.DisplayIndex = 0;
                dgInventoryAdjDetail.Columns.Insert(0, colNo);
            }
            else
            {
                dgInventoryAdjDetail.Columns["No"].DisplayIndex = 0;
            }

            if (dtInventoryAdjustment.Rows.Count > 0 && dgInventoryAdjDetail.Columns.Contains("InventoryAdjustmentId"))
            {
                dgInventoryAdjDetail.Sort(dgInventoryAdjDetail.Columns["InventoryAdjustmentId"], ListSortDirection.Descending);
            }

            dgInventoryAdjDetail.Columns["AdjustmentDate"].HeaderText = "Date";
            dgInventoryAdjDetail.Columns["AdjustmentDate"].Width = 150;
            dgInventoryAdjDetail.Columns["AdjustmentDate"].DefaultCellStyle.Format = "dd/MMM/yyyy";
            dgInventoryAdjDetail.Columns["AdjustmentDate"].DisplayIndex = 1;

            dgInventoryAdjDetail.Columns["RefNumber"].HeaderText = "Ref Number";
            dgInventoryAdjDetail.Columns["RefNumber"].Width = 200;
            dgInventoryAdjDetail.Columns["RefNumber"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgInventoryAdjDetail.Columns["RefNumber"].DisplayIndex = 2;

            dgInventoryAdjDetail.Columns["EmployeeName"].HeaderText = "Employee";
            dgInventoryAdjDetail.Columns["EmployeeName"].Width = 200;
            dgInventoryAdjDetail.Columns["EmployeeName"].DisplayIndex = 3;

            dgInventoryAdjDetail.Columns["Note"].HeaderText = "Note";
            dgInventoryAdjDetail.Columns["Note"].Width = 300;
            dgInventoryAdjDetail.Columns["Note"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgInventoryAdjDetail.Columns["Note"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgInventoryAdjDetail.Columns["Note"].DisplayIndex = 4;
        }
        private void dgPurchases_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
        private void dgPurchases_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 & e.ColumnIndex > -1)
            {
                {
                    e.Handled = true;
                    using (Brush b = new SolidBrush(dgInventoryAdjDetail.DefaultCellStyle.BackColor))
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
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search(txtSearch.Text.Trim());
        }
        private void Search(string searchText)
        {
            if (dtInventoryAdjustment == null)
                return;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                dtInventoryAdjustment.DefaultView.RowFilter = string.Empty;
                dgInventoryAdjDetail.DataSource = dtInventoryAdjustment;
                return;
            }
            string s = searchText.Trim().Replace("'", "''");
            string filter = $"VendorName LIKE '%{s}%' OR RefNumber LIKE '%{s}%' OR EmployeeName LIKE '%{s}%'";

            dtInventoryAdjustment.DefaultView.RowFilter = filter;
            dgInventoryAdjDetail.DataSource = dtInventoryAdjustment.DefaultView;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmInventoryAdjustmentAddEdit frmAddEdit = new FrmInventoryAdjustmentAddEdit(null);
            if (frmAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                RefreshOpenedItemForm();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgInventoryAdjDetail.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select an inventory adjustment first to edit.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int inventoryadjustmentid = Convert.ToInt32(dgInventoryAdjDetail.SelectedRows[0].Cells["InventoryAdjustmentId"].Value.ToString());
            InventoryAdjustment inventoryAdjustment = InventoryAdjustmentService.Get(inventoryadjustmentid);
            FrmInventoryAdjustmentAddEdit frmAddEdit = new FrmInventoryAdjustmentAddEdit(inventoryAdjustment);
            if (frmAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                RefreshOpenedItemForm();
            }
        }

        private void RefreshOpenedItemForm()
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmItem itemForm)
                {
                    itemForm.RefreshItems();
                    break;
                }
            }
        }
    }
}
