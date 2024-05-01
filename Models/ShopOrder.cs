using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace grocery_store.Models
{
    public partial class ShopOrder
    {
        public ShopOrder()
        {
            OrderLine = new HashSet<OrderLine>();
        }

        public int ShopOrderId { get; set; }
        public decimal? SubTotal { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? PaymentId { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual ICollection<OrderLine> OrderLine { get; set; }
    }
}
