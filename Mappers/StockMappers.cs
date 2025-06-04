using dotnet.Models;
using dotnet.Dto.Stock;
using Learn_DotNet_Finance.Dto.Stock;

namespace dotnet.Mappers
{
    public static class StockMappers
    {
        public static StocksDto ToStocksDto(this Stock stockModel)
        {
            return new StocksDto
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Purchase = stockModel.Purchase, 
                LastDividend = stockModel.LastDividend,
                Industry = stockModel.Industry,
                MarketCap = stockModel.MarketCap,
            };
        }



    public static Stock ToStock(this CreateStockRequestDto stockDto) {
        return new Stock {
            Symbol = stockDto.Symbol,
            CompanyName = stockDto.CompanyName,
            Purchase = stockDto.Purchase,
            LastDividend = stockDto.LastDividend,
            Industry = stockDto.Industry,
            MarketCap = stockDto.MarketCap,
        };
    }
}
}