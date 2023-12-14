using GerEventos.Domain.Base;
using GerEventos.Domain.Entities;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerEventos.App.Outros
{
    public partial class Relatorio : MaterialForm
    {
        private readonly IBaseService<EventoInscricao> _eventoinscricaoService;
        private readonly IBaseService<EventoPalestrante> _eventopalestranteService;
        public Relatorio(IBaseService<EventoInscricao> eventoinscricaoService, IBaseService<EventoPalestrante> eventopalestranteService)
        {
            _eventoinscricaoService = eventoinscricaoService;
            _eventopalestranteService = eventopalestranteService;
            InitializeComponent();
            CarregaEventos();
            CarregaEventos2();
        }

        private void CarregaEventos()
        {
            var inscricoes = _eventoinscricaoService.Get<EventoInscricao>(new List<string>() { "Evento", "Participante" }).OrderBy(x => x.Evento.Id);
            foreach (var inscricao in inscricoes)
            {
                CaixadeInscricao even = new CaixadeInscricao();
                even.lblNomeEvento.Text = inscricao.Evento.Nome;
                even.lblDataEvento.Text = inscricao.Evento.DataEvento.ToString("dd/MM/yyyy HH:mm:ss");
                even.lblNome.Text = "Participante: " + inscricao.Participante.Nome;

                flowLayoutParticipante.Controls.Add(even);
            }
        }

        private void CarregaEventos2()
        {
            var inscricoes = _eventopalestranteService.Get<EventoPalestrante>(new List<string>() { "Evento", "Palestrante" }).OrderBy(x => x.Evento.Id);
            foreach (var inscricao in inscricoes)
            {
                CaixadeInscricao even = new CaixadeInscricao();
                even.lblNomeEvento.Text = inscricao.Evento.Nome;
                even.lblDataEvento.Text = inscricao.Evento.DataEvento.ToString("dd/MM/yyyy HH:mm:ss");
                even.lblNome.Text = "Palestrante: " + inscricao.Palestrante.Nome;

                flowLayoutPalestrante.Controls.Add(even);
            }
        }
    }
}
