using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBookstore.Domain.Entities;

namespace OnlineBookstore.Configurations
{
    public class BookSeed : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                // 1-10: Classics
                new Book { Id = 1, Title = "The Great Gatsby", ISBN = "9780743273565", PricePhysical = 15.99, PriceSoftcopy = 9.99, StockQuantity = 50, ImageLink = "https://m.media-amazon.com/images/I/71FTb9X6wsL.jpg", GenreId = 1 },
                new Book { Id = 2, Title = "To Kill a Mockingbird", ISBN = "9780061120084", PricePhysical = 12.50, PriceSoftcopy = 7.99, StockQuantity = 35, ImageLink = "https://m.media-amazon.com/images/I/81gepf1eMqL.jpg", GenreId = 1 },
                new Book { Id = 3, Title = "1984", ISBN = "9780451524935", PricePhysical = 10.00, PriceSoftcopy = 5.99, StockQuantity = 100, ImageLink = "https://m.media-amazon.com/images/I/71kxa1-qmfL.jpg", GenreId = 2 },
                new Book { Id = 4, Title = "Pride and Prejudice", ISBN = "9780141439518", PricePhysical = 9.99, PriceSoftcopy = 4.99, StockQuantity = 60, ImageLink = "https://m.media-amazon.com/images/I/71Q1Iu4suAL.jpg", GenreId = 1 },
                new Book { Id = 5, Title = "The Catcher in the Rye", ISBN = "9780316769488", PricePhysical = 14.00, PriceSoftcopy = 8.50, StockQuantity = 40, ImageLink = "https://m.media-amazon.com/images/I/8125BD7z9pL.jpg", GenreId = 1 },
                new Book { Id = 6, Title = "Wuthering Heights", ISBN = "9780141439556", PricePhysical = 11.00, PriceSoftcopy = 5.00, StockQuantity = 20, ImageLink = "https://m.media-amazon.com/images/I/81Y7p99uRHL.jpg", GenreId = 1 },
                new Book { Id = 7, Title = "Moby Dick", ISBN = "9780142437247", PricePhysical = 18.00, PriceSoftcopy = 9.00, StockQuantity = 15, ImageLink = "https://m.media-amazon.com/images/I/71d5f-9Y6uL.jpg", GenreId = 1 },
                new Book { Id = 8, Title = "The Odyssey", ISBN = "9780140268867", PricePhysical = 16.00, PriceSoftcopy = 8.00, StockQuantity = 30, ImageLink = "https://m.media-amazon.com/images/I/81mE79Y+v9L.jpg", GenreId = 1 },
                new Book { Id = 9, Title = "Crime and Punishment", ISBN = "9780143107637", PricePhysical = 17.50, PriceSoftcopy = 10.00, StockQuantity = 25, ImageLink = "https://m.media-amazon.com/images/I/71O2XI6Df6L.jpg", GenreId = 1 },
                new Book { Id = 10, Title = "Brave New World", ISBN = "9780060850524", PricePhysical = 13.99, PriceSoftcopy = 7.99, StockQuantity = 45, ImageLink = "https://m.media-amazon.com/images/I/81mXqW2H6sL.jpg", GenreId = 2 },

