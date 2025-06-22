using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarejoConnect.Model;
using VarejoConnect.Model.Repositorios;

namespace VarejoConnect.View.ListPage
{
    public partial class ListClient : Form
    {

        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        List<Cliente> lista = new List<Cliente>();
        public Cliente cliente = new Cliente();

        public ListClient()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            lista = clienteRepositorio.GetAll();
            dataGridView1.DataSource = lista;
            ConfigurarDatagrid();
        }

        private void ConfigurarDatagrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["status"].Visible = false;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["telefone"].Visible = false;
            dataGridView1.Columns["documento"].Visible = false;
            dataGridView1.Columns["funcionarioAlteracao"].Visible = false;
            dataGridView1.Columns["funcionarioNome"].Visible = false;
            dataGridView1.Columns["dataAlteracao"].Visible = false;
            dataGridView1.Columns["dataCriacao"].Visible = false;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);

            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["nome"].HeaderText = "NOME";
            dataGridView1.Columns["email"].HeaderText = "EMAIL";
        }

        private void AtualizarDataGridView(List<Cliente> clientes)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clientes;
        }

        private void OrdenarPorId(List<Cliente> clientes)
        {
            var clientesOrdenados = clientes.OrderBy(p => p.id).ToList();
            AtualizarDataGridView(clientesOrdenados);
        }

        private void OrdenarPorNome(List<Cliente> clientes)
        {
            var clientesOrdenados = clientes.OrderBy(p => p.nome).ToList();
            AtualizarDataGridView(clientesOrdenados);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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
                        this.cliente = clienteSelecionado;
                    }
                }

                dataGridView1.Refresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nenhum cliente selecionado", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
