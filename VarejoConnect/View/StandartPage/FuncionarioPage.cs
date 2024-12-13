using QuestPDF.Fluent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarejoConnect.Controller;
using VarejoConnect.Model;
using VarejoConnect.Model.Repositorios;
using VarejoConnect.View.EditPage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VarejoConnect.View
{
    public partial class FuncionarioPage : Form
    {

        FuncionarioRepositorio repository = new FuncionarioRepositorio();
        Actions actions = new Actions();
        BindingList<Funcionario> buscaFuncionarios = new BindingList<Funcionario>();
        BindingList<Funcionario> funcionarios;
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public FuncionarioPage()
        {
            InitializeComponent();
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = funcionarios;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["senha"].Visible = false;
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["salario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["funcionarioAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["salario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["salario"].DefaultCellStyle.Format = "N2";
        }

        public void ObterDados()
        {
            funcionarios = new BindingList<Funcionario>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FuncionarioPage_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxes.Clear();
            textBoxes.Add(NomeTextBox.Text);
            textBoxes.Add(LoginTextBox.Text);
            textBoxes.Add(SenhaTextBox.Text);
            textBoxes.Add(CargoTextBox.Text);
            textBoxes.Add(LoginTextBox.Text);
            textBoxes.Add(SalarioTextBox.Text);
            textBoxes.Add(ConfirmarSenhaTextBox.Text);

            bool isblank = actions.verifyBlanksTextboxes(textBoxes);

            if (isblank)
            {
                return;
            }


            if (ConfirmarSenhaTextBox.Text.Equals(SenhaTextBox.Text))
            {

                foreach (var text in funcionarios)
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
                    numSalario = double.Parse(SalarioTextBox.Text.Trim());
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Você tem que digitar apenas numeros no campo de Salário", "Error", MessageBoxButtons.OK);
                    return;
                }

                Funcionario funcionario = new Funcionario(id, LoginTextBox.Text.Trim(), NomeTextBox.Text.Trim().ToUpper(), SenhaTextBox.Text.Trim(), CargoTextBox.Text.Trim().ToUpper(), numSalario, dataAtual, dataAtual, Global.funcionarioLogado);
                funcionarios.Add(funcionario);
                repository.Add(funcionario);

                id++;

                LoginTextBox.Clear();
                NomeTextBox.Clear();
                SenhaTextBox.Clear();
                CargoTextBox.Clear();
                SalarioTextBox.Clear();
                ConfirmarSenhaTextBox.Clear();
            }
            else
            {
                MessageBox.Show("As senhas não conferem", "Erro", MessageBoxButtons.OK);
            }

            dataGridView1.Refresh();
        }

        private void BtnInativar_Click(object sender, EventArgs e)
        {

            Funcionario funcionarioSelecionado;
            DataGridViewRow dataGridViewRow;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    dataGridViewRow = dataGridView1.SelectedRows[i];
                    funcionarioSelecionado = dataGridViewRow.DataBoundItem as Funcionario;


                    if (funcionarioSelecionado != null)
                    {
                        funcionarios.Remove(funcionarioSelecionado);
                        buscaFuncionarios.Remove(funcionarioSelecionado);
                        repository.RemoveFuncionario(funcionarioSelecionado);
                    }
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Nenhum Funcionário selecionado", "Error", MessageBoxButtons.OK);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
                Funcionario funcionarioSelecionado = dataGridViewRow.DataBoundItem as Funcionario;

                FuncionarioEditPage editPage = new FuncionarioEditPage(funcionarioSelecionado);
                int index = funcionarios.IndexOf(funcionarioSelecionado);
                editPage.ShowDialog();


                if (editPage.DialogResult == DialogResult.OK)
                {
                    funcionarios[index] = editPage.funcionario;
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("É possivel editar apenas um funcionário por vez!", "Error", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

            buscaFuncionarios.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = buscaFuncionarios;
            dataGridView1.Columns["senha"].Visible = false;
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["salario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["funcionarioAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["salario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["salario"].DefaultCellStyle.Format = "N2";


            string criterioBusca = SearchOptions.SelectedItem?.ToString();

            if (criterioBusca == null)
            {
                MessageBox.Show("Você precisa selecionar um método de busca!", "Error", MessageBoxButtons.OK);
            }
            else
            {



                if (criterioBusca.Equals("SEM FILTRO"))
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = funcionarios;
                    dataGridView1.Columns["senha"].Visible = false;
                }
                else
                {
                    if (!(string.IsNullOrWhiteSpace(PesquisarTextBox.Text)))
                    {
                        if (criterioBusca.Equals("NOME"))
                        {

                            bool funcionarioExiste = false;

                            foreach (var funcionario in funcionarios)
                            {
                                if (funcionario.nome.Contains(PesquisarTextBox.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                                {
                                    buscaFuncionarios.Add(funcionario);

                                    funcionarioExiste = true;
                                }
                            }

                            if (!funcionarioExiste)
                            {
                                MessageBox.Show("Funcionário não está cadastrado", "Error", MessageBoxButtons.OK);
                            }
                            else
                            {
                                dataGridView1.Refresh();
                            }
                        }
                        else if (criterioBusca.Equals("ID"))
                        {
                            bool funcionarioExiste = false;

                            try
                            {
                                int numId = int.Parse(PesquisarTextBox.Text);
                            }
                            catch (FormatException ex)
                            {
                                MessageBox.Show("Você tem que digitar apenas numeros", "Error", MessageBoxButtons.OK);
                                return;
                            }


                            foreach (var funcionario in funcionarios)
                            {
                                if (funcionario.id == int.Parse(PesquisarTextBox.Text))
                                {
                                    buscaFuncionarios.Add(funcionario);

                                    funcionarioExiste = true;
                                }
                            }

                            if (!funcionarioExiste)
                            {
                                MessageBox.Show("Funcionário não está cadastrado", "Error", MessageBoxButtons.OK);
                            }
                            else
                            {
                                dataGridView1.Refresh();
                            }
                        }
                        else if (criterioBusca.Equals("CARGO"))
                        {
                            bool funcionarioExiste = false;

                            foreach (var funcionario in funcionarios)
                            {
                                if (funcionario.cargo.Equals(PesquisarTextBox.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                                {
                                    buscaFuncionarios.Add(funcionario);

                                    funcionarioExiste = true;
                                }
                            }

                            if (!funcionarioExiste)
                            {
                                MessageBox.Show("Não há nenhum funcionário com este cargo, ou cargo inexistente", "Error", MessageBoxButtons.OK);
                            }
                            else
                            {
                                dataGridView1.Refresh();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Marque uma das opções de busca!", "Error", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Você não digitou nenhum termo para ser pesquisado!", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            PesquisarTextBox.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você quer gerar o relatorio em PDF?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {

                bool funcionarioExiste = false;
                List<Funcionario> funcionariosRelatorio = new List<Funcionario>();

                string pesquisa = RelatorioTextBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(pesquisa))
                {
                    foreach (var funcionario in funcionarios)
                    {
                        funcionariosRelatorio.Add(funcionario);
                        funcionarioExiste = true;
                    }
                }
                else
                {
                    foreach (var funcionario in funcionarios)
                    {
                        if (funcionario.nome.Contains(pesquisa, StringComparison.OrdinalIgnoreCase))
                        {
                            funcionariosRelatorio.Add(funcionario);
                            funcionarioExiste = true;
                        }
                    }
                }

                if (!funcionarioExiste)
                {
                    MessageBox.Show("Nenhum funcionario com este nome!", "Error", MessageBoxButtons.OK);
                }



                QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
                string dataAtual = DateTime.Now.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture);
                string titulo = $"Relatório De Funcionários Por Nome - {dataAtual}";

                string diretorio = @"C:\Users\claud\OneDrive\Desktop";
                if (!Directory.Exists(diretorio))
                {
                    MessageBox.Show("Diretorio Incorreto, verificar!", "Error", MessageBoxButtons.OK);
                    return;
                }

                string nomeArquivo = Path.Combine(diretorio, $"relatorio-Funcionrios-Por-Nome-{dataAtual}.pdf");

                var relatorio = new RelatorioFuncionarios(funcionariosRelatorio, titulo);
                relatorio.GeneratePdf(nomeArquivo);
            }
        }
    }
}
