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
    public partial class DanhSachPhanLoai : UserControl
    {
        public DanhSachPhanLoai()
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

        private void gridview_danh_sach_loai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
