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
    public partial class FrmVendor : Form
    {
        DataTable dtVendor;

        public FrmVendor()
        {
            InitializeComponent();
        }

        private void FrmVendor_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dtVendor = VendorService.GetAll();
            dgVendors.DataSource = dtVendor;
            if (dgVendors.Columns.Contains("IsDeleted"))
            {
                dgVendors.Columns["IsDeleted"].Visible = false;
            }
            if (dgVendors.Columns.Contains("VendorId"))
            {
                dgVendors.Columns["VendorId"].Visible = false;
            }

            if (!dgVendors.Columns.Contains("No"))
            {
                DataGridViewTextBoxColumn colNo = new DataGridViewTextBoxColumn();
                colNo.Name = "No";
                colNo.HeaderText = "No.";
                colNo.Width = 50;
                colNo.DisplayIndex = 0;
                dgVendors.Columns.Insert(0, colNo);
            }
            else
            {
                dgVendors.Columns["No"].DisplayIndex = 0;
            }

            dgVendors.Sort(dgVendors.Columns["VendorId"], ListSortDirection.Descending);

            dgVendors.Columns["VendorName"].HeaderText = "Name";
            dgVendors.Columns["VendorName"].Width = 180;
            dgVendors.Columns["VendorName"].DisplayIndex = 1;

            dgVendors.Columns["CompanyName"].HeaderText = "Company";
            dgVendors.Columns["CompanyName"].Width = 200;
            dgVendors.Columns["CompanyName"].DisplayIndex = 2;

            dgVendors.Columns["Phone"].HeaderText = "Phone";
            dgVendors.Columns["Phone"].Width = 150;
            dgVendors.Columns["Phone"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgVendors.Columns["Phone"].DisplayIndex = 3;

            dgVendors.Columns["Email"].HeaderText = "Email";
            dgVendors.Columns["Email"].Width = 200;
            dgVendors.Columns["Email"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgVendors.Columns["Email"].DisplayIndex = 4;

            dgVendors.Columns["Address"].HeaderText = "Address";
            dgVendors.Columns["Address"].Width = 300;
            dgVendors.Columns["Address"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgVendors.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgVendors.Columns["Address"].DisplayIndex = 5;
        }
        private void dgVendors_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 & e.ColumnIndex > -1)
            {
                {
                    e.Handled = true;
                    using (Brush b = new SolidBrush(dgVendors.DefaultCellStyle.BackColor))
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
            if (dtVendor == null)
                return;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                dtVendor.DefaultView.RowFilter = string.Empty;
                dgVendors.DataSource = dtVendor;
                return;
            }
            string s = searchText.Trim().Replace("'", "''");
            string filter = $"VendorName LIKE '%{s}%' OR CompanyName LIKE '%{s}%'";
            dtVendor.DefaultView.RowFilter = filter;
            dgVendors.DataSource = dtVendor.DefaultView;
        }
        private void dgVendors_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
