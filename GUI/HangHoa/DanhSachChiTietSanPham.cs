using grocery_store.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition.Primitives;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grocery_store.GUI.HangHoa
{
    public partial class DanhSachChiTietSanPham : UserControl
    {
        public event EventHandler TroVeClick;

        private Product currentProduct;
        private ProductDetail currentProductDetail;
        private int indexCurrentRow;
        public DanhSachChiTietSanPham(Product product)
        {
            InitializeComponent();
            this.btn_tro_ve.Click += (sender, e) => TroVeClick?.Invoke(this, e);
            this.currentProduct = product;
        }
        private async void DanhSachChiTietSanPham_Load(object sender, EventArgs e)
        {
            lb_ten_va_sku.Text = currentProduct.Name + " - " + currentProduct.Sku;
            gridview_danh_sach_chi_tiet_san_pham.DataSource = await GetProductDetailTable();
        }


        #region CRUD
        private void btn_them_Click(object sender, EventArgs e)
        {
            ChiTietSanPham UC_ChiTietSanPham = new ChiTietSanPham(currentProduct.Sku,null);
            UC_ChiTietSanPham.Location = new Point(0, 0);
            UC_ChiTietSanPham.HuyClick += (S, args) =>
            {
                this.Controls.Remove(UC_ChiTietSanPham);
            };

            UC_ChiTietSanPham.LuuClick += async (S, args) =>
            {
                try
                {
                    int success = await UC_ChiTietSanPham.Them();
                    if (success == 0)
                    {
                        this.Controls.Remove(UC_ChiTietSanPham);
                        gridview_danh_sach_chi_tiet_san_pham.DataSource = await GetProductDetailTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message + "\nVui lòng thực hiện lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            this.Controls.Add(UC_ChiTietSanPham);
            UC_ChiTietSanPham.BringToFront();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            ChiTietSanPham UC_ChiTietSanPham = new ChiTietSanPham(currentProduct.Sku,currentProductDetail);
            UC_ChiTietSanPham.Location = new Point(0, 0);
            UC_ChiTietSanPham.HuyClick += (S, args) =>
            {
                this.Controls.Remove(UC_ChiTietSanPham);
            };

            UC_ChiTietSanPham.LuuClick += async (S, args) =>
            {
                try
                {
                    int success = await UC_ChiTietSanPham.Sua();
                    if (success == 0)
                    {
                        this.Controls.Remove(UC_ChiTietSanPham);
                        gridview_danh_sach_chi_tiet_san_pham.DataSource = await GetProductDetailTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message + "\nVui lòng thực hiện lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            this.Controls.Add(UC_ChiTietSanPham);
            UC_ChiTietSanPham.BringToFront();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region DB Util
        private async Task<DataTable> GetProductDetailTable()
        {
            DataTable productDetailTable = new DataTable();
            productDetailTable.Columns.Add("Expiry", typeof(string));
            productDetailTable.Columns.Add("QuantityInStock", typeof(int));


            List<ProductDetail> productDetails = await GetProductDetailList();

            foreach (ProductDetail productDetail in productDetails)
            {
                DateTime expiry = (DateTime)productDetail.Expiry;
                string formatedExpiry = expiry.ToString();

                productDetailTable.Rows.Add(formatedExpiry,
                            productDetail.QuantityInStock
                            );
            }
            return productDetailTable;
        }
        private async Task<List<ProductDetail>> GetProductDetailList()
        {
            List<ProductDetail> productDetails;
            using (var dbContext = new GroceryStoreContext())
            {
                productDetails = await dbContext.ProductDetail.ToListAsync();
            }
            return productDetails;
        }



        #endregion

        #region Util

        #endregion

        private async void gridview_danh_sach_chi_tiet_san_pham_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            indexCurrentRow = e.RowIndex;

            DataGridViewRow selectedRow = gridview_danh_sach_chi_tiet_san_pham.Rows[indexCurrentRow];

            if (selectedRow != null)
            {
                string sku = selectedRow.Cells[0].Value.ToString();
                DateTime expiry;
                DateTime.TryParseExact(selectedRow.Cells[1].Value.ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out expiry);
                using (var dbContext = new GroceryStoreContext())
                {
                    currentProductDetail = await dbContext.ProductDetail.FirstOrDefaultAsync(x => x.Sku == sku );
                }
            }
        }
    }
}
