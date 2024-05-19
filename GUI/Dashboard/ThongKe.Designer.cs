namespace grocery_store.GUI.Dashboard
{
    partial class ThongKe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.panel_profit = new Guna.UI.WinForms.GunaGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_increase_profit = new System.Windows.Forms.Label();
            this.header_profit = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_profit = new System.Windows.Forms.Label();
            this.panel_revenue = new Guna.UI.WinForms.GunaGradientPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label_increase_revenue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_revenue = new System.Windows.Forms.Label();
            this.header_renueve = new System.Windows.Forms.Label();
            this.panel_numOfOrder = new Guna.UI.WinForms.GunaGradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label_increase_numOrder = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_numOfOrder = new System.Windows.Forms.Label();
            this.header_numOrder = new System.Windows.Forms.Label();
            this.ElipseRevenue = new Guna.UI.WinForms.GunaElipse(this.components);
            this.ElipseProfit = new Guna.UI.WinForms.GunaElipse(this.components);
            this.ElipseNum = new Guna.UI.WinForms.GunaElipse(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.input_dateStart = new System.Windows.Forms.DateTimePicker();
            this.input_dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_profit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel_revenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_numOfOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_profit
            // 
            this.panel_profit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_profit.BackgroundImage")));
            this.panel_profit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_profit.Controls.Add(this.label2);
            this.panel_profit.Controls.Add(this.label_increase_profit);
            this.panel_profit.Controls.Add(this.header_profit);
            this.panel_profit.Controls.Add(this.pictureBox4);
            this.panel_profit.Controls.Add(this.label_profit);
            this.panel_profit.GradiantColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.panel_profit.GradiantColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.panel_profit.GradiantColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.panel_profit.GradiantColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.panel_profit.Location = new System.Drawing.Point(505, 52);
            this.panel_profit.Name = "panel_profit";
            this.panel_profit.Size = new System.Drawing.Size(400, 170);
            this.panel_profit.TabIndex = 8;
            this.panel_profit.Text = "gunaGradientPanel1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(200, 121);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "so với tháng trước";
            // 
            // label_increase_profit
            // 
            this.label_increase_profit.AutoSize = true;
            this.label_increase_profit.BackColor = System.Drawing.Color.Transparent;
            this.label_increase_profit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_increase_profit.Location = new System.Drawing.Point(143, 121);
            this.label_increase_profit.Name = "label_increase_profit";
            this.label_increase_profit.Size = new System.Drawing.Size(51, 25);
            this.label_increase_profit.TabIndex = 13;
            this.label_increase_profit.Text = "↗2%";
            // 
            // header_profit
            // 
            this.header_profit.AutoSize = true;
            this.header_profit.BackColor = System.Drawing.Color.Transparent;
            this.header_profit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.header_profit.Location = new System.Drawing.Point(187, 25);
            this.header_profit.Name = "header_profit";
            this.header_profit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.header_profit.Size = new System.Drawing.Size(177, 31);
            this.header_profit.TabIndex = 10;
            this.header_profit.Text = "Tổng lợi nhuận";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Image = global::grocery_store.Properties.Resources.profit;
            this.pictureBox4.Location = new System.Drawing.Point(23, 53);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // label_profit
            // 
            this.label_profit.AutoSize = true;
            this.label_profit.BackColor = System.Drawing.Color.Transparent;
            this.label_profit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_profit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_profit.Location = new System.Drawing.Point(136, 67);
            this.label_profit.Name = "label_profit";
            this.label_profit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_profit.Size = new System.Drawing.Size(229, 41);
            this.label_profit.TabIndex = 11;
            this.label_profit.Text = "10,000,000,000";
            this.label_profit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_revenue
            // 
            this.panel_revenue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_revenue.BackgroundImage")));
            this.panel_revenue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_revenue.Controls.Add(this.label8);
            this.panel_revenue.Controls.Add(this.label_increase_revenue);
            this.panel_revenue.Controls.Add(this.pictureBox1);
            this.panel_revenue.Controls.Add(this.label_revenue);
            this.panel_revenue.Controls.Add(this.header_renueve);
            this.panel_revenue.GradiantColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.panel_revenue.GradiantColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.panel_revenue.GradiantColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.panel_revenue.GradiantColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.panel_revenue.Location = new System.Drawing.Point(59, 52);
            this.panel_revenue.Name = "panel_revenue";
            this.panel_revenue.Size = new System.Drawing.Size(400, 170);
            this.panel_revenue.TabIndex = 9;
            this.panel_revenue.Text = "gunaGradientPanel2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(198, 121);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(163, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "so với tháng trước";
            // 
            // label_increase_revenue
            // 
            this.label_increase_revenue.AutoSize = true;
            this.label_increase_revenue.BackColor = System.Drawing.Color.Transparent;
            this.label_increase_revenue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_increase_revenue.Location = new System.Drawing.Point(141, 121);
            this.label_increase_revenue.Name = "label_increase_revenue";
            this.label_increase_revenue.Size = new System.Drawing.Size(51, 25);
            this.label_increase_revenue.TabIndex = 8;
            this.label_increase_revenue.Text = "↗2%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::grocery_store.Properties.Resources.revenue;
            this.pictureBox1.Location = new System.Drawing.Point(25, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label_revenue
            // 
            this.label_revenue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_revenue.AutoSize = true;
            this.label_revenue.BackColor = System.Drawing.Color.Transparent;
            this.label_revenue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_revenue.Location = new System.Drawing.Point(134, 67);
            this.label_revenue.Name = "label_revenue";
            this.label_revenue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_revenue.Size = new System.Drawing.Size(229, 41);
            this.label_revenue.TabIndex = 6;
            this.label_revenue.Text = "10,000,000,000";
            this.label_revenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // header_renueve
            // 
            this.header_renueve.AutoSize = true;
            this.header_renueve.BackColor = System.Drawing.Color.Transparent;
            this.header_renueve.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.header_renueve.Location = new System.Drawing.Point(170, 25);
            this.header_renueve.Name = "header_renueve";
            this.header_renueve.Size = new System.Drawing.Size(186, 31);
            this.header_renueve.TabIndex = 5;
            this.header_renueve.Text = "Tổng doanh thu";
            // 
            // panel_numOfOrder
            // 
            this.panel_numOfOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_numOfOrder.BackgroundImage")));
            this.panel_numOfOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_numOfOrder.Controls.Add(this.label5);
            this.panel_numOfOrder.Controls.Add(this.label_increase_numOrder);
            this.panel_numOfOrder.Controls.Add(this.pictureBox3);
            this.panel_numOfOrder.Controls.Add(this.label_numOfOrder);
            this.panel_numOfOrder.Controls.Add(this.header_numOrder);
            this.panel_numOfOrder.GradiantColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(158)))));
            this.panel_numOfOrder.GradiantColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(158)))));
            this.panel_numOfOrder.GradiantColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(158)))));
            this.panel_numOfOrder.GradiantColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(158)))));
            this.panel_numOfOrder.Location = new System.Drawing.Point(953, 52);
            this.panel_numOfOrder.Name = "panel_numOfOrder";
            this.panel_numOfOrder.Size = new System.Drawing.Size(400, 170);
            this.panel_numOfOrder.TabIndex = 10;
            this.panel_numOfOrder.Text = "gunaGradientPanel3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(198, 123);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "so với tháng trước";
            // 
            // label_increase_numOrder
            // 
            this.label_increase_numOrder.AutoSize = true;
            this.label_increase_numOrder.BackColor = System.Drawing.Color.Transparent;
            this.label_increase_numOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_increase_numOrder.Location = new System.Drawing.Point(141, 123);
            this.label_increase_numOrder.Name = "label_increase_numOrder";
            this.label_increase_numOrder.Size = new System.Drawing.Size(51, 25);
            this.label_increase_numOrder.TabIndex = 13;
            this.label_increase_numOrder.Text = "↘2%";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::grocery_store.Properties.Resources.cart_2;
            this.pictureBox3.Location = new System.Drawing.Point(19, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label_numOfOrder
            // 
            this.label_numOfOrder.AutoSize = true;
            this.label_numOfOrder.BackColor = System.Drawing.Color.Transparent;
            this.label_numOfOrder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_numOfOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_numOfOrder.Location = new System.Drawing.Point(134, 69);
            this.label_numOfOrder.Name = "label_numOfOrder";
            this.label_numOfOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_numOfOrder.Size = new System.Drawing.Size(229, 41);
            this.label_numOfOrder.TabIndex = 11;
            this.label_numOfOrder.Text = "10,000,000,000";
            this.label_numOfOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // header_numOrder
            // 
            this.header_numOrder.AutoSize = true;
            this.header_numOrder.BackColor = System.Drawing.Color.Transparent;
            this.header_numOrder.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.header_numOrder.Location = new System.Drawing.Point(212, 23);
            this.header_numOrder.Name = "header_numOrder";
            this.header_numOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.header_numOrder.Size = new System.Drawing.Size(150, 31);
            this.header_numOrder.TabIndex = 10;
            this.header_numOrder.Text = "Số đơn hàng";
            // 
            // ElipseRevenue
            // 
            this.ElipseRevenue.Radius = 20;
            this.ElipseRevenue.TargetControl = this.panel_revenue;
            // 
            // ElipseProfit
            // 
            this.ElipseProfit.Radius = 20;
            this.ElipseProfit.TargetControl = this.panel_profit;
            // 
            // ElipseNum
            // 
            this.ElipseNum.Radius = 20;
            this.ElipseNum.TargetControl = this.panel_numOfOrder;
            // 
            // reportViewer
            // 
            this.reportViewer.LocalReport.ReportEmbeddedResource = "grocery_store.GUI.ThongKe.statistical.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(59, 252);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.ShowBackButton = false;
            this.reportViewer.ShowFindControls = false;
            this.reportViewer.ShowPageNavigationControls = false;
            this.reportViewer.ShowPrintButton = false;
            this.reportViewer.ShowStopButton = false;
            this.reportViewer.ShowZoomControl = false;
            this.reportViewer.Size = new System.Drawing.Size(1625, 768);
            this.reportViewer.TabIndex = 11;
            // 
            // input_dateStart
            // 
            this.input_dateStart.CalendarTrailingForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.input_dateStart.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.input_dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_dateStart.Location = new System.Drawing.Point(1407, 80);
            this.input_dateStart.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.input_dateStart.Name = "input_dateStart";
            this.input_dateStart.Size = new System.Drawing.Size(233, 47);
            this.input_dateStart.TabIndex = 10;
            this.input_dateStart.Value = new System.DateTime(2024, 3, 1, 0, 0, 0, 0);
            this.input_dateStart.Validating += new System.ComponentModel.CancelEventHandler(this.input_dateStart_Validating);
            this.input_dateStart.Validated += new System.EventHandler(this.input_dateStart_Validated);
            // 
            // input_dateEnd
            // 
            this.input_dateEnd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.input_dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_dateEnd.Location = new System.Drawing.Point(1407, 175);
            this.input_dateEnd.MinDate = new System.DateTime(2024, 5, 1, 0, 0, 0, 0);
            this.input_dateEnd.Name = "input_dateEnd";
            this.input_dateEnd.Size = new System.Drawing.Size(233, 47);
            this.input_dateEnd.TabIndex = 12;
            this.input_dateEnd.Value = new System.DateTime(2024, 5, 30, 0, 0, 0, 0);
            this.input_dateEnd.Validating += new System.ComponentModel.CancelEventHandler(this.input_dateEnd_Validating);
            this.input_dateEnd.Validated += new System.EventHandler(this.input_dateEnd_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(1407, 52);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(1407, 143);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Đến ngày";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_dateEnd);
            this.Controls.Add(this.input_dateStart);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.panel_numOfOrder);
            this.Controls.Add(this.panel_revenue);
            this.Controls.Add(this.panel_profit);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(1720, 1050);
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.panel_profit.ResumeLayout(false);
            this.panel_profit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel_revenue.ResumeLayout(false);
            this.panel_revenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_numOfOrder.ResumeLayout(false);
            this.panel_numOfOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel panel_profit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_increase_profit;
        private System.Windows.Forms.Label header_profit;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Label label_profit;
        private Guna.UI.WinForms.GunaGradientPanel panel_revenue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_increase_revenue;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label_revenue;
        private System.Windows.Forms.Label header_renueve;
        private Guna.UI.WinForms.GunaGradientPanel panel_numOfOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_increase_numOrder;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label label_numOfOrder;
        private System.Windows.Forms.Label header_numOrder;
        private Guna.UI.WinForms.GunaElipse ElipseRevenue;
        private Guna.UI.WinForms.GunaElipse ElipseProfit;
        private Guna.UI.WinForms.GunaElipse ElipseNum;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.DateTimePicker input_dateStart;
        private System.Windows.Forms.DateTimePicker input_dateEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
