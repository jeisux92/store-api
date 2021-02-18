using System.Threading.Tasks;
using Store.Models.Entities;
using Store.Repositories;

namespace Store.Services.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository) => _customerRepository = customerRepository;

        public async Task<Customer> GetCustomerAsync(int id) => await _customerRepository.GetByIdAsync(id);
    }
}