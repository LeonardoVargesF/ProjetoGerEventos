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
            this.btnInscrever = new ReaLTaiizor.Controls.MaterialButton();
            this.lblNomeEvento = new System.Windows.Forms.Label();
            this.btnCancelarInsc = new ReaLTaiizor.Controls.MaterialButton();
            this.lblDataEvento = new System.Windows.Forms.Label();
            this.lblIdEvento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInscrever
            // 
            this.btnInscrever.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInscrever.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInscrever.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInscrever.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInscrever.Depth = 0;
            this.btnInscrever.HighEmphasis = true;
            this.btnInscrever.Icon = null;
            this.btnInscrever.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnInscrever.Location = new System.Drawing.Point(301, 65);
            this.btnInscrever.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInscrever.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnInscrever.Name = "btnInscrever";
            this.btnInscrever.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInscrever.Size = new System.Drawing.Size(108, 36);
            this.btnInscrever.TabIndex = 0;
            this.btnInscrever.Text = "&Inscrever";
            this.btnInscrever.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInscrever.UseAccentColor = false;
            this.btnInscrever.UseVisualStyleBackColor = true;
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeEvento.Location = new System.Drawing.Point(103, 0);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(220, 40);
            this.lblNomeEvento.TabIndex = 1;
            this.lblNomeEvento.Text = "label1";
            this.lblNomeEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelarInsc
            // 
            this.btnCancelarInsc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarInsc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelarInsc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarInsc.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelarInsc.Depth = 0;
            this.btnCancelarInsc.HighEmphasis = true;
            this.btnCancelarInsc.Icon = null;
            this.btnCancelarInsc.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCancelarInsc.Location = new System.Drawing.Point(7, 65);
            this.btnCancelarInsc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelarInsc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCancelarInsc.Name = "btnCancelarInsc";
            this.btnCancelarInsc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelarInsc.Size = new System.Drawing.Size(105, 36);
            this.btnCancelarInsc.TabIndex = 2;
            this.btnCancelarInsc.Text = "&Cancelar";
            this.btnCancelarInsc.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelarInsc.UseAccentColor = true;
            this.btnCancelarInsc.UseVisualStyleBackColor = true;
            // 
            // lblDataEvento
            // 
            this.lblDataEvento.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataEvento.Location = new System.Drawing.Point(131, 40);
            this.lblDataEvento.Name = "lblDataEvento";
            this.lblDataEvento.Size = new System.Drawing.Size(163, 39);
            this.lblDataEvento.TabIndex = 3;
            this.lblDataEvento.Text = "label1";
            this.lblDataEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdEvento
            // 
            this.lblIdEvento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdEvento.Location = new System.Drawing.Point(0, 0);
            this.lblIdEvento.Name = "lblIdEvento";
            this.lblIdEvento.Size = new System.Drawing.Size(40, 39);
            this.lblIdEvento.TabIndex = 4;
            this.lblIdEvento.Text = "label1";
            this.lblIdEvento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CaixadeEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.lblIdEvento);
            this.Controls.Add(this.lblDataEvento);
            this.Controls.Add(this.btnCancelarInsc);
            this.Controls.Add(this.lblNomeEvento);
            this.Controls.Add(this.btnInscrever);
            this.Name = "CaixadeEventos";
            this.Size = new System.Drawing.Size(425, 107);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Label lblNomeEvento;
        public Label lblDataEvento;
        public ReaLTaiizor.Controls.MaterialButton btnInscrever;
        public ReaLTaiizor.Controls.MaterialButton btnCancelarInsc;
        public Label lblIdEvento;
    }
}
