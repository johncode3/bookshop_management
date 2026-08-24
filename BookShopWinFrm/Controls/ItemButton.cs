using BookShopWinFrm.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookShopWinFrm.Controls
{
    public partial class ItemButton : UserControl
    {
        public Item Data { get; set; }
        public EventHandler ItemClick { get; set; }
        public ItemButton(Item item)
        {
            InitializeComponent();
            this.Data = item;
            this.Click += ItemButton_InternalClick;
            WireUpChildrenClicks(this);
        }
        private void WireUpChildrenClicks(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                child.Click += ItemButton_InternalClick;
                if (child.HasChildren)
                {
                    WireUpChildrenClicks(child);
                }
            }
        }

        private void ItemButton_InternalClick(object sender, EventArgs e)
        {
            ItemClick?.Invoke(this, e);
        }
        private void ItemButton_Click(object sender, EventArgs e)
        {
            if (this.ItemClick != null)
                this.ItemClick(this, e);
        }
        private void ItemButton_Load(object sender, EventArgs e)
        {
            if (this.Data == null) return;

            txtItemName.Text = this.Data.ItemName;
            lblPrice.Text = this.Data.SalePrice.ToString("$ 0.00");
            lblQuantity.Text = this.Data.Quantity.ToString("0 (ea)");

            if (this.Data.Thumnail != null && this.Data.Thumnail.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(this.Data.Thumnail))
                    {
                        picThumbnail.Image = new Bitmap(Image.FromStream(ms));
                    }
                }
                catch
                {
                    // Handle broken stream gracefully
                }
            }
        }
    }
}
