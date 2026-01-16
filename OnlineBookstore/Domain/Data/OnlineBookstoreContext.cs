using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineBookstore.Domain.Entities;
using OnlineBookstore.Domain;
using OnlineBookstore.Configurations;

namespace OnlineBookstore.Domain.Data
{
    // Updated to Primary Constructor syntax from CarRental skeleton
    public class OnlineBookstoreContext(DbContextOptions<OnlineBookstoreContext> options) :
        IdentityDbContext<OnlineBookstoreUser>(options)
    {
        public DbSet<Book> Books { get; set; } = default!;
        public DbSet<Genre> Genres { get; set; } = default!;
        public DbSet<Publisher> Publishers { get; set; } = default!;
        public DbSet<Author> Authors { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<OrderItem> OrderItems { get; set; } = default!;
        public DbSet<Payment> Payments { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Mandatory for IdentityDbContext to function
            base.OnModelCreating(builder);

            // Placeholder for future seed data configurations
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
        }
    }
}