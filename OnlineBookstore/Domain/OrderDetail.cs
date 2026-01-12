namespace OnlineBookstore.Domain
{
    public class OrderDetail : BaseDomainModel
    {
        public int OrderId { get; set; }
        public Order? Order { get; set; }
        public int BookId { get; set; }
        public Book? Book { get; set; }
        public int Quantity { get; set; }
    }
}

