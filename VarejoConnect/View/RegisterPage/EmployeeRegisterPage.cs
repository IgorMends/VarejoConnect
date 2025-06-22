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
using VarejoConnect.Model.Repositorios;
using VarejoConnect.Model;

namespace VarejoConnect.View.RegisterPage
{
    public partial class EmployeeRegisterPage : Form
    {

        FuncionarioRepositorio repository = new FuncionarioRepositorio();
        public BindingList<Funcionario> funcionariosModal = new BindingList<Funcionario>();
        LogsRepositorio logs = new LogsRepositorio();   
        List<string> textBoxes = new List<string>();
        Actions actions = new Actions();
        int id;

        public EmployeeRegisterPage(BindingList<Funcionario> funcionariosList)
        {
            funcionariosModal = funcionariosList;
            id = repository.getHighestId() + 1;
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            textBoxes.Add(LoginTextBox.Text);
            textBoxes.Add(NomeTextBox.Text);
            textBoxes.Add(PositionTextBox.Text);
            textBoxes.Add(PasswordTextBox.Text);
            textBoxes.Add(ConfirmPasswordTextBox.Text);
            textBoxes.Add(SalaryTextBox.Text);

            bool isblank = actions.verifyBlanksTextboxes(textBoxes);

            if (isblank)
            {
                return;
            }


            if (ConfirmPasswordTextBox.Text.Equals(PasswordTextBox.Text))
            {

                foreach (var text in funcionariosModal)
                {
                    if (text.nome.Equals(NomeTextBox.Text))
                    {
                        MessageBox.Show("Este funcionário já esta cadastrado!", "Erro", MessageBoxButtons.OK);
                        return;
                    }
                }

                double numSalario;

                try
                {
                    numSalario = double.Parse(SalaryTextBox.Text.Trim());
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Você tem que digitar apenas numeros no campo de Salário", "Error", MessageBoxButtons.OK);
                    return;
                }

                Funcionario funcionario = new Funcionario(id, LoginTextBox.Text.Trim(), NomeTextBox.Text.Trim().ToUpper(), PasswordTextBox.Text.Trim(), PositionTextBox.Text.Trim().ToUpper(), numSalario, DateTime.Today, DateTime.Today, Global.funcionarioLogado, true);
                funcionariosModal.Add(funcionario);
                repository.Add(funcionario);
                Logs log = new Logs(DateTime.UtcNow, Global.funcionarioLogado, "FUNCIONARIO", funcionario.id, "FUNCIONARIO CADASTRADO");
                logs.Add(log);

                this.DialogResult = DialogResult.OK;    
                this.Close();
            }
            else
            {
                MessageBox.Show("As senhas não conferem", "Erro", MessageBoxButtons.OK);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeRegisterPage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
