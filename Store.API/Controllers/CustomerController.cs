using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store.Services;

namespace Store.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _customerService.GetCustomerAsync(id));
        }
    }
}