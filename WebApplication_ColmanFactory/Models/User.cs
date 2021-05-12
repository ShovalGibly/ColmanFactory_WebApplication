using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_ColmanFactory.Models
{
    public class User
    {
        // User ID
        [Key]
        public int UserID { get; set; }

        // User Role
        public bool isEditor { get; set; }

        // User Data
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        // Many To Many connection ( -> orderHistory and -> cart )
     
    }
}
