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
                else if (accessLevel == 3)
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

        private void txtNomeUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 8 && tecla !=9)
            {
                e.Handled = true;
                MessageBox.Show("Apenas letras são permitidas neste campo.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}