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
    public partial class FrmSale : Form
    {
        DataTable dtSale;
        public FrmSale()
        {
            InitializeComponent();
        }

        private void FrmSale_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dtSale = SaleService.GetAll();
            dgSales.DataSource = dtSale;

            if (dgSales.Columns.Contains("SaleId"))
            {
                dgSales.Columns["SaleId"].Visible = false;
            }
            if (dgSales.Columns.Contains("CustomerId"))
            {
                dgSales.Columns["CustomerId"].Visible = false;
            }
            if (dgSales.Columns.Contains("EmployeeId"))
            {
                dgSales.Columns["EmployeeId"].Visible = false;
            }

            if (!dgSales.Columns.Contains("No"))
            {
                DataGridViewTextBoxColumn colNo = new DataGridViewTextBoxColumn();
                colNo.Name = "No";
                colNo.HeaderText = "No.";
                colNo.Width = 50;
                colNo.DisplayIndex = 0;
                dgSales.Columns.Insert(0, colNo);
            }
            else
            {
                dgSales.Columns["No"].DisplayIndex = 0;
            }

            dgSales.Sort(dgSales.Columns["SaleId"], ListSortDirection.Descending);


            dgSales.Columns["SaleDate"].HeaderText = "Date";
            dgSales.Columns["SaleDate"].Width = 150;
            dgSales.Columns["SaleDate"].DefaultCellStyle.Format = "dd/MMM/yyyy";
            dgSales.Columns["SaleDate"].Visible = true;
            dgSales.Columns["SaleDate"].DisplayIndex = 1;

            dgSales.Columns["RefNumber"].HeaderText = "RefNumber";
            dgSales.Columns["RefNumber"].Width = 150;
            dgSales.Columns["RefNumber"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgSales.Columns["RefNumber"].Visible = true;
            dgSales.Columns["RefNumber"].DisplayIndex = 2;

            dgSales.Columns["CustomerId"].Visible = false;
            dgSales.Columns["CustomerName"].DisplayIndex = 3;

            dgSales.Columns["CustomerName"].HeaderText = "Customer";
            dgSales.Columns["CustomerName"].Width = 200;
            dgSales.Columns["CustomerName"].Visible = true;
            dgSales.Columns["CustomerName"].DisplayIndex = 4;

            dgSales.Columns["EmployeeId"].Visible = false;
            dgSales.Columns["EmployeeName"].DisplayIndex = 5;

            dgSales.Columns["EmployeeName"].HeaderText = "Employee";
            dgSales.Columns["EmployeeName"].Width = 200;
            dgSales.Columns["EmployeeName"].Visible = true;
            dgSales.Columns["EmployeeName"].DisplayIndex = 5;

            dgSales.Columns["TotalAmount"].HeaderText = "Total Amount";
            dgSales.Columns["TotalAmount"].Width = 150;
            dgSales.Columns["TotalAmount"].Visible = true;
            dgSales.Columns["TotalAmount"].DisplayIndex = 6;

            dgSales.Columns["Status"].HeaderText = "Status";
            dgSales.Columns["Status"].Width = 100;
            dgSales.Columns["Status"].Visible = true;
            dgSales.Columns["Status"].DisplayIndex = 7;

            dgSales.Columns["Note"].HeaderText = "Note";
            dgSales.Columns["Note"].Width = 300;
            dgSales.Columns["Note"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSales.Columns["Note"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgSales.Columns["Note"].Visible = true;
            dgSales.Columns["Note"].DisplayIndex = 8;
        }
        private void dgCustomers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void dgSales_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 & e.ColumnIndex > -1)
            {
                {
                    e.Handled = true;
                    using (Brush b = new SolidBrush(dgSales.DefaultCellStyle.BackColor))
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmSaleAddEdit frmAddEdit = new FrmSaleAddEdit(null);
            if (frmAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgSales.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a sale first to edit.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int saleid = Convert.ToInt32(dgSales.SelectedRows[0].Cells["SaleId"].Value.ToString());
            Sale sale = SaleService.Get(saleid);
            FrmSaleAddEdit frmAddEdit = new FrmSaleAddEdit(sale);
            if (frmAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgSales.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a sale first to cancel.","System",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Confirmation!\nDo you really want to cancel this sale?","Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                int saleid = Convert.ToInt32(dgSales.SelectedRows[0].Cells["SaleId"].Value);
                Sale sale = SaleService.Get(saleid);

                if (sale == null)
                {
                    MessageBox.Show("Sale not found.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                sale.Status = "Cancelled";
                SaleService.Delete(sale);
                MessageBox.Show("Sale cancelled successfully.","Information", MessageBoxButtons.OK,MessageBoxIcon.Information);

                LoadData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search(txtSearch.Text.Trim());
        }
        private void Search(string searchText)
        {
            if (dtSale == null)
                return;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                dtSale.DefaultView.RowFilter = string.Empty;
                dgSales.DataSource = dtSale;
                return;
            }
            string s = searchText.Trim().Replace("'", "''");
            string filter = $"CustomerName LIKE '%{s}%' OR RefNumber LIKE '%{s}%' OR EmployeeName LIKE '%{s}%'";

            dtSale.DefaultView.RowFilter = filter;
            dgSales.DataSource = dtSale.DefaultView;
        }
    }
}
