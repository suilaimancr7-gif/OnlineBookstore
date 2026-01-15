using OnlineBookstore.Common;

namespace OnlineBookstore.Domain.Entities
{
    public class Author : BaseDomainEntity
    {
        public string? Name { get; set; }
        public string? Bio { get; set; }

        // Navigation property: one Author can write many Books
        public ICollection<Book>? Books { get; set; }
    }
}

