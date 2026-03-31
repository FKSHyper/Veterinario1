using Veterinario.MDI;
using Veterinario.Classes;
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

        }

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
                    MessageBox.Show("Login bem-sucedido!");
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
                    MessageBox.Show("Login bem-sucedido!");
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

        private void btnHistoric_Click(object sender, EventArgs e)
        {
            Historico historicoForm = new Historico();
            historicoForm.ShowDialog();
        }

        private void plAnimal_Paint(object sender, PaintEventArgs e)
        {
            plAnimal.Visible = true;
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
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
            else
            {
                Cliente novoCliente = new Cliente(textBox1.Text, int.Parse(textBox2.Text), textBox3.Text, textBox4.Text, textBox5.Text);
                MessageBox.Show($"Novo Cliente registrado");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

                plCliente.Visible = false;
                plAnimal.Visible = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text) ||
                string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox9.Text) ||
                string.IsNullOrWhiteSpace(textBox10.Text) || string.IsNullOrWhiteSpace(textBox11.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
            else
            {
                Animal novoAnimal = new Animal(textBox6.Text, textBox7.Text, textBox8.Text, int.Parse(textBox9.Text), int.Parse(textBox10.Text), int.Parse(textBox11.Text));
                MessageBox.Show($"Novo Animal registrado");
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            panelBtn.Visible = false;
            panelLogin.Visible = true;
            txtLogin.Clear();
            txtPass.Clear();

            MessageBox.Show("Logout efetuado com sucesso!");

            btnLogout.Visible = false;
        }

        private void btnCons_Click(object sender, EventArgs e)
        {
            FormConsulta consulta = new FormConsulta();

            consulta.ShowDialog();
        }
    }
}
