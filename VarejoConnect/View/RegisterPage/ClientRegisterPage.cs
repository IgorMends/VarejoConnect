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
using VarejoConnect.Controller;
using VarejoConnect.Model;
using VarejoConnect.Model.Repositorios;

namespace VarejoConnect.View.RegisterPage
{
    public partial class ClientRegisterPage : Form
    {
        ClienteRepositorio repository = new ClienteRepositorio();
        public BindingList<Cliente> clientesModal = new BindingList<Cliente>();
        LogsRepositorio logs = new LogsRepositorio();
        List<string> textBoxes = new List<string>();
        Actions actions = new Actions();
        int id;

        public ClientRegisterPage(BindingList<Cliente> clientesList)
        {
            clientesModal = clientesList;
            id = repository.getHighestId() + 1;
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            textBoxes.Add(NomeTextBox.Text);
            textBoxes.Add(CpfTextBox.Text);
            textBoxes.Add(EmailTextBox.Text);
            textBoxes.Add(TelefoneTextBox.Text);

            bool isblank = actions.verifyBlanksTextboxes(textBoxes);

            if (isblank)
            {
                return;
            }


            foreach (var text in clientesModal)
            {
                if (text.nome.Equals(NomeTextBox.Text))
                {
                    MessageBox.Show("Este cliente já esta cadastrado!", "Erro", MessageBoxButtons.OK);
                    return;
                }
            }

            long numDoc;
            long numTel;


            try
            {
                numTel = long.Parse(TelefoneTextBox.Text.Trim());
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
                string documento = CpfTextBox.Text.Trim();
                string telefone = TelefoneTextBox.Text.Trim();

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

            Cliente cliente = new Cliente(this.id, NomeTextBox.Text.Trim().ToUpper(), CpfTextBox.Text.Trim(), EmailTextBox.Text.Trim(), TelefoneTextBox.Text.Trim(), DateTime.Today, DateTime.Today, Global.funcionarioLogado, true);
            repository.Add(cliente);
            clientesModal.Add(cliente);
            Logs log = new Logs(DateTime.UtcNow, Global.funcionarioLogado, "CLIENTE", cliente.id, "CLIENTE CADASTRADO");
            logs.Add(log);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ClientRegisterPage_Load(object sender, EventArgs e)
        {

        }
    }
}
