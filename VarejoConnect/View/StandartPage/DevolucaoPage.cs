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

namespace VarejoConnect.View.StandartPage
{
    public partial class DevolucaoPage : Form
    {

        FuncionarioRepositorio funcionarioRepositorio = new FuncionarioRepositorio();
        VendaRepositorio vendaRepositorio = new VendaRepositorio();
        DevolucaoRepositorio devolucaoRepositorio = new DevolucaoRepositorio();
        ProdutoVendaRepositorio produtoVendaRepositorio = new ProdutoVendaRepositorio();
        BindingList<Produto> produtosVenda;
        int idDevolucao;


        public DevolucaoPage()
        {
            InitializeComponent();
            idDevolucao = devolucaoRepositorio.getHighestId() + 1;
            label11.Text = funcionarioRepositorio.getNameById(Global.funcionarioLogado).ToUpper();
        }

        public void ConfigureDatagridVenda()
        {
            dgvVenda.Columns["status"].Visible = false;
            dgvVenda.Columns["funcionarioNome"].Visible = false;
            dgvVenda.Columns["secaoNome"].Visible = false;
            dgvVenda.Columns["marca"].Visible = false;
            dgvVenda.Columns["descricao"].Visible = false;
            dgvVenda.Columns["preco"].Visible = false;
            dgvVenda.Columns["secao"].Visible = false;
            dgvVenda.Columns["dataAlteracao"].Visible = false;
            dgvVenda.Columns["dataCriacao"].Visible = false;
            dgvVenda.Columns["funcionarioAlteracao"].Visible = false;
            dgvVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVenda.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVenda.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvVenda.EnableHeadersVisualStyles = false;
            dgvVenda.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvVenda.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);

            dgvVenda.Columns["id"].HeaderText = "ID";
            dgvVenda.Columns["nome"].HeaderText = "NOME";
            dgvVenda.Columns["quantidade"].HeaderText = "QUANTIDADE";
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
                    var produtosVendaList = produtoVendaRepositorio.GetByVendaIdWithNames(id);
                    produtosVenda = new BindingList<Produto>(produtosVendaList);

                    dgvVenda.DataSource = null;
                    dgvVenda.DataSource = produtosVenda;
                    ConfigureDatagridVenda();
                }
                else
                {
                    MessageBox.Show("Venda nao encontrada! Tente novamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show("Insira o ID da Venda, apenas numeros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
                        produtosVenda = new BindingList<Produto>(produtosVendaList);

                        dgvVenda.DataSource = null;
                        dgvVenda.DataSource = produtosVenda;
                        ConfigureDatagridVenda();
                    }
                    else
                    {
                        MessageBox.Show("Venda nao encontrada! Tente novamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MessageBox.Show("Insira o ID da Venda, apenas numeros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
    }
}
