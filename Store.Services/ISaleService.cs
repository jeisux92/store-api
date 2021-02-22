using Store.Models.DTO;
using Store.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Services
{
    public interface ISaleService
    {
        Task CreateSaleAsync(long customerId, Dictionary<int,int> products);
        Task<Sale> GetSaleAsync(int id);
        Task<IEnumerable<SaleCustomerDto>> GetAllSaleAsync();
        Task<IEnumerable<Bill>> GetAllBillAsync(int id);
    }
}
