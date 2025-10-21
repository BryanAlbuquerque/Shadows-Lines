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

            StartPosition = FormStartPosition.CenterScreen;

            var fundo = new CustomBackgroundPanel();
            this.Controls.Add(fundo);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var user = new Users(username, password);

            string erro = user.ValidateFields();
            if (erro != null)
            {
                MessageBox.Show(erro, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int accessLevel = user.AuthenticateUser();

                if (accessLevel == 1)
                {
                    MessageBox.Show("Login realizado com sucesso!");
                    Menu01 menu = new Menu01();
                    menu.Show();
                    this.Hide(); // Esconde a tela de login
                }
                else if (accessLevel == 2)
                {
                    MessageBox.Show("Login realizado com sucesso!");
                    Menu02 menu = new Menu02();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao autenticar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}