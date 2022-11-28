using Cursos.Application.Dtos;
using Cursos.Domain;
using Cursos.Infra.CrossCutting.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursos.Infra.CrossCutting.Mapper
{
    public class MapperAluno : IMapperAluno
    {
        IEnumerable<AlunoDto> alunosDto = new List<AlunoDto>();
        public Aluno MapperDtoToEntity(AlunoDto alunoDto)
        {
            Aluno aluno = new Aluno()
            { 
                Id = alunoDto.Id,
                Cpf = alunoDto.Cpf,
                Email = alunoDto.Email,
                Name = alunoDto.Name
            };

            return aluno;
        }

        public AlunoDto MapperEntityToDto(Aluno aluno)
        {
            AlunoDto alunoDto = new AlunoDto() 
            {
                Id = aluno.Id,
                Name = aluno.Name,
                Email = aluno.Email,
                Cpf = aluno.Cpf
            };

            return alunoDto;
        }

        public IEnumerable<AlunoDto> MapperListAlunosDto(IEnumerable<Aluno> alunos)
        {
            IEnumerable<AlunoDto> alunosDto = alunos.Select(aluno => new AlunoDto 
            {
                Id = aluno.Id,
                Cpf = aluno.Cpf,
                Email = aluno.Email,
                Name = aluno.Name
            }
            );

            return alunosDto;
        }
    }
}
