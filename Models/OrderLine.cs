using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace grocery_store.Models
{
    public partial class OrderLine
    {
        public int OrderLineId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public int? ShopOrderId { get; set; }
        public int? ProductId { get; set; }

        public virtual Product ShopOrder { get; set; }
        public virtual ShopOrder ShopOrderNavigation { get; set; }
    }
}
