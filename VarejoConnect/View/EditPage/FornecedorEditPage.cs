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
using VarejoConnect.Model.Repositorios;
using VarejoConnect.Model;
using Microsoft.VisualBasic.Logging;

namespace VarejoConnect.View.EditPage
{
    public partial class FornecedorEditPage : Form
    {

        FornecedorRepositorio repository = new FornecedorRepositorio();
        public Fornecedor fornecedor { get; set; }
        LogsRepositorio logs = new LogsRepositorio();
        Actions actions = new Actions();

        public FornecedorEditPage(Fornecedor fornecedor)
        {
            InitializeComponent();
            this.fornecedor = fornecedor;
            textBox1.Text = fornecedor.nome.Trim();
            textBox2.Text = fornecedor.empresa.Trim();
            textBox3.Text = fornecedor.telefone.Trim();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            this.fornecedor.nome = textBox1.Text.ToUpper().Trim();
            this.fornecedor.empresa = textBox2.Text.Trim().ToUpper();
            this.fornecedor.telefone = textBox3.Text.Trim();
            this.fornecedor.dataAlteracao = DateTime.Today;
            this.fornecedor.funcionarioAlteracao = Global.funcionarioLogado;
            repository.UpdateFornecedor(fornecedor);
            Logs log = new Logs(DateTime.UtcNow, Global.funcionarioLogado, "FORNECEDOR", fornecedor.id, "FORNECEDOR EDITADO");
            logs.Add(log);
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
