using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext()
        {
            
        }
        public ShopContext(DbContextOptions options):base(options)
        {
            
        }
        public virtual DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 101, Name = "Pencil", Price = 12.5f, Quantity = 2 },
                new Product { Id = 102, Name = "Eraser", Price = 5.0f, Quantity = 3 }
            );
        }
    }
}
