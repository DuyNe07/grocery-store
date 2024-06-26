﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace grocery_store.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderLine = new HashSet<OrderLine>();
            ProductDetail = new HashSet<ProductDetail>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal CostPrice { get; set; }
        public string Sku { get; set; }
        public decimal MarketPrice { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<OrderLine> OrderLine { get; set; }
        public virtual ICollection<ProductDetail> ProductDetail { get; set; }
    }
}
