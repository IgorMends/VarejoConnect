using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarejoConnect.Model.Repositorios;

namespace VarejoConnect.View.StandartPage
{
    public partial class DevolucaoPage : Form
    {

        FuncionarioRepositorio funcionarioRepositorio = new FuncionarioRepositorio();

        public DevolucaoPage()
        {
            InitializeComponent();
        }

        public void ConfigureDatagrid()
        {
            label11.Text = funcionarioRepositorio.getNameById(Global.funcionarioLogado).ToUpper();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
