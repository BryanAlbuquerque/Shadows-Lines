using ShadowLines.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class Menu01 : Form
    {
        public Menu01()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            lblCliente.Visible = true;
            txtClienteID.Visible = true;

            lblData.Visible = true;
            txtData.Visible = true;

            lblServico.Visible = true;
            txtServico.Visible = true;

            lblFuncionario.Visible = true;
            txtFuncionarioID.Visible = true;

            lblValor.Visible = true;
            txtValor.Visible = true;

            lblPagamento.Visible = true;
            txtPagamento.Visible = true;

            btnAgendar.Visible = true;
        }

        private void btnAgendar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int clientId = int.Parse(txtClienteID.Text);
                int employeeId = int.Parse(txtFuncionarioID.Text);
                DateTime dataHora = DateTime.Parse(txtData.Text);
                string servico = txtServico.Text;
                decimal valor = decimal.Parse(txtValor.Text);
                string pagamento = txtPagamento.Text;

                var novoAgendamento = new Appointments(clientId, dataHora, servico, employeeId, valor, pagamento);
                novoAgendamento.RegisterAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void Menu01_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToString();


        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
