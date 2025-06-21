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
using VarejoConnect.View.ListPage;
using VarejoConnect.View.OthersPage;

namespace VarejoConnect.View.StandartPage
{
    public partial class DevolucaoPage : Form
    {

        FuncionarioRepositorio funcionarioRepositorio = new FuncionarioRepositorio();
        VendaRepositorio vendaRepositorio = new VendaRepositorio();
        DevolucaoRepositorio devolucaoRepositorio = new DevolucaoRepositorio();
        ProdutoVendaRepositorio produtoVendaRepositorio = new ProdutoVendaRepositorio();
        ProdutoDevolucaoRepositorio produtoDevolucaoRepositorio = new ProdutoDevolucaoRepositorio();
        BindingList<Produto> produtosVenda;
        BindingList<Produto> produtosDevolver = new BindingList<Produto>();
        DateTime dataAtual = DateTime.Today;
        int idDevolucao;


        public DevolucaoPage()
        {
            InitializeComponent();
            idDevolucao = devolucaoRepositorio.getHighestId() + 1;
            label11.Text = funcionarioRepositorio.getNameById(Global.funcionarioLogado).ToUpper();
        }

        public void ConfigureDatagrid(DataGridView dataGrid)
        {
            dataGrid.Columns["status"].Visible = false;
            dataGrid.Columns["funcionarioNome"].Visible = false;
            dataGrid.Columns["secaoNome"].Visible = false;
            dataGrid.Columns["marca"].Visible = false;
            dataGrid.Columns["descricao"].Visible = false;
            dataGrid.Columns["preco"].Visible = false;
            dataGrid.Columns["secao"].Visible = false;
            dataGrid.Columns["dataAlteracao"].Visible = false;
            dataGrid.Columns["dataCriacao"].Visible = false;
            dataGrid.Columns["funcionarioAlteracao"].Visible = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGrid.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);

