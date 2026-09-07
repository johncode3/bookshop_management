namespace BookShopWinFrm.BusinessLayer
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTitleBar = new Panel();
            lblTitle = new Label();
            picLogo = new PictureBox();
            pnlMenuBar = new Panel();
            pnlSubUserManagement = new Panel();
            submnuUserAccountPerssion = new Panel();
            submnuUserAccountPermission = new Label();
            mnuUserCenter = new Panel();
            lblUserManagement = new Label();
            pictureBox3 = new PictureBox();
            pnlSubMenuEmployeeCenter = new Panel();
            submnuEmployeeList = new Panel();
            lblEmployeeList = new Label();
            mnuEmployeeCenter = new Panel();
            lblEmployeeCenter = new Label();
            pictureBox2 = new PictureBox();
            pnlSubMenuInventoryAdjCenter = new Panel();
            submnuInventoryAdjTransaction = new Panel();
            lblInventoryAdjTransaction = new Label();
            submnuItemList = new Panel();
            lblItemList = new Label();
            mnuInventoryCenter = new Panel();
            lblInventoryCenter = new Label();
            picInventoryCenter = new PictureBox();
            pnlSubMenuVendorCenter = new Panel();
            submnuPurchaseTransction = new Panel();
            lblPurchaseTransaction = new Label();
            submnuVendorList = new Panel();
            lblVendorList = new Label();
            mnuVendorCenter = new Panel();
            lblVendorCenter = new Label();
            pictureBox1 = new PictureBox();
            pnlSubMnuCustomerCenter = new Panel();
            submnuSaleTransaction = new Panel();
            lblSaleTransaction = new Label();
            submnuCustomerList = new Panel();
            lblCustomerList = new Label();
            mnuCustomerCenter = new Panel();
            lblCustomerCenter = new Label();
            picCustomerCenter = new PictureBox();
            mnuPOS = new Panel();
            lblPOS = new Label();
            picPOS = new PictureBox();
            mnuDashbaord = new Panel();
            lblDashbaord = new Label();
            picDashbaord = new PictureBox();
            pnlLine = new Panel();
            pnlMain = new Panel();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlMenuBar.SuspendLayout();
            pnlSubUserManagement.SuspendLayout();
            submnuUserAccountPerssion.SuspendLayout();
            mnuUserCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlSubMenuEmployeeCenter.SuspendLayout();
            submnuEmployeeList.SuspendLayout();
            mnuEmployeeCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlSubMenuInventoryAdjCenter.SuspendLayout();
            submnuInventoryAdjTransaction.SuspendLayout();
            submnuItemList.SuspendLayout();
            mnuInventoryCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picInventoryCenter).BeginInit();
            pnlSubMenuVendorCenter.SuspendLayout();
            submnuPurchaseTransction.SuspendLayout();
            submnuVendorList.SuspendLayout();
            mnuVendorCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlSubMnuCustomerCenter.SuspendLayout();
            submnuSaleTransaction.SuspendLayout();
            submnuCustomerList.SuspendLayout();
            mnuCustomerCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCustomerCenter).BeginInit();
            mnuPOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPOS).BeginInit();
            mnuDashbaord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDashbaord).BeginInit();
            SuspendLayout();
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.White;
            pnlTitleBar.Controls.Add(lblTitle);
            pnlTitleBar.Controls.Add(picLogo);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1195, 136);
            pnlTitleBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Kh Pen Wappathor", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(134, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(449, 62);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Book Shop Management";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(23, 10);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(105, 104);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlMenuBar
            // 
            pnlMenuBar.BackColor = Color.White;
            pnlMenuBar.Controls.Add(pnlSubUserManagement);
            pnlMenuBar.Controls.Add(mnuUserCenter);
            pnlMenuBar.Controls.Add(pnlSubMenuEmployeeCenter);
            pnlMenuBar.Controls.Add(mnuEmployeeCenter);
            pnlMenuBar.Controls.Add(pnlSubMenuInventoryAdjCenter);
            pnlMenuBar.Controls.Add(mnuInventoryCenter);
            pnlMenuBar.Controls.Add(pnlSubMenuVendorCenter);
            pnlMenuBar.Controls.Add(mnuVendorCenter);
            pnlMenuBar.Controls.Add(pnlSubMnuCustomerCenter);
            pnlMenuBar.Controls.Add(mnuCustomerCenter);
            pnlMenuBar.Controls.Add(mnuPOS);
            pnlMenuBar.Controls.Add(mnuDashbaord);
            pnlMenuBar.Dock = DockStyle.Left;
            pnlMenuBar.Location = new Point(0, 136);
            pnlMenuBar.Name = "pnlMenuBar";
            pnlMenuBar.Padding = new Padding(20, 10, 20, 0);
            pnlMenuBar.Size = new Size(401, 919);
            pnlMenuBar.TabIndex = 1;
            // 
            // pnlSubUserManagement
            // 
            pnlSubUserManagement.Controls.Add(submnuUserAccountPerssion);
            pnlSubUserManagement.Dock = DockStyle.Top;
            pnlSubUserManagement.Location = new Point(20, 944);
            pnlSubUserManagement.Name = "pnlSubUserManagement";
            pnlSubUserManagement.Size = new Size(361, 62);
            pnlSubUserManagement.TabIndex = 11;
            pnlSubUserManagement.Visible = false;
            // 
            // submnuUserAccountPerssion
            // 
            submnuUserAccountPerssion.BackColor = Color.Transparent;
            submnuUserAccountPerssion.Controls.Add(submnuUserAccountPermission);
            submnuUserAccountPerssion.Dock = DockStyle.Top;
            submnuUserAccountPerssion.Location = new Point(0, 0);
            submnuUserAccountPerssion.Name = "submnuUserAccountPerssion";
            submnuUserAccountPerssion.Size = new Size(361, 50);
            submnuUserAccountPerssion.TabIndex = 3;
            // 
            // submnuUserAccountPermission
            // 
            submnuUserAccountPermission.AutoSize = true;
            submnuUserAccountPermission.Font = new Font("Kh Pen Wappathor", 11F, FontStyle.Bold);
            submnuUserAccountPermission.Location = new Point(64, 7);
            submnuUserAccountPermission.Name = "submnuUserAccountPermission";
            submnuUserAccountPermission.Size = new Size(274, 35);
            submnuUserAccountPermission.TabIndex = 3;
            submnuUserAccountPermission.Text = "User Account & Permission";
            submnuUserAccountPermission.Click += submnuUserAccountPermission_Click;
            // 
            // mnuUserCenter
            // 
            mnuUserCenter.BackColor = Color.Transparent;
            mnuUserCenter.Controls.Add(lblUserManagement);
            mnuUserCenter.Controls.Add(pictureBox3);
            mnuUserCenter.Dock = DockStyle.Top;
            mnuUserCenter.Location = new Point(20, 879);
            mnuUserCenter.Name = "mnuUserCenter";
            mnuUserCenter.Size = new Size(361, 65);
            mnuUserCenter.TabIndex = 10;
            mnuUserCenter.Click += mnuUserCenter_Click;
            // 
            // lblUserManagement
            // 
            lblUserManagement.AutoSize = true;
            lblUserManagement.Font = new Font("Kh Pen Wappathor", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserManagement.Location = new Point(59, 15);
            lblUserManagement.Name = "lblUserManagement";
            lblUserManagement.Size = new Size(228, 41);
            lblUserManagement.TabIndex = 3;
            lblUserManagement.Text = "User Management";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user;
            pictureBox3.Location = new Point(10, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pnlSubMenuEmployeeCenter
            // 
            pnlSubMenuEmployeeCenter.Controls.Add(submnuEmployeeList);
            pnlSubMenuEmployeeCenter.Dock = DockStyle.Top;
            pnlSubMenuEmployeeCenter.Location = new Point(20, 823);
            pnlSubMenuEmployeeCenter.Name = "pnlSubMenuEmployeeCenter";
            pnlSubMenuEmployeeCenter.Size = new Size(361, 56);
            pnlSubMenuEmployeeCenter.TabIndex = 9;
            pnlSubMenuEmployeeCenter.Visible = false;
            // 
            // submnuEmployeeList
            // 
            submnuEmployeeList.BackColor = Color.Transparent;
            submnuEmployeeList.Controls.Add(lblEmployeeList);
            submnuEmployeeList.Dock = DockStyle.Top;
            submnuEmployeeList.Location = new Point(0, 0);
            submnuEmployeeList.Name = "submnuEmployeeList";
            submnuEmployeeList.Size = new Size(361, 50);
            submnuEmployeeList.TabIndex = 3;
            submnuEmployeeList.Click += submnuEmployeeList_Click;
            // 
            // lblEmployeeList
            // 
            lblEmployeeList.AutoSize = true;
            lblEmployeeList.Font = new Font("Kh Pen Wappathor", 11F, FontStyle.Bold);
            lblEmployeeList.Location = new Point(64, 6);
            lblEmployeeList.Name = "lblEmployeeList";
            lblEmployeeList.Size = new Size(156, 35);
            lblEmployeeList.TabIndex = 3;
            lblEmployeeList.Text = "Employee List";
            lblEmployeeList.Click += submnuEmployeeList_Click;
            // 
            // mnuEmployeeCenter
            // 
            mnuEmployeeCenter.BackColor = Color.Transparent;
            mnuEmployeeCenter.Controls.Add(lblEmployeeCenter);
            mnuEmployeeCenter.Controls.Add(pictureBox2);
            mnuEmployeeCenter.Dock = DockStyle.Top;
            mnuEmployeeCenter.Location = new Point(20, 758);
            mnuEmployeeCenter.Name = "mnuEmployeeCenter";
            mnuEmployeeCenter.Size = new Size(361, 65);
            mnuEmployeeCenter.TabIndex = 8;
            mnuEmployeeCenter.Click += mnuEmployeeCenter_Click;
            // 
            // lblEmployeeCenter
            // 
            lblEmployeeCenter.AutoSize = true;
            lblEmployeeCenter.Font = new Font("Kh Pen Wappathor", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeCenter.Location = new Point(59, 15);
            lblEmployeeCenter.Name = "lblEmployeeCenter";
            lblEmployeeCenter.Size = new Size(217, 41);
            lblEmployeeCenter.TabIndex = 3;
            lblEmployeeCenter.Text = "Employee Center";
            lblEmployeeCenter.Click += mnuEmployeeCenter_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.staff;
            pictureBox2.Location = new Point(10, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pnlSubMenuInventoryAdjCenter
            // 
            pnlSubMenuInventoryAdjCenter.Controls.Add(submnuInventoryAdjTransaction);
            pnlSubMenuInventoryAdjCenter.Controls.Add(submnuItemList);
            pnlSubMenuInventoryAdjCenter.Dock = DockStyle.Top;
            pnlSubMenuInventoryAdjCenter.Location = new Point(20, 617);
            pnlSubMenuInventoryAdjCenter.Name = "pnlSubMenuInventoryAdjCenter";
            pnlSubMenuInventoryAdjCenter.Size = new Size(361, 141);
            pnlSubMenuInventoryAdjCenter.TabIndex = 7;
            pnlSubMenuInventoryAdjCenter.Visible = false;
            // 
            // submnuInventoryAdjTransaction
            // 
            submnuInventoryAdjTransaction.BackColor = Color.Transparent;
            submnuInventoryAdjTransaction.Controls.Add(lblInventoryAdjTransaction);
            submnuInventoryAdjTransaction.Dock = DockStyle.Top;
            submnuInventoryAdjTransaction.Location = new Point(0, 65);
            submnuInventoryAdjTransaction.Name = "submnuInventoryAdjTransaction";
            submnuInventoryAdjTransaction.Size = new Size(361, 65);
            submnuInventoryAdjTransaction.TabIndex = 4;
            submnuInventoryAdjTransaction.Click += submnuInventoryAdjTransaction_Click;
            // 
            // lblInventoryAdjTransaction
            // 
            lblInventoryAdjTransaction.AutoSize = true;
            lblInventoryAdjTransaction.Font = new Font("Kh Pen Wappathor", 11F, FontStyle.Bold);
            lblInventoryAdjTransaction.Location = new Point(64, 18);
            lblInventoryAdjTransaction.Name = "lblInventoryAdjTransaction";
            lblInventoryAdjTransaction.Size = new Size(274, 35);
            lblInventoryAdjTransaction.TabIndex = 3;
            lblInventoryAdjTransaction.Text = "Inventory Adj Transaction";
            lblInventoryAdjTransaction.Click += submnuInventoryAdjTransaction_Click;
            // 
            // submnuItemList
            // 
            submnuItemList.BackColor = Color.Transparent;
            submnuItemList.Controls.Add(lblItemList);
            submnuItemList.Dock = DockStyle.Top;
            submnuItemList.Location = new Point(0, 0);
            submnuItemList.Name = "submnuItemList";
            submnuItemList.Size = new Size(361, 65);
            submnuItemList.TabIndex = 3;
            submnuItemList.Click += submnuItemList_Click;
            // 
            // lblItemList
            // 
            lblItemList.AutoSize = true;
            lblItemList.Font = new Font("Kh Pen Wappathor", 11F, FontStyle.Bold);
            lblItemList.Location = new Point(64, 15);
            lblItemList.Name = "lblItemList";
            lblItemList.Size = new Size(103, 35);
            lblItemList.TabIndex = 3;
            lblItemList.Text = "Item List";
            lblItemList.Click += submnuItemList_Click;
            // 
            // mnuInventoryCenter
            // 
            mnuInventoryCenter.BackColor = Color.Transparent;
            mnuInventoryCenter.Controls.Add(lblInventoryCenter);
            mnuInventoryCenter.Controls.Add(picInventoryCenter);
            mnuInventoryCenter.Dock = DockStyle.Top;
            mnuInventoryCenter.Location = new Point(20, 552);
            mnuInventoryCenter.Name = "mnuInventoryCenter";
            mnuInventoryCenter.Size = new Size(361, 65);
            mnuInventoryCenter.TabIndex = 6;
            mnuInventoryCenter.Click += mnuInventoryCenter_Click;
            // 
            // lblInventoryCenter
            // 
            lblInventoryCenter.AutoSize = true;
            lblInventoryCenter.Font = new Font("Kh Pen Wappathor", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryCenter.Location = new Point(59, 15);
            lblInventoryCenter.Name = "lblInventoryCenter";
            lblInventoryCenter.Size = new Size(214, 41);
            lblInventoryCenter.TabIndex = 3;
            lblInventoryCenter.Text = "Inventory Center";
            lblInventoryCenter.Click += mnuInventoryCenter_Click;
            // 
            // picInventoryCenter
            // 
            picInventoryCenter.Image = Properties.Resources.inventory1;
            picInventoryCenter.Location = new Point(10, 14);
            picInventoryCenter.Name = "picInventoryCenter";
            picInventoryCenter.Size = new Size(40, 40);
            picInventoryCenter.SizeMode = PictureBoxSizeMode.StretchImage;
            picInventoryCenter.TabIndex = 0;
            picInventoryCenter.TabStop = false;
            // 
            // pnlSubMenuVendorCenter
            // 
            pnlSubMenuVendorCenter.Controls.Add(submnuPurchaseTransction);
            pnlSubMenuVendorCenter.Controls.Add(submnuVendorList);
            pnlSubMenuVendorCenter.Dock = DockStyle.Top;
            pnlSubMenuVendorCenter.Location = new Point(20, 411);
            pnlSubMenuVendorCenter.Name = "pnlSubMenuVendorCenter";
            pnlSubMenuVendorCenter.Size = new Size(361, 141);
            pnlSubMenuVendorCenter.TabIndex = 5;
            pnlSubMenuVendorCenter.Visible = false;
            // 
            // submnuPurchaseTransction
            // 
            submnuPurchaseTransction.BackColor = Color.Transparent;
            submnuPurchaseTransction.Controls.Add(lblPurchaseTransaction);
            submnuPurchaseTransction.Dock = DockStyle.Top;
            submnuPurchaseTransction.Location = new Point(0, 65);
            submnuPurchaseTransction.Name = "submnuPurchaseTransction";
            submnuPurchaseTransction.Size = new Size(361, 65);
            submnuPurchaseTransction.TabIndex = 4;
            submnuPurchaseTransction.Click += submnuPurchaseTransction_Click;
            // 
            // lblPurchaseTransaction
            // 
            lblPurchaseTransaction.AutoSize = true;
            lblPurchaseTransaction.Font = new Font("Kh Pen Wappathor", 11F, FontStyle.Bold);
            lblPurchaseTransaction.Location = new Point(64, 17);
            lblPurchaseTransaction.Name = "lblPurchaseTransaction";
            lblPurchaseTransaction.Size = new Size(234, 35);
            lblPurchaseTransaction.TabIndex = 3;
            lblPurchaseTransaction.Text = "Purchase Transaction";
            lblPurchaseTransaction.Click += submnuPurchaseTransction_Click;
            // 
            // submnuVendorList
            // 
            submnuVendorList.BackColor = Color.Transparent;
            submnuVendorList.Controls.Add(lblVendorList);
            submnuVendorList.Dock = DockStyle.Top;
            submnuVendorList.Location = new Point(0, 0);
            submnuVendorList.Name = "submnuVendorList";
            submnuVendorList.Size = new Size(361, 65);
            submnuVendorList.TabIndex = 3;
            submnuVendorList.Click += submnuVendorList_Click;
            // 
            // lblVendorList
            // 
            lblVendorList.AutoSize = true;
            lblVendorList.Font = new Font("Kh Pen Wappathor", 11F, FontStyle.Bold);
            lblVendorList.Location = new Point(64, 12);
            lblVendorList.Name = "lblVendorList";
            lblVendorList.Size = new Size(130, 35);
            lblVendorList.TabIndex = 3;
            lblVendorList.Text = "Vendor List";
            lblVendorList.Click += submnuVendorList_Click;
            // 
            // mnuVendorCenter
            // 
            mnuVendorCenter.BackColor = Color.Transparent;
            mnuVendorCenter.Controls.Add(lblVendorCenter);
            mnuVendorCenter.Controls.Add(pictureBox1);
            mnuVendorCenter.Dock = DockStyle.Top;
            mnuVendorCenter.Location = new Point(20, 346);
            mnuVendorCenter.Name = "mnuVendorCenter";
            mnuVendorCenter.Size = new Size(361, 65);
            mnuVendorCenter.TabIndex = 4;
            mnuVendorCenter.Click += mnuVendorCenter_Click;
            // 
            // lblVendorCenter
            // 
            lblVendorCenter.AutoSize = true;
            lblVendorCenter.Font = new Font("Kh Pen Wappathor", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVendorCenter.Location = new Point(59, 15);
            lblVendorCenter.Name = "lblVendorCenter";
            lblVendorCenter.Size = new Size(188, 41);
            lblVendorCenter.TabIndex = 3;
            lblVendorCenter.Text = "Vendor Center";
            lblVendorCenter.Click += mnuVendorCenter_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vendor;
            pictureBox1.Location = new Point(10, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlSubMnuCustomerCenter
            // 
            pnlSubMnuCustomerCenter.Controls.Add(submnuSaleTransaction);
            pnlSubMnuCustomerCenter.Controls.Add(submnuCustomerList);
            pnlSubMnuCustomerCenter.Dock = DockStyle.Top;
            pnlSubMnuCustomerCenter.Location = new Point(20, 205);
            pnlSubMnuCustomerCenter.Name = "pnlSubMnuCustomerCenter";
            pnlSubMnuCustomerCenter.Size = new Size(361, 141);
            pnlSubMnuCustomerCenter.TabIndex = 3;
            pnlSubMnuCustomerCenter.Visible = false;
            // 
            // submnuSaleTransaction
            // 
            submnuSaleTransaction.BackColor = Color.Transparent;
            submnuSaleTransaction.Controls.Add(lblSaleTransaction);
            submnuSaleTransaction.Dock = DockStyle.Top;
            submnuSaleTransaction.Location = new Point(0, 65);
            submnuSaleTransaction.Name = "submnuSaleTransaction";
            submnuSaleTransaction.Size = new Size(361, 65);
            submnuSaleTransaction.TabIndex = 4;
            submnuSaleTransaction.Click += submnuSaleTransaction_Click;
            // 
            // lblSaleTransaction
            // 
            lblSaleTransaction.AutoSize = true;
            lblSaleTransaction.Font = new Font("Kh Pen Wappathor", 11F, FontStyle.Bold);
            lblSaleTransaction.Location = new Point(64, 18);
            lblSaleTransaction.Name = "lblSaleTransaction";
            lblSaleTransaction.Size = new Size(195, 35);
            lblSaleTransaction.TabIndex = 3;
            lblSaleTransaction.Text = "Sales Transaction";
            lblSaleTransaction.Click += submnuSaleTransaction_Click;
            // 
            // submnuCustomerList
            // 
            submnuCustomerList.BackColor = Color.Transparent;
            submnuCustomerList.Controls.Add(lblCustomerList);
            submnuCustomerList.Dock = DockStyle.Top;
            submnuCustomerList.Location = new Point(0, 0);
            submnuCustomerList.Name = "submnuCustomerList";
            submnuCustomerList.Size = new Size(361, 65);
            submnuCustomerList.TabIndex = 3;
            submnuCustomerList.Click += submnuCustomerList_Click;
            // 
            // lblCustomerList
            // 
            lblCustomerList.AutoSize = true;
            lblCustomerList.Font = new Font("Kh Pen Wappathor", 11F, FontStyle.Bold);
            lblCustomerList.Location = new Point(64, 16);
            lblCustomerList.Name = "lblCustomerList";
            lblCustomerList.Size = new Size(155, 35);
            lblCustomerList.TabIndex = 3;
            lblCustomerList.Text = "Customer List";
            lblCustomerList.Click += submnuCustomerList_Click;
            // 
            // mnuCustomerCenter
            // 
            mnuCustomerCenter.BackColor = Color.Transparent;
            mnuCustomerCenter.Controls.Add(lblCustomerCenter);
            mnuCustomerCenter.Controls.Add(picCustomerCenter);
            mnuCustomerCenter.Dock = DockStyle.Top;
            mnuCustomerCenter.Location = new Point(20, 140);
            mnuCustomerCenter.Name = "mnuCustomerCenter";
            mnuCustomerCenter.Size = new Size(361, 65);
            mnuCustomerCenter.TabIndex = 2;
            mnuCustomerCenter.Click += mnuCustomerCenter_Click;
            // 
            // lblCustomerCenter
            // 
            lblCustomerCenter.AutoSize = true;
            lblCustomerCenter.Font = new Font("Kh Pen Wappathor", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerCenter.Location = new Point(59, 15);
            lblCustomerCenter.Name = "lblCustomerCenter";
            lblCustomerCenter.Size = new Size(216, 41);
            lblCustomerCenter.TabIndex = 3;
            lblCustomerCenter.Text = "Customer Center";
            lblCustomerCenter.Click += mnuCustomerCenter_Click;
            // 
            // picCustomerCenter
            // 
            picCustomerCenter.Image = Properties.Resources.customer;
            picCustomerCenter.Location = new Point(10, 14);
            picCustomerCenter.Name = "picCustomerCenter";
            picCustomerCenter.Size = new Size(40, 40);
            picCustomerCenter.SizeMode = PictureBoxSizeMode.StretchImage;
            picCustomerCenter.TabIndex = 0;
            picCustomerCenter.TabStop = false;
            // 
            // mnuPOS
            // 
            mnuPOS.BackColor = Color.Transparent;
            mnuPOS.Controls.Add(lblPOS);
            mnuPOS.Controls.Add(picPOS);
            mnuPOS.Dock = DockStyle.Top;
            mnuPOS.Location = new Point(20, 75);
            mnuPOS.Name = "mnuPOS";
            mnuPOS.Size = new Size(361, 65);
            mnuPOS.TabIndex = 1;
            mnuPOS.Click += mnuPOS_Click;
            // 
            // lblPOS
            // 
            lblPOS.AutoSize = true;
            lblPOS.Font = new Font("Kh Pen Wappathor", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPOS.Location = new Point(59, 15);
            lblPOS.Name = "lblPOS";
            lblPOS.Size = new Size(68, 41);
            lblPOS.TabIndex = 3;
            lblPOS.Text = "POS";
            lblPOS.Click += mnuPOS_Click;
            // 
            // picPOS
            // 
            picPOS.Image = Properties.Resources.pos;
            picPOS.Location = new Point(10, 14);
            picPOS.Name = "picPOS";
            picPOS.Size = new Size(40, 40);
            picPOS.SizeMode = PictureBoxSizeMode.StretchImage;
            picPOS.TabIndex = 0;
            picPOS.TabStop = false;
            // 
            // mnuDashbaord
            // 
            mnuDashbaord.BackColor = Color.Transparent;
            mnuDashbaord.Controls.Add(lblDashbaord);
            mnuDashbaord.Controls.Add(picDashbaord);
            mnuDashbaord.Dock = DockStyle.Top;
            mnuDashbaord.Location = new Point(20, 10);
            mnuDashbaord.Name = "mnuDashbaord";
            mnuDashbaord.Size = new Size(361, 65);
            mnuDashbaord.TabIndex = 0;
            // 
            // lblDashbaord
            // 
            lblDashbaord.AutoSize = true;
            lblDashbaord.Font = new Font("Kh Pen Wappathor", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashbaord.Location = new Point(59, 15);
            lblDashbaord.Name = "lblDashbaord";
            lblDashbaord.Size = new Size(145, 41);
            lblDashbaord.TabIndex = 3;
            lblDashbaord.Text = "Dashboard";
            // 
            // picDashbaord
            // 
            picDashbaord.Image = Properties.Resources.dashboard;
            picDashbaord.Location = new Point(10, 14);
            picDashbaord.Name = "picDashbaord";
            picDashbaord.Size = new Size(40, 40);
            picDashbaord.SizeMode = PictureBoxSizeMode.StretchImage;
            picDashbaord.TabIndex = 0;
            picDashbaord.TabStop = false;
            // 
            // pnlLine
            // 
            pnlLine.BackColor = Color.Black;
            pnlLine.Dock = DockStyle.Left;
            pnlLine.Location = new Point(401, 136);
            pnlLine.Name = "pnlLine";
            pnlLine.Size = new Size(5, 919);
            pnlLine.TabIndex = 2;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(406, 136);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(789, 919);
            pnlMain.TabIndex = 3;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 1055);
            Controls.Add(pnlMain);
            Controls.Add(pnlLine);
            Controls.Add(pnlMenuBar);
            Controls.Add(pnlTitleBar);
            Name = "FrmMain";
            Text = "FrmMain";
            WindowState = FormWindowState.Maximized;
            Load += FrmMain_Load;
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlMenuBar.ResumeLayout(false);
            pnlSubUserManagement.ResumeLayout(false);
            submnuUserAccountPerssion.ResumeLayout(false);
            submnuUserAccountPerssion.PerformLayout();
            mnuUserCenter.ResumeLayout(false);
            mnuUserCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlSubMenuEmployeeCenter.ResumeLayout(false);
            submnuEmployeeList.ResumeLayout(false);
            submnuEmployeeList.PerformLayout();
            mnuEmployeeCenter.ResumeLayout(false);
            mnuEmployeeCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlSubMenuInventoryAdjCenter.ResumeLayout(false);
            submnuInventoryAdjTransaction.ResumeLayout(false);
            submnuInventoryAdjTransaction.PerformLayout();
            submnuItemList.ResumeLayout(false);
            submnuItemList.PerformLayout();
            mnuInventoryCenter.ResumeLayout(false);
            mnuInventoryCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picInventoryCenter).EndInit();
            pnlSubMenuVendorCenter.ResumeLayout(false);
            submnuPurchaseTransction.ResumeLayout(false);
            submnuPurchaseTransction.PerformLayout();
            submnuVendorList.ResumeLayout(false);
            submnuVendorList.PerformLayout();
            mnuVendorCenter.ResumeLayout(false);
            mnuVendorCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlSubMnuCustomerCenter.ResumeLayout(false);
            submnuSaleTransaction.ResumeLayout(false);
            submnuSaleTransaction.PerformLayout();
            submnuCustomerList.ResumeLayout(false);
            submnuCustomerList.PerformLayout();
            mnuCustomerCenter.ResumeLayout(false);
            mnuCustomerCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCustomerCenter).EndInit();
            mnuPOS.ResumeLayout(false);
            mnuPOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPOS).EndInit();
            mnuDashbaord.ResumeLayout(false);
            mnuDashbaord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDashbaord).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitleBar;
        private Panel pnlMenuBar;
        private Panel mnuDashbaord;
        private PictureBox picDashbaord;
        private Panel pnlLine;
        private PictureBox picLogo;
        private Label lblTitle;
        private Label lblDashbaord;
        private Label lblEmployeeList;
        private Panel mnuCustomerCenter;
        private Label lblCustomerCenter;
        private PictureBox picCustomerCenter;
        private Panel pnlSubMnuCustomerCenter;
        private Panel mnuPOS;
        private Label lblPOS;
        private PictureBox picPOS;
        private Panel submnuCustomerList;
        private Label lblCustomerList;
        private Panel submnuSaleTransaction;
        private Label lblSaleTransaction;
        private Panel pnlSubMenuVendorCenter;
        private Panel submnuPurchaseTransction;
        private Label lblPurchaseTransaction;
        private Panel submnuVendorList;
        private Label lblVendorList;
        private Panel mnuVendorCenter;
        private Label lblVendorCenter;
        private PictureBox pictureBox1;
        private Panel pnlSubMenuInventoryAdjCenter;
        private Panel submnuInventoryAdjTransaction;
        private Label lblInventoryAdjTransaction;
        private Panel submnuItemList;
        private Label lblItemList;
        private Panel mnuInventoryCenter;
        private Label lblInventoryCenter;
        private PictureBox picInventoryCenter;
        private Panel pnlSubMenuEmployeeCenter;
        private Panel submnuEmployeeList;
        private Panel mnuEmployeeCenter;
        private Label lblEmployeeCenter;
        private PictureBox pictureBox2;
        private Panel pnlSubUserManagement;
        private Panel submnuUserAccountPerssion;
        private Label submnuUserAccountPermission;
        private Panel mnuUserCenter;
        private Label lblUserManagement;
        private PictureBox pictureBox3;
        private Panel pnlMain;
    }
}