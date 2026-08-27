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
        FrmSales frmSales;
        FrmEmployee frmEmployee;
        FrmVendor frmVendor;
        FrmInventoryAdjustmnet frmInventoryAdjustmnet;
        FrmUser frmUser;
        FrmReportCenter frmReportCenter;
        DataTable dtUserPermissions;

        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            frmLogin = new FrmLogin(this);
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                LoadUserPermissions();
                if (this.UserLogin.IsAdmin)
                {
                    this.mnuAdmin.Visible = true;
                }
                else
                {
                    this.mnuAdmin.Visible = false;
                }
            }
            else
            {
                Application.Exit();
            }
        }
        void LoadUserPermissions()
        {
            dtUserPermissions = this.UserLogin.GetUserPermissions();
            foreach (DataRow dr in dtUserPermissions.Rows)
            {
                string permissionName = dr["PermissionName"].ToString();
                switch (permissionName)
                {
                    case "Customer":
                        this.mnuCustomer.Visible = true;
                        break;
                    case "Sales":
                        this.mnuSales.Visible = true;
                        break;
                    case "Employee":
                        this.mnuEmployee.Visible = true;
                        break;
                    case "Vendor":
                        this.mnuVendor.Visible = true;
                        break;
                    case "Inventory Adjustment":
                        this.mnuInventoryAdjustment.Visible = true;
                        break;
                    case "Report Center":
                        this.mnuReportCenter.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }
        private void mnuCustomerCenter_Click(object sender, EventArgs e)
        {
            mnuCustomerDropdown.Visible = !mnuCustomerDropdown.Visible;
        }
        private void submnuCustomer_Click(object sender, EventArgs e)
        {
            if (frmCustomer == null)
            {
                frmCustomer = new FrmCustomer();
                frmCustomer.TopLevel = false;
                frmCustomer.FormBorderStyle = FormBorderStyle.None;
                frmCustomer.Dock = DockStyle.Fill;
                frmCustomer.WindowState = FormWindowState.Normal;
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
        public AppUser UserLogin { get; set; }
    }
}
