using GerEventos.App.Base;
using GerEventos.App.Models;
using GerEventos.Domain.Base;
using GerEventos.Domain.Entities;
using GerEventos.Service.Validators;
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
    public partial class CadastroPalestrante : CadastroBase
    {
        private readonly IBaseService<Palestrante> _palestranteService;
        private readonly IBaseService<Cidade> _cidadeService;

        private List<PalestranteModel>? palestrantes;

        public CadastroPalestrante(IBaseService<Palestrante> palestranteService, IBaseService<Cidade> cidadeService)
        {
            _palestranteService = palestranteService;
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

        private void PreencheObjeto(Palestrante palestrante)
        {
            palestrante.Nome = txtNome.Text;
            palestrante.CPF = txtCPF.Text;
            palestrante.Email = txtEmail.Text;
            palestrante.Telefone = txtTelefone.Text;
            palestrante.Especializacao = txtEspecializacao.Text;

            if (int.TryParse(cboCidade.SelectedValue.ToString(), out var idGrupo))
            {
                var cidade = _cidadeService.GetById<Cidade>(idGrupo);
                palestrante.Cidade = cidade;
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
                        var palestrante = _palestranteService.GetById<Palestrante>(id);
                        PreencheObjeto(palestrante);
                        _palestranteService.Update<Palestrante, Palestrante, PalestranteValidator>(palestrante);
                    }
                }
                else
                {
                    var palestrante = new Palestrante();
                    PreencheObjeto(palestrante);
                    _palestranteService.Add<Palestrante, Palestrante, PalestranteValidator>(palestrante);

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
                _palestranteService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"GEREVENTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            palestrantes = _palestranteService.Get<PalestranteModel>(new[] { "Cidade" }).ToList();
            dataGridViewConsulta.DataSource = palestrantes;
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
            txtEspecializacao.Text = linha?.Cells["Especializacao"].Value.ToString();
        }

    }
}
