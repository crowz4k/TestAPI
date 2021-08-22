using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    public class AppDBContext:DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<OrderLineItem> OrderLineItems { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite($"Data Source=example.db;");
            optionsBuilder.EnableSensitiveDataLogging();

        }
    }
}
