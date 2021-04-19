using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Context {
    public class DbContextApplication : DbContext
    {
        public DbContextApplication(DbContextOptions<DbContextApplication> options) : base(options)
        {
        }
        public DbSet<Product> Products { get;set; }
        public DbSet<Category> Categories { get;set; }
        public DbSet<Theme> Themes { get;set; }
    }
}

