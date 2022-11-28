using Cursos.Application.Dtos;
using Cursos.Domain;
using System.Collections.Generic;

namespace Cursos.Infra.CrossCutting.Interface
{
    public interface IMapperAluno
    {
        Aluno MapperDtoToEntity(AlunoDto alunoDto);

        IEnumerable<AlunoDto> MapperListAlunosDto(IEnumerable<Aluno> alunos);

        AlunoDto MapperEntityToDto(Aluno aluno);
    }
}
