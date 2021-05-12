using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication_ColmanFactory.Models;

namespace WebApplication_ColmanFactory.Data
{
    public class WebApplication_ColmanFactoryContext : DbContext
    {
        public WebApplication_ColmanFactoryContext (DbContextOptions<WebApplication_ColmanFactoryContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication_ColmanFactory.Models.Product> Product { get; set; }

        public DbSet<WebApplication_ColmanFactory.Models.Category> Category { get; set; }

        public DbSet<WebApplication_ColmanFactory.Models.User> User { get; set; }
    }
}
