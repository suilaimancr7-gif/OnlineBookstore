namespace OnlineBookstore.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? CustID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? PhoneNumber { get; set; }
        public string? Address { get; set; }

    }
}

