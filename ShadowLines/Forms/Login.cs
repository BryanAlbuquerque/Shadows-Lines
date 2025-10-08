using ShadowLines.Classes;
using ShadowLines.Forms;
using System;
using System.Windows.Forms;

namespace ShadowLines
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            var fundo = new CustomBackgroundPanel();
            this.Controls.Add(fundo);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            int password = int.Parse(txtPassword.Text);

            Users user = new Users(name, password);

            int accessLevel = user.AuthenticateUser(name, password);

            if (accessLevel == 1)
            {
                MessageBox.Show("Login realizado com sucesso!");
                Menu01 menu = new Menu01();
                menu.Show();
                this.Hide();
            }
            else if(accessLevel == 2)
            {
                MessageBox.Show("Login realizado com sucesso!");
                Menu02 menu = new Menu02();
                menu.Show();
                this.Hide();
            }
            else if (accessLevel == 3)
            {
                MessageBox.Show("Login realizado com sucesso!");
                Menu03 menu = new Menu03();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}