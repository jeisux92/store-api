

using Microsoft.AspNetCore.Mvc;
using Store.API.ViewModels;
using Store.Services;
using System.Linq;
using System.Threading.Tasks;

namespace Store.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SaleController : Controller
    {
        private readonly ISaleService _saleService;

        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()=>
            Ok(await _saleService.GetAllSaleAsync());
        


        [HttpPost]
        public async Task<IActionResult> Post(SaleViewModel sale)
        {
            await _saleService.CreateSaleAsync(sale.IdentificationNumber, sale.Sale.ToDictionary(x => x.ProductId, x => x.Quantity));
            return Ok();
        }


        [HttpGet("{id}/bills")]
        public async Task<IActionResult> GetBills(int id) =>
            Ok(await _saleService.GetAllBillAsync(id));

    }
}