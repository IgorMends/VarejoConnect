using VarejoConnect.Controller;
using VarejoConnect.Model;
using VarejoConnect.Model.Repositorios;
using VarejoConnect.View;

namespace VarejoConnect
{
    public partial class LoginPage : Form
    {

        public List<Funcionario> funcionarios;

        public LoginPage()
        {
            InitializeComponent();
            ObterFuncionarios();
        }

        private void ObterFuncionarios()
        {
            var repository = new FuncionarioRepositorio();
            funcionarios = repository.GetAll();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool funcExiste = false;
            
            foreach(var funcionario in funcionarios)
            {
                if (funcionario.login.Equals(textBox1.Text) && funcionario.senha.Equals(textBox2.Text))
                {
                    funcExiste = true;
                    Global.funcionarioLogado = funcionario.id;
                    this.Hide();
                    HomePage adminHomePage = new HomePage();
                    adminHomePage.Show();
                    break;
                }
            }

            if(!funcExiste)
            {
                MessageBox.Show("Usuário não cadastrado!", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
