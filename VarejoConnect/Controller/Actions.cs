using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarejoConnect.View;

namespace VarejoConnect.Controller
{
    public class Actions
    {
        public Actions()
        {

        }

        public void CloseApplication()
        {
            DialogResult resultado = MessageBox.Show("Você deseja fechar o programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void MinimizeApplication(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        public void UserChange(Form form)
        {
            DialogResult resultado = MessageBox.Show("Você deseja trocar o Usuário? Ao confirmar você pode perder os dados desta pagina", "Confirmação"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                form.Hide();
                LoginPage form1 = new LoginPage();
                form1.Show();
            }
        }

        public void ChangePage(Panel panel, Form nextPage)
        {
            nextPage.TopLevel = false;
            panel.Controls.Add(nextPage);  
            nextPage.BringToFront();
            nextPage.Show();

        }

        public bool verifyBlanksTextboxes(List<string> textBoxes)
        {
            foreach (var text in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    MessageBox.Show("Nenhum campo pode estar vazio.", "Erro", MessageBoxButtons.OK);
                    return true;
                }                
            }
            return false;
        }

        public bool validarCPF(string cpf)
        {
            if (cpf.Length != 11)
                return false;

            if (new string(cpf[0], cpf.Length) == cpf)
                return false;

            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (cpf[i] - '0') * multiplicador1[i];

            int resto = soma % 11;
            int digito1 = (resto < 2) ? 0 : 11 - resto;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (cpf[i] - '0') * multiplicador2[i];

            resto = soma % 11;
            int digito2 = (resto < 2) ? 0 : 11 - resto;

            return cpf[9] - '0' == digito1 && cpf[10] - '0' == digito2;
        }

        public bool validarCNPJ(string cnpj)
        {
            if (cnpj.Length != 14)
                return false;

            if (new string(cnpj[0], cnpj.Length) == cnpj)
                return false;

            int[] multiplicador1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma = 0;
            for (int i = 0; i < 12; i++)
                soma += (cnpj[i] - '0') * multiplicador1[i];

            int resto = soma % 11;
            int digito1 = (resto < 2) ? 0 : 11 - resto;

            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += (cnpj[i] - '0') * multiplicador2[i];

            resto = soma % 11;
            int digito2 = (resto < 2) ? 0 : 11 - resto;

            return cnpj[12] - '0' == digito1 && cnpj[13] - '0' == digito2;
        }
    }
}
