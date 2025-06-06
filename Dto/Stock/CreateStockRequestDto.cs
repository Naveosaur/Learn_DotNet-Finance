namespace Learn_DotNet_Finance.Dto.Stock
{
    public class CreateStockRequestDto
    {
        
        public string Symbol { get; set; } = string.Empty;

        public string CompanyName { get; set; } = string.Empty;

        public decimal Purchase { get; set; }

        public decimal LastDividend { get; set; }

        public string Industry { get; set; } = string.Empty;

        public long MarketCap { get; set; }

        
    }
}