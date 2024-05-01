namespace grocery_store.GUI.HangHoa
{
    partial class DanhSachNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachNhaCungCap));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btn_them = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_sua = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_xoa = new Guna.UI.WinForms.GunaAdvenceButton();
            this.danh_sach_san_pham_main = new Guna.UI.WinForms.GunaPanel();
            this.gridview_danh_sach_nha_cung_cap = new Guna.UI.WinForms.GunaDataGridView();
            this.lb_so_luong_nha_cung_cap = new System.Windows.Forms.Label();
            this.so_luong_phan_loai = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nha_cung_cap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_dien_thoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong_san_pham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPanel1.SuspendLayout();
            this.danh_sach_san_pham_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_danh_sach_nha_cung_cap)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.so_luong_phan_loai);
            this.gunaPanel1.Controls.Add(this.lb_so_luong_nha_cung_cap);
            this.gunaPanel1.Controls.Add(this.btn_them);
            this.gunaPanel1.Controls.Add(this.btn_sua);
            this.gunaPanel1.Controls.Add(this.btn_xoa);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1730, 150);
            this.gunaPanel1.TabIndex = 10;
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
            this.btn_them.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
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
            this.btn_sua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
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
            this.btn_xoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_xoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_xoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_xoa.OnHoverImage = null;
            this.btn_xoa.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_xoa.OnPressedColor = System.Drawing.Color.Black;
            this.btn_xoa.Radius = 10;
            this.btn_xoa.Size = new System.Drawing.Size(120, 50);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // danh_sach_san_pham_main
            // 
            this.danh_sach_san_pham_main.Controls.Add(this.gridview_danh_sach_nha_cung_cap);
            this.danh_sach_san_pham_main.Location = new System.Drawing.Point(0, 150);
            this.danh_sach_san_pham_main.Name = "danh_sach_san_pham_main";
            this.danh_sach_san_pham_main.Size = new System.Drawing.Size(1730, 750);
            this.danh_sach_san_pham_main.TabIndex = 9;
            // 
            // gridview_danh_sach_nha_cung_cap
            // 
            this.gridview_danh_sach_nha_cung_cap.AllowUserToAddRows = false;
            this.gridview_danh_sach_nha_cung_cap.AllowUserToDeleteRows = false;
            this.gridview_danh_sach_nha_cung_cap.AllowUserToResizeColumns = false;
            this.gridview_danh_sach_nha_cung_cap.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_nha_cung_cap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview_danh_sach_nha_cung_cap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridview_danh_sach_nha_cung_cap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview_danh_sach_nha_cung_cap.BackgroundColor = System.Drawing.Color.White;
            this.gridview_danh_sach_nha_cung_cap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview_danh_sach_nha_cung_cap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_danh_sach_nha_cung_cap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_danh_sach_nha_cung_cap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridview_danh_sach_nha_cung_cap.ColumnHeadersHeight = 50;
            this.gridview_danh_sach_nha_cung_cap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nha_cung_cap,
            this.email,
            this.so_dien_thoai,
            this.so_luong_san_pham});
            this.gridview_danh_sach_nha_cung_cap.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_danh_sach_nha_cung_cap.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridview_danh_sach_nha_cung_cap.EnableHeadersVisualStyles = false;
            this.gridview_danh_sach_nha_cung_cap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.gridview_danh_sach_nha_cung_cap.Location = new System.Drawing.Point(45, 0);
            this.gridview_danh_sach_nha_cung_cap.MultiSelect = false;
            this.gridview_danh_sach_nha_cung_cap.Name = "gridview_danh_sach_nha_cung_cap";
            this.gridview_danh_sach_nha_cung_cap.ReadOnly = true;
            this.gridview_danh_sach_nha_cung_cap.RowHeadersVisible = false;
            this.gridview_danh_sach_nha_cung_cap.RowHeadersWidth = 51;
            this.gridview_danh_sach_nha_cung_cap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_danh_sach_nha_cung_cap.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridview_danh_sach_nha_cung_cap.RowTemplate.Height = 50;
            this.gridview_danh_sach_nha_cung_cap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_danh_sach_nha_cung_cap.Size = new System.Drawing.Size(1640, 750);
            this.gridview_danh_sach_nha_cung_cap.TabIndex = 4;
            this.gridview_danh_sach_nha_cung_cap.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.HeaderStyle.Height = 50;
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.ReadOnly = true;
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.RowsStyle.Height = 50;
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_danh_sach_nha_cung_cap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridview_danh_sach_nha_cung_cap.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_danh_sach_nha_cung_cap_RowEnter);
            // 
            // lb_so_luong_nha_cung_cap
            // 
            this.lb_so_luong_nha_cung_cap.AutoSize = true;
            this.lb_so_luong_nha_cung_cap.BackColor = System.Drawing.Color.Transparent;
            this.lb_so_luong_nha_cung_cap.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_so_luong_nha_cung_cap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.lb_so_luong_nha_cung_cap.Location = new System.Drawing.Point(319, 50);
            this.lb_so_luong_nha_cung_cap.Name = "lb_so_luong_nha_cung_cap";
            this.lb_so_luong_nha_cung_cap.Size = new System.Drawing.Size(40, 31);
            this.lb_so_luong_nha_cung_cap.TabIndex = 12;
            this.lb_so_luong_nha_cung_cap.Text = "11";
            // 
            // so_luong_phan_loai
            // 
            this.so_luong_phan_loai.AutoSize = true;
            this.so_luong_phan_loai.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.so_luong_phan_loai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.so_luong_phan_loai.Location = new System.Drawing.Point(39, 50);
            this.so_luong_phan_loai.Name = "so_luong_phan_loai";
            this.so_luong_phan_loai.Size = new System.Drawing.Size(274, 31);
            this.so_luong_phan_loai.TabIndex = 11;
            this.so_luong_phan_loai.Text = "Số Lượng Nhà Cung Cấp:";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "SupplierID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // nha_cung_cap
            // 
            this.nha_cung_cap.DataPropertyName = "SupplierName";
            this.nha_cung_cap.HeaderText = "Nhà Cung Cấp";
            this.nha_cung_cap.MinimumWidth = 6;
            this.nha_cung_cap.Name = "nha_cung_cap";
            this.nha_cung_cap.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // so_dien_thoai
            // 
            this.so_dien_thoai.DataPropertyName = "PhoneNumber";
            this.so_dien_thoai.HeaderText = "Số Điện Thoại";
            this.so_dien_thoai.MinimumWidth = 6;
            this.so_dien_thoai.Name = "so_dien_thoai";
            this.so_dien_thoai.ReadOnly = true;
            // 
            // so_luong_san_pham
            // 
            this.so_luong_san_pham.DataPropertyName = "NumOfProducts";
            this.so_luong_san_pham.HeaderText = "Số Sản Phẩm";
            this.so_luong_san_pham.MinimumWidth = 6;
            this.so_luong_san_pham.Name = "so_luong_san_pham";
            this.so_luong_san_pham.ReadOnly = true;
            // 
            // DanhSachNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.danh_sach_san_pham_main);
            this.Name = "DanhSachNhaCungCap";
            this.Size = new System.Drawing.Size(1730, 950);
            this.Load += new System.EventHandler(this.DanhSachNhaCungCap_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.danh_sach_san_pham_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_danh_sach_nha_cung_cap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_them;
        private Guna.UI.WinForms.GunaAdvenceButton btn_sua;
        private Guna.UI.WinForms.GunaAdvenceButton btn_xoa;
        private Guna.UI.WinForms.GunaPanel danh_sach_san_pham_main;
        private Guna.UI.WinForms.GunaDataGridView gridview_danh_sach_nha_cung_cap;
        private System.Windows.Forms.Label lb_so_luong_nha_cung_cap;
        private System.Windows.Forms.Label so_luong_phan_loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nha_cung_cap;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_dien_thoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong_san_pham;
    }
}
