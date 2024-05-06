using grocery_store.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
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
            LoadCombobox();
        }
        private async void DanhSachSanPham_Load(object sender, EventArgs e)
        {
            gridview_danh_sach_san_pham.DataSource = await GetProducTable(null, -1, -1, 10000);
            UpdateSoDong();
        }


        #region Chức năng thêm sản phẩm
        private void btn_them_Click(object sender, EventArgs e)
        {
            SanPham UC_san_pham = new SanPham(null);
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
                    gridview_danh_sach_san_pham.DataSource = await GetProducTable(null, -1, -1, 10000);
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
            UC_san_pham.Location = new Point(0, 0);
            UC_san_pham.HuyClick += (s, args) =>
            {
                this.Controls.Remove(UC_san_pham);
            };
            UC_san_pham.LuuClick += async (s, args) =>
            {
                Product productUpdate = await UC_san_pham.Sua();

                if (productUpdate != null)
                {
                    this.Controls.Remove(UC_san_pham);
                    gridview_danh_sach_san_pham.DataSource = await GetProducTable(null, -1, -1, 10000);
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
                gridview_danh_sach_san_pham.DataSource = await GetProducTable(null, -1, -1, 10000);
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

        #region Chức năng xem chi tiết sản phẩm
        private void gridview_danh_sach_san_pham_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = gridview_danh_sach_san_pham.Rows[indexCurrentRow];
            if (selectedRow != null)
            {
                DanhSachChiTietSanPham UC_Danh_Sach_Chi_Tiet_San_Pham = new DanhSachChiTietSanPham(currentProduct);
                UC_Danh_Sach_Chi_Tiet_San_Pham.Location = new Point(0, 0);

                UC_Danh_Sach_Chi_Tiet_San_Pham.TroVeClick += async (s, args) =>
                {
                    this.Controls.Remove(UC_Danh_Sach_Chi_Tiet_San_Pham);
                    gridview_danh_sach_san_pham.DataSource = await GetProducTable(null, -1, -1, 10000);
                    UpdateSoDong();
                };

                this.Controls.Add(UC_Danh_Sach_Chi_Tiet_San_Pham);
                UC_Danh_Sach_Chi_Tiet_San_Pham.BringToFront();

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
        private void UpdateSoDong()
        {
            lb_tong_so_dong.Text = "Kết quả: " + gridview_danh_sach_san_pham.RowCount.ToString();
        }
        public async void LoadCombobox()
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
        #endregion

        #region DB Util
        private async Task<DataTable> GetProducTable(string ProductName, int CategoryID, int SupplierID, int NumOfStock)
        {
            DataTable ProductTable = new DataTable();
            ProductTable.Columns.Add("ProductId", typeof(int));
            ProductTable.Columns.Add("SKU", typeof(string));
            ProductTable.Columns.Add("Name", typeof(string));
            ProductTable.Columns.Add("Category", typeof(string));
            ProductTable.Columns.Add("Supplier", typeof(string));
            ProductTable.Columns.Add("QuantityInStock", typeof(int));
            ProductTable.Columns.Add("CostPrice", typeof(string));
            ProductTable.Columns.Add("MarketPrice", typeof(string));

            List<Product> products = await GetProductList(ProductName, CategoryID, SupplierID);

            foreach (Product product in products)
            {
                string formattedCostPrice = string.Format("{0:N0}", product.CostPrice);
                string formattedMarketPrice = string.Format("{0:N0}", product.MarketPrice);
                int QuantityInStock = await GetQtyInStock(product.Sku);

                if (QuantityInStock <= NumOfStock)
                {
                    ProductTable.Rows.Add(product.ProductId,
                            product.Sku,
                            product.Name,
                            product.Category.Name,
                            product.Supplier.Name,
                            QuantityInStock,
                            formattedCostPrice,
                            formattedMarketPrice);
                }
                
            }
            return ProductTable;
        }
        private async Task<int> GetQtyInStock(string Sku)
        {
            int total = 0;
            using (var dbContext = new GroceryStoreContext())
            {
                total = (int)await dbContext.ProductDetail.Where(x => x.Sku == Sku).Select(x => x.QuantityInStock).SumAsync();
            }
            return total;
        }


        private async Task<List<Product>> GetProductList(string SearchValue, int CategoryID, int SupplierID)
        {
            List<Product> products;
            using (var dbContext = new GroceryStoreContext())
            {
                IQueryable<Product> query = dbContext.Product.Include(p => p.Category).Include(p => p.Supplier);

                if (!string.IsNullOrEmpty(SearchValue))
                {
                    query = query.Where(p => p.Name == SearchValue || p.Sku == SearchValue);
                }

                if (CategoryID != -1 && CategoryID != null)
                {
                    query = query.Where(p => p.CategoryId == CategoryID);
                }

                if (SupplierID != -1 && SupplierID != null)
                {
                    query = query.Where(p => p.SupplierId == SupplierID);
                }

                products = await query.ToListAsync();
            }
            return products;
        }



        #endregion

        private async void btn_tim_kiem_Click(object sender, EventArgs e)
        {
            int phanLoaiId = cbb_phan_loai.SelectedValue != null ? (int)cbb_phan_loai.SelectedValue : 0;
            int nhaCungCapId = cbb_nha_cung_cap.SelectedValue != null ? (int)cbb_nha_cung_cap.SelectedValue : 0;
            int numOfStock = (int)tb_muc_ton.Value;

            gridview_danh_sach_san_pham.DataSource = await GetProducTable(txtbox_tim_kiem.Text, phanLoaiId, nhaCungCapId, numOfStock);
            UpdateSoDong();
        }

        private async void cbb_nha_cung_cap_SelectedIndexChanged(object sender, EventArgs e)
        {
            int phanLoaiId = cbb_phan_loai.SelectedValue != null ? (int)cbb_phan_loai.SelectedValue : 0;
            int nhaCungCapId = cbb_nha_cung_cap.SelectedValue != null ? (int)cbb_nha_cung_cap.SelectedValue : 0;
            int numOfStock = (int)tb_muc_ton.Value;

            gridview_danh_sach_san_pham.DataSource = await GetProducTable(txtbox_tim_kiem.Text, phanLoaiId, nhaCungCapId, numOfStock);
            UpdateSoDong();

        }

        private async void cbb_phan_loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int phanLoaiId = cbb_phan_loai.SelectedValue != null ? (int)cbb_phan_loai.SelectedValue : 0;
            int nhaCungCapId = cbb_nha_cung_cap.SelectedValue != null ? (int)cbb_nha_cung_cap.SelectedValue : 0;
            int numOfStock = (int)tb_muc_ton.Value;

            gridview_danh_sach_san_pham.DataSource = await GetProducTable(txtbox_tim_kiem.Text, phanLoaiId, nhaCungCapId, numOfStock);
            UpdateSoDong();
        }

        private async void tb_muc_ton_ValueChanged(object sender, EventArgs e)
        {
            int phanLoaiId = cbb_phan_loai.SelectedValue != null ? (int)cbb_phan_loai.SelectedValue : 0;
            int nhaCungCapId = cbb_nha_cung_cap.SelectedValue != null ? (int)cbb_nha_cung_cap.SelectedValue : 0;
            int numOfStock = (int)tb_muc_ton.Value;

            gridview_danh_sach_san_pham.DataSource = await GetProducTable(txtbox_tim_kiem.Text, phanLoaiId, nhaCungCapId, numOfStock);
            UpdateSoDong();
        }
    }
}
