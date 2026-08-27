using BookShopWinFrm.DataLayer.Model;
using BookShopWinFrm.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopWinFrm.BusinessLayer
{
    public partial class FrmUserAddEdit : Form
    {
        AppUser user;
        bool newUser;
        DataTable dtEmployee;
        public FrmUserAddEdit(AppUser user)
        {
            InitializeComponent();
            LoadEmployee();
            if (user == null)
            {
                this.user = new AppUser();
                lblTitle.Text = "New User";
                this.Text = "List : New User";
                newUser = true;
            }
            else
            {
                this.user = user;
                newUser = false;
                lblTitle.Text = "Edit User";
                this.Text = "List : Edit User";
                newUser = false;
                LoadData();
            }
        }
        private void LoadData()
        {
            txtUserName.Text = user.UserName;
            txtPassword.Text = user.Password;
            txtConfirmPassword.Text = user.Password;
            cmbEmployee.SelectedValue = user.EmployeeId;
            chkIsAdmin.Checked = user.IsAdmin;
            if (user.Avatar != null && user.Avatar.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(user.Avatar))
                {
                    imgProfile.Image = new Bitmap(Image.FromStream(ms));
                }
            }
            else
            {
                imgProfile.Image = null;
            }
        }
        void LoadEmployee()
        {
            DataTable dtEmployee = EmployeeService.GetAll();
            cmbEmployee.SelectedIndex = -1;
            cmbEmployee.DataSource = dtEmployee;
            cmbEmployee.DisplayMember = "EmployeeName";
            cmbEmployee.ValueMember = "EmployeeId";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!DoValidation())
            {
                return;
            }
            user.EmployeeId = Convert.ToInt32(cmbEmployee.SelectedValue);
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.IsAdmin = chkIsAdmin.Checked;
            if (imgProfile.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imgProfile.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    user.Avatar = ms.ToArray();
                }
            }
            else
            {
                user.Avatar = null;
            }

            if (newUser)
            {
                AppUserService.Add(user);
            }
            else
            {
                AppUserService.Update(user);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool DoValidation()
        {
            if (cmbEmployee.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an employee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbEmployee.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return false;
            }
            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please check again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                txtConfirmPassword.SelectAll();
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
                        imgProfile.Image = new Bitmap(img);
                    }
                }
            }
        }
    }
}
