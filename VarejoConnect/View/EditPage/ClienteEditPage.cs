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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VarejoConnect.View.EditPage
{
    public partial class ClienteEditPage : Form
    {

        ClienteRepositorio repository = new ClienteRepositorio();
        public Cliente cliente { get; set; }
        Actions actions = new Actions();

        public ClienteEditPage(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            textBox1.Text = cliente.nome.Trim();
            textBox2.Text = cliente.email.Trim();
            textBox3.Text = cliente.telefone.Trim();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            this.cliente.nome = textBox1.Text.ToUpper().Trim();
            this.cliente.email = textBox2.Text.Trim();
            this.cliente.telefone = textBox3.Text.Trim();
            this.cliente.dataAlteracao = DateTime.Today;
            this.cliente.funcionarioAlteracao = Global.funcionarioLogado;
            repository.UpdateCliente(cliente);
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
