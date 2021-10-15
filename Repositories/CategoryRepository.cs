using System.Threading.Tasks;
using TodoApi.DataModel;
using TodoApi.Contracts.Repositories;
using TodoApi.Models;
using TodoApi.DataModel.UnitOfWork;

namespace TodoApi.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DbContextPostgreSQL _context;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryRepository(DbContextPostgreSQL contextApplication, IUnitOfWork unitOfWork)
        {
            _context = contextApplication;
            _unitOfWork = unitOfWork;
        }

        public async Task SaveAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _unitOfWork.Commit();
        }
    }
}
