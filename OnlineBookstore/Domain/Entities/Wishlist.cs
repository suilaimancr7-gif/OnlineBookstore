using OnlineBookstore.Common;
using System.ComponentModel.DataAnnotations;

namespace OnlineBookstore.Domain.Entities
{
    public class Wishlist : BaseDomainEntity
    {
        [Required]
        public string? CustomerId { get; set; } // Links to the logged-in User

        public int BookId { get; set; }
        public virtual Book? Book { get; set; }

        public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}