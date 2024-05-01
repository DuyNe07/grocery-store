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
    public partial class DanhSachNhaCungCap : UserControl
    {
        private Supplier currentSupplier;
        private int indexCurrentRow;
        public DanhSachNhaCungCap()
        {
            InitializeComponent();
        }

        #region Load
        private async void DanhSachNhaCungCap_Load(object sender, EventArgs e)
        {
            gridview_danh_sach_nha_cung_cap.DataSource = await GetSupplierTable();
            UpdateSoDong();
        }

        private async void gridview_danh_sach_nha_cung_cap_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            indexCurrentRow = e.RowIndex;

            DataGridViewRow selectedRow = gridview_danh_sach_nha_cung_cap.Rows[indexCurrentRow];

            if (selectedRow != null)
            {
                int supplierID = Convert.ToInt32(selectedRow.Cells[0].Value);
                using (var dbContext = new GroceryStoreContext())
                {
                    currentSupplier = await dbContext.Supplier.FirstOrDefaultAsync(p => p.SupplierId == supplierID);
                }
            }
        }
        #endregion

        #region Chức năng thêm nhà cung cấp
        private void btn_them_Click(object sender, EventArgs e)
        {
            NhaCungCap UC_Nha_Cung_cap = new NhaCungCap(null);
            UC_Nha_Cung_cap.Location = new Point(0, 0);
            UC_Nha_Cung_cap.HuyClick += (S, args) =>
            {
                this.Controls.Remove(UC_Nha_Cung_cap);
            };

            UC_Nha_Cung_cap.LuuClick += async (S, args) =>
            {
                try
                {
                    UC_Nha_Cung_cap.Them();
                    this.Controls.Remove(UC_Nha_Cung_cap);
                    gridview_danh_sach_nha_cung_cap.DataSource = await GetSupplierTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message + "\nVui lòng thực hiện lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            this.Controls.Add(UC_Nha_Cung_cap);
            UC_Nha_Cung_cap.BringToFront();
        }
        #endregion

        #region Chức năng sửa nhà cung cấp
        private void btn_sua_Click(object sender, EventArgs e)
        {
            NhaCungCap UC_Nha_Cung_cap = new NhaCungCap(currentSupplier);
            UC_Nha_Cung_cap.Location = new Point(0, 0);
            UC_Nha_Cung_cap.HuyClick += (S, args) =>
            {
                this.Controls.Remove(UC_Nha_Cung_cap);
            };

            UC_Nha_Cung_cap.LuuClick += async (S, args) =>
            {
                try
                {
                    await UC_Nha_Cung_cap.Sua();
                    this.Controls.Remove(UC_Nha_Cung_cap);
                    gridview_danh_sach_nha_cung_cap.DataSource = await GetSupplierTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message + "\nVui lòng thực hiện lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            this.Controls.Add(UC_Nha_Cung_cap);
            UC_Nha_Cung_cap.BringToFront();
        }
        #endregion

        #region Chức năng xóa nhà cung cấp
        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region DB Util
        private async Task<DataTable> GetSupplierTable()
        {
            DataTable SuplierTable = new DataTable();
            SuplierTable.Columns.Add("SupplierID", typeof(int));
            SuplierTable.Columns.Add("Suppliername", typeof(string));
            SuplierTable.Columns.Add("Email", typeof(string));
            SuplierTable.Columns.Add("PhoneNumber", typeof(string));
            SuplierTable.Columns.Add("NumOfProducts", typeof(int));

            List<Supplier> suppliers = await GetSupplierList();

            foreach (Supplier supplier in suppliers)
            {
                SuplierTable.Rows.Add(supplier.SupplierId,
                            supplier.Name,
                            supplier.Email,
                            supplier.Phone,
                            supplier.Product.Count
                            );
            }
            return SuplierTable;
        }
        private async Task<List<Supplier>> GetSupplierList()
        {
            List<Supplier> suppliers;
            using (var dbContext = new GroceryStoreContext())
            {
                suppliers = await dbContext.Supplier.Include(p => p.Product).ToListAsync();
            }
            return suppliers;
        }
        #endregion

        #region Util
        private void UpdateSoDong()
        {
            lb_so_luong_nha_cung_cap.Text = gridview_danh_sach_nha_cung_cap.RowCount.ToString();
        }
        #endregion



    }
}
