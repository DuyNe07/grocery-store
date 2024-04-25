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

namespace grocery_store.GUI.HangHoa
{
    public partial class SanPham : UserControl
    {
        public event EventHandler HuyClick;
        public event EventHandler LuuClick;
        private Product product;


        public SanPham(Product product)
        {
            InitializeComponent();
            this.btn_huy.Click += (sender, e) => HuyClick?.Invoke(this, e);
            this.btn_luu.Click += (sender, e) => LuuClick?.Invoke(this, e);
            this.product = product;
            
        }

        

        private void SanPham_Load(object sender, EventArgs e)
        {

        }

        public void run()
        {
            MessageBox.Show(tb_ten_san_pham.Text);
        }
    }
}
