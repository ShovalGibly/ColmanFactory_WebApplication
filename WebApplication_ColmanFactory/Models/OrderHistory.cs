using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_ColmanFactory.Models
{
    public class OrderHistory
    {
        // User data
        public int UserID { get; set; }
        public User User { get; set; }

        // Product number
        public int ProductID { get; set; }
        public Product Product { get; set; }

        // How much from each item
        public int Amount { get; set; }

        // When bought 
        public int MonthNumber { get; set; }
    }
}
