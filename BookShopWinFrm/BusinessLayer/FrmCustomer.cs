using BookShopWinFrm.DataLayer.Model;
using BookShopWinFrm.DataLayer.Services;
using Microsoft.VisualBasic;
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
    public partial class FrmCustomer : Form
    {
        DataTable dtCustomer;
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dtCustomer = CustomerService.GetAll();
            dgCustomers.DataSource = dtCustomer;
            if (dgCustomers.Columns.Contains("IsDeleted"))
            {
                dgCustomers.Columns["IsDeleted"].Visible = false;
            }
            if (dgCustomers.Columns.Contains("CustomerId"))
            {
                dgCustomers.Columns["CustomerId"].Visible = false;
            }

            if (!dgCustomers.Columns.Contains("No"))
            {
                DataGridViewTextBoxColumn colNo = new DataGridViewTextBoxColumn();
                colNo.Name = "No";
                colNo.HeaderText = "No.";
                colNo.Width = 50;
                colNo.DisplayIndex = 0;
                dgCustomers.Columns.Insert(0, colNo);
            }
            else
            {
                dgCustomers.Columns["No"].DisplayIndex = 0;
            }

            dgCustomers.Sort(dgCustomers.Columns["CustomerId"], ListSortDirection.Descending);

            dgCustomers.Columns["CustomerName"].HeaderText = "Name";
            dgCustomers.Columns["CustomerName"].Width = 180;
            dgCustomers.Columns["CustomerName"].DisplayIndex = 1;

            dgCustomers.Columns["CompanyName"].HeaderText = "Company";
            dgCustomers.Columns["CompanyName"].Width = 200;
            dgCustomers.Columns["CompanyName"].DisplayIndex = 2;

            dgCustomers.Columns["Phone"].HeaderText = "Phone";
            dgCustomers.Columns["Phone"].Width = 150;
            dgCustomers.Columns["Phone"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgCustomers.Columns["Phone"].DisplayIndex = 3;

            dgCustomers.Columns["Email"].HeaderText = "Email";
            dgCustomers.Columns["Email"].Width = 200;
            dgCustomers.Columns["Email"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgCustomers.Columns["Email"].DisplayIndex = 4;

            dgCustomers.Columns["CustomerType"].HeaderText = "Type";
            dgCustomers.Columns["CustomerType"].Width = 100;
            dgCustomers.Columns["CustomerType"].DisplayIndex = 5;

            dgCustomers.Columns["MemberDiscount"].HeaderText = "Discount";
            dgCustomers.Columns["MemberDiscount"].Width = 100;
            dgCustomers.Columns["MemberDiscount"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgCustomers.Columns["MemberDiscount"].DisplayIndex = 6;

            dgCustomers.Columns["Address"].HeaderText = "Address";
            dgCustomers.Columns["Address"].Width = 300;
            dgCustomers.Columns["Address"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgCustomers.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgCustomers.Columns["Address"].DisplayIndex = 7;
        }
        private void dgCustomers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 & e.ColumnIndex > -1)
            {
                {
                    e.Handled = true;
                    using (Brush b = new SolidBrush(dgCustomers.DefaultCellStyle.BackColor))
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
            FrmCustomerAddEdit frmAddEdit = new FrmCustomerAddEdit(null);
            if (frmAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgCustomers.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a customer first to edit.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int customerId = Convert.ToInt32(dgCustomers.SelectedRows[0].Cells["CustomerId"].Value.ToString());
            Customer customer = CustomerService.Get(customerId);
            FrmCustomerAddEdit frmAddEdit = new FrmCustomerAddEdit(customer);

            if (frmAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirmation!\nDo you really want to delete this customer?", "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dgCustomers.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a customer first to delete.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (confirm == DialogResult.Yes)
            {
                int customerid = Convert.ToInt32(dgCustomers.SelectedRows[0].Cells["CustomerId"].Value.ToString());
                Customer customer = CustomerService.Get(customerid);
                CustomerService.Delete(customerid);
                MessageBox.Show("Customer had deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search(txtSearch.Text.Trim());
        }
        private void Search(string searchText)
        {
            if (dtCustomer == null)
                return;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                dtCustomer.DefaultView.RowFilter = string.Empty;
                dgCustomers.DataSource = dtCustomer;
                return;
            }
            string s = searchText.Trim().Replace("'", "''");
            string filter = $"CustomerName LIKE '%{s}%' OR CompanyName LIKE '%{s}%'";
            dtCustomer.DefaultView.RowFilter = filter;
            dgCustomers.DataSource = dtCustomer.DefaultView;
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
    }
}
