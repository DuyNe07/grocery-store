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
        public string Quantity
        {
            get => label_quantity.Text;
            set => label_quantity.Text = value;
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
        public Item(int quantity)
        {
            InitializeComponent();
            this.btn_del.Click += (sender, e) => ButtonClick?.Invoke(this, e);
            this.Quantity = quantity.ToString();
        }


    }
}
