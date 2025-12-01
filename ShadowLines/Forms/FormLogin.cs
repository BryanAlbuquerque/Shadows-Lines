using ShadowLines.Classes;
using ShadowLines.Forms;
using System;
using System.Windows.Forms;

namespace ShadowLines
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            var fundo = new CustomBackgroundPanel();
            this.Controls.Add(fundo);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string NomeUsuario = txtNomeUsuario.Text;
            string SenhaId = txtSenhaId.Text;

            var usuario = new Usuarios(NomeUsuario, SenhaId);

            string erro = usuario.ValidarCampos();
            if (erro != null)
            {
                MessageBox.Show(erro, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int accessLevel = usuario.AutenticarUsuario();

                if (accessLevel == 1)
                {
                    MessageBox.Show("Login realizado com sucesso!");
                    FormMenu1 menu = new FormMenu1();
                    menu.Show();
                    this.Hide(); 
                }
                else if (accessLevel == 2)
                {
                    MessageBox.Show("Login realizado com sucesso!");
                    FormMenu2 menu = new FormMenu2();
                    menu.Show();
                    this.Hide();
                }
                else if (accessLevel == 0 || accessLevel > 2)
                {
                    MessageBox.Show("Nível de acesso não valido para login!");
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