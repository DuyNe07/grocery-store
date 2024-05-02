namespace grocery_store.GUI.HangHoa
{
    partial class ChiTietSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietSanPham));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.input_han_su_dung = new System.Windows.Forms.DateTimePicker();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.lb_inventory_error = new System.Windows.Forms.Label();
            this.lb_maket_price_error = new System.Windows.Forms.Label();
            this.lb_cost_price_error = new System.Windows.Forms.Label();
            this.lb_supplier_error = new System.Windows.Forms.Label();
            this.lb_category_error = new System.Windows.Forms.Label();
            this.lb_name_error = new System.Windows.Forms.Label();
            this.input_ton_kho = new System.Windows.Forms.NumericUpDown();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btn_luu = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_huy = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lb_name_control = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_ton_kho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.gunaPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1731, 950);
            this.panel1.TabIndex = 8;
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
            this.gunaPanel1.Controls.Add(this.input_ton_kho);
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.btn_luu);
            this.gunaPanel1.Controls.Add(this.btn_huy);
            this.gunaPanel1.Controls.Add(this.lb_name_control);
            this.gunaPanel1.Location = new System.Drawing.Point(565, 125);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(600, 370);
            this.gunaPanel1.TabIndex = 7;
            // 
            // input_han_su_dung
            // 
            this.input_han_su_dung.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.input_han_su_dung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_han_su_dung.Location = new System.Drawing.Point(283, 119);
            this.input_han_su_dung.MinDate = new System.DateTime(2024, 5, 1, 0, 0, 0, 0);
            this.input_han_su_dung.Name = "input_han_su_dung";
            this.input_han_su_dung.Size = new System.Drawing.Size(233, 34);
            this.input_han_su_dung.TabIndex = 0;
            this.input_han_su_dung.Value = new System.DateTime(2024, 5, 1, 9, 51, 12, 0);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(80, 119);
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
            // input_ton_kho
            // 
            this.input_ton_kho.BackColor = System.Drawing.Color.WhiteSmoke;
            this.input_ton_kho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_ton_kho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.input_ton_kho.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.input_ton_kho.Location = new System.Drawing.Point(283, 191);
            this.input_ton_kho.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.input_ton_kho.Name = "input_ton_kho";
            this.input_ton_kho.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.input_ton_kho.Size = new System.Drawing.Size(233, 30);
            this.input_ton_kho.TabIndex = 19;
            this.input_ton_kho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_ton_kho.ThousandsSeparator = true;
            this.input_ton_kho.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(80, 190);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(92, 28);
            this.gunaLabel4.TabIndex = 12;
            this.gunaLabel4.Text = "Tồn Kho:";
            // 
            // btn_luu
            // 
            this.btn_luu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.btn_luu.Location = new System.Drawing.Point(435, 283);
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
            // btn_huy
            // 
            this.btn_huy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.btn_huy.Location = new System.Drawing.Point(260, 283);
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
            // lb_name_control
            // 
            this.lb_name_control.AutoSize = true;
            this.lb_name_control.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.lb_name_control.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.lb_name_control.Location = new System.Drawing.Point(253, 25);
            this.lb_name_control.Name = "lb_name_control";
            this.lb_name_control.Size = new System.Drawing.Size(108, 41);
            this.lb_name_control.TabIndex = 7;
            this.lb_name_control.Text = "THÊM";
            // 
            // ChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "ChiTietSanPham";
            this.Size = new System.Drawing.Size(1731, 950);
            this.Load += new System.EventHandler(this.ChiTietSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_ton_kho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.DateTimePicker input_han_su_dung;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private System.Windows.Forms.Label lb_inventory_error;
        private System.Windows.Forms.Label lb_maket_price_error;
        private System.Windows.Forms.Label lb_cost_price_error;
        private System.Windows.Forms.Label lb_supplier_error;
        private System.Windows.Forms.Label lb_category_error;
        private System.Windows.Forms.Label lb_name_error;
        private System.Windows.Forms.NumericUpDown input_ton_kho;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaAdvenceButton btn_luu;
        private Guna.UI.WinForms.GunaAdvenceButton btn_huy;
        public Guna.UI.WinForms.GunaLabel lb_name_control;
    }
}
