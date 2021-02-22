using Store.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Repositories
{
    public interface IBillRepository : IBaseRepository<Bill>
    {
        Task<IEnumerable<Bill>> GetBySaleIdAsync(int id);
        void Create(IEnumerable<Bill> bills);
    }
}
