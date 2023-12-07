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
    public partial class CadastroParticipante : CadastroBase
    {
        private readonly IBaseService<Participante> _participanteService;
        private readonly IBaseService<Cidade> _cidadeService;

        private List<ParticipanteModel>? participantes;

        public CadastroParticipante(IBaseService<Participante> participanteService, IBaseService<Cidade> cidadeService)
        {
            _participanteService = participanteService;
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

        private void PreencheObjeto(Participante participante)
        {
            participante.Nome = txtNome.Text;
            participante.CPF = txtCPF.Text;
            participante.Email = txtEmail.Text;
            participante.Telefone = txtTelefone.Text;

            if (int.TryParse(cboCidade.SelectedValue.ToString(), out var idGrupo))
            {
                var cidade = _cidadeService.GetById<Cidade>(idGrupo);
                participante.Cidade = cidade;
            }
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var participante = _participanteService.GetById<Participante>(id);
                        PreencheObjeto(participante);
                        _participanteService.Update<Participante, Participante, ParticipanteValidator>(participante);
                    }
                }
                else
                {
                    var participante = new Participante();
                    PreencheObjeto(participante);
                    _participanteService.Add<Participante, Participante, ParticipanteValidator>(participante);

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
                _participanteService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"GEREVENTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            participantes = _participanteService.Get<ParticipanteModel>(new[] { "Cidade" }).ToList();
            dataGridViewConsulta.DataSource = participantes;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["IdCidade"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtCPF.Text = linha?.Cells["CPF"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            cboCidade.SelectedValue = linha?.Cells["IdCidade"].Value;
        }

    }
}
