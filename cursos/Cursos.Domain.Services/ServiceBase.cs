using Cursos.Domain.Core.Interfaces.Repositories;
using Cursos.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace Cursos.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Add(TEntity obj)
        {
            this.repository.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return this.repository.GetById(id);
        }
        public void Remove(TEntity obj)
        {
            this.repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            this.repository.Update(obj);
        }
    }
}
