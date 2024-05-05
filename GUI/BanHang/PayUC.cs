using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;
using System.Drawing.Imaging;
using ZXing.Common;
using System.IO;
using grocery_store.Models;



namespace grocery_store.GUI.BanHang
{
    public partial class PayUC : UserControl
    {
        public event EventHandler OKClick;
        public event EventHandler CancelClick;
        private System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VI");
        public bool paid = false; 
        public Image Image
        {
            get { return pictureBox_QR.Image; }
            set { pictureBox_QR.Image = value; }
        }

        public PayUC(Image paymentImage)
        {
            InitializeComponent();
            //this.reportViewer.LocalReport.ReportEmbeddedResource = "grocery_store.GUI.BanHang.ShopOrderReport.rdlc";

            this.Image = paymentImage;
            this.btn_OK.Click += (sender, e) => OKClick?.Invoke(this, e);
            this.btn_Cancel.Click += (sender, e) => CancelClick?.Invoke(this, e);
        }

        public void loadReport(List<Item> items, string paymentMethod, string EmployyeeName)
        {
            reportViewer.Visible = true;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetItem", items));

            ReportParameter paymentMethodParam = new ReportParameter();
            paymentMethodParam.Name = "PaymentMethod";
            paymentMethodParam.Values.Add(paymentMethod);
            reportViewer.LocalReport.SetParameters(paymentMethodParam);

            ReportParameter employeeNameParam = new ReportParameter();
            employeeNameParam.Name = "EmployeeName";
            employeeNameParam.Values.Add(EmployyeeName);
            reportViewer.LocalReport.SetParameters(employeeNameParam);

            ReportParameter orderDate = new ReportParameter();
            orderDate.Name = "OrderDate";
            orderDate.Values.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            reportViewer.LocalReport.SetParameters(orderDate);

            ReportParameter orderTotal = new ReportParameter();
            orderTotal.Name = "OrderTotal";
            orderTotal.Values.Add(items.Sum(i => i.Product.MarketPrice * i.Quantity).ToString("N0", culture));
            reportViewer.LocalReport.SetParameters(orderTotal);

            reportViewer.RefreshReport();
        }

    }
}
