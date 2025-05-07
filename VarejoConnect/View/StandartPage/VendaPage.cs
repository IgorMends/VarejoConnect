using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarejoConnect.Model;
using VarejoConnect.Model.Repositorios;
using VarejoConnect.View.ListPage;

namespace VarejoConnect.View
{
    public partial class VendaPage : Form
    {

        FuncionarioRepositorio funcionarioRepositorio = new FuncionarioRepositorio();
        ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        BindingList<Produto> carrinho = new BindingList<Produto>();
        VendaRepositorio vendaRepositorio = new VendaRepositorio();
        DateTime dataAtual = DateTime.Today;
        int idVenda;
        double precoTotal;

        public VendaPage()
        {
            InitializeComponent();
            idVenda = vendaRepositorio.getHighestId() + 1;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = carrinho;
            ConfigureDataGrid();
        }

        public void ConfigureDataGrid()
        {
            dataGridView1.Columns["status"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["funcionarioAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            label11.Text = funcionarioRepositorio.getNameById(Global.funcionarioLogado).ToUpper();

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);

            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["nome"].HeaderText = "NOME";
            dataGridView1.Columns["marca"].HeaderText = "MARCA";
            dataGridView1.Columns["descricao"].HeaderText = "DESCRICAO";
            dataGridView1.Columns["preco"].HeaderText = "PREÇO";
            dataGridView1.Columns["secao"].HeaderText = "SEÇÃO";
            dataGridView1.Columns["quantidade"].HeaderText = "QUANTIDADE";
            dataGridView1.Columns["dataAlteracao"].HeaderText = "DATA DE ALTERAÇÃO";
            dataGridView1.Columns["dataCriacao"].HeaderText = "DATA DE CRIAÇÃO";
            dataGridView1.Columns["funcionarioAlteracao"].HeaderText = "ALTERADO POR";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (string.IsNullOrEmpty(quantidadeTextBox.Text) || quantidadeTextBox.Text == "0")
                {
                    MessageBox.Show("Digite a quantidade do produto!", "Error", MessageBoxButtons.OK);
                    return;
                }


                if (int.TryParse(produtoTextBox.Text, out int id))
                {
                    Produto produtoSelecionado = produtoRepositorio.getById(id);
                    Produto produtoBanco = produtoRepositorio.getById(id);
                    int quantidadeBox;

                    if (produtoSelecionado == null)
                    {
                        MessageBox.Show("Produto Inexistente", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        try
                        {
                            quantidadeBox = int.Parse(quantidadeTextBox.Text);
                            int indexNoCarrinho = -1;

                            for (int i = 0; i < carrinho.Count; i++)
                            {
                                if (carrinho[i].id == produtoSelecionado.id)
                                {
                                    indexNoCarrinho = i;
                                    break;
                                }
                            }



                            if (indexNoCarrinho == -1)
                            {
                                if (produtoBanco.quantidade < quantidadeBox)
                                {
                                    MessageBox.Show("Quantidade em estoque insuficiente!", "Error", MessageBoxButtons.OK);
                                    return;
                                }

                                produtoSelecionado.quantidade = quantidadeBox;
                                carrinho.Add(produtoSelecionado);

                                precoTotal += produtoSelecionado.preco * quantidadeBox;
                                TotalLabel.Text = "R$: " + precoTotal.ToString();
                                subTotalLabel.Text = "R$: " + precoTotal.ToString();

                                produtoTextBox.Clear();
                                quantidadeTextBox.Clear();
                            }
                            else
                            {

                                Produto produtoNoCarrinho = carrinho[indexNoCarrinho];
                                int novaQuantidade = produtoNoCarrinho.quantidade + quantidadeBox;


                                if (produtoBanco.quantidade < novaQuantidade)
                                {
                                    MessageBox.Show("Quantidade em estoque insuficiente!", "Error", MessageBoxButtons.OK);
                                    return;
                                }


                                produtoNoCarrinho.quantidade = novaQuantidade;
                                precoTotal += produtoSelecionado.preco * quantidadeBox;
                                TotalLabel.Text = "R$: " + precoTotal.ToString();
                                subTotalLabel.Text = "R$: " + precoTotal.ToString();

                                produtoTextBox.Clear();
                                quantidadeTextBox.Clear();
                            }
                            dataGridView1.Refresh();
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show("Digite apenas números no campo de quantidade!", "Error", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
                else
                {
                    Produto produtoSelecionado = produtoRepositorio.getByName(produtoTextBox.Text.ToUpper());
                    Produto produtoBanco = produtoRepositorio.getByName(produtoTextBox.Text.ToUpper());
                    int quantidadeBox;

                    if (produtoSelecionado == null)
                    {
                        MessageBox.Show("Produto Inexistente", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        try
                        {
                            quantidadeBox = int.Parse(quantidadeTextBox.Text);
                            int indexNoCarrinho = -1;

                            for (int i = 0; i < carrinho.Count; i++)
                            {
                                if (carrinho[i].nome == produtoSelecionado.nome)
                                {
                                    indexNoCarrinho = i;
                                    break;
                                }
                            }



                            if (indexNoCarrinho == -1)
                            {
                                if (produtoBanco.quantidade < quantidadeBox)
                                {
                                    MessageBox.Show("Quantidade em estoque insuficiente!", "Error", MessageBoxButtons.OK);
                                    return;
                                }

                                produtoSelecionado.quantidade = quantidadeBox;
                                carrinho.Add(produtoSelecionado);
                                precoTotal += produtoSelecionado.preco * quantidadeBox;
                                TotalLabel.Text = "R$: " + precoTotal.ToString();
                                subTotalLabel.Text = "R$: " + precoTotal.ToString();

                                produtoTextBox.Clear();
                                quantidadeTextBox.Clear();
                            }
                            else
                            {

                                Produto produtoNoCarrinho = carrinho[indexNoCarrinho];
                                int novaQuantidade = produtoNoCarrinho.quantidade + quantidadeBox;


                                if (produtoBanco.quantidade < novaQuantidade)
                                {
                                    MessageBox.Show("Quantidade em estoque insuficiente!", "Error", MessageBoxButtons.OK);
                                    return;
                                }


                                produtoNoCarrinho.quantidade = novaQuantidade;
                                precoTotal += produtoSelecionado.preco * quantidadeBox;
                                TotalLabel.Text = "R$: " + precoTotal.ToString();
                                subTotalLabel.Text = "R$: " + precoTotal.ToString();

                                produtoTextBox.Clear();
                                quantidadeTextBox.Clear();
                            }
                            dataGridView1.Refresh();
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show("Digite apenas números no campo de quantidade!", "Error", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
            }
        }

        private void quantidadeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(quantidadeTextBox.Text) || quantidadeTextBox.Text == "0")
            {
                MessageBox.Show("Digite a quantidade do produto!", "Error", MessageBoxButtons.OK);
                return;
            }

            if (int.TryParse(produtoTextBox.Text, out int id))
            {
                Produto produtoSelecionado = produtoRepositorio.getById(id);
                Produto produtoBanco = produtoRepositorio.getById(id);
                int quantidadeBox;

                if (produtoSelecionado == null)
                {
                    MessageBox.Show("Produto Inexistente", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        quantidadeBox = int.Parse(quantidadeTextBox.Text);
                        int indexNoCarrinho = -1;

                        for (int i = 0; i < carrinho.Count; i++)
                        {
                            if (carrinho[i].id == produtoSelecionado.id)
                            {
                                indexNoCarrinho = i;
                                break;
                            }
                        }



                        if (indexNoCarrinho == -1)
                        {
                            if (produtoBanco.quantidade < quantidadeBox)
                            {
                                MessageBox.Show("Quantidade em estoque insuficiente!", "Error", MessageBoxButtons.OK);
                                return;
                            }

                            produtoSelecionado.quantidade = quantidadeBox;
                            carrinho.Add(produtoSelecionado);
                            precoTotal += produtoSelecionado.preco * quantidadeBox;
                            TotalLabel.Text = "R$: " + precoTotal.ToString();
                            subTotalLabel.Text = "R$: " + precoTotal.ToString();

                            produtoTextBox.Clear();
                            quantidadeTextBox.Clear();
                        }
                        else
                        {

                            Produto produtoNoCarrinho = carrinho[indexNoCarrinho];
                            int novaQuantidade = produtoNoCarrinho.quantidade + quantidadeBox;


                            if (produtoBanco.quantidade < novaQuantidade)
                            {
                                MessageBox.Show("Quantidade em estoque insuficiente!", "Error", MessageBoxButtons.OK);
                                return;
                            }


                            produtoNoCarrinho.quantidade = novaQuantidade;
                            precoTotal += produtoSelecionado.preco * quantidadeBox;
                            TotalLabel.Text = "R$: " + precoTotal.ToString();
                            subTotalLabel.Text = "R$: " + precoTotal.ToString();

                            produtoTextBox.Clear();
                            quantidadeTextBox.Clear();
                        }
                        dataGridView1.Refresh();
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Digite apenas números no campo de quantidade!", "Error", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            else
            {
                Produto produtoSelecionado = produtoRepositorio.getByName(produtoTextBox.Text.ToUpper());
                Produto produtoBanco = produtoRepositorio.getByName(produtoTextBox.Text.ToUpper());
                int quantidadeBox;

                if (produtoSelecionado == null)
                {
                    MessageBox.Show("Produto Inexistente", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        quantidadeBox = int.Parse(quantidadeTextBox.Text);
                        int indexNoCarrinho = -1;

                        for (int i = 0; i < carrinho.Count; i++)
                        {
                            if (carrinho[i].nome == produtoSelecionado.nome)
                            {
                                indexNoCarrinho = i;
                                break;
                            }
                        }



                        if (indexNoCarrinho == -1)
                        {
                            if (produtoBanco.quantidade < quantidadeBox)
                            {
                                MessageBox.Show("Quantidade em estoque insuficiente!", "Error", MessageBoxButtons.OK);
                                return;
                            }

                            produtoSelecionado.quantidade = quantidadeBox;
                            carrinho.Add(produtoSelecionado);
                            precoTotal += produtoSelecionado.preco * quantidadeBox;
                            TotalLabel.Text = "R$: " + precoTotal.ToString();
                            subTotalLabel.Text = "R$: " + precoTotal.ToString();

                            produtoTextBox.Clear();
                            quantidadeTextBox.Clear();
                        }
                        else
                        {

                            Produto produtoNoCarrinho = carrinho[indexNoCarrinho];
                            int novaQuantidade = produtoNoCarrinho.quantidade + quantidadeBox;


                            if (produtoBanco.quantidade < novaQuantidade)
                            {
                                MessageBox.Show("Quantidade em estoque insuficiente!", "Error", MessageBoxButtons.OK);
                                return;
                            }


                            produtoNoCarrinho.quantidade = novaQuantidade;
                            precoTotal += produtoSelecionado.preco * quantidadeBox;
                            TotalLabel.Text = "R$: " + precoTotal.ToString();
                            subTotalLabel.Text = "R$: " + precoTotal.ToString();

                            produtoTextBox.Clear();
                            quantidadeTextBox.Clear();
                        }
                        dataGridView1.Refresh();
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Digite apenas números no campo de quantidade!", "Error", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
        }

        private void quantidadeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (string.IsNullOrEmpty(quantidadeTextBox.Text) || quantidadeTextBox.Text == "0")
                {
                    MessageBox.Show("Digite a quantidade do produto!", "Error", MessageBoxButtons.OK);
                    return;
                }


                if (int.TryParse(produtoTextBox.Text, out int id))
                {
                    Produto produtoSelecionado = produtoRepositorio.getById(id);
                    Produto produtoBanco = produtoRepositorio.getById(id);
                    int quantidadeBox;

                    if (produtoSelecionado == null)
                    {
                        MessageBox.Show("Produto Inexistente", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        try
                        {
                            quantidadeBox = int.Parse(quantidadeTextBox.Text);
                            int indexNoCarrinho = -1;

                            for (int i = 0; i < carrinho.Count; i++)
                            {
                                if (carrinho[i].id == produtoSelecionado.id)
                                {
                                    indexNoCarrinho = i;
                                    break;
                                }
                            }



                            if (indexNoCarrinho == -1)
                            {
                                if (produtoBanco.quantidade < quantidadeBox)
                                {
                                    MessageBox.Show("Quantidade em estoque insuficiente!", "Error", MessageBoxButtons.OK);
                                    return;
                                }

                                produtoSelecionado.quantidade = quantidadeBox;
                                carrinho.Add(produtoSelecionado);
                                precoTotal += produtoSelecionado.preco * quantidadeBox;
                                TotalLabel.Text = "R$: " + precoTotal.ToString();
                                subTotalLabel.Text = "R$: " + precoTotal.ToString();

                                produtoTextBox.Clear();
                                quantidadeTextBox.Clear();
                            }
                            else
                            {

                                Produto produtoNoCarrinho = carrinho[indexNoCarrinho];
                                int novaQuantidade = produtoNoCarrinho.quantidade + quantidadeBox;


                                if (produtoBanco.quantidade < novaQuantidade)
                                {
                                    MessageBox.Show("Quantidade em estoque insuficiente!", "Error", MessageBoxButtons.OK);
                                    return;
                                }


                                produtoNoCarrinho.quantidade = novaQuantidade;
                                precoTotal += produtoSelecionado.preco * quantidadeBox;
                                TotalLabel.Text = "R$: " + precoTotal.ToString();
                                subTotalLabel.Text = "R$: " + precoTotal.ToString();

                                produtoTextBox.Clear();
                                quantidadeTextBox.Clear();
                            }
                            dataGridView1.Refresh();
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show("Digite apenas números no campo de quantidade!", "Error", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
                else
                {
                    Produto produtoSelecionado = produtoRepositorio.getByName(produtoTextBox.Text.ToUpper());
                    Produto produtoBanco = produtoRepositorio.getByName(produtoTextBox.Text.ToUpper());
                    int quantidadeBox;

                    if (produtoSelecionado == null)
                    {
                        MessageBox.Show("Produto Inexistente", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        try
                        {
                            quantidadeBox = int.Parse(quantidadeTextBox.Text);
                            int indexNoCarrinho = -1;

                            for (int i = 0; i < carrinho.Count; i++)
                            {
                                if (carrinho[i].nome == produtoSelecionado.nome)
                                {
                                    indexNoCarrinho = i;
                                    break;
                                }
                            }



                            if (indexNoCarrinho == -1)
                            {
                                if (produtoBanco.quantidade < quantidadeBox)
                                {
                                    MessageBox.Show("Quantidade em estoque insuficiente!", "Error", MessageBoxButtons.OK);
                                    return;
                                }

                                produtoSelecionado.quantidade = quantidadeBox;
                                carrinho.Add(produtoSelecionado);
                                precoTotal += produtoSelecionado.preco * quantidadeBox;
                                TotalLabel.Text = "R$: " + precoTotal.ToString();
                                subTotalLabel.Text = "R$: " + precoTotal.ToString();

                                produtoTextBox.Clear();
                                quantidadeTextBox.Clear();
                            }
                            else
                            {

                                Produto produtoNoCarrinho = carrinho[indexNoCarrinho];
                                int novaQuantidade = produtoNoCarrinho.quantidade + quantidadeBox;


                                if (produtoBanco.quantidade < novaQuantidade)
                                {
                                    MessageBox.Show("Quantidade em estoque insuficiente!", "Error", MessageBoxButtons.OK);
                                    return;
                                }


                                produtoNoCarrinho.quantidade = novaQuantidade;
                                precoTotal += produtoSelecionado.preco * quantidadeBox;
                                TotalLabel.Text = "R$: " + precoTotal.ToString();
                                subTotalLabel.Text = "R$: " + precoTotal.ToString();

                                produtoTextBox.Clear();
                                quantidadeTextBox.Clear();
                            }
                            dataGridView1.Refresh();
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show("Digite apenas números no campo de quantidade!", "Error", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ListProduct listProduct = new ListProduct();
            listProduct.ShowDialog();
        }

        private void BtnVenda_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("O pagamento foi confirmado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Cliente clienteSelecionado;

                if (precoTotal == null || precoTotal == 0.0)
                {
                    MessageBox.Show("Não há nenhum item na venda, não é possivel realizar a venda deste modo!", "Error", MessageBoxButtons.OK);
                }

                if (int.TryParse(clienteTextBox.Text, out int id))
                {
                    clienteSelecionado = clienteRepositorio.getById(id);
                }
                else
                {
                    clienteSelecionado = clienteRepositorio.getByName(clienteTextBox.Text.ToUpper());
                }


                if (clienteSelecionado == null)
                {
                    MessageBox.Show("Cliente inexistente, favor cadastrar", "Error", MessageBoxButtons.OK);
                    return;
                }

                if (TipoDropBox.Text == "")
                {
                    MessageBox.Show("Selecione uma forma de pagamento!", "Error", MessageBoxButtons.OK);
                    return;
                }

                Venda venda = new Venda(idVenda, precoTotal, TipoDropBox.Text, dataAtual, clienteSelecionado.id, Global.funcionarioLogado);
                vendaRepositorio.Add(venda);

                foreach (Produto produto in carrinho)
                {
                    produtoRepositorio.decreaseQuantity(produto, produto.quantidade);
                }

                idVenda++;
                precoTotal = 0;
                carrinho.Clear();
                TotalLabel.Text = "";
                subTotalLabel.Text = "";
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = carrinho;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ListClient listClient = new ListClient();
            listClient.ShowDialog();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
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
                        DialogResult resultado = MessageBox.Show("Você deseja limpar o produto selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            carrinho.Remove(produtoSelecionado);
                            TotalLabel.Text = "";
                            subTotalLabel.Text = "";
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = carrinho;
                            ConfigureDataGrid();
                        }
                    }
                }

                dataGridView1.Refresh();
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Você deseja limpar todos os produtos?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    carrinho.Clear();
                    TotalLabel.Text = "";
                    subTotalLabel.Text = "";
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = carrinho;
                    ConfigureDataGrid();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListVendas listVendas = new ListVendas();
            listVendas.ShowDialog();
        }
    }
}
