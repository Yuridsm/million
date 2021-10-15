using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Contracts.Repositories
{
    public interface IProductRepository
    {
        Task SaveAsync(Product product);
    }
}
