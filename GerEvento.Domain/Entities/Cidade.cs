﻿using GerEventos.Domain.Base;

namespace GerEventos.Domain.Entities
{
    public class Cidade : BaseEntity<int>
    {
        public Cidade()
        {

        }

        public Cidade(int id, string? nome, string? estado) : base(id)
        {
            Nome = nome;
            Estado = estado;
        }

        public string? Nome { get; set; }
        public string? Estado { get; set; }
    }
}
