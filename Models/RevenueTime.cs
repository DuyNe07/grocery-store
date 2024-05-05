using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grocery_store.Models
{
    public class RevenueTime
    {
        public DateTime OrderDate { get; set; }
        public string ProductName { get; set; }
        public decimal Revenue { get; set; }
        public decimal SubTotal { get; set; }

        public string MonthYear
        {
            get
            {
                return OrderDate.ToString("MM/yyyy");
            }
        }
    }
}
