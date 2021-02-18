using System.Data;
using Store.Models.Entities;

namespace Store.Repositories.Implementation
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IDbConnection connection) : base(connection)
        {
        }
    }
}