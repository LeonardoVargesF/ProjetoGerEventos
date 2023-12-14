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
            toolStripSeparator3 = new ToolStripSeparator();
            palestrantesToolStripMenuItem = new ToolStripMenuItem();
            participantesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            cidadeToolStripMenuItem = new ToolStripMenuItem();
            inscriçãoToolStripMenuItem1 = new ToolStripMenuItem();
            inscriçãoToolStripMenuItem = new ToolStripMenuItem();
            participanteToolStripMenuItem = new ToolStripMenuItem();
            palestranteToolStripMenuItem = new ToolStripMenuItem();
            inscriçõesToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, inscriçãoToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(999, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eventosToolStripMenuItem, toolStripSeparator3, palestrantesToolStripMenuItem, participantesToolStripMenuItem, toolStripSeparator2, cidadeToolStripMenuItem, inscriçãoToolStripMenuItem1 });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(71, 20);
            cadastroToolStripMenuItem.Text = "&Cadastros";
            // 
            // eventosToolStripMenuItem
            // 
            eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            eventosToolStripMenuItem.Size = new Size(142, 22);
            eventosToolStripMenuItem.Text = "&Eventos";
            eventosToolStripMenuItem.Click += eventosToolStripMenuItem_Click_1;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(139, 6);
            // 
            // palestrantesToolStripMenuItem
            // 
            palestrantesToolStripMenuItem.Name = "palestrantesToolStripMenuItem";
            palestrantesToolStripMenuItem.Size = new Size(142, 22);
            palestrantesToolStripMenuItem.Text = "&Palestrantes";
            palestrantesToolStripMenuItem.Click += palestrantesToolStripMenuItem_Click_1;
            // 
            // participantesToolStripMenuItem
            // 
            participantesToolStripMenuItem.Name = "participantesToolStripMenuItem";
            participantesToolStripMenuItem.Size = new Size(142, 22);
            participantesToolStripMenuItem.Text = "&Participantes";
            participantesToolStripMenuItem.Click += participantesToolStripMenuItem_Click_1;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(139, 6);
            // 
            // cidadeToolStripMenuItem
            // 
            cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            cidadeToolStripMenuItem.Size = new Size(142, 22);
            cidadeToolStripMenuItem.Text = "&Cidades";
            cidadeToolStripMenuItem.Click += cidadeToolStripMenuItem_Click_1;
            // 
            // inscriçãoToolStripMenuItem1
            // 
            inscriçãoToolStripMenuItem1.Name = "inscriçãoToolStripMenuItem1";
            inscriçãoToolStripMenuItem1.Size = new Size(142, 22);
            inscriçãoToolStripMenuItem1.Text = "Inscrição";
            // 
            // inscriçãoToolStripMenuItem
            // 
            inscriçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { participanteToolStripMenuItem, palestranteToolStripMenuItem, inscriçõesToolStripMenuItem });
            inscriçãoToolStripMenuItem.Name = "inscriçãoToolStripMenuItem";
            inscriçãoToolStripMenuItem.Size = new Size(66, 20);
            inscriçãoToolStripMenuItem.Text = "&Inscrição";
            // 
            // participanteToolStripMenuItem
            // 
            participanteToolStripMenuItem.Name = "participanteToolStripMenuItem";
            participanteToolStripMenuItem.Size = new Size(137, 22);
            participanteToolStripMenuItem.Text = "Participante";
            participanteToolStripMenuItem.Click += participanteToolStripMenuItem_Click;
            // 
            // palestranteToolStripMenuItem
            // 
            palestranteToolStripMenuItem.Name = "palestranteToolStripMenuItem";
            palestranteToolStripMenuItem.Size = new Size(137, 22);
            palestranteToolStripMenuItem.Text = "Palestrante";
            palestranteToolStripMenuItem.Click += palestranteToolStripMenuItem_Click;
            // 
            // inscriçõesToolStripMenuItem
            // 
            inscriçõesToolStripMenuItem.Name = "inscriçõesToolStripMenuItem";
            inscriçõesToolStripMenuItem.Size = new Size(137, 22);
            inscriçõesToolStripMenuItem.Text = "Inscrições";
            inscriçõesToolStripMenuItem.Click += inscriçõesToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click_1;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Properties.Resources.Leonardo_Eventos;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1005, 591);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento de Eventos";
            FormClosing += FormPrincipal_FormClosing_1;
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
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem cidadeToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem inscriçãoToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem participanteToolStripMenuItem;
        private ToolStripMenuItem palestranteToolStripMenuItem;
        private ToolStripMenuItem inscriçõesToolStripMenuItem;
    }
}