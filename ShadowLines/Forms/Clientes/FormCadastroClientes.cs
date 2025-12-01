using ShadowLines.Classes;
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class FormCadastroClientes : Form
    {
        public FormCadastroClientes()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void Salvar()
        {
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text)
                    || string.IsNullOrEmpty(txtCpf.Text)
                    || string.IsNullOrEmpty(txtTelefone.Text)
                    || string.IsNullOrEmpty(txtEmail.Text)
                    || string.IsNullOrEmpty(txtData.Text)
                    || string.IsNullOrEmpty(txtEndereco.Text))
                {
                    MessageBox.Show("Erro existem espaços em branco!");
                    return;
                }
                Cliente clientes = new Cliente();

                clientes.Nome_Completo = txtNome.Text;
                clientes.CPF = Convert.ToInt64(txtCpf.Text.Replace(".", "").Replace("-", ""));
                clientes.Telefone = Convert.ToInt64(txtTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""));
                clientes.Email = txtEmail.Text;
                clientes.Data_Nascimento = DateTime.ParseExact(txtData.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                clientes.Endereco = txtEndereco.Text;

                clientes.Insert();

                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ocorreu um erro! {ex}");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
