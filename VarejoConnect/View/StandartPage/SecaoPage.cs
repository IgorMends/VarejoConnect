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
using VarejoConnect.View.RegisterPage;
using VarejoConnect.View.EditPage;
using QuestPDF.Fluent;
using System.Globalization;

namespace VarejoConnect.View.StandartPage
{
    public partial class SecaoPage : Form
    {
        SecaoRepositorio repository = new SecaoRepositorio();
        Actions actions = new Actions();
        BindingList<Secao> buscaSecao = new BindingList<Secao>();
        BindingList<Secao> secoes = new BindingList<Secao>();
        List<string> textBoxes = new List<string>();
        DateTime dataAtual = DateTime.Today;
        int id;

        public SecaoPage()
        {
            InitializeComponent();
            ObterDados();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = secoes;
            ConfigureDataGrid();
        }

        public void ConfigureDataGrid()
        {
            dataGridView1.Columns["status"].Visible = false;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["funcionarioAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataCriacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);

            dataGridView1.Columns["id"].HeaderText = "id";
            dataGridView1.Columns["nome"].HeaderText = "NOME";
            dataGridView1.Columns["descricao"].HeaderText = "DESCRIÇÃO";
            dataGridView1.Columns["quantidade"].HeaderText = "QUANTIDADE DE PRODUTOS";
            dataGridView1.Columns["dataAlteracao"].HeaderText = "DATA DE ALTERAÇÃO";
            dataGridView1.Columns["dataCriacao"].HeaderText = "DATA DE CRIAÇÃO";
            dataGridView1.Columns["funcionarioAlteracao"].HeaderText = "ALTERADO POR";

        }

        public void ObterDados()
        {
            secoes = new BindingList<Secao>(repository.GetAll());
            id = repository.getHighestId() + 1;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SectionRegisterPage sectionRegisterPage = new SectionRegisterPage(secoes);

            sectionRegisterPage.ShowDialog();

            if (sectionRegisterPage.DialogResult == DialogResult.OK)
            {
                secoes = sectionRegisterPage.secoesModal;
                id++;
            }


            dataGridView1.Refresh();
        }

        private void BtnInativar_Click(object sender, EventArgs e)
        {
            Secao secaoSelecionada;
            DataGridViewRow dataGridViewRow;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    dataGridViewRow = dataGridView1.SelectedRows[i];
                    secaoSelecionada = dataGridViewRow.DataBoundItem as Secao;


                    if (secaoSelecionada != null)
                    {
                        secoes.Remove(secaoSelecionada);
                        buscaSecao.Remove(secaoSelecionada);
                        repository.RemoveSecao(secaoSelecionada);
                    }
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Nenhuma Seção selecionada!", "Error", MessageBoxButtons.OK);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
                Secao secaoSelecionada = dataGridViewRow.DataBoundItem as Secao;

                SecaoEditPage editPage = new SecaoEditPage(secaoSelecionada);
                int index = secoes.IndexOf(secaoSelecionada);
                editPage.ShowDialog();


                if (editPage.DialogResult == DialogResult.OK)
                {
                    secoes[index] = editPage.secao;
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("É possivel editar apenas uma secao por vez!", "Error", MessageBoxButtons.OK);
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            buscaSecao.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = buscaSecao;
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
                    dataGridView1.DataSource = buscaSecao;
                    ConfigureDataGrid();
                }
                else
                {
                    if (!(string.IsNullOrWhiteSpace(PesquisarTextBox.Text)))
                    {
                        if (criterioBusca.Equals("NOME"))
                        {

                            bool secaoExiste = false;

                            foreach (var secao in secoes)
                            {
                                if (secao.nome.Contains(PesquisarTextBox.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                                {
                                    buscaSecao.Add(secao);

                                    secaoExiste = true;
                                }
                            }

                            if (!secaoExiste)
                            {
                                MessageBox.Show("Seção não está cadastrado", "Error", MessageBoxButtons.OK);
                            }
                            else
                            {
                                dataGridView1.Refresh();
                            }
                        }
                        else if (criterioBusca.Equals("ID"))
                        {
                            bool secaoExiste = false;
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


                            foreach (var secao in secoes)
                            {
                                if (secao.id == numId)
                                {
                                    buscaSecao.Add(secao);

                                    secaoExiste = true;
                                }
                            }

                            if (!secaoExiste)
                            {
                                MessageBox.Show("Seção não está cadastrado", "Error", MessageBoxButtons.OK);
                            }
                            else
                            {
                                dataGridView1.Refresh();
                            }
                        }
                        else if (criterioBusca.Equals("QUANTIDADE"))
                        {
                            bool secaoExiste = false;
                            int numProd;

                            try
                            {
                                numProd = int.Parse(PesquisarTextBox.Text);
                            }
                            catch (FormatException ex)
                            {
                                MessageBox.Show("Você tem que digitar apenas numeros", "Error", MessageBoxButtons.OK);
                                return;
                            }


                            foreach (var secao in secoes)
                            {
                                if (secao.quantidade == numProd)
                                {
                                    buscaSecao.Add(secao);

                                    secaoExiste = true;
                                }
                            }

                            if (!secaoExiste)
                            {
                                MessageBox.Show("Seção não está cadastrado", "Error", MessageBoxButtons.OK);
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

                bool secaoExiste = false;
                List<Secao> secoesRelatorio = new List<Secao>();

                string pesquisa = RelatorioTextBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(pesquisa))
                {
                    foreach (var secao in secoes)
                    {
                        secoesRelatorio.Add(secao);
                        secaoExiste = true;
                    }
                }
                else
                {
                    foreach (var secao in secoes)
                    {
                        if (secao.nome.Contains(pesquisa, StringComparison.OrdinalIgnoreCase))
                        {
                            secoesRelatorio.Add(secao);
                            secaoExiste = true;
                        }
                    }
                }

                if (!secaoExiste)
                {
                    MessageBox.Show("Nenhuma Seção com este nome!", "Error", MessageBoxButtons.OK);
                }



                QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
                string dataAtual = DateTime.Now.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture);
                string titulo = $"Relatório De Seçõs Por Nome - {dataAtual}";

                string diretorio = @"C:\Users\William\Desktop";
                if (!Directory.Exists(diretorio))
                {
                    MessageBox.Show("Diretorio Incorreto, verificar!", "Error", MessageBoxButtons.OK);
                    return;
                }

                string nomeArquivo = Path.Combine(diretorio, $"relatorio-Seções-Por-Nome-{dataAtual}.pdf");

                var relatorio = new RelatorioSecoes(secoesRelatorio, titulo);
                relatorio.GeneratePdf(nomeArquivo);
            }
        }
    }
}
