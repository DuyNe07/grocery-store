using System;
using System.Drawing;
using System.Windows.Forms;

namespace grocery_store.GUI.Dashboard
{
    public partial class HangHoa : UserControl
    {
        private GUI.HangHoa.NhapKho UC_nhap_kho;
        private GUI.HangHoa.DanhSachPhanLoai UC_danh_sach_phan_loai;
        private GUI.HangHoa.DanhSachNhaCungCap UC_danh_sach_nha_cung_cap;
        private GUI.HangHoa.DanhSachSanPham UC_danh_sach_san_pham;

        public HangHoa()
        {
            InitializeComponent();

            // UC_danh_sach_san_pham
            // 
            this.UC_danh_sach_san_pham = new GUI.HangHoa.DanhSachSanPham();
            this.UC_danh_sach_san_pham.Location = new System.Drawing.Point(0, 0);
            this.UC_danh_sach_san_pham.Name = "UC_danh_sach_san_pham";
            this.UC_danh_sach_san_pham.Size = new System.Drawing.Size(1730, 950);
            // 

            // UC_danh_sach_phan_loai
            // 
            this.UC_danh_sach_phan_loai = new GUI.HangHoa.DanhSachPhanLoai();
            this.UC_danh_sach_phan_loai.Location = new System.Drawing.Point(0, 0);
            this.UC_danh_sach_phan_loai.Name = "UC_danh_sach_phan_loai";
            this.UC_danh_sach_phan_loai.Size = new System.Drawing.Size(1730, 950);
            // 
            // UC_danh_sach_nha_cung_cap
            // 
            this.UC_danh_sach_nha_cung_cap = new GUI.HangHoa.DanhSachNhaCungCap();
            this.UC_danh_sach_nha_cung_cap.Location = new System.Drawing.Point(0, 0);
            this.UC_danh_sach_nha_cung_cap.Name = "UC_danh_sach_nha_cung_cap";
            this.UC_danh_sach_nha_cung_cap.Size = new System.Drawing.Size(1730, 950);
            // 

            // UC_nhap_kho
            // 
            //this.UC_nhap_kho = new GUI.HangHoa.NhapKho();
            //this.UC_nhap_kho.Location = new System.Drawing.Point(0, 0);
            //this.UC_nhap_kho.Name = "UC_nhap_kho";
            //this.UC_nhap_kho.Size = new System.Drawing.Size(1730, 950);
            //
        }


        private void HangHoa_Load(object sender, EventArgs e)
        {

            SetView(1, 0, 0, 0);
            lb_name_control.Text = "DANH SÁCH SẢN PHẨM";
        }

        private void SetView(int san_pham, int phan_loai,int nha_cung_cap, int nhap_kho)
        {
            // Định dang cho nút sản phẩm
            if (san_pham == 0)
            {
                this.panel_hang_hoa.Controls.Remove(UC_danh_sach_san_pham);
                btn_san_pham.BaseColor = Color.FromArgb(109, 125, 229);
                btn_san_pham.OnHoverBaseColor = Color.FromArgb(72, 83, 152);
                btn_san_pham.ForeColor = Color.White;
            }
            else
            {
                UC_danh_sach_san_pham.LoadCombobox();
                this.panel_hang_hoa.Controls.Add(UC_danh_sach_san_pham);
                btn_san_pham.BaseColor = Color.FromArgb(196, 211, 249);
                btn_san_pham.ForeColor = Color.FromArgb(109, 125, 229);
                btn_san_pham.OnHoverBaseColor = Color.FromArgb(196, 211, 249);
            }

            // Định dang cho nút phân loại
            if (phan_loai == 0)
            {
                this.panel_hang_hoa.Controls.Remove(UC_danh_sach_phan_loai);
                btn_phan_loai.BaseColor = Color.FromArgb(109, 125, 229);
                btn_phan_loai.OnHoverBaseColor = Color.FromArgb(72, 83, 152);
                btn_phan_loai.ForeColor = Color.White;
            }
            else
            {
                this.panel_hang_hoa.Controls.Add(UC_danh_sach_phan_loai);
                btn_phan_loai.BaseColor = Color.FromArgb(196, 211, 249);
                btn_phan_loai.ForeColor = Color.FromArgb(109, 125, 229);
                btn_phan_loai.OnHoverBaseColor = Color.FromArgb(196, 211, 249);
            }

            // Định dang cho nút nhà cung cấp
            if (nha_cung_cap == 0)
            {
                this.panel_hang_hoa.Controls.Remove(UC_danh_sach_nha_cung_cap);
                btn_nha_cung_cap.BaseColor = Color.FromArgb(109, 125, 229);
                btn_nha_cung_cap.OnHoverBaseColor = Color.FromArgb(72, 83, 152);
                btn_nha_cung_cap.ForeColor = Color.White;
            }
            else
            {
                this.panel_hang_hoa.Controls.Add(UC_danh_sach_nha_cung_cap);
                btn_nha_cung_cap.BaseColor = Color.FromArgb(196, 211, 249);
                btn_nha_cung_cap.ForeColor = Color.FromArgb(109, 125, 229);
                btn_nha_cung_cap.OnHoverBaseColor = Color.FromArgb(196, 211, 249);
            }

            // Định dang cho nút nhập kho
            //if (nhap_kho == 0)
            //{
            //    this.panel_hang_hoa.Controls.Remove(UC_nhap_kho);
            //    btn_nhap_hang.BaseColor = Color.FromArgb(109, 125, 229);
            //    btn_nhap_hang.OnHoverBaseColor = Color.FromArgb(72, 83, 152);
            //    btn_nhap_hang.ForeColor = Color.White;
            //}
            //else
            //{
            //this.panel_hang_hoa.Controls.Add(UC_nhap_kho);
            //btn_nhap_hang.BaseColor = Color.FromArgb(196, 211, 249);
            //    btn_nhap_hang.ForeColor = Color.FromArgb(109, 125, 229);
            //    btn_nhap_hang.OnHoverBaseColor = Color.FromArgb(196, 211, 249);
            //}

        }

        private void btn_san_pham_Click(object sender, EventArgs e)
        {
            SetView(1,0,0,0);
            lb_name_control.Text = "DANH SÁCH SẢN PHẨM";
        }

        private void btn_phan_loai_Click(object sender, EventArgs e)
        {
            SetView(0, 1, 0, 0);
            lb_name_control.Text = "PHÂN LOẠI";
        }

        //private void btn_nhap_hang_Click(object sender, EventArgs e)
        //{
        //    SetView(0, 0, 0, 1);
        //    lb_name_control.Text = "NHẬP HÀNG";
        //}

        private void btn_nha_cung_cap_Click(object sender, EventArgs e)
        {
            SetView(0, 0, 1, 0);
            lb_name_control.Text = "NHÀ CUNG CẤP";
        }

    }

    #region design
    
    #endregion
}
