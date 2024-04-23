namespace grocery_store.GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangHoa));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.txtbox_tim_kiem = new Guna.UI.WinForms.GunaTextBox();
            this.btn_san_pham = new Guna.UI.WinForms.GunaButton();
            this.btn_phan_loai = new Guna.UI.WinForms.GunaButton();
            this.btn_nhap_hang = new Guna.UI.WinForms.GunaButton();
            this.panel_hang_hoa = new Guna.UI.WinForms.GunaPanel();
            this.UC_danh_sach_san_pham = new grocery_store.GUI.HangHoa_.DanhSachSanPham();
            this.UC_nhap_kho = new grocery_store.GUI.HangHoa_.NhapKho();
            this.UC_danh_sach_phan_loai = new grocery_store.GUI.HangHoa_.DanhSachPhanLoai();
            this.gunaPanel1.SuspendLayout();
            this.panel_hang_hoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.txtbox_tim_kiem);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1720, 100);
            this.gunaPanel1.TabIndex = 1;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.White;
            this.gunaButton1.BorderSize = 3;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.gunaButton1.Location = new System.Drawing.Point(1075, 13);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(90, 70);
            this.gunaButton1.TabIndex = 0;
            // 
            // txtbox_tim_kiem
            // 
            this.txtbox_tim_kiem.BaseColor = System.Drawing.Color.White;
            this.txtbox_tim_kiem.BorderColor = System.Drawing.Color.Silver;
            this.txtbox_tim_kiem.BorderSize = 0;
            this.txtbox_tim_kiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_tim_kiem.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbox_tim_kiem.FocusedBorderColor = System.Drawing.Color.White;
            this.txtbox_tim_kiem.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtbox_tim_kiem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_tim_kiem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtbox_tim_kiem.Location = new System.Drawing.Point(1165, 13);
            this.txtbox_tim_kiem.Name = "txtbox_tim_kiem";
            this.txtbox_tim_kiem.PasswordChar = '\0';
            this.txtbox_tim_kiem.Size = new System.Drawing.Size(450, 70);
            this.txtbox_tim_kiem.TabIndex = 0;
            this.txtbox_tim_kiem.Text = "Tìm Kiếm";
            this.txtbox_tim_kiem.TextOffsetX = 15;
            this.txtbox_tim_kiem.Enter += new System.EventHandler(this.txtbox_tim_kiem_Enter);
            this.txtbox_tim_kiem.Leave += new System.EventHandler(this.txtbox_tim_kiem_Leave);
            this.txtbox_tim_kiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtbox_tim_kiem_MouseClick);
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
            this.btn_nhap_hang.Location = new System.Drawing.Point(500, 0);
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
            this.panel_hang_hoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_hang_hoa.Location = new System.Drawing.Point(0, 100);
            this.panel_hang_hoa.Name = "panel_hang_hoa";
            this.panel_hang_hoa.Size = new System.Drawing.Size(1720, 950);
            this.panel_hang_hoa.TabIndex = 5;
            // 
            // UC_danh_sach_san_pham
            // 
            this.UC_danh_sach_san_pham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_danh_sach_san_pham.BackColor = System.Drawing.Color.White;
            this.UC_danh_sach_san_pham.Location = new System.Drawing.Point(0, 0);
            this.UC_danh_sach_san_pham.Name = "UC_danh_sach_san_pham";
            this.UC_danh_sach_san_pham.Size = new System.Drawing.Size(1730, 950);
            this.UC_danh_sach_san_pham.TabIndex = 0;
            // 
            // UC_nhap_kho
            // 
            this.UC_nhap_kho.Location = new System.Drawing.Point(0, 0);
            this.UC_nhap_kho.Name = "UC_nhap_kho";
            this.UC_nhap_kho.Size = new System.Drawing.Size(1730, 950);
            this.UC_nhap_kho.TabIndex = 2;
            // 
            // UC_danh_sach_phan_loai
            // 
            this.UC_danh_sach_phan_loai.Location = new System.Drawing.Point(0, 0);
            this.UC_danh_sach_phan_loai.Name = "UC_danh_sach_phan_loai";
            this.UC_danh_sach_phan_loai.Size = new System.Drawing.Size(1730, 950);
            this.UC_danh_sach_phan_loai.TabIndex = 1;
            // 
            // HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_hang_hoa);
            this.Controls.Add(this.btn_nhap_hang);
            this.Controls.Add(this.btn_phan_loai);
            this.Controls.Add(this.btn_san_pham);
            this.Controls.Add(this.gunaPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HangHoa";
            this.Size = new System.Drawing.Size(1720, 1050);
            this.Load += new System.EventHandler(this.HangHoa_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.panel_hang_hoa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btn_san_pham;
        private Guna.UI.WinForms.GunaButton btn_phan_loai;
        private Guna.UI.WinForms.GunaButton btn_nhap_hang;
        private Guna.UI.WinForms.GunaPanel panel_hang_hoa;
        private Guna.UI.WinForms.GunaTextBox txtbox_tim_kiem;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private HangHoa_.DanhSachSanPham UC_danh_sach_san_pham;
        private HangHoa_.NhapKho UC_nhap_kho;
        private HangHoa_.DanhSachPhanLoai UC_danh_sach_phan_loai;
    }
}
