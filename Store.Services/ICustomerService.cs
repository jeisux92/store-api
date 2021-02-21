using System.Collections.Generic;
using System.Threading.Tasks;
using Store.Models.Entities;

namespace Store.Services
{
    public interface ICustomerService
    {
        Task<Customer> GetCustomerAsync(int id);
        Task<IEnumerable<Customer>> GetAllCustomerAsync();
        Task<bool> CustomerExistsAsync(int customerId);
        Task CreateCustomerAsync(Customer customer);
    }
}