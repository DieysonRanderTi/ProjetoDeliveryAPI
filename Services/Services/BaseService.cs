using Domain.Core.Interfaces.Repositories;
using Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace Services.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repositoryBase;

        public BaseService(IBaseRepository<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void Add(TEntity obj)
        {
            _repositoryBase.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repositoryBase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _repositoryBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _repositoryBase.Update(obj);
        }
    }
}