using Microsoft.VisualBasic.Logging;
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

namespace VarejoConnect.View.OthersPage
{
    public partial class FinalizarDevolucaoPage : Form
    {
        Devolucao devolucao;
        List<Produto> listaProdutos;
        DevolucaoRepositorio devolucaoRepositorio = new DevolucaoRepositorio();
        ProdutoDevolucaoRepositorio produtoDevolucaoRepositorio = new ProdutoDevolucaoRepositorio();
        LogsRepositorio logs = new LogsRepositorio();   
        ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();

        public FinalizarDevolucaoPage(Devolucao devolucao, List<Produto> listaProdutos)
        {
            InitializeComponent();
            this.devolucao = devolucao;
            this.listaProdutos = listaProdutos;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVenda_Click(object sender, EventArgs e)
        {
            devolucao.motivo = motivoTextBox.Text;
            devolucaoRepositorio.Add(devolucao);

            foreach (Produto produto in listaProdutos) 
            {
                produtoDevolucaoRepositorio.Add(produto, devolucao.id);
                produtoRepositorio.adicionarEstoqueProduto(produto.id, produto.quantidade);
            }
            Logs log = new Logs(DateTime.UtcNow, Global.funcionarioLogado, "DEVOLUCAO", devolucao.id, "DEVOLUCAO REALIZADA");
            logs.Add(log);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
