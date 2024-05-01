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

        #region Load
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
        #endregion

        #region Chức năng thêm phân loại
        private void btn_them_Click(object sender, EventArgs e)
        {
            PhanLoai UC_phan_loai = new PhanLoai(null);
            UC_phan_loai.Location = new Point(0, 0);
            UC_phan_loai.HuyClick += (S, args) =>
            {
                this.Controls.Remove(UC_phan_loai);
            };

            UC_phan_loai.LuuClick += async (S, args) =>
            {
                try
                {
                    UC_phan_loai.Them();
                    this.Controls.Remove(UC_phan_loai);
                    gridview_danh_sach_phan_loai.DataSource = await GetCategopryTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message + "\nVui lòng thực hiện lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            this.Controls.Add(UC_phan_loai);
            UC_phan_loai.BringToFront();
        }
        #endregion

        #region Chức năng sửa phân loại
        private void btn_sua_Click(object sender, EventArgs e)
        {
            PhanLoai UC_phan_loai = new PhanLoai(currentCategory);
            UC_phan_loai.Location = new Point(0, 0);
            UC_phan_loai.HuyClick += (S, args) =>
            {
                this.Controls.Remove(UC_phan_loai);
            };

            UC_phan_loai.LuuClick += async (S, args) =>
            {
                try
                {
                    await UC_phan_loai.Sua();
                    this.Controls.Remove(UC_phan_loai);
                    gridview_danh_sach_phan_loai.DataSource = await GetCategopryTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message + "\nVui lòng thực hiện lại", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            };
            this.Controls.Add(UC_phan_loai);
            UC_phan_loai.BringToFront();

        }
        #endregion

        #region Chức năng xóa phân loại
        private async void btn_xoa_ClickAsync(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xóa phân loại " + currentCategory.Name, "Xác Nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                await DeleteCategoryByID(currentCategory.CategoryId);
                gridview_danh_sach_phan_loai.DataSource = await GetCategopryTable();
                UpdateSoDong();
            }
        }

        private async Task DeleteCategoryByID(int categoryID)
        {
            using (var dbContext = new GroceryStoreContext())
            {
                Category categoryToDelete = await dbContext.Category.FindAsync(categoryID);
                if (categoryToDelete != null)
                {
                    try
                    {
                        dbContext.Category.Remove(categoryToDelete);
                        await dbContext.SaveChangesAsync();
                        MessageBox.Show("Phân loại đã được xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        MessageBox.Show($"Không thể xóa phân loại." +
                            $"\nVui lòng thử xóa các sản phẩm thuộc phân loại {categoryToDelete.Name} trước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phân loại cần xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
