using GerEventos.App.Base;
using GerEventos.App.Models;
using GerEventos.Domain.Base;
using GerEventos.Domain.Entities;
using GerEventos.Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerEventos.App.Cadastros
{
    public partial class CadastroEvento : CadastroBase
    {
        private readonly IBaseService<Evento> _eventoService;
        private readonly IBaseService<Cidade> _cidadeService;

        private List<EventoModel>? eventos;

        public CadastroEvento(IBaseService<Evento> eventoService, IBaseService<Cidade> cidadeService)
        {
            _eventoService = eventoService;
            _cidadeService = cidadeService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboCidade.ValueMember = "Id";
            cboCidade.DisplayMember = "NomeEstado";
            cboCidade.DataSource = _cidadeService.Get<CidadeModel>().ToList();
        }

        private void PreencheObjeto(Evento evento)
        {
            evento.Nome = txtNome.Text;
            evento.Descricao = txtDescricao.Text;

            if (int.TryParse(txtTempoDuracao.Text, out var tempoDuracao))
            {
                evento.TempoDuracao = tempoDuracao;
            }

            if (DateTime.TryParse(txtData.Text, out var dataEvento))
            {
                evento.DataEvento = dataEvento;
            }

            if (int.TryParse(cboCidade.SelectedValue.ToString(), out var idGrupo))
            {
                var cidade = _cidadeService.GetById<Cidade>(idGrupo);
                evento.Cidade = cidade;
            }
            evento.Endereco = txtEndereco.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var evento = _eventoService.GetById<Evento>(id);
                        PreencheObjeto(evento);
                        _eventoService.Update<Evento, Evento, EventoValidator>(evento);
                    }
                }
                else
                {
                    var evento = new Evento();
                    PreencheObjeto(evento);
                    _eventoService.Add<Evento, Evento, EventoValidator>(evento);

                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"GEREVENTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _eventoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"GEREVENTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            eventos = _eventoService.Get<EventoModel>(new[] { "Cidade" }).ToList();
            dataGridViewConsulta.DataSource = eventos;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["IdCidade"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtDescricao.Text = linha?.Cells["Descricao"].Value.ToString();
            txtTempoDuracao.Text = linha?.Cells["TempoDuracao"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();
            cboCidade.SelectedValue = linha?.Cells["IdCidade"].Value;
            txtData.Text = DateTime.TryParse(linha?.Cells["DataEvento"].Value.ToString(), out var dataC)
               ? dataC.ToString("g")
               : "";
        }

    }
}

