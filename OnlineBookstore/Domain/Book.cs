namespace OnlineBookstore.Domain
{
    public class Book : BaseDomainModel
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public string? ISBM { get; set; }
        public decimal Price { get; set; }
        public int StockCount { get; set; }
    }
}
