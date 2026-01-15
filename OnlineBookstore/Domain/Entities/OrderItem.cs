using OnlineBookstore.Common;

namespace OnlineBookstore.Domain.Entities
{
    public class OrderItem : BaseDomainEntity
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public int OrderId { get; set; }
        public Order? Order { get; set; }

        public int BookId { get; set; }
        public Book? Book { get; set; }
    }
}

