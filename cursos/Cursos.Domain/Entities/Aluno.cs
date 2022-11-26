using Cursos.Domain.Entities;

namespace Cursos.Domain
{
    public class Aluno : Base
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
}
