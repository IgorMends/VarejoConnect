using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VarejoConnect.View.OthersPage
{
    public partial class QuantidadeProdutoPage : Form
    {

        int quantidadeTotal;
        public int quantidadeInformada;
        public QuantidadeProdutoPage(int quantidadeTotal)
        {
            InitializeComponent();
            label11.Text = quantidadeTotal.ToString();
            this.quantidadeTotal = quantidadeTotal;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                quantidadeInformada = int.Parse(textBox1.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("A quantidade tem que ser digitada em numeros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (quantidadeInformada <= 0 || quantidadeInformada > quantidadeTotal)
            {
                MessageBox.Show("Digite uma quantidade valida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
