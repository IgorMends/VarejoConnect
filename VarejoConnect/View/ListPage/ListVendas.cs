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
            dataGridView1.Columns["clienteVenda"].Visible = false;
            dataGridView1.Columns["funcionarioVenda"].Visible = false;
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
            dataGridView1.Columns["clienteVenda"].Visible = false;
            dataGridView1.Columns["funcionarioVenda"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repository.GetAllVendas();
            dataGridView1.Columns["clienteVenda"].Visible = false;
            dataGridView1.Columns["funcionarioVenda"].Visible = false;
        }
    }
}
