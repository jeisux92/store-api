using System.Data;
using System.Threading.Tasks;
using Dapper;

namespace Store.Repositories.Implementation
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly IDbConnection _connection;

        protected BaseRepository(IDbConnection connection)
        {
            _connection = connection;
        }


        public virtual async Task<T> GetByIdAsync<TU>(TU id) =>
            await _connection.QueryFirstOrDefaultAsync<T>($"{typeof(T).Name}GetById", new
            {
                @Id = id
            }, commandType: CommandType.StoredProcedure);

        public virtual async Task CreateAsync(T entity) =>
            await _connection.ExecuteAsync($"{nameof(T)}.Create", entity);


        public virtual async Task DeleteAsync<TU>(TU id) =>
            await _connection.ExecuteAsync($"{nameof(T)}.Delete", new
            {
                id
            });

        public virtual async Task EditAsync(T entity) =>
            await _connection.ExecuteAsync($"{nameof(T)}.Edit", entity);
    }
}