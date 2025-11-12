using ShadowLines.Classes;
using ShadowLines.Design;
using System;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class Menu01 : Form
    {
        private Panel painelAgendamentosUI;
        private Panel painelCanceladosDiaUI;
        private Panel painelTotalAgendamentosUI;
        private Panel painelValorTotalDiarioUI;
        public Menu01()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            painelAgendamentosUI = new PainelAgendamentosUI().CriarPainel();
            painelCanceladosDiaUI = new PainelCanceladosDiaUI().CriarPainel();
            painelTotalAgendamentosUI = new PainelTotalAgendamentosUI().CriarPainel();
            painelValorTotalDiarioUI = new PainelValorTotalDiarioUI().CriarPainel();

            this.Controls.Add(painelAgendamentosUI);
            this.Controls.Add(painelCanceladosDiaUI);
            this.Controls.Add(painelTotalAgendamentosUI);
            this.Controls.Add(painelValorTotalDiarioUI);
        }

        private void Agendamento(bool visivel)
        {
            //Novo Agendamento
            lblTitulo.Visible = visivel;
            lblCliente.Visible = visivel;
            txtClienteID.Visible = visivel;

            lblData.Visible = visivel;
            txtData.Visible = visivel;

            menuStrip.Visible = visivel;
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

        public void Reagendamento(bool visivel)
        {
            //Reagendamento
            lblTitulo2.Visible = visivel;
            lblClient.Visible = visivel;
            txtCliente.Visible = visivel;

            lblMudarData.Visible = visivel;
            txtMudarData.Visible = visivel;

            btnReagendar.Visible = visivel;

            lblDesign.Visible = visivel;
            lblCancelar.Visible = visivel;
        }

        public void Interface(bool visivel)
        {
            painelAgendamentosUI.Visible = visivel;
            painelCanceladosDiaUI.Visible = visivel;
            painelTotalAgendamentosUI.Visible = visivel;
            painelValorTotalDiarioUI.Visible = visivel;

        }

        private void Menu01_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Bem-vindo, {SessaoUsuarioModel.NomeUsuario}!";
            txtData.Text = DateTime.Now.ToString();
            txtMudarData.Text = DateTime.Now.ToString();

            Agendamento(false);
            Reagendamento(false);
            Interface(true);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            Interface(false);
            Reagendamento(false);
            Agendamento(true);

        }
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                int clientId = int.Parse(txtClienteID.Text);
                int funcionarioId = int.Parse(txtFuncionarioID.Text);
                DateTime dataHora = DateTime.Parse(txtData.Text);
                string servico = txtServico.Text;
                decimal valor = decimal.Parse(txtValor.Text);
                string pagamento = txtPagamento.Text;

                Agendamento novoAgendamento = new Agendamento
                    (clientId, dataHora, servico, funcionarioId, valor, pagamento);
                novoAgendamento.RegistrarAgendamento();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            Interface(true);
            Agendamento(false);
            Reagendamento(false);
        }

        private void toolServicos_Click(object sender, EventArgs e)
        {
            toolServicos.Text = "Serviços ⬇";
        }

        private void TattoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtServico.Text = "Tatto";
            txtValor.Text = "250";
            toolServicos.Text = "Serviços ➜";

        }

        private void remoçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtServico.Text = "Remoção";
            txtValor.Text = "500";
            toolServicos.Text = "Serviços ➜";

        }

        private void reconstruçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtServico.Text = "Reconstrução";
            txtValor.Text = "150";
            toolServicos.Text = "Serviços ➜";

        }

        private void coberturaDeTatuagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtServico.Text = "Cobertura de Tatuagem";
            txtValor.Text = "200";
            toolServicos.Text = "Serviços ➜";

        }

        private void consultoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtServico.Text = "Consultoria";
            txtValor.Text = "50";
            toolServicos.Text = "Serviços ➜";

        }

        private void tatuagemPersonalizadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtServico.Text = "Tatuagem Personalizada";
            txtValor.Text = "500";
            toolServicos.Text = "Serviços ➜";
        }

        private void btnReagendamento_Click(object sender, EventArgs e)
        {
            Interface(false);
            Agendamento(false);
            Reagendamento(true);
        }

        private void btnReagendar_Click(object sender, EventArgs e)
        {
            string clienteId = txtCliente.Text;
            DateTime novaData = DateTime.Parse(txtMudarData.Text);

            var reagendamento = new Reagendamento();
            reagendamento.AlterarHorario(clienteId, novaData);
        }
    }
}
