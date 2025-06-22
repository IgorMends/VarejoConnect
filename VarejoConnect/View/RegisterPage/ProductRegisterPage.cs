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
using VarejoConnect.Model.Repositorios;
using VarejoConnect.Model;

namespace VarejoConnect.View.RegisterPage
{
    public partial class ProductRegisterPage : Form
    {
        SecaoRepositorio secaoRepo = new SecaoRepositorio();
        ProdutoRepositorio repository = new ProdutoRepositorio();
        public BindingList<Produto> produtosModal = new BindingList<Produto>();
        LogsRepositorio logs = new LogsRepositorio();
        List<string> textBoxes = new List<string>();
        Actions actions = new Actions();
        int id;

        public ProductRegisterPage(BindingList<Produto> produtosList)
        {
            produtosModal = produtosList;
            id = repository.getHighestId() + 1;
            InitializeComponent();

            List<string> nomes = secaoRepo.getAllNomes();
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            comboBox1.DataSource = nomes;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string secaoSelecionada = comboBox1.SelectedItem?.ToString();
            textBoxes.Add(secaoSelecionada);
            textBoxes.Add(NomeTextBox.Text);
            textBoxes.Add(MarcaTextBox.Text);
            textBoxes.Add(DescricaoTextBox.Text);
            textBoxes.Add(PrecoTextBox.Text);

            bool isblank = actions.verifyBlanksTextboxes(textBoxes);

            if (isblank)
            {
                return;
            }


            foreach (var text in produtosModal)
            {
                if (text.nome.Equals(NomeTextBox.Text))
                {
                    MessageBox.Show("Este produto já esta cadastrado!", "Erro", MessageBoxButtons.OK);
                    return;
                }
            }

            double numPreco;

            try
            {
                numPreco = double.Parse(PrecoTextBox.Text.Trim());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Você tem que digitar apenas numeros no campo de Preço!", "Error", MessageBoxButtons.OK);
                return;
            }

            Produto produto = new Produto(id, NomeTextBox.Text.Trim().ToUpper(), MarcaTextBox.Text.Trim().ToUpper(), DescricaoTextBox.Text.Trim().ToUpper(), secaoRepo.getIdByName(secaoSelecionada),numPreco, 0, Global.funcionarioLogado, DateTime.Today, DateTime.Today, true);
            secaoRepo.IncrementarQuantidadeSecao(secaoRepo.getIdByName(secaoSelecionada));
            produtosModal.Add(produto);
            repository.Add(produto);
            Logs log = new Logs(DateTime.UtcNow, Global.funcionarioLogado, "PRODUTO", produto.id, "PRODUTO CADASTRADO");
            logs.Add(log);

            this.DialogResult = DialogResult.OK;    
            this.Close();
        }

        private void ProductRegisterPage_Load(object sender, EventArgs e)
        {

        }
    }
}
