using OnlineBookstore.Common;

namespace OnlineBookstore.Domain.Entities
{
    public class Publisher : BaseDomainEntity
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? ContactInfo { get; set; }

        // Navigation property: one Publisher can publish many Books
        public ICollection<Book>? Books { get; set; }
    }
}

