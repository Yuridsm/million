using System.Threading.Tasks;

namespace TodoApi.DataModel.UnitOfWork {
    public interface IUnitOfWork
    {
        Task Commit();
        Task Rollback();
    }
}

