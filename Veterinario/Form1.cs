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
                btn.Visible = false;
                button5.Visible = false;
                button4.Visible = false;
            }

            panelBtn.Visible = true;

            panelLogin.Visible = false;
        }
    }
}