                // 11-20: Sci-Fi & Fantasy
                new Book { Id = 11, Title = "The Hobbit", ISBN = "9780547928227", PricePhysical = 25.00, PriceSoftcopy = 15.00, StockQuantity = 20, ImageLink = "https://m.media-amazon.com/images/I/710+HcoPgtL.jpg", GenreId = 3 },
                new Book { Id = 12, Title = "Dune", ISBN = "9780441172719", PricePhysical = 22.00, PriceSoftcopy = 12.00, StockQuantity = 45, ImageLink = "https://m.media-amazon.com/images/I/818pgeS7YdL.jpg", GenreId = 2 },
                new Book { Id = 13, Title = "Foundation", ISBN = "9780553293357", PricePhysical = 18.50, PriceSoftcopy = 10.00, StockQuantity = 30, ImageLink = "https://m.media-amazon.com/images/I/71UupBy6S7L.jpg", GenreId = 2 },
                new Book { Id = 14, Title = "Neuromancer", ISBN = "9780441569595", PricePhysical = 16.00, PriceSoftcopy = 9.00, StockQuantity = 25, ImageLink = "https://m.media-amazon.com/images/I/91BpM6vI69L.jpg", GenreId = 2 },
                new Book { Id = 15, Title = "Hyperion", ISBN = "9780553283686", PricePhysical = 19.00, PriceSoftcopy = 11.00, StockQuantity = 12, ImageLink = "https://m.media-amazon.com/images/I/91XmB0vG-EL.jpg", GenreId = 2 },
                new Book { Id = 16, Title = "The Martian", ISBN = "9780553418026", PricePhysical = 15.00, PriceSoftcopy = 8.00, StockQuantity = 55, ImageLink = "https://m.media-amazon.com/images/I/81vSXYYmXfL.jpg", GenreId = 2 },
                new Book { Id = 17, Title = "Project Hail Mary", ISBN = "9780593135204", PricePhysical = 28.00, PriceSoftcopy = 14.00, StockQuantity = 60, ImageLink = "https://m.media-amazon.com/images/I/919YpC-N8rL.jpg", GenreId = 2 },
                new Book { Id = 18, Title = "American Gods", ISBN = "9780380789030", PricePhysical = 16.50, PriceSoftcopy = 9.50, StockQuantity = 30, ImageLink = "https://m.media-amazon.com/images/I/91nKzUoR9LL.jpg", GenreId = 3 },
                new Book { Id = 19, Title = "The Way of Kings", ISBN = "9780765365279", PricePhysical = 35.00, PriceSoftcopy = 20.00, StockQuantity = 15, ImageLink = "https://m.media-amazon.com/images/I/91I06L1T2eL.jpg", GenreId = 3 },
                new Book { Id = 20, Title = "Mistborn", ISBN = "9780765350381", PricePhysical = 24.00, PriceSoftcopy = 12.00, StockQuantity = 40, ImageLink = "https://m.media-amazon.com/images/I/91U676J9OqL.jpg", GenreId = 3 },

                // 21-30: Business & Self-Help
                new Book { Id = 21, Title = "Atomic Habits", ISBN = "9780735211292", PricePhysical = 18.00, PriceSoftcopy = 12.00, StockQuantity = 150, ImageLink = "https://m.media-amazon.com/images/I/91bYsX41DVL.jpg", GenreId = 4 },
                new Book { Id = 22, Title = "Deep Work", ISBN = "9781455586691", PricePhysical = 17.00, PriceSoftcopy = 9.00, StockQuantity = 55, ImageLink = "https://m.media-amazon.com/images/I/417S9k6O6DL.jpg", GenreId = 4 },
                new Book { Id = 23, Title = "Sapiens", ISBN = "9780062316097", PricePhysical = 24.99, PriceSoftcopy = 14.99, StockQuantity = 70, ImageLink = "https://m.media-amazon.com/images/I/713jIoMO3UL.jpg", GenreId = 5 },
                new Book { Id = 24, Title = "Zero to One", ISBN = "9780804139298", PricePhysical = 21.00, PriceSoftcopy = 11.00, StockQuantity = 80, ImageLink = "https://m.media-amazon.com/images/I/71m-9S36SGL.jpg", GenreId = 4 },
                new Book { Id = 25, Title = "The Lean Startup", ISBN = "9780307887894", PricePhysical = 25.00, PriceSoftcopy = 15.00, StockQuantity = 50, ImageLink = "https://m.media-amazon.com/images/I/81-QB7nDh4L.jpg", GenreId = 4 },
                new Book { Id = 26, Title = "Rich Dad Poor Dad", ISBN = "9781612680194", PricePhysical = 14.00, PriceSoftcopy = 7.00, StockQuantity = 200, ImageLink = "https://m.media-amazon.com/images/I/81bsw6fnUiL.jpg", GenreId = 4 },
                new Book { Id = 27, Title = "The Psychology of Money", ISBN = "9780857197689", PricePhysical = 19.50, PriceSoftcopy = 10.00, StockQuantity = 100, ImageLink = "https://m.media-amazon.com/images/I/81Lb75rMSdL.jpg", GenreId = 4 },
                new Book { Id = 28, Title = "The 4-Hour Workweek", ISBN = "9780307465351", PricePhysical = 22.00, PriceSoftcopy = 11.00, StockQuantity = 40, ImageLink = "https://m.media-amazon.com/images/I/81qW97nxuNL.jpg", GenreId = 4 },
                new Book { Id = 29, Title = "Shoe Dog", ISBN = "9781501135910", PricePhysical = 18.00, PriceSoftcopy = 9.00, StockQuantity = 65, ImageLink = "https://m.media-amazon.com/images/I/8166D8+7SXL.jpg", GenreId = 5 },
                new Book { Id = 30, Title = "Influence", ISBN = "9780061241895", PricePhysical = 17.00, PriceSoftcopy = 8.50, StockQuantity = 35, ImageLink = "https://m.media-amazon.com/images/I/81vYkY9P69L.jpg", GenreId = 4 },

