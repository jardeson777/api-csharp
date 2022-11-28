using Cursos.Application.Dtos;
using System.Collections.Generic;

namespace Cursos.Application.Inferfaces
{
    public interface IApplicationServiceTurma
    {
        public void Add(TurmaDto turmaDto);
        public void Update(TurmaDto turmaDto);
        public void Remove(TurmaDto turmaDto);
        public IEnumerable<TurmaDto> GetAll();
        public TurmaDto GetById(int id);
    }
}
