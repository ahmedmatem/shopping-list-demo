using Microsoft.EntityFrameworkCore;

namespace ShoppingList.Data
{
    public class ShoppingListDbContext : DbContext
    {
        public ShoppingListDbContext(DbContextOptions<ShoppingListDbContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .HasData(
                new Product() { Name = "Chees", Id = 1 },
                new Product() { Name = "Milk", Id = 2 });
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductNote> ProductNotes { get; set; }
    }
}
