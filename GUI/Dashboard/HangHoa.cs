using System;
using System.Drawing;
using System.Windows.Forms;

namespace grocery_store.GUI.Dashboard
{
    public partial class HangHoa : UserControl
    {
        public HangHoa()
        {
            InitializeComponent();
        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            reset_UC();
            UC_danh_sach_san_pham.Visible = true;
            set_color(1, 0, 0, 0);
            lb_name_control.Text = "DANH SÁCH SẢN PHẨM";
        }


        private void reset_UC()
        {
            UC_nhap_kho.Visible = false;
            UC_danh_sach_phan_loai.Visible = false;
            UC_danh_sach_san_pham.Visible = false;
            UC_danh_sach_nha_cung_cap.Visible = false;
        }

        private void set_color(int san_pham, int phan_loai,int nha_cung_cap, int nhap_kho)
        {
            // Định dang cho nút sản phẩm
            if (san_pham == 0)
            {
                btn_san_pham.BaseColor = Color.FromArgb(109, 125, 229);
                btn_san_pham.OnHoverBaseColor = Color.FromArgb(72, 83, 152);
                btn_san_pham.ForeColor = Color.White;
            }
            else
            {
                btn_san_pham.BaseColor = Color.FromArgb(196, 211, 249);
                btn_san_pham.ForeColor = Color.FromArgb(109, 125, 229);
                btn_san_pham.OnHoverBaseColor = Color.FromArgb(196, 211, 249);
            }

            // Định dang cho nút phân loại
            if (phan_loai == 0)
            {
                btn_phan_loai.BaseColor = Color.FromArgb(109, 125, 229);
                btn_phan_loai.OnHoverBaseColor = Color.FromArgb(72, 83, 152);
                btn_phan_loai.ForeColor = Color.White;
            }
            else
            {
                btn_phan_loai.BaseColor = Color.FromArgb(196, 211, 249);
                btn_phan_loai.ForeColor = Color.FromArgb(109, 125, 229);
                btn_phan_loai.OnHoverBaseColor = Color.FromArgb(196, 211, 249);
            }

            // Định dang cho nút nhà cung cấp
            if (nha_cung_cap == 0)
            {
                btn_nha_cung_cap.BaseColor = Color.FromArgb(109, 125, 229);
                btn_nha_cung_cap.OnHoverBaseColor = Color.FromArgb(72, 83, 152);
                btn_nha_cung_cap.ForeColor = Color.White;
            }
            else
            {
                btn_nha_cung_cap.BaseColor = Color.FromArgb(196, 211, 249);
                btn_nha_cung_cap.ForeColor = Color.FromArgb(109, 125, 229);
                btn_nha_cung_cap.OnHoverBaseColor = Color.FromArgb(196, 211, 249);
            }

            // Định dang cho nút nhập kho
            if (nhap_kho == 0)
            {
                btn_nhap_hang.BaseColor = Color.FromArgb(109, 125, 229);
                btn_nhap_hang.OnHoverBaseColor = Color.FromArgb(72, 83, 152);
                btn_nhap_hang.ForeColor = Color.White;
            }
            else
            {
                btn_nhap_hang.BaseColor = Color.FromArgb(196, 211, 249);
                btn_nhap_hang.ForeColor = Color.FromArgb(109, 125, 229);
                btn_nhap_hang.OnHoverBaseColor = Color.FromArgb(196, 211, 249);
            }

        }

        private void btn_san_pham_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_danh_sach_san_pham.Visible = true;
            set_color(1,0,0,0);
            lb_name_control.Text = "DANH SÁCH SẢN PHẨM";
        }

        private void btn_phan_loai_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_danh_sach_phan_loai.Visible = true;
            set_color(0, 1, 0, 0);
            lb_name_control.Text = "PHÂN LOẠI";
        }

        private void btn_nhap_hang_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_nhap_kho.Visible = true;
            set_color(0, 0, 0, 1);
            lb_name_control.Text = "NHẬP HÀNG";
        }

        private void btn_nha_cung_cap_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_danh_sach_nha_cung_cap.Visible = true;
            set_color(0, 0, 1, 0);
            lb_name_control.Text = "NHÀ CUNG CẤP";
        }
    }
}
