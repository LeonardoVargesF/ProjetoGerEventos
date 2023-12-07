namespace GerEventos.App.Cadastros
{
    partial class CadastroInscricao
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
            cboParticipantes = new ReaLTaiizor.Controls.MaterialComboBox();
            label1 = new Label();
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
            flowLayoutEventos.Location = new Point(6, 150);
            flowLayoutEventos.Name = "flowLayoutEventos";
            flowLayoutEventos.Size = new Size(430, 295);
            flowLayoutEventos.TabIndex = 0;
            // 
            // cboParticipantes
            // 
            cboParticipantes.AutoResize = false;
            cboParticipantes.BackColor = Color.FromArgb(255, 255, 255);
            cboParticipantes.Depth = 0;
            cboParticipantes.DrawMode = DrawMode.OwnerDrawVariable;
            cboParticipantes.DropDownHeight = 174;
            cboParticipantes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboParticipantes.DropDownWidth = 121;
            cboParticipantes.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboParticipantes.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboParticipantes.FormattingEnabled = true;
            cboParticipantes.IntegralHeight = false;
            cboParticipantes.ItemHeight = 43;
            cboParticipantes.Location = new Point(120, 95);
            cboParticipantes.MaxDropDownItems = 4;
            cboParticipantes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboParticipantes.Name = "cboParticipantes";
            cboParticipantes.Size = new Size(205, 49);
            cboParticipantes.StartIndex = 0;
            cboParticipantes.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 77);
            label1.Name = "label1";
            label1.Size = new Size(215, 15);
            label1.TabIndex = 2;
            label1.Text = "Selecione o Participante para Cadastrar!";
            // 
            // CadastroInscricao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(442, 451);
            Controls.Add(label1);
            Controls.Add(cboParticipantes);
            Controls.Add(flowLayoutEventos);
            Name = "CadastroInscricao";
            Text = "Inscrição de Participante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialComboBox cboParticipante;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutEventos;
        private ReaLTaiizor.Controls.MaterialComboBox cboParticipantes;
        private Label label1;
    }
}