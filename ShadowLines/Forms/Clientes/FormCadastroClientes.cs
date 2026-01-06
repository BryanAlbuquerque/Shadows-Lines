using ShadowLines.Classes;
using ShadowLines.Models;
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
                ClienteModel cliente = new ClienteModel();

                cliente.Nome = txtNome.Text;
                cliente.CPF = Convert.ToInt64(txtCpf.Text.Replace(".", "").Replace("-", ""));
                cliente.Telefone = Convert.ToInt64(txtTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""));
                cliente.Email = txtEmail.Text;
                cliente.DataNascimento = DateTime.ParseExact(txtData.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                cliente.Endereco = txtEndereco.Text;

                Cliente clientes = new Cliente();
                clientes.Insert(cliente);

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
