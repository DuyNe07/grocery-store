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
        public event EventHandler RemoveClick;
        public event EventHandler QuantityChanged;
        private System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VI");
        public Product Product { get; set; }
        public int Quantity
        {
            get => int.Parse(Num_quantity.Text);
            set => Num_quantity.Text = value.ToString();
        }
        public string NameProduct
        {
            get => label_nameProduct.Text;
            set => label_nameProduct.Text = value;
        }
        public string Price
        {
            get => label_marketPrice.Text;
            set => label_marketPrice.Text = value;
        }
        public float LineTotal
        {
            get => float.Parse(label_totalLine.Text.Replace(".", ""));
            set => label_totalLine.Text = value.ToString("N0", culture);
        }
        public Item(Product product)
        {
            InitializeComponent();

            this.Product = product;
            this.btn_del.Click += (sender, e) => RemoveClick?.Invoke(this, e);
            this.Num_quantity.TextChanged += (sender, e) => QuantityChanged?.Invoke(this, e);
            this.Quantity = 1;
            this.NameProduct = product.Name;
            this.label_nameProduct.Location = new Point(120 - (label_nameProduct.Width / 2), 40);
            string formattedPrice = product.MarketPrice.ToString("N0", culture);
            this.Price = formattedPrice;
        }
    }
}
