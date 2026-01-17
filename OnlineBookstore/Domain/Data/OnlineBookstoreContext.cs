using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineBookstore.Domain.Entities;
using OnlineBookstore.Domain;
using OnlineBookstore.Configurations;

namespace OnlineBookstore.Domain.Data
{
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

        // Add the Admin entity here for the new CRUD
        public DbSet<Admin> Admins { get; set; } = default!;
        public DbSet<Wishlist> Wishlists { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new GenreSeed());
            builder.ApplyConfiguration(new BookSeed());
        }
    }
}