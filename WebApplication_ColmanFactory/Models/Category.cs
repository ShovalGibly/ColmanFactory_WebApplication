using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_ColmanFactory.Models
{
    public class Category
    {
        // Category ID
        [Key]
        public int CategoryID { get; set; }

        // Category Data
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }

        [DisplayName("Image")]
        public string CategoryImagePath { get; set; }

        [DisplayName("Description")]
        public string CategoryDescription { get; set; }

        // one to many connection with Product
        public List<Product> Products { get; set; }
    }
}
