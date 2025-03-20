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

namespace VarejoConnect.View.ListPage
{
	public partial class ListProduct : Form
	{
		ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
		List<Produto> lista = new List<Produto>();
		


		public ListProduct()
		{
			InitializeComponent();
			dataGridView1.DataSource = null;
			lista = produtoRepositorio.GetAll();
			dataGridView1.DataSource = lista;
			ConfigurarDatagrid();

		}

		private void ConfigurarDatagrid()
		{
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["status"].Visible = false;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView1.Columns["quantidade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView1.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView1.Columns["preco"].Visible = false;
			dataGridView1.Columns["descricao"].Visible = false;
			dataGridView1.Columns["marca"].Visible = false;
			dataGridView1.Columns["funcionarioAlteracao"].Visible = false;
			dataGridView1.Columns["dataAlteracao"].Visible = false;
			dataGridView1.Columns["dataCriacao"].Visible = false;
		}

		private void AtualizarDataGridView(List<Produto> produtos)
		{
			dataGridView1.DataSource = null; 
			dataGridView1.DataSource = produtos; 
		}

		private void OrdenarPorId(List<Produto> produtos)
		{
			var produtosOrdenados = produtos.OrderBy(p => p.id).ToList();
			AtualizarDataGridView(produtosOrdenados);
		}

		private void OrdenarPorNome(List<Produto> produtos)
		{
			var produtosOrdenados = produtos.OrderBy(p => p.nome).ToList();
			AtualizarDataGridView(produtosOrdenados);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ListProduct_Load(object sender, EventArgs e)
		{

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
