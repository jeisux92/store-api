using System.Collections.Generic;
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
        public async Task<IEnumerable<Customer>> GetAllCustomerAsync() => await _customerRepository.GetAllAsync();

        public async Task<bool> CustomerExistsAsync(int customerId)
        {
            Customer customer = await GetCustomerAsync(customerId);
            return customer is null;
        }

        public async Task CreateCustomerAsync(Customer customer) =>
            await _customerRepository.CreateAsync(customer);
    }
}