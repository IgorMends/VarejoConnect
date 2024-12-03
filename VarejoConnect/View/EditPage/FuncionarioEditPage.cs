using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarejoConnect.Controller;
using VarejoConnect.Model;
using VarejoConnect.Model.Repositorios;

namespace VarejoConnect.View.EditPage
{
    public partial class FuncionarioEditPage : Form
    {

        FuncionarioRepositorio repository = new FuncionarioRepositorio();
        public Funcionario funcionario { get; set; }
        Actions actions = new Actions();
        private Funcionario funcionarioLogado;

        public FuncionarioEditPage(Funcionario funcionario)
        {
            InitializeComponent();
            funcionarioLogado = repository.getById(Global.funcionarioLogado);
            this.funcionario = funcionario;
            textBox1.Text = funcionario.nome.Trim();
            textBox2.Text = funcionario.salario.ToString().Trim();
            textBox3.Text = funcionario.cargo.Trim();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Equals(funcionarioLogado.senha))
            {
                this.funcionario.nome = textBox1.Text.Trim();
                this.funcionario.salario = double.Parse(textBox2.Text.Trim());
                this.funcionario.cargo = textBox3.Text.Trim().ToUpper();
                this.funcionario.dataAlteracao = DateTime.Today;
                this.funcionario.funcionarioAlteracao = Global.funcionarioLogado;
                repository.UpdateFuncionario(funcionario);
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha incorreta, tente novamente!", "Error", MessageBoxButtons.OK);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FuncionarioEditPage_Load(object sender, EventArgs e)
        {

        }
    }
}
