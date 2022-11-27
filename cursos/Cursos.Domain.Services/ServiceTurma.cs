using Cursos.Domain.Core.Interfaces.Repositories;
using Cursos.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursos.Domain.Services
{
    public class ServiceTurma : ServiceBase<Turma>, IServiceTurma
    {
        private readonly IRepositoryTurma repository;
        public ServiceTurma(IRepositoryTurma repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
