using Cursos.Domain;
using Cursos.Domain.Core.Interfaces.Repositories;

namespace Cursos.Infra.Data.Repositories
{
    public class RepositoryAluno : RepositoryBase<Aluno>, IRepositoryAluno
    {
        private readonly SqlContext sqlContext;

        public RepositoryAluno(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}