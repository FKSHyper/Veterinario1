using Microsoft.Data.SqlClient;
using System.Data;
using Veterinario.DAL;

namespace Veterinario.MDI
{
    public partial class Historico : Form
    {
        public Historico()
        {
            InitializeComponent();
        }

        public void PreencherListaAnimais()
        {
            // 1. Query para buscar o ID e o Nome (para o utilizador saber quem é quem)
            string sql = "SELECT AnimalID, Nome FROM Animal ORDER BY Nome ASC";

            // 2. Chamar a DatabaseHelper (não precisa de parâmetros aqui)
            DataTable dtAnimais = DatabaseHelper.ExecuteQuery(sql);

            // 3. Configurar a ComboBox
            cbAnimais.DataSource = dtAnimais;

            // O que o utilizador VÊ (o nome do cão/gato)
            cbAnimais.DisplayMember = "Nome";

            // O que o código GUARDA (o ID para a FK da Consulta)
            cbAnimais.ValueMember = "AnimalID";

            // Opcional: Começar sem nenhum animal selecionado
            cbAnimais.SelectedIndex = -1;
        }

        private void CarregarHistorico(int idDoAnimal)
        {
            // Seleciona apenas consultas com data anterior a "agora"
            string sql = @"SELECT DataHora AS [Data], Motivo, Observacoes 
                   FROM Consulta 
                   WHERE AnimalID = @id AND DataHora < GETDATE() 
                   ORDER BY DataHora DESC";

            // 2. Criar o parâmetro
            SqlParameter[] p =
            {
                new SqlParameter("@id", idDoAnimal)
            };

            // 3. Chamar a DatabaseHelper e guardar no DataTable
            DataTable dt = DatabaseHelper.ExecuteQuery(sql, p);

            // 4. Mostrar no DataGridView que tens no Design
            dgvHistorico.DataSource = dt;

            // Dica: Formatar a coluna da Data para ficar legível em PT-PT
            dgvHistorico.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAnimais.SelectedValue != null && cbAnimais.SelectedIndex != -1)
            {
                if (cbAnimais.SelectedValue != null && cbAnimais.SelectedIndex != -1)
                {
                    // Se o valor for um DataRowView (o que causa o erro), pegamos o campo ID dele
                    if (cbAnimais.SelectedValue is DataRowView drv)
                    {
                        int idSelecionado = Convert.ToInt32(drv["AnimalID"]);
                        CarregarHistorico(idSelecionado);
                    }
                    else
                    {
                        // Se já for o ID diretamente, convertemos normalmente
                        int idSelecionado = Convert.ToInt32(cbAnimais.SelectedValue);
                        CarregarHistorico(idSelecionado);
                    }
                }
            }
        }

        private void Historico_Load(object sender, EventArgs e)
        {
            PreencherListaAnimais();
        }
    }
}
