using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaDesarrolladorNet.Model;

namespace PruebaDesarrolladorNet.Data
{
    internal class ApplicationDbContext : DbContext
    {
        
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CRUDComputers;Trusted_Connection=True;TrustServerCertificate=True;");
        
    }
}
