using OnlineBookstore.Common;

namespace OnlineBookstore.Domain.Entities
{
    public class Customer : BaseDomainEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }

        // Navigation property: one Customer can place many Orders
        public ICollection<Order>? Orders { get; set; }
    }
}
