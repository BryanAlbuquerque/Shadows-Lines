using ShadowLines.Classes;
using ShadowLines.Design;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class Menu01 : Form
    {

        private PainelAgendamentos painelAgendamentos;
        private Panel painelAgendamentosUI;
        public Menu01()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AlternarCamposAgendamento(bool visivel)
        {
            lblTitulo.Visible = visivel;
            lblCliente.Visible = visivel;
            txtClienteID.Visible = visivel;

            lblData.Visible = visivel;
            txtData.Visible = visivel;

            lblServico.Visible = visivel;
            txtServico.Visible = visivel;

            lblFuncionario.Visible = visivel;
            txtFuncionarioID.Visible = visivel;

            lblValor.Visible = visivel;
            txtValor.Visible = visivel;

            lblPagamento.Visible = visivel;
            txtPagamento.Visible = visivel;

            btnAgendar.Visible = visivel;

            lblDesign.Visible = visivel;
            lblCancelar.Visible = visivel;
        }

        private void Menu01_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToString();

            painelAgendamentos = new PainelAgendamentos();
            painelAgendamentosUI = painelAgendamentos.CriarPainel();
            this.Controls.Add(painelAgendamentosUI);

            // mostra painel de agendamentos e esconde os campos de cadastro
            painelAgendamentosUI.Visible = true;
            AlternarCamposAgendamento(false);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            painelAgendamentosUI.Visible = false; // esconde o painel com agendamentos
            AlternarCamposAgendamento(true);      // mostra os campos para novo agendamento
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                int clientId = int.Parse(txtClienteID.Text);
                int employeeId = int.Parse(txtFuncionarioID.Text);
                DateTime dataHora = DateTime.Parse(txtData.Text);
                string servico = txtServico.Text;
                decimal valor = decimal.Parse(txtValor.Text);
                string pagamento = txtPagamento.Text;

                var novoAgendamento = new FazerAgendamento
                    (clientId, dataHora, servico, employeeId, valor, pagamento);
                novoAgendamento.RegisterAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            AlternarCamposAgendamento(false);
            painelAgendamentosUI.Visible = true;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
