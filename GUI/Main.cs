using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grocery_store.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            reset_UC();
            UC_BanHang.Visible = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void reset_UC()
        {
            //set visible all user control is false
            UC_BanHang.Visible = false;
            UC_HoaDon.Visible = false;
            UC_HangHoa.Visible = false;
            UC_ThongKe.Visible = false;
            UC_NhanVien.Visible = false;
            UC_QuanLy.Visible = false; 
        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_BanHang.Visible = true;
            btn_banhang.OnPressedState.FillColor = Color.FromArgb(82, 121, 111);
            
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_HoaDon.Visible = true;
            btn_hoadon.OnPressedState.FillColor = Color.FromArgb(82, 121, 111);
        }

        private void btn_hanghoa_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_HangHoa.Visible = true;
            btn_hanghoa.OnPressedState.FillColor = Color.FromArgb(82, 121, 111);
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_ThongKe.Visible = true;
            btn_thongke.OnPressedState.FillColor = Color.FromArgb(82, 121, 111);
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_NhanVien.Visible = true;
            btn_nhanvien.OnPressedState.FillColor = Color.FromArgb(82, 121, 111);
        }

        private void btn_quanly_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_QuanLy.Visible = true;
            btn_quanly.OnPressedState.FillColor = Color.FromArgb(82, 121, 111);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            reset_UC();
            btn_thoat.OnPressedState.FillColor = Color.FromArgb(82, 121, 111);
        }
    }
}
