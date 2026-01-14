using OnlineBookstore.Common;

namespace OnlineBookstore.Domain.Entities
{
    public class Order : BaseDomainEntity
    {
        public DateTime OrderDate { get; set; }
        public string? OrderStatus { get; set; }
        public decimal TotalAmount { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        // Navigation properties
        public ICollection<OrderItem>? OrderItems { get; set; }
        public Payment? Payment { get; set; }
    }
}
