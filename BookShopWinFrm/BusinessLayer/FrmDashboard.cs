using BookShopWinFrm.DataLayer.Model;
using BookShopWinFrm.DataLayer.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BookShopWinFrm.BusinessLayer
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            this.VisibleChanged += FrmDashboard_VisibleChanged;
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardMetrics();
            LoadRecentSales();
        }

        private void LoadDashboardMetrics()
        {
            try
            {
                DataTable dtSales = SaleService.GetAll();
                decimal totalRevenue = 0;
                foreach (DataRow row in dtSales.Rows)
                {
                    if (row["TotalAmount"] != DBNull.Value)
                    {
                        totalRevenue += Convert.ToDecimal(row["TotalAmount"]);
                    }
                }
                lblTotalRevenue.Text = $"$ {totalRevenue:N2}";

                DataTable dtItems = ItemService.GetAll();
                decimal totalStock = 0;
                foreach (DataRow row in dtItems.Rows)
                {
                    if (row["Quantity"] != DBNull.Value)
                    {
                        totalStock += Convert.ToDecimal(row["Quantity"]);
                    }
                }
                lblTotalStock.Text = totalStock.ToString("N0");

                DataTable dtCust = CustomerService.GetAll();
                lblTotalCustomers.Text = dtCust.Rows.Count.ToString();

                DataTable dtEmp = EmployeeService.GetAll();
                lblTotalEmployees.Text = dtEmp.Rows.Count.ToString();
            }
            catch
            {
                // Suppress metrics errors
            }
        }

        private void LoadRecentSales()
        {
            DataTable dtSales = SaleService.GetAll();
            dgRecentSales.DataSource = dtSales;

            if (dgRecentSales.Columns.Contains("SaleId"))
            {
                dgRecentSales.Columns["SaleId"].Visible = false;
            }
            if (dgRecentSales.Columns.Contains("CustomerId"))
            {
                dgRecentSales.Columns["CustomerId"].Visible = false;
            }
            if (dgRecentSales.Columns.Contains("EmployeeId"))
            {
                dgRecentSales.Columns["EmployeeId"].Visible = false;
            }

            if (!dgRecentSales.Columns.Contains("No"))
            {
                DataGridViewTextBoxColumn colNo = new DataGridViewTextBoxColumn();
                colNo.Name = "No";
                colNo.HeaderText = "No.";
                colNo.Width = 50;
                colNo.DisplayIndex = 0;
                dgRecentSales.Columns.Insert(0, colNo);
            }
            else
            {
                dgRecentSales.Columns["No"].DisplayIndex = 0;
            }

            dgRecentSales.Sort(dgRecentSales.Columns["SaleId"], ListSortDirection.Descending);


            dgRecentSales.Columns["SaleDate"].HeaderText = "Date";
            dgRecentSales.Columns["SaleDate"].Width = 150;
            dgRecentSales.Columns["SaleDate"].DefaultCellStyle.Format = "dd/MMM/yyyy";
            dgRecentSales.Columns["SaleDate"].Visible = true;
            dgRecentSales.Columns["SaleDate"].DisplayIndex = 1;

            dgRecentSales.Columns["RefNumber"].HeaderText = "RefNumber";
            dgRecentSales.Columns["RefNumber"].Width = 150;
            dgRecentSales.Columns["RefNumber"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgRecentSales.Columns["RefNumber"].Visible = true;
            dgRecentSales.Columns["RefNumber"].DisplayIndex = 2;

            dgRecentSales.Columns["CustomerId"].Visible = false;
            dgRecentSales.Columns["CustomerName"].DisplayIndex = 3;

            dgRecentSales.Columns["CustomerName"].HeaderText = "Customer";
            dgRecentSales.Columns["CustomerName"].Width = 200;
            dgRecentSales.Columns["CustomerName"].Visible = true;
            dgRecentSales.Columns["CustomerName"].DisplayIndex = 4;

            dgRecentSales.Columns["EmployeeId"].Visible = false;
            dgRecentSales.Columns["EmployeeName"].DisplayIndex = 5;

            dgRecentSales.Columns["EmployeeName"].HeaderText = "Employee";
            dgRecentSales.Columns["EmployeeName"].Width = 200;
            dgRecentSales.Columns["EmployeeName"].Visible = true;
            dgRecentSales.Columns["EmployeeName"].DisplayIndex = 5;

            dgRecentSales.Columns["TotalAmount"].HeaderText = "Total Amount";
            dgRecentSales.Columns["TotalAmount"].Width = 150;
            dgRecentSales.Columns["TotalAmount"].Visible = true;
            dgRecentSales.Columns["TotalAmount"].DisplayIndex = 6;

            dgRecentSales.Columns["Status"].HeaderText = "Status";
            dgRecentSales.Columns["Status"].Width = 100;
            dgRecentSales.Columns["Status"].Visible = true;
            dgRecentSales.Columns["Status"].DisplayIndex = 7;

            dgRecentSales.Columns["Note"].HeaderText = "Note";
            dgRecentSales.Columns["Note"].Width = 300;
            dgRecentSales.Columns["Note"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgRecentSales.Columns["Note"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgRecentSales.Columns["Note"].Visible = true;
            dgRecentSales.Columns["Note"].DisplayIndex = 8;
        }

        private void FrmDashboard_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadDashboardMetrics();
                LoadRecentSales();
            }
        }

        private void dgRecentSales_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                e.Handled = true;
                using (Brush b = new SolidBrush(dgRecentSales.DefaultCellStyle.BackColor))
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

        private void dgRecentSales_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
    }
}