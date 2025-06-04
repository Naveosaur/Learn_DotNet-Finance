using dotnet.Data;
using dotnet.Dto.Stock;
using dotnet.Mappers;
using Learn_DotNet_Finance.Dto.Stock;
using Learn_DotNet_Finance.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Learn_DotNet_Finance.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IStockRepository _stockRepo;
        public StockController(ApplicationDBContext context, IStockRepository stockRepo)
        {
            _stockRepo = stockRepo;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStocks()
        {
            var stock = await _stockRepo.GetAllAsync();
            var stockDto = stock.Select(s => s.ToStocksDto());

            return Ok(stockDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStockById([FromRoute] int id)
        {
            var stock = await _stockRepo.GetByIdAsync(id);

            if (stock == null)
            {
                return NotFound();
            }       

            return Ok(stock.ToStocksDto());
        }


        [HttpPost]
        public async Task<IActionResult> CreateStock([FromBody] CreateStockRequestDto stockDto)
        {
            var stock = stockDto.ToStock();
            await _stockRepo.CreateAsync(stock);
            return CreatedAtAction(nameof(GetStockById), new { id = stock.Id }, stock.ToStocksDto());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateStock([FromRoute] int id, [FromBody]  UpdateStockRequestDto updateDto)
        {
            var stock = await _stockRepo.UpdateAsync(id, updateDto);

            if (stock == null)
            {
                return NotFound();
            }

            await _context.SaveChangesAsync();

            return Ok(stock.ToStocksDto());

        }


        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteStock([FromRoute] int id)
        {
            var stock = await _stockRepo.DeleteAsync(id);

            if (stock == null)
            {
                return NotFound();
            }

           
            return NoContent();
        }

    }
}
 