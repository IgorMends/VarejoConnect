using VarejoConnect.View;

namespace VarejoConnect
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals("admin") && textBox2.Text.Equals("admin"))
            {
                this.Hide();
                HomePage adminHomePage = new HomePage();
                adminHomePage.Show();
            }
        }
    }
}
