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
    public partial class FrmEmployeeAddEdit : Form
    {
        Employee employee;
        bool newemployee;
        public FrmEmployeeAddEdit(Employee employee)
        {
            InitializeComponent();
            cmbHaveSpouse.SelectedIndexChanged += cmbHaveSpouse_SelectedIndexChanged;

            cmbSex.Items.Add("Male");
            cmbSex.Items.Add("Female");

            cmbPosition.Items.Add("Store Manager");
            cmbPosition.Items.Add("Assistant Manager");
            cmbPosition.Items.Add("Lead Cashier");
            cmbPosition.Items.Add("Bookseller / Sales Associate");
            cmbPosition.Items.Add("Inventory Specialist");
            cmbPosition.Items.Add("Event Coordinator");
            cmbPosition.Items.Add("Accountant");

            cmbDepartment.Items.Add("Store Operations");
            cmbDepartment.Items.Add("Inventory & Logistics");
            cmbDepartment.Items.Add("Customer Service & Events");
            cmbDepartment.Items.Add("Finance & Administration");
            cmbDepartment.Items.Add("E-Commerce & Online");

            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");

            cmbMaritalStatus.Items.Add("Single");
            cmbMaritalStatus.Items.Add("Married");

            cmbHaveSpouse.Items.Add("Yes");
            cmbHaveSpouse.Items.Add("No");

            if (employee == null)
            {
                this.employee = new Employee();
                lblTitle.Text = "New Employee";
                this.Text = "List : New Employee";
                newemployee = true;
                txtNumberOfChildren.Text = "0";
                cmbHaveSpouse.SelectedItem = "No";
                cmbMaritalStatus.SelectedItem = "Single";
                cmbStatus.SelectedItem = "Active";

            }
            else
            {
                this.employee = employee;
                newemployee = false;
                lblTitle.Text = "Edit Employee";
                this.Text = "List : Edit Employee";
                LoadData();
            }
        }
        private void LoadData()
        {
            txtEmployeeName.Text = employee.EmployeeName;
            cmbSex.SelectedItem = employee.Sex;
            cmbStatus.SelectedItem = (employee.IsActive == 1) ? "Active" : "Inactive";
            cmbPosition.SelectedItem = employee.Position;
            cmbMaritalStatus.SelectedItem = employee.MaritalStatus;
            cmbHaveSpouse.SelectedItem = (employee.HaveSpouse == 1) ? "Yes" : "No";
            cmbDepartment.SelectedItem = employee.Department;
            dtmDOB.Value = employee.DOB;
            dtmHiredDate.Value = employee.HiredDate;
            txtNumberOfChildren.Text = employee.NumberOfChildren.ToString();
            txtSalary.Text = employee.Salary.ToString();
            txtAddress.Text = employee.Address?.ToString() ?? "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!DoValidation())
                return;
            employee.EmployeeName = txtEmployeeName.Text;
            employee.Sex = cmbSex.SelectedItem.ToString();
            employee.IsActive = (cmbStatus.SelectedItem?.ToString() == "Active") ? 1 : 0;
            employee.Position = cmbPosition.SelectedItem.ToString();
            employee.MaritalStatus = cmbMaritalStatus.SelectedItem.ToString();
            employee.HaveSpouse = (cmbHaveSpouse.SelectedItem.ToString() == "Yes") ? 1 : 0;
            employee.Department = cmbDepartment.SelectedItem.ToString();
            employee.DOB = DateTime.Parse(dtmDOB.Text);
            employee.HiredDate = DateTime.Parse(dtmHiredDate.Text);
            employee.NumberOfChildren = string.IsNullOrEmpty(txtNumberOfChildren.Text) ? 0 : int.Parse(txtNumberOfChildren.Text);
            employee.Salary = decimal.Parse(txtSalary.Text);
            employee.Address = txtAddress.Text;

            if (newemployee)
            {
                EmployeeService.Add(employee);
            }
            else
            {
                EmployeeService.Update(employee);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool DoValidation()
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeName.Text))
            {
                MessageBox.Show("Please enter employee name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeName.Focus();
                return false;
            }
            if (cmbSex.SelectedIndex == -1)
            {
                MessageBox.Show("Please select gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSex.Focus();
                return false;
            }
            if (cmbPosition.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a position.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPosition.Focus();
                return false;
            }
            if (cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbDepartment.Focus();
                return false;
            }
            if (cmbMaritalStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select marital status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbMaritalStatus.Focus();
                return false;
            }
            if (cmbHaveSpouse.SelectedIndex == -1)
            {
                MessageBox.Show("Please specify if they have a spouse.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbHaveSpouse.Focus();
                return false;
            }
            if (!decimal.TryParse(txtSalary.Text.Trim(), out decimal salary) || salary < 0)
            {
                MessageBox.Show("Please enter a valid salary amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalary.Focus();
                txtSalary.SelectAll();
                return false;
            }

            if (!int.TryParse(txtNumberOfChildren.Text.Trim(), out int children) || children < 0)
            {
                MessageBox.Show("Please enter a valid number of children (0 or more).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumberOfChildren.Focus();
                txtNumberOfChildren.SelectAll();
                return false;
            }
            if (dtmDOB.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Date of Birth cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtmDOB.Focus();
                return false;
            }

            if (dtmHiredDate.Value.Date < dtmDOB.Value.Date)
            {
                MessageBox.Show("Hired Date cannot be earlier than Date of Birth!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtmHiredDate.Focus();
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void cmbHaveSpouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHaveSpouse.SelectedItem?.ToString() == "Yes")
            {
                cmbMaritalStatus.SelectedItem = "Married";
            }
            else if (cmbHaveSpouse.SelectedItem?.ToString() == "No")
            {
                cmbMaritalStatus.SelectedItem = "Single";
            }
        }
    }
}
