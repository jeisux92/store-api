using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetByIdAsync<TU>(TU id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<int> CreateAsync(T entity);
        Task DeleteAsync<TU>(TU id);
        Task EditAsync(T entity);
    }
}