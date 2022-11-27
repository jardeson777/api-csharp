using Cursos.Domain;
using Cursos.Domain.Core.Interfaces.Repositories;

namespace Cursos.Infra.Data.Repositories
{
    public class RepositoryTurma : RepositoryBase<Turma>, IRepositoryTurma
    {
        private readonly SqlContext sqlContext;

        public RepositoryTurma(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
