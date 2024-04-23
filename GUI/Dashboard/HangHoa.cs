using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grocery_store.GUI
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
            set_color(1, 0, 0);
        }

        private void txtbox_tim_kiem_MouseClick(object sender, MouseEventArgs e)
        {

           
            
        }

        private void txtbox_tim_kiem_Enter(object sender, EventArgs e)
        {
            txtbox_tim_kiem.Text = "";
        }
        private void txtbox_tim_kiem_Leave(object sender, EventArgs e)
        {
            txtbox_tim_kiem.Text = "Tìm Kiếm";
        }

        private void reset_UC()
        {
            UC_nhap_kho.Visible = false;
            UC_danh_sach_phan_loai.Visible = false;
            UC_danh_sach_san_pham.Visible = false;
        }

        private void set_color(int san_pham, int phan_loai, int nhap_kho)
        {
            // Định dang cho nút sản phẩm
            if (san_pham == 0)
            {
                btn_san_pham.BaseColor = Color.FromArgb(109, 125, 229);
                btn_san_pham.ForeColor = Color.White;
            } else
            {
                btn_san_pham.BaseColor = Color.White;
                btn_san_pham.ForeColor = Color.FromArgb(109, 125, 229);
            }

            // Định dang cho nút phân loại
            if (phan_loai == 0)
            {
                btn_phan_loai.BaseColor = Color.FromArgb(109, 125, 229);
                btn_phan_loai.ForeColor = Color.White;
            }
            else
            {
                btn_phan_loai.BaseColor = Color.White;
                btn_phan_loai.ForeColor = Color.FromArgb(109, 125, 229);
            }

            // Định dang cho nút nhập kho
            if (nhap_kho == 0)
            {
                btn_nhap_hang.BaseColor = Color.FromArgb(109, 125, 229);
                btn_nhap_hang.ForeColor = Color.White;
            }
            else
            {
                btn_nhap_hang.BaseColor = Color.White;
                btn_nhap_hang.ForeColor = Color.FromArgb(109, 125, 229);
            }

        }

        private void btn_san_pham_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_danh_sach_san_pham.Visible = true;
            set_color(1,0,0);
        }

        private void btn_phan_loai_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_danh_sach_phan_loai.Visible = true;
            set_color(0, 1, 0);
        }

        private void btn_nhap_hang_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_nhap_kho.Visible = true;
            set_color(0, 0, 1);
        }


    }
}
