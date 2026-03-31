namespace Veterinario.MDI
{
    partial class Historico
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
            dgvHistorico = new DataGridView();
            cbAnimais = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorico
            // 
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Location = new Point(12, 52);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.Size = new Size(655, 886);
            dgvHistorico.TabIndex = 0;
            // 
            // cbAnimais
            // 
            cbAnimais.FormattingEnabled = true;
            cbAnimais.Location = new Point(12, 12);
            cbAnimais.Name = "cbAnimais";
            cbAnimais.Size = new Size(209, 23);
            cbAnimais.TabIndex = 1;
            cbAnimais.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Historico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 708);
            Controls.Add(cbAnimais);
            Controls.Add(dgvHistorico);
            Name = "Historico";
            Text = "Historico";
            Load += Historico_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistorico;
        private ComboBox cbAnimais;
    }
}