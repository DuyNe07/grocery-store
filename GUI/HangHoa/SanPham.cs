using grocery_store.API;
using grocery_store.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace grocery_store.GUI.HangHoa
{
    public partial class SanPham : UserControl
    {
        public event EventHandler HuyClick;
        public event EventHandler LuuClick;
        private Product curentProduct;

        public SanPham(Product product)
        {
            InitializeComponent();
            this.btn_huy.Click += (sender, e) => HuyClick?.Invoke(this, e);
            this.btn_luu.Click += (sender, e) => LuuClick?.Invoke(this, e);
            this.curentProduct = product;
        }

        private  void SanPham_Load(object sender, EventArgs e)
        {
            if (curentProduct == null)
            {
                LoadFormThem();
            }
            else
            {
                LoadFormSuaAsync();
            }
        }

        public async Task<Product> Them()
        {
            Product newProduct;
            string ErrorMessage = CheckInput();
            if (string.IsNullOrWhiteSpace(ErrorMessage))
            {
                var dbContext = new GroceryStoreContext();
                newProduct = new Product();
                Category category = new Category();
                Supplier supplier = new Supplier();

                category.Name = cbb_phan_loai.Text;
                category.CategoryId = int.Parse(cbb_phan_loai.SelectedValue.ToString());
                supplier.Name = cbb_nha_cung_cap.Text;
                supplier.SupplierId = int.Parse(cbb_nha_cung_cap.SelectedValue.ToString());

                GenerateProductCode ProductUtil = new GenerateProductCode();
                string Sku = await ProductUtil.GenerateSKU(tb_ten_san_pham.Text, cbb_phan_loai.SelectedText, cbb_nha_cung_cap.SelectedText);

                Product productCheck = dbContext.Product.FirstOrDefault(p => p.Sku == Sku);
                if (productCheck == null)
                {
                    newProduct.Sku = Sku;
                    newProduct.Name = tb_ten_san_pham.Text;
                    newProduct.CategoryId = category.CategoryId;
                    newProduct.SupplierId = supplier.SupplierId;
                    newProduct.QuantityInStock = int.Parse(input_ton_kho.Value.ToString());
                    newProduct.CostPrice = decimal.Parse(input_gia_nhap.Value.ToString());
                    newProduct.MarketPrice = decimal.Parse(input_gia_ban.Value.ToString());
                    DateTime.TryParseExact(input_han_su_dung.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime HanSuDung);
                    newProduct.Expiry = HanSuDung;

                    await dbContext.AddAsync(newProduct);
                    await dbContext.SaveChangesAsync();

                    newProduct.Category = category;
                    newProduct.Supplier = supplier;
                }
            }
            else
            {
                newProduct = null;
            }
            
            return newProduct;
        }
        public async Task<Product> Sua(Product product)
        {
            Product productToUpdate = null;
            string ErrorMessage = CheckInput();

            if (string.IsNullOrWhiteSpace(ErrorMessage))
            {
                var dbContext = new GroceryStoreContext();
                Category category = new Category();
                Supplier supplier = new Supplier();
                category.Name = cbb_phan_loai.Text;
                category.CategoryId = int.Parse(cbb_phan_loai.SelectedValue.ToString());
                supplier.Name = cbb_nha_cung_cap.Text;
                supplier.SupplierId = int.Parse(cbb_nha_cung_cap.SelectedValue.ToString());

                productToUpdate = await dbContext.Product.FindAsync(product.ProductId);
                if (productToUpdate != null)
                {
                    productToUpdate.Name = tb_ten_san_pham.Text;
                    productToUpdate.Category = category;
                    productToUpdate.CategoryId = category.CategoryId;
                    productToUpdate.Supplier = supplier;
                    productToUpdate.SupplierId = supplier.SupplierId;
                    productToUpdate.QuantityInStock = int.Parse(input_ton_kho.Value.ToString());
                    productToUpdate.CostPrice = decimal.Parse(input_gia_nhap.Value.ToString());
                    productToUpdate.MarketPrice = decimal.Parse(input_gia_ban.Value.ToString());

                    DateTime.TryParseExact(input_han_su_dung.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime HanSuDung);
                    productToUpdate.Expiry = HanSuDung;

                    GenerateProductCode ProductUtil = new GenerateProductCode();
                    productToUpdate.Sku = await ProductUtil.GenerateSKU(productToUpdate.Name, category.Name, supplier.Name);
                    await dbContext.SaveChangesAsync();
                }
            }
            else
            {
                MessageBox.Show(CheckInput(), "Thông tin bị thiếu hoặc chưa chính xác");
            }
            return productToUpdate;
        }


        #region Xử Lý Giao Diện
        private async Task LoadFormSuaAsync()
        {
            ClearForm();
            LoadCombobox();

            var dbContext = new GroceryStoreContext();
            List<Category> categories = await dbContext.Category.ToListAsync();
            List<Supplier> suppliers = await dbContext.Supplier.ToListAsync();

            tb_ten_san_pham.Text = curentProduct.Name;
            cbb_phan_loai.SelectedIndex = GetIndex(categories, curentProduct.Category.Name);
            cbb_nha_cung_cap.SelectedIndex = GetIndex(suppliers, curentProduct.Supplier.Name);
            input_ton_kho.Value = decimal.Parse(curentProduct.QuantityInStock.ToString());
            input_gia_nhap.Value = decimal.Parse(curentProduct.CostPrice.ToString());
            input_gia_ban.Value = decimal.Parse(curentProduct.MarketPrice.ToString());

            DateTime.TryParseExact(curentProduct.Expiry.ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime HanSuDung);
            input_han_su_dung.Text = HanSuDung.ToString("MM/dd/yyyy");
            Console.WriteLine(curentProduct.Expiry);
        }
        private void LoadFormThem()
        {
            ClearForm();
            LoadCombobox();
        }

        private void ClearForm()
        {
            tb_ten_san_pham.Text = string.Empty;
            input_ton_kho.Value = 0;
            input_gia_nhap.Value = 0;
            input_gia_ban.Value = 0;
        }
        private async void LoadCombobox()
        {

            List<Category> categoriesWithDefault = new List<Category>();
            List<Supplier> suppliersWithDefault = new List<Supplier>();

            var dbContext = new GroceryStoreContext();
            List<Category> categories = await dbContext.Category.ToListAsync();
            List<Supplier> suppliers = await dbContext.Supplier.ToListAsync();
     
            categoriesWithDefault.Add(new Category { CategoryId = -1, Name = "Phân loại" });
            suppliersWithDefault.Add(new Supplier { SupplierId = -1, Name = "Nhà Cung Cấp" });
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
        #endregion

        #region Kiểm Tra Trị Nhập Vào
          
        public string CheckInput()
        {
            string ErrorMessage = "";
            if (string.IsNullOrEmpty(tb_ten_san_pham.Text))
            {
                ErrorMessage += "- Vui lòng nhập tên sản phẩm.\n";
            }
            if (cbb_phan_loai.SelectedValue.ToString().Contains("-1"))
            {
                ErrorMessage += "- Vui lòng chọn phân loại.\n";
            }
            if (cbb_nha_cung_cap.SelectedValue.ToString().Contains("-1"))
            {
                ErrorMessage += "- Vui lòng chọn nhà cung cấp.\n";
            }
            if (input_gia_nhap.Value == 0)
            {
                ErrorMessage += "- Vui lòng thêm thông tin Giá nhập.\n";
            }
            if (input_gia_ban.Value == 0)
            {
                ErrorMessage += "- Vui lòng thêm thông tin Giá bán.\n";
            }
            string str_ton_kho = input_ton_kho.Value.ToString();
            if (str_ton_kho.Contains(".") || str_ton_kho.Contains(","))
            {
                input_ton_kho.Value = 0;
                ErrorMessage += "- Vui lòng nhập số số tồn kho là số nguyên.\n";
            }
            return ErrorMessage;
        }

        private void tb_ten_san_pham_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_ten_san_pham.Text))
            {
                lb_name_error.Text = "Vui lòng nhập tên sản phẩm";
            } 
            else
            {
                lb_name_error.Text = string.Empty;
            }
        }
        private void cbb_phan_loai_Validating(object sender, CancelEventArgs e)
        {
            if (cbb_phan_loai.SelectedValue.ToString().Contains("-1"))
            {
                lb_category_error.Text = "Vui lòng chọn phân loại.";
            }
            else
            {
                lb_category_error.Text = string.Empty;
            }
        }

        private void cbb_nha_cung_cap_Validating(object sender, CancelEventArgs e)
        {
            if (cbb_nha_cung_cap.SelectedValue.ToString().Contains("-1"))
            {
                lb_supplier_error.Text = "Vui lòng chọn nhà cung cấp.";
            }
            else
            {
                lb_supplier_error.Text = string.Empty;
            }
        }

        private void input_gia_nhap_Validating(object sender, CancelEventArgs e)
        {
            if (input_gia_nhap.Value == 0)
            {
                lb_cost_price_error.Text = "Vui lòng thêm thông tin Giá nhập.";
            }
            else
            {
                lb_cost_price_error.Text = string.Empty;
            }
        }

        private void input_gia_ban_Validating(object sender, CancelEventArgs e)
        {
            if (input_gia_ban.Value == 0)
            {
                lb_maket_price_error.Text = "Vui lòng thêm thông tin Giá bán.";
            }
            else
            {
                lb_maket_price_error.Text = string.Empty;
            }

        }

        private void lb_inventory_error_Validating(object sender, CancelEventArgs e)
        {
            string str_ton_kho = input_ton_kho.Value.ToString();
            if(str_ton_kho.Contains(".") || str_ton_kho.Contains(","))
            {
                input_ton_kho.Value = 0;
                lb_inventory_error.Text = "Vui lòng nhập số nguyên dương.";
            }
            else
            {
                lb_inventory_error.Text = string.Empty;
            }
        }
        #endregion

        #region Util
        private  int GetIndex<T>(List<T> objects, string name)
        {
            for (int i = 0; i < objects.Count + 1; i++)
            {
                dynamic obj = objects[i];
                if (name.Contains(obj.Name))
                {
                    return i + 1;
                }
            }
            return -1;
        }



        #endregion

    }
}
