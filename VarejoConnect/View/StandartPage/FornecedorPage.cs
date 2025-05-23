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
using VarejoConnect.Model.Repositorios;
using VarejoConnect.Model;
using VarejoConnect.View.EditPage;
using VarejoConnect.View.RegisterPage;
using QuestPDF.Fluent;

namespace VarejoConnect.View.StandartPage
{
    public partial class FornecedorPage : Form
    {
        FornecedorRepositorio repository = new FornecedorRepositorio();
        Actions actions = new Actions();
        BindingList<Fornecedor> buscaFornecedores = new BindingList<Fornecedor>();
        BindingList<Fornecedor> fornecedores = new BindingList<Fornecedor>();
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public FornecedorPage()
        {
            InitializeComponent();
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = fornecedores;
            ConfigureDataGrid();
        }

        public void ConfigureDataGrid()
        {
            dataGridView1.Columns["status"].Visible = false;
            dataGridView1.Columns["funcionarioAlteracao"].Visible = false;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["documento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["funcionarioAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);

            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["nome"].HeaderText = "NOME";
            dataGridView1.Columns["telefone"].HeaderText = "TELEFONE";
            dataGridView1.Columns["documento"].HeaderText = "DOCUMENTO";
            dataGridView1.Columns["Empresa"].HeaderText = "EMPRESA";
            dataGridView1.Columns["dataAlteracao"].HeaderText = "DATA DE ALTERAÇÃO";
            dataGridView1.Columns["dataCriacao"].HeaderText = "DATA DE CRIAÇÃO";
            dataGridView1.Columns["funcionarioNome"].HeaderText = "ALTERADO POR";

        }

        public void ObterDados()
        {
            fornecedores = new BindingList<Fornecedor>(repository.getAllWithNames());
            id = repository.getHighestId() + 1;
        }

        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            SupplierRegisterPage supplierRegisterPage = new SupplierRegisterPage(fornecedores);

            supplierRegisterPage.ShowDialog();

            if (supplierRegisterPage.DialogResult == DialogResult.OK)
            {
                fornecedores = supplierRegisterPage.fornecedoresModal;
                fornecedores = new BindingList<Fornecedor>(repository.getAllWithNames());

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = fornecedores;

                ConfigureDataGrid();
                dataGridView1.Refresh();
                id++;
            }


            dataGridView1.Refresh();
        }

        private void BtnInativar_Click_1(object sender, EventArgs e)
        {
            Fornecedor fornecedorSelecionado;
            DataGridViewRow dataGridViewRow;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    dataGridViewRow = dataGridView1.SelectedRows[i];
                    fornecedorSelecionado = dataGridViewRow.DataBoundItem as Fornecedor;


                    if (fornecedorSelecionado != null)
                    {
                        fornecedores.Remove(fornecedorSelecionado);
                        buscaFornecedores.Remove(fornecedorSelecionado);
                        repository.RemoveFornecedor(fornecedorSelecionado);
                    }
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Nenhum Fornecedor selecionado!", "Error", MessageBoxButtons.OK);
            }
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
                Fornecedor fornecedorSelecionado = dataGridViewRow.DataBoundItem as Fornecedor;

                FornecedorEditPage editPage = new FornecedorEditPage(fornecedorSelecionado);
                int index = fornecedores.IndexOf(fornecedorSelecionado);
                editPage.ShowDialog();


                if (editPage.DialogResult == DialogResult.OK)
                {
                    fornecedores[index] = editPage.fornecedor;
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("É possivel editar apenas um fornecedor por vez!", "Error", MessageBoxButtons.OK);
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            buscaFornecedores.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = buscaFornecedores;
            ConfigureDataGrid();


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
                    dataGridView1.DataSource = fornecedores;
                    ConfigureDataGrid();
                }
                else
                {
                    if (!(string.IsNullOrWhiteSpace(PesquisarTextBox.Text)))
                    {
                        if (criterioBusca.Equals("NOME"))
                        {

                            bool fornecedorExiste = false;

                            foreach (var fornecedor in fornecedores)
                            {
                                if (fornecedor.nome.Contains(PesquisarTextBox.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                                {
                                    buscaFornecedores.Add(fornecedor);

                                    fornecedorExiste = true;
                                }
                            }

                            if (!fornecedorExiste)
                            {
                                MessageBox.Show("Fornecedor não está cadastrado", "Error", MessageBoxButtons.OK);
                            }
                            else
                            {
                                dataGridView1.Refresh();
                            }
                        }
                        else if (criterioBusca.Equals("ID"))
                        {
                            bool fornecedorExiste = false;
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


                            foreach (var fornecedor in fornecedores)
                            {
                                if (fornecedor.id == numId)
                                {
                                    buscaFornecedores.Add(fornecedor);

                                    fornecedorExiste = true;
                                }
                            }

                            if (!fornecedorExiste)
                            {
                                MessageBox.Show("Fornecedor não está cadastrado", "Error", MessageBoxButtons.OK);
                            }
                            else
                            {
                                dataGridView1.Refresh();
                            }
                        }
                        else if (criterioBusca.Equals("DOCUMENTO"))
                        {
                            bool fornecedorExiste = false;

                            foreach (var fornecedor in fornecedores)
                            {
                                if (fornecedor.documento.Equals(PesquisarTextBox.Text.Trim()))
                                {
                                    buscaFornecedores.Add(fornecedor);

                                    fornecedorExiste = true;
                                }
                            }

                            if (!fornecedorExiste)
                            {
                                MessageBox.Show("Não há nenhum Fornecedor com este cpf!", "Error", MessageBoxButtons.OK);
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

                bool fornecedorExiste = false;
                List<Fornecedor> fornecedoresRelatorio = new List<Fornecedor>();

                string pesquisa = RelatorioTextBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(pesquisa))
                {
                    foreach (var fornecedor in fornecedores)
                    {
                        fornecedoresRelatorio.Add(fornecedor);
                        fornecedorExiste = true;
                    }
                }
                else
                {
                    foreach (var fornecedor in fornecedores)
                    {
                        if (fornecedor.nome.Contains(pesquisa, StringComparison.OrdinalIgnoreCase))
                        {
                            fornecedoresRelatorio.Add(fornecedor);
                            fornecedorExiste = true;
                        }
                    }
                }

                if (!fornecedorExiste)
                {
                    MessageBox.Show("Nenhum fornecedor com este nome!", "Error", MessageBoxButtons.OK);
                }



                QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
                string dataAtual = DateTime.Now.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture);
                string titulo = $"Relatório De Fornecedor Por Nome - {dataAtual}";

                string diretorio = @"C:\Users\William\Desktop";
                if (!Directory.Exists(diretorio))
                {
                    MessageBox.Show("Diretorio Incorreto, verificar!", "Error", MessageBoxButtons.OK);
                    return;
                }

                string nomeArquivo = Path.Combine(diretorio, $"relatorio-Fornecedor-Por-Nome-{dataAtual}.pdf");

                var relatorio = new RelatorioFornecedores(fornecedoresRelatorio, titulo);
                relatorio.GeneratePdf(nomeArquivo);
            }
        }
    }
}
