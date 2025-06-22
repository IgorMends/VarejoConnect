using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarejoConnect.Controller;
using VarejoConnect.Model;
using VarejoConnect.Model.Repositorios;

namespace VarejoConnect.View.EditPage
{
    public partial class ProdutoEditPage : Form
    {
        SecaoRepositorio secaoRepo = new SecaoRepositorio();
        LogsRepositorio logs =  new LogsRepositorio();
        ProdutoRepositorio repository = new ProdutoRepositorio();
        public Produto produto { get; set; }
        Actions actions = new Actions();

        public ProdutoEditPage(Produto produto)
        {
            InitializeComponent();
            this.produto = produto;
            textBox1.Text = produto.nome.Trim();
            textBox2.Text = produto.preco.ToString().Trim();
            textBox3.Text = produto.marca.Trim();
            textBox4.Text = produto.descricao.Trim();

            List<string> nomes = secaoRepo.getAllNomes();
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            comboBox1.DataSource = nomes;
            comboBox1.SelectedItem = secaoRepo.getNameById(produto.secao);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string secaoSelecionada = comboBox1.SelectedItem.ToString();

            this.produto.nome = textBox1.Text.Trim().ToUpper();
            this.produto.preco = double.Parse(textBox2.Text.Trim());
            this.produto.marca = textBox3.Text.Trim().ToUpper();
            this.produto.secao = secaoRepo.getIdByName(secaoSelecionada);
            this.produto.descricao = textBox4.Text.Trim().ToUpper();
            this.produto.dataAlteracao = DateTime.Today;
            this.produto.funcionarioAlteracao = Global.funcionarioLogado;
            repository.UpdateProduto(produto);
            Logs log = new Logs(DateTime.UtcNow, Global.funcionarioLogado, "PRODUTO", produto.id, "PRODUTO EDITADO");
            logs.Add(log);

            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
