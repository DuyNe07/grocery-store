namespace grocery_store.GUI.Dashboard
{
    partial class HangHoa
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btn_san_pham = new Guna.UI.WinForms.GunaButton();
            this.btn_phan_loai = new Guna.UI.WinForms.GunaButton();
            this.btn_nha_cung_cap = new Guna.UI.WinForms.GunaButton();
            this.btn_nhap_hang = new Guna.UI.WinForms.GunaButton();
            this.panel_hang_hoa = new Guna.UI.WinForms.GunaPanel();
            this.UC_danh_sach_san_pham = new grocery_store.GUI.HangHoa.DanhSachSanPham();
            this.UC_nhap_kho = new grocery_store.GUI.HangHoa.NhapKho();
            this.UC_danh_sach_phan_loai = new grocery_store.GUI.HangHoa.DanhSachPhanLoai();
            this.UC_danh_sach_nha_cung_cap = new grocery_store.GUI.HangHoa.DanhSachNhaCungCap();
            this.lb_name_control = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.panel_hang_hoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.gunaPanel1.Controls.Add(this.lb_name_control);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1720, 100);
            this.gunaPanel1.TabIndex = 1;
            // 
            // btn_san_pham
            // 
            this.btn_san_pham.AnimationHoverSpeed = 0.07F;
            this.btn_san_pham.AnimationSpeed = 0.03F;
            this.btn_san_pham.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.btn_san_pham.BorderColor = System.Drawing.Color.Black;
            this.btn_san_pham.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_san_pham.ForeColor = System.Drawing.Color.White;
            this.btn_san_pham.Image = null;
            this.btn_san_pham.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_san_pham.Location = new System.Drawing.Point(0, 0);
            this.btn_san_pham.Name = "btn_san_pham";
            this.btn_san_pham.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_san_pham.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_san_pham.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.btn_san_pham.OnHoverImage = null;
            this.btn_san_pham.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.btn_san_pham.OnPressedDepth = 50;
            this.btn_san_pham.Size = new System.Drawing.Size(250, 100);
            this.btn_san_pham.TabIndex = 2;
            this.btn_san_pham.Text = "Sản Phẩm";
            this.btn_san_pham.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_san_pham.Click += new System.EventHandler(this.btn_san_pham_Click);
            // 
            // btn_phan_loai
            // 
            this.btn_phan_loai.AnimationHoverSpeed = 0.07F;
            this.btn_phan_loai.AnimationSpeed = 0.03F;
            this.btn_phan_loai.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.btn_phan_loai.BorderColor = System.Drawing.Color.Black;
            this.btn_phan_loai.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phan_loai.ForeColor = System.Drawing.Color.White;
            this.btn_phan_loai.Image = null;
            this.btn_phan_loai.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_phan_loai.Location = new System.Drawing.Point(250, 0);
            this.btn_phan_loai.Name = "btn_phan_loai";
            this.btn_phan_loai.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_phan_loai.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_phan_loai.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.btn_phan_loai.OnHoverImage = null;
            this.btn_phan_loai.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.btn_phan_loai.OnPressedDepth = 50;
            this.btn_phan_loai.Size = new System.Drawing.Size(250, 100);
            this.btn_phan_loai.TabIndex = 3;
            this.btn_phan_loai.Text = "Phân Loại";
            this.btn_phan_loai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_phan_loai.Click += new System.EventHandler(this.btn_phan_loai_Click);
            // 
            // btn_nha_cung_cap
            // 
            this.btn_nha_cung_cap.AnimationHoverSpeed = 0.07F;
            this.btn_nha_cung_cap.AnimationSpeed = 0.03F;
            this.btn_nha_cung_cap.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.btn_nha_cung_cap.BorderColor = System.Drawing.Color.Black;
            this.btn_nha_cung_cap.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nha_cung_cap.ForeColor = System.Drawing.Color.White;
            this.btn_nha_cung_cap.Image = null;
            this.btn_nha_cung_cap.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_nha_cung_cap.Location = new System.Drawing.Point(500, 0);
            this.btn_nha_cung_cap.Name = "btn_nha_cung_cap";
            this.btn_nha_cung_cap.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_nha_cung_cap.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_nha_cung_cap.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.btn_nha_cung_cap.OnHoverImage = null;
            this.btn_nha_cung_cap.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.btn_nha_cung_cap.OnPressedDepth = 50;
            this.btn_nha_cung_cap.Size = new System.Drawing.Size(250, 100);
            this.btn_nha_cung_cap.TabIndex = 3;
            this.btn_nha_cung_cap.Text = "Nhà Cung Cấp";
            this.btn_nha_cung_cap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_nha_cung_cap.Click += new System.EventHandler(this.btn_nha_cung_cap_Click);
            // 
            // btn_nhap_hang
            // 
            this.btn_nhap_hang.AnimationHoverSpeed = 0.07F;
            this.btn_nhap_hang.AnimationSpeed = 0.03F;
            this.btn_nhap_hang.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.btn_nhap_hang.BorderColor = System.Drawing.Color.Black;
            this.btn_nhap_hang.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhap_hang.ForeColor = System.Drawing.Color.White;
            this.btn_nhap_hang.Image = null;
            this.btn_nhap_hang.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_nhap_hang.Location = new System.Drawing.Point(750, 0);
            this.btn_nhap_hang.Name = "btn_nhap_hang";
            this.btn_nhap_hang.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_nhap_hang.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_nhap_hang.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.btn_nhap_hang.OnHoverImage = null;
            this.btn_nhap_hang.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.btn_nhap_hang.OnPressedDepth = 50;
            this.btn_nhap_hang.Size = new System.Drawing.Size(250, 100);
            this.btn_nhap_hang.TabIndex = 4;
            this.btn_nhap_hang.Text = "Nhập Hàng";
            this.btn_nhap_hang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_nhap_hang.Click += new System.EventHandler(this.btn_nhap_hang_Click);
            // 
            // panel_hang_hoa
            // 
            this.panel_hang_hoa.Controls.Add(this.UC_danh_sach_san_pham);
            this.panel_hang_hoa.Controls.Add(this.UC_nhap_kho);
            this.panel_hang_hoa.Controls.Add(this.UC_danh_sach_phan_loai);
            this.panel_hang_hoa.Controls.Add(this.UC_danh_sach_nha_cung_cap);
            this.panel_hang_hoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_hang_hoa.Location = new System.Drawing.Point(0, 100);
            this.panel_hang_hoa.Name = "panel_hang_hoa";
            this.panel_hang_hoa.Size = new System.Drawing.Size(1720, 950);
            this.panel_hang_hoa.TabIndex = 5;
            // 
            // UC_danh_sach_san_pham
            // 
            this.UC_danh_sach_san_pham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.UC_danh_sach_san_pham.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UC_danh_sach_san_pham.Location = new System.Drawing.Point(0, 0);
            this.UC_danh_sach_san_pham.Name = "UC_danh_sach_san_pham";
            this.UC_danh_sach_san_pham.Size = new System.Drawing.Size(1730, 950);
            this.UC_danh_sach_san_pham.TabIndex = 3;
            // 
            // UC_nhap_kho
            // 
            this.UC_nhap_kho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.UC_nhap_kho.Location = new System.Drawing.Point(0, 0);
            this.UC_nhap_kho.Name = "UC_nhap_kho";
            this.UC_nhap_kho.Size = new System.Drawing.Size(1730, 950);
            this.UC_nhap_kho.TabIndex = 2;
            // 
            // UC_danh_sach_phan_loai
            // 
            this.UC_danh_sach_phan_loai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.UC_danh_sach_phan_loai.Location = new System.Drawing.Point(0, 0);
            this.UC_danh_sach_phan_loai.Name = "UC_danh_sach_phan_loai";
            this.UC_danh_sach_phan_loai.Size = new System.Drawing.Size(1730, 950);
            this.UC_danh_sach_phan_loai.TabIndex = 1;
            // 
            // UC_danh_sach_nha_cung_cap
            // 
            this.UC_danh_sach_nha_cung_cap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.UC_danh_sach_nha_cung_cap.Location = new System.Drawing.Point(0, 0);
            this.UC_danh_sach_nha_cung_cap.Name = "UC_danh_sach_nha_cung_cap";
            this.UC_danh_sach_nha_cung_cap.Size = new System.Drawing.Size(1730, 950);
            this.UC_danh_sach_nha_cung_cap.TabIndex = 10;
            // 
            // lb_name_control
            // 
            this.lb_name_control.AutoSize = true;
            this.lb_name_control.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.lb_name_control.ForeColor = System.Drawing.Color.White;
            this.lb_name_control.Location = new System.Drawing.Point(1210, 30);
            this.lb_name_control.Name = "lb_name_control";
            this.lb_name_control.Size = new System.Drawing.Size(380, 41);
            this.lb_name_control.TabIndex = 3;
            this.lb_name_control.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_hang_hoa);
            this.Controls.Add(this.btn_nhap_hang);
            this.Controls.Add(this.btn_phan_loai);
            this.Controls.Add(this.btn_nha_cung_cap);
            this.Controls.Add(this.btn_san_pham);
            this.Controls.Add(this.gunaPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HangHoa";
            this.Size = new System.Drawing.Size(1720, 1050);
            this.Load += new System.EventHandler(this.HangHoa_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.panel_hang_hoa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btn_san_pham;
        private Guna.UI.WinForms.GunaButton btn_phan_loai;
        private Guna.UI.WinForms.GunaButton btn_nha_cung_cap;
        private Guna.UI.WinForms.GunaButton btn_nhap_hang;
        private Guna.UI.WinForms.GunaPanel panel_hang_hoa;
        private GUI.HangHoa.NhapKho UC_nhap_kho;
        private GUI.HangHoa.DanhSachPhanLoai UC_danh_sach_phan_loai;
        private GUI.HangHoa.DanhSachNhaCungCap UC_danh_sach_nha_cung_cap;
        private GUI.HangHoa.DanhSachSanPham UC_danh_sach_san_pham;
        private Guna.UI.WinForms.GunaLabel lb_name_control;
    }
}
