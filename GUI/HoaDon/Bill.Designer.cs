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
            this.reportViewer_invoice = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer_invoice
            // 
            this.reportViewer_invoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.reportViewer_invoice.AutoSize = true;
            this.reportViewer_invoice.LocalReport.ReportEmbeddedResource = "grocery_store.GUI.HoaDon.BillReport.rdlc";
            this.reportViewer_invoice.Location = new System.Drawing.Point(15, 20);
            this.reportViewer_invoice.Name = "reportViewer_invoice";
            this.reportViewer_invoice.ServerReport.BearerToken = null;
            this.reportViewer_invoice.Size = new System.Drawing.Size(587, 521);
            this.reportViewer_invoice.TabIndex = 0;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.reportViewer_invoice);
            this.Name = "Bill";
            this.Size = new System.Drawing.Size(608, 560);
            this.Load += new System.EventHandler(this.Bill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer_invoice;
    }
}
