using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinario.Classes;
using Veterinario.DAL;

namespace Veterinario.MDI
{
    internal partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
        }

        public DateTime Data { get; set; }
        public string Motivo { get; set; }

        private Animal animal;
        private Cliente cliente;
        public FormConsulta(DateTime data, string motivo, Animal animal, Cliente cliente)
        {
            Data = data;
            Motivo = motivo;
            this.animal = animal;
            this.cliente = cliente;
        }

        private void CarregarConsultasFuturas()
        {
            try
            {
                // 1. O SQL: Filtramos onde a DataHora é maior ou igual a "agora"
                // Fazemos um JOIN com a tabela Animal para o utilizador saber de quem é a consulta
                string sql = @"SELECT C.ConsultaID, 
                              A.Nome AS [Nome do Animal], 
                              C.DataHora AS [Data e Hora], 
                              C.Motivo
                       FROM Consulta C
                       INNER JOIN Animal A ON C.AnimalID = A.AnimalID
                       WHERE C.DataHora >= @agora
                       ORDER BY C.DataHora ASC";

                // 2. Criar o parâmetro com a hora exata do clique
                SqlParameter[] p = {
            new SqlParameter("@agora", DateTime.Now)
        };

                // 3. Chamar o DatabaseHelper (que já resolvemos antes)
                DataTable dt = Veterinario.DAL.DatabaseHelper.ExecuteQuery(sql, p);

                // 4. Ligar os dados à Grid que está dentro do teu painel
                dgvConsultasFuturas.DataSource = dt;

                // 5. Opcional: Ajustar a largura das colunas e formato da data
                if (dgvConsultasFuturas.Columns.Contains("Data e Hora"))
                {
                    dgvConsultasFuturas.Columns["Data e Hora"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dgvConsultasFuturas.Columns["Data e Hora"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar consultas: " + ex.Message);
            }
        }

        private void EsconderPaineis()
        {
            pnlMarcar.Visible = false;
            pnlVerConsultas.Visible = false;
        }

        public bool ValidarData(DateTime data)
        {
            // Regra: Não permitir marcar consultas no passado
            return data >= DateTime.Now;
        }

        private void PreencherListaAnimais()
        {
            try
            {
                // SQL para buscar os animais
                string sql = "SELECT AnimalID, Nome FROM Animal ORDER BY Nome ASC";

                // Chamada ao DatabaseHelper (usando o caminho completo para evitar erros)
                DataTable dt = Veterinario.DAL.DatabaseHelper.ExecuteQuery(sql);

                if (dt != null)
                {
                    cbAnimais.DataSource = dt;
                    cbAnimais.DisplayMember = "Nome";      // O que o utilizador vê
                    cbAnimais.ValueMember = "AnimalID";    // O ID que guardamos no SQL
                    cbAnimais.SelectedIndex = -1;          // Começa vazio
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao preencher lista de animais: " + ex.Message);
            }
        }

        // Função para obter um dado específico de uma consulta
        public string GetDetalhesConsulta(int idConsulta)
        {
            string sql = "SELECT Observacoes FROM Consulta WHERE ConsultaID = @id";
            SqlParameter[] p = { new SqlParameter("@id", idConsulta) };

            DataTable dt = DatabaseHelper.ExecuteQuery(sql, p);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Observacoes"].ToString();
            }
            return "Nenhuma observação encontrada.";
        }

        private void btnVerFuturas_Click(object sender, EventArgs e)
        {
            EsconderPaineis();
            pnlVerConsultas.Visible = true;
            pnlVerConsultas.BringToFront();

            // Aproveita para carregar os dados da Grid que está dentro deste painel
            CarregarConsultasFuturas();
        }

        private void btnSalvarMarcacao_Click(object sender, EventArgs e)
        {
            EsconderPaineis();
            pnlMarcar.Visible = true;
            pnlMarcar.BringToFront();

            if (cbAnimais.DataSource == null)
            {
                PreencherListaAnimais();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validação básica: verificar se selecionou um animal
                if (cbAnimais.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, selecione um animal da lista!");
                    return;
                }

                // 2. Preparar o SQL de Inserção
                // Nota: Os nomes das colunas devem ser iguais aos da tua tabela no SQL Server
                string sql = "INSERT INTO Consulta (AnimalID, DataHora, Motivo) VALUES (@animalID, @data, @motivo)";

                // 3. Criar os parâmetros para evitar erros de formato e SQL Injection
                SqlParameter[] p = {
            new SqlParameter("@animalID", cbAnimais.SelectedValue),
            new SqlParameter("@data", dateTimePicker1.Value), // Confirma o nome do teu DateTimePicker
            new SqlParameter("@motivo", txtMotivo.Text)      // Confirma o nome da tua TextBox
        };

                // 4. Executar o comando através do teu DatabaseHelper
                int linhasAfetadas = Veterinario.DAL.DatabaseHelper.ExecuteCommand(sql, p);

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Consulta agendada com sucesso!");

                    // Limpar os campos para a próxima
                    txtMotivo.Clear();
                    cbAnimais.SelectedIndex = -1;

                    // Opcional: Mudar para o outro painel para ver a nova consulta na lista
                    btnVerFuturas_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar consulta: " + ex.Message);
            }
        }
    }
}