            dataGrid.Columns["id"].HeaderText = "ID";
            dataGrid.Columns["nome"].HeaderText = "NOME";
            dataGrid.Columns["quantidade"].HeaderText = "QUANTIDADE";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DevolucaoPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(vendaTextbox.Text.Trim(), out int id))
            {
                Venda vendaSelecionada = vendaRepositorio.GetVendaById(id);

                if (vendaSelecionada != null)
                {
                    var produtosVendaOriginais = produtoVendaRepositorio.GetByVendaIdWithNames(id);

                    var produtosDisponiveisParaDevolucao = new List<Produto>();

                    foreach (var produto in produtosVendaOriginais)
                    {
                        int quantidadeJaDevolvida = produtoDevolucaoRepositorio.ObterQuantidadeDevolvida(produto.id, id);

                        int quantidadeDisponivel = produto.quantidade - quantidadeJaDevolvida;

                        if (quantidadeDisponivel > 0)
                        {
                            produtosDisponiveisParaDevolucao.Add(new Produto
                            {
                                id = produto.id,
                                nome = produto.nome,
                                marca = produto.marca,
                                preco = produto.preco,
                                secao = produto.secao,
                                quantidade = quantidadeDisponivel
                            });
                        }
                    }

                    produtosVenda = new BindingList<Produto>(produtosDisponiveisParaDevolucao);
                    dgvVenda.DataSource = null;
                    dgvVenda.DataSource = produtosVenda;
                    ConfigureDatagrid(dgvVenda);
                }
                else
                {
                    MessageBox.Show("Venda não encontrada! Tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Insira o ID da Venda, apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void vendaTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(vendaTextbox.Text.Trim(), out int id))
                {
                    Venda vendaSelecionada = vendaRepositorio.GetVendaById(id);

                    if (vendaSelecionada != null)
                    {
                        var produtosVendaList = produtoVendaRepositorio.GetByVendaIdWithNames(id);

                        var produtosDisponiveisParaDevolucao = new List<Produto>();

                        foreach (var produto in produtosVendaList)
                        {
                            int quantidadeJaDevolvida = produtoDevolucaoRepositorio.ObterQuantidadeDevolvida(produto.id, id);

                            int quantidadeDisponivel = produto.quantidade - quantidadeJaDevolvida;

                            if (quantidadeDisponivel > 0)
                            {
                                produtosDisponiveisParaDevolucao.Add(new Produto
                                {
                                    id = produto.id,
                                    nome = produto.nome,
                                    marca = produto.marca,
                                    preco = produto.preco,
                                    secao = produto.secao,
                                    quantidade = quantidadeDisponivel
                                });
                            }
                        }

                        produtosVenda = new BindingList<Produto>(produtosDisponiveisParaDevolucao);

                        dgvVenda.DataSource = null;
                        dgvVenda.DataSource = produtosVenda;
                        ConfigureDatagrid(dgvVenda);
                    }
                    else
                    {
                        MessageBox.Show("Venda não encontrada! Tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MessageBox.Show("Insira o ID da Venda, apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ListVendas listVendas = new ListVendas();

            listVendas.ShowDialog();

            if (listVendas.venda != null)
            {
                string idString = listVendas.venda.id.ToString();
                vendaTextbox.Text = idString;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvVenda.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para devolver.");
                return;
            }

            Produto produtoSelecionado = (Produto)dgvVenda.SelectedRows[0].DataBoundItem;

            if (produtoSelecionado.quantidade == 0)
            {
                MessageBox.Show("Produto já foi totalmente devolvido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            QuantidadeProdutoPage selecaoQuantidade = new QuantidadeProdutoPage(produtoSelecionado.quantidade);
            selecaoQuantidade.ShowDialog();

            if (selecaoQuantidade.DialogResult == DialogResult.OK)
            {

                var produtoExistente = produtosDevolver.FirstOrDefault(p => p.id == produtoSelecionado.id);

                if (produtoExistente != null)
                {
                    produtoExistente.quantidade += selecaoQuantidade.quantidadeInformada;
                }
                else
                {
                    Produto produtoDevolvido = new Produto(
                    produtoSelecionado.id, produtoSelecionado.nome,
                    produtoSelecionado.marca, produtoSelecionado.descricao,
                    produtoSelecionado.secao, produtoSelecionado.preco,
                    selecaoQuantidade.quantidadeInformada, produtoSelecionado.funcionarioAlteracao,
                    produtoSelecionado.dataAlteracao, produtoSelecionado.dataCriacao,
                    produtoSelecionado.status);

                    produtosDevolver.Add(produtoDevolvido);
                }

                produtoSelecionado.quantidade -= selecaoQuantidade.quantidadeInformada;

                dgvDevolver.DataSource = null;
                dgvDevolver.DataSource = produtosDevolver;
                ConfigureDatagrid(dgvDevolver);

                dgvVenda.Refresh();
                dgvDevolver.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você deseja Devolver a venda inteira?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                foreach (var produto in produtosVenda.ToList())
                {
                    if (produto.quantidade <= 0)
                        continue;

                    var produtoExistente = produtosDevolver.FirstOrDefault(p => p.id == produto.id);

                    if (produtoExistente != null)
                    {
                        produtoExistente.quantidade += produto.quantidade;
                    }
                    else
                    {
                        Produto produtoDevolvido = new Produto(
                            produto.id, produto.nome,
                            produto.marca, produto.descricao,
                            produto.secao, produto.preco,
                            produto.quantidade, produto.funcionarioAlteracao,
                            produto.dataAlteracao, produto.dataCriacao,
                            produto.status
                        );

                        produtosDevolver.Add(produtoDevolvido);
                    }

                    produto.quantidade = 0;
                }

                dgvDevolver.DataSource = null;
                dgvDevolver.DataSource = produtosDevolver;
                ConfigureDatagrid(dgvDevolver);

                dgvVenda.Refresh();
                dgvDevolver.Refresh();
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            if (dgvDevolver.SelectedRows.Count > 0)
            {
                if (dgvDevolver.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Somente é possivel devolver um produto por vez ou todos de uma vez!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var produtoSelecionado = (Produto)dgvDevolver.SelectedRows[0].DataBoundItem;

                var produtoOriginal = produtosVenda.FirstOrDefault(p => p.id == produtoSelecionado.id);

                if (produtoOriginal != null)
                {
                    produtoOriginal.quantidade += produtoSelecionado.quantidade;
                }

                produtosDevolver.Remove(produtoSelecionado);
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Você deseja Limpar a Devolução inteira?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    foreach (var produtoDevolvido in produtosDevolver)
                    {
                        var produtoOriginal = produtosVenda.FirstOrDefault(p => p.id == produtoDevolvido.id);

                        if (produtoOriginal != null)
                        {
                            produtoOriginal.quantidade += produtoDevolvido.quantidade;
                        }
                    }

                    produtosDevolver.Clear();
                }
            }

            dgvVenda.DataSource = null;
            dgvVenda.DataSource = produtosVenda;
            ConfigureDatagrid(dgvVenda);

            dgvDevolver.DataSource = null;
            dgvDevolver.DataSource = produtosDevolver;
            ConfigureDatagrid(dgvDevolver);

            dgvVenda.Refresh();
            dgvDevolver.Refresh();
        }

        private void BtnVenda_Click(object sender, EventArgs e)
        {
            int vendaId = int.Parse(vendaTextbox.Text.Trim());
            Devolucao devolucao = new Devolucao(idDevolucao, vendaId, "", dataAtual, Global.funcionarioLogado);

            FinalizarDevolucaoPage finalizarDevolucaoPage = new FinalizarDevolucaoPage(devolucao, produtosDevolver.ToList());
            finalizarDevolucaoPage.ShowDialog();

            if (finalizarDevolucaoPage.DialogResult == DialogResult.OK)
            {
                produtosDevolver = null;
                produtosVenda = null;

                dgvVenda.DataSource = null;
                dgvVenda.DataSource = produtosVenda;

                dgvDevolver.DataSource = null;
                dgvDevolver.DataSource = produtosDevolver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListDevolucao listDevolucao = new ListDevolucao(); 
            listDevolucao.ShowDialog();
        }
    }
}
