using grocery_store.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;

namespace grocery_store.GUI.BanHang
{
    public partial class Item : UserControl
    {
        public event EventHandler RemoveClick;
        public event EventHandler QuantityChanged;
        private System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VI");
        public byte[] BarCode { get; set; }
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
        public string LineTotal
        {
            get => label_totalLine.Text;
            set => label_totalLine.Text = value;
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

        public void generate_barcode()
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.CODE_128;
            writer.Options = new EncodingOptions
            {
                Height = 60,
                Width = 360
            };

            Bitmap bitmap = writer.Write(DateTime.Now.ToString("ddMMyyyyHHmm"));
            MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            this.BarCode = ms.ToArray();
        }
    }
}
