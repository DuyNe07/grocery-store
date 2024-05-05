using grocery_store.Models;
using System.Collections.Generic;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using System.Linq;
using System;
using System.Drawing;
using System.IO;

namespace grocery_store.GUI.HoaDon
{
    public partial class Bill : UserControl
    {
        private int ShopOrderID;
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VI");
        public event EventHandler CloseClick;
        public Bill(int shoporderID)
        {
            InitializeComponent();
            ShopOrderID = shoporderID;
            this.btn_close.Click += (sender, e) => CloseClick?.Invoke(this, e);
            loadData();
        }
        public void loadData()
        {
            using (var context = new GroceryStoreContext())
            {
                var invoices = context.ViewInvoice.Where(x => x.ShopOrderId == ShopOrderID).ToList();

                var formattedInvoices = invoices.Select(invoice => new
                {
                    ProductName = invoice.ProductName,
                    Quantity = invoice.Quantity,
                    OrderDate = invoice.OrderDate.ToString("dd/MM/yyyy HH:mm"),
                    NameEmp = invoice.NameEmp,
                    PaymentMethod = invoice.PaymentMethod,
                    MarketPrice = invoice.FormattedMarketPrice,
                    PriceLine = invoice.FormattedPriceLine,
                    SubTotal = invoice.FormattedSubTotal,
                    BarCode = invoice.BarCode
                }).ToList();

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet_Invoice", formattedInvoices));

                reportViewer.RefreshReport();
            }
        }
    }
}
