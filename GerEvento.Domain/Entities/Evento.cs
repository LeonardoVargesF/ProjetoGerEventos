using GerEventos.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerEventos.Domain.Entities
{
    public class Evento : BaseEntity<int>
    {
        public Evento()
        {
            Palestrantes = new List<EventoPalestrante>();
            Participantes = new List<EventoInscricao>();
        }

        public Evento(int id, string? nome, DateTime dataEvento, string? descricao, int tempoDuracao, string? endereco, Cidade? cidade, List<EventoPalestrante> palestrantes, List<EventoInscricao> participantes) : base(id)
        {
            Nome = nome;
            DataEvento = dataEvento;
            Descricao = descricao;
            TempoDuracao = tempoDuracao;
            Endereco = endereco;
            Cidade = cidade;
            Palestrantes = palestrantes;
            Participantes = participantes;
        }

        public string? Nome { get; set; }
        public DateTime DataEvento { get; set; }
        public string? Descricao { get; set; }
        public int TempoDuracao { get; set; }
        public string? Endereco { get; set; }
        public Cidade? Cidade { get; set; }
        public List<EventoPalestrante> Palestrantes { get; set; }
        public List<EventoInscricao> Participantes { get; set; }
    }

    public class EventoInscricao : BaseEntity<int>
    {
        public EventoInscricao()
        {

        }

        public EventoInscricao(int id, DateTime dataInscricao, Evento? evento, Participante? participante) : base(id)
        {
            DataInscricao = dataInscricao;
            Evento = evento;
            Participante = participante;
        }

        public DateTime DataInscricao { get; set; }
        public Evento? Evento { get; set; }
        public Participante? Participante { get; set; }
    }


}
