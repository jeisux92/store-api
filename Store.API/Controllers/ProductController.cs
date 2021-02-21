using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store.Models.Entities;
using Store.Services;

namespace Store.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService) => _productService = productService;


        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _productService.GetProductAsync(id));
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _productService.GetAllProductAsync());
        }


        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {
            if (!await _productService.ProductExistsAsync(product.Id))
            {
                return BadRequest("Customer is already created");
            }
            else
            {
                await _productService.CreateProductAsync(product);
                return Ok();
            }
        }
    }
}