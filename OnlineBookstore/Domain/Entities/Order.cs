using OnlineBookstore.Common;

namespace OnlineBookstore.Domain.Entities
{
    public class Order : BaseDomainEntity
    {
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string? CustomerId { get; set; } // Matches the SQL column causing the error
        public string? ShippingAddress { get; set; }
        public string? CustomerEmail { get; set; }
        public string? TrackingNumber { get; set; }
        public string? ReferenceCode { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}