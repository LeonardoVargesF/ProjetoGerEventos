namespace GerEventos.App.Outros
{
    partial class CaixadeEventos
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
            btnInscrever = new ReaLTaiizor.Controls.MaterialButton();
            lblNomeEvento = new Label();
            btnCancelarInsc = new ReaLTaiizor.Controls.MaterialButton();
            lblDataEvento = new Label();
            SuspendLayout();
            // 
            // btnInscrever
            // 
            btnInscrever.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInscrever.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInscrever.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnInscrever.Depth = 0;
            btnInscrever.HighEmphasis = true;
            btnInscrever.Icon = null;
            btnInscrever.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnInscrever.Location = new Point(301, 65);
            btnInscrever.Margin = new Padding(4, 6, 4, 6);
            btnInscrever.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnInscrever.Name = "btnInscrever";
            btnInscrever.NoAccentTextColor = Color.Empty;
            btnInscrever.Size = new Size(108, 36);
            btnInscrever.TabIndex = 0;
            btnInscrever.Text = "&Inscrever";
            btnInscrever.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnInscrever.UseAccentColor = false;
            btnInscrever.UseVisualStyleBackColor = true;
            // 
            // lblNomeEvento
            // 
            lblNomeEvento.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeEvento.Location = new Point(103, 0);
            lblNomeEvento.Name = "lblNomeEvento";
            lblNomeEvento.Size = new Size(220, 40);
            lblNomeEvento.TabIndex = 1;
            lblNomeEvento.Text = "label1";
            lblNomeEvento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancelarInsc
            // 
            btnCancelarInsc.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelarInsc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelarInsc.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelarInsc.Depth = 0;
            btnCancelarInsc.HighEmphasis = true;
            btnCancelarInsc.Icon = null;
            btnCancelarInsc.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelarInsc.Location = new Point(7, 65);
            btnCancelarInsc.Margin = new Padding(4, 6, 4, 6);
            btnCancelarInsc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelarInsc.Name = "btnCancelarInsc";
            btnCancelarInsc.NoAccentTextColor = Color.Empty;
            btnCancelarInsc.Size = new Size(105, 36);
            btnCancelarInsc.TabIndex = 2;
            btnCancelarInsc.Text = "&Cancelar";
            btnCancelarInsc.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelarInsc.UseAccentColor = true;
            btnCancelarInsc.UseVisualStyleBackColor = true;
            // 
            // lblDataEvento
            // 
            lblDataEvento.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataEvento.Location = new Point(131, 40);
            lblDataEvento.Name = "lblDataEvento";
            lblDataEvento.Size = new Size(163, 39);
            lblDataEvento.TabIndex = 3;
            lblDataEvento.Text = "label1";
            lblDataEvento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CaixadeEventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            Controls.Add(lblDataEvento);
            Controls.Add(btnCancelarInsc);
            Controls.Add(lblNomeEvento);
            Controls.Add(btnInscrever);
            Name = "CaixadeEventos";
            Size = new Size(425, 107);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lblNomeEvento;
        public Label lblDataEvento;
        public ReaLTaiizor.Controls.MaterialButton btnInscrever;
        public ReaLTaiizor.Controls.MaterialButton btnCancelarInsc;
    }
}
