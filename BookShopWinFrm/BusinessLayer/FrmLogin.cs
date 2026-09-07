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
    public partial class FrmLogin : Form
    {
        private FrmMain mainForm;

        public FrmLogin(FrmMain main)
        {
            InitializeComponent();
            this.mainForm = main;
            InitializeLoginLayout();
        }

        public FrmLogin()
        {
            InitializeComponent();
            InitializeLoginLayout();
        }

        private void InitializeLoginLayout()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Resize += FrmLogin_Resize;
            CenterLoginPanel();
        }

        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            CenterLoginPanel();
        }

        private void CenterLoginPanel()
        {
            if (pnlLogin == null)
                return;

            int x = Math.Max((this.ClientSize.Width - pnlLogin.Width) / 2, 0);
            int y = Math.Max((this.ClientSize.Height - pnlLogin.Height) / 2, 0);
            pnlLogin.Location = new Point(x, y);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AppUser loggedUser = AppUserService.Login(username, password);

            if (loggedUser != null)
            {
                if (!loggedUser.IsActive)
                {
                    MessageBox.Show("This account has been deactivated.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (mainForm != null)
                {
                    mainForm.UserLogin = loggedUser;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}