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
using VarejoConnect.View.EditPage;
using QuestPDF.Fluent;
using System.Globalization;

namespace VarejoConnect.View
{
    public partial class ClientePage : Form
    {

        ClienteRepositorio repository = new ClienteRepositorio();
        Actions actions = new Actions();
        BindingList<Cliente> buscaClientes = new BindingList<Cliente>();
        BindingList<Cliente> clientes = new BindingList<Cliente>();
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public ClientePage()
        {
            InitializeComponent();
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clientes;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["cpf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["funcionarioAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void ObterDados()
        {
            clientes = new BindingList<Cliente>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            textBoxes.Clear();
            textBoxes.Add(NomeTextBox.Text);
            textBoxes.Add(CpfTextBox.Text);
            textBoxes.Add(EmailTextBox.Text);
            textBoxes.Add(TelefoneTextBox.Text);

            bool isblank = actions.verifyBlanksTextboxes(textBoxes);

            if (isblank)
            {
                return;
            }


            foreach (var text in clientes)
            {
                if (text.nome.Equals(NomeTextBox.Text))
                {
                    MessageBox.Show("Este cliente já esta cadastrado!", "Erro", MessageBoxButtons.OK);
                    return;
                }
            }

            long numCPF;
            long numTel;


            try
            {
                numTel = long.Parse(TelefoneTextBox.Text.Trim());
                if (numTel.ToString().Length != 11)
                {
                    MessageBox.Show("O campo de telefone precisa ter 11 numeros, incluindo DDD!");
                    return;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Você tem que digitar apenas numeros no campo de Telefone", "Error", MessageBoxButtons.OK);
                return;
            }

            try
            {
                numCPF = long.Parse(CpfTextBox.Text.Trim());
                numTel = long.Parse(TelefoneTextBox.Text.Trim());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Você tem que digitar apenas numeros no campo de CPF", "Error", MessageBoxButtons.OK);
                return;
            }

            Cliente cliente = new Cliente(id, NomeTextBox.Text.Trim().ToUpper(), CpfTextBox.Text.Trim(), EmailTextBox.Text.Trim(), TelefoneTextBox.Text.Trim(), dataAtual, dataAtual, Global.funcionarioLogado);
            clientes.Add(cliente);
            repository.Add(cliente);

            id++;

            NomeTextBox.Clear();
            CpfTextBox.Clear();
            EmailTextBox.Clear();
            TelefoneTextBox.Clear();

            dataGridView1.Refresh();
        }

        private void BtnInativar_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado;
            DataGridViewRow dataGridViewRow;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    dataGridViewRow = dataGridView1.SelectedRows[i];
                    clienteSelecionado = dataGridViewRow.DataBoundItem as Cliente;


                    if (clienteSelecionado != null)
                    {
                        clientes.Remove(clienteSelecionado);
                        buscaClientes.Remove(clienteSelecionado);
                        repository.RemoveCliente(clienteSelecionado);
                    }
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Nenhum Cliente selecionado!", "Error", MessageBoxButtons.OK);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
                Cliente clienteSelecionado = dataGridViewRow.DataBoundItem as Cliente;

                ClienteEditPage editPage = new ClienteEditPage(clienteSelecionado);
                int index = clientes.IndexOf(clienteSelecionado);
                editPage.ShowDialog();


                if (editPage.DialogResult == DialogResult.OK)
                {
                    clientes[index] = editPage.cliente;
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("É possivel editar apenas um cliente por vez!", "Error", MessageBoxButtons.OK);
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            buscaClientes.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = buscaClientes;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["cpf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["funcionarioAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


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
                    dataGridView1.DataSource = clientes;
                }
                else
                {
                    if (!(string.IsNullOrWhiteSpace(PesquisarTextBox.Text)))
                    {
                        if (criterioBusca.Equals("NOME"))
                        {

                            bool clienteExiste = false;

                            foreach (var cliente in clientes)
                            {
                                if (cliente.nome.Contains(PesquisarTextBox.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                                {
                                    buscaClientes.Add(cliente);

                                    clienteExiste = true;
                                }
                            }

                            if (!clienteExiste)
                            {
                                MessageBox.Show("Cliente não está cadastrado", "Error", MessageBoxButtons.OK);
                            }
                            else
                            {
                                dataGridView1.Refresh();
                            }
                        }
                        else if (criterioBusca.Equals("ID"))
                        {
                            bool clienteExiste = false;
                            int numId;

                            try
                            {
                                numId = int.Parse(PesquisarTextBox.Text);
                            }
                            catch (FormatException ex)
                            {
                                MessageBox.Show("Você tem que digitar apenas numeros", "Error", MessageBoxButtons.OK);
                                return;
                            }


                            foreach (var cliente in clientes)
                            {
                                if (cliente.id == numId)
                                {
                                    buscaClientes.Add(cliente);

                                    clienteExiste = true;
                                }
                            }

                            if (!clienteExiste)
                            {
                                MessageBox.Show("Cliente não está cadastrado", "Error", MessageBoxButtons.OK);
                            }
                            else
                            {
                                dataGridView1.Refresh();
                            }
                        }
                        else if (criterioBusca.Equals("CARGO"))
                        {
                            bool clienteExiste = false;

                            foreach (var cliente in clientes)
                            {
                                if (cliente.cpf.Equals(PesquisarTextBox.Text.Trim()))
                                {
                                    buscaClientes.Add(cliente);

                                    clienteExiste = true;
                                }
                            }

                            if (!clienteExiste)
                            {
                                MessageBox.Show("Não há nenhum cliente com este cpf!", "Error", MessageBoxButtons.OK);
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você quer gerar o relatorio em PDF?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {

                bool clienteExiste = false;
                List<Cliente> clientesRelatorio = new List<Cliente>();

                string pesquisa = RelatorioTextBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(pesquisa))
                {
                    foreach (var cliente in clientes)
                    {                        
                        clientesRelatorio.Add(cliente);
                        clienteExiste = true;                        
                    }
                }
                else
                {
                    foreach (var cliente in clientes)
                    {
                        if (cliente.nome.Contains(pesquisa, StringComparison.OrdinalIgnoreCase))
                        {
                            clientesRelatorio.Add(cliente);
                            clienteExiste = true;
                        }
                    }
                }

                if (!clienteExiste)
                {
                    MessageBox.Show("Nenhum cliente com este nome!", "Error", MessageBoxButtons.OK);
                }



                QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
                string dataAtual = DateTime.Now.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture);
                string titulo = $"Relatório De Clientes Por Nome - {dataAtual}";

                string diretorio = @"C:\Users\claud\OneDrive\Desktop";
                if (!Directory.Exists(diretorio))
                {
                    MessageBox.Show("Diretorio Incorreto, verificar!", "Error", MessageBoxButtons.OK);
                    return;
                }

                string nomeArquivo = Path.Combine(diretorio, $"relatorio-Clientes-Por-Nome-{dataAtual}.pdf");

                var relatorio = new RelatorioClientes(clientesRelatorio, titulo);
                relatorio.GeneratePdf(nomeArquivo);
            }
        }
    }
}
