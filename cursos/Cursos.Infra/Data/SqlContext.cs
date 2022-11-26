using Cursos.Domain;
using Microsoft.EntityFrameworkCore;

namespace Cursos.Infra.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext() { }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Aluno> MyProperty { get; set; }
    }
}
