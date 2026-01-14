using Microsoft.EntityFrameworkCore;
using OnlineBookstore.Domain.Entities;

namespace OnlineBookstore.Domain.Data
{
    public class OnlineBookstoreContext : DbContext
    {
        public OnlineBookstoreContext(DbContextOptions<OnlineBookstoreContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = default!;
        public DbSet<Genre> Genres { get; set; } = default!;
        public DbSet<Publisher> Publishers { get; set; } = default!;
        public DbSet<Author> Authors { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<OrderItem> OrderItems { get; set; } = default!;
        public DbSet<Payment> Payments { get; set; } = default!;
    }
}
