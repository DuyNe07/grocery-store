using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace grocery_store.Models
{
    public partial class EmployeeTimekeeping
    {
        [Key, Column(Order = 0)]
        public int? EmployeeId { get; set; }
        [Key, Column(Order = 1)]
        public int? TimekeepingId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Timekeeping Timekeeping { get; set; }
    }
}
