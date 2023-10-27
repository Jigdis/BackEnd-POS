using POS.Application.Interface.Interface;
using POS.Persistence.Context;

namespace POS.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork
        (
            ApplicationDbContext context
        )
        {
            _context = context;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
