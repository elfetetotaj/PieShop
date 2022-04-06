using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PieShop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pie>().Property(p => p.Price).HasColumnType("decimal(18,4)");
        }
    }
}
