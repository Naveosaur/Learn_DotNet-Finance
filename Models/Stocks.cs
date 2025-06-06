
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet.Models
{
    public class Stock
    {
        public int Id { get; set; }

        public string Symbol { get; set; } = string.Empty;

        public string CompanyName { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase { get; set; }

        [Column(TypeName = "decimal(18,2)")] 
        public decimal LastDividend { get; set; }

        public string Industry { get; set; } = string.Empty;

        public long MarketCap { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public List<Comment> Comment { get; set; } = new List<Comment>();
    }
}