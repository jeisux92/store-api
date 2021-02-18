using System.Threading.Tasks;
using Store.Models.Entities;

namespace Store.Services
{
    public interface ICustomerService
    {
        Task<Customer> GetCustomerAsync(int id);
    }
}