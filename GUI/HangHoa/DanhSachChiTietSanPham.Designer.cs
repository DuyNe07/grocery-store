namespace grocery_store.GUI.HangHoa
{
    partial class DanhSachChiTietSanPham
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
            Guna.UI.WinForms.GunaPanel gunaPanel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachChiTietSanPham));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_tro_ve = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lb_ten_va_sku = new System.Windows.Forms.Label();
            this.btn_them = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_sua = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_xoa = new Guna.UI.WinForms.GunaAdvenceButton();
            this.danh_sach_san_pham_main = new Guna.UI.WinForms.GunaPanel();
            this.gridview_danh_sach_chi_tiet_san_pham = new Guna.UI.WinForms.GunaDataGridView();
            this.han_su_dung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong_ton_kho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            gunaPanel1.SuspendLayout();
            this.danh_sach_san_pham_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_danh_sach_chi_tiet_san_pham)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            gunaPanel1.Controls.Add(this.btn_tro_ve);
            gunaPanel1.Controls.Add(this.lb_ten_va_sku);
            gunaPanel1.Controls.Add(this.btn_them);
            gunaPanel1.Controls.Add(this.btn_sua);
            gunaPanel1.Controls.Add(this.btn_xoa);
            gunaPanel1.Location = new System.Drawing.Point(0, 0);
            gunaPanel1.Name = "gunaPanel1";
            gunaPanel1.Size = new System.Drawing.Size(1730, 150);
            gunaPanel1.TabIndex = 9;
            // 
            // btn_tro_ve
            // 
            this.btn_tro_ve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_tro_ve.AnimationHoverSpeed = 0.07F;
            this.btn_tro_ve.AnimationSpeed = 0.03F;
            this.btn_tro_ve.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.btn_tro_ve.BorderColor = System.Drawing.Color.Black;
            this.btn_tro_ve.CheckedBaseColor = System.Drawing.Color.Black;
            this.btn_tro_ve.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_tro_ve.CheckedForeColor = System.Drawing.Color.White;
            this.btn_tro_ve.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_tro_ve.CheckedImage")));
            this.btn_tro_ve.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btn_tro_ve.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tro_ve.ForeColor = System.Drawing.Color.White;
            this.btn_tro_ve.Image = global::grocery_store.Properties.Resources.cancel;
            this.btn_tro_ve.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_tro_ve.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_tro_ve.Location = new System.Drawing.Point(81, 50);
            this.btn_tro_ve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tro_ve.Name = "btn_tro_ve";
            this.btn_tro_ve.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.btn_tro_ve.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_tro_ve.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_tro_ve.OnHoverImage = null;
            this.btn_tro_ve.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_tro_ve.OnPressedColor = System.Drawing.Color.Black;
            this.btn_tro_ve.Radius = 10;
            this.btn_tro_ve.Size = new System.Drawing.Size(166, 50);
            this.btn_tro_ve.TabIndex = 13;
            this.btn_tro_ve.Text = "Trở về";
            // 
            // lb_ten_va_sku
            // 
            this.lb_ten_va_sku.AutoSize = true;
            this.lb_ten_va_sku.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten_va_sku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.lb_ten_va_sku.Location = new System.Drawing.Point(495, 59);
            this.lb_ten_va_sku.Name = "lb_ten_va_sku";
            this.lb_ten_va_sku.Size = new System.Drawing.Size(104, 31);
            this.lb_ten_va_sku.TabIndex = 12;
            this.lb_ten_va_sku.Text = "Product";
            // 
            // btn_them
            // 
            this.btn_them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_them.AnimationHoverSpeed = 0.07F;
            this.btn_them.AnimationSpeed = 0.03F;
            this.btn_them.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.btn_them.BorderColor = System.Drawing.Color.Black;
            this.btn_them.CheckedBaseColor = System.Drawing.Color.Black;
            this.btn_them.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_them.CheckedForeColor = System.Drawing.Color.White;
            this.btn_them.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_them.CheckedImage")));
            this.btn_them.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Image = global::grocery_store.Properties.Resources.add;
            this.btn_them.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_them.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_them.Location = new System.Drawing.Point(1297, 50);
            this.btn_them.Name = "btn_them";
            this.btn_them.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(117)))), ((int)(((byte)(53)))));
            this.btn_them.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_them.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_them.OnHoverImage = null;
            this.btn_them.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_them.OnPressedColor = System.Drawing.Color.Black;
            this.btn_them.Radius = 10;
            this.btn_them.Size = new System.Drawing.Size(135, 50);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sua.AnimationHoverSpeed = 0.07F;
            this.btn_sua.AnimationSpeed = 0.03F;
            this.btn_sua.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_sua.BorderColor = System.Drawing.Color.Black;
            this.btn_sua.CheckedBaseColor = System.Drawing.Color.Black;
            this.btn_sua.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_sua.CheckedForeColor = System.Drawing.Color.White;
            this.btn_sua.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_sua.CheckedImage")));
            this.btn_sua.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Image = global::grocery_store.Properties.Resources.edit;
            this.btn_sua.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_sua.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_sua.Location = new System.Drawing.Point(1438, 50);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(128)))), ((int)(((byte)(4)))));
            this.btn_sua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_sua.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_sua.OnHoverImage = null;
            this.btn_sua.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_sua.OnPressedColor = System.Drawing.Color.Black;
            this.btn_sua.Radius = 10;
            this.btn_sua.Size = new System.Drawing.Size(120, 50);
            this.btn_sua.TabIndex = 7;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xoa.AnimationHoverSpeed = 0.07F;
            this.btn_xoa.AnimationSpeed = 0.03F;
            this.btn_xoa.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.btn_xoa.BorderColor = System.Drawing.Color.Black;
            this.btn_xoa.CheckedBaseColor = System.Drawing.Color.Black;
            this.btn_xoa.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_xoa.CheckedForeColor = System.Drawing.Color.White;
            this.btn_xoa.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_xoa.CheckedImage")));
            this.btn_xoa.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Image = global::grocery_store.Properties.Resources.delete;
            this.btn_xoa.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_xoa.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_xoa.Location = new System.Drawing.Point(1564, 50);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.btn_xoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_xoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_xoa.OnHoverImage = null;
            this.btn_xoa.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_xoa.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.btn_xoa.Radius = 10;
            this.btn_xoa.Size = new System.Drawing.Size(120, 50);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // danh_sach_san_pham_main
            // 
            this.danh_sach_san_pham_main.Controls.Add(this.gridview_danh_sach_chi_tiet_san_pham);
            this.danh_sach_san_pham_main.Location = new System.Drawing.Point(0, 150);
            this.danh_sach_san_pham_main.Name = "danh_sach_san_pham_main";
            this.danh_sach_san_pham_main.Size = new System.Drawing.Size(1730, 750);
            this.danh_sach_san_pham_main.TabIndex = 11;
            // 
            // gridview_danh_sach_chi_tiet_san_pham
            // 
            this.gridview_danh_sach_chi_tiet_san_pham.AllowUserToAddRows = false;
            this.gridview_danh_sach_chi_tiet_san_pham.AllowUserToDeleteRows = false;
            this.gridview_danh_sach_chi_tiet_san_pham.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_chi_tiet_san_pham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview_danh_sach_chi_tiet_san_pham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridview_danh_sach_chi_tiet_san_pham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview_danh_sach_chi_tiet_san_pham.BackgroundColor = System.Drawing.Color.White;
            this.gridview_danh_sach_chi_tiet_san_pham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview_danh_sach_chi_tiet_san_pham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_danh_sach_chi_tiet_san_pham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_danh_sach_chi_tiet_san_pham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridview_danh_sach_chi_tiet_san_pham.ColumnHeadersHeight = 50;
            this.gridview_danh_sach_chi_tiet_san_pham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.han_su_dung,
            this.so_luong_ton_kho});
            this.gridview_danh_sach_chi_tiet_san_pham.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_danh_sach_chi_tiet_san_pham.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridview_danh_sach_chi_tiet_san_pham.EnableHeadersVisualStyles = false;
            this.gridview_danh_sach_chi_tiet_san_pham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_danh_sach_chi_tiet_san_pham.Location = new System.Drawing.Point(395, 0);
            this.gridview_danh_sach_chi_tiet_san_pham.MultiSelect = false;
            this.gridview_danh_sach_chi_tiet_san_pham.Name = "gridview_danh_sach_chi_tiet_san_pham";
            this.gridview_danh_sach_chi_tiet_san_pham.ReadOnly = true;
            this.gridview_danh_sach_chi_tiet_san_pham.RowHeadersVisible = false;
            this.gridview_danh_sach_chi_tiet_san_pham.RowHeadersWidth = 51;
            this.gridview_danh_sach_chi_tiet_san_pham.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_danh_sach_chi_tiet_san_pham.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridview_danh_sach_chi_tiet_san_pham.RowTemplate.Height = 50;
            this.gridview_danh_sach_chi_tiet_san_pham.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridview_danh_sach_chi_tiet_san_pham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_danh_sach_chi_tiet_san_pham.Size = new System.Drawing.Size(940, 700);
            this.gridview_danh_sach_chi_tiet_san_pham.TabIndex = 10;
            this.gridview_danh_sach_chi_tiet_san_pham.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.HeaderStyle.Height = 50;
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.ReadOnly = true;
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.RowsStyle.Height = 50;
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_danh_sach_chi_tiet_san_pham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridview_danh_sach_chi_tiet_san_pham.VirtualMode = true;
            this.gridview_danh_sach_chi_tiet_san_pham.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_danh_sach_chi_tiet_san_pham_RowEnter);
            // 
            // han_su_dung
            // 
            this.han_su_dung.DataPropertyName = "Expiry";
            this.han_su_dung.HeaderText = "Hạn Sử Dụng";
            this.han_su_dung.MinimumWidth = 6;
            this.han_su_dung.Name = "han_su_dung";
            this.han_su_dung.ReadOnly = true;
            // 
            // so_luong_ton_kho
            // 
            this.so_luong_ton_kho.DataPropertyName = "QuantityInStock";
            this.so_luong_ton_kho.HeaderText = "Tồn Kho";
            this.so_luong_ton_kho.MinimumWidth = 6;
            this.so_luong_ton_kho.Name = "so_luong_ton_kho";
            this.so_luong_ton_kho.ReadOnly = true;
            // 
            // DanhSachChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.danh_sach_san_pham_main);
            this.Controls.Add(gunaPanel1);
            this.Name = "DanhSachChiTietSanPham";
            this.Size = new System.Drawing.Size(1730, 1050);
            this.Load += new System.EventHandler(this.DanhSachChiTietSanPham_Load);
            gunaPanel1.ResumeLayout(false);
            gunaPanel1.PerformLayout();
            this.danh_sach_san_pham_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_danh_sach_chi_tiet_san_pham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btn_them;
        private Guna.UI.WinForms.GunaAdvenceButton btn_sua;
        private Guna.UI.WinForms.GunaAdvenceButton btn_xoa;
        private Guna.UI.WinForms.GunaPanel danh_sach_san_pham_main;
        private Guna.UI.WinForms.GunaDataGridView gridview_danh_sach_chi_tiet_san_pham;
        private System.Windows.Forms.Label lb_ten_va_sku;
        private System.Windows.Forms.DataGridViewTextBoxColumn han_su_dung;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong_ton_kho;
        private Guna.UI.WinForms.GunaAdvenceButton btn_tro_ve;
    }
}
