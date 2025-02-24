using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VarejoConnect.View.RegisterPage
{
    public partial class ClientRegisterPage : Form
    {
        public ClientRegisterPage()
        {
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


            foreach (var text in clientes)
            {
                if (text.nome.Equals(NomeTextBox.Text))
                {
                    MessageBox.Show("Este cliente já esta cadastrado!", "Erro", MessageBoxButtons.OK);
                    return;
                }
            }

            long numCPF;
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
                numCPF = long.Parse(CpfTextBox.Text.Trim());
                numTel = long.Parse(TelefoneTextBox.Text.Trim());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Você tem que digitar apenas numeros no campo de CPF", "Error", MessageBoxButtons.OK);
                return;
            }

            Cliente cliente = new Cliente(id, NomeTextBox.Text.Trim().ToUpper(), CpfTextBox.Text.Trim(), EmailTextBox.Text.Trim(), TelefoneTextBox.Text.Trim(), dataAtual, dataAtual, Global.funcionarioLogado);
            clientes.Add(cliente);
            repository.Add(cliente);
        }
    }
}
