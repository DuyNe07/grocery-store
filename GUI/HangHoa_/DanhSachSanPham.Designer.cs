namespace grocery_store.GUI.HangHoa_
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachSanPham));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.danh_sach_san_pham_main = new Guna.UI.WinForms.GunaPanel();
            this.gridview_danh_sach_san_pham = new Guna.UI.WinForms.GunaDataGridView();
            this.btn_tim_kiem = new Guna.UI.WinForms.GunaButton();
            this.txtbox_tim_kiem = new Guna.UI.WinForms.GunaTextBox();
            this.btn_xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gia_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia_nhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nha_cung_cap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phan_loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_san_pham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danh_sach_san_pham_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_danh_sach_san_pham)).BeginInit();
            this.SuspendLayout();
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
            this.so_luong,
            this.gia_nhap,
            this.gia_ban,
            this.btn_sua,
            this.btn_xoa});
            this.gridview_danh_sach_san_pham.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_danh_sach_san_pham.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridview_danh_sach_san_pham.EnableHeadersVisualStyles = false;
            this.gridview_danh_sach_san_pham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.gridview_danh_sach_san_pham.Location = new System.Drawing.Point(45, 0);
            this.gridview_danh_sach_san_pham.MultiSelect = false;
            this.gridview_danh_sach_san_pham.Name = "gridview_danh_sach_san_pham";
            this.gridview_danh_sach_san_pham.ReadOnly = true;
            this.gridview_danh_sach_san_pham.RowHeadersVisible = false;
            this.gridview_danh_sach_san_pham.RowHeadersWidth = 51;
            this.gridview_danh_sach_san_pham.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_danh_sach_san_pham.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridview_danh_sach_san_pham.RowTemplate.Height = 50;
            this.gridview_danh_sach_san_pham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_danh_sach_san_pham.Size = new System.Drawing.Size(1640, 750);
            this.gridview_danh_sach_san_pham.TabIndex = 4;
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
            // btn_tim_kiem
            // 
            this.btn_tim_kiem.AnimationHoverSpeed = 0.07F;
            this.btn_tim_kiem.AnimationSpeed = 0.03F;
            this.btn_tim_kiem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tim_kiem.BorderColor = System.Drawing.Color.White;
            this.btn_tim_kiem.BorderSize = 3;
            this.btn_tim_kiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_tim_kiem.ForeColor = System.Drawing.Color.White;
            this.btn_tim_kiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_tim_kiem.Image")));
            this.btn_tim_kiem.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_tim_kiem.Location = new System.Drawing.Point(50, 40);
            this.btn_tim_kiem.Name = "btn_tim_kiem";
            this.btn_tim_kiem.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btn_tim_kiem.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_tim_kiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_tim_kiem.OnHoverImage = null;
            this.btn_tim_kiem.OnPressedColor = System.Drawing.Color.Black;
            this.btn_tim_kiem.Size = new System.Drawing.Size(90, 70);
            this.btn_tim_kiem.TabIndex = 3;
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
            this.txtbox_tim_kiem.Location = new System.Drawing.Point(140, 40);
            this.txtbox_tim_kiem.Name = "txtbox_tim_kiem";
            this.txtbox_tim_kiem.PasswordChar = '\0';
            this.txtbox_tim_kiem.Size = new System.Drawing.Size(450, 70);
            this.txtbox_tim_kiem.TabIndex = 4;
            this.txtbox_tim_kiem.Text = "Tìm Kiếm";
            this.txtbox_tim_kiem.TextOffsetX = 15;
            this.txtbox_tim_kiem.Enter += new System.EventHandler(this.txtbox_tim_kiem_Enter);
            this.txtbox_tim_kiem.Leave += new System.EventHandler(this.txtbox_tim_kiem_Leave);
            // 
            // btn_xoa
            // 
            this.btn_xoa.HeaderText = "";
            this.btn_xoa.MinimumWidth = 6;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ReadOnly = true;
            // 
            // btn_sua
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.btn_sua.DefaultCellStyle = dataGridViewCellStyle3;
            this.btn_sua.HeaderText = "";
            this.btn_sua.MinimumWidth = 6;
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.ReadOnly = true;
            this.btn_sua.UseColumnTextForButtonValue = true;
            // 
            // gia_ban
            // 
            this.gia_ban.DataPropertyName = "gia_ban";
            this.gia_ban.HeaderText = "Giá Bán";
            this.gia_ban.MinimumWidth = 6;
            this.gia_ban.Name = "gia_ban";
            this.gia_ban.ReadOnly = true;
            // 
            // gia_nhap
            // 
            this.gia_nhap.DataPropertyName = "gia_nhap";
            this.gia_nhap.HeaderText = "Giá Nhập";
            this.gia_nhap.MinimumWidth = 6;
            this.gia_nhap.Name = "gia_nhap";
            this.gia_nhap.ReadOnly = true;
            // 
            // so_luong
            // 
            this.so_luong.DataPropertyName = "so_luong";
            this.so_luong.HeaderText = "Số Lượng";
            this.so_luong.MinimumWidth = 6;
            this.so_luong.Name = "so_luong";
            this.so_luong.ReadOnly = true;
            // 
            // nha_cung_cap
            // 
            this.nha_cung_cap.DataPropertyName = "nha_cung_cap";
            this.nha_cung_cap.HeaderText = "Nhà Cung Cấp";
            this.nha_cung_cap.MinimumWidth = 6;
            this.nha_cung_cap.Name = "nha_cung_cap";
            this.nha_cung_cap.ReadOnly = true;
            // 
            // phan_loai
            // 
            this.phan_loai.DataPropertyName = "phan_loai";
            this.phan_loai.HeaderText = "Phân Loại";
            this.phan_loai.MinimumWidth = 6;
            this.phan_loai.Name = "phan_loai";
            this.phan_loai.ReadOnly = true;
            // 
            // ten_san_pham
            // 
            this.ten_san_pham.DataPropertyName = "ten_san_pham";
            this.ten_san_pham.HeaderText = "Tên Sản Phẩm";
            this.ten_san_pham.MinimumWidth = 6;
            this.ten_san_pham.Name = "ten_san_pham";
            this.ten_san_pham.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // DanhSachSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.btn_tim_kiem);
            this.Controls.Add(this.txtbox_tim_kiem);
            this.Controls.Add(this.danh_sach_san_pham_main);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DanhSachSanPham";
            this.Size = new System.Drawing.Size(1730, 950);
            this.Load += new System.EventHandler(this.DanhSachSanPham_Load);
            this.danh_sach_san_pham_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_danh_sach_san_pham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel danh_sach_san_pham_main;
        private Guna.UI.WinForms.GunaDataGridView gridview_danh_sach_san_pham;
        private Guna.UI.WinForms.GunaButton btn_tim_kiem;
        private Guna.UI.WinForms.GunaTextBox txtbox_tim_kiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_san_pham;
        private System.Windows.Forms.DataGridViewTextBoxColumn phan_loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn nha_cung_cap;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_nhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_ban;
        private System.Windows.Forms.DataGridViewButtonColumn btn_sua;
        private System.Windows.Forms.DataGridViewButtonColumn btn_xoa;
    }
}
