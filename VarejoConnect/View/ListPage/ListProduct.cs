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

namespace VarejoConnect.View.ListPage
{
    public partial class ListProduct : Form
    {

        SecaoRepositorio secaoRepo = new SecaoRepositorio();
        ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
        ProdutoVendaRepositorio produtoVendaRepositorio = new ProdutoVendaRepositorio();
        List<Produto> lista = new List<Produto>();
        public Produto produto = new Produto();
        int vendaId;



        public ListProduct(List<Produto> list, int id)
        {
            InitializeComponent();
            vendaId = id;
            dataGridView1.DataSource = null;
            lista = list;
            dataGridView1.DataSource = lista;

            List<string> nomes = secaoRepo.getAllNomes();
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            comboBox1.DataSource = nomes;
            comboBox1.SelectedItem = secaoRepo.getNameById(produto.secao);

            ConfigurarDatagrid();
        }

        public ListProduct()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            lista = produtoRepositorio.getAllWithNames();
            dataGridView1.DataSource = lista;

            List<string> nomes = secaoRepo.getAllNomes();
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            comboBox1.DataSource = nomes;
            comboBox1.SelectedItem = secaoRepo.getNameById(produto.secao);

            ConfigurarDatagrid();

        }

        private void ConfigurarDatagrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["secao"].Visible = false;
            dataGridView1.Columns["funcionarioNome"].Visible = false;
            dataGridView1.Columns["status"].Visible = false;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["quantidade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["secao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["preco"].Visible = false;
            dataGridView1.Columns["descricao"].Visible = false;
            dataGridView1.Columns["marca"].Visible = false;
            dataGridView1.Columns["funcionarioAlteracao"].Visible = false;
            dataGridView1.Columns["dataAlteracao"].Visible = false;
            dataGridView1.Columns["dataCriacao"].Visible = false;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);

            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["nome"].HeaderText = "NOME";
            dataGridView1.Columns["secaoNome"].HeaderText = "SECAO";
            dataGridView1.Columns["quantidade"].HeaderText = "QUANTIDADE";

        }

        private void AtualizarDataGridView(List<Produto> produtos)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = produtos;
        }

        private void OrdenarPorId(List<Produto> produtos)
        {
            var produtosOrdenados = produtos.OrderBy(p => p.id).ToList();
            AtualizarDataGridView(produtosOrdenados);
        }

        private void OrdenarPorNome(List<Produto> produtos)
        {
            var produtosOrdenados = produtos.OrderBy(p => p.nome).ToList();
            AtualizarDataGridView(produtosOrdenados);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListProduct_Load(object sender, EventArgs e)
        {

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma seção!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string secaoSelecionada = comboBox1.SelectedItem.ToString();
            List<Produto> listaSecao = new List<Produto>();
            List<Produto> listaVenda = produtoVendaRepositorio.GetByVendaIdWithNames(vendaId);
            List<Produto> listaSecaoVenda = new List<Produto>();


            if (secaoSelecionada != null)
            {


                if (vendaId != 0) {
                    listaSecao = produtoRepositorio.getAllBySecaoInative(secaoRepo.getIdByName(secaoSelecionada));

                    foreach (var produto in listaVenda)
                    {
                        foreach (var produtoVenda in listaSecao)
                        {
                            if (produto.id == produtoVenda.id)
                            {
                                listaSecaoVenda.Add(produto);
                            }
                        }
                    }
                }
                else
                {
                    int secaoSelecionadaId = secaoRepo.GetIdByName(secaoSelecionada);
                    listaSecaoVenda = produtoRepositorio.getAllBySecaoWithName(secaoSelecionadaId);
                }

                if (NomeRadio.Checked)
                {
                    OrdenarPorNome(listaSecaoVenda);
                    ConfigurarDatagrid();
                }
                else if (IDRadio.Checked)
                {
                    OrdenarPorId(listaSecaoVenda);
                    ConfigurarDatagrid();
                }
                else
                {
                    MessageBox.Show("Você precisa selecionar ao menos uma das opções de busca!", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (NomeRadio.Checked)
                {
                    OrdenarPorNome(lista);
                    ConfigurarDatagrid();
                }
                else if (IDRadio.Checked)
                {
                    OrdenarPorId(lista);
                    ConfigurarDatagrid();
                }
                else
                {
                    MessageBox.Show("Você precisa selecionar ao menos uma das opções de busca!", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                        this.produto = produtoSelecionado;
                    }
                }

                dataGridView1.Refresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado", "Error", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
            comboBox1.SelectedIndex = -1;
            IDRadio.Checked = false;
            NomeRadio.Checked = false;
            ConfigurarDatagrid();
        }
    }
}
