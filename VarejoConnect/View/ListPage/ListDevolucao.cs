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
    public partial class ListDevolucao : Form
    {

        DevolucaoRepositorio repository = new DevolucaoRepositorio();
        public ListDevolucao()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repository.GetAllDevolucoes();
            ConfigurarDataGrid();
        }

        public void ConfigurarDataGrid()
        {
            dataGridView1.Columns["funcionario"].Visible = false;

            dataGridView1.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["vendaId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["datadevolucao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);

            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["vendaId"].HeaderText = "ID VENDA";
            dataGridView1.Columns["motivo"].HeaderText = "MOTIVO";
            dataGridView1.Columns["datadevolucao"].HeaderText = "DATA DA DEVOLUÇÃO";
            dataGridView1.Columns["funcionarioNome"].HeaderText = "FUNCIONÁRIO";
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = dtpInicio.Value.Date;
            DateTime dataFim = dtpFim.Value.Date.AddDays(1).AddSeconds(-1);

            dataGridView1.DataSource = repository.GetDevolucoesWithNames(dataInicio, dataFim);
            ConfigurarDataGrid();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repository.GetAllDevolucoes();
            ConfigurarDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Devolucao devolucaoSelecionada;
            DataGridViewRow dataGridViewRow;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    dataGridViewRow = dataGridView1.SelectedRows[i];
                    devolucaoSelecionada = dataGridViewRow.DataBoundItem as Devolucao;


                    if (devolucaoSelecionada != null)
                    {
                        ProdutoDevolucaoRepositorio produtoDevolucaoRepositorio = new ProdutoDevolucaoRepositorio();
                        ListProduct listProduct = new ListProduct(produtoDevolucaoRepositorio.GetByDevolucaoIdWithNames(devolucaoSelecionada.id), devolucaoSelecionada.id);
                        listProduct.ShowDialog();
                    }
                }

                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Nenhuma devolução selecionada!", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
