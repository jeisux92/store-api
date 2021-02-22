using System.Collections.Generic;
using System.Threading.Tasks;
using Store.Models.Entities;

namespace Store.Services
{
    public interface IProductService
    {
        Task<Product> GetProductAsync(int id);
        Task<IEnumerable<Product>> GetAllProductAsync();
        Task<bool> ProductExistsAsync(int productId);
        Task CreateProductAsync(Product product);
    }
}