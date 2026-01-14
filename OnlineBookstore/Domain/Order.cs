using System.Collections.Generic;

namespace OnlineBookstore.Domain
{
    public class Order : BaseDomainModel
    {
        public int CustomerId { get; set; }
        public Customer? CustomerID { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}

