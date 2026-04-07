using Microsoft.Data.SqlClient;
using System.Data;
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
                // 1. Validações Iniciais
                if (cbAnimais.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, selecione um animal!");
                    return;
                }

                DateTime dataEscolhida = dateTimePicker1.Value;

                if (dataEscolhida < DateTime.Now)
                {
                    MessageBox.Show("Não podes marcar consultas para o passado!");
                    return;
                }

                // 2. VERIFICAÇÃO DE DISPONIBILIDADE
                // Vamos ver se já existe uma consulta marcada num intervalo de 30 minutos
                // (podes ajustar o tempo conforme a duração média das consultas)
                string sqlVerificar = @"SELECT COUNT(*) FROM Consulta 
                                WHERE DataHora >= DATEADD(minute, -30, @data) 
                                AND DataHora <= DATEADD(minute, 30, @data)";

                SqlParameter[] pVerificar = { new SqlParameter("@data", dataEscolhida) };

                // Executamos uma query que devolve apenas um número
                DataTable dt = Veterinario.DAL.DatabaseHelper.ExecuteQuery(sqlVerificar, pVerificar);
                int conflitos = Convert.ToInt32(dt.Rows[0][0]);

                if (conflitos > 0)
                {
                    MessageBox.Show("Já existe uma consulta marcada para este horário (ou muito próxima). Por favor, escolha outra hora!");
                    return; // Interrompe o código aqui e não faz o Insert
                }

                // 3. SE PASSOU NA VERIFICAÇÃO, FAZEMOS O INSERT
                string sqlInsert = "INSERT INTO Consulta (AnimalID, DataHora, Motivo) VALUES (@animalID, @data, @motivo)";

                SqlParameter[] pInsert = {
            new SqlParameter("@animalID", cbAnimais.SelectedValue),
            new SqlParameter("@data", dataEscolhida),
            new SqlParameter("@motivo", txtMotivo.Text)
        };

                int resultado = Veterinario.DAL.DatabaseHelper.ExecuteCommand(sqlInsert, pInsert);

                if (resultado > 0)
                {
                    MessageBox.Show("Consulta agendada com sucesso!");
                    txtMotivo.Clear();
                    cbAnimais.SelectedIndex = -1;

                    // Atualizar a lista automaticamente para ver a nova marcação
                    CarregarConsultasFuturas();

                    EsconderPaineis();
                    pnlVerConsultas.Visible = true;
                    pnlVerConsultas.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar/salvar: " + ex.Message);
            }
        }
    }
}
