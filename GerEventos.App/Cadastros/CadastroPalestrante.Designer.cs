namespace GerEventos.App.Cadastros
{
    partial class CadastroPalestrante
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
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTelefone = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtCPF = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEspecializacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCidade = new ReaLTaiizor.Controls.MaterialComboBox();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(572, 367);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboCidade);
            tabPageCadastro.Controls.Add(txtEspecializacao);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtTelefone);
            tabPageCadastro.Controls.Add(txtCPF);
            tabPageCadastro.Controls.Add(txtEmail);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Size = new Size(564, 332);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtEmail, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCPF, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTelefone, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtEspecializacao, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCidade, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(536, 396);
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
            txtId.Location = new Point(474, 6);
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
            txtId.Size = new Size(81, 48);
            txtId.TabIndex = 11;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtTelefone
            // 
            txtTelefone.AllowPromptAsInput = true;
            txtTelefone.AnimateReadOnly = false;
            txtTelefone.AsciiOnly = false;
            txtTelefone.BackgroundImageLayout = ImageLayout.None;
            txtTelefone.BeepOnError = false;
            txtTelefone.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefone.Depth = 0;
            txtTelefone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefone.HidePromptOnLeave = false;
            txtTelefone.HideSelection = true;
            txtTelefone.Hint = "Telefone";
            txtTelefone.InsertKeyMode = InsertKeyMode.Default;
            txtTelefone.LeadingIcon = null;
            txtTelefone.Location = new Point(7, 168);
            txtTelefone.Mask = "(99) 99999-9999";
            txtTelefone.MaxLength = 32767;
            txtTelefone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PasswordChar = '\0';
            txtTelefone.PrefixSuffixText = null;
            txtTelefone.PromptChar = '_';
            txtTelefone.ReadOnly = false;
            txtTelefone.RejectInputOnFirstFailure = false;
            txtTelefone.ResetOnPrompt = true;
            txtTelefone.ResetOnSpace = true;
            txtTelefone.RightToLeft = RightToLeft.No;
            txtTelefone.SelectedText = "";
            txtTelefone.SelectionLength = 0;
            txtTelefone.SelectionStart = 0;
            txtTelefone.ShortcutsEnabled = true;
            txtTelefone.Size = new Size(171, 48);
            txtTelefone.SkipLiterals = true;
            txtTelefone.TabIndex = 10;
            txtTelefone.TabStop = false;
            txtTelefone.Text = "(  )      -";
            txtTelefone.TextAlign = HorizontalAlignment.Left;
            txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefone.TrailingIcon = null;
            txtTelefone.UseSystemPasswordChar = false;
            txtTelefone.ValidatingType = null;
            // 
            // txtCPF
            // 
            txtCPF.AllowPromptAsInput = true;
            txtCPF.AnimateReadOnly = false;
            txtCPF.AsciiOnly = false;
            txtCPF.BackgroundImageLayout = ImageLayout.None;
            txtCPF.BeepOnError = false;
            txtCPF.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtCPF.Depth = 0;
            txtCPF.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCPF.HidePromptOnLeave = false;
            txtCPF.HideSelection = true;
            txtCPF.Hint = "CPF";
            txtCPF.InsertKeyMode = InsertKeyMode.Default;
            txtCPF.LeadingIcon = null;
            txtCPF.Location = new Point(7, 114);
            txtCPF.Mask = "999.999.999-99";
            txtCPF.MaxLength = 32767;
            txtCPF.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCPF.Name = "txtCPF";
            txtCPF.PasswordChar = '\0';
            txtCPF.PrefixSuffixText = null;
            txtCPF.PromptChar = '_';
            txtCPF.ReadOnly = false;
            txtCPF.RejectInputOnFirstFailure = false;
            txtCPF.ResetOnPrompt = true;
            txtCPF.ResetOnSpace = true;
            txtCPF.RightToLeft = RightToLeft.No;
            txtCPF.SelectedText = "";
            txtCPF.SelectionLength = 0;
            txtCPF.SelectionStart = 0;
            txtCPF.ShortcutsEnabled = true;
            txtCPF.Size = new Size(548, 48);
            txtCPF.SkipLiterals = true;
            txtCPF.TabIndex = 9;
            txtCPF.TabStop = false;
            txtCPF.Text = "   ,   ,   -";
            txtCPF.TextAlign = HorizontalAlignment.Left;
            txtCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCPF.TrailingIcon = null;
            txtCPF.UseSystemPasswordChar = false;
            txtCPF.ValidatingType = null;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(7, 60);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(548, 48);
            txtEmail.TabIndex = 8;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(7, 6);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(461, 48);
            txtNome.TabIndex = 7;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtEspecializacao
            // 
            txtEspecializacao.AnimateReadOnly = false;
            txtEspecializacao.AutoCompleteMode = AutoCompleteMode.None;
            txtEspecializacao.AutoCompleteSource = AutoCompleteSource.None;
            txtEspecializacao.BackgroundImageLayout = ImageLayout.None;
            txtEspecializacao.CharacterCasing = CharacterCasing.Normal;
            txtEspecializacao.Depth = 0;
            txtEspecializacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEspecializacao.HideSelection = true;
            txtEspecializacao.Hint = "Especialização";
            txtEspecializacao.LeadingIcon = null;
            txtEspecializacao.Location = new Point(7, 222);
            txtEspecializacao.MaxLength = 32767;
            txtEspecializacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEspecializacao.Name = "txtEspecializacao";
            txtEspecializacao.PasswordChar = '\0';
            txtEspecializacao.PrefixSuffixText = null;
            txtEspecializacao.ReadOnly = false;
            txtEspecializacao.RightToLeft = RightToLeft.No;
            txtEspecializacao.SelectedText = "";
            txtEspecializacao.SelectionLength = 0;
            txtEspecializacao.SelectionStart = 0;
            txtEspecializacao.ShortcutsEnabled = true;
            txtEspecializacao.Size = new Size(548, 48);
            txtEspecializacao.TabIndex = 12;
            txtEspecializacao.TabStop = false;
            txtEspecializacao.TextAlign = HorizontalAlignment.Left;
            txtEspecializacao.TrailingIcon = null;
            txtEspecializacao.UseSystemPasswordChar = false;
            // 
            // cboCidade
            // 
            cboCidade.AutoResize = false;
            cboCidade.BackColor = Color.FromArgb(255, 255, 255);
            cboCidade.Depth = 0;
            cboCidade.DrawMode = DrawMode.OwnerDrawVariable;
            cboCidade.DropDownHeight = 174;
            cboCidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCidade.DropDownWidth = 121;
            cboCidade.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCidade.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCidade.FormattingEnabled = true;
            cboCidade.Hint = "Cidade";
            cboCidade.IntegralHeight = false;
            cboCidade.ItemHeight = 43;
            cboCidade.Location = new Point(184, 168);
            cboCidade.MaxDropDownItems = 4;
            cboCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCidade.Name = "cboCidade";
            cboCidade.Size = new Size(371, 49);
            cboCidade.StartIndex = 0;
            cboCidade.TabIndex = 13;
            // 
            // CadastroPalestrante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 434);
            Location = new Point(0, 0);
            Name = "CadastroPalestrante";
            Text = "CadastroPalestrante";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTelefone;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCPF;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEspecializacao;
        private ReaLTaiizor.Controls.MaterialComboBox cboCidade;
    }
}