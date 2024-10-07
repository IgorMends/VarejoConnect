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
    public partial class ProdutoPage : Form
    {

        Actions actions = new Actions();

        public ProdutoPage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            actions.CloseApplication();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            actions.MinimizeApplication(this);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            actions.HomePageBack(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            actions.UserChange(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientePage clientePage = new ClientePage();
            actions.ChangePage(this, clientePage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VendaPage vendaPage = new VendaPage();
            actions.ChangePage(this, vendaPage);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FuncionarioPage funcionarioPage = new FuncionarioPage();
            actions.ChangePage(this, funcionarioPage);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CaixaPage caixaPage = new CaixaPage(); 
            actions.ChangePage(this, caixaPage);    
        }
    }
}
