﻿using Cursos.Domain.Entities;

namespace Cursos.Domain
{
    public class Aluno : Base
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
}
