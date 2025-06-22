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
using Microsoft.VisualBasic.Logging;

namespace VarejoConnect.View.RegisterPage
{
    public partial class SupplierRegisterPage : Form
    {

        FornecedorRepositorio repository = new FornecedorRepositorio();
        public BindingList<Fornecedor> fornecedoresModal = new BindingList<Fornecedor>();
        LogsRepositorio logs = new LogsRepositorio();
        List<string> textBoxes = new List<string>();
        Actions actions = new Actions();
        int id;

        public SupplierRegisterPage(BindingList<Fornecedor> fornecedoresList)
        {
            fornecedoresModal = fornecedoresList;
            id = repository.getHighestId() + 1;
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
           

            textBoxes.Add(FornecedorName.Text);
            textBoxes.Add(FornecedorDoc.Text);
            textBoxes.Add(textBox1.Text);
            textBoxes.Add(FornecedorNum.Text);


            bool isblank = actions.verifyBlanksTextboxes(textBoxes);

            if (isblank)
            {
                return;
            }


            foreach (var text in fornecedoresModal)
            {
                if (text.nome.Equals(FornecedorName.Text))
                {
                    MessageBox.Show("Este fornecedor já esta cadastrado!", "Erro", MessageBoxButtons.OK);
                    return;
                }
            }

            long numDoc;
            long numTel;


            try
            {
                numTel = long.Parse(FornecedorNum.Text.Trim());
                if (numTel.ToString().Length != 11)
                {
                    MessageBox.Show("O campo de telefone precisa ter 11 numeros, incluindo DDD!");
                    return;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Você tem que digitar apenas numeros no campo de Telefone", "Error", MessageBoxButtons.OK);
                return;
            }

            try
            {
                string documento = FornecedorDoc.Text.Trim();
                string telefone = FornecedorNum.Text.Trim();

                if (!long.TryParse(documento, out numDoc))
                {
                    MessageBox.Show("Você deve digitar apenas números no campo de documento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (TipoDropBox.Text == "FÍSICA")
                {
                    if (documento.Length != 11)
                    {
                        MessageBox.Show("O campo de documento precisa ter 11 números, pois é CPF!");
                        return;
                    }

                    if (!actions.validarCPF(documento))
                    {
                        MessageBox.Show("CPF inválido!");
                        return;
                    }
                }
                else if (TipoDropBox.Text == "JURÍDICA")
                {
                    if (documento.Length != 14)
                    {
                        MessageBox.Show("O campo de documento precisa ter 14 números, pois é CNPJ!");
                        return;
                    }

                    if (!actions.validarCNPJ(documento))
                    {
                        MessageBox.Show("CNPJ inválido!");
                        return;
                    }
                }

                if (!long.TryParse(telefone, out numTel))
                {
                    MessageBox.Show("Você deve digitar apenas números no campo de telefone.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fornecedor fornecedor = new Fornecedor(this.id, FornecedorName.Text.Trim().ToUpper(), textBox1.Text.Trim().ToUpper(), FornecedorDoc.Text.Trim(), FornecedorNum.Text.Trim(), Global.funcionarioLogado, DateTime.Today, DateTime.Today, true);
            repository.Add(fornecedor);
            fornecedoresModal.Add(fornecedor);
            Logs log = new Logs(DateTime.UtcNow, Global.funcionarioLogado, "FORNECEDOR", fornecedor.id, "FORNECEDOR CADASTRADO");
            logs.Add(log);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EmpresaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmpresaBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
