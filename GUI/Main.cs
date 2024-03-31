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
            UC_BanHang.Visible = false;
            UC_HoaDon.Visible = false;
            UC_HangHoa.Visible = false;
            UC_ThongKe.Visible = false;
            UC_NhanVien.Visible = false;
            UC_QuanLy.Visible = false; 
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_BanHang.Visible = true;
            
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_HoaDon.Visible = true;
        }

        private void btn_good_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_HangHoa.Visible = true;
        }

        private void btn_statistical_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_ThongKe.Visible = true;
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_NhanVien.Visible = true;
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            reset_UC();
            UC_QuanLy.Visible = true;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
