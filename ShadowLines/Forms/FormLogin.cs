using ShadowLines.Classes;
using ShadowLines.Forms;
using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

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

        private void Salvar()
        {
            if (string.IsNullOrEmpty(txtNomeUsuario.Text)
                   || string.IsNullOrEmpty(txtSenhaId.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Usuarios usuario = new Usuarios
                {
                    NomeUsuario = txtNomeUsuario.Text,
                    SenhaId = txtSenhaId.Text
                };

                int nivelAcesso = usuario.Login();

                if (nivelAcesso == 1)
                {
                    MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormNivelAcesso1 form = new FormNivelAcesso1();
                    form.Show();
                    this.Hide();
                }
                else if (nivelAcesso == 2)
                {
                    MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormNivelAcesso2 formNivelAcesso1 = new FormNivelAcesso2();
                    formNivelAcesso1.Show();
                    this.Hide();
                }
                else if (nivelAcesso == 3)
                {
                    MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormNivelAcesso3 formNivelAcesso2 = new FormNivelAcesso3();
                    formNivelAcesso2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nome de usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao conectar! Envie print ao suporte: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Salvar();

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}