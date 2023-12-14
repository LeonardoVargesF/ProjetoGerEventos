using GerEventos.App.Cadastros;
using GerEventos.App.Infra;
using GerEventos.App.Outros;
using GerEventos.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using System.Security.Policy;

namespace GerEventos.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void cidadeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Exibeformulario<CadastroCidade>();
        }

        private void eventosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Exibeformulario<CadastroEvento>();
        }

        private void palestrantesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Exibeformulario<CadastroPalestrante>();
        }

        private void participantesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Exibeformulario<CadastroParticipante>();
        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }

        private void FormPrincipal_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void participanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroInscricao>();
        }

        private void palestranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroPalestranteEvento>();
        }


        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void inscriçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<Relatorio>();
        }
    }
}