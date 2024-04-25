namespace grocery_store.GUI.HangHoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbb_phan_loai = new Guna.UI.WinForms.GunaComboBox();
            this.cbb_nha_san_xuat = new Guna.UI.WinForms.GunaComboBox();
            this.btn_them = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_sua = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_xoa = new Guna.UI.WinForms.GunaAdvenceButton();
            this.danh_sach_san_pham_main = new Guna.UI.WinForms.GunaPanel();
            this.gridview_danh_sach_san_pham = new Guna.UI.WinForms.GunaDataGridView();
            this.txtbox_tim_kiem = new Guna.UI.WinForms.GunaTextBox();
            this.btn_tim_kiem = new Guna.UI.WinForms.GunaButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_san_pham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phan_loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nha_cung_cap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong_ton_kho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia_nhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            gunaPanel1.SuspendLayout();
            this.danh_sach_san_pham_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_danh_sach_san_pham)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            gunaPanel1.Controls.Add(this.cbb_phan_loai);
            gunaPanel1.Controls.Add(this.cbb_nha_san_xuat);
            gunaPanel1.Controls.Add(this.btn_them);
            gunaPanel1.Controls.Add(this.btn_sua);
            gunaPanel1.Controls.Add(this.btn_xoa);
            gunaPanel1.Location = new System.Drawing.Point(0, 0);
            gunaPanel1.Name = "gunaPanel1";
            gunaPanel1.Size = new System.Drawing.Size(1730, 150);
            gunaPanel1.TabIndex = 7;
            // 
            // cbb_phan_loai
            // 
            this.cbb_phan_loai.BackColor = System.Drawing.Color.Transparent;
            this.cbb_phan_loai.BaseColor = System.Drawing.Color.White;
            this.cbb_phan_loai.BorderColor = System.Drawing.Color.Silver;
            this.cbb_phan_loai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_phan_loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_phan_loai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_phan_loai.ForeColor = System.Drawing.Color.Black;
            this.cbb_phan_loai.FormattingEnabled = true;
            this.cbb_phan_loai.Items.AddRange(new object[] {
            "Phân Loại (All)",
            "COCA",
            "PEPSI"});
            this.cbb_phan_loai.Location = new System.Drawing.Point(920, 60);
            this.cbb_phan_loai.Name = "cbb_phan_loai";
            this.cbb_phan_loai.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbb_phan_loai.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbb_phan_loai.Size = new System.Drawing.Size(270, 33);
            this.cbb_phan_loai.TabIndex = 10;
            // 
            // cbb_nha_san_xuat
            // 
            this.cbb_nha_san_xuat.BackColor = System.Drawing.Color.Transparent;
            this.cbb_nha_san_xuat.BaseColor = System.Drawing.Color.White;
            this.cbb_nha_san_xuat.BorderColor = System.Drawing.Color.Silver;
            this.cbb_nha_san_xuat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_nha_san_xuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_nha_san_xuat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_nha_san_xuat.ForeColor = System.Drawing.Color.Black;
            this.cbb_nha_san_xuat.FormattingEnabled = true;
            this.cbb_nha_san_xuat.Items.AddRange(new object[] {
            "Nhà sản xuất (All)",
            "COCA",
            "PEPSI"});
            this.cbb_nha_san_xuat.Location = new System.Drawing.Point(620, 60);
            this.cbb_nha_san_xuat.Name = "cbb_nha_san_xuat";
            this.cbb_nha_san_xuat.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbb_nha_san_xuat.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbb_nha_san_xuat.Size = new System.Drawing.Size(270, 33);
            this.cbb_nha_san_xuat.TabIndex = 9;
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
            this.btn_xoa.OnPressedColor = System.Drawing.Color.Black;
            this.btn_xoa.Radius = 10;
            this.btn_xoa.Size = new System.Drawing.Size(120, 50);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xóa";
            // 
            // danh_sach_san_pham_main
            // 
            this.danh_sach_san_pham_main.Controls.Add(this.gridview_danh_sach_san_pham);
            this.danh_sach_san_pham_main.Location = new System.Drawing.Point(0, 150);
            this.danh_sach_san_pham_main.Name = "danh_sach_san_pham_main";
            this.danh_sach_san_pham_main.Size = new System.Drawing.Size(1730, 750);
            this.danh_sach_san_pham_main.TabIndex = 1;
            // 
            // gridview_danh_sach_san_pham
            // 
            this.gridview_danh_sach_san_pham.AllowUserToAddRows = false;
            this.gridview_danh_sach_san_pham.AllowUserToDeleteRows = false;
            this.gridview_danh_sach_san_pham.AllowUserToResizeColumns = false;
            this.gridview_danh_sach_san_pham.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_san_pham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview_danh_sach_san_pham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridview_danh_sach_san_pham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview_danh_sach_san_pham.BackgroundColor = System.Drawing.Color.White;
            this.gridview_danh_sach_san_pham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview_danh_sach_san_pham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_danh_sach_san_pham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_danh_sach_san_pham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridview_danh_sach_san_pham.ColumnHeadersHeight = 50;
            this.gridview_danh_sach_san_pham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten_san_pham,
            this.phan_loai,
            this.nha_cung_cap,
            this.so_luong_ton_kho,
            this.gia_nhap,
            this.gia_ban});
            this.gridview_danh_sach_san_pham.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_danh_sach_san_pham.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridview_danh_sach_san_pham.EnableHeadersVisualStyles = false;
            this.gridview_danh_sach_san_pham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.gridview_danh_sach_san_pham.Location = new System.Drawing.Point(45, 0);
            this.gridview_danh_sach_san_pham.MultiSelect = false;
            this.gridview_danh_sach_san_pham.Name = "gridview_danh_sach_san_pham";
            this.gridview_danh_sach_san_pham.ReadOnly = true;
            this.gridview_danh_sach_san_pham.RowHeadersVisible = false;
            this.gridview_danh_sach_san_pham.RowHeadersWidth = 51;
            this.gridview_danh_sach_san_pham.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_danh_sach_san_pham.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridview_danh_sach_san_pham.RowTemplate.Height = 50;
            this.gridview_danh_sach_san_pham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_danh_sach_san_pham.Size = new System.Drawing.Size(1640, 750);
            this.gridview_danh_sach_san_pham.TabIndex = 0;
            this.gridview_danh_sach_san_pham.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gridview_danh_sach_san_pham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_san_pham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridview_danh_sach_san_pham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridview_danh_sach_san_pham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridview_danh_sach_san_pham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridview_danh_sach_san_pham.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_san_pham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
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
            this.gridview_danh_sach_san_pham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridview_danh_sach_san_pham.ThemeStyle.RowsStyle.Height = 50;
            this.gridview_danh_sach_san_pham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_danh_sach_san_pham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.txtbox_tim_kiem.Location = new System.Drawing.Point(120, 50);
            this.txtbox_tim_kiem.Name = "txtbox_tim_kiem";
            this.txtbox_tim_kiem.PasswordChar = '\0';
            this.txtbox_tim_kiem.Size = new System.Drawing.Size(450, 50);
            this.txtbox_tim_kiem.TabIndex = 4;
            this.txtbox_tim_kiem.Text = "Tìm Kiếm";
            this.txtbox_tim_kiem.TextOffsetX = 15;
            this.txtbox_tim_kiem.Enter += new System.EventHandler(this.txtbox_tim_kiem_Enter);
            this.txtbox_tim_kiem.Leave += new System.EventHandler(this.txtbox_tim_kiem_Leave);
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
            this.btn_tim_kiem.Location = new System.Drawing.Point(50, 50);
            this.btn_tim_kiem.Name = "btn_tim_kiem";
            this.btn_tim_kiem.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btn_tim_kiem.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_tim_kiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_tim_kiem.OnHoverImage = null;
            this.btn_tim_kiem.OnPressedColor = System.Drawing.Color.Black;
            this.btn_tim_kiem.Size = new System.Drawing.Size(70, 50);
            this.btn_tim_kiem.TabIndex = 3;
            // 
            // id
            // 
            this.id.DataPropertyName = "ProductId";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
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
            // DanhSachSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.btn_tim_kiem);
            this.Controls.Add(this.txtbox_tim_kiem);
            this.Controls.Add(this.danh_sach_san_pham_main);
            this.Controls.Add(gunaPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DanhSachSanPham";
            this.Size = new System.Drawing.Size(1730, 950);
            this.Load += new System.EventHandler(this.DanhSachSanPham_Load);
            gunaPanel1.ResumeLayout(false);
            this.danh_sach_san_pham_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_danh_sach_san_pham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel danh_sach_san_pham_main;
        private Guna.UI.WinForms.GunaAdvenceButton btn_xoa;
        private Guna.UI.WinForms.GunaAdvenceButton btn_them;
        private Guna.UI.WinForms.GunaAdvenceButton btn_sua;
        private Guna.UI.WinForms.GunaComboBox cbb_nha_san_xuat;
        private Guna.UI.WinForms.GunaComboBox cbb_phan_loai;
        private Guna.UI.WinForms.GunaTextBox txtbox_tim_kiem;
        private Guna.UI.WinForms.GunaButton btn_tim_kiem;
        private Guna.UI.WinForms.GunaDataGridView gridview_danh_sach_san_pham;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_san_pham;
        private System.Windows.Forms.DataGridViewTextBoxColumn phan_loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn nha_cung_cap;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong_ton_kho;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_nhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_ban;
    }
}
