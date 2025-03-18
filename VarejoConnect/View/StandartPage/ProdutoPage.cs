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
using VarejoConnect.View.RegisterPage;

namespace VarejoConnect.View
{
    public partial class ProdutoPage : Form
    {
        ProdutoRepositorio repository = new ProdutoRepositorio();
        Actions actions = new Actions();
        BindingList<Produto> buscaProdutos = new BindingList<Produto>();
        BindingList<Produto> produtos = new BindingList<Produto>();
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public ProdutoPage()
        {
            InitializeComponent();
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = produtos;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["preco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["funcionarioAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["preco"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["preco"].DefaultCellStyle.Format = "N2";
        }

        public void ObterDados()
        {
            produtos = new BindingList<Produto>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            ProductRegisterPage productRegisterPage = new ProductRegisterPage(produtos);

            productRegisterPage.ShowDialog();

            if (productRegisterPage.DialogResult == DialogResult.OK)
            {
                produtos = productRegisterPage.produtosModal;
                id++;
            }

            dataGridView1.Refresh();
        }

        private void BtnInativar_Click(object sender, EventArgs e)
        {
            Produto produtoSelecionado;
            DataGridViewRow dataGridViewRow;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    dataGridViewRow = dataGridView1.SelectedRows[i];
                    produtoSelecionado = dataGridViewRow.DataBoundItem as Produto;


                    if (produtoSelecionado != null)
                    {
                        produtos.Remove(produtoSelecionado);
                        buscaProdutos.Remove(produtoSelecionado);
                        repository.RemoveProduto(produtoSelecionado);
                    }
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado", "Error", MessageBoxButtons.OK);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
                Produto produtoSelecionado = dataGridViewRow.DataBoundItem as Produto;

                ProdutoEditPage editPage = new ProdutoEditPage(produtoSelecionado);
                int index = produtos.IndexOf(produtoSelecionado);
                editPage.ShowDialog();


                if (editPage.DialogResult == DialogResult.OK)
                {
                    produtos[index] = editPage.produto;
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("É possivel editar apenas um produto por vez!", "Error", MessageBoxButtons.OK);
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            buscaProdutos.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = buscaProdutos;
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["preco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["funcionarioAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["preco"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["preco"].DefaultCellStyle.Format = "N2";


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
                    dataGridView1.DataSource = produtos;
                }
                else
                {
                    if (!(string.IsNullOrWhiteSpace(PesquisarTextBox.Text)))
                    {
                        if (criterioBusca.Equals("NOME"))
                        {

                            bool produtoExiste = false;

                            foreach (var produto in produtos)
                            {
                                if (produto.nome.Contains(PesquisarTextBox.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                                {
                                    buscaProdutos.Add(produto);

                                    produtoExiste = true;
                                }
                            }

                            if (!produtoExiste)
                            {
                                MessageBox.Show("Produto não está cadastrado", "Error", MessageBoxButtons.OK);
                            }
                            else
                            {
                                dataGridView1.Refresh();
                            }
                        }
                        else if (criterioBusca.Equals("ID"))
                        {
                            bool produtoExiste = false;

                            try
                            {
                                int numId = int.Parse(PesquisarTextBox.Text);
                            }
                            catch (FormatException ex)
                            {
                                MessageBox.Show("Você tem que digitar apenas numeros", "Error", MessageBoxButtons.OK);
                                return;
                            }


                            foreach (var produto in produtos)
                            {
                                if (produto.id == int.Parse(PesquisarTextBox.Text))
                                {
                                    buscaProdutos.Add(produto);

                                    produtoExiste = true;
                                }
                            }

                            if (!produtoExiste)
                            {
                                MessageBox.Show("Produto não está cadastrado", "Error", MessageBoxButtons.OK);
                            }
                            else
                            {
                                dataGridView1.Refresh();
                            }
                        }
                        else if (criterioBusca.Equals("MARCA"))
                        {
                            bool produtoExiste = false;

                            foreach (var produto in produtos)
                            {
                                if (produto.marca.Equals(PesquisarTextBox.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                                {
                                    buscaProdutos.Add(produto);

                                    produtoExiste = true;
                                }
                            }

                            if (!produtoExiste)
                            {
                                MessageBox.Show("Não há nenhum produto desta marca, ou marca inexistente!", "Error", MessageBoxButtons.OK);
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

        private void btnAtt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
                Produto produtoSelecionado = dataGridViewRow.DataBoundItem as Produto;



                try
                {
                    int quantidadeAdicional = int.Parse(quantidadeTextBox.Text);
                    produtoSelecionado.quantidade = produtoSelecionado.quantidade + quantidadeAdicional;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Você tem que digitar apenas numeros no campo de Quantidade!", "Error", MessageBoxButtons.OK);
                    return;
                }

                repository.updateQuantidade(produtoSelecionado);
                quantidadeTextBox.Clear();

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Selecione UM produto para alterar a quantidade!", "Error", MessageBoxButtons.OK);
            }
        }

        private void ProdutoPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você quer gerar o relatorio em PDF?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {

                bool produtoExiste = false;
                List<Produto> produtosRelatorio = new List<Produto>();

                string pesquisa = RelatorioTextBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(pesquisa))
                {
                    foreach (var produto in produtos)
                    {
                        produtosRelatorio.Add(produto);
                        produtoExiste = true;
                    }
                }
                else
                {
                    foreach (var produto in produtos)
                    {
                        if (produto.nome.Contains(pesquisa, StringComparison.OrdinalIgnoreCase))
                        {
                            produtosRelatorio.Add(produto);
                            produtoExiste = true;
                        }
                    }
                }

                if (!produtoExiste)
                {
                    MessageBox.Show("Nenhum produto com este nome!", "Error", MessageBoxButtons.OK);
                }



                QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
                string dataAtual = DateTime.Now.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture);
                string titulo = $"Relatório De Produto Por Nome - {dataAtual}";

                string diretorio = @"C:\Users\William\Desktop";
                if (!Directory.Exists(diretorio))
                {
                    MessageBox.Show("Diretorio Incorreto, verificar!", "Error", MessageBoxButtons.OK);
                    return;
                }

                string nomeArquivo = Path.Combine(diretorio, $"relatorio-Produtos-Por-Nome-{dataAtual}.pdf");

                var relatorio = new RelatorioProdutos(produtosRelatorio, titulo);
                relatorio.GeneratePdf(nomeArquivo);
            }
        }
    }
}
