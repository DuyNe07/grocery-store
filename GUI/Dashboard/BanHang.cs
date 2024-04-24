using grocery_store.GUI.BanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grocery_store.GUI.Dashboard
{
    public partial class BanHang : UserControl
    {
        List<Item> items = new List<Item>();
        public BanHang()
        {
            InitializeComponent();
        }
        public event EventHandler ButtonClick;
        

        private void refresh()
        {
            panel_products.Controls.Clear();
            int y_start = 80;
            foreach (Item item in items)
            {
                item.Location = new Point(95, y_start);
                item.BackColor = Color.White;

                panel_products.Controls.Add(item);
                y_start += 150;
            }
        }
        int i = 1;
        private void btn_scan_Click(object sender, EventArgs e)
        {
            Item item = new Item(i);
            i += 1;
            //tôi muốn thêm sự kiện là khi click vào button xóa thì sẽ xóa item đó khỏi danh sách
            item.ButtonClick += (s, args) =>
            {
                items.Remove(item);
                refresh();
            };
            items.Add(item);
            refresh();
        }
    }
}
