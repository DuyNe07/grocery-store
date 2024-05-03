using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace grocery_store.Models
{
    public partial class ProductDetail
    {
        public string Sku { get; set; }
        public int? QuantityInStock { get; set; }
        public DateTime Expiry { get; set; }

        public string BarCode { get; set; }
        public virtual Product SkuNavigation { get; set; }

        public void generateBarCode()
        {
            if (Sku == null) { return; }
            else
            {
                BarCode = Sku.Trim() + Expiry.ToString("yyMMdd");
            }
        }

    }
}
