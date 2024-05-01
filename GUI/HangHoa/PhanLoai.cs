using grocery_store.API;
using grocery_store.Models;
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
    public partial class PhanLoai : UserControl
    {
        public event EventHandler HuyClick;
        public event EventHandler LuuClick;
        private Category curentCategory;
        public PhanLoai(Category category)
        {
            InitializeComponent();
            this.btn_huy.Click += (sender, e) => HuyClick?.Invoke(this, e);
            this.btn_luu.Click += (sender, e) => LuuClick?.Invoke(this, e);
            this.curentCategory = category;
        }

        public async Task Sua()
        {
            Category categoryToUpdate;
            string ErrorMessage = CheckInput();
            if (string.IsNullOrWhiteSpace(ErrorMessage))
            {
                using (var dbContext = new GroceryStoreContext())
                {
                    categoryToUpdate = await dbContext.Category.FindAsync(curentCategory.CategoryId);

                    if (categoryToUpdate != null)
                    {
                        categoryToUpdate.Name = tb_ten_phan_loai.Text;
                        await dbContext.SaveChangesAsync();
                    }
                }
            }
        }

        public async void Them()
        {
            Category newCategory;
            string ErrorMessage = CheckInput();
            if (string.IsNullOrWhiteSpace(ErrorMessage))
            {
                newCategory = new Category();

                newCategory.Name = tb_ten_phan_loai.Text;

                using (var dbContext = new GroceryStoreContext())
                {
                    await dbContext.AddAsync(newCategory);
                    await dbContext.SaveChangesAsync();
                }  
            }
        }

        private void PhanLoai_Load(object sender, EventArgs e)
        {
            if (curentCategory == null)
            {
                lb_name_control.Text = "THÊM PHÂN LOẠI";
                LoadFormThem();
            }
            else
            {
                lb_name_control.Text = "SỬA PHÂN LOẠI";
                LoadFormSua();
            }
        }

        #region Util Giao Diện
        private void LoadFormThem()
        {
            tb_ten_phan_loai.Text = string.Empty;
        }
        private void LoadFormSua()
        {
            tb_ten_phan_loai.Text = curentCategory.Name;
        }
        #endregion

        #region Kiểm tra giá trị nhập vào
        public string CheckInput()
        {
            string ErrorMessage = "";
            if (string.IsNullOrEmpty(tb_ten_phan_loai.Text))
            {
                ErrorMessage += "- Vui lòng nhập tên sản phẩm.\n";
            }
            return ErrorMessage;
        }
        #endregion

    }
}
