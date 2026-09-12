namespace BookShopWinFrm.BusinessLayer
{
    partial class FrmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlCard1 = new Panel();
            lblTotalRevenue = new Label();
            lblTitleRevenue = new Label();
            pnlCard2 = new Panel();
            lblTotalStock = new Label();
            lblTitleStock = new Label();
            pnlCard3 = new Panel();
            lblTotalCustomers = new Label();
            lblTitleCustomers = new Label();
            pnlCard4 = new Panel();
            lblTotalEmployees = new Label();
            lblTitleEmployees = new Label();
            dgRecentSales = new DataGridView();
            lblGridTitle = new Label();
            pnlCard1.SuspendLayout();
            pnlCard2.SuspendLayout();
            pnlCard3.SuspendLayout();
            pnlCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgRecentSales).BeginInit();
            SuspendLayout();
            // 
            // pnlCard1
            // 
            pnlCard1.BackColor = Color.FromArgb(40, 167, 69);
            pnlCard1.Controls.Add(lblTotalRevenue);
            pnlCard1.Controls.Add(lblTitleRevenue);
            pnlCard1.Location = new Point(30, 30);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new Size(220, 120);
            pnlCard1.TabIndex = 0;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalRevenue.ForeColor = Color.White;
            lblTotalRevenue.Location = new Point(15, 50);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(98, 46);
            lblTotalRevenue.TabIndex = 1;
            lblTotalRevenue.Text = "$ 0.0";
            // 
            // lblTitleRevenue
            // 
            lblTitleRevenue.AutoSize = true;
            lblTitleRevenue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitleRevenue.ForeColor = Color.White;
            lblTitleRevenue.Location = new Point(15, 15);
            lblTitleRevenue.Name = "lblTitleRevenue";
            lblTitleRevenue.Size = new Size(136, 25);
            lblTitleRevenue.TabIndex = 0;
            lblTitleRevenue.Text = "Total Revenue";
            // 
            // pnlCard2
            // 
            pnlCard2.BackColor = Color.FromArgb(23, 162, 184);
            pnlCard2.Controls.Add(lblTotalStock);
            pnlCard2.Controls.Add(lblTitleStock);
            pnlCard2.Location = new Point(270, 30);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Size = new Size(220, 120);
            pnlCard2.TabIndex = 1;
            // 
            // lblTotalStock
            // 
            lblTotalStock.AutoSize = true;
            lblTotalStock.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalStock.ForeColor = Color.White;
            lblTotalStock.Location = new Point(15, 50);
            lblTotalStock.Name = "lblTotalStock";
            lblTotalStock.Size = new Size(40, 46);
            lblTotalStock.TabIndex = 1;
            lblTotalStock.Text = "0";
            // 
            // lblTitleStock
            // 
            lblTitleStock.AutoSize = true;
            lblTitleStock.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitleStock.ForeColor = Color.White;
            lblTitleStock.Location = new Point(15, 15);
            lblTitleStock.Name = "lblTitleStock";
            lblTitleStock.Size = new Size(145, 25);
            lblTitleStock.TabIndex = 0;
            lblTitleStock.Text = "Books In Stock";
            // 
            // pnlCard3
            // 
            pnlCard3.BackColor = Color.FromArgb(255, 193, 7);
            pnlCard3.Controls.Add(lblTotalCustomers);
            pnlCard3.Controls.Add(lblTitleCustomers);
            pnlCard3.Location = new Point(510, 30);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Size = new Size(220, 120);
            pnlCard3.TabIndex = 2;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalCustomers.ForeColor = Color.White;
            lblTotalCustomers.Location = new Point(15, 50);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(40, 46);
            lblTotalCustomers.TabIndex = 1;
            lblTotalCustomers.Text = "0";
            // 
            // lblTitleCustomers
            // 
            lblTitleCustomers.AutoSize = true;
            lblTitleCustomers.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitleCustomers.ForeColor = Color.White;
            lblTitleCustomers.Location = new Point(15, 15);
            lblTitleCustomers.Name = "lblTitleCustomers";
            lblTitleCustomers.Size = new Size(154, 25);
            lblTitleCustomers.TabIndex = 0;
            lblTitleCustomers.Text = "Total Customers";
            // 
            // pnlCard4
            // 
            pnlCard4.BackColor = Color.FromArgb(108, 117, 125);
            pnlCard4.Controls.Add(lblTotalEmployees);
            pnlCard4.Controls.Add(lblTitleEmployees);
            pnlCard4.Location = new Point(750, 30);
            pnlCard4.Name = "pnlCard4";
            pnlCard4.Size = new Size(220, 120);
            pnlCard4.TabIndex = 3;
            // 
            // lblTotalEmployees
            // 
            lblTotalEmployees.AutoSize = true;
            lblTotalEmployees.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalEmployees.ForeColor = Color.White;
            lblTotalEmployees.Location = new Point(15, 50);
            lblTotalEmployees.Name = "lblTotalEmployees";
            lblTotalEmployees.Size = new Size(40, 46);
            lblTotalEmployees.TabIndex = 1;
            lblTotalEmployees.Text = "0";
            // 
            // lblTitleEmployees
            // 
            lblTitleEmployees.AutoSize = true;
            lblTitleEmployees.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitleEmployees.ForeColor = Color.White;
            lblTitleEmployees.Location = new Point(15, 15);
            lblTitleEmployees.Name = "lblTitleEmployees";
            lblTitleEmployees.Size = new Size(154, 25);
            lblTitleEmployees.TabIndex = 0;
            lblTitleEmployees.Text = "Total Employees";
            // 
            // dgRecentSales
            // 
            dgRecentSales.AllowUserToAddRows = false;
            dgRecentSales.AllowUserToDeleteRows = false;
            dgRecentSales.AllowUserToResizeColumns = false;
            dgRecentSales.AllowUserToResizeRows = false;
            dgRecentSales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgRecentSales.BackgroundColor = Color.White;
            dgRecentSales.BorderStyle = BorderStyle.None;
            dgRecentSales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgRecentSales.ColumnHeadersHeight = 40;
            dgRecentSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgRecentSales.Location = new Point(30, 210);
            dgRecentSales.MultiSelect = false;
            dgRecentSales.Name = "dgRecentSales";
            dgRecentSales.ReadOnly = true;
            dgRecentSales.RowHeadersVisible = false;
            dgRecentSales.RowHeadersWidth = 50;
            dgRecentSales.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgRecentSales.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
            dgRecentSales.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgRecentSales.RowTemplate.Height = 30;
            dgRecentSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgRecentSales.Size = new Size(940, 360);
            dgRecentSales.TabIndex = 4;
            dgRecentSales.CellPainting += dgRecentSales_CellPainting;
            dgRecentSales.RowPostPaint += dgRecentSales_RowPostPaint;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblGridTitle.Location = new Point(30, 170);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(269, 32);
            lblGridTitle.TabIndex = 5;
            lblGridTitle.Text = "Recent Sales Overview";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1000, 600);
            Controls.Add(lblGridTitle);
            Controls.Add(dgRecentSales);
            Controls.Add(pnlCard4);
            Controls.Add(pnlCard3);
            Controls.Add(pnlCard2);
            Controls.Add(pnlCard1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDashboard";
            Text = "FrmDashboard";
            Load += FrmDashboard_Load;
            pnlCard1.ResumeLayout(false);
            pnlCard1.PerformLayout();
            pnlCard2.ResumeLayout(false);
            pnlCard2.PerformLayout();
            pnlCard3.ResumeLayout(false);
            pnlCard3.PerformLayout();
            pnlCard4.ResumeLayout(false);
            pnlCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgRecentSales).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTitleRevenue;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblTotalStock;
        private System.Windows.Forms.Label lblTitleStock;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label lblTitleCustomers;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblTotalEmployees;
        private System.Windows.Forms.Label lblTitleEmployees;
        private System.Windows.Forms.DataGridView dgRecentSales;
        private System.Windows.Forms.Label lblGridTitle;
    }
}