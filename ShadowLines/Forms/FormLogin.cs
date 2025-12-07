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
                Usuarios usuario = new Usuarios();

                usuario.NomeUsuario = txtNomeUsuario.Text;
                usuario.SenhaId = txtSenhaId.Text;

                usuario.Login();
                MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (SessaoUsuarioModel.NivelAcesso == 1)
                {
                    FormNivelAcesso1 formNivelAcesso1 = new FormNivelAcesso1();
                    formNivelAcesso1.Show();
                    this.Hide();
                }
                else if (SessaoUsuarioModel.NivelAcesso == 2)
                {
                    FormNivelAcesso2 formNivelAcesso2 = new FormNivelAcesso2();
                    formNivelAcesso2.Show();
                    this.Hide();
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