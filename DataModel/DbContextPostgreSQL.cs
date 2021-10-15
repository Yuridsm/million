using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.DataModel {
    public class DbContextPostgreSQL : DbContext
    {
        public DbContextPostgreSQL(DbContextOptions<DbContextPostgreSQL> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

