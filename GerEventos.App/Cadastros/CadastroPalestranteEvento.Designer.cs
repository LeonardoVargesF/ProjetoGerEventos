namespace GerEventos.App.Cadastros
{
    partial class CadastroPalestranteEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboParticipante = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutEventos = new FlowLayoutPanel();
            cboPalestrantes = new ReaLTaiizor.Controls.MaterialComboBox();
            label1 = new Label();
            txtTitulo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDuracao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            SuspendLayout();
            // 
            // cboParticipante
            // 
            cboParticipante.AutoResize = false;
            cboParticipante.BackColor = Color.FromArgb(255, 255, 255);
            cboParticipante.Depth = 0;
            cboParticipante.DrawMode = DrawMode.OwnerDrawVariable;
            cboParticipante.DropDownHeight = 174;
            cboParticipante.DropDownStyle = ComboBoxStyle.DropDownList;
            cboParticipante.DropDownWidth = 121;
            cboParticipante.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboParticipante.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboParticipante.FormattingEnabled = true;
            cboParticipante.Hint = "Participante";
            cboParticipante.IntegralHeight = false;
            cboParticipante.ItemHeight = 43;
            cboParticipante.Location = new Point(7, 6);
            cboParticipante.MaxDropDownItems = 4;
            cboParticipante.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboParticipante.Name = "cboParticipante";
            cboParticipante.Size = new Size(409, 49);
            cboParticipante.StartIndex = 0;
            cboParticipante.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(422, 8);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(124, 48);
            txtId.TabIndex = 5;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(3, 62);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(543, 233);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // flowLayoutEventos
            // 
            flowLayoutEventos.AutoScroll = true;
            flowLayoutEventos.Location = new Point(6, 203);
            flowLayoutEventos.Name = "flowLayoutEventos";
            flowLayoutEventos.Size = new Size(441, 242);
            flowLayoutEventos.TabIndex = 0;
            // 
            // cboPalestrantes
            // 
            cboPalestrantes.AutoResize = false;
            cboPalestrantes.BackColor = Color.FromArgb(255, 255, 255);
            cboPalestrantes.Depth = 0;
            cboPalestrantes.DrawMode = DrawMode.OwnerDrawVariable;
            cboPalestrantes.DropDownHeight = 174;
            cboPalestrantes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPalestrantes.DropDownWidth = 121;
            cboPalestrantes.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPalestrantes.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPalestrantes.FormattingEnabled = true;
            cboPalestrantes.IntegralHeight = false;
            cboPalestrantes.ItemHeight = 43;
            cboPalestrantes.Location = new Point(8, 96);
            cboPalestrantes.MaxDropDownItems = 4;
            cboPalestrantes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPalestrantes.Name = "cboPalestrantes";
            cboPalestrantes.Size = new Size(269, 49);
            cboPalestrantes.StartIndex = 0;
            cboPalestrantes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 78);
            label1.Name = "label1";
            label1.Size = new Size(207, 15);
            label1.TabIndex = 2;
            label1.Text = "Selecione o Palestrante para Inscrição!";
            // 
            // txtTitulo
            // 
            txtTitulo.AnimateReadOnly = false;
            txtTitulo.AutoCompleteMode = AutoCompleteMode.None;
            txtTitulo.AutoCompleteSource = AutoCompleteSource.None;
            txtTitulo.BackgroundImageLayout = ImageLayout.None;
            txtTitulo.CharacterCasing = CharacterCasing.Normal;
            txtTitulo.Depth = 0;
            txtTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTitulo.HideSelection = true;
            txtTitulo.Hint = "Titulo da Palestra";
            txtTitulo.LeadingIcon = null;
            txtTitulo.Location = new Point(8, 149);
            txtTitulo.MaxLength = 32767;
            txtTitulo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PasswordChar = '\0';
            txtTitulo.PrefixSuffixText = null;
            txtTitulo.ReadOnly = false;
            txtTitulo.RightToLeft = RightToLeft.No;
            txtTitulo.SelectedText = "";
            txtTitulo.SelectionLength = 0;
            txtTitulo.SelectionStart = 0;
            txtTitulo.ShortcutsEnabled = true;
            txtTitulo.Size = new Size(439, 48);
            txtTitulo.TabIndex = 2;
            txtTitulo.TabStop = false;
            txtTitulo.TextAlign = HorizontalAlignment.Left;
            txtTitulo.TrailingIcon = null;
            txtTitulo.UseSystemPasswordChar = false;
            // 
            // txtDuracao
            // 
            txtDuracao.AnimateReadOnly = false;
            txtDuracao.AutoCompleteMode = AutoCompleteMode.None;
            txtDuracao.AutoCompleteSource = AutoCompleteSource.None;
            txtDuracao.BackgroundImageLayout = ImageLayout.None;
            txtDuracao.CharacterCasing = CharacterCasing.Normal;
            txtDuracao.Depth = 0;
            txtDuracao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDuracao.HideSelection = true;
            txtDuracao.Hint = "Duração(minutos)";
            txtDuracao.LeadingIcon = null;
            txtDuracao.Location = new Point(283, 96);
            txtDuracao.MaxLength = 32767;
            txtDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDuracao.Name = "txtDuracao";
            txtDuracao.PasswordChar = '\0';
            txtDuracao.PrefixSuffixText = null;
            txtDuracao.ReadOnly = false;
            txtDuracao.RightToLeft = RightToLeft.No;
            txtDuracao.SelectedText = "";
            txtDuracao.SelectionLength = 0;
            txtDuracao.SelectionStart = 0;
            txtDuracao.ShortcutsEnabled = true;
            txtDuracao.Size = new Size(164, 48);
            txtDuracao.TabIndex = 1;
            txtDuracao.TabStop = false;
            txtDuracao.TextAlign = HorizontalAlignment.Left;
            txtDuracao.TrailingIcon = null;
            txtDuracao.UseSystemPasswordChar = false;
            // 
            // CadastroPalestranteEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(453, 451);
            Controls.Add(txtTitulo);
            Controls.Add(txtDuracao);
            Controls.Add(label1);
            Controls.Add(cboPalestrantes);
            Controls.Add(flowLayoutEventos);
            Name = "CadastroPalestranteEvento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscrição de Palestrante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialComboBox cboParticipante;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutEventos;
        private ReaLTaiizor.Controls.MaterialComboBox cboPalestrantes;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTitulo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDuracao;
    }
}