using grocery_store.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grocery_store.GUI.BanHang
{
    public partial class Item : UserControl
    {
        public event EventHandler ButtonClick;
        public event EventHandler QuantityChanged;

        public Product Product { get; set; }
        public string Quantity
        {
            get => domainUpDown_quantity.Text;
            set => domainUpDown_quantity.Text = value;
        }
        public string NameProduct
        {
            get => label_nameProduct.Text;
            set => label_nameProduct.Text = value;
        }
        public string Price
        {
            get => label_price.Text;
            set => label_price.Text = value;
        }
        public Item(Product product)
        {
            InitializeComponent();
            generateQuantity();

            this.btn_del.Click += (sender, e) => ButtonClick?.Invoke(this, e);
            this.domainUpDown_quantity.TextChanged += (sender, e) => QuantityChanged?.Invoke(this, e);
            this.Quantity = "1";
            this.NameProduct = product.Name;

            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");
            string formattedPrice = product.MarketPrice.ToString("N0");
            this.Price = formattedPrice;
        }

        private void generateQuantity()
        {
            domainUpDown_quantity.Items.Clear();
            for (int i = 99; i >= 1; i--)
            {
                domainUpDown_quantity.Items.Add(i.ToString());
            }
        }
    }
}
