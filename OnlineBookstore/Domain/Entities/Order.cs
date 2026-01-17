using OnlineBookstore.Common;

namespace OnlineBookstore.Domain.Entities
{
    public class Order : BaseDomainEntity
    {
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string? CustomerId { get; set; }
        public string? ShippingAddress { get; set; }
        public string? CustomerEmail { get; set; }
        public string? TrackingNumber { get; set; }
        public string? ReferenceCode { get; set; }

        // Add this property to fix the CS1061 error
        public decimal TotalAmount { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}