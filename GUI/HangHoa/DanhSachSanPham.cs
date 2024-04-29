using grocery_store.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grocery_store.GUI.HangHoa
{
    public partial class DanhSachSanPham : UserControl
    {
        private Product currentProduct;
        private int indexCurrentRow;
        public DanhSachSanPham()
        {
            InitializeComponent();
        }

        #region Chức năng thêm sản phẩm
        private void btn_them_Click(object sender, EventArgs e)
        {
            SanPham UC_san_pham = new SanPham(null);
            UC_san_pham.lb_name_control.Text = "THÊM SẢN PHẨM";
            UC_san_pham.Location = new Point(0, 0);

            // Hủy
            UC_san_pham.HuyClick += (s, args) =>
            {
                this.Controls.Remove(UC_san_pham);
            };

            // Thực thi
            UC_san_pham.LuuClick += async (s, args) =>
            {
                Product newProdcut = await UC_san_pham.Them();

                if (newProdcut != null)
                {
                    this.Controls.Remove(UC_san_pham);
                    gridview_danh_sach_san_pham.DataSource = await GetProducTable();
                    UpdateSoDong();
                }
            };
            this.Controls.Add(UC_san_pham);
            UC_san_pham.BringToFront();
        }
        #endregion

        #region Chức năng sửa sản phẩm
        private void btn_sua_Click(object sender, EventArgs e)
        {
            SanPham UC_san_pham = new SanPham(currentProduct);
            UC_san_pham.lb_name_control.Text = "SỬA SẢN PHẨM";
            UC_san_pham.Location = new Point(0, 0);
            UC_san_pham.HuyClick += (s, args) =>
            {
                this.Controls.Remove(UC_san_pham);
            };
            UC_san_pham.LuuClick += async (s, args) =>
            {
                Product productUpdate = await UC_san_pham.Sua(currentProduct);

                if (productUpdate != null)
                {
                    this.Controls.Remove(UC_san_pham);
                    gridview_danh_sach_san_pham.DataSource = await GetProducTable();
                    currentProduct = productUpdate;
                }
            };
            this.Controls.Add(UC_san_pham);
            UC_san_pham.BringToFront();
        }

        #endregion

        #region Chức năng xóa sản phẩm
        private async void btn_xoa_ClickAsync(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xóa sản phẩm " + currentProduct.Name, "Xác Nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                await DeleteProductByID(currentProduct.ProductId);
                gridview_danh_sach_san_pham.DataSource = await GetProducTable();
                UpdateSoDong();
            }
        }
        private async Task DeleteProductByID(int productID)
        {
            using (var dbContext = new GroceryStoreContext())
            {
                Product productToDelete = await dbContext.Product.FindAsync(productID);
                if (productToDelete != null)
                {
                    try
                    {
                        dbContext.Product.Remove(productToDelete);
                        await dbContext.SaveChangesAsync();
                        MessageBox.Show("Sản phẩm đã được xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Không thể xóa sản phẩm. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm cần xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #endregion

        private async void gridview_danh_sach_san_pham_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            indexCurrentRow = e.RowIndex;

            DataGridViewRow selectedRow = gridview_danh_sach_san_pham.Rows[indexCurrentRow];

            if (selectedRow != null)
            {
                int productId = Convert.ToInt32(selectedRow.Cells[0].Value);
                using (var dbContext = new GroceryStoreContext())
                {
                    currentProduct = await dbContext.Product.Include(p => p.Category).Include(p => p.Supplier).FirstOrDefaultAsync(p => p.ProductId == productId);
                }
            }
        }


        #region Xử Lý Giao Diện
        private async void DanhSachSanPham_Load(object sender, EventArgs e)
        {
            gridview_danh_sach_san_pham.DataSource = await GetProducTable();
            await LoadCombobox();
            UpdateSoDong();
        }
        private void UpdateSoDong()
        {
            lb_so_dong.Text = gridview_danh_sach_san_pham.RowCount.ToString();
        }
        private async Task LoadCombobox()
        {
            using (var dbContext = new GroceryStoreContext())
            {
                // Thực hiện các tác vụ trên DbContext
                var categories = await dbContext.Category.ToListAsync();
                var suppliers = await dbContext.Supplier.ToListAsync();

                // Thêm mục mặc định vào danh sách
                categories.Insert(0, new Category { CategoryId = -1, Name = "Phân loại (All)" });
                suppliers.Insert(0, new Supplier { SupplierId = -1, Name = "Nhà Cung Cấp (All)" });

  
                cbb_nha_cung_cap.DisplayMember = "Name";
                cbb_nha_cung_cap.ValueMember = "SupplierID";
                cbb_nha_cung_cap.DataSource = suppliers;

                cbb_phan_loai.DisplayMember = "Name";
                cbb_phan_loai.ValueMember = "CategoryId";
                cbb_phan_loai.DataSource = categories;

                // Chọn mục đầu tiên là mục mặc định
                cbb_phan_loai.SelectedIndex = 0;
                cbb_nha_cung_cap.SelectedIndex = 0;
            }
        }
        private void txtbox_tim_kiem_Enter(object sender, EventArgs e)
        {
            txtbox_tim_kiem.Text = "";
        }

        private void txtbox_tim_kiem_Leave(object sender, EventArgs e)
        {
            txtbox_tim_kiem.Text = "Tìm Kiếm";
        }
        #endregion

        #region DB Util
        private async Task<DataTable> GetProducTable()
        {
            DataTable ProductTable = new DataTable();
            ProductTable.Columns.Add("ProductId", typeof(int));
            ProductTable.Columns.Add("SKU", typeof(string));
            ProductTable.Columns.Add("Name", typeof(string));
            ProductTable.Columns.Add("Expiry", typeof(string));
            ProductTable.Columns.Add("Category", typeof(string));
            ProductTable.Columns.Add("Supplier", typeof(string));
            ProductTable.Columns.Add("QuantityInStock", typeof(int));
            ProductTable.Columns.Add("CostPrice", typeof(string));
            ProductTable.Columns.Add("MarketPrice", typeof(string));

            List<Product> products = await GetProductList();

            foreach (Product product in products)
            {
                string formattedCostPrice = string.Format("{0:N0}", product.CostPrice);
                string formattedMarketPrice = string.Format("{0:N0}", product.MarketPrice);
                DateTime expiry = (DateTime)product.Expiry;
                string formatedExpiry = expiry.Month + "/" + expiry.Day + "/" + expiry.Year;

                ProductTable.Rows.Add(product.ProductId,
                            product.Sku,
                            product.Name,
                            formatedExpiry,
                            product.Category.Name,
                            product.Supplier.Name,
                            product.QuantityInStock,
                            formattedCostPrice,
                            formattedMarketPrice);
            }
            return ProductTable;
        }
        private async Task<List<Product>> GetProductList()
        {
            List<Product> products;
            using (var dbContext = new GroceryStoreContext())
            {
                products = await dbContext.Product
                    .Include(p => p.Category)
                    .Include(p => p.Supplier)
                    //.Where(p => p.Name == ProductName?)
                    //.Where(p => p.CategoryId == CategoryID?)
                    //.Where(p => p.SupplierId == SupplierID?)
                    .ToListAsync();
            }
            return products;
        }
        #endregion


    }
}
