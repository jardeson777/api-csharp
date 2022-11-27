using Cursos.Domain.Core.Interfaces.Repositories;
using Cursos.Domain.Core.Interfaces.Services;

namespace Cursos.Domain.Services
{
    public class ServiceAluno : ServiceBase<Aluno>, IServiceAluno
    {
        private readonly IRepositoryAluno repository;
        public ServiceAluno(IRepositoryAluno repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
