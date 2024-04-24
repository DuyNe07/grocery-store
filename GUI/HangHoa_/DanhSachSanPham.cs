using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grocery_store.GUI.HangHoa_
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
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("ten_san_pham", typeof(string));
            dt.Columns.Add("phan_loai", typeof(string));
            dt.Columns.Add("nha_cung_cap", typeof(string));
            dt.Columns.Add("so_luong", typeof(int));
            dt.Columns.Add("gia_nhap", typeof(double));
            dt.Columns.Add("gia_ban", typeof(double));

            // Thêm dữ liệu mẫu
            dt.Rows.Add(1, "Sản phẩm 1", "Loại A", "Nhà cung cấp A", 10, 10000, 15000);
            dt.Rows.Add(2, "Sản phẩm 2", "Loại B", "Nhà cung cấp B", 20, 20000, 25000);
            dt.Rows.Add(3, "Sản phẩm 3", "Loại C", "Nhà cung cấp C", 30, 30000, 35000);
            dt.Rows.Add(4, "Sản phẩm 4", "Loại D", "Nhà cung cấp D", 40, 40000, 45000);
            dt.Rows.Add(5, "Sản phẩm 5", "Loại E", "Nhà cung cấp E", 50, 50000, 55000);

            // Gán dữ liệu cho GridView
            gridview_danh_sach_san_pham.DataSource = dt;
        }
    }
}
