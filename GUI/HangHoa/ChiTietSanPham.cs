using grocery_store.API;
using grocery_store.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition.Primitives;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grocery_store.GUI.HangHoa
{
    public partial class ChiTietSanPham : UserControl
    {
        public event EventHandler HuyClick;
        public event EventHandler LuuClick;
        private ProductDetail curentProductDetail;
        private string currentSKU;
        public ChiTietSanPham(string currentSKU, ProductDetail curentProductDetail)
        {
            InitializeComponent();
            this.btn_huy.Click += (sender, e) => HuyClick?.Invoke(this, e);
            this.btn_luu.Click += (sender, e) => LuuClick?.Invoke(this, e);
            this.curentProductDetail = curentProductDetail; 
            this.currentSKU = currentSKU;
        }

        private void ChiTietSanPham_Load(object sender, EventArgs e)
        {
            if (curentProductDetail == null)
            {
                lb_name_control.Text = "THÊM";
                LoadFormThem();
            }
            else
            {
                lb_name_control.Text = "SỬA";
                LoadFormSuaAsync();
            }
        }

        #region Chức năng thêm
        public async Task<int> Them()
        {
            if (!await CheckProductDetail(currentSKU, input_han_su_dung.Value))
            {
                using(var dbContext = new GroceryStoreContext())
                {
                    ProductDetail newProductDetail = new ProductDetail();

                    newProductDetail.Sku = currentSKU;
                    newProductDetail.Expiry = input_han_su_dung.Value;
                    newProductDetail.QuantityInStock = (int)input_ton_kho.Value;
                    newProductDetail.generateBarCode();
                    await dbContext.AddAsync(newProductDetail);
                    await dbContext.SaveChangesAsync();
                }
            }
            else
            {
                MessageBox.Show("Đã tồn tại hạn sử dụng này!", "Không thể thực hiện");
                return 1;
            }
            return 0;
        }
        #endregion

        #region Chức năng sửa
        public async Task<int> Sua()
        {
            if (await CheckProductDetail(currentSKU, input_han_su_dung.Value))
            {
               
                using(var dbContext = new GroceryStoreContext())
                {
                    ProductDetail productDetailToUpdate = await dbContext.ProductDetail.FirstOrDefaultAsync(x => x.BarCode == curentProductDetail.BarCode);
                    productDetailToUpdate.QuantityInStock = (int)input_ton_kho.Value;
                    productDetailToUpdate.generateBarCode();
                    await dbContext.SaveChangesAsync();
                }
            }
            else
            {
                MessageBox.Show("Đã tồn tại hạn sử dụng này!", "Không thể thực hiện");
                return 1;
            }
            return 0;
        }
        #endregion

        #region Xử Lý Giao Diện
        private void LoadFormSuaAsync()
        {
            input_han_su_dung.Enabled = false;
            using (var dbContext = new GroceryStoreContext())
            {
                input_ton_kho.Value = (decimal)curentProductDetail.QuantityInStock;
                input_han_su_dung.Value = curentProductDetail.Expiry;
            }
        }
        private void LoadFormThem()
        {
            input_ton_kho.Value = 0;
        }
        #endregion

        #region Util
        public async Task<bool> CheckProductDetail(string sku, DateTime expiry)
        {
            using (var dbContext = new GroceryStoreContext())
            {
                // Kiểm tra xem có bản ghi nào trong ProductDetail khớp với SKU và Expiry đã cho không
                var productDetailExists = await dbContext.ProductDetail
                    .AnyAsync(x => x.Sku == sku && x.Expiry == expiry);

                return productDetailExists;
            }

        }
       

        #endregion
    }
}
