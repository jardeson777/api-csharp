using Cursos.Application.Dtos;
using System.Collections.Generic;

namespace Cursos.Application.Inferfaces
{
    public interface IApplicationServiceAluno
    {
        public void Add(AlunoDto alunoDto);
        public void Update(AlunoDto alunoDto);
        public void Remove(AlunoDto alunoDto);
        public IEnumerable<AlunoDto> GetAll();
        public AlunoDto GetById(int id);
    }
}
