using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
