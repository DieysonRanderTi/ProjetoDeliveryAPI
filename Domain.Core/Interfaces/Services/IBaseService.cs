
using Domain.Core.Interfaces.Repositorys;

namespace Domain.Core.Interfaces.Services
{
    public interface IBaseService<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
    }
}
