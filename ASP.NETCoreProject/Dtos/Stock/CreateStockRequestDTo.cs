
namespace ASP.NETCoreProject.Dtos.Stock
{
    public class CreateStockRequestDTO
    {
        public string Symbol { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;

        public decimal Purchase { get; set; }
        public decimal LastDiv { get; set; }

        public string Industry { get; set; } = string.Empty;

        public long MarketCap { get; set; }
    }
}
