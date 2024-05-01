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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_profit = new System.Windows.Forms.Label();
            this.gunaGradientPanel2 = new Guna.UI.WinForms.GunaGradientPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label_increase_revenue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_revenue = new System.Windows.Forms.Label();
            this.header_renueve = new System.Windows.Forms.Label();
            this.gunaGradientPanel3 = new Guna.UI.WinForms.GunaGradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label_increase_numOrder = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_numOfOrder = new System.Windows.Forms.Label();
            this.header_numOrder = new System.Windows.Forms.Label();
            this.gunaGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gunaGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.LocalReport.ReportEmbeddedResource = "grocery_store.GUI.ThongKe.statistical.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(82, 255);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1588, 730);
            this.reportViewer.TabIndex = 0;
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.label2);
            this.gunaGradientPanel1.Controls.Add(this.label9);
            this.gunaGradientPanel1.Controls.Add(this.label11);
            this.gunaGradientPanel1.Controls.Add(this.pictureBox4);
            this.gunaGradientPanel1.Controls.Add(this.label_profit);
            this.gunaGradientPanel1.GradiantColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.gunaGradientPanel1.GradiantColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.gunaGradientPanel1.GradiantColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.gunaGradientPanel1.GradiantColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.gunaGradientPanel1.Location = new System.Drawing.Point(687, 52);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(400, 170);
            this.gunaGradientPanel1.TabIndex = 8;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(143, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "↗2%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(187, 25);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(177, 31);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tổng lợi nhuận";
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
            // gunaGradientPanel2
            // 
            this.gunaGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel2.BackgroundImage")));
            this.gunaGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel2.Controls.Add(this.label8);
            this.gunaGradientPanel2.Controls.Add(this.label_increase_revenue);
            this.gunaGradientPanel2.Controls.Add(this.pictureBox1);
            this.gunaGradientPanel2.Controls.Add(this.label_revenue);
            this.gunaGradientPanel2.Controls.Add(this.header_renueve);
            this.gunaGradientPanel2.GradiantColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.gunaGradientPanel2.GradiantColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.gunaGradientPanel2.GradiantColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.gunaGradientPanel2.GradiantColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.gunaGradientPanel2.Location = new System.Drawing.Point(82, 52);
            this.gunaGradientPanel2.Name = "gunaGradientPanel2";
            this.gunaGradientPanel2.Size = new System.Drawing.Size(400, 170);
            this.gunaGradientPanel2.TabIndex = 9;
            this.gunaGradientPanel2.Text = "gunaGradientPanel2";
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
            // gunaGradientPanel3
            // 
            this.gunaGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel3.BackgroundImage")));
            this.gunaGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel3.Controls.Add(this.label5);
            this.gunaGradientPanel3.Controls.Add(this.label_increase_numOrder);
            this.gunaGradientPanel3.Controls.Add(this.pictureBox3);
            this.gunaGradientPanel3.Controls.Add(this.label_numOfOrder);
            this.gunaGradientPanel3.Controls.Add(this.header_numOrder);
            this.gunaGradientPanel3.GradiantColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(112)))));
            this.gunaGradientPanel3.GradiantColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(218)))));
            this.gunaGradientPanel3.GradiantColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(158)))));
            this.gunaGradientPanel3.GradiantColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(218)))));
            this.gunaGradientPanel3.Location = new System.Drawing.Point(1270, 52);
            this.gunaGradientPanel3.Name = "gunaGradientPanel3";
            this.gunaGradientPanel3.Size = new System.Drawing.Size(400, 170);
            this.gunaGradientPanel3.TabIndex = 10;
            this.gunaGradientPanel3.Text = "gunaGradientPanel3";
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
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.gunaGradientPanel3);
            this.Controls.Add(this.gunaGradientPanel2);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.reportViewer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(1720, 1050);
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gunaGradientPanel2.ResumeLayout(false);
            this.gunaGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaGradientPanel3.ResumeLayout(false);
            this.gunaGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Label label_profit;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_increase_revenue;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label_revenue;
        private System.Windows.Forms.Label header_renueve;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_increase_numOrder;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label label_numOfOrder;
        private System.Windows.Forms.Label header_numOrder;
    }
}
