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
                Form1 form1 = new Form1();
                form1.Show();
            }
        }

        public void ChangePage(Form actualPage, Form nextPage)
        {
            actualPage.Hide();
            nextPage.Show();
        }

        public void HomePageBack(Form form)
        {
            DialogResult resultado = MessageBox.Show("Você deseja voltar a página inicial? Ao confirmar você perderá o dados desta página caso não tenha salvo!", "Confirmação"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                form.Hide();
                HomePage homePage = new HomePage();
                homePage.Show();
            }
        }
    }
}
