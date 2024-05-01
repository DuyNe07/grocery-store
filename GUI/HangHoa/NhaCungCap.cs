using grocery_store.Models;
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
        public async Task Sua()
        {
            
        }

        public async void Them()
        {

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

    }
}
