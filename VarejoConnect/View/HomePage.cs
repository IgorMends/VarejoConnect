﻿using System;
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
using VarejoConnect.View.StandartPage;

namespace VarejoConnect.View
{
    public partial class HomePage : Form
    {

        Actions actions = new Actions();
        FuncionarioRepositorio repositoryFuncionario = new FuncionarioRepositorio();

        public HomePage()
        {
            InitializeComponent();
            if (Global.funcionarioLogado != 0)
            {
                button4.Visible = false;
            }
            DateTime dataAtual = DateTime.Today;
            string dataFormatada = dataAtual.ToString("dd/MM/yyyy");

            label3.Text = dataFormatada;
            label4.Text = repositoryFuncionario.getNameById(Global.funcionarioLogado);
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

        private void button6_Click(object sender, EventArgs e)
        {
            FornecedorPage fornecedorPage = new FornecedorPage();
            actions.ChangePage(panel2, fornecedorPage);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            SecaoPage secaoPage = new SecaoPage();
            actions.ChangePage(panel2, secaoPage);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DevolucaoPage devolucaoPage = new DevolucaoPage();
            actions.ChangePage(panel2, devolucaoPage);
        }
    }
}
