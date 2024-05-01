using grocery_store.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grocery_store.GUI.HangHoa
{
    public partial class NhaCungCap : UserControl
    {
        public event EventHandler HuyClick;
        public event EventHandler LuuClick;
        private Supplier currentSupplier;

        public NhaCungCap(Supplier supplier)
        {
            InitializeComponent();
            this.btn_huy.Click += (sender, e) => HuyClick?.Invoke(this, e);
            this.btn_luu.Click += (sender, e) => LuuClick?.Invoke(this, e);
            this.currentSupplier = supplier;
        }

        #region Load
        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            if (currentSupplier == null)
            {
                lb_name_control.Text = "THÊM NHÀ CUNG CẤP";
                LoadFormThem();
            }
            else
            {
                lb_name_control.Text = "SỬA NHÀ CUNG CẤP";
                LoadFormSua();
            }
        }
        #endregion

        #region Chức năng
        public async Task<int> Sua()
        {
            Supplier supplierToUpdate;
            string ErrorMessage = CheckInput();
            if (string.IsNullOrWhiteSpace(ErrorMessage))
            {
                using (var dbContext = new GroceryStoreContext())
                {
                    supplierToUpdate = await dbContext.Supplier.FindAsync(currentSupplier.SupplierId);

                    if (supplierToUpdate != null)
                    {
                        supplierToUpdate.Name = tb_ten_nha_cung_cap.Text;
                        supplierToUpdate.Email = tb_email.Text;
                        supplierToUpdate.Phone = tb_so_dien_thoai.Text;
                        await dbContext.SaveChangesAsync();
                    }
                }
            }
            else
            {
                MessageBox.Show(ErrorMessage, "Thông tin bị thiếu hoặc chưa chính xác");
                return 1;
            }
            return 0;
        }

        public async Task<int> Them()
        {
            Supplier newSupplier;
            string ErrorMessage = CheckInput();
            if (string.IsNullOrWhiteSpace(ErrorMessage))
            {
                newSupplier = new Supplier();

                newSupplier.Name = tb_ten_nha_cung_cap.Text;
                newSupplier.Email = tb_email.Text;
                newSupplier.Phone = tb_so_dien_thoai.Text;

                using (var dbContext = new GroceryStoreContext())
                {
                    await dbContext.AddAsync(newSupplier);
                    await dbContext.SaveChangesAsync();
                }
            }
            else
            {
                MessageBox.Show(ErrorMessage, "Thông tin bị thiếu hoặc chưa chính xác");
                return 1;
            }
            return 0;


        }
        #endregion

        #region Util Giao Diện
        private void LoadFormThem()
        {
            tb_ten_nha_cung_cap.Text = string.Empty;
            tb_email.Text = string.Empty;
            tb_so_dien_thoai.Text = string.Empty;
        }
        private void LoadFormSua()
        {
            tb_ten_nha_cung_cap.Text = currentSupplier.Name;
            tb_email.Text = currentSupplier.Email;
            tb_so_dien_thoai.Text = currentSupplier.Phone;
        }
        #endregion

        #region Kiểm tra giá trị nhập vào
        public string CheckInput()
        {
            string ErrorMessage = "";
            if (string.IsNullOrEmpty(tb_ten_nha_cung_cap.Text))
            {
                ErrorMessage += "- Vui lòng nhập tên nhà cung cấp.\n";
            }

            if (string.IsNullOrEmpty(tb_email.Text))
            {
                ErrorMessage += "- Vui lòng nhập email.\n";
            }
            else
            {
                // Kiểm tra email hợp lệ bằng regex 
                if (!Regex.IsMatch(tb_email.Text, @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$"))
                {
                    ErrorMessage += "- Email không hợp lệ.\n";
                }
            }

            if (string.IsNullOrEmpty(tb_so_dien_thoai.Text))
            {
                ErrorMessage += "- Vui lòng nhập số điện thoại.\n";
            }
            else
            {
                // Kiểm tra số điện thoại hợp lệ bằng regex 
                if (!Regex.IsMatch(tb_so_dien_thoai.Text, @"^0\d{9}$"))
                {
                    ErrorMessage += "- Số điện thoại không hợp lệ.\n";
                }
            }

            return ErrorMessage;
        }
        private void tb_ten_nha_cung_cap_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_ten_nha_cung_cap.Text))
            {
                lb_name_error.Text = "Vui lòng nhập tên nhà cung cấp.";
            }
            else
            {
                lb_name_error.Text = null;
            }
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_email.Text))
            {
                lb_error_email.Text = "Vui lòng nhập email.";
            }
            else
            {
                // Kiểm tra email hợp lệ bằng regex 
                if (!Regex.IsMatch(tb_email.Text, @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$"))
                {
                    lb_error_email.Text = "Email không hợp lệ.";
                }
                else
                {
                    lb_error_email.Text = null;
                }
            }
        }

        private void tb_so_dien_thoai_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_so_dien_thoai.Text))
            {
                lb_erro_so_dien_thoai.Text = "Vui lòng nhập số điện thoại.";
            }
            else
            {
                // Kiểm tra số điện thoại hợp lệ bằng regex 
                if (!Regex.IsMatch(tb_so_dien_thoai.Text, @"^0\d{9}$"))
                {
                    lb_erro_so_dien_thoai.Text = "Số điện thoại không hợp lệ.";
                }
                else
                {
                    lb_erro_so_dien_thoai.Text = null;
                }
            }
        }


        #endregion


    }
}
