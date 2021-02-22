using Dapper;
using Store.Models.DTO;
using Store.Models.Entities;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Store.Repositories.Implementation
{
    public class SaleRepository : BaseRepository<Sale>, ISaleRepository
    {
        public SaleRepository(IDbConnection connection) : base(connection)
        {
        }


        public override async Task<int> CreateAsync(Sale entity)
        {
            var parameters = new
            {
                entity.CustomerId,
                entity.Total
            };
            return await _connection.ExecuteAsync($"SaleCreate", parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<SaleCustomerDto>> GetAllWithCustomerAsync()=>
            await _connection.QueryAsync<SaleCustomerDto>($"SaleWithCustomerGetAll",
                commandType: CommandType.StoredProcedure);
        
    }
}
