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
    public partial class FrmInventoryAdjustmentAddEdit : Form
    {
        InventoryAdjustment inventoryAdjustment;
        DataTable dtInventoryAdjustmentDetail;
        bool newInventoryAdjustment;
        public FrmInventoryAdjustmentAddEdit(InventoryAdjustment inventoryAdjustment)
        {
            InitializeComponent();
            dgInvAdjDetail.CellValueChanged += dgInvAdjDetail_CellValueChanged;
            dgInvAdjDetail.CurrentCellDirtyStateChanged += dgInvAdjDetail_CurrentCellDirtyStateChanged;
            dgInvAdjDetail.DataError += dgInvAdjDetail_DataError;

            LoadEmployee();
            LoadItem();

            if (inventoryAdjustment == null)
            {
                this.inventoryAdjustment = new InventoryAdjustment();
                this.newInventoryAdjustment = true;
                lblTitle.Text = "Add New Inventory Adjustment";
                this.Text = "List : New Purchase";
            }
            else
            {
                this.inventoryAdjustment = inventoryAdjustment;
                this.newInventoryAdjustment = false;
                lblTitle.Text = "Edit Inventory Adjustment";
                this.Text = "List : Edit Inventory Adjustment";
            }
            LoadInventoryAdjustmentData();
        }
        void LoadInventoryAdjustmentData()
        {
            dgInvAdjDetail.AutoGenerateColumns = false;

            if (newInventoryAdjustment)
            {
                txtRefNumber.Text = "INV-ADJ-" + DateTime.Now.ToString("yyyyMMdd-HHmm");
                txtRefNumber.ReadOnly = true;
                dtmInvAdjDate.Value = DateTime.Now;
                cmbEmployee.SelectedIndex = -1;
                txtNote.Text = "";

                dtInventoryAdjustmentDetail = InventoryAdjustmentService.GetDetail(0);

                DataRow dr = dtInventoryAdjustmentDetail.NewRow();
                dtInventoryAdjustmentDetail.Rows.Add(dr);
            }
            else
            {
                txtRefNumber.ReadOnly = true;
                txtRefNumber.Text = inventoryAdjustment.RefNumber;
                dtmInvAdjDate.Value = inventoryAdjustment.AdjustmentDate;
                cmbEmployee.SelectedValue = inventoryAdjustment.EmployeeId;
                txtNote.Text = inventoryAdjustment.Note;
                dtInventoryAdjustmentDetail = InventoryAdjustmentService.GetDetail(inventoryAdjustment.InventoryAdjustmentId);
            }

            dgInvAdjDetail.DataSource = dtInventoryAdjustmentDetail;
            UpdateTotalPrice();
        }
        void LoadEmployee()
        {
            DataTable dtEmp = EmployeeService.GetAll();
            cmbEmployee.DataSource = dtEmp;
            cmbEmployee.DisplayMember = "EmployeeName";
            cmbEmployee.ValueMember = "EmployeeId";
        }
        void LoadItem()
        {
            DataTable dtItem = ItemService.GetAll();

            DataRow emptyRow = dtItem.NewRow();
            emptyRow["ItemID"] = DBNull.Value;
            emptyRow["ItemName"] = "-- Select Item --";
            dtItem.Rows.InsertAt(emptyRow, 0);

            if (dgInvAdjDetail.Columns["ItemId"] is DataGridViewComboBoxColumn cmbItem)
            {
                cmbItem.DataSource = dtItem;
                cmbItem.DisplayMember = "ItemName";
                cmbItem.ValueMember = "ItemId";
                cmbItem.DataPropertyName = "ItemId";
            }
        }
        private void dgPurchaseDetail_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                e.Handled = true;
                using (Brush b = new SolidBrush(dgInvAdjDetail.DefaultCellStyle.BackColor))
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgInvAdjDetail.EndEdit();
            dtInventoryAdjustmentDetail.AcceptChanges();

            if (!DoValidation())
                return;

            decimal grandTotal = CalculateInventoryAdjustmentTotalFromDataTable();

            if (newInventoryAdjustment)
            {
                inventoryAdjustment = new InventoryAdjustment();
                inventoryAdjustment.RefNumber = txtRefNumber.Text.Trim();
                inventoryAdjustment.AdjustmentDate = dtmInvAdjDate.Value.Date;
                inventoryAdjustment.EmployeeId = Convert.ToInt32(cmbEmployee.SelectedValue);
                inventoryAdjustment.Note = txtNote.Text.Trim();

                int inventoryAdjustmentId = InventoryAdjustmentService.Add(inventoryAdjustment);
                if (inventoryAdjustmentId > 0)
                {
                    foreach (DataRow dr in dtInventoryAdjustmentDetail.Rows)
                    {
                        if (!TryGetItemId(dr, out int itemId)) continue;

                        InventoryAdjustmentDetail detail = new InventoryAdjustmentDetail();
                        detail.InventoryAdjustmentId = inventoryAdjustmentId;
                        detail.ItemId = itemId;
                        detail.Description = dr["Description"]?.ToString() ?? "";
                        detail.Quantity = Convert.ToInt32(dr["Quantity"] ?? 0);
                        detail.UnitPrice = Convert.ToDecimal(dr["UnitPrice"] ?? 0);
                        detail.TotalAmount = Convert.ToDecimal(dr["TotalAmount"] ?? 0);

                        InventoryAdjustmentService.AddDetail(detail);
                    }
                    MessageBox.Show("Inventory adjustment added successfully, and stock updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                InventoryAdjustmentService.DeleteDetail(inventoryAdjustment.InventoryAdjustmentId);
                InventoryAdjustmentService.Update(inventoryAdjustment);

                foreach (DataRow dr in dtInventoryAdjustmentDetail.Rows)
                {
                    if (!TryGetItemId(dr, out int itemId)) continue;

                    InventoryAdjustmentDetail detail = new InventoryAdjustmentDetail();
                    detail.InventoryAdjustmentId = inventoryAdjustment.InventoryAdjustmentId;
                    detail.ItemId = itemId;
                    detail.Description = dr["Description"]?.ToString() ?? "";
                    detail.Quantity = Convert.ToInt32(dr["Quantity"] ?? 0);
                    detail.UnitPrice = Convert.ToDecimal(dr["UnitPrice"] ?? 0);
                    detail.TotalAmount = Convert.ToDecimal(dr["TotalAmount"] ?? 0);

                    InventoryAdjustmentService.AddDetail(detail);
                }
                MessageBox.Show("Inventory adjustment updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        bool DoValidation()
        {
            if (string.IsNullOrWhiteSpace(txtRefNumber.Text))
            {
                MessageBox.Show("Reference Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbEmployee.SelectedIndex < 0)
            {
                MessageBox.Show("Employee is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool TryGetItemId(DataRow row, out int itemId)
        {
            itemId = 0;
            string itemColumn = row.Table.Columns.Contains("ItemId") ? "ItemId" : (row.Table.Columns.Contains("ItemID") ? "ItemID" : null);
            if (itemColumn == null || row[itemColumn] == DBNull.Value || row[itemColumn] == null)
                return false;

            return int.TryParse(row[itemColumn].ToString(), out itemId);
        }

        private void dgInvAdjDetail_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgInvAdjDetail.IsCurrentCellDirty)
            {
                dgInvAdjDetail.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private bool _isUpdatingCells = false;

        private void dgInvAdjDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)

        {
            if (e.RowIndex < 0) return;
            if (_isUpdatingCells) return;

            DataGridViewRow row = dgInvAdjDetail.Rows[e.RowIndex];
            string columnName = dgInvAdjDetail.Columns[e.ColumnIndex].Name;

            try
            {
                _isUpdatingCells = true;

                if (columnName == "ItemId")
                {
                    var cellVal = row.Cells["ItemId"].Value;
                    if (cellVal != null && int.TryParse(cellVal.ToString(), out int itemId))
                    {
                        DataTable dtItem = ItemService.GetAll();
                        DataRow[] foundRows = dtItem.Select($"ItemId = {itemId}");

                        if (foundRows.Length > 0)
                        {
                            row.Cells["Description"].Value = foundRows[0]["ItemDescription"]?.ToString() ?? "";
                            row.Cells["UnitPrice"].Value = foundRows[0]["SalePrice"] != DBNull.Value ? Convert.ToDecimal(foundRows[0]["SalePrice"]) : 0m;

                            if (row.Cells["Quantity"].Value == null || row.Cells["Quantity"].Value == DBNull.Value || Convert.ToDecimal(row.Cells["Quantity"].Value) <= 0)
                            {
                                row.Cells["Quantity"].Value = 1m;
                            }
                        }
                    }
                    else
                    {
                        row.Cells["Description"].Value = "";
                        row.Cells["UnitPrice"].Value = 0m;
                        row.Cells["Quantity"].Value = 0m;
                        row.Cells["TotalAmount"].Value = 0m;
                    }
                }
                CalculateRow(row);
            }
            finally
            {
                _isUpdatingCells = false;
            }
        }

        private void CalculateRow(DataGridViewRow row)
        {
            try
            {
                decimal qty = Convert.ToDecimal(row.Cells["Quantity"].Value ?? 0);
                decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value ?? 0);
                decimal totalAmount = qty * unitPrice;

                row.Cells["TotalAmount"].Value = totalAmount;

                UpdateTotalPrice();
            }
            catch
            {
                // Suppress typing exceptions
            }
        }

        private decimal CalculateInventoryAdjustmentTotalFromDataTable()
        {
            decimal totalAmount = 0m;
            foreach (DataRow row in dtInventoryAdjustmentDetail.Rows)
            {
                if (!TryGetItemId(row, out _)) continue;
                decimal amount = Convert.ToDecimal(row["TotalAmount"] == DBNull.Value ? 0 : row["TotalAmount"]);
                totalAmount += amount;
            }
            return totalAmount;
        }

        private void UpdateTotalPrice()
        {
            decimal total = 0m;

            if (dgInvAdjDetail != null)
            {
                foreach (DataGridViewRow row in dgInvAdjDetail.Rows)
                {
                    if (row.IsNewRow) continue;
                    var val = row.Cells["TotalAmount"].Value;
                    if (val != null && val != DBNull.Value && decimal.TryParse(val.ToString(), out var amount))
                    {
                        total += amount;
                    }
                }
            }

            if (lblTotalPrice != null)
            {
                lblTotalPrice.Text = $"$ {total:0.00}";
            }
        }
        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            FrmEmployeeAddEdit frmEmployeeAddEdit = new FrmEmployeeAddEdit(null);
            if (frmEmployeeAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadEmployee();
            }
        }

        private void dgInvAdjDetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
