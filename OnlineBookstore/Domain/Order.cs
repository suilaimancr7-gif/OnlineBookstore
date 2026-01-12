using System.Collections.Generic;

namespace OnlineBookstore.Domain
{
    public class Order : BaseDomainModel
    {
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}

