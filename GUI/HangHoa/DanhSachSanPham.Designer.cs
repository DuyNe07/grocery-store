﻿namespace grocery_store.GUI.HangHoa
{
    partial class DanhSachSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachSanPham));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_tong_so_dong = new System.Windows.Forms.Label();
            this.txtbox_tim_kiem = new Guna.UI.WinForms.GunaTextBox();
            this.btn_tim_kiem = new Guna.UI.WinForms.GunaButton();
            this.cbb_phan_loai = new System.Windows.Forms.ComboBox();
            this.cbb_nha_cung_cap = new System.Windows.Forms.ComboBox();
            this.btn_them = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_sua = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_xoa = new Guna.UI.WinForms.GunaAdvenceButton();
            this.danh_sach_san_pham_main = new Guna.UI.WinForms.GunaPanel();
            this.gridview_danh_sach_san_pham = new Guna.UI.WinForms.GunaDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_san_pham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phan_loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nha_cung_cap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong_ton_kho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia_nhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_muc_ton = new System.Windows.Forms.NumericUpDown();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            gunaPanel1.SuspendLayout();
            this.danh_sach_san_pham_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_danh_sach_san_pham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_muc_ton)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            gunaPanel1.Controls.Add(this.tb_muc_ton);
            gunaPanel1.Controls.Add(this.gunaLabel5);
            gunaPanel1.Controls.Add(this.lb_tong_so_dong);
            gunaPanel1.Controls.Add(this.txtbox_tim_kiem);
            gunaPanel1.Controls.Add(this.btn_tim_kiem);
            gunaPanel1.Controls.Add(this.cbb_phan_loai);
            gunaPanel1.Controls.Add(this.cbb_nha_cung_cap);
            gunaPanel1.Controls.Add(this.btn_them);
            gunaPanel1.Controls.Add(this.btn_sua);
            gunaPanel1.Controls.Add(this.btn_xoa);
            gunaPanel1.Location = new System.Drawing.Point(0, 0);
            gunaPanel1.Name = "gunaPanel1";
            gunaPanel1.Size = new System.Drawing.Size(1730, 150);
            gunaPanel1.TabIndex = 8;
            // 
            // lb_tong_so_dong
            // 
            this.lb_tong_so_dong.AutoSize = true;
            this.lb_tong_so_dong.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tong_so_dong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.lb_tong_so_dong.Location = new System.Drawing.Point(44, 102);
            this.lb_tong_so_dong.Name = "lb_tong_so_dong";
            this.lb_tong_so_dong.Size = new System.Drawing.Size(76, 23);
            this.lb_tong_so_dong.TabIndex = 13;
            this.lb_tong_so_dong.Text = "Kết quả:";
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
            this.txtbox_tim_kiem.Location = new System.Drawing.Point(117, 42);
            this.txtbox_tim_kiem.Name = "txtbox_tim_kiem";
            this.txtbox_tim_kiem.PasswordChar = '\0';
            this.txtbox_tim_kiem.Size = new System.Drawing.Size(450, 50);
            this.txtbox_tim_kiem.TabIndex = 16;
            this.txtbox_tim_kiem.TextOffsetX = 15;
            // 
            // btn_tim_kiem
            // 
            this.btn_tim_kiem.AnimationHoverSpeed = 0.07F;
            this.btn_tim_kiem.AnimationSpeed = 0.03F;
            this.btn_tim_kiem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tim_kiem.BorderColor = System.Drawing.Color.White;
            this.btn_tim_kiem.BorderSize = 3;
            this.btn_tim_kiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_tim_kiem.ForeColor = System.Drawing.Color.White;
            this.btn_tim_kiem.Image = global::grocery_store.Properties.Resources.Search;
            this.btn_tim_kiem.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_tim_kiem.Location = new System.Drawing.Point(47, 42);
            this.btn_tim_kiem.Name = "btn_tim_kiem";
            this.btn_tim_kiem.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btn_tim_kiem.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_tim_kiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_tim_kiem.OnHoverImage = null;
            this.btn_tim_kiem.OnPressedColor = System.Drawing.Color.Black;
            this.btn_tim_kiem.Size = new System.Drawing.Size(70, 50);
            this.btn_tim_kiem.TabIndex = 15;
            this.btn_tim_kiem.Click += new System.EventHandler(this.btn_tim_kiem_Click);
            // 
            // cbb_phan_loai
            // 
            this.cbb_phan_loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_phan_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_phan_loai.FormattingEnabled = true;
            this.cbb_phan_loai.ItemHeight = 22;
            this.cbb_phan_loai.Location = new System.Drawing.Point(821, 62);
            this.cbb_phan_loai.Name = "cbb_phan_loai";
            this.cbb_phan_loai.Size = new System.Drawing.Size(180, 30);
            this.cbb_phan_loai.TabIndex = 12;
            this.cbb_phan_loai.SelectedIndexChanged += new System.EventHandler(this.cbb_phan_loai_SelectedIndexChanged);
            // 
            // cbb_nha_cung_cap
            // 
            this.cbb_nha_cung_cap.BackColor = System.Drawing.Color.White;
            this.cbb_nha_cung_cap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_nha_cung_cap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_nha_cung_cap.ForeColor = System.Drawing.Color.Black;
            this.cbb_nha_cung_cap.FormattingEnabled = true;
            this.cbb_nha_cung_cap.Location = new System.Drawing.Point(600, 62);
            this.cbb_nha_cung_cap.Name = "cbb_nha_cung_cap";
            this.cbb_nha_cung_cap.Size = new System.Drawing.Size(180, 30);
            this.cbb_nha_cung_cap.TabIndex = 11;
            this.cbb_nha_cung_cap.SelectedIndexChanged += new System.EventHandler(this.cbb_nha_cung_cap_SelectedIndexChanged);
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
            this.btn_them.Location = new System.Drawing.Point(1299, 50);
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
            this.btn_sua.Location = new System.Drawing.Point(1440, 50);
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
            this.btn_xoa.Location = new System.Drawing.Point(1566, 50);
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
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_ClickAsync);
            // 
            // danh_sach_san_pham_main
            // 
            this.danh_sach_san_pham_main.Controls.Add(this.gridview_danh_sach_san_pham);
            this.danh_sach_san_pham_main.Location = new System.Drawing.Point(0, 150);
            this.danh_sach_san_pham_main.Name = "danh_sach_san_pham_main";
            this.danh_sach_san_pham_main.Size = new System.Drawing.Size(1730, 750);
            this.danh_sach_san_pham_main.TabIndex = 10;
            // 
            // gridview_danh_sach_san_pham
            // 
            this.gridview_danh_sach_san_pham.AllowUserToAddRows = false;
            this.gridview_danh_sach_san_pham.AllowUserToDeleteRows = false;
            this.gridview_danh_sach_san_pham.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_san_pham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridview_danh_sach_san_pham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridview_danh_sach_san_pham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview_danh_sach_san_pham.BackgroundColor = System.Drawing.Color.White;
            this.gridview_danh_sach_san_pham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview_danh_sach_san_pham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_danh_sach_san_pham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_danh_sach_san_pham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridview_danh_sach_san_pham.ColumnHeadersHeight = 50;
            this.gridview_danh_sach_san_pham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.sku,
            this.ten_san_pham,
            this.phan_loai,
            this.nha_cung_cap,
            this.so_luong_ton_kho,
            this.gia_nhap,
            this.gia_ban});
            this.gridview_danh_sach_san_pham.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_danh_sach_san_pham.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridview_danh_sach_san_pham.EnableHeadersVisualStyles = false;
            this.gridview_danh_sach_san_pham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_danh_sach_san_pham.Location = new System.Drawing.Point(45, 0);
            this.gridview_danh_sach_san_pham.MultiSelect = false;
            this.gridview_danh_sach_san_pham.Name = "gridview_danh_sach_san_pham";
            this.gridview_danh_sach_san_pham.ReadOnly = true;
            this.gridview_danh_sach_san_pham.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridview_danh_sach_san_pham.RowHeadersVisible = false;
            this.gridview_danh_sach_san_pham.RowHeadersWidth = 51;
            this.gridview_danh_sach_san_pham.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_danh_sach_san_pham.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridview_danh_sach_san_pham.RowTemplate.Height = 50;
            this.gridview_danh_sach_san_pham.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridview_danh_sach_san_pham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_danh_sach_san_pham.Size = new System.Drawing.Size(1640, 750);
            this.gridview_danh_sach_san_pham.TabIndex = 10;
            this.gridview_danh_sach_san_pham.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gridview_danh_sach_san_pham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_san_pham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridview_danh_sach_san_pham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridview_danh_sach_san_pham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridview_danh_sach_san_pham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridview_danh_sach_san_pham.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_san_pham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_danh_sach_san_pham.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridview_danh_sach_san_pham.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridview_danh_sach_san_pham.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridview_danh_sach_san_pham.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridview_danh_sach_san_pham.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridview_danh_sach_san_pham.ThemeStyle.HeaderStyle.Height = 50;
            this.gridview_danh_sach_san_pham.ThemeStyle.ReadOnly = true;
            this.gridview_danh_sach_san_pham.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_san_pham.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_danh_sach_san_pham.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridview_danh_sach_san_pham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridview_danh_sach_san_pham.ThemeStyle.RowsStyle.Height = 50;
            this.gridview_danh_sach_san_pham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_danh_sach_san_pham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridview_danh_sach_san_pham.VirtualMode = true;
            this.gridview_danh_sach_san_pham.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_danh_sach_san_pham_RowEnter);
            this.gridview_danh_sach_san_pham.DoubleClick += new System.EventHandler(this.gridview_danh_sach_san_pham_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "ProductId";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // sku
            // 
            this.sku.DataPropertyName = "SKU";
            this.sku.HeaderText = "SKU";
            this.sku.MinimumWidth = 6;
            this.sku.Name = "sku";
            this.sku.ReadOnly = true;
            // 
            // ten_san_pham
            // 
            this.ten_san_pham.DataPropertyName = "Name";
            this.ten_san_pham.HeaderText = "Tên Sản Phẩm";
            this.ten_san_pham.MinimumWidth = 6;
            this.ten_san_pham.Name = "ten_san_pham";
            this.ten_san_pham.ReadOnly = true;
            // 
            // phan_loai
            // 
            this.phan_loai.DataPropertyName = "Category";
            this.phan_loai.HeaderText = "Phân Loại";
            this.phan_loai.MinimumWidth = 6;
            this.phan_loai.Name = "phan_loai";
            this.phan_loai.ReadOnly = true;
            // 
            // nha_cung_cap
            // 
            this.nha_cung_cap.DataPropertyName = "Supplier";
            this.nha_cung_cap.HeaderText = "Nhà Cung Cấp";
            this.nha_cung_cap.MinimumWidth = 6;
            this.nha_cung_cap.Name = "nha_cung_cap";
            this.nha_cung_cap.ReadOnly = true;
            // 
            // so_luong_ton_kho
            // 
            this.so_luong_ton_kho.DataPropertyName = "QuantityInStock";
            this.so_luong_ton_kho.HeaderText = "Tồn Kho";
            this.so_luong_ton_kho.MinimumWidth = 6;
            this.so_luong_ton_kho.Name = "so_luong_ton_kho";
            this.so_luong_ton_kho.ReadOnly = true;
            // 
            // gia_nhap
            // 
            this.gia_nhap.DataPropertyName = "CostPrice";
            this.gia_nhap.HeaderText = "Giá Nhập";
            this.gia_nhap.MinimumWidth = 6;
            this.gia_nhap.Name = "gia_nhap";
            this.gia_nhap.ReadOnly = true;
            // 
            // gia_ban
            // 
            this.gia_ban.DataPropertyName = "MarketPrice";
            this.gia_ban.HeaderText = "Giá Bán";
            this.gia_ban.MinimumWidth = 6;
            this.gia_ban.Name = "gia_ban";
            this.gia_ban.ReadOnly = true;
            // 
            // tb_muc_ton
            // 
            this.tb_muc_ton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_muc_ton.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_muc_ton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_muc_ton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_muc_ton.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tb_muc_ton.Location = new System.Drawing.Point(1163, 62);
            this.tb_muc_ton.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.tb_muc_ton.Name = "tb_muc_ton";
            this.tb_muc_ton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_muc_ton.Size = new System.Drawing.Size(87, 30);
            this.tb_muc_ton.TabIndex = 24;
            this.tb_muc_ton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_muc_ton.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.tb_muc_ton.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tb_muc_ton.ValueChanged += new System.EventHandler(this.tb_muc_ton_ValueChanged);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(1060, 64);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(93, 28);
            this.gunaLabel5.TabIndex = 23;
            this.gunaLabel5.Text = "Mức tồn:";
            // 
            // DanhSachSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.Controls.Add(gunaPanel1);
            this.Controls.Add(this.danh_sach_san_pham_main);
            this.Name = "DanhSachSanPham";
            this.Size = new System.Drawing.Size(1730, 1050);
            this.Load += new System.EventHandler(this.DanhSachSanPham_Load);
            gunaPanel1.ResumeLayout(false);
            gunaPanel1.PerformLayout();
            this.danh_sach_san_pham_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_danh_sach_san_pham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_muc_ton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_tong_so_dong;
        private System.Windows.Forms.ComboBox cbb_phan_loai;
        private System.Windows.Forms.ComboBox cbb_nha_cung_cap;
        private Guna.UI.WinForms.GunaAdvenceButton btn_them;
        private Guna.UI.WinForms.GunaAdvenceButton btn_sua;
        private Guna.UI.WinForms.GunaAdvenceButton btn_xoa;
        private Guna.UI.WinForms.GunaTextBox txtbox_tim_kiem;
        private Guna.UI.WinForms.GunaButton btn_tim_kiem;
        private Guna.UI.WinForms.GunaPanel danh_sach_san_pham_main;
        private Guna.UI.WinForms.GunaDataGridView gridview_danh_sach_san_pham;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sku;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_san_pham;
        private System.Windows.Forms.DataGridViewTextBoxColumn phan_loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn nha_cung_cap;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong_ton_kho;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_nhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_ban;
        private System.Windows.Forms.NumericUpDown tb_muc_ton;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
    }
}
