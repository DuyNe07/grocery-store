using grocery_store.Models;
using System.Collections.Generic;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using System.Linq;

namespace grocery_store.GUI.HoaDon
{
    public partial class Bill : UserControl
    {
        private int ShopOrderID;
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VI");
        public Bill(int shoporderID)
        {
            InitializeComponent();
            ShopOrderID = shoporderID;
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

                }).ToList();

                //reportViewer_invoice.LocalReport.DataSources.Clear();
                //reportViewer_invoice.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet_Invoice", formattedInvoices));

                //reportViewer_invoice.RefreshReport();
            }
        }
               
        public void GenarateBarCode()
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.CODE_128;
            writer.Options = new EncodingOptions
            {
                Height = 100,
                Width = 300
            };
        }

        private void Bill_Load(object sender, System.EventArgs e)
        {

        }
    }
}
