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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.Logging;

namespace VarejoConnect.View.EditPage
{
    public partial class SecaoEditPage : Form
    {
        SecaoRepositorio repository = new SecaoRepositorio();
        LogsRepositorio logs = new LogsRepositorio();
        public Secao secao { get; set; }
        Actions actions = new Actions();

        public SecaoEditPage(Secao secao)
        {
            InitializeComponent();
            this.secao = secao;
            textBox1.Text = secao.nome.Trim();
            textBox2.Text = secao.descricao.Trim();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            this.secao.nome = textBox1.Text.ToUpper().Trim();
            this.secao.descricao = textBox2.Text.Trim();
            this.secao.dataAlteracao = DateTime.Today;
            this.secao.funcionarioAlteracao = Global.funcionarioLogado;
            repository.UpdateSecao(secao);
            Logs log = new Logs(DateTime.UtcNow, Global.funcionarioLogado, "SECAO", this.secao.id, "SECAO EDITADA");
            logs.Add(log);
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
