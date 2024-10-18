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

namespace VarejoConnect.View
{
    public partial class HomePage : Form
    {

        Actions actions = new Actions();
        public HomePage()
        {
            InitializeComponent();
            DateTime dataAtual = DateTime.Today;
            string dataFormatada = dataAtual.ToString("dd/MM/yyyy");

            label3.Text = dataFormatada;
            label4.Text = "User: admin";
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            actions.CloseApplication();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            actions.MinimizeApplication(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            actions.UserChange(this);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProdutoPage produtoPage = new ProdutoPage();
            actions.ChangePage(panel2, produtoPage);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CaixaPage caixaPage = new CaixaPage();
            actions.ChangePage(panel2, caixaPage);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FuncionarioPage funcionarioPage = new FuncionarioPage();
            actions.ChangePage(panel2, funcionarioPage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VendaPage vendaPage = new VendaPage();
            actions.ChangePage(panel2, vendaPage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientePage clientePage = new ClientePage();
            actions.ChangePage(panel2, clientePage);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
