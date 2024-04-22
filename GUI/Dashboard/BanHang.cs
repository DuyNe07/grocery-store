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
using grocery_store.Models;

namespace grocery_store.GUI.Dashboard
{
    public partial class BanHang : UserControl
    {
        List<Item> items = new List<Item>();
        GroceryStoreContext db = new GroceryStoreContext();
        public BanHang()
        {
            InitializeComponent();
        }
        public event EventHandler ButtonClick;
        

        private void refresh()
        {
            panel_products.Controls.Clear();
            int y_start = 30;
            foreach (Item item in items)
            {
                item.Location = new Point(70, y_start);
                item.BackColor = Color.White;

                panel_products.Controls.Add(item);
                y_start += 90;
            }
        }
        int i = 1;
        private void btn_scan_Click(object sender, EventArgs e)
        {
            //Item item = new Item(i);
            //i += 1;
            ////tôi muốn thêm sự kiện là khi click vào button xóa thì sẽ xóa item đó khỏi danh sách
            //item.ButtonClick += (s, args) =>
            //{
            //    items.Remove(item);
            //    refresh();
            //};
            //items.Add(item);
            //refresh();
        }

        private void updateTotal()
        {
            int total = 0;
            foreach (Item item in items)
            {
                string priceWithoutSeparators = item.Price.Replace(".", "");
                total += int.Parse(priceWithoutSeparators) * int.Parse(item.Quantity);

            }
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");
            string formattedTotal = total.ToString("N0");

            label_totalPrice.Text = formattedTotal.ToString();
            label_totalPrice.Location = new Point(1075 - label_totalPrice.Width / 2, 768);
        }


        private void btn_enterCode_Click(object sender, EventArgs e)
        {
            if(txtbox_enterCode.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm");
                return;
            }
            else
            {
                Product product = db.Product.Where(p => p.Sku == txtbox_enterCode.Text).FirstOrDefault();
                if (product == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm");
                    return;
                }
                else
                {
                    //kiểm tra xem sản phẩm đã có trong danh sách chưa nếu có thì cộng dồn số lượng
                    foreach (Item i in items)
                    {
                        if (i.NameProduct == product.Name)
                        {
                            int quantity = int.Parse(i.Quantity);
                            quantity += 1;
                            i.Quantity = quantity.ToString();
                            return;
                        }
                    }
                    Item item = new Item(product);
                    item.label_price.Location = new Point(590 - (item.label_price.Width / 2), 35);
                    item.ButtonClick += (s, args) =>
                    {
                        items.Remove(item);
                        refresh();
                    };
                    item.QuantityChanged += (s, args) =>
                    {
                        updateTotal();
                    };
                    items.Add(item);
                    updateTotal();
                    refresh();
                }
            }
        }
    }
}
