namespace Veterinario.MDI
{
    partial class FormConsulta
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
            btnVerFuturas = new Button();
            btnSalvarMarcacao = new Button();
            pnlMarcar = new Panel();
            btnSalvar = new Button();
            label3 = new Label();
            txtMotivo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            cbAnimais = new ComboBox();
            pnlVerConsultas = new Panel();
            btnAtualizar = new Button();
            dgvConsultasFuturas = new DataGridView();
            pnlMarcar.SuspendLayout();
            pnlVerConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultasFuturas).BeginInit();
            SuspendLayout();
            // 
            // btnVerFuturas
            // 
            btnVerFuturas.Location = new Point(12, 12);
            btnVerFuturas.Name = "btnVerFuturas";
            btnVerFuturas.Size = new Size(115, 49);
            btnVerFuturas.TabIndex = 0;
            btnVerFuturas.Text = "Ver Consultas";
            btnVerFuturas.UseVisualStyleBackColor = true;
            btnVerFuturas.Click += btnVerFuturas_Click;
            // 
            // btnSalvarMarcacao
            // 
            btnSalvarMarcacao.Location = new Point(162, 12);
            btnSalvarMarcacao.Name = "btnSalvarMarcacao";
            btnSalvarMarcacao.Size = new Size(115, 49);
            btnSalvarMarcacao.TabIndex = 1;
            btnSalvarMarcacao.Text = "Criar Consulta";
            btnSalvarMarcacao.UseVisualStyleBackColor = true;
            btnSalvarMarcacao.Click += btnSalvarMarcacao_Click;
            // 
            // pnlMarcar
            // 
            pnlMarcar.Controls.Add(btnSalvar);
            pnlMarcar.Controls.Add(label3);
            pnlMarcar.Controls.Add(txtMotivo);
            pnlMarcar.Controls.Add(label2);
            pnlMarcar.Controls.Add(label1);
            pnlMarcar.Controls.Add(dateTimePicker1);
            pnlMarcar.Controls.Add(cbAnimais);
            pnlMarcar.Location = new Point(12, 124);
            pnlMarcar.Name = "pnlMarcar";
            pnlMarcar.Size = new Size(640, 314);
            pnlMarcar.TabIndex = 2;
            pnlMarcar.Visible = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(192, 255, 192);
            btnSalvar.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btnSalvar.Location = new Point(501, 252);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 49);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 20);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 4;
            label3.Text = "Motivos/Sintomas:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(321, 61);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.ScrollBars = ScrollBars.Vertical;
            txtMotivo.Size = new Size(295, 139);
            txtMotivo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 20);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 3;
            label2.Text = "Data e Hora da Consulta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 2;
            label1.Text = "Animal:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyy H:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(150, 61);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(154, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // cbAnimais
            // 
            cbAnimais.FormattingEnabled = true;
            cbAnimais.Location = new Point(14, 61);
            cbAnimais.Name = "cbAnimais";
            cbAnimais.Size = new Size(121, 23);
            cbAnimais.TabIndex = 0;
            // 
            // pnlVerConsultas
            // 
            pnlVerConsultas.Controls.Add(btnAtualizar);
            pnlVerConsultas.Controls.Add(dgvConsultasFuturas);
            pnlVerConsultas.Location = new Point(12, 124);
            pnlVerConsultas.Name = "pnlVerConsultas";
            pnlVerConsultas.Size = new Size(640, 314);
            pnlVerConsultas.TabIndex = 3;
            pnlVerConsultas.Visible = false;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(3, 3);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(115, 52);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // dgvConsultasFuturas
            // 
            dgvConsultasFuturas.AllowUserToAddRows = false;
            dgvConsultasFuturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultasFuturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultasFuturas.Location = new Point(3, 61);
            dgvConsultasFuturas.Name = "dgvConsultasFuturas";
            dgvConsultasFuturas.ReadOnly = true;
            dgvConsultasFuturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultasFuturas.Size = new Size(634, 250);
            dgvConsultasFuturas.TabIndex = 0;
            // 
            // FormConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMarcar);
            Controls.Add(pnlVerConsultas);
            Controls.Add(btnSalvarMarcacao);
            Controls.Add(btnVerFuturas);
            Name = "FormConsulta";
            Text = "Consulta";
            pnlMarcar.ResumeLayout(false);
            pnlMarcar.PerformLayout();
            pnlVerConsultas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvConsultasFuturas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVerFuturas;
        private Button btnSalvarMarcacao;
        private Panel pnlMarcar;
        private Panel pnlVerConsultas;
        private ComboBox cbAnimais;
        private Label label3;
        private TextBox txtMotivo;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button btnSalvar;
        private DataGridView dgvConsultasFuturas;
        private Button btnAtualizar;
    }
}