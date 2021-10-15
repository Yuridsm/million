using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Contracts.Repositories
{
    public interface ICategoryRepository
    {
        Task SaveAsync(Category category);
    }
}
