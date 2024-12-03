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
			dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView1.Columns["telefone"].Visible = false;
			dataGridView1.Columns["cpf"].Visible = false;
			dataGridView1.Columns["funcionarioAlteracao"].Visible = false;
			dataGridView1.Columns["dataAlteracao"].Visible = false;
			dataGridView1.Columns["dataCriacao"].Visible = false;
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
	}
}
