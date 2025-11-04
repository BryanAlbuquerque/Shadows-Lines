using ShadowLines.Classes;
using System;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text.Trim();
            string numero = txtTelefone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string endereco = txtEndereco.Text.Trim();

            if (!DateTime.TryParse(txtDataNascimento.Text, out DateTime data))
            {
                MessageBox.Show("Data inválida. Use o formato DD/MM/AAAA.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CadastrarClientes.AdicionarCliente(nome, cpf, numero, email, data, endereco))
            {
                txtNome.Clear();
                txtCpf.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
                txtDataNascimento.Clear();
                txtEndereco.Clear();
            }
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            ClientesDados dados = new ClientesDados();
            dados.Show();
            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu01 menu = new Menu01();
            menu.Show();
            this.Hide();
        }
    }
}
