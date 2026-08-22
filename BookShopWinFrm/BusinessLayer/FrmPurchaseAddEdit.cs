using BookShopWinFrm.DataLayer.Model;
using BookShopWinFrm.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopWinFrm.BusinessLayer
{
    public partial class FrmPurchaseAddEdit : Form
    {
        Purchase purchase;
        DataTable dtPurchaseDetail;
        bool newpurchase;

        public FrmPurchaseAddEdit(Purchase purchase)
        {
            InitializeComponent();
            dgPurchaseDetail.CellValueChanged += dgPurchaseDetail_CellValueChanged;
            dgPurchaseDetail.CurrentCellDirtyStateChanged += dgPurchaseDetail_CurrentCellDirtyStateChanged;

            LoadVendor();
            LoadEmployee();
            LoadItem();

            if (purchase == null)
            {
                this.purchase = new Purchase();
                this.newpurchase = true;
                lblTitle.Text = "Add New Purchase";
                this.Text = "List : New Purchase";
            }
            else
            {
                this.purchase = purchase;
                this.newpurchase = false;
                lblTitle.Text = "Edit Purchase";
                this.Text = "List : Edit Purchase";
            }
            LoadPurchaseData();
        }

        void LoadPurchaseData()
        {
            dgPurchaseDetail.AutoGenerateColumns = false;

            if (newpurchase)
            {
                cmbVendor.SelectedIndex = -1;
                txtRefNumber.Text = "PO-" + DateTime.Now.ToString("yyyyMMdd-HHmm");
                txtRefNumber.ReadOnly = true;
                dtmPurchaseDate.Value = DateTime.Now;
                cmbEmployee.SelectedIndex = -1;
                cmbStatus.SelectedItem = "Completed";
                txtNote.Text = "";

                dtPurchaseDetail = PurchaseService.GetDetail(0);

                DataRow dr = dtPurchaseDetail.NewRow();
                dtPurchaseDetail.Rows.Add(dr);
            }
            else
            {
                cmbVendor.SelectedValue = purchase.VendorId;
                txtRefNumber.Text = purchase.RefNumber;
                dtmPurchaseDate.Value = purchase.PurchaseDate;
                cmbEmployee.SelectedValue = purchase.EmployeeId;

                if (!string.IsNullOrEmpty(purchase.Status))
                {
                    cmbStatus.SelectedItem = purchase.Status;
                }
                else
                {
                    cmbStatus.SelectedItem = "Completed";
                }

                txtNote.Text = purchase.Note;
                dtPurchaseDetail = PurchaseService.GetDetail(purchase.PurchaseId);

                if (!string.IsNullOrEmpty(purchase.Status) && string.Equals(purchase.Status, "Cancelled", StringComparison.OrdinalIgnoreCase))
                {
                    dgPurchaseDetail.ReadOnly = true;
                    cmbVendor.Enabled = false;
                    cmbEmployee.Enabled = false;
                    txtRefNumber.ReadOnly = true;
                    dtmPurchaseDate.Enabled = false;
                    txtNote.ReadOnly = true;
                    cmbStatus.Enabled = false;
                }
            }

            dgPurchaseDetail.DataSource = dtPurchaseDetail;
            UpdateTotalPrice();
        }

        void LoadVendor()
        {
            DataTable dtVendor = VendorService.GetAll();
            cmbVendor.DataSource = dtVendor;
            cmbVendor.DisplayMember = "VendorName";
            cmbVendor.ValueMember = "VendorId";
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

            if (dgPurchaseDetail.Columns["ItemId"] is DataGridViewComboBoxColumn cmbItem)
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
                using (Brush b = new SolidBrush(dgPurchaseDetail.DefaultCellStyle.BackColor))
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
            dgPurchaseDetail.EndEdit();
            dtPurchaseDetail.AcceptChanges();

            if (!DoValidation())
                return;

            decimal grandTotal = CalculatePurchaseTotalFromDataTable();

            if (newpurchase)
            {
                purchase = new Purchase();
                purchase.VendorId = Convert.ToInt32(cmbVendor.SelectedValue);
                purchase.RefNumber = txtRefNumber.Text.Trim();
                purchase.PurchaseDate = dtmPurchaseDate.Value.Date;
                purchase.EmployeeId = Convert.ToInt32(cmbEmployee.SelectedValue);
                purchase.Status = cmbStatus.SelectedItem != null ? cmbStatus.SelectedItem.ToString() : "Completed";
                purchase.Note = txtNote.Text.Trim();
                purchase.TotalAmount = grandTotal;

                int purchaseId = PurchaseService.Add(purchase);
                if (purchaseId > 0)
                {
                    foreach (DataRow dr in dtPurchaseDetail.Rows)
                    {
                        if (!TryGetItemId(dr, out int itemId)) continue;

                        PurchaseDetail detail = new PurchaseDetail();
                        detail.PurchaseId = purchaseId;
                        detail.ItemId = itemId;
                        detail.Description = dr["Description"]?.ToString() ?? "";
                        detail.Quantity = Convert.ToInt32(dr["Quantity"] ?? 0);
                        detail.UnitPrice = Convert.ToDecimal(dr["UnitPrice"] ?? 0);
                        detail.TotalAmount = Convert.ToDecimal(dr["TotalAmount"] ?? 0);

                        PurchaseService.AddDetail(detail);
                    }
                    MessageBox.Show("Purchase order added successfully, and stock increased.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string oldStatus = purchase.Status ?? string.Empty;
                string newStatus = cmbStatus.SelectedItem != null ? cmbStatus.SelectedItem.ToString() : "Completed";
                bool isCancelling = !string.Equals(oldStatus, "Cancelled", StringComparison.OrdinalIgnoreCase)
                    && string.Equals(newStatus, "Cancelled", StringComparison.OrdinalIgnoreCase);

                purchase.VendorId = Convert.ToInt32(cmbVendor.SelectedValue);
                purchase.RefNumber = txtRefNumber.Text.Trim();
                purchase.PurchaseDate = dtmPurchaseDate.Value.Date;
                purchase.EmployeeId = Convert.ToInt32(cmbEmployee.SelectedValue);
                purchase.Status = newStatus;
                purchase.Note = txtNote.Text.Trim();
                purchase.TotalAmount = grandTotal;

                if (isCancelling)
                {
                    PurchaseService.Update(purchase);
                    MessageBox.Show("Purchase cancelled successfully and stock reversed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    PurchaseService.DeleteDetail(purchase.PurchaseId);
                    PurchaseService.Update(purchase);

                    foreach (DataRow dr in dtPurchaseDetail.Rows)
                    {
                        if (!TryGetItemId(dr, out int itemId)) continue;

                        PurchaseDetail detail = new PurchaseDetail();
                        detail.PurchaseId = purchase.PurchaseId;
                        detail.ItemId = itemId;
                        detail.Description = dr["Description"]?.ToString() ?? "";
                        detail.Quantity = Convert.ToInt32(dr["Quantity"] ?? 0);
                        detail.UnitPrice = Convert.ToDecimal(dr["UnitPrice"] ?? 0);
                        detail.TotalAmount = Convert.ToDecimal(dr["TotalAmount"] ?? 0);

                        PurchaseService.AddDetail(detail);
                    }
                    MessageBox.Show("Purchase order updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        bool DoValidation()
        {
            if (!newpurchase && !string.IsNullOrEmpty(purchase.Status) &&
                string.Equals(purchase.Status, "Cancelled", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (cmbVendor.SelectedIndex < 0)
            {
                MessageBox.Show("Vendor is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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

            bool hasValidDetail = false;
            foreach (DataRow row in dtPurchaseDetail.Rows)
            {
                if (!TryGetItemId(row, out int itemId)) continue;

                hasValidDetail = true;
                decimal quantity = Convert.ToDecimal(row["Quantity"] ?? 0);
                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (!hasValidDetail)
            {
                MessageBox.Show("Please add at least one item.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgPurchaseDetail_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgPurchaseDetail.IsCurrentCellDirty)
            {
                dgPurchaseDetail.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private bool _isUpdatingCells = false;

        private void dgPurchaseDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (_isUpdatingCells) return;

            DataGridViewRow row = dgPurchaseDetail.Rows[e.RowIndex];
            string columnName = dgPurchaseDetail.Columns[e.ColumnIndex].Name;

            try
            {
                _isUpdatingCells = true;

                // 1. If user changed the Item dropdown
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
                        // Clear row if user unselected item
                        row.Cells["Description"].Value = "";
                        row.Cells["UnitPrice"].Value = 0m;
                        row.Cells["Quantity"].Value = 0m;
                        row.Cells["TotalAmount"].Value = 0m;
                    }
                }

                // 2. ALWAYS calculate row math if ItemId, Quantity, or UnitPrice changed
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
                // Ensure you use your exact grid column names here ("Quantity", "UnitPrice", "TotalAmount")
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

        private decimal CalculatePurchaseTotalFromDataTable()
        {
            decimal totalAmount = 0m;
            foreach (DataRow row in dtPurchaseDetail.Rows)
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

            if (dgPurchaseDetail != null)
            {
                foreach (DataGridViewRow row in dgPurchaseDetail.Rows)
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

            if (purchase != null)
            {
                purchase.TotalAmount = total;
            }
        }

        private void btnVendorAdd_Click(object sender, EventArgs e)
        {
            FrmVendorAddEdit frmVendorAddEdit = new FrmVendorAddEdit(null);
            if (frmVendorAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadVendor();
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
    }
}