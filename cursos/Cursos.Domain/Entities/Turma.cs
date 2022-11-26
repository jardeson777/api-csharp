using Cursos.Domain.Entities;

namespace Cursos.Domain
{
    public class Turma : Base
    {
        public string Numero { get; set; }
        public string AnoLetivo { get; set; }
    }
}
