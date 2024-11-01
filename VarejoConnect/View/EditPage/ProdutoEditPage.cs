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

namespace VarejoConnect.View.EditPage
{
    public partial class ProdutoEditPage : Form
    {
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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            this.produto.nome = textBox1.Text.Trim();
            this.produto.preco = double.Parse(textBox2.Text.Trim());
            this.produto.marca = textBox3.Text.Trim().ToUpper();
            this.produto.descricao = textBox4.Text.Trim().ToUpper();
            this.produto.dataAlteracao = DateTime.Today;
            this.produto.funcionarioAlteracao = Global.funcionarioLogado;
            repository.UpdateProduto(produto);
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            actions.CloseApplication();
        }
    }
}
