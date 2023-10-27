using POS.Application.Interface.Interface;
using POS.Persistence.Context;
using Dapper;
using System.Data;

namespace POS.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync(string storeProcedure)
        {
            using var connection = _context.CreateConnection;
            return await connection.QueryAsync<T>(storeProcedure, commandType: CommandType.StoredProcedure);
        }

        public async Task<T> GetByIdAsync(string storeProcedure, object parameter)
        {
            using var connection = _context.CreateConnection;
            var objParam = new DynamicParameters(parameter);
            return await connection
                .QuerySingleOrDefaultAsync<T>(storeProcedure, param: objParam, commandType: CommandType.StoredProcedure);
        }

        public async Task<bool> ExcecAsync(string storeProcedure, object parameters)
        {
            using var connection = _context.CreateConnection;
            var objParams = new DynamicParameters(parameters);

            var recordsAffected = await connection
                .ExecuteAsync(storeProcedure, param: objParams, commandType: CommandType.StoredProcedure);

            return recordsAffected > 0;
        }
    }
}
