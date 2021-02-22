using System.Data;
using System.Threading.Tasks;
using Dapper;
using Store.Models.Entities;

namespace Store.Repositories.Implementation
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IDbConnection connection) : base(connection)
        {
        }

        public override async Task<int> CreateAsync(Product entity)
        {
            var parameters = new
            {
                entity.Name,
                entity.UnitValue
            };
            return await _connection.ExecuteAsync($"ProductCreate", parameters, commandType: CommandType.StoredProcedure);
        }
    }
}