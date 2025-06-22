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
    public partial class SectionRegisterPage : Form
    {

        SecaoRepositorio repository = new SecaoRepositorio();
        public BindingList<Secao> secoesModal = new BindingList<Secao>();
        LogsRepositorio logs = new LogsRepositorio();
        List<string> textBoxes = new List<string>();
        Actions actions = new Actions();
        int id;

        public SectionRegisterPage(BindingList<Secao> secoesList)
        {
            secoesModal = secoesList;
            id = repository.getHighestId() + 1;
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            textBoxes.Add(NomeSectionTextBox.Text);
            textBoxes.Add(DescriptionSectionTextBox.Text);

            bool isblank = actions.verifyBlanksTextboxes(textBoxes);

            if (isblank)
            {
                return;
            }


            foreach (var text in secoesModal)
            {
                if (text.nome.Equals(NomeSectionTextBox.Text))
                {
                    MessageBox.Show("Esta seção já esta cadastrada!", "Erro", MessageBoxButtons.OK);
                    return;
                }
            }

            

            Secao secao = new Secao(this.id, NomeSectionTextBox.Text.Trim().ToUpper(), DescriptionSectionTextBox.Text.Trim(), 0, Global.funcionarioLogado, DateTime.Today, DateTime.Today, true);
            repository.Add(secao);
            secoesModal.Add(secao);
            Logs log = new Logs(DateTime.UtcNow, Global.funcionarioLogado, "SECAO", secao.id, "CADASTRO DE SECAO");
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
