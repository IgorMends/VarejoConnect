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
using VarejoConnect.View.EditPage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VarejoConnect.View
{
    public partial class FuncionarioPage : Form
    {

        Actions actions = new Actions();
        BindingList<Funcionario> buscaFuncionarios = new BindingList<Funcionario>();
        BindingList<Funcionario> funcionarios = new BindingList<Funcionario>();
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id = 0;

        public FuncionarioPage()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = funcionarios;
            dataGridView1.Columns["senha"].Visible = false;
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
            textBoxes.Add(SenhaTextBox.Text);
            textBoxes.Add(CargoTextBox.Text);
            textBoxes.Add(SalarioTextBox.Text);
            textBoxes.Add(ConfirmarSenhaTextBox.Text);

            actions.verifyBlanksTextboxes(textBoxes);


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

                Funcionario funcionario = new Funcionario(id, NomeTextBox.Text.Trim(), SenhaTextBox.Text.Trim(), CargoTextBox.Text.Trim(), numSalario, dataAtual, dataAtual, "Admin");
                funcionarios.Add(funcionario);

                id++;

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

            if (TodosRadio.Checked)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = funcionarios;
                dataGridView1.Columns["senha"].Visible = false;
            }
            else
            {
                if (!(string.IsNullOrWhiteSpace(PesquisarTextBox.Text)))
                {
                    if (NomeRadio.Checked)
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
                    else if (IDRadio.Checked)
                    {
                        bool funcionarioExiste = false;

                        try
                        {
                            int numId = int.Parse(PesquisarTextBox.Text);
                        }
                        catch(FormatException ex)
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
                    else if (CargoRadio.Checked)
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
            PesquisarTextBox.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
