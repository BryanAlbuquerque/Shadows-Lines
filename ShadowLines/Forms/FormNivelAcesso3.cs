using ShadowLines.Classes;
using ShadowLines.UI;
using System.Windows.Forms;
using ShadowLines.Forms.Servicos;
using ShadowLines.Forms.FormsMenu2;

namespace ShadowLines.Forms
{
    public partial class FormNivelAcesso3 : Form
    {
        private Panel painelAgendamentosUI;
        private Panel painelCanceladosDiaUI;
        private Panel painelTotalAgendamentosUI;
        private Panel painelValorTotalDiarioUI;
        public FormNivelAcesso3()
        {
            InitializeComponent();

            painelAgendamentosUI = new PainelAgendamentosUI().CriarPainel();
            painelCanceladosDiaUI = new PainelCanceladosDiaUI().CriarPainel();
            painelTotalAgendamentosUI = new PainelTotalAgendamentosUI().CriarPainel();
            painelValorTotalDiarioUI = new PainelValorTotalDiarioUI().CriarPainel();

            this.Controls.Add(painelAgendamentosUI);
            this.Controls.Add(painelCanceladosDiaUI);
            this.Controls.Add(painelTotalAgendamentosUI);
            this.Controls.Add(painelValorTotalDiarioUI);
        }
        public void Interface(bool visivel)
        {
            painelAgendamentosUI.Visible = visivel;
            painelCanceladosDiaUI.Visible = visivel;
            painelTotalAgendamentosUI.Visible = visivel;
            painelValorTotalDiarioUI.Visible = visivel;

            iconButtonAtualizar.Visible = visivel;
        }

        private void RecarregarPaineis()
        {
            // Remove os antigos
            this.Controls.Remove(painelAgendamentosUI);
            this.Controls.Remove(painelCanceladosDiaUI);
            this.Controls.Remove(painelTotalAgendamentosUI);
            this.Controls.Remove(painelValorTotalDiarioUI);

            // Cria painéis novos
            painelAgendamentosUI = new PainelAgendamentosUI().CriarPainel();
            painelCanceladosDiaUI = new PainelCanceladosDiaUI().CriarPainel();
            painelTotalAgendamentosUI = new PainelTotalAgendamentosUI().CriarPainel();
            painelValorTotalDiarioUI = new PainelValorTotalDiarioUI().CriarPainel();

            // Adiciona novamente
            this.Controls.Add(painelAgendamentosUI);
            this.Controls.Add(painelCanceladosDiaUI);
            this.Controls.Add(painelTotalAgendamentosUI);
            this.Controls.Add(painelValorTotalDiarioUI);

            // Atualiza visualmente
            painelAgendamentosUI.Refresh();
            painelCanceladosDiaUI.Refresh();
            painelTotalAgendamentosUI.Refresh();
            painelValorTotalDiarioUI.Refresh();
        }

        private void btnAgendamentos_Click(object sender, System.EventArgs e)
        {
            FormAgendamentoNivelAcesso2 form = new FormAgendamentoNivelAcesso2();
            form.Show();
            this.Hide();
        }

        private void FormMenu2_Load(object sender, System.EventArgs e)
        {
            lblUsuario.Text = $"Bem-vindo, {SessaoUsuarioModel.NomeUsuario}!";
            Interface(true);
        }

        private void iconButtonAtualizar_Click(object sender, System.EventArgs e)
        {
            RecarregarPaineis();
        }

        private void btnDesconectar_Click(object sender, System.EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void btnDados_Click(object sender, System.EventArgs e)
        {
            FormDadosAgendamentos dadosAgendamentos = new FormDadosAgendamentos();
            dadosAgendamentos.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, System.EventArgs e)
        {
            FormClientes clientes = new FormClientes();
            clientes.Show();
            this.Hide();
        }

        private void bntFuncionarios_Click(object sender, System.EventArgs e)
        {
            FormFuncionarios funcionarios = new FormFuncionarios();
            funcionarios.Show();
            this.Hide();
        }

        private void btnRelatorios_Click(object sender, System.EventArgs e)
        {
            FormRelatorios relatorios = new FormRelatorios();
            relatorios.Show();
            this.Hide();
        }

        private void btnServicos_Click(object sender, System.EventArgs e)
        {
            FormServicos servicos = new FormServicos();
            servicos.Show();
            this.Hide();
        }
    }
}
