using System.Collections.Generic;
using System.Threading.Tasks;
using Store.Models.Entities;
using Store.Repositories;

namespace Store.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> GetProductAsync(int id) => await _productRepository.GetByIdAsync(id);

        public async Task<IEnumerable<Product>> GetAllProductAsync() => await _productRepository.GetAllAsync();

        public async Task<bool> ProductExistsAsync(int productId)
        {
            Product product = await GetProductAsync(productId);
            return product is null;
        }

        public async Task CreateProductAsync(Product product) => await _productRepository.CreateAsync(product);
    }
}