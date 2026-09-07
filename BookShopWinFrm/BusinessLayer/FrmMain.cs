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
        // Child Form Instances
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

        // Session Property
        public static AppUser CurrentUser { get; private set; }
        public AppUser UserLogin
        {
            get => CurrentUser;
            set => CurrentUser = value;
        }

        public FrmMain()
        {
            InitializeComponent();
            RegisterMenuHoverEffects();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadUserPermission();
        }

        void LoadUserPermission()
        {
            if (this.UserLogin == null) return;

            // 1. Hide submenus by default for regular users
            if (submnuCustomerList != null) submnuCustomerList.Visible = false;
            if (submnuSaleTransaction != null) submnuSaleTransaction.Visible = false;
            if (submnuVendorList != null) submnuVendorList.Visible = false;
            if (submnuPurchaseTransction != null) submnuPurchaseTransction.Visible = false;
            if (submnuItemList != null) submnuItemList.Visible = false;
            if (submnuInventoryAdjTransaction != null) submnuInventoryAdjTransaction.Visible = false;
            if (submnuEmployeeList != null) submnuEmployeeList.Visible = false;
            if (submnuUserAccountPermission != null) submnuUserAccountPermission.Visible = false;

            // Admin bypasses granular permission table loop
            if (this.UserLogin.IsAdmin)
            {
                if (submnuCustomerList != null) submnuCustomerList.Visible = true;
                if (submnuSaleTransaction != null) submnuSaleTransaction.Visible = true;
                if (submnuVendorList != null) submnuVendorList.Visible = true;
                if (submnuPurchaseTransction != null) submnuPurchaseTransction.Visible = true;
                if (submnuItemList != null) submnuItemList.Visible = true;
                if (submnuInventoryAdjTransaction != null) submnuInventoryAdjTransaction.Visible = true;
                if (submnuEmployeeList != null) submnuEmployeeList.Visible = true;
                if (submnuUserAccountPermission != null) submnuUserAccountPermission.Visible = true;
                return;
            }

            // 2. Fetch granular permissions from database
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

        // ==========================================
        // SIDEBAR ACCORDION DROPDOWN TOGGLES
        // ==========================================
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


        // ==========================================
        // CHILD FORM NAVIGATION LOADERS
        // ==========================================
        private void submnuCustomerList_Click(object sender, EventArgs e)
        {
            if (frmCustomer == null || frmCustomer.IsDisposed)
            {
                frmCustomer = new FrmCustomer();
            }
            LoadFormIntoPanel(frmCustomer);
        }

        private void submnuSaleTransaction_Click(object sender, EventArgs e)
        {
            if (frmSale == null || frmSale.IsDisposed)
            {
                frmSale = new FrmSale();
            }
            LoadFormIntoPanel(frmSale);
        }

        private void submnuVendorList_Click(object sender, EventArgs e)
        {
            if (frmVendor == null || frmVendor.IsDisposed)
            {
                frmVendor = new FrmVendor();
            }
            LoadFormIntoPanel(frmVendor);
        }

        private void submnuPurchaseTransction_Click(object sender, EventArgs e)
        {
            if (frmPurchase == null || frmPurchase.IsDisposed)
            {
                frmPurchase = new FrmPurchase();
            }
            LoadFormIntoPanel(frmPurchase);
        }

        private void submnuItemList_Click(object sender, EventArgs e)
        {
            if (frmItem == null || frmItem.IsDisposed)
            {
                frmItem = new FrmItem();
            }
            LoadFormIntoPanel(frmItem);
        }

        private void submnuInventoryAdjTransaction_Click(object sender, EventArgs e)
        {
            if (frmInventoryAdjustment == null || frmInventoryAdjustment.IsDisposed)
            {
                frmInventoryAdjustment = new FrmInventoryAdjustment();
            }
            LoadFormIntoPanel(frmInventoryAdjustment);
        }

        private void submnuEmployeeList_Click(object sender, EventArgs e)
        {
            if (frmEmployee == null || frmEmployee.IsDisposed)
            {
                frmEmployee = new FrmEmployee();
            }
            LoadFormIntoPanel(frmEmployee);
        }

        private void submnuUserAccountPermission_Click(object sender, EventArgs e)
        {
            if (frmUser == null || frmUser.IsDisposed)
            {
                frmUser = new FrmUser();
            }
            LoadFormIntoPanel(frmUser);
        }

        private void mnuPOS_Click(object sender, EventArgs e)
        {
            if (frmPOS == null || frmPOS.IsDisposed)
            {
                frmPOS = new FrmPOS();
            }
            LoadFormIntoPanel(frmPOS);
        }


        // ==========================================
        // HELPER PANEL LOADER ENGINE
        // ==========================================
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


        // ==========================================
        // UI VISUAL HOVER EFFECTS
        // ==========================================
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
                panel.BackColor = Color.Transparent;
            }
        }
    }
}