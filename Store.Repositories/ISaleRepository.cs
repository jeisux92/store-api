using Store.Models.DTO;
using Store.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Repositories
{
    public interface ISaleRepository : IBaseRepository<Sale>
    {
        Task<IEnumerable<SaleCustomerDto>> GetAllWithCustomerAsync();
    }
}
