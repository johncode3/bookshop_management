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
        FrmSale frmSales;
        FrmEmployee frmEmployee;
        FrmVendor frmVendor;
        FrmInventoryAdjustment frmInventoryAdjustment;
        FrmUser frmUser;
        DataTable dtUserPermissions;

        public AppUser UserLogin { get; set; }
        public FrmMain()
        {
            InitializeComponent();
        }

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
    }
}