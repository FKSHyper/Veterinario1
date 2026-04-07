using Microsoft.Data.SqlClient;
using System.Data;
using Veterinario.Classes;
using Veterinario.DAL;
using Veterinario.MDI;
namespace Veterinario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelBtn.Visible = false;
            plCliente.Visible = false;
            plAnimal.Visible = false;
            btnLogout.Visible = false;
            btnAddAnimal.Click += AdicionarAnimal;
            AtualizarGrelha();

        }

        private int idDonoAtual;

        private string nomeDonoAtual;

        private void button7_Click(object sender, EventArgs e)
        {

            string FuncionarioID = "100";
            string passFunc1 = "123";
            string Funcao = "Rececionista";

            string FuncionarioID2 = "200";
            string passFunc2 = "456";
            string Funcao2 = "Veterinário";

            string funcaoLog = "";
            string idLog = "";

            bool loginSuccessful = false;

            if (txtLogin.Text == FuncionarioID)
            {
                if (txtPass.Text == passFunc1)
                {
                    funcaoLog = Funcao;
                    idLog = txtLogin.Text;
                    loginSuccessful = true;
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos. Tente novamente.");
                    txtLogin.Clear();
                    txtPass.Clear();
                    loginSuccessful = false;
                }
            }
            else if (txtLogin.Text == FuncionarioID2)
            {
                if (txtPass.Text == passFunc2)
                {
                    funcaoLog = Funcao2;
                    idLog = txtLogin.Text;
                    loginSuccessful = true;
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos. Tente novamente.");
                    txtLogin.Clear();
                    txtPass.Clear();
                    loginSuccessful = false;
                }
            }
            else if (txtLogin.Text == null || txtPass.Text == null)
            {
                MessageBox.Show("Deve entrar com suas credenciais!");
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos. Tente novamente.");
                txtLogin.Clear();
                txtPass.Clear();
                loginSuccessful = false;
            }

            if (loginSuccessful)
            {

                MessageBox.Show($"Bem-vindo, {idLog} {funcaoLog}!");
                btnLogout.Visible = true;
                panelBtn.Visible = true;
                panelLogin.Visible = false;

                if (funcaoLog == "Rececionista")
                {
                    btnHistoric.Visible = false;
                }
                else
                {
                    btnHistoric.Visible = true;
                }
                panelBtn.Visible = true;

                panelLogin.Visible = false;

            }
        }

        private void btnDef_Click(object sender, EventArgs e)
        {
            txtDef.Visible = true;
            txtSeta.Visible = true;
        }

        private void AdicionarAnimal(object sender, EventArgs e)
        {
            plCliente.Visible = false;
            plAnimal.Visible = true;
            if (string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text) ||
                string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox9.Text) ||
                string.IsNullOrWhiteSpace(textBox10.Text) || string.IsNullOrWhiteSpace(textBox11.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
            else
            {
                string sql = "INSERT INTO Animal (Nome, Especie, Raca, Idade, Peso, Chip, ClienteID) " +
                 "VALUES (@nome, @esp, @raca, @idade, @peso, @chip, @clienteID)";

                SqlParameter[] ps = {
                    new SqlParameter("@nome", textBox6.Text),
                    new SqlParameter("@esp", textBox7.Text),
                    new SqlParameter("@raca", textBox8.Text),
                    new SqlParameter("@idade", int.Parse(textBox9.Text)),
                    new SqlParameter("@peso", float.Parse(textBox10.Text)),
                    new SqlParameter("@chip", textBox11.Text),
                    new SqlParameter("@clienteID", idDonoAtual) // <-- O ID que guardamos no botão com o nome do cliente!
                };

                int res = DatabaseHelper.ExecuteCommand(sql, ps);
                if (res > 0) MessageBox.Show("Animal associado ao dono com sucesso!");
                AtualizarGrelha();
                textBox6.Clear(); textBox7.Clear(); textBox8.Clear(); textBox9.Clear(); textBox10.Clear(); textBox11.Clear();
            }
        }

        private void btnHistoric_Click(object sender, EventArgs e)
        {
            Historico historicoForm = new Historico();
            historicoForm.ShowDialog();
        }

        private void plAnimal_Paint(object sender, PaintEventArgs e)
        {
            plAnimal.BringToFront();
            plAnimal.Visible = true;
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            plCliente.BringToFront();
            plCliente.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
            else if (Cliente.GetTelefone(textBox3.Text) == null || Cliente.GetEmail(textBox4.Text) == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
            else if (!int.TryParse(textBox2.Text, out int nif))
            {
                MessageBox.Show("O NIF deve ser um número válido.");
                return;
            }
            else if (!int.TryParse(textBox3.Text, out int telefone))
            {
                MessageBox.Show("O telefone deve ser um número válido.");
                return;
            }
            else
            {
                // 1. Criamos o comando SQL (ID não entra, pois é IDENTITY)
                string sql = "INSERT INTO Cliente (Nome, Nif, Telefone, Email, Morada) VALUES (@nome, @nif, @tel, @email, @morada); SELECT SCOPE_IDENTITY(); ";

                // 2. Criamos os parâmetros para segurança
                SqlParameter[] ps = {
                    new SqlParameter("@nome", textBox1.Text),
                    new SqlParameter("@nif", nif),
                    new SqlParameter("@tel", telefone),
                    new SqlParameter("@email", textBox4.Text),
                    new SqlParameter("@morada", textBox5.Text)
             };

                DataTable dt = DatabaseHelper.ExecuteQuery(sql, ps);

                if (dt != null && dt.Rows.Count > 0)
                {
                    // Guardamos o ID para usar no botão do Animal depois
                    idDonoAtual = Convert.ToInt32(dt.Rows[0][0]);
                    nomeDonoAtual = textBox1.Text;
                    textBox13.Text = nomeDonoAtual;

                    MessageBox.Show("Cliente registado com sucesso! ID: " + idDonoAtual);

                    // Limpar campos e trocar painel
                    textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();
                    plCliente.Visible = false;
                    plAnimal.Visible = true;
                }
                else
                {
                    MessageBox.Show("Erro ao gravar no banco de dados.");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdicionarAnimal(null, null);
            textBox13.ReadOnly = true;
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            AdicionarAnimal(null, null);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();

            MessageBox.Show("Logout efetuado com sucesso!");

        }

        private void AtualizarGrelha()
        {
            string sql = @"SELECT c.Nome, c.Nif, c.Telefone, c.Email, c.Morada, 
                          a.Nome as Animal, a.Especie, a.Chip
                   FROM Cliente c
                   LEFT JOIN Animal a ON c.ClienteID = a.ClienteID";

            DataTable dt = DatabaseHelper.ExecuteQuery(sql);

            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nifAlvo = textBox12.Text;

            FiltroUsuario filtro = new FiltroUsuario();
            DataTable dt = filtro.FiltrarDados(nifAlvo);

            if (dt != null && dt.Rows.Count > 0)
            {

                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show($"Nenhum cliente encontrado com o NIF {textBox12.Text}.");
                AtualizarGrelha();
            }
        }

        private void btnCons_Click(object sender, EventArgs e)
        {
            FormConsulta consulta = new FormConsulta();

            consulta.ShowDialog();
        }

    }
}
