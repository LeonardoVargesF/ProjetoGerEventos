using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerEventos.App.Models
{
    internal class EventoPalestranteModel
    {
        public int Id { get; set; }
        public string? TituloPalestra { get; set; }
        public int TempoDuracao { get; set; }
        public int IdEvento { get; set; }
        public string? Evento { get; set; }
        public int idPalestrante { get; set; }
        public string? Palestrante { get; set; }
    }
}
