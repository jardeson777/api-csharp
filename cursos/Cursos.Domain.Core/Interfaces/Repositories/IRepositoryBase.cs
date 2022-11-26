using System.Collections.Generic;

namespace Cursos.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntitie> where TEntitie : class
    {
        void Add(TEntitie obj);
        void Update(TEntitie obj);
        void Remove(TEntitie obj);
        IEnumerable<TEntitie> GetAll();
        TEntitie GetById(int id);
    }
}
