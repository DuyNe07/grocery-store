using grocery_store.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grocery_store.GUI.HangHoa
{
    public partial class DanhSachSanPham : UserControl
    {
        public DanhSachSanPham()
        {
            InitializeComponent();
        }

        private void txtbox_tim_kiem_Enter(object sender, EventArgs e)
        {
            txtbox_tim_kiem.Text = "";
        }

        private void txtbox_tim_kiem_Leave(object sender, EventArgs e)
        {
            txtbox_tim_kiem.Text = "Tìm Kiếm";
        }

        private void DanhSachSanPham_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private async void RefreshGridView()
        {
            // Lấy danh sách sản phẩm từ cơ sở dữ liệu bằng Entity Framework
            using (var dbContext = new GroceryStoreContext())
            {
                List<Product> products = await dbContext.Product.ToListAsync();

                DataTable dt = new DataTable();
                dt.Columns.Add("ProductId", typeof(int));
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Category", typeof(string));
                dt.Columns.Add("Supplier", typeof(string));
                dt.Columns.Add("QuantityInStock", typeof(int));
                dt.Columns.Add("CostPrice", typeof(string));
                dt.Columns.Add("MarketPrice", typeof(string));

                foreach (Product product in products)
                {
                    // Định dạng giá thành và giá thị trường thành chuỗi không có số thập phân và đơn vị là "đ"
                    string formattedCostPrice = string.Format("{0:N0}", product.CostPrice);
                    string formattedMarketPrice = string.Format("{0:N0}", product.MarketPrice);


                    dt.Rows.Add(product.ProductId, product.Name, product.Category, product.Supplier, product.QuantityInStock, formattedCostPrice, formattedMarketPrice);
                }
                // Gán danh sách sản phẩm cho DataSource của DataGridView
                gridview_danh_sach_san_pham.DataSource = dt;
            }

        }



        //Xử lý: Thêm sản Phẩm
        private void btn_them_Click(object sender, EventArgs e)
        {
            SanPham san_pham = new SanPham(null);
            san_pham.Location = new Point(0,0);
            san_pham.HuyClick += async (s, args) =>
            {
                this.Controls.Remove(san_pham);
            };
            Product product = new Product();
            san_pham.LuuClick += async (s, args) =>
            {
                san_pham.run();
                this.Controls.Remove(san_pham);
            };


            this.Controls.Add(san_pham);
            san_pham.BringToFront();
        }
    }
}
