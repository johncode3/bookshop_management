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
                this.user.IsActive = true;
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
            chkIsActive.Checked = user.IsActive;
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
            user.IsActive = chkIsActive.Checked;
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
                user.IsActive = true;
                int newId = AppUserService.Add(user);
                if (user.IsAdmin)
                {
                    GrantAllPermissions(newId);
                }
            }
            else
            {
                AppUserService.Update(user);
                RefreshMainUserIfNeeded();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void RefreshMainUserIfNeeded()
        {
            if (FrmMain.CurrentUser == null || FrmMain.CurrentUser.AppUserId != user.AppUserId)
                return;

            AppUser refreshedUser = AppUserService.Get(user.AppUserId);
            if (refreshedUser == null)
                return;

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmMain mainForm)
                {
                    mainForm.UserLogin = refreshedUser;
                    break;
                }
            }
        }

        private void GrantAllPermissions(int appUserId)
        {
            string[] permissions =
            {
                "CustomerView", "CustomerCreate", "CustomerModify", "CustomerDelete",
                "SaleView", "SaleCreate", "SaleModify", "SaleDelete",
                "VendorView", "VendorCreate", "VendorModify", "VendorDelete",
                "PurchaseView", "PurchaseCreate", "PurchaseModify", "PurchaseDelete",
                "ItemView", "ItemCreate", "ItemModify", "ItemDelete",
                "InventoryAdjustmentView", "InventoryAdjustmentCreate", "InventoryAdjustmentModify",
                "EmployeeView", "EmployeeCreate", "EmployeeModify", "EmployeeDelete",
                "UserView", "UserCreate", "UserModify", "UserDelete"
            };

            foreach (string permission in permissions)
            {
                AppUserService.AddUserPermission(new AppUserPermission
                {
                    AppUserId = appUserId,
                    PermissionName = permission
                });
            }
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
