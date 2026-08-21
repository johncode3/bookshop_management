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
    public partial class FrmPurchase : Form
    {
        DataTable dtPurchase;
        public FrmPurchase()
        {
            InitializeComponent();
        }

        private void FrmPurchase_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dtPurchase = PurchaseService.GetAll();
            dgPurchases.DataSource = dtPurchase;

            if (dgPurchases.Columns.Contains("PurchaseId"))
            {
                dgPurchases.Columns["PurchaseId"].Visible = false;
            }
            if (dgPurchases.Columns.Contains("CustomerId"))
            {
                dgPurchases.Columns["CustomerId"].Visible = false;
            }
            if (dgPurchases.Columns.Contains("EmployeeId"))
            {
                dgPurchases.Columns["EmployeeId"].Visible = false;
            }

            if (!dgPurchases.Columns.Contains("No"))
            {
                DataGridViewTextBoxColumn colNo = new DataGridViewTextBoxColumn();
                colNo.Name = "No";
                colNo.HeaderText = "No.";
                colNo.Width = 50;
                colNo.DisplayIndex = 0;
                dgPurchases.Columns.Insert(0, colNo);
            }
            else
            {
                dgPurchases.Columns["No"].DisplayIndex = 0;
            }

            dgPurchases.Sort(dgPurchases.Columns["PurchaseId"], ListSortDirection.Descending);

            dgPurchases.Columns["PurchaseDate"].HeaderText = "Date";
            dgPurchases.Columns["PurchaseDate"].Width = 150;
            dgPurchases.Columns["PurchaseDate"].DefaultCellStyle.Format = "dd/MMM/yyyy";
            dgPurchases.Columns["PurchaseDate"].Visible = true;
            dgPurchases.Columns["RefNumber"].DisplayIndex = 1;

            dgPurchases.Columns["RefNumber"].HeaderText = "RefNumber";
            dgPurchases.Columns["RefNumber"].Width = 150;
            dgPurchases.Columns["RefNumber"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgPurchases.Columns["RefNumber"].Visible = true;
            dgPurchases.Columns["RefNumber"].DisplayIndex = 2;

            dgPurchases.Columns["VendorId"].Visible = false;
            dgPurchases.Columns["VendorName"].DisplayIndex = 3;

            dgPurchases.Columns["VendorName"].HeaderText = "Vendor";
            dgPurchases.Columns["VendorName"].Width = 200;
            dgPurchases.Columns["VendorName"].Visible = true;
            dgPurchases.Columns["VendorName"].DisplayIndex = 4;

            dgPurchases.Columns["EmployeeId"].Visible = false;
            dgPurchases.Columns["EmployeeName"].DisplayIndex = 5;

            dgPurchases.Columns["EmployeeName"].HeaderText = "Employee";
            dgPurchases.Columns["EmployeeName"].Width = 200;
            dgPurchases.Columns["EmployeeName"].Visible = true;
            dgPurchases.Columns["EmployeeName"].DisplayIndex = 5;

            dgPurchases.Columns["TotalAmount"].HeaderText = "Total Amount";
            dgPurchases.Columns["TotalAmount"].Width = 150;
            dgPurchases.Columns["TotalAmount"].Visible = true;
            dgPurchases.Columns["TotalAmount"].DisplayIndex = 6;

            dgPurchases.Columns["Status"].HeaderText = "Status";
            dgPurchases.Columns["Status"].Width = 100;
            dgPurchases.Columns["Status"].Visible = true;
            dgPurchases.Columns["Status"].DisplayIndex = 7;

            dgPurchases.Columns["Note"].HeaderText = "Note";
            dgPurchases.Columns["Note"].Width = 300;
            dgPurchases.Columns["Note"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgPurchases.Columns["Note"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgPurchases.Columns["Note"].Visible = true;
            dgPurchases.Columns["Note"].DisplayIndex = 8;
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
                    using (Brush b = new SolidBrush(dgPurchases.DefaultCellStyle.BackColor))
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
            if (dtPurchase == null)
                return;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                dtPurchase.DefaultView.RowFilter = string.Empty;
                dgPurchases.DataSource = dtPurchase;
                return;
            }
            string s = searchText.Trim().Replace("'", "''");
            string filter = $"VendorName LIKE '%{s}%' OR RefNumber LIKE '%{s}%' OR EmployeeName LIKE '%{s}%'";

            dtPurchase.DefaultView.RowFilter = filter;
            dgPurchases.DataSource = dtPurchase.DefaultView;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmPurchaseAddEdit frmAddEdit = new FrmPurchaseAddEdit();
            if (frmAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgPurchases.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a purchase first to edit.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int purchaseid = Convert.ToInt32(dgPurchases.SelectedRows[0].Cells["PurchaseId"].Value.ToString());
            Purchase purchase = PurchaseService.Get(purchaseid);
            FrmPurchaseAddEdit frmAddEdit = new FrmPurchaseAddEdit();
            if (frmAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgPurchases.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a purchase first to cancel.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Confirmation!\nDo you really want to cancel this purchase?", "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                int purchaseid = Convert.ToInt32(dgPurchases.SelectedRows[0].Cells["PurchaseId"].Value);
                Purchase purchase = PurchaseService.Get(purchaseid);

                if (purchase == null)
                {
                    MessageBox.Show("Purchase not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                purchase.Status = "Cancelled";
                PurchaseService.Delete(purchase);
                MessageBox.Show("Purchase cancelled successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
            }
        }
    }
}
