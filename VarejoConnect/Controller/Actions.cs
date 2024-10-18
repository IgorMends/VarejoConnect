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

        public void verifyBlanksTextboxes(List<string> textBoxes)
        {
            foreach (var text in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    MessageBox.Show("Nenhum campo pode estar vazio.", "Erro", MessageBoxButtons.OK);
                    return;
                }
            }
        }
    }
}
