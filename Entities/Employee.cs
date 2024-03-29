﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace grocery_store.Entities
{
    public partial class Employee
    {
        public Employee()
        {
            ShopOrder = new HashSet<ShopOrder>();
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public int? JobId { get; set; }

        public virtual Job Job { get; set; }
        public virtual ICollection<ShopOrder> ShopOrder { get; set; }
    }
}
