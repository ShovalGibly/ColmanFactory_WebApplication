using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_ColmanFactory.Models
{
    public class Cart
    {
        /**
    * User's cart
    * Many to many class between the users and their chosen products
    */
       
            // User Data
            public int UserID { get; set; }
            public User User { get; set; }

            // Product Data
            public int ProductID { get; set; }
            public Product Product { get; set; }

            // How much from each item 
            public int Amount { get; set; }
        
    }
}
