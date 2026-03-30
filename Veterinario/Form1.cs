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
            string cargo;

            if (textBox1.Text == "gui@123")
            {
                cargo = "Rececionista";
            }
            else
            {
                cargo = "Veterinario";
            }

            if (cargo == "Rececionista")
            {
                btnHistoric.Visible = false;
            }

            panelBtn.Visible = true;

            panelLogin.Visible = false;
        }
    }
}
