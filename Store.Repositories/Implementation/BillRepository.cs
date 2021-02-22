using Dapper;
using Store.Models.Entities;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Linq;

namespace Store.Repositories.Implementation
{
    public class BillRepository : BaseRepository<Bill>, IBillRepository
    {
        public BillRepository(IDbConnection connection) : base(connection)
        {
        }

        public void Create(IEnumerable<Bill> bills)
        {
            var parameters = bills.Select(x => new
            {
                x.ProductId,
                x.Quantity,
                x.SaleId
            });
            foreach (var item in parameters)
            {
                _connection.Execute("BillCreate", item, commandType: CommandType.StoredProcedure);
            }
        }

        public Task<IEnumerable<Bill>> GetBySaleIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
