using System.Threading.Tasks;
using TodoApi.DataModel;
using TodoApi.Contracts.Repositories;
using TodoApi.Models;

namespace TodoApi.Repositories
{
    public class LoggingRepository : ILoggingRepository
    {
        private readonly DbContextInMemory _context;

        public LoggingRepository(DbContextInMemory contextApplication)
        {
            _context = contextApplication;
        }

        public async Task SaveAsync(Logging logging)
        {
            await _context.Loggings.AddAsync(logging);
            await _context.SaveChangesAsync();
        }
    }
}
