using grocery_store.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class DanhSachPhanLoai : UserControl
    {
        private Category currentCategory;
        private int indexCurrentRow;
        public DanhSachPhanLoai()
        {
            InitializeComponent();
        }
        private async void DanhSachPhanLoai_Load(object sender, EventArgs e)
        {
            gridview_danh_sach_phan_loai.DataSource = await GetCategopryTable();
            UpdateSoDong();
        }
        private async void gridview_danh_sach_phan_loai_RowEnterAsync(object sender, DataGridViewCellEventArgs e)
        {
            indexCurrentRow = e.RowIndex;

            DataGridViewRow selectedRow = gridview_danh_sach_phan_loai.Rows[indexCurrentRow];

            if (selectedRow != null)
            {
                int categoryID = Convert.ToInt32(selectedRow.Cells[0].Value);
                using (var dbContext = new GroceryStoreContext())
                {
                    currentCategory = await dbContext.Category.FirstOrDefaultAsync(p => p.CategoryId == categoryID);
                }
            }
        }

        #region Chức năng thêm phân loại
        private void btn_them_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Chức năng sửa phân loại
        private void btn_sua_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Chức năng xóa phân loại
        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region DB Util
        private async Task<DataTable> GetCategopryTable()
        {
            DataTable CategoryTable = new DataTable();
            CategoryTable.Columns.Add("CategoryID", typeof(int));
            CategoryTable.Columns.Add("CategoryName", typeof(string));
            CategoryTable.Columns.Add("NumOfProducts", typeof(int));

            List<Category> categories = await GetCategoryList();

            foreach (Category category in categories)
            {
                CategoryTable.Rows.Add(category.CategoryId,
                            category.Name,
                            category.Product.Count
                            );
            }
            return CategoryTable;
        }
        private async Task<List<Category>> GetCategoryList()
        {
            List<Category> categories;
            using (var dbContext = new GroceryStoreContext())
            {
                categories = await dbContext.Category.Include(p => p.Product).ToListAsync();
            }
            return categories;
        }
        #endregion

        #region Util
        private void UpdateSoDong()
        {
            lb_so_luong_phan_loai.Text = gridview_danh_sach_phan_loai.RowCount.ToString();
        }

        #endregion


    }
}
