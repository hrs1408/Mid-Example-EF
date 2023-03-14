using Microsoft.EntityFrameworkCore;
using Mid_Example.Models;

namespace Mid_Example.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