                // 31-40: Unique Mystery, Local, and Modern Titles (Shortened for brevity but unique)
                new Book { Id = 31, Title = "The Silent Patient", ISBN = "9781250301697", PricePhysical = 19.99, PriceSoftcopy = 11.00, StockQuantity = 110, ImageLink = "https://m.media-amazon.com/images/I/81JJ7fyyKyL.jpg", GenreId = 6 },
                new Book { Id = 32, Title = "Where the Crawdads Sing", ISBN = "9780735219090", PricePhysical = 15.00, PriceSoftcopy = 8.50, StockQuantity = 90, ImageLink = "https://m.media-amazon.com/images/I/81O1oy0y9eL.jpg", GenreId = 1 },
                new Book { Id = 33, Title = "The Alchemist", ISBN = "9780062315007", PricePhysical = 14.00, PriceSoftcopy = 7.00, StockQuantity = 150, ImageLink = "https://m.media-amazon.com/images/I/51Z906VNo9L.jpg", GenreId = 1 },
                new Book { Id = 34, Title = "Crazy Rich Asians", ISBN = "9780345803788", PricePhysical = 16.00, PriceSoftcopy = 9.00, StockQuantity = 80, ImageLink = "https://m.media-amazon.com/images/I/81WojU7Y7-L.jpg", GenreId = 1 },
                new Book { Id = 35, Title = "The Art of War", ISBN = "9781590302255", PricePhysical = 10.00, PriceSoftcopy = 4.00, StockQuantity = 200, ImageLink = "https://m.media-amazon.com/images/I/712K4PankpL.jpg", GenreId = 5 },
                new Book { Id = 36, Title = "Thinking, Fast and Slow", ISBN = "9780374533557", PricePhysical = 20.00, PriceSoftcopy = 10.00, StockQuantity = 40, ImageLink = "https://m.media-amazon.com/images/I/71f66SAnS9L.jpg", GenreId = 4 },
                new Book { Id = 37, Title = "Educated", ISBN = "9780399590504", PricePhysical = 18.00, PriceSoftcopy = 9.00, StockQuantity = 75, ImageLink = "https://m.media-amazon.com/images/I/81WojU7Y7-L.jpg", GenreId = 5 },
                new Book { Id = 38, Title = "Becoming", ISBN = "9781524763138", PricePhysical = 25.00, PriceSoftcopy = 12.50, StockQuantity = 60, ImageLink = "https://m.media-amazon.com/images/I/81h2gWcq95L.jpg", GenreId = 5 },
                new Book { Id = 39, Title = "The 7 Habits", ISBN = "9781982137274", PricePhysical = 16.00, PriceSoftcopy = 8.00, StockQuantity = 100, ImageLink = "https://m.media-amazon.com/images/I/71YV6Xo7+vL.jpg", GenreId = 4 },
                new Book { Id = 40, Title = "Shantaram", ISBN = "9780312330538", PricePhysical = 22.00, PriceSoftcopy = 11.00, StockQuantity = 30, ImageLink = "https://m.media-amazon.com/images/I/91M-vG6K8SL.jpg", GenreId = 1 }

            
            );
        }
    }
}
