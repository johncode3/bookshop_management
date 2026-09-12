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
    public partial class FrmMain : Form
    {
        FrmDashboard frmDashboard;
        FrmLogin frmLogin;
        FrmCustomer frmCustomer;
        FrmSale frmSale;
        FrmVendor frmVendor;
        FrmPurchase frmPurchase;
        FrmItem frmItem;
        FrmInventoryAdjustment frmInventoryAdjustment;
        FrmEmployee frmEmployee;
        FrmUser frmUser;
        FrmPOS frmPOS;

        DataTable dtUserPermission;
        private Panel activeMenuPanel = null;

        public static AppUser CurrentUser { get; private set; }
        public AppUser UserLogin
        {
            get => CurrentUser;
            set
            {
                CurrentUser = value;
                ShowCurrentUserInfo();
            }
        }

        public FrmMain()
        {
            InitializeComponent();
            RegisterMenuHoverEffects();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ShowCurrentUserInfo();
            LoadUserPermission();

            if (frmDashboard == null || frmDashboard.IsDisposed)
            {
                frmDashboard = new FrmDashboard();
            }
            LoadFormIntoPanel(frmDashboard);
            SetActiveMenuPanel(mnuDashbaord);
        }

        private void ShowCurrentUserInfo()
        {
            if (lblUserName != null)
            {
                lblUserName.Text = CurrentUser?.UserName ?? string.Empty;
            }

            if (picProfile != null)
            {
                if (CurrentUser?.Avatar != null && CurrentUser.Avatar.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(CurrentUser.Avatar))
                    using (Image img = Image.FromStream(ms))
                    {
                        picProfile.Image = new Bitmap(img);
                    }
                }
                else
                {
                    picProfile.Image = null;
                }
            }
        }

        void LoadUserPermission()
        {
            if (this.UserLogin == null) return;

            if (submnuCustomerList != null) submnuCustomerList.Visible = false;
            if (submnuSaleTransaction != null) submnuSaleTransaction.Visible = false;
            if (submnuVendorList != null) submnuVendorList.Visible = false;
            if (submnuPurchaseTransction != null) submnuPurchaseTransction.Visible = false;
            if (submnuItemList != null) submnuItemList.Visible = false;
            if (submnuInventoryAdjTransaction != null) submnuInventoryAdjTransaction.Visible = false;
            if (submnuEmployeeList != null) submnuEmployeeList.Visible = false;
            if (mnuUserCenter != null) mnuUserCenter.Visible = false;
            if (pnlSubUserManagement != null) pnlSubUserManagement.Visible = false;
            if (submnuUserAccountPerssion != null) submnuUserAccountPerssion.Visible = false;
            if (submnuUserAccountPermission != null) submnuUserAccountPermission.Visible = false;

            CloseUnauthorizedOpenForms();

            if (this.UserLogin.IsAdmin)
            {
                if (submnuCustomerList != null) submnuCustomerList.Visible = true;
                if (submnuSaleTransaction != null) submnuSaleTransaction.Visible = true;
                if (submnuVendorList != null) submnuVendorList.Visible = true;
                if (submnuPurchaseTransction != null) submnuPurchaseTransction.Visible = true;
                if (submnuItemList != null) submnuItemList.Visible = true;
                if (submnuInventoryAdjTransaction != null) submnuInventoryAdjTransaction.Visible = true;
                if (submnuEmployeeList != null) submnuEmployeeList.Visible = true;
                if (mnuUserCenter != null) mnuUserCenter.Visible = true;
                if (pnlSubUserManagement != null) pnlSubUserManagement.Visible = true;
                if (submnuUserAccountPerssion != null) submnuUserAccountPerssion.Visible = true;
                if (submnuUserAccountPermission != null) submnuUserAccountPermission.Visible = true;
                return;
            }

            dtUserPermission = AppUserService.GetUserPermissions(this.UserLogin.AppUserId);

            if (dtUserPermission != null && dtUserPermission.Rows.Count > 0)
            {
                foreach (DataRow row in dtUserPermission.Rows)
                {
                    string permName = row["PermissionName"].ToString();

                    if (permName == "CustomerView" && submnuCustomerList != null) submnuCustomerList.Visible = true;
                    if (permName == "SaleView" && submnuSaleTransaction != null) submnuSaleTransaction.Visible = true;
                    if (permName == "VendorView" && submnuVendorList != null) submnuVendorList.Visible = true;
                    if (permName == "PurchaseView" && submnuPurchaseTransction != null) submnuPurchaseTransction.Visible = true;
                    if (permName == "ItemView" && submnuItemList != null) submnuItemList.Visible = true;
                    if (permName == "InventoryAdjustmentView" && submnuInventoryAdjTransaction != null) submnuInventoryAdjTransaction.Visible = true;
                    if (permName == "EmployeeView" && submnuEmployeeList != null) submnuEmployeeList.Visible = true;
                    if (permName == "UserView" && submnuUserAccountPermission != null) submnuUserAccountPermission.Visible = true;
                }
            }
        }

        private void CloseUnauthorizedOpenForms()
        {
            if (frmCustomer != null && !frmCustomer.IsDisposed && !submnuCustomerList.Visible) frmCustomer.Close();
            if (frmSale != null && !frmSale.IsDisposed && !submnuSaleTransaction.Visible) frmSale.Close();
            if (frmVendor != null && !frmVendor.IsDisposed && !submnuVendorList.Visible) frmVendor.Close();
            if (frmPurchase != null && !frmPurchase.IsDisposed && !submnuPurchaseTransction.Visible) frmPurchase.Close();
            if (frmItem != null && !frmItem.IsDisposed && !submnuItemList.Visible) frmItem.Close();
            if (frmInventoryAdjustment != null && !frmInventoryAdjustment.IsDisposed && !submnuInventoryAdjTransaction.Visible) frmInventoryAdjustment.Close();
            if (frmEmployee != null && !frmEmployee.IsDisposed && !submnuEmployeeList.Visible) frmEmployee.Close();
            if (frmUser != null && !frmUser.IsDisposed && !mnuUserCenter.Visible) frmUser.Close();
        }

        private void mnuCustomerCenter_Click(object sender, EventArgs e)
        {
            if (pnlSubMnuCustomerCenter != null)
                pnlSubMnuCustomerCenter.Visible = !pnlSubMnuCustomerCenter.Visible;
        }

        private void mnuVendorCenter_Click(object sender, EventArgs e)
        {
            if (pnlSubMenuVendorCenter != null)
                pnlSubMenuVendorCenter.Visible = !pnlSubMenuVendorCenter.Visible;
        }

        private void mnuInventoryCenter_Click(object sender, EventArgs e)
        {
            if (pnlSubMenuInventoryAdjCenter != null)
                pnlSubMenuInventoryAdjCenter.Visible = !pnlSubMenuInventoryAdjCenter.Visible;
        }

        private void mnuEmployeeCenter_Click(object sender, EventArgs e)
        {
            if (pnlSubMenuEmployeeCenter != null)
                pnlSubMenuEmployeeCenter.Visible = !pnlSubMenuEmployeeCenter.Visible;
        }

        private void mnuUserCenter_Click(object sender, EventArgs e)
        {
            if (pnlSubUserManagement != null)
                pnlSubUserManagement.Visible = !pnlSubUserManagement.Visible;
        }

        private void mnuDashbaord_Click(object sender, EventArgs e)
        {
            if (frmDashboard == null || frmDashboard.IsDisposed)
            {
                frmDashboard = new FrmDashboard();
            }
            LoadFormIntoPanel(frmDashboard);
            SetActiveMenuPanel(mnuDashbaord);
        }
        private void submnuCustomerList_Click(object sender, EventArgs e)
        {
            if (frmCustomer == null || frmCustomer.IsDisposed)
            {
                frmCustomer = new FrmCustomer();
                frmCustomer.UserPermissions = dtUserPermission;
            }
            else
            {
                frmCustomer.UserPermissions = dtUserPermission;
            }
            LoadFormIntoPanel(frmCustomer);
            SetActiveMenuPanel(submnuCustomerList);
        }

        private void submnuSaleTransaction_Click(object sender, EventArgs e)
        {
            if (frmSale == null || frmSale.IsDisposed)
            {
                frmSale = new FrmSale();
                frmSale.UserPermissions = dtUserPermission;
            }
            else
            {
                frmSale.UserPermissions = dtUserPermission;
            }
            LoadFormIntoPanel(frmSale);
            SetActiveMenuPanel(submnuSaleTransaction);
        }

        private void submnuVendorList_Click(object sender, EventArgs e)
        {
            if (frmVendor == null || frmVendor.IsDisposed)
            {
                frmVendor = new FrmVendor();
                frmVendor.UserPermissions = dtUserPermission;
            }
            else
            {
                frmVendor.UserPermissions = dtUserPermission;
            }
            LoadFormIntoPanel(frmVendor);
            SetActiveMenuPanel(submnuVendorList);
        }

        private void submnuPurchaseTransction_Click(object sender, EventArgs e)
        {
            if (frmPurchase == null || frmPurchase.IsDisposed)
            {
                frmPurchase = new FrmPurchase();
                frmPurchase.UserPermissions = dtUserPermission;
            }
            else
            {
                frmPurchase.UserPermissions = dtUserPermission;
            }
            LoadFormIntoPanel(frmPurchase);
            SetActiveMenuPanel(submnuPurchaseTransction);
        }

        private void submnuItemList_Click(object sender, EventArgs e)
        {
            if (frmItem == null || frmItem.IsDisposed)
            {
                frmItem = new FrmItem();
                frmItem.UserPermissions = dtUserPermission;
            }
            else
            {
                frmItem.UserPermissions = dtUserPermission;
            }
            LoadFormIntoPanel(frmItem);
            SetActiveMenuPanel(submnuItemList);
        }

        private void submnuInventoryAdjTransaction_Click(object sender, EventArgs e)
        {
            if (frmInventoryAdjustment == null || frmInventoryAdjustment.IsDisposed)
            {
                frmInventoryAdjustment = new FrmInventoryAdjustment();
                frmInventoryAdjustment.UserPermissions = dtUserPermission;
            }
            else
            {
                frmInventoryAdjustment.UserPermissions = dtUserPermission;
            }
            LoadFormIntoPanel(frmInventoryAdjustment);
            SetActiveMenuPanel(submnuInventoryAdjTransaction);
        }

        private void submnuEmployeeList_Click(object sender, EventArgs e)
        {
            if (frmEmployee == null || frmEmployee.IsDisposed)
            {
                frmEmployee = new FrmEmployee();
                frmEmployee.UserPermissions = dtUserPermission;
            }
            else
            {
                frmEmployee.UserPermissions = dtUserPermission;
            }
            LoadFormIntoPanel(frmEmployee);
            SetActiveMenuPanel(submnuEmployeeList);
        }

        private void submnuUserAccountPermission_Click(object sender, EventArgs e)
        {
            if (frmUser == null || frmUser.IsDisposed)
            {
                frmUser = new FrmUser();
                frmUser.UserPermissions = dtUserPermission;
            }
            else
            {
                frmUser.UserPermissions = dtUserPermission;
            }
            LoadFormIntoPanel(frmUser);
            SetActiveMenuPanel(submnuUserAccountPerssion);
        }

        private void mnuPOS_Click(object sender, EventArgs e)
        {
            if (frmPOS == null || frmPOS.IsDisposed)
            {
                frmPOS = new FrmPOS();
            }
            LoadFormIntoPanel(frmPOS);
            SetActiveMenuPanel(mnuPOS);
        }

        private void LoadFormIntoPanel(Form childForm)
        {
            if (childForm == null || childForm.IsDisposed)
                return;

            foreach (Control control in pnlMain.Controls)
            {
                control.Hide();
            }

            if (!pnlMain.Controls.Contains(childForm))
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                childForm.WindowState = FormWindowState.Normal;
                pnlMain.Controls.Add(childForm);
            }

            pnlMain.Tag = childForm;
            childForm.Show();
            childForm.BringToFront();
        }

        private void SetActiveMenuPanel(Panel menuPanel)
        {
            if (activeMenuPanel != null)
            {
                activeMenuPanel.BackColor = Color.Transparent;
            }

            activeMenuPanel = menuPanel;
            if (activeMenuPanel != null)
            {
                activeMenuPanel.BackColor = Color.FromArgb(0, 122, 204);
            }
        }

        private void RegisterMenuHoverEffects()
        {
            Panel[] menuPanels =
            {
                mnuDashbaord,
                mnuPOS,
                mnuCustomerCenter,
                submnuCustomerList,
                submnuSaleTransaction,
                mnuVendorCenter,
                submnuVendorList,
                submnuPurchaseTransction,
                mnuInventoryCenter,
                submnuItemList,
                submnuInventoryAdjTransaction,
                mnuEmployeeCenter,
                submnuEmployeeList,
                mnuUserCenter,
                submnuUserAccountPerssion
            };

            foreach (Panel panel in menuPanels)
            {
                if (panel != null)
                {
                    panel.MouseEnter += MenuPanel_MouseEnter;
                    panel.MouseLeave += MenuPanel_MouseLeave;
                }
            }
        }

        private void MenuPanel_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Panel panel)
            {
                panel.BackColor = Color.FromArgb(0, 122, 204);
            }
        }

        private void MenuPanel_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Panel panel)
            {
                if (panel != activeMenuPanel)
                {
                    panel.BackColor = Color.Transparent;
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CurrentUser = null;
            lblUserName.Text = string.Empty;
            picProfile.Image = null;
            if (activeMenuPanel != null)
            {
                activeMenuPanel.BackColor = Color.Transparent;
                activeMenuPanel = null;
            }

            this.Hide();
            using (FrmLogin frmLogin = new FrmLogin(this))
            {
                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    LoadUserPermission();
                    if (pnlMain.Controls.Contains(frmDashboard))
                    {
                        LoadFormIntoPanel(frmDashboard);
                        SetActiveMenuPanel(mnuDashbaord);
                    }
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }

        }
    }
}