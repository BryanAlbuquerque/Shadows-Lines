using ShadowLines.Classes;
using ShadowLines.Design;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ShadowLines.Forms
{
    public partial class Menu01 : Form
    {

        private PainelAgendamentos painelAgendamentos;
        private Panel painelAgendamentosUI;

        private PainelLucroDiario painelLucroDiario;
        private Panel paineLucroDiarioUI;

        public Menu01()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AlternarCamposAgendamento(bool visivel)
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

        }
        private void Menu01_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Bem-vindo, {SessaoUsuarioModel.NomeUsuario}!";
            txtData.Text = DateTime.Now.ToString();

            //Adiciona o painel de agendamentos ao formulário
            painelAgendamentos = new PainelAgendamentos();
            painelAgendamentosUI = painelAgendamentos.CriarPainel();
            this.Controls.Add(painelAgendamentosUI);

            //Adiciona o painel de lucro diário ao formulário
            painelLucroDiario = new PainelLucroDiario();
            paineLucroDiarioUI = painelLucroDiario.CriarPainel();
            this.Controls.Add(paineLucroDiarioUI);

            painelAgendamentosUI.Visible = true;
            paineLucroDiarioUI.Visible = true;
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
            painelAgendamentosUI.Visible = false;
            paineLucroDiarioUI.Visible = false;
            Reagendamento(false);
            AlternarCamposAgendamento(true);
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

                var novoAgendamento = new FazerAgendamento
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
            AlternarCamposAgendamento(false);
            Reagendamento(false);
            painelAgendamentosUI.Visible = true;
            paineLucroDiarioUI.Visible = true;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnMudanca_Click(object sender, EventArgs e)
        {
            painelAgendamentosUI.Visible = false;
            paineLucroDiarioUI.Visible = false;
            AlternarCamposAgendamento(false);
            Reagendamento(true);  
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

        private void toolServicos_Click(object sender, EventArgs e)
        {
            toolServicos.Text = "Serviços ⬇";
        }
    }
}
