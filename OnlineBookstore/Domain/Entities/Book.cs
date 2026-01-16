using OnlineBookstore.Common;
using System.ComponentModel.DataAnnotations;

namespace OnlineBookstore.Domain.Entities
{
    public class Book : BaseDomainEntity
    {
        [Required]
        public string? Title { get; set; }
        public string? ISBN { get; set; }
        public string? Description { get; set; }
        public string? ImageLink { get; set; } // Required for your picture feature

        public double PricePhysical { get; set; }
        public double PriceSoftcopy { get; set; }
        public int? StockQuantity { get; set; }

        public int? AuthorId { get; set; }
        public virtual Author? Author { get; set; }

        public int? GenreId { get; set; }
        public virtual Genre? Genre { get; set; }
    }
}