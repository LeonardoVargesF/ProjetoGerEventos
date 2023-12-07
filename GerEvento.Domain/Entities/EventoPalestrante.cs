using GerEventos.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerEventos.Domain.Entities
{
    public class EventoPalestrante : BaseEntity<int>
    {
        public EventoPalestrante()
        {

        }

        public EventoPalestrante(int id, string? tituloPalestra, int tempoDuracao, Evento? evento, Palestrante? palestrante) : base(id)
        {
            TituloPalestra = tituloPalestra;
            TempoDuracao = tempoDuracao;
            Evento = evento;
            Palestrante = palestrante;
        }

        public string? TituloPalestra { get; set; }
        public int TempoDuracao { get; set; }
        public Evento? Evento { get; set; }
        public Palestrante? Palestrante { get; set; }
    }
}