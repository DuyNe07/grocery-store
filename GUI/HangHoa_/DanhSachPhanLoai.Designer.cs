namespace grocery_store.GUI.HangHoa_
{
    partial class DanhSachPhanLoai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachPhanLoai));
            this.danh_sach_san_pham_main = new Guna.UI.WinForms.GunaPanel();
            this.gridview_danh_sach_loai = new Guna.UI.WinForms.GunaDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phan_loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong_san_pham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doanh_thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loi_nhuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_tim_kiem = new Guna.UI.WinForms.GunaButton();
            this.txtbox_tim_kiem = new Guna.UI.WinForms.GunaTextBox();
            this.danh_sach_san_pham_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_danh_sach_loai)).BeginInit();
            this.SuspendLayout();
            // 
            // danh_sach_san_pham_main
            // 
            this.danh_sach_san_pham_main.Controls.Add(this.gridview_danh_sach_loai);
            this.danh_sach_san_pham_main.Location = new System.Drawing.Point(0, 150);
            this.danh_sach_san_pham_main.Name = "danh_sach_san_pham_main";
            this.danh_sach_san_pham_main.Size = new System.Drawing.Size(1730, 750);
            this.danh_sach_san_pham_main.TabIndex = 2;
            // 
            // gridview_danh_sach_loai
            // 
            this.gridview_danh_sach_loai.AllowUserToAddRows = false;
            this.gridview_danh_sach_loai.AllowUserToDeleteRows = false;
            this.gridview_danh_sach_loai.AllowUserToResizeColumns = false;
            this.gridview_danh_sach_loai.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_loai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridview_danh_sach_loai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridview_danh_sach_loai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview_danh_sach_loai.BackgroundColor = System.Drawing.Color.White;
            this.gridview_danh_sach_loai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview_danh_sach_loai.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_danh_sach_loai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_danh_sach_loai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridview_danh_sach_loai.ColumnHeadersHeight = 50;
            this.gridview_danh_sach_loai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.phan_loai,
            this.so_luong_san_pham,
            this.doanh_thu,
            this.loi_nhuan});
            this.gridview_danh_sach_loai.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_danh_sach_loai.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridview_danh_sach_loai.EnableHeadersVisualStyles = false;
            this.gridview_danh_sach_loai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.gridview_danh_sach_loai.Location = new System.Drawing.Point(45, 0);
            this.gridview_danh_sach_loai.MultiSelect = false;
            this.gridview_danh_sach_loai.Name = "gridview_danh_sach_loai";
            this.gridview_danh_sach_loai.ReadOnly = true;
            this.gridview_danh_sach_loai.RowHeadersVisible = false;
            this.gridview_danh_sach_loai.RowHeadersWidth = 51;
            this.gridview_danh_sach_loai.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_danh_sach_loai.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridview_danh_sach_loai.RowTemplate.Height = 50;
            this.gridview_danh_sach_loai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_danh_sach_loai.Size = new System.Drawing.Size(1640, 750);
            this.gridview_danh_sach_loai.TabIndex = 4;
            this.gridview_danh_sach_loai.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gridview_danh_sach_loai.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_loai.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridview_danh_sach_loai.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridview_danh_sach_loai.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridview_danh_sach_loai.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridview_danh_sach_loai.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_loai.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.gridview_danh_sach_loai.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridview_danh_sach_loai.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridview_danh_sach_loai.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridview_danh_sach_loai.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridview_danh_sach_loai.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridview_danh_sach_loai.ThemeStyle.HeaderStyle.Height = 50;
            this.gridview_danh_sach_loai.ThemeStyle.ReadOnly = true;
            this.gridview_danh_sach_loai.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_danh_sach_loai.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_danh_sach_loai.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridview_danh_sach_loai.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridview_danh_sach_loai.ThemeStyle.RowsStyle.Height = 50;
            this.gridview_danh_sach_loai.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_danh_sach_loai.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // phan_loai
            // 
            this.phan_loai.DataPropertyName = "phan_loai";
            this.phan_loai.HeaderText = "Phân Loại";
            this.phan_loai.MinimumWidth = 6;
            this.phan_loai.Name = "phan_loai";
            this.phan_loai.ReadOnly = true;
            // 
            // so_luong_san_pham
            // 
            this.so_luong_san_pham.HeaderText = "Số Sản Phẩm";
            this.so_luong_san_pham.MinimumWidth = 6;
            this.so_luong_san_pham.Name = "so_luong_san_pham";
            this.so_luong_san_pham.ReadOnly = true;
            // 
            // doanh_thu
            // 
            this.doanh_thu.HeaderText = "Doanh Thu";
            this.doanh_thu.MinimumWidth = 6;
            this.doanh_thu.Name = "doanh_thu";
            this.doanh_thu.ReadOnly = true;
            // 
            // loi_nhuan
            // 
            this.loi_nhuan.HeaderText = "Lợi Nhuận";
            this.loi_nhuan.MinimumWidth = 6;
            this.loi_nhuan.Name = "loi_nhuan";
            this.loi_nhuan.ReadOnly = true;
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
            this.btn_tim_kiem.TabIndex = 5;
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
            this.txtbox_tim_kiem.TabIndex = 6;
            this.txtbox_tim_kiem.Text = "Tìm Kiếm";
            this.txtbox_tim_kiem.TextOffsetX = 15;
            this.txtbox_tim_kiem.Enter += new System.EventHandler(this.txtbox_tim_kiem_Enter);
            this.txtbox_tim_kiem.Leave += new System.EventHandler(this.txtbox_tim_kiem_Leave);
            // 
            // DanhSachPhanLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.btn_tim_kiem);
            this.Controls.Add(this.txtbox_tim_kiem);
            this.Controls.Add(this.danh_sach_san_pham_main);
            this.Name = "DanhSachPhanLoai";
            this.Size = new System.Drawing.Size(1730, 950);
            this.danh_sach_san_pham_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_danh_sach_loai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel danh_sach_san_pham_main;
        private Guna.UI.WinForms.GunaDataGridView gridview_danh_sach_loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn phan_loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong_san_pham;
        private System.Windows.Forms.DataGridViewTextBoxColumn doanh_thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn loi_nhuan;
        private Guna.UI.WinForms.GunaButton btn_tim_kiem;
        private Guna.UI.WinForms.GunaTextBox txtbox_tim_kiem;
    }
}
