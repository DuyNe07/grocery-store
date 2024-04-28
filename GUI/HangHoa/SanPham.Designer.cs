namespace grocery_store.GUI.HangHoa
{
    partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_ten_san_pham = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lb_name_control = new Guna.UI.WinForms.GunaLabel();
            this.btn_huy = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_luu = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.input_han_su_dung = new System.Windows.Forms.MaskedTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.lb_inventory_error = new System.Windows.Forms.Label();
            this.lb_maket_price_error = new System.Windows.Forms.Label();
            this.lb_cost_price_error = new System.Windows.Forms.Label();
            this.lb_supplier_error = new System.Windows.Forms.Label();
            this.lb_category_error = new System.Windows.Forms.Label();
            this.lb_name_error = new System.Windows.Forms.Label();
            this.cbb_nha_cung_cap = new System.Windows.Forms.ComboBox();
            this.cbb_phan_loai = new System.Windows.Forms.ComboBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.input_gia_nhap = new System.Windows.Forms.NumericUpDown();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.input_gia_ban = new System.Windows.Forms.NumericUpDown();
            this.input_ton_kho = new System.Windows.Forms.NumericUpDown();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_gia_nhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_gia_ban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_ton_kho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1731, 950);
            this.panel1.TabIndex = 7;
            // 
            // tb_ten_san_pham
            // 
            this.tb_ten_san_pham.BackColor = System.Drawing.Color.GhostWhite;
            this.tb_ten_san_pham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ten_san_pham.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_ten_san_pham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ten_san_pham.LineColor = System.Drawing.Color.Gainsboro;
            this.tb_ten_san_pham.LineSize = 2;
            this.tb_ten_san_pham.Location = new System.Drawing.Point(244, 106);
            this.tb_ten_san_pham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ten_san_pham.Name = "tb_ten_san_pham";
            this.tb_ten_san_pham.PasswordChar = '\0';
            this.tb_ten_san_pham.Size = new System.Drawing.Size(311, 37);
            this.tb_ten_san_pham.TabIndex = 0;
            this.tb_ten_san_pham.Validating += new System.ComponentModel.CancelEventHandler(this.tb_ten_san_pham_Validating);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(43, 115);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(146, 28);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Tên Sản Phẩm:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(43, 180);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(107, 28);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Phân Loại:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(43, 244);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(148, 28);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Nhà Cung Cấp:";
            // 
            // lb_name_control
            // 
            this.lb_name_control.AutoSize = true;
            this.lb_name_control.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.lb_name_control.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.lb_name_control.Location = new System.Drawing.Point(177, 28);
            this.lb_name_control.Name = "lb_name_control";
            this.lb_name_control.Size = new System.Drawing.Size(285, 41);
            this.lb_name_control.TabIndex = 7;
            this.lb_name_control.Text = "THÊM SẢN PHẨM";
            // 
            // btn_huy
            // 
            this.btn_huy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_huy.AnimationHoverSpeed = 0.07F;
            this.btn_huy.AnimationSpeed = 0.03F;
            this.btn_huy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.btn_huy.BorderColor = System.Drawing.Color.Black;
            this.btn_huy.CheckedBaseColor = System.Drawing.Color.Black;
            this.btn_huy.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_huy.CheckedForeColor = System.Drawing.Color.White;
            this.btn_huy.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_huy.CheckedImage")));
            this.btn_huy.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Image = global::grocery_store.Properties.Resources.cancel;
            this.btn_huy.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_huy.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_huy.Location = new System.Drawing.Point(260, 613);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.btn_huy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_huy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_huy.OnHoverImage = null;
            this.btn_huy.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_huy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_huy.Radius = 10;
            this.btn_huy.Size = new System.Drawing.Size(120, 50);
            this.btn_huy.TabIndex = 10;
            this.btn_huy.Text = "Hủy";
            // 
            // btn_luu
            // 
            this.btn_luu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_luu.AnimationHoverSpeed = 0.07F;
            this.btn_luu.AnimationSpeed = 0.03F;
            this.btn_luu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.btn_luu.BorderColor = System.Drawing.Color.Black;
            this.btn_luu.CheckedBaseColor = System.Drawing.Color.Black;
            this.btn_luu.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_luu.CheckedForeColor = System.Drawing.Color.White;
            this.btn_luu.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_luu.CheckedImage")));
            this.btn_luu.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Image = global::grocery_store.Properties.Resources.save;
            this.btn_luu.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_luu.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_luu.Location = new System.Drawing.Point(435, 613);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(117)))), ((int)(((byte)(53)))));
            this.btn_luu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_luu.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_luu.OnHoverImage = null;
            this.btn_luu.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_luu.OnPressedColor = System.Drawing.Color.Black;
            this.btn_luu.Radius = 10;
            this.btn_luu.Size = new System.Drawing.Size(120, 50);
            this.btn_luu.TabIndex = 9;
            this.btn_luu.Text = "Lưu";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.input_han_su_dung);
            this.gunaPanel1.Controls.Add(this.gunaLabel9);
            this.gunaPanel1.Controls.Add(this.lb_inventory_error);
            this.gunaPanel1.Controls.Add(this.lb_maket_price_error);
            this.gunaPanel1.Controls.Add(this.lb_cost_price_error);
            this.gunaPanel1.Controls.Add(this.lb_supplier_error);
            this.gunaPanel1.Controls.Add(this.lb_category_error);
            this.gunaPanel1.Controls.Add(this.lb_name_error);
            this.gunaPanel1.Controls.Add(this.cbb_nha_cung_cap);
            this.gunaPanel1.Controls.Add(this.cbb_phan_loai);
            this.gunaPanel1.Controls.Add(this.gunaLabel8);
            this.gunaPanel1.Controls.Add(this.input_gia_nhap);
            this.gunaPanel1.Controls.Add(this.gunaLabel7);
            this.gunaPanel1.Controls.Add(this.input_gia_ban);
            this.gunaPanel1.Controls.Add(this.input_ton_kho);
            this.gunaPanel1.Controls.Add(this.gunaLabel6);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.btn_luu);
            this.gunaPanel1.Controls.Add(this.btn_huy);
            this.gunaPanel1.Controls.Add(this.lb_name_control);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.tb_ten_san_pham);
            this.gunaPanel1.Location = new System.Drawing.Point(563, 50);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(600, 700);
            this.gunaPanel1.TabIndex = 6;
            // 
            // input_han_su_dung
            // 
            this.input_han_su_dung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.input_han_su_dung.Location = new System.Drawing.Point(244, 527);
            this.input_han_su_dung.Mask = "00/00/0000";
            this.input_han_su_dung.Name = "input_han_su_dung";
            this.input_han_su_dung.Size = new System.Drawing.Size(181, 34);
            this.input_han_su_dung.TabIndex = 35;
            this.input_han_su_dung.ValidatingType = typeof(System.DateTime);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(43, 527);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(137, 28);
            this.gunaLabel9.TabIndex = 34;
            this.gunaLabel9.Text = "Hạn Sử Dụng:";
            // 
            // lb_inventory_error
            // 
            this.lb_inventory_error.AutoSize = true;
            this.lb_inventory_error.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inventory_error.ForeColor = System.Drawing.Color.Red;
            this.lb_inventory_error.Location = new System.Drawing.Point(240, 340);
            this.lb_inventory_error.Name = "lb_inventory_error";
            this.lb_inventory_error.Size = new System.Drawing.Size(0, 20);
            this.lb_inventory_error.TabIndex = 31;
            this.lb_inventory_error.Validating += new System.ComponentModel.CancelEventHandler(this.lb_inventory_error_Validating);
            // 
            // lb_maket_price_error
            // 
            this.lb_maket_price_error.AutoSize = true;
            this.lb_maket_price_error.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maket_price_error.ForeColor = System.Drawing.Color.Red;
            this.lb_maket_price_error.Location = new System.Drawing.Point(240, 486);
            this.lb_maket_price_error.Name = "lb_maket_price_error";
            this.lb_maket_price_error.Size = new System.Drawing.Size(0, 20);
            this.lb_maket_price_error.TabIndex = 30;
            // 
            // lb_cost_price_error
            // 
            this.lb_cost_price_error.AutoSize = true;
            this.lb_cost_price_error.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cost_price_error.ForeColor = System.Drawing.Color.Red;
            this.lb_cost_price_error.Location = new System.Drawing.Point(240, 412);
            this.lb_cost_price_error.Name = "lb_cost_price_error";
            this.lb_cost_price_error.Size = new System.Drawing.Size(0, 20);
            this.lb_cost_price_error.TabIndex = 29;
            // 
            // lb_supplier_error
            // 
            this.lb_supplier_error.AutoSize = true;
            this.lb_supplier_error.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supplier_error.ForeColor = System.Drawing.Color.Red;
            this.lb_supplier_error.Location = new System.Drawing.Point(240, 280);
            this.lb_supplier_error.Name = "lb_supplier_error";
            this.lb_supplier_error.Size = new System.Drawing.Size(0, 20);
            this.lb_supplier_error.TabIndex = 27;
            // 
            // lb_category_error
            // 
            this.lb_category_error.AutoSize = true;
            this.lb_category_error.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_category_error.ForeColor = System.Drawing.Color.Red;
            this.lb_category_error.Location = new System.Drawing.Point(240, 211);
            this.lb_category_error.Name = "lb_category_error";
            this.lb_category_error.Size = new System.Drawing.Size(0, 20);
            this.lb_category_error.TabIndex = 26;
            // 
            // lb_name_error
            // 
            this.lb_name_error.AutoSize = true;
            this.lb_name_error.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name_error.ForeColor = System.Drawing.Color.Red;
            this.lb_name_error.Location = new System.Drawing.Point(240, 145);
            this.lb_name_error.Name = "lb_name_error";
            this.lb_name_error.Size = new System.Drawing.Size(0, 20);
            this.lb_name_error.TabIndex = 25;
            // 
            // cbb_nha_cung_cap
            // 
            this.cbb_nha_cung_cap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbb_nha_cung_cap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbb_nha_cung_cap.FormattingEnabled = true;
            this.cbb_nha_cung_cap.Location = new System.Drawing.Point(244, 241);
            this.cbb_nha_cung_cap.Name = "cbb_nha_cung_cap";
            this.cbb_nha_cung_cap.Size = new System.Drawing.Size(311, 36);
            this.cbb_nha_cung_cap.TabIndex = 24;
            this.cbb_nha_cung_cap.Validating += new System.ComponentModel.CancelEventHandler(this.cbb_nha_cung_cap_Validating);
            // 
            // cbb_phan_loai
            // 
            this.cbb_phan_loai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbb_phan_loai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbb_phan_loai.ItemHeight = 28;
            this.cbb_phan_loai.Location = new System.Drawing.Point(244, 172);
            this.cbb_phan_loai.Name = "cbb_phan_loai";
            this.cbb_phan_loai.Size = new System.Drawing.Size(311, 36);
            this.cbb_phan_loai.TabIndex = 0;
            this.cbb_phan_loai.Validating += new System.ComponentModel.CancelEventHandler(this.cbb_phan_loai_Validating);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(431, 383);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(46, 23);
            this.gunaLabel8.TabIndex = 23;
            this.gunaLabel8.Text = "VNĐ";
            // 
            // input_gia_nhap
            // 
            this.input_gia_nhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.input_gia_nhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_gia_nhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.input_gia_nhap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.input_gia_nhap.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.input_gia_nhap.Location = new System.Drawing.Point(244, 379);
            this.input_gia_nhap.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.input_gia_nhap.Name = "input_gia_nhap";
            this.input_gia_nhap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.input_gia_nhap.Size = new System.Drawing.Size(181, 30);
            this.input_gia_nhap.TabIndex = 22;
            this.input_gia_nhap.ThousandsSeparator = true;
            this.input_gia_nhap.Validating += new System.ComponentModel.CancelEventHandler(this.input_gia_nhap_Validating);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(431, 457);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(46, 23);
            this.gunaLabel7.TabIndex = 21;
            this.gunaLabel7.Text = "VNĐ";
            // 
            // input_gia_ban
            // 
            this.input_gia_ban.BackColor = System.Drawing.Color.WhiteSmoke;
            this.input_gia_ban.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_gia_ban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.input_gia_ban.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.input_gia_ban.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.input_gia_ban.Location = new System.Drawing.Point(244, 453);
            this.input_gia_ban.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.input_gia_ban.Name = "input_gia_ban";
            this.input_gia_ban.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.input_gia_ban.Size = new System.Drawing.Size(181, 30);
            this.input_gia_ban.TabIndex = 20;
            this.input_gia_ban.ThousandsSeparator = true;
            this.input_gia_ban.Validating += new System.ComponentModel.CancelEventHandler(this.input_gia_ban_Validating);
            // 
            // input_ton_kho
            // 
            this.input_ton_kho.BackColor = System.Drawing.Color.WhiteSmoke;
            this.input_ton_kho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_ton_kho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.input_ton_kho.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.input_ton_kho.Location = new System.Drawing.Point(244, 307);
            this.input_ton_kho.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.input_ton_kho.Name = "input_ton_kho";
            this.input_ton_kho.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.input_ton_kho.Size = new System.Drawing.Size(181, 30);
            this.input_ton_kho.TabIndex = 19;
            this.input_ton_kho.ThousandsSeparator = true;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(43, 455);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(88, 28);
            this.gunaLabel6.TabIndex = 16;
            this.gunaLabel6.Text = "Giá Bán:";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(43, 381);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(102, 28);
            this.gunaLabel5.TabIndex = 14;
            this.gunaLabel5.Text = "Giá Nhập:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(43, 313);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(92, 28);
            this.gunaLabel4.TabIndex = 12;
            this.gunaLabel4.Text = "Tồn Kho:";
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SanPham";
            this.Size = new System.Drawing.Size(1732, 953);
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_gia_nhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_gia_ban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_ton_kho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLineTextBox tb_ten_san_pham;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaAdvenceButton btn_huy;
        private Guna.UI.WinForms.GunaAdvenceButton btn_luu;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.NumericUpDown input_ton_kho;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private System.Windows.Forms.NumericUpDown input_gia_nhap;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private System.Windows.Forms.NumericUpDown input_gia_ban;
        public Guna.UI.WinForms.GunaLabel lb_name_control;
        private System.Windows.Forms.ComboBox cbb_nha_cung_cap;
        private System.Windows.Forms.ComboBox cbb_phan_loai;
        private System.Windows.Forms.Label lb_name_error;
        private System.Windows.Forms.Label lb_maket_price_error;
        private System.Windows.Forms.Label lb_cost_price_error;
        private System.Windows.Forms.Label lb_supplier_error;
        private System.Windows.Forms.Label lb_category_error;
        private System.Windows.Forms.Label lb_inventory_error;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private System.Windows.Forms.MaskedTextBox input_han_su_dung;
    }
}
