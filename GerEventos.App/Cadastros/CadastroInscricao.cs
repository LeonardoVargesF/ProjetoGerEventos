using GerEventos.App.Base;
using GerEventos.App.Models;
using GerEventos.App.Outros;
using GerEventos.Domain.Base;
using GerEventos.Domain.Entities;
using GerEventos.Service.Validators;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerEventos.App.Cadastros
{
    public partial class CadastroInscricao : MaterialForm
    {
        private readonly IBaseService<Participante> _participanteService;
        private readonly IBaseService<EventoInscricao> _eventoinscricaoService;
        private readonly IBaseService<Evento> _eventoService;
        private readonly IBaseService<EventoPalestrante> _eventopalestranteService;

        protected bool IsAlteracao = false;

        private List<EventoInscricaoModel>? inscricoes;
        public CadastroInscricao(IBaseService<Participante> participanteService, IBaseService<Evento> eventoService)
        {
            _participanteService = participanteService;
            _eventoService = eventoService;
            //_eventoinscricaoService = eventoinscricaoService;
            InitializeComponent();
            CarregarCombo();
            CarregaEventos();
        }
        /*
        private void PreencheObjeto(EventoInscricao eventoInscricao)
        {
            eventoInscricao.Participante = cboParticipantes.ValueMember;

            eventoInscricao.Email = txtEmail.Text;

                
            var participante = _participanteService.GetById<Participante>(cboParticipantes.ValueMember);
            eventoInscricao.Participante = participante;

        }

        protected override void Salvar()
        {
            try
            {
                var eventoInscricao = new EventoInscricao();
                PreencheObjeto(eventoInscricao);

                    _eventoinscricaoService.Add<EventoInscricao, EventoInscricao, EventoInscricaoValidator>(eventoInscricao);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"GEREVENTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */


        private void CarregaEventos()
        {
            var eventos = _eventoService.Get<Evento>();
            foreach (var evento in eventos)
            {
                Outros.CaixadeEventos even = new Outros.CaixadeEventos();
                even.lblNomeEvento.Text = evento.Nome;
                even.lblDataEvento.Text = evento.DataEvento.ToString("dd/MM/yyyy HH:mm:ss");
                even.btnInscrever.Click += btn_inscrever_Click;
                even.btnCancelarInsc.Click += btn_cancelar_Click;

                flowLayoutEventos.Controls.Add(even);
            }
        }

        private void btn_inscrever_Click(object? sender, EventArgs e)
        {
            var post1 = (Evento)((System.Windows.Forms.Button)sender).Tag;
            //Salvar();      
        }

        private void btn_cancelar_Click(object? sender, EventArgs e)
        {

        }


        private void CarregarCombo()
        {
            cboParticipantes.ValueMember = "Id";
            cboParticipantes.DisplayMember = "Nome";
            cboParticipantes.DataSource = _participanteService.Get<ParticipanteModel>().ToList();
        }
    }
}
