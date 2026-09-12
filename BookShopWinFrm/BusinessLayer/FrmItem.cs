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
    public partial class FrmItem : Form
    {
        DataTable dtItem;

        public DataTable UserPermissions { get; set; }

        public FrmItem()
        {
            InitializeComponent();
            this.VisibleChanged += FrmItem_VisibleChanged;
        }

        private void FrmItem_Load(object sender, EventArgs e)
        {
            LoadData();
            ApplyPermissions();
        }

        private void FrmItem_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadData();
            }
        }

        public void RefreshItems()
        {
            LoadData();
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

                if (permName == "ItemCreate")
                    btnAdd.Visible = true;
                else if (permName == "ItemModify")
                    btnEdit.Visible = true;
                else if (permName == "ItemDelete")
                    btnDelete.Visible = true;
            }
        }
        private void LoadData()
        {
            dtItem = ItemService.GetAll();
            dgItems.DataSource = dtItem;
            dgItems.RowTemplate.Height = 70;
            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dgItems.Columns["Thumbnail"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            if (dgItems.Columns.Contains("IsDeleted"))
            {
                dgItems.Columns["IsDeleted"].Visible = false;
            }
            if (dgItems.Columns.Contains("ItemId"))
            {
                dgItems.Columns["ItemId"].Visible = false;
            }

            if (!dgItems.Columns.Contains("No"))
            {
                DataGridViewTextBoxColumn colNo = new DataGridViewTextBoxColumn();
                colNo.Name = "No";
                colNo.HeaderText = "No.";
                colNo.Width = 50;
                colNo.DisplayIndex = 0;
                dgItems.Columns.Insert(0, colNo);
            }
            else
            {
                dgItems.Columns["No"].DisplayIndex = 0;
            }

            dgItems.Sort(dgItems.Columns["ItemId"], ListSortDirection.Descending);

            dgItems.Columns["ItemName"].HeaderText = "Name";
            dgItems.Columns["ItemName"].Width = 200;
            dgItems.Columns["ItemName"].DisplayIndex = 1;

            dgItems.Columns["Category"].HeaderText = "Category";
            dgItems.Columns["Category"].Width = 150;
            dgItems.Columns["Category"].DisplayIndex = 2;

            dgItems.Columns["Author"].HeaderText = "Author";
            dgItems.Columns["Author"].Width = 200;
            dgItems.Columns["Author"].DisplayIndex = 3;

            dgItems.Columns["Rating"].HeaderText = "Rating";
            dgItems.Columns["Rating"].Width = 100;
            dgItems.Columns["Rating"].DisplayIndex = 4;

            dgItems.Columns["Quantity"].HeaderText = "Quantity";
            dgItems.Columns["Quantity"].Width = 100;
            dgItems.Columns["Quantity"].DisplayIndex = 5;

            dgItems.Columns["SalePrice"].HeaderText = "Sale Price";
            dgItems.Columns["SalePrice"].Width = 100;
            dgItems.Columns["SalePrice"].DisplayIndex = 6;

            dgItems.Columns["Thumbnail"].HeaderText = "Image";
            dgItems.Columns["Thumbnail"].Width = 150;

            dgItems.Columns["Thumbnail"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgItems.Columns["Thumbnail"].DisplayIndex = 7;

            dgItems.Columns["ItemDescription"].HeaderText = "Description";
            dgItems.Columns["ItemDescription"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgItems.Columns["ItemDescription"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgItems.Columns["ItemDescription"].DisplayIndex = 8;
        }
        private void dgItems_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 & e.ColumnIndex > -1)
            {
                {
                    e.Handled = true;
                    using (Brush b = new SolidBrush(dgItems.DefaultCellStyle.BackColor))
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
        private void dgItems_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
            if (dtItem == null)
                return;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                dtItem.DefaultView.RowFilter = string.Empty;
                dgItems.DataSource = dtItem;
                return;
            }
            string s = searchText.Trim().Replace("'", "''");
            string filter = $"ItemName LIKE '%{s}%' OR Category LIKE '%{s}%'";
            dtItem.DefaultView.RowFilter = filter;
            dgItems.DataSource = dtItem.DefaultView;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == new FrmItemAddEdit(null).ShowDialog())
            {
                LoadData();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to edit.", "Edit Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int itemId = Convert.ToInt32(dgItems.SelectedRows[0].Cells["ItemId"].Value);
            Item item = ItemService.Get(itemId);
            FrmItemAddEdit frmItemAddEdit = new FrmItemAddEdit(item);
            if (frmItemAddEdit.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirmation!\nDo you really want to delete this item?", "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                int itemid = Convert.ToInt32(dgItems.SelectedRows[0].Cells["ItemId"].Value.ToString());
                Item item = ItemService.Get(itemid);
                ItemService.Delete(itemid);
                MessageBox.Show("Item had deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }
    }

}
