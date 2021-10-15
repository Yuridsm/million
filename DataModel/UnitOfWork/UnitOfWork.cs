using System.Threading.Tasks;

namespace TodoApi.DataModel.UnitOfWork {
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContextPostgreSQL _context;

        public UnitOfWork(DbContextPostgreSQL context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        public Task Rollback()
        {
            // Do nothing here
            return Task.Run(() => {});
        }
    }
}

