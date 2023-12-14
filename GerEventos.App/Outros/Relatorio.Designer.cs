namespace GerEventos.App.Outros
{
    partial class Relatorio
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
            flowLayoutParticipante = new FlowLayoutPanel();
            flowLayoutPalestrante = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // flowLayoutParticipante
            // 
            flowLayoutParticipante.AutoScroll = true;
            flowLayoutParticipante.Location = new Point(6, 95);
            flowLayoutParticipante.Name = "flowLayoutParticipante";
            flowLayoutParticipante.Size = new Size(350, 349);
            flowLayoutParticipante.TabIndex = 0;
            // 
            // flowLayoutPalestrante
            // 
            flowLayoutPalestrante.AutoScroll = true;
            flowLayoutPalestrante.Location = new Point(470, 95);
            flowLayoutPalestrante.Name = "flowLayoutPalestrante";
            flowLayoutPalestrante.Size = new Size(350, 349);
            flowLayoutPalestrante.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(74, 73);
            label1.Name = "label1";
            label1.Size = new Size(192, 19);
            label1.TabIndex = 2;
            label1.Text = "Inscrições Participantes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(545, 73);
            label2.Name = "label2";
            label2.Size = new Size(187, 19);
            label2.TabIndex = 3;
            label2.Text = "Inscrições Palestrantes";
            // 
            // Relatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.plano_de_fundo_texturizado_de_concreto_grunge_preto;
            ClientSize = new Size(826, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPalestrante);
            Controls.Add(flowLayoutParticipante);
            Name = "Relatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatorio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutParticipante;
        private FlowLayoutPanel flowLayoutPalestrante;
        private Label label1;
        private Label label2;
    }
}