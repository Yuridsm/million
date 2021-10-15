using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.DataModel {
    public class DbContextInMemory : DbContext
    {
        public DbContextInMemory(DbContextOptions<DbContextInMemory> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Logging> Loggings { get; set; }
    }
}

