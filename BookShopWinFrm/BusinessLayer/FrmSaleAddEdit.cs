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
    public partial class FrmSaleAddEdit : Form
    {
        Sale sale;
        DataTable dtSaleDetail;
        bool newsale;

        public FrmSaleAddEdit(Sale sale)
        {
            InitializeComponent();
            dgSaleDetail.CellValueChanged += dgSaleDetail_CellValueChanged;
            dgSaleDetail.CurrentCellDirtyStateChanged += dgSaleDetail_CurrentCellDirtyStateChanged;

            LoadCustomer();
            LoadEmployee();
            LoadItem();

            if (sale == null)
            {
                this.sale = new Sale();
                lblTitle.Text = "Add New Sale";
                this.Text = "List : New Sale";
                this.newsale = true;
            }
            else
            {
                this.sale = sale;
                this.newsale = false;
                lblTitle.Text = "Edit Sale";
                this.Text = "List : Edit Sale";
            }
            LoadSale();
        }

        void LoadSale()
        {
            dgSaleDetail.AutoGenerateColumns = false;

            if (newsale)
            {
                cmbCustomer.SelectedIndex = -1;
                dtmSaleDate.Value = DateTime.Now;
                cmbEmployee.SelectedIndex = -1;

                // Setup status items for NEW sale (Hide Cancelled)
                cmbStatus.Items.Clear();
                cmbStatus.Items.Add("Completed");
                cmbStatus.Items.Add("On Hold");
                cmbStatus.SelectedItem = "Completed";

                txtNote.Text = "";
                txtRefNumber.Text = "INV-" + DateTime.Now.ToString("yyyyMMdd-HHmm");
                txtRefNumber.ReadOnly = true;

                dtSaleDetail = SaleService.GetDetail(0);

                DataRow dr = dtSaleDetail.NewRow();
                dtSaleDetail.Rows.Add(dr);
            }
            else
            {
                // Setup status items for EDIT mode (Include Cancelled)
                if (!cmbStatus.Items.Contains("Cancelled"))
                {
                    cmbStatus.Items.Clear();
                    cmbStatus.Items.Add("Completed");
                    cmbStatus.Items.Add("On Hold");
                    cmbStatus.Items.Add("Cancelled");
                }

                cmbCustomer.SelectedValue = sale.CustomerId;
                txtRefNumber.Text = sale.RefNumber;
                dtmSaleDate.Value = sale.SaleDate;
                cmbEmployee.SelectedValue = sale.EmployeeId;

                if (!string.IsNullOrEmpty(sale.Status))
                {
                    cmbStatus.SelectedItem = sale.Status;
                }
                else
                {
                    cmbStatus.SelectedItem = "Completed";
                }

                txtNote.Text = sale.Note;
                dtSaleDetail = SaleService.GetDetail(sale.SaleId);

                if (!string.IsNullOrEmpty(sale.Status) && string.Equals(sale.Status, "Cancelled", StringComparison.OrdinalIgnoreCase))
                {
                    dgSaleDetail.ReadOnly = true;
                    cmbCustomer.Enabled = false;
                    cmbEmployee.Enabled = false;
                    txtRefNumber.ReadOnly = true;
                    dtmSaleDate.Enabled = false;
                    txtNote.ReadOnly = true;
                    cmbStatus.Enabled = false;
                }
            }

            dgSaleDetail.DataSource = dtSaleDetail;
            UpdateTotalPrice();
        }

        void LoadCustomer()
        {
            DataTable dtCustomer = CustomerService.GetAll();
            cmbCustomer.DataSource = dtCustomer;
            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.ValueMember = "CustomerId";
        }
        void LoadEmployee()
        {
            DataTable dtSaleRep = EmployeeService.GetAll();
            cmbEmployee.DataSource = dtSaleRep;
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

            DataGridViewComboBoxColumn cmbItem = dgSaleDetail.Columns["ItemID"] as DataGridViewComboBoxColumn;
            cmbItem.DataSource = dtItem;
            cmbItem.DisplayMember = "ItemName";
            cmbItem.ValueMember = "ItemID";
            cmbItem.DataPropertyName = "ItemId";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgSaleDetail.EndEdit();
            dtSaleDetail.AcceptChanges();

            if (!DoValidation())
                return;

            if (newsale)
            {
                sale = new Sale();
                sale.CustomerId = Convert.ToInt32(cmbCustomer.SelectedValue);
                sale.RefNumber = txtRefNumber.Text.Trim();
                sale.SaleDate = dtmSaleDate.Value.Date;
                sale.EmployeeId = Convert.ToInt32(cmbEmployee.SelectedValue);
                sale.Status = cmbStatus.SelectedItem != null ? cmbStatus.SelectedItem.ToString() : "Completed";
                sale.Note = txtNote.Text.Trim();
                sale.TotalAmount = CalculateSaleTotalFromDataTable();

                int saleid = SaleService.Add(sale);
                if (saleid > 0)
                {
                    int savedDetailCount = 0;
                    foreach (DataRow dr in dtSaleDetail.Rows)
                    {
                        if (!TryGetItemId(dr, out int itemId))
                            continue;

                        SaleDetail saleDetail = new SaleDetail();
                        saleDetail.SaleId = saleid;
                        saleDetail.ItemId = itemId;
                        saleDetail.Description = dr["Description"].ToString();
                        saleDetail.Quantity = Convert.ToInt32(dr["Quantity"] == DBNull.Value ? 0 : dr["Quantity"]);
                        saleDetail.UnitPriceAtSale = Convert.ToDecimal(dr["UnitPriceAtSale"] == DBNull.Value ? 0 : dr["UnitPriceAtSale"]);
                        saleDetail.DiscountAmount = Convert.ToDecimal(dr["DiscountAmount"] == DBNull.Value ? 0 : dr["DiscountAmount"]);
                        saleDetail.Price = Convert.ToDecimal(dr["Price"] == DBNull.Value ? 0 : dr["Price"]);

                        SaleService.AddDetail(saleDetail);
                        savedDetailCount++;
                    }

                    if (savedDetailCount == 0)
                    {
                        MessageBox.Show("Warning: Sale saved but no items were added (all rows were empty).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Sale added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                string oldStatus = sale.Status ?? string.Empty;
                string newStatus = cmbStatus.SelectedItem != null ? cmbStatus.SelectedItem.ToString() : "Completed";
                bool isCancelling = !string.Equals(oldStatus, "Cancelled", StringComparison.OrdinalIgnoreCase)
                    && string.Equals(newStatus, "Cancelled", StringComparison.OrdinalIgnoreCase);

                sale.CustomerId = Convert.ToInt32(cmbCustomer.SelectedValue);
                sale.RefNumber = txtRefNumber.Text.Trim();
                sale.SaleDate = dtmSaleDate.Value.Date;
                sale.EmployeeId = Convert.ToInt32(cmbEmployee.SelectedValue);
                sale.Status = newStatus;
                sale.Note = txtNote.Text.Trim();
                sale.TotalAmount = CalculateSaleTotalFromDataTable();

                if (isCancelling)
                {
                    SaleService.Update(sale);
                    MessageBox.Show("Sale cancelled successfully. Item history preserved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SaleService.DeleteDetail(sale.SaleId);
                    SaleService.Update(sale);

                    int savedDetailCount = 0;
                    foreach (DataRow row in dtSaleDetail.Rows)
                    {
                        if (!TryGetItemId(row, out int itemId))
                            continue;

                        SaleDetail saledetail = new SaleDetail();
                        saledetail.SaleId = sale.SaleId;
                        saledetail.ItemId = itemId;
                        saledetail.Description = row["Description"].ToString();
                        saledetail.Quantity = Convert.ToInt32(row["Quantity"] == DBNull.Value ? 0 : row["Quantity"]);
                        saledetail.UnitPriceAtSale = Convert.ToDecimal(row["UnitPriceAtSale"] == DBNull.Value ? 0 : row["UnitPriceAtSale"]);
                        saledetail.DiscountAmount = Convert.ToDecimal(row["DiscountAmount"] == DBNull.Value ? 0 : row["DiscountAmount"]);
                        saledetail.Price = Convert.ToDecimal(row["Price"] == DBNull.Value ? 0 : row["Price"]);
                        SaleService.AddDetail(saledetail);
                        savedDetailCount++;
                    }

                    if (savedDetailCount == 0)
                    {
                        MessageBox.Show("Warning: Sale updated but no items were added (all rows were empty).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Sale updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        bool DoValidation()
        {
            if (!newsale && !string.IsNullOrEmpty(sale.Status) &&
                string.Equals(sale.Status, "Cancelled", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (cmbCustomer.SelectedIndex < 0)
            {
                MessageBox.Show("Customer is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtRefNumber.Text.Trim() == "")
            {
                MessageBox.Show("Reference Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbEmployee.SelectedIndex < 0)
            {
                MessageBox.Show("Employee is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dtmSaleDate.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Sale Date cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool hasValidDetail = false;
            foreach (DataRow row in dtSaleDetail.Rows)
            {
                if (!TryGetItemId(row, out int itemId))
                    continue;

                hasValidDetail = true;
                decimal quantity = Convert.ToDecimal(row["Quantity"] == DBNull.Value ? 0 : row["Quantity"]);
                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                decimal availableQty = GetAvailableQuantity(itemId);
                if (availableQty <= 0)
                {
                    MessageBox.Show("Selected item is out of stock.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgSaleDetail_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgSaleDetail.IsCurrentCellDirty)
            {
                dgSaleDetail.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private bool _isUpdatingCells = false;
        private void dgSaleDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (_isUpdatingCells) return;

            DataGridViewRow row = dgSaleDetail.Rows[e.RowIndex];
            string columnName = dgSaleDetail.Columns[e.ColumnIndex].Name;

            try
            {
                _isUpdatingCells = true;

                if (columnName == "ItemId")
                {
                    var cellVal = row.Cells["ItemId"].Value;
                    if (cellVal != null && int.TryParse(cellVal.ToString(), out int itemId))
                    {
                        DataTable dtItem = ItemService.GetAll();
                        DataRow[] foundRows = dtItem.Select($"ItemID = {itemId}");

                        if (foundRows.Length > 0)
                        {
                            decimal availableQty = foundRows[0]["Quantity"] != DBNull.Value
                                ? Convert.ToDecimal(foundRows[0]["Quantity"])
                                : 0m;

                            if (availableQty <= 0)
                            {
                                MessageBox.Show("This item is out of stock.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                row.Cells["ItemId"].Value = DBNull.Value;
                                row.Cells["Description"].Value = "";
                                row.Cells["UnitPriceAtSale"].Value = 0m;
                                row.Cells["Quantity"].Value = 0m;
                                row.Cells["DiscountAmount"].Value = 0m;
                                row.Cells["Price"].Value = 0m;
                                UpdateTotalPrice();
                                return;
                            }

                            row.Cells["Description"].Value = foundRows[0]["ItemDescription"]?.ToString() ?? "";
                            row.Cells["UnitPriceAtSale"].Value = foundRows[0]["SalePrice"] != DBNull.Value
                                ? Convert.ToDecimal(foundRows[0]["SalePrice"])
                                : 0m;

                            if (row.Cells["Quantity"].Value == null || row.Cells["Quantity"].Value == DBNull.Value || Convert.ToDecimal(row.Cells["Quantity"].Value) <= 0)
                            {
                                row.Cells["Quantity"].Value = 1m;
                            }
                        }
                    }
                }
                if (columnName == "ItemId" || columnName == "Quantity" || columnName == "DiscountAmount")
                {
                    CalculateRow(row);
                }
            }
            finally
            {
                _isUpdatingCells = false;
            }
        }

        private decimal CalculateSaleTotalFromDataTable()
        {
            decimal totalAmount = 0m;
            foreach (DataRow row in dtSaleDetail.Rows)
            {
                if (!TryGetItemId(row, out _))
                    continue;

                decimal price = Convert.ToDecimal(row["Price"] == DBNull.Value ? 0 : row["Price"]);
                totalAmount += price;
            }
            return totalAmount;
        }

        private bool TryGetItemId(DataRow row, out int itemId)
        {
            itemId = 0;
            string itemColumn = row.Table.Columns.Contains("ItemId") ? "ItemId" : (row.Table.Columns.Contains("ItemID") ? "ItemID" : null);
            if (itemColumn == null || row[itemColumn] == DBNull.Value || row[itemColumn] == null)
                return false;

            return int.TryParse(row[itemColumn].ToString(), out itemId);
        }

        private decimal GetAvailableQuantity(int itemId)
        {
            Item item = ItemService.Get(itemId);
            if (item == null)
                return 0m;
            return item.Quantity;
        }

        private void UpdateTotalPrice()
        {
            decimal total = 0m;

            if (dgSaleDetail != null)
            {
                foreach (DataGridViewRow row in dgSaleDetail.Rows)
                {
                    if (row.IsNewRow) continue;
                    var val = row.Cells["Price"].Value; if (val != null && val != DBNull.Value && decimal.TryParse(val.ToString(), out var price)) { total += price; }
                }
            }

            if (lblTotalPrice != null)
            {
                lblTotalPrice.Text = $"$ {total:0.00}";
            }

            if (sale != null)
            {
                sale.TotalAmount = total;
            }
        }

        private void CalculateRow(DataGridViewRow row)
        {
            try
            {
                decimal qty = Convert.ToDecimal(row.Cells["Quantity"].Value ?? 0);
                decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPriceAtSale"].Value ?? 0);

                decimal discountPercetage = GetCurrentCustomerDiscount();
                decimal grossTotal = qty * unitPrice;

                decimal calcualtedDiscountAmount = grossTotal * discountPercetage / 100m;
                row.Cells["DiscountAmount"].Value = calcualtedDiscountAmount;

                decimal netPrice = grossTotal - calcualtedDiscountAmount;
                row.Cells["Price"].Value = netPrice > 0 ? netPrice : 0;

                UpdateTotalPrice();
            }
            catch
            {
                // Handle any exceptions that may occur during the calculation
            }

        }
        private decimal GetCurrentCustomerDiscount()
        {
            try
            {
                if (cmbCustomer == null || cmbCustomer.IsDisposed) return 0m;
                if (cmbCustomer.SelectedItem == null) return 0m;
                if (cmbCustomer.SelectedItem is DataRowView rowView)
                {
                    if (rowView.Row != null && rowView.Row.Table.Columns.Contains("MemberDiscount"))
                    {
                        var val = rowView["MemberDiscount"];
                        if (val != null && val != DBNull.Value)
                        {
                            return Convert.ToDecimal(val);
                        }
                    }
                }
            }
            catch
            {
                // Suppress any binding cast exceptions during dropdown initialization
            }
            return 0m;
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgSaleDetail == null || dgSaleDetail.Rows.Count == 0) return;
            foreach (DataGridViewRow row in dgSaleDetail.Rows)
            {
                if (row.IsNewRow) continue;
                CalculateRow(row);
            }

            UpdateTotalPrice();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            FrmCustomerAddEdit frmCustomerAddEdit = new FrmCustomerAddEdit(null);

            if (frmCustomerAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadCustomer();
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
