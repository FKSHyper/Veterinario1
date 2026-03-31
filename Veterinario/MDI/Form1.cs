namespace Veterinario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelBtn.Visible = false;
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
                } else
                {
                    btnHistoric.Visible = true;
                }
            }
        }

        private void btnDef_Click(object sender, EventArgs e)
        {
            txtDef.Visible = true;
            txtSeta.Visible = true;
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
    }
}
