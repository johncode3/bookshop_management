using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopWinFrm.DataLayer.Model;
using BookShopWinFrm.DataLayer.Services;

namespace BookShopWinFrm.BusinessLayer
{
    public partial class FrmVendorAddEdit : Form
    {
        Vendor vendor;
        bool newvendor;
        public FrmVendorAddEdit(Vendor vendor)
        {
            InitializeComponent();
            if (vendor == null)
            {
                this.vendor = new Vendor();
                lblTitle.Text = "New Vendor";
                this.Text = "List : New Vendor";
                newvendor = true;
            }
            else
            {
                this.vendor = vendor;
                newvendor = false;
                lblTitle.Text = "Edit Vendor";
                this.Text = "List : Edit Vendor";
                newvendor = false;
                LoadData();
            }
        }
        void LoadData()
        {
            txtVendorName.Text = vendor.VendorName;
            txtCompanyName.Text = vendor.CompanyName;
            txtPhone.Text = vendor.Phone;
            txtEmail.Text = vendor.Email;
            txtAddress.Text = vendor.Address;
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
            vendor.VendorName = txtVendorName.Text;
            vendor.CompanyName = txtCompanyName.Text;
            vendor.Phone = txtPhone.Text;
            vendor.Email = txtEmail.Text;
            vendor.Address = txtAddress.Text.Trim();

            if (newvendor)
            {
                VendorService.Add(vendor);
            }
            else
            {
                VendorService.Update(vendor);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool DoValidation()
        {
            if (txtVendorName.Text.Trim() == "")
            {
                MessageBox.Show("Vendor Name is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVendorName.Focus();
                return false;
            }
            else if (txtCompanyName.Text.Trim() == "")
            {
                MessageBox.Show("Company Name is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCompanyName.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
