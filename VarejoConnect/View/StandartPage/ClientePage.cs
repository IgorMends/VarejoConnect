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
using VarejoConnect.Model.Repositorios;
using VarejoConnect.Model;
using VarejoConnect.View.EditPage;
using QuestPDF.Fluent;
using System.Globalization;
using VarejoConnect.View.RegisterPage;
using System.Reflection;
using Microsoft.VisualBasic.Logging;

namespace VarejoConnect.View
{
    public partial class ClientePage : Form
    {

        ClienteRepositorio repository = new ClienteRepositorio();
        Actions actions = new Actions();
        BindingList<Cliente> buscaClientes = new BindingList<Cliente>();
        LogsRepositorio logs = new LogsRepositorio();
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
            dataGridView1.Columns["email"].HeaderText = "EMAIL";
            dataGridView1.Columns["dataAlteracao"].HeaderText = "DATA DE ALTERAÇÃO";
            dataGridView1.Columns["dataCriacao"].HeaderText = "DATA DE CRIAÇÃO";
            dataGridView1.Columns["funcionarioNome"].HeaderText = "ALTERADO POR";

        }

        public void ObterDados()
        {
            clientes = new BindingList<Cliente>(repository.getAllWithNames());
            id = repository.getHighestId() + 1;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            ClientRegisterPage clientRegisterPage = new ClientRegisterPage(clientes);

            clientRegisterPage.ShowDialog();

            if (clientRegisterPage.DialogResult == DialogResult.OK)
            {
                clientes = clientRegisterPage.clientesModal;
                clientes = new BindingList<Cliente>(repository.getAllWithNames());

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = clientes;

                ConfigureDataGrid();
                dataGridView1.Refresh();
                id++;
            }


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
                        Logs log = new Logs(DateTime.UtcNow, Global.funcionarioLogado, "CLIENTE", clienteSelecionado.id, "CLIENTE EXCLUIDO");
                        logs.Add(log);
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
                    dataGridView1.DataSource = clientes;
                    ConfigureDataGrid();
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
                        else if (criterioBusca.Equals("DOCUMENTO"))
                        {
                            bool clienteExiste = false;

                            foreach (var cliente in clientes)
                            {
                                if (cliente.documento.Equals(PesquisarTextBox.Text.Trim()))
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

                string diretorio = @"C:\Users\William\Desktop";
                if (!Directory.Exists(diretorio))
                {
                    MessageBox.Show("Diretorio Incorreto, verificar!", "Error", MessageBoxButtons.OK);
                    return;
                }

                string nomeArquivo = Path.Combine(diretorio, $"relatorio-Clientes-Por-Nome-{dataAtual}.pdf");

                var relatorio = new RelatorioClientes(clientesRelatorio, titulo);
                relatorio.GeneratePdf(nomeArquivo);
                Logs log = new Logs(DateTime.UtcNow, Global.funcionarioLogado, "CLIENTE", null, "RELATORIO DE CLIENTE GERADO");
                logs.Add(log);
            }
        }

        private void ClientePage_Load(object sender, EventArgs e)
        {

        }
    }
}
