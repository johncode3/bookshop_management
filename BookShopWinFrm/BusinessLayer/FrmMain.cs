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
        FrmLogin frmLogin;
        FrmCustomer frmCustomer;
<<<<<<< HEAD
        FrmSale frmSales;
        FrmEmployee frmEmployee;
        FrmVendor frmVendor;
        FrmInventoryAdjustment frmInventoryAdjustment;
        FrmUser frmUser;
        DataTable dtUserPermissions;
=======
        FrmSale frmSale;
        FrmVendor frmVendor;
        FrmPurchase frmPurchase;
        FrmItem frmItem;
        FrmInventoryAdjustment frmInventoryAdjustment;
        FrmEmployee frmEmployee;
        FrmUser frmUser;
        FrmPOS frmPOS;

        DataTable dtUserPermission;
        public static AppUser CurrentUser { get; private set; }
        public AppUser UserLogin
        {
            get => CurrentUser;
            set => CurrentUser = value;
        }
>>>>>>> 3aaab69 (Add role permissions and safe config handling)

        public AppUser UserLogin { get; set; }
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

            mnuUserCenter.Visible = this.UserLogin.IsAdmin;
            pnlSubUserManagement.Visible = false;

            if (this.UserLogin.IsAdmin) return;

            submnuCustomerList.Visible = false;
            submnuSaleTransaction.Visible = false;
            submnuVendorList.Visible = false;
            submnuPurchaseTransction.Visible = false;
            submnuItemList.Visible = false;
            submnuInventoryAdjTransaction.Visible = false;
            submnuEmployeeList.Visible = false;
            submnuUserAccountPermission.Visible = false;

            dtUserPermission = AppUserService.GetUserPermissions(this.UserLogin.AppUserId);
            if (dtUserPermission != null && dtUserPermission.Rows.Count > 0)
            {
                foreach (DataRow row in dtUserPermission.Rows)
                {
                    string permName = row["PermissionName"].ToString();

                    if (permName == "CustomerView") submnuCustomerList.Visible = true;
                    if (permName == "SaleView") submnuSaleTransaction.Visible = true;
                    if (permName == "VendorView") submnuVendorList.Visible = true;
                    if (permName == "PurchaseView") submnuPurchaseTransction.Visible = true;
                    if (permName == "ItemView") submnuItemList.Visible = true;
                    if (permName == "InventoryAdjustmentView") submnuInventoryAdjTransaction.Visible = true;
                    if (permName == "EmployeeView") submnuEmployeeList.Visible = true;
                    if (permName == "UserView") submnuUserAccountPerssion.Visible = true;
                }
            }
        }

        private void mnuCustomerCenter_Click(object sender, EventArgs e)
        {
            pnlSubMnuCustomerCenter.Visible = !pnlSubMnuCustomerCenter.Visible;
        }

        private void mnuVendorCenter_Click(object sender, EventArgs e)
        {
            pnlSubMenuVendorCenter.Visible = !pnlSubMenuVendorCenter.Visible;
        }

        private void mnuInventoryCenter_Click(object sender, EventArgs e)
        {
            pnlSubMenuInventoryAdjCenter.Visible = !pnlSubMenuInventoryAdjCenter.Visible;
        }

        private void mnuEmployeeCenter_Click(object sender, EventArgs e)
        {
            pnlSubMenuEmployeeCenter.Visible = !pnlSubMenuEmployeeCenter.Visible;
        }

        private void mnuUserCenter_Click(object sender, EventArgs e)
        {
            pnlSubUserManagement.Visible = !pnlSubUserManagement.Visible;
        }

        private void submnuCustomerList_Click(object sender, EventArgs e)
        {
            if (frmCustomer == null || frmCustomer.IsDisposed)
            {
                frmCustomer = new FrmCustomer();
                frmCustomer.UserPermissions = dtUserPermission;
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
                frmVendor.UserPermissions = dtUserPermission;
            }
            LoadFormIntoPanel(frmVendor);
        }

        private void submnuPurchaseTransction_Click(object sender, EventArgs e)
        {
            if (frmPurchase == null || frmPurchase.IsDisposed)
            {
                frmPurchase = new FrmPurchase();
                frmPurchase.UserPermissions = dtUserPermission;
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
                frmInventoryAdjustment.UserPermissions = dtUserPermission;
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
                panel.MouseEnter += MenuPanel_MouseEnter;
                panel.MouseLeave += MenuPanel_MouseLeave;
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
<<<<<<< HEAD

        private void FrmMain_Load(object sender, EventArgs e)
        {
           frmLogin = new FrmLogin(this);
           if (frmLogin.ShowDialog() == DialogResult.OK)
           {
               if (this.UserLogin != null)
               {
                   LoadUserPermissions();
                   
                   if (this.UserLogin.IsAdmin == 1)
                   {
                       this.mnuAdmin.Visible = true;
                   }
                   else
                   {
                       this.mnuAdmin.Visible = false;
                   }
               }
           }
           else
           {
               Application.Exit();
           }
        }
        void LoadUserPermissions()
        {
           dtUserPermissions = AppUserService.GetPermissions(this.UserLogin.AppUserId);
           
           if(dtUserPermissions != null && dtUserPermissions.Rows.Count > 0)
            {
                foreach(DataRow row in dtUserPermissions.Rows)
                {
                    string perm = row["PermissionName"].ToString();
                    
                    if (perm == "CustomerView")
                    {
                        this.mnuCustomer.Visible = true;
                    }
                    if (perm == "SaleView")
                    {
                        this.mnuSales.Visible = true;
                    }
                    if (perm == "EmployeeView")
                    {
                        this.mnuEmployee.Visible = true;
                    }
                    if (perm == "VendorView")
                    {
                        this.mnuVendor.Visible = true;
                    }
                    if (perm == "InventoryAdjustmentView")
                    {
                        this.mnuInventoryAdjustment.Visible = true;
                    }
                    if (perm == "UserView")
                    {
                        this.mnuUser.Visible = true;
                    }
                }
            }
        }
        private void mnuCustomerCenter_Click(object sender, EventArgs e)
        {
           mnuCustomerDropdown.Visible = !mnuCustomerDropdown.Visible;
        }
        private void submnuCustomer_Click(object sender, EventArgs e)
        {
           if (frmCustomer == null || frmCustomer.IsDisposed)
           {
               frmCustomer = new FrmCustomer();
               frmCustomer.TopLevel = false;
               frmCustomer.FormBorderStyle = FormBorderStyle.None;
               frmCustomer.Dock = DockStyle.Fill;
               pnlMain.Controls.Add(frmCustomer);
               pnlMain.Tag = frmCustomer;
               frmCustomer.BringToFront();
               frmCustomer.Show();
           }
           else
           {
               frmCustomer.BringToFront();
           }
        }
        private void mnuSalesCenter_Click(object sender, EventArgs e)
        {
            mnuSalesDropdown.Visible = !mnuSalesDropdown.Visible;
        }
        private void submnuSales_Click(object sender, EventArgs e)
        {
            if (frmSales == null || frmSales.IsDisposed)
            {
                frmSales = new FrmSale();
                frmSales.TopLevel = false;
                frmSales.FormBorderStyle = FormBorderStyle.None;
                frmSales.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(frmSales);
                pnlMain.Tag = frmSales;
                frmSales.BringToFront();
                frmSales.Show();
            }
            else
            {
                frmSales.BringToFront();
            }
        }
=======
>>>>>>> 3aaab69 (Add role permissions and safe config handling)
    }
}