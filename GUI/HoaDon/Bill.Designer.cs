namespace grocery_store.GUI.HoaDon
{
    partial class Bill
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
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_close = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.LocalReport.ReportEmbeddedResource = "grocery_store.GUI.HoaDon.BillReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(153, 56);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.ShowBackButton = false;
            this.reportViewer.ShowFindControls = false;
            this.reportViewer.ShowPageNavigationControls = false;
            this.reportViewer.ShowPrintButton = false;
            this.reportViewer.ShowStopButton = false;
            this.reportViewer.ShowZoomControl = false;
            this.reportViewer.Size = new System.Drawing.Size(526, 825);
            this.reportViewer.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.AnimationHoverSpeed = 0.07F;
            this.btn_close.AnimationSpeed = 0.03F;
            this.btn_close.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.btn_close.BorderColor = System.Drawing.Color.Black;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Image = null;
            this.btn_close.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_close.Location = new System.Drawing.Point(518, 923);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btn_close.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_close.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_close.OnHoverImage = null;
            this.btn_close.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.btn_close.Radius = 15;
            this.btn_close.Size = new System.Drawing.Size(161, 58);
            this.btn_close.TabIndex = 13;
            this.btn_close.Text = "Thoát";
            this.btn_close.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.btn_close);
            this.Name = "Bill";
            this.Size = new System.Drawing.Size(851, 1008);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        public Guna.UI.WinForms.GunaButton btn_close;
    }
}
