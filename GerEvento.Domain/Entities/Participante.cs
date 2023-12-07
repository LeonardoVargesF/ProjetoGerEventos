using GerEventos.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerEventos.Domain.Entities
{
    public class Participante : BaseEntity<int>
    {
        public Participante()
        {

        }

        public Participante(int id, string? nome, string? email, string? cpf, Cidade? cidade, string? telefone) : base(id)
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
            Cidade = cidade;
            Telefone = telefone;
        }

        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? CPF { get; set; }
        public string? Telefone { get; set; }
        public Cidade? Cidade { get; set; }
    }
}

