using GerEventos.Domain.Entities;

namespace GerEventos.App.Models
{
    internal class EventoModel
    {
        public EventoModel()
        {
            Palestrantes = new List<EventoPalestranteModel>();
            Participantes = new List<EventoInscricaoModel>();
        }
        public int Id { get; set; }
        public string? Nome { get; set; }
        public DateTime DataEvento { get; set; }
        public string? Endereco { get; set; }
        public string? Descricao { get; set; }
        public string? TempoDuracao { get; set; }
        public int IdCidade { get; set; }
        public string? Cidade { get; set; }
        public List<EventoPalestranteModel> Palestrantes { get; set; }
        public List<EventoInscricaoModel> Participantes { get; set; }
    }

    public class EventoInscricaoModel
    {
        public int Id { get; set; }
        public DateTime DataInscricao { get; set; }
        public int IdEvento { get; set; }
        public string? Evento { get; set; }
        public int idParticipante { get; set; }
        public string? Participante { get; set; }
    }

}
