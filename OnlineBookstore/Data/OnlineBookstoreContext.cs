using Microsoft.EntityFrameworkCore;
using OnlineBookstore.Domain;
using System.Collections.Generic;

namespace OnlineBookstore.Data
{
    public class OnlineBookstoreContext : DbContext
    {
        public OnlineBookstoreContext(DbContextOptions<OnlineBookstoreContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = default!;
    }
}
