using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store.Models.Entities;
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
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _customerService.GetAllCustomerAsync());
        }


        [HttpPost]
        public async Task<IActionResult> Post(Customer customer)
        {
            if (!await _customerService.CustomerExistsAsync(customer.Id))
            {
                return BadRequest("Customer is already created");
            }
            else
            {
                await _customerService.CreateCustomerAsync(customer);
                return Ok();
            }
        }
    }
}