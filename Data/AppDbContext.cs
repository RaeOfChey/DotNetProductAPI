using Microsoft.EntityFrameworkCore;
using DotNetProductAPI.Models;

namespace DotNetProductAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; } // DbSet for Products
    }
}