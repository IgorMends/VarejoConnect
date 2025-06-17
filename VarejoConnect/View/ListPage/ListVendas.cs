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
    public partial class ListVendas : Form
    {

        VendaRepositorio repository = new VendaRepositorio();

        public ListVendas()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repository.GetAllVendas();
            ConfigurarDataGrid();
        }

        public void ConfigurarDataGrid()
        {
            dataGridView1.Columns["clienteVenda"].Visible = false;
            dataGridView1.Columns["funcionarioVenda"].Visible = false;

            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["valorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["dataVenda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["valorTotal"].DefaultCellStyle.Format = "N2";
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);

            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["valorTotal"].HeaderText = "VALOR TOTAL";
            dataGridView1.Columns["formaPagamento"].HeaderText = "FORMA DE PAGAMENTO";
            dataGridView1.Columns["dataVenda"].HeaderText = "DATA DA VENDA";
            dataGridView1.Columns["clienteNome"].HeaderText = "CLIENTE";
            dataGridView1.Columns["funcionarioNome"].HeaderText = "FUNCIONÁRIO";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListVendas_Load(object sender, EventArgs e)
        {

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = dtpInicio.Value.Date;
            DateTime dataFim = dtpFim.Value.Date.AddDays(1).AddSeconds(-1);

            dataGridView1.DataSource = repository.GetVendasWithNames(dataInicio, dataFim);
            ConfigurarDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repository.GetAllVendas();
            ConfigurarDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Venda vendaSelecionada;
            DataGridViewRow dataGridViewRow;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    dataGridViewRow = dataGridView1.SelectedRows[i];
                    vendaSelecionada = dataGridViewRow.DataBoundItem as Venda;


                    if (vendaSelecionada != null)
                    {
                        ProdutoVendaRepositorio produtoVendaRepositorio = new ProdutoVendaRepositorio();
                        ListProduct listProduct = new ListProduct(produtoVendaRepositorio.GetByVendaIdWithNames(vendaSelecionada.id), vendaSelecionada.id);
                        listProduct.ShowDialog();
                    }
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Nenhuma venda selecionado", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
