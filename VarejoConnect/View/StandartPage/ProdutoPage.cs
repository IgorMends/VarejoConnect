﻿using System;
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
using VarejoConnect.View.EditPage;

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
            textBoxes.Clear();
            textBoxes.Add(NomeTextBox.Text);
            textBoxes.Add(MarcaTextBox.Text);
            textBoxes.Add(DescricaoTextBox.Text);
            textBoxes.Add(PrecoTextBox.Text);


            actions.verifyBlanksTextboxes(textBoxes);


            foreach (var text in produtos)
            {
                if (text.nome.Equals(NomeTextBox.Text))
                {
                    MessageBox.Show("Este produto já esta cadastrado!", "Erro", MessageBoxButtons.OK);
                    return;
                }
            }

            double numPreco;

            try
            {
                numPreco = double.Parse(PrecoTextBox.Text.Trim());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Você tem que digitar apenas numeros no campo de Preço!", "Error", MessageBoxButtons.OK);
                return;
            }

            Produto produto = new Produto(id, NomeTextBox.Text.Trim().ToUpper(), MarcaTextBox.Text.Trim().ToUpper(), DescricaoTextBox.Text.Trim().ToUpper(), numPreco, Global.funcionarioLogado, dataAtual, dataAtual);
            produtos.Add(produto);
            repository.Add(produto);

            id++;

            NomeTextBox.Clear();
            MarcaTextBox.Clear();
            DescricaoTextBox.Clear();
            PrecoTextBox.Clear();

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

            if (TodosRadio.Checked)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = produtos;
            }
            else
            {
                if (!(string.IsNullOrWhiteSpace(PesquisarTextBox.Text)))
                {
                    if (NomeRadio.Checked)
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
                    else if (IDRadio.Checked)
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
                    else if (MarcaRadio.Checked)
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
            PesquisarTextBox.Clear();
        }
    }
}
