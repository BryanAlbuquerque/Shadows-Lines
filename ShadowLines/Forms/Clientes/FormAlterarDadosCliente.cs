using ShadowLines.Classes;
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class FormAlterarDadosCliente : Form
    {
        public FormAlterarDadosCliente()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void PopularComboBoxClientes()
        {
            var lista = Cliente.Select("%");

            comboBoxClientes.DataSource = lista;
            comboBoxClientes.DisplayMember = "Nome_Completo";
            comboBoxClientes.ValueMember = "ClienteID";
            comboBoxClientes.SelectedIndex = -1;
        }

        private void FormAlterarDadosCliente_Load(object sender, EventArgs e)
        {
            PopularComboBoxClientes();
        }

        private void Salvar()
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxClientes.Text)
                    ||string.IsNullOrEmpty(txtNome.Text) 
                    ||string.IsNullOrEmpty(txtCpf.Text)
                    || string.IsNullOrEmpty(txtTelefone.Text)
                    || string.IsNullOrEmpty(txtEmail.Text)
                    || string.IsNullOrEmpty(txtData.Text)
                    || string.IsNullOrEmpty(txtEndereco.Text))
                {
                    MessageBox.Show("Erro existem espaços em branco!");
                    return;
                }
                Cliente clientes = new Cliente();

                clientes.ClienteID = Convert.ToInt32(comboBoxClientes.SelectedValue);
                clientes.Nome_Completo = txtNome.Text;
                clientes.CPF = Convert.ToInt64(txtCpf.Text.Replace(".", "").Replace("-", ""));
                clientes.Telefone = Convert.ToInt64(txtTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""));
                clientes.Email = txtEmail.Text;
                clientes.Data_Nascimento = DateTime.ParseExact(txtData.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                clientes.Endereco = txtEndereco.Text;

                clientes.Update();

                MessageBox.Show("Dados alterados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex}");

            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void comboBoxClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedIndex == -1) return;

            int id = Convert.ToInt32(comboBoxClientes.SelectedValue);
            var c = Cliente.SelectedSet(id);

            txtNome.Text = c.Nome_Completo;
            txtCpf.Text = c.CPF.ToString();
            txtTelefone.Text = c.Telefone.ToString();
            txtEmail.Text = c.Email;
            txtEndereco.Text = c.Endereco;
            txtData.Text = c.Data_Nascimento?.ToString("dd/MM/yyyy");
        }
    }
}
