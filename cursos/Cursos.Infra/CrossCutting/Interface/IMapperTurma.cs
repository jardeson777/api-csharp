using Cursos.Application.Dtos;
using Cursos.Domain;
using System.Collections.Generic;

namespace Cursos.Infra.CrossCutting.Interface
{
    public interface IMapperTurma
    {
        Turma MapperDtoToEntity(TurmaDto turmaDto);

        IEnumerable<TurmaDto> MapperListTurmasDto(IEnumerable<Turma> turmas);

        TurmaDto MapperEntityToDto(Turma turma);
    }
}
