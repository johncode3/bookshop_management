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
    public partial class FrmCustomerAddEdit : Form
    {
        Customer customer;
        bool newcustomer;

        public FrmCustomerAddEdit(Customer customer)
        {
            InitializeComponent();
            cmbCustomerType.Items.Add("Regular");
            cmbCustomerType.Items.Add("Teacher");
            cmbCustomerType.Items.Add("Student");
            if (customer == null)
            {
                this.customer = new Customer();
                lblTitle.Text = "New Customer";
                this.Text = "List : New Customer";
                newcustomer = true;
            }
            else
            {
                this.customer = customer;
                newcustomer = false;
                lblTitle.Text = "Edit Customer";
                this.Text = "List : Edit Customer";
                newcustomer = false;
                LoadData();
            }
        }
        void LoadData()
        {
            txtCustomerName.Text = customer.CustomerName;
            txtCompanyName.Text = customer.CompanyName;
            txtPhone.Text = customer.Phone;
            txtEmail.Text = customer.Email;
            cmbCustomerType.SelectedItem = customer.CustomerType;
            txtAddress.Text = customer.Address;
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
            customer.CustomerName = txtCustomerName.Text;
            customer.CompanyName = txtCompanyName.Text;
            customer.Phone = txtPhone.Text;
            customer.Email = txtEmail.Text;
            customer.CustomerType = cmbCustomerType.SelectedItem.ToString();
            customer.Address = txtAddress.Text.Trim();

            if (customer.CustomerType == "Student")
                customer.MemberDiscount = 15.00m;
            else if (customer.CustomerType == "Teacher")
                customer.MemberDiscount = 10.00m;
            else
                customer.MemberDiscount = 0.00m;

            if (newcustomer)
            {
                CustomerService.Add(customer);
            }
            else
            {
                CustomerService.Update(customer);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool DoValidation()
        {
            if (txtCustomerName.Text.Trim() == "")
            {
                MessageBox.Show("Customer Name is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerName.Focus();
                return false;
            }
            else if (txtCompanyName.Text.Trim() == "")
            {
                MessageBox.Show("Company Name is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCompanyName.Focus();
                return false;
            }
            else if (cmbCustomerType.Text.Trim() == "")
            {
                MessageBox.Show("Customer Type is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCustomerType.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
