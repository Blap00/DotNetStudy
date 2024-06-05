using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DatabaseContext : DbContext
    {
        // SET THE DB TABLES
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=PC-FABIAN; Database = master; Persist Security Info = True;user ID=coreAPP; password=dotnetadmin");
            }
            
            base.OnConfiguring(optionsBuilder);
        }
    }
}
