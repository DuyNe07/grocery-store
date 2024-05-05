namespace grocery_store.GUI.Dashboard
{
    partial class HoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.input_search = new Guna.UI.WinForms.GunaTextBox();
            this.btn_search = new Guna.UI.WinForms.GunaButton();
            this.btn_show = new Guna.UI.WinForms.GunaButton();
            this.gridview_invoice = new Guna.UI.WinForms.GunaDataGridView();
            this.ShopOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // input_search
            // 
            this.input_search.BaseColor = System.Drawing.Color.White;
            this.input_search.BorderColor = System.Drawing.Color.Silver;
            this.input_search.BorderSize = 0;
            this.input_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_search.FocusedBaseColor = System.Drawing.Color.White;
            this.input_search.FocusedBorderColor = System.Drawing.Color.White;
            this.input_search.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.input_search.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_search.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.input_search.Location = new System.Drawing.Point(110, 61);
            this.input_search.Name = "input_search";
            this.input_search.PasswordChar = '\0';
            this.input_search.Size = new System.Drawing.Size(350, 50);
            this.input_search.TabIndex = 23;
            this.input_search.TextOffsetX = 15;
            // 
            // btn_search
            // 
            this.btn_search.AnimationHoverSpeed = 0.07F;
            this.btn_search.AnimationSpeed = 0.03F;
            this.btn_search.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_search.BorderColor = System.Drawing.Color.White;
            this.btn_search.BorderSize = 3;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Image = global::grocery_store.Properties.Resources.Search;
            this.btn_search.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_search.Location = new System.Drawing.Point(40, 61);
            this.btn_search.Name = "btn_search";
            this.btn_search.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btn_search.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_search.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_search.OnHoverImage = null;
            this.btn_search.OnPressedColor = System.Drawing.Color.Black;
            this.btn_search.Size = new System.Drawing.Size(70, 50);
            this.btn_search.TabIndex = 22;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_show
            // 
            this.btn_show.AnimationHoverSpeed = 0.07F;
            this.btn_show.AnimationSpeed = 0.03F;
            this.btn_show.BackColor = System.Drawing.Color.Transparent;
            this.btn_show.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_show.BorderColor = System.Drawing.Color.Black;
            this.btn_show.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btn_show.ForeColor = System.Drawing.Color.Black;
            this.btn_show.Image = null;
            this.btn_show.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_show.Location = new System.Drawing.Point(1391, 61);
            this.btn_show.Name = "btn_show";
            this.btn_show.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(121)))), ((int)(((byte)(111)))));
            this.btn_show.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_show.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_show.OnHoverImage = null;
            this.btn_show.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(129)))));
            this.btn_show.Radius = 15;
            this.btn_show.Size = new System.Drawing.Size(208, 60);
            this.btn_show.TabIndex = 24;
            this.btn_show.Text = "Xem";
            this.btn_show.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // gridview_invoice
            // 
            this.gridview_invoice.AllowUserToAddRows = false;
            this.gridview_invoice.AllowUserToDeleteRows = false;
            this.gridview_invoice.AllowUserToResizeColumns = false;
            this.gridview_invoice.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridview_invoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview_invoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview_invoice.BackgroundColor = System.Drawing.Color.White;
            this.gridview_invoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridview_invoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_invoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_invoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridview_invoice.ColumnHeadersHeight = 60;
            this.gridview_invoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShopOrderId,
            this.OrderDate,
            this.PaymentMethod,
            this.NameEmp,
            this.SumTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_invoice.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridview_invoice.EnableHeadersVisualStyles = false;
            this.gridview_invoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_invoice.Location = new System.Drawing.Point(40, 163);
            this.gridview_invoice.Name = "gridview_invoice";
            this.gridview_invoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridview_invoice.RowHeadersVisible = false;
            this.gridview_invoice.RowHeadersWidth = 50;
            this.gridview_invoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridview_invoice.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridview_invoice.RowTemplate.Height = 50;
            this.gridview_invoice.RowTemplate.ReadOnly = true;
            this.gridview_invoice.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_invoice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridview_invoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_invoice.Size = new System.Drawing.Size(1615, 827);
            this.gridview_invoice.TabIndex = 21;
            this.gridview_invoice.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gridview_invoice.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_invoice.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridview_invoice.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridview_invoice.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridview_invoice.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridview_invoice.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridview_invoice.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_invoice.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridview_invoice.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridview_invoice.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridview_invoice.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridview_invoice.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridview_invoice.ThemeStyle.HeaderStyle.Height = 60;
            this.gridview_invoice.ThemeStyle.ReadOnly = false;
            this.gridview_invoice.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview_invoice.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview_invoice.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridview_invoice.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridview_invoice.ThemeStyle.RowsStyle.Height = 50;
            this.gridview_invoice.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview_invoice.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridview_invoice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_invoice_CellDoubleClick);
            this.gridview_invoice.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_invoice_RowEnter);
            // 
            // ShopOrderId
            // 
            this.ShopOrderId.DataPropertyName = "ShopOrderId";
            this.ShopOrderId.HeaderText = "Shop Order ID";
            this.ShopOrderId.MinimumWidth = 6;
            this.ShopOrderId.Name = "ShopOrderId";
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "Ngày đặt đơn";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.DataPropertyName = "PaymentMethod";
            this.PaymentMethod.HeaderText = "Phương thức thanh toán";
            this.PaymentMethod.MinimumWidth = 6;
            this.PaymentMethod.Name = "PaymentMethod";
            // 
            // NameEmp
            // 
            this.NameEmp.DataPropertyName = "NameEmp";
            this.NameEmp.HeaderText = "Nhân viên";
            this.NameEmp.MinimumWidth = 6;
            this.NameEmp.Name = "NameEmp";
            // 
            // SumTotal
            // 
            this.SumTotal.DataPropertyName = "SubTotal";
            this.SumTotal.HeaderText = "Tổng hoá đơn";
            this.SumTotal.MinimumWidth = 6;
            this.SumTotal.Name = "SumTotal";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.input_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.gridview_invoice);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HoaDon";
            this.Size = new System.Drawing.Size(1720, 1050);
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_invoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox input_search;
        private Guna.UI.WinForms.GunaButton btn_search;
        private Guna.UI.WinForms.GunaButton btn_show;
        private Guna.UI.WinForms.GunaDataGridView gridview_invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShopOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumTotal;
    }
}
