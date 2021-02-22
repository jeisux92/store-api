using System.Data;
using System.Threading.Tasks;
using Dapper;
using Store.Models.Entities;

namespace Store.Repositories.Implementation
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDbConnection connection) : base(connection)
        {
        }


        public override async Task<int> CreateAsync(Customer entity)
        {
            var parameters = new
            {
                Name = entity.Name,
                Phone = entity.Phone,
                IdentificationNumber = entity.IdentificationNumber,
                LastName = entity.LastName
            };
            return await _connection.ExecuteAsync($"CustomerCreate", parameters, commandType: CommandType.StoredProcedure);
        }
    }
}