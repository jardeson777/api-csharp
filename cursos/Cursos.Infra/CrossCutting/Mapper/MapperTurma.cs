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
    public class MapperTurma : IMapperTurma
    {
        public Turma MapperDtoToEntity(TurmaDto turmaDto)
        {
            Turma turma= new Turma()
            {
                Id = turmaDto.Id,
                AnoLetivo = turmaDto.AnoLetivo,
                Numero = turmaDto.Numero
            };

            return turma;
        }

        public TurmaDto MapperEntityToDto(Turma turma)
        {
            TurmaDto turmaDto = new TurmaDto()
            { 
                Id = turma.Id,
                Numero = turma.Numero,
                AnoLetivo = turma.AnoLetivo
            };

            return turmaDto;
        }

        public IEnumerable<TurmaDto> MapperListTurmasDto(IEnumerable<Turma> turmas)
        {
            IEnumerable<TurmaDto> turmasDto = turmas.Select(turma => new TurmaDto { 
                Id = turma.Id,
                AnoLetivo = turma.AnoLetivo,
                Numero = turma.Numero
            });

            return turmasDto;
        }
    }
}
