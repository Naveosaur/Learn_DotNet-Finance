namespace dotnet.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int? StockId { get; set; }

        // Navigational property for the Stock entity
        public Stocks? Stock { get; set; }
    }
}
