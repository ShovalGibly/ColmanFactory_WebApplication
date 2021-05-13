using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_ColmanFactory.Models
{
    public enum UserType
    {
        Guest,
        Client,
        Admin
    }
    public class User
    { 

        // User ID
        [Key]
        public int UserID { get; set; }

        // User Role

        public UserType Type { get; set; } = UserType.Guest;

        // User Data
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        // Many To Many connection ( -> orderHistory and -> cart )
     
    }
}
