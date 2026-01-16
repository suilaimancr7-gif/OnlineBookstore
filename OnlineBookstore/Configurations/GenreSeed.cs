using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBookstore.Domain.Entities;

namespace OnlineBookstore.Configurations
{
    public class GenreSeed : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                new Genre { Id = 1, Name = "Fiction" },
                new Genre { Id = 2, Name = "Dystopian" },
                new Genre { Id = 3, Name = "Fantasy" },
                new Genre { Id = 4, Name = "Self-Help" },
                new Genre { Id = 5, Name = "Biography" },
                new Genre { Id = 6, Name = "Thriller" }
            );
        }
    }
}
