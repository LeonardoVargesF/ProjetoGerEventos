using GerEventos.App.Base;
using GerEventos.App.Models;
using GerEventos.App.Outros;
using GerEventos.Domain.Base;
using GerEventos.Domain.Entities;
using GerEventos.Service.Validators;
using Microsoft.Extensions.Logging;
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
using System.Xml.Linq;

namespace GerEventos.App.Cadastros
{
    public partial class CadastroPalestranteEvento : MaterialForm
    {
        private readonly IBaseService<Palestrante> _palestranteService;
        private readonly IBaseService<EventoPalestrante> _eventopalestranteService;
        private readonly IBaseService<Evento> _eventoService;

        protected bool IsAlteracao = false;

        public CadastroPalestranteEvento(IBaseService<Palestrante> palestranteService, IBaseService<Evento> eventoService, IBaseService<EventoPalestrante> eventopalestranteService)
        {
            _palestranteService = palestranteService;
            _eventoService = eventoService;
            _eventopalestranteService = eventopalestranteService;
            InitializeComponent();
            CarregarCombo();
            CarregaEventos();
        }

        private void CarregaEventos()
        {
            var eventos = _eventoService.Get<Evento>();
            foreach (var evento in eventos)
            {
                Outros.CaixadeEventos even = new Outros.CaixadeEventos();
                even.lblNomeEvento.Text = evento.Nome;
                even.lblDataEvento.Text = evento.DataEvento.ToString("dd/MM/yyyy HH:mm:ss");
                even.lblIdEvento.Text = evento.Id.ToString();
                even.btnInscrever.Tag = evento.Id.ToString();
                even.btnInscrever.Click += btn_inscrever_Click;
                even.btnCancelarInsc.Click += btn_cancelar_Click;

                flowLayoutEventos.Controls.Add(even);
            }
        }

        private void btn_inscrever_Click(object? sender, EventArgs e)
        {
            int.TryParse(txtDuracao.Text, out var duracao);

            int.TryParse(cboPalestrantes.SelectedValue.ToString(), out var idGrupo);
            var palestrante = _palestranteService.GetById<Palestrante>(idGrupo);

            int.TryParse(((MaterialButton)sender).Tag.ToString(), out var id);

            var inscricao = new EventoPalestrante()
            {
                TituloPalestra = txtTitulo.Text,
                TempoDuracao = duracao,
                Evento = new Evento() { Id = id },
                Palestrante = palestrante,

            };
            _eventopalestranteService.Add<EventoPalestrante, EventoPalestrante, EventoPalestranteValidator>(inscricao);

        }

        private void btn_cancelar_Click(object? sender, EventArgs e)
        {

        }


        private void CarregarCombo()
        {
            cboPalestrantes.ValueMember = "Id";
            cboPalestrantes.DisplayMember = "Nome";
            cboPalestrantes.DataSource = _palestranteService.Get<PalestranteModel>().ToList();
        }
    }
}

