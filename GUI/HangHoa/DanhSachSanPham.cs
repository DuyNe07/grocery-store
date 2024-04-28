using grocery_store.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grocery_store.GUI.HangHoa
{
    public partial class DanhSachSanPham : UserControl
    {
        private Product currentProduct = new Product();
        private int indexCurrentRow;

        public DanhSachSanPham()
        {
            InitializeComponent();
            LoadCombobox();
        }

        private async void DanhSachSanPham_Load(object sender, EventArgs e)
        {
            gridview_danh_sach_san_pham.DataSource = await GetProducTable();
            UpdateSoDong();
        }

        private void gridview_danh_sach_san_pham_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            indexCurrentRow = e.RowIndex;
            DataGridViewRow selectedRow = gridview_danh_sach_san_pham.Rows[indexCurrentRow];
            Category category = new Category();
            Supplier supplier = new Supplier();

            currentProduct.ProductId = int.Parse(selectedRow.Cells[0].Value.ToString());
            currentProduct.Sku = selectedRow.Cells[1].Value.ToString();
            currentProduct.Name = selectedRow.Cells[2].Value.ToString();
            DateTime.TryParseExact(selectedRow.Cells[3].Value.ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime HanSuDung);
            currentProduct.Expiry = HanSuDung;
            category.Name = selectedRow.Cells[4].Value.ToString();
            supplier.Name = selectedRow.Cells[5].Value.ToString();
            currentProduct.QuantityInStock = int.Parse(selectedRow.Cells[6].Value.ToString());
            currentProduct.CostPrice = decimal.Parse(selectedRow.Cells[7].Value.ToString());
            currentProduct.MarketPrice = decimal.Parse(selectedRow.Cells[8].Value.ToString());
            currentProduct.Category = category;
            currentProduct.Supplier = supplier;
        }

        #region Chức Năng: Thêm Sản Phẩm
        private void btn_them_Click(object sender, EventArgs e)
        {
            SanPham UC_san_pham = new SanPham(null);
            UC_san_pham.lb_name_control.Text = "THÊM SẢN PHẨM";
            UC_san_pham.Location = new Point(0, 0);

            // Hủy
            UC_san_pham.HuyClick += async (s, args) =>
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

        #region Chức Năng: Sửa Sản Phẩm
        private void btn_sua_Click(object sender, EventArgs e)
        {
            SanPham UC_san_pham = new SanPham(currentProduct);
            UC_san_pham.lb_name_control.Text = "SỬA SẢN PHẨM";
            UC_san_pham.Location = new Point(0, 0);
            UC_san_pham.HuyClick += async (s, args) =>
            {
                this.Controls.Remove(UC_san_pham);
            };
            UC_san_pham.LuuClick += async (s, args) =>
            {
                Product productUpdate = await UC_san_pham.Sua(currentProduct);
                
                if (productUpdate != null)
                {
                    this.Controls.Remove(UC_san_pham);
                    UpdateRow(indexCurrentRow, productUpdate);
                    currentProduct = productUpdate;
                }
            };
            this.Controls.Add(UC_san_pham);
            UC_san_pham.BringToFront();
        }

        private void UpdateRow(int rowIndex, Product productUpdate)
        {
            DataGridViewRow rowUpdate = gridview_danh_sach_san_pham.Rows[rowIndex];
            rowUpdate.Cells[0].Value = productUpdate.ProductId;
            rowUpdate.Cells[1].Value = productUpdate.Sku;
            rowUpdate.Cells[2].Value = productUpdate.Name;
            DateTime expiry = (DateTime)productUpdate.Expiry;

            string formattedExpiry = expiry.ToString("MM/dd/yyyy");
            rowUpdate.Cells[3].Value = formattedExpiry;

            rowUpdate.Cells[4].Value = productUpdate.Category.Name;
            rowUpdate.Cells[5].Value = productUpdate.Supplier.Name;
            rowUpdate.Cells[6].Value = productUpdate.QuantityInStock;

            string formattedCostPrice = string.Format("{0:N0}", productUpdate.CostPrice);
            rowUpdate.Cells[7].Value = formattedCostPrice;

            string formattedMarketPrice = string.Format("{0:N0}", productUpdate.MarketPrice);
            rowUpdate.Cells[8].Value = formattedMarketPrice;
        }
        #endregion

        #region Chức Năng: Xóa Sản Phẩm
        private async void btn_xoa_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Xóa sản phẩm " + currentProduct.Name, "Xác Nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                DeleteProductByID(currentProduct.ProductId);
                gridview_danh_sach_san_pham.DataSource = await GetProducTable();
                UpdateSoDong();



            }
        }
        private async void DeleteProductByID(int productID)
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
                    }
                    catch 
                    {
                        MessageBox.Show("Sản Phẩm này không thể xóa !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                return;
            }
        }
        #endregion

        #region Truy Vấn 
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

        //private async Task<List<Product>> GetProductList(string ProductName,int CategoryID, int SupplierID)
        //{
        //    List<Product> products;
        //    using (var dbContext = new GroceryStoreContext())
        //    {
        //        products = await dbContext.Product
        //            .Include(p => p.Category)
        //            .Include(p => p.Supplier)
        //            .Where(p => p.Name == ProductName ?)
        //            .Where(p => p.CategoryId == CategoryID ?)
        //            .Where(p => p.SupplierId == SupplierID ?)
        //            .ToListAsync();
        //    }
        //    return products;
        //}
        #endregion

        #region Xử Lý Giao Diện
        private void UpdateSoDong()
        {
            lb_so_dong.Text = gridview_danh_sach_san_pham.RowCount.ToString();
        }
        private async void LoadCombobox()
        {
            List<Category> categories;
            List<Supplier> suppliers;
            List<Category> categoriesWithDefault = new List<Category>();
            List<Supplier> suppliersWithDefault = new List<Supplier>();
            var dbContext = new GroceryStoreContext();

            categories = await dbContext.Category.ToListAsync();
            suppliers = await dbContext.Supplier.ToListAsync();
            categoriesWithDefault.Add(new Category { CategoryId = -1, Name = "Phân loại (All)" });
            suppliersWithDefault.Add(new Supplier { SupplierId = -1, Name = "Nhà Cung Cấp (All)" });
            categoriesWithDefault.AddRange(categories);
            suppliersWithDefault.AddRange(suppliers);

            // Set DisplayMember and ValueMember
            cbb_nha_cung_cap.DisplayMember = "Name";
            cbb_nha_cung_cap.ValueMember = "SupplierID";

            cbb_phan_loai.DisplayMember = "name";
            cbb_phan_loai.ValueMember = "CategoryId";

            // Add suppliers to the ComboBox efficiently
            cbb_nha_cung_cap.DataSource = suppliersWithDefault;
            cbb_phan_loai.DataSource = categoriesWithDefault;

            cbb_phan_loai.SelectedIndex = 0;
            cbb_nha_cung_cap.SelectedIndex = 0;
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

       


    }
}
