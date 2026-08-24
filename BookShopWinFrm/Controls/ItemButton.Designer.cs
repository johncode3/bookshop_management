namespace BookShopWinFrm.Controls
{
    partial class ItemButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picThumbnail = new PictureBox();
            pnlToolBar = new Panel();
            lblQuantity = new Label();
            lblPrice = new Label();
            txtItemName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picThumbnail).BeginInit();
            pnlToolBar.SuspendLayout();
            SuspendLayout();
            // 
            // picThumbnail
            // 
            picThumbnail.Dock = DockStyle.Top;
            picThumbnail.Image = Properties.Resources.Notebook;
            picThumbnail.Location = new Point(5, 5);
            picThumbnail.Name = "picThumbnail";
            picThumbnail.Size = new Size(178, 224);
            picThumbnail.SizeMode = PictureBoxSizeMode.Zoom;
            picThumbnail.TabIndex = 0;
            picThumbnail.TabStop = false;
            // 
            // pnlToolBar
            // 
            pnlToolBar.Controls.Add(lblQuantity);
            pnlToolBar.Controls.Add(lblPrice);
            pnlToolBar.Dock = DockStyle.Bottom;
            pnlToolBar.Location = new Point(5, 289);
            pnlToolBar.Name = "pnlToolBar";
            pnlToolBar.Size = new Size(178, 35);
            pnlToolBar.TabIndex = 1;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Dock = DockStyle.Right;
            lblQuantity.Location = new Point(141, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(37, 23);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Qty";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Left;
            lblPrice.Location = new Point(0, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(47, 23);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "Price";
            // 
            // txtItemName
            // 
            txtItemName.BackColor = Color.White;
            txtItemName.BorderStyle = BorderStyle.None;
            txtItemName.Dock = DockStyle.Fill;
            txtItemName.Location = new Point(5, 229);
            txtItemName.Multiline = true;
            txtItemName.Name = "txtItemName";
            txtItemName.ReadOnly = true;
            txtItemName.Size = new Size(178, 60);
            txtItemName.TabIndex = 2;
            // 
            // ItemButton
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(txtItemName);
            Controls.Add(pnlToolBar);
            Controls.Add(picThumbnail);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ItemButton";
            Padding = new Padding(5);
            Size = new Size(188, 329);
            Load += ItemButton_Load;
            Click += ItemButton_Click;
            ((System.ComponentModel.ISupportInitialize)picThumbnail).EndInit();
            pnlToolBar.ResumeLayout(false);
            pnlToolBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picThumbnail;
        private Panel pnlToolBar;
        private Label lblPrice;
        private Label lblQuantity;
        private TextBox txtItemName;
    }
}
