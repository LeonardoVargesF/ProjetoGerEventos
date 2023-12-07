namespace GerEventos.App
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            eventosToolStripMenuItem = new ToolStripMenuItem();
            palestrantesToolStripMenuItem = new ToolStripMenuItem();
            participantesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            cidadeToolStripMenuItem = new ToolStripMenuItem();
            inscriçãoToolStripMenuItem1 = new ToolStripMenuItem();
            inscriçãoToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            btnCadastroPalestrante = new ReaLTaiizor.Controls.MaterialButton();
            btnCadastroParticipante = new ReaLTaiizor.Controls.MaterialButton();
            toolStripSeparator3 = new ToolStripSeparator();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, inscriçãoToolStripMenuItem, relatóriosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(628, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eventosToolStripMenuItem, toolStripSeparator3, palestrantesToolStripMenuItem, participantesToolStripMenuItem, toolStripSeparator2, cidadeToolStripMenuItem, inscriçãoToolStripMenuItem1 });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(122, 20);
            cadastroToolStripMenuItem.Text = "&Cadastros";
            // 
            // eventosToolStripMenuItem
            // 
            eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            eventosToolStripMenuItem.Size = new Size(180, 22);
            eventosToolStripMenuItem.Text = "&Eventos";
            eventosToolStripMenuItem.Click += eventosToolStripMenuItem_Click;
            // 
            // palestrantesToolStripMenuItem
            // 
            palestrantesToolStripMenuItem.Name = "palestrantesToolStripMenuItem";
            palestrantesToolStripMenuItem.Size = new Size(180, 22);
            palestrantesToolStripMenuItem.Text = "&Palestrantes";
            palestrantesToolStripMenuItem.Click += palestrantesToolStripMenuItem_Click;
            // 
            // participantesToolStripMenuItem
            // 
            participantesToolStripMenuItem.Name = "participantesToolStripMenuItem";
            participantesToolStripMenuItem.Size = new Size(180, 22);
            participantesToolStripMenuItem.Text = "&Participantes";
            participantesToolStripMenuItem.Click += participantesToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // cidadeToolStripMenuItem
            // 
            cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            cidadeToolStripMenuItem.Size = new Size(180, 22);
            cidadeToolStripMenuItem.Text = "&Cidades";
            cidadeToolStripMenuItem.Click += cidadeToolStripMenuItem_Click;
            // 
            // inscriçãoToolStripMenuItem1
            // 
            inscriçãoToolStripMenuItem1.Name = "inscriçãoToolStripMenuItem1";
            inscriçãoToolStripMenuItem1.Size = new Size(180, 22);
            inscriçãoToolStripMenuItem1.Text = "Inscrição";
            // 
            // inscriçãoToolStripMenuItem
            // 
            inscriçãoToolStripMenuItem.Name = "inscriçãoToolStripMenuItem";
            inscriçãoToolStripMenuItem.Size = new Size(66, 20);
            inscriçãoToolStripMenuItem.Text = "&Inscrição";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // btnCadastroPalestrante
            // 
            btnCadastroPalestrante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCadastroPalestrante.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCadastroPalestrante.BackColor = SystemColors.ButtonFace;
            btnCadastroPalestrante.Cursor = Cursors.Hand;
            btnCadastroPalestrante.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCadastroPalestrante.Depth = 0;
            btnCadastroPalestrante.ForeColor = SystemColors.ControlText;
            btnCadastroPalestrante.HighEmphasis = true;
            btnCadastroPalestrante.Icon = null;
            btnCadastroPalestrante.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCadastroPalestrante.Location = new Point(55, 436);
            btnCadastroPalestrante.Margin = new Padding(4, 6, 4, 6);
            btnCadastroPalestrante.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCadastroPalestrante.Name = "btnCadastroPalestrante";
            btnCadastroPalestrante.NoAccentTextColor = Color.Empty;
            btnCadastroPalestrante.Size = new Size(209, 36);
            btnCadastroPalestrante.TabIndex = 11;
            btnCadastroPalestrante.Text = "Cadastrar Palestrante";
            btnCadastroPalestrante.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCadastroPalestrante.UseAccentColor = true;
            btnCadastroPalestrante.UseVisualStyleBackColor = false;
            // 
            // btnCadastroParticipante
            // 
            btnCadastroParticipante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCadastroParticipante.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCadastroParticipante.Cursor = Cursors.Hand;
            btnCadastroParticipante.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCadastroParticipante.Depth = 0;
            btnCadastroParticipante.HighEmphasis = true;
            btnCadastroParticipante.Icon = null;
            btnCadastroParticipante.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCadastroParticipante.Location = new Point(357, 436);
            btnCadastroParticipante.Margin = new Padding(4, 6, 4, 6);
            btnCadastroParticipante.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCadastroParticipante.Name = "btnCadastroParticipante";
            btnCadastroParticipante.NoAccentTextColor = Color.Empty;
            btnCadastroParticipante.Size = new Size(212, 36);
            btnCadastroParticipante.TabIndex = 12;
            btnCadastroParticipante.Text = "Cadastrar Participante";
            btnCadastroParticipante.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCadastroParticipante.UseAccentColor = false;
            btnCadastroParticipante.UseVisualStyleBackColor = true;
            btnCadastroParticipante.Click += btnCadastroParticipante_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(634, 557);
            Controls.Add(btnCadastroParticipante);
            Controls.Add(btnCadastroPalestrante);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento de Eventos";
            FormClosing += FormPrincipal_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem eventosToolStripMenuItem;
        private ToolStripMenuItem palestrantesToolStripMenuItem;
        private ToolStripMenuItem participantesToolStripMenuItem;
        private ToolStripMenuItem inscriçãoToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem cidadeToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem inscriçãoToolStripMenuItem1;
        private ReaLTaiizor.Controls.MaterialButton btnCadastroPalestrante;
        private ReaLTaiizor.Controls.MaterialButton btnCadastroParticipante;
        private ToolStripSeparator toolStripSeparator3;
    }
}