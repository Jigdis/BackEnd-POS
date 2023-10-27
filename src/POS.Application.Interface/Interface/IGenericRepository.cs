using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Application.Interface.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(string storeProcedure);
        Task<T> GetByIdAsync(string storeProcedure, object parameter);
        Task<bool> ExcecAsync(string storeProcedure, object parameters);
    }
}
