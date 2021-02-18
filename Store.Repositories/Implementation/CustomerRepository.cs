using System.Data;
using Store.Models.Entities;

namespace Store.Repositories.Implementation
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDbConnection connection) : base(connection)
        {
        }
    }
}