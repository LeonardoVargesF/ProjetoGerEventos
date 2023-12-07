﻿using GerEventos.App.Base;
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
    public partial class CadastroInscricao : MaterialForm
    {
        private readonly IBaseService<Participante> _participanteService;
        private readonly IBaseService<EventoInscricao> _eventoinscricaoService;
        private readonly IBaseService<Evento> _eventoService;

        protected bool IsAlteracao = false;

        public CadastroInscricao(IBaseService<Participante> participanteService, IBaseService<Evento> eventoService, IBaseService<EventoInscricao> eventoinscricaoService)
        {
            _participanteService = participanteService;
            _eventoService = eventoService;
            _eventoinscricaoService = eventoinscricaoService;
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

            int.TryParse(cboParticipantes.SelectedValue.ToString(), out var idGrupo);
            var participante = _participanteService.GetById<Participante>(idGrupo);

            int.TryParse(((MaterialButton)sender).Tag.ToString(), out var id);

            var inscricao = new EventoInscricao()
            {
                DataInscricao = DateTime.Now,
                Evento = new Evento() {Id = id},
                Participante = participante
        };
            _eventoinscricaoService.Add<EventoInscricao, EventoInscricao, EventoInscricaoValidator>(inscricao);

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
