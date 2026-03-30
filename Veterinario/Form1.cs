namespace Veterinario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelBtn.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool loginSuccessful = false;

            if (txtLogin.Text == FuncionarioID && txtPass.Text == Pass)
            {
                MessageBox.Show("Login bem-sucedido!");
                loginSuccessful = true;
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
                if (Funcao == "Rececionista")
                {
                    btnHistoric.Visible = false;
                }
            }

            panelBtn.Visible = true;

            panelLogin.Visible = false;
        }
    }
}
