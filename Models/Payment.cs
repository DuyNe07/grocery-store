using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace grocery_store.Models
{
    public partial class Payment
    {
        public Payment()
        {
            ShopOrder = new HashSet<ShopOrder>();
        }

        public int PaymentId { get; set; }
        public string Name { get; set; }
        public string Qr { get; set; }

        public virtual ICollection<ShopOrder> ShopOrder { get; set; }
    }
}
