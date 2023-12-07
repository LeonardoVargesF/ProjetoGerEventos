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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.palestrantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palestranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.inscriçãoToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventosToolStripMenuItem,
            this.toolStripSeparator3,
            this.palestrantesToolStripMenuItem,
            this.participantesToolStripMenuItem,
            this.toolStripSeparator2,
            this.cidadeToolStripMenuItem,
            this.inscriçãoToolStripMenuItem1});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastroToolStripMenuItem.Text = "&Cadastros";
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.eventosToolStripMenuItem.Text = "&Eventos";
            this.eventosToolStripMenuItem.Click += new System.EventHandler(this.eventosToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(139, 6);
            // 
            // palestrantesToolStripMenuItem
            // 
            this.palestrantesToolStripMenuItem.Name = "palestrantesToolStripMenuItem";
            this.palestrantesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.palestrantesToolStripMenuItem.Text = "&Palestrantes";
            this.palestrantesToolStripMenuItem.Click += new System.EventHandler(this.palestrantesToolStripMenuItem_Click_1);
            // 
            // participantesToolStripMenuItem
            // 
            this.participantesToolStripMenuItem.Name = "participantesToolStripMenuItem";
            this.participantesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.participantesToolStripMenuItem.Text = "&Participantes";
            this.participantesToolStripMenuItem.Click += new System.EventHandler(this.participantesToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
            // 
            // cidadeToolStripMenuItem
            // 
            this.cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            this.cidadeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cidadeToolStripMenuItem.Text = "&Cidades";
            this.cidadeToolStripMenuItem.Click += new System.EventHandler(this.cidadeToolStripMenuItem_Click_1);
            // 
            // inscriçãoToolStripMenuItem1
            // 
            this.inscriçãoToolStripMenuItem1.Name = "inscriçãoToolStripMenuItem1";
            this.inscriçãoToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.inscriçãoToolStripMenuItem1.Text = "Inscrição";
            // 
            // inscriçãoToolStripMenuItem
            // 
            this.inscriçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.participanteToolStripMenuItem,
            this.palestranteToolStripMenuItem});
            this.inscriçãoToolStripMenuItem.Name = "inscriçãoToolStripMenuItem";
            this.inscriçãoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.inscriçãoToolStripMenuItem.Text = "&Inscrição";
            // 
            // participanteToolStripMenuItem
            // 
            this.participanteToolStripMenuItem.Name = "participanteToolStripMenuItem";
            this.participanteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.participanteToolStripMenuItem.Text = "Participante";
            this.participanteToolStripMenuItem.Click += new System.EventHandler(this.participanteToolStripMenuItem_Click);
            // 
            // palestranteToolStripMenuItem
            // 
            this.palestranteToolStripMenuItem.Name = "palestranteToolStripMenuItem";
            this.palestranteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.palestranteToolStripMenuItem.Text = "Palestrante";
            this.palestranteToolStripMenuItem.Click += new System.EventHandler(this.palestranteToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(634, 557);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Eventos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem participanteToolStripMenuItem;
        private ToolStripMenuItem palestranteToolStripMenuItem;
    }
}