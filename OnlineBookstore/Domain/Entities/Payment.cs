using OnlineBookstore.Common;

namespace OnlineBookstore.Domain.Entities
{
    public class Payment : BaseDomainEntity
    {
        public DateTime PaymentDate { get; set; }
        public string? PaymentMethod { get; set; }
        public string? PaymentStatus { get; set; }
        public decimal Amount { get; set; }

        public int OrderId { get; set; }
        public Order? Order { get; set; }
    }
}

