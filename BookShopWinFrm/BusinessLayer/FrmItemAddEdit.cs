using BookShopWinFrm.DataLayer.Model;
using BookShopWinFrm.DataLayer.Services;
using System.IO;
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
    public partial class FrmItemAddEdit : Form
    {
        Item item;
        bool newitem;

        public FrmItemAddEdit(Item item)
        {
            InitializeComponent();

            cmbCategory.Items.Add("Fiction");
            cmbCategory.Items.Add("Non-Fiction");
            cmbCategory.Items.Add("Science & Technology");
            cmbCategory.Items.Add("Business & Economics");
            cmbCategory.Items.Add("Fantasy & Sci-Fi");
            cmbCategory.Items.Add("Self-Help");
            cmbCategory.Items.Add("Educational");
            cmbCategory.Items.Add("Children & YA");

            if (item == null)
            {
                this.item = new Item();
                lblTitle.Text = "New Item";
                this.Text = "List : New Item";
                btnUpload.Text = "Upload";
                newitem = true;
            }
            else
            {
                this.item = item;
                newitem = false;
                lblTitle.Text = "Edit Item";
                this.Text = "List : Edit Item";
                btnUpload.Text = "Change";
                LoadData();
            }
        }
        private void LoadData()
        {
            txtItemName.Text = item.ItemName;
            txtAuthorName.Text = item.Author;

            if (!string.IsNullOrEmpty(item.Category))
            {
                cmbCategory.SelectedItem = item.Category;
            }

            txtQuantity.Text = item.Quantity.ToString();
            txtRating.Text = item.Rating.ToString();
            txtSalePrice.Text = item.SalePrice.ToString();
            txtItemDescription.Text = item.ItemDescription;

            if (item.Thumnail != null && item.Thumnail.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(item.Thumnail))
                {
                    imgItem.Image = new Bitmap(Image.FromStream(ms));
                }
            }
            else
            {
                imgItem.Image = null;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!DoValidation())
                return;
            item.ItemName = txtItemName.Text;
            item.Author = txtAuthorName.Text;
            item.Category = cmbCategory.SelectedItem.ToString();
            item.Quantity = decimal.Parse(txtQuantity.Text);
            item.Rating = decimal.Parse(txtRating.Text);
            item.SalePrice = decimal.Parse(txtSalePrice.Text);
            item.ItemDescription = txtItemDescription.Text;
            if (imgItem.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imgItem.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    item.Thumnail = ms.ToArray();
                }
            }
            else
            {
                item.Thumnail = null;
            }

            if (newitem)
            {
                ItemService.Add(item);
            }
            else
            {
                ItemService.Update(item);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool DoValidation()
        {
            if (txtItemName.Text.Trim() == "")
            {
                MessageBox.Show("Item Name is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemName.Focus();
                return false;
            }
            else if (txtQuantity.Text.Trim() == "")
            {
                MessageBox.Show("Quantity is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return false;
            }
            else if (!decimal.TryParse(txtQuantity.Text.Trim(), out decimal quantity) || quantity < 0)
            {
                MessageBox.Show("Quantity cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return false;
            }
            else if (!decimal.TryParse(txtRating.Text.Trim(), out decimal rating) || rating < 0 || rating > 5)
            {
                MessageBox.Show("Rating must be a number between 0 and 5.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRating.Focus();
                return false;
            }
            else if (txtSalePrice.Text.Trim() == "")
            {
                MessageBox.Show("Sale Price is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalePrice.Focus();
                return false;
            }
            else if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Category is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCategory.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (Image img = Image.FromFile(ofd.FileName))
                    {
                        imgItem.Image = new Bitmap(img);
                    }
                }
            }
        }
    }
}
