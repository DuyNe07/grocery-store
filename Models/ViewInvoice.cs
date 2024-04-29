using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace grocery_store.Models
{
    public partial class ViewInvoice
    {
        public int ShopOrderId { get; set; }
        public string ProductName { get; set; }
        public DateTime OrderDate { get; set; }
        public int? Quantity { get; set; }
        public decimal MarketPrice { get; set; }
        public decimal PriceLine { get; set; }
        public string NameEmp { get; set; }
        public decimal SubTotal { get; set; }
        public string PaymentMethod { get; set; }

        public string FormattedMarketPrice
        {
            get { return MarketPrice.ToString("N0", new System.Globalization.CultureInfo("vi-VI")); }
        }

        public string FormattedPriceLine
        {
            get { return PriceLine.ToString("N0", new System.Globalization.CultureInfo("vi-VI")); }
        }

        public string FormattedSubTotal
        {
            get { return SubTotal.ToString("N0", new System.Globalization.CultureInfo("vi-VI")); }
        }
    }
}
