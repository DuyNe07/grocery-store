﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace grocery_store.Entities
{
    public partial class Timekeeping
    {
        public int TimekeepingId { get; set; }
        public TimeSpan? Checkin { get; set; }
        public decimal? Checkout { get; set; }
        public decimal? Salary { get; set; }
    }
}
