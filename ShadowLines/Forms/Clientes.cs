using ShadowLines.Classes;
using System;
using System.Numerics;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            lblNome.Visible = true;
            txtNome.Visible = true;

            lblCPF.Visible = true;
            txtCPF.Visible = true;

            lblTelefone.Visible = true;
            txtTelefone.Visible = true;

            lblEmail.Visible = true;
            txtEmail.Visible = true;

            lblData.Visible = true;
            txtData.Visible = true;

            lblEnd.Visible = true;
            txtEnd.Visible = true;

            btnEnviar.Visible = true;   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string name = txtNome.Text;
            string cpf = txtCPF.Text.Trim();
            string number = txtTelefone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string adress = txtEnd.Text.Trim();

            if (!DateTime.TryParse(txtData.Text, out DateTime date))
            {
                MessageBox.Show("Data inválida. Use o formato DD/MM/AAAA.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Costumers.AddCustomer(name, cpf, number, email, date, adress);

            txtNome.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtData.Clear();
            txtEnd.Clear();

        }

        private void btnDados_Click_1(object sender, EventArgs e)
        {
            ClientesDados clientesDados = new ClientesDados();
            clientesDados.Show();
            this.Hide();
        }
    }
}
