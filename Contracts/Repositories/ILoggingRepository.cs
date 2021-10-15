using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Contracts.Repositories
{
    public interface ILoggingRepository
    {
        Task SaveAsync(Logging logging);
    }
}
