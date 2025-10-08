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
            dtData.Visible = true;

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
            string cpf = txtCPF.Text;
            int number = int.Parse(txtTelefone.Text);
            string email = txtEmail.Text;
            DateTime dateTime = DateTime.Parse(dtData.ToString());
            string adress = txtEnd.Text;

            if (string.IsNullOrEmpty(name) ||
               string.IsNullOrEmpty(email) ||
               string.IsNullOrEmpty(adress))
            {
                MessageBox.Show("Erro! Existem espaços em branco!");
            }
            else if (Costumers.AddCustomer(name, cpf, number, email, dateTime, adress))
            {
                MessageBox.Show("Entrada realizado com sucesso!");
            }
        }
    }
}
