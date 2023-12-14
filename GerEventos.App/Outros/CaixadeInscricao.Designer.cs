namespace GerEventos.App.Outros
{
    partial class CaixadeInscricao
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblDataEvento = new Label();
            lblNomeEvento = new Label();
            lblNome = new Label();
            SuspendLayout();
            // 
            // lblDataEvento
            // 
            lblDataEvento.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataEvento.Location = new Point(81, 40);
            lblDataEvento.Name = "lblDataEvento";
            lblDataEvento.Size = new Size(163, 39);
            lblDataEvento.TabIndex = 5;
            lblDataEvento.Text = "label1";
            lblDataEvento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeEvento
            // 
            lblNomeEvento.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeEvento.Location = new Point(53, 0);
            lblNomeEvento.Name = "lblNomeEvento";
            lblNomeEvento.Size = new Size(220, 40);
            lblNomeEvento.TabIndex = 4;
            lblNomeEvento.Text = "label1";
            lblNomeEvento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            lblNome.Location = new Point(3, 107);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(226, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "label1";
            // 
            // CaixadeInscricao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblNome);
            Controls.Add(lblDataEvento);
            Controls.Add(lblNomeEvento);
            Name = "CaixadeInscricao";
            Size = new Size(324, 131);
            ResumeLayout(false);
        }

        #endregion

        public Label lblDataEvento;
        public Label lblNomeEvento;
        public Label lblNome;
    }
}
